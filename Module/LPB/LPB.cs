using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProVIFM;
using ProVLib;
using KCSDK;
using CommonObj;
using PaeLibGeneral;
using PaeLibProVSDKEx;

namespace LPB
{
    /// <summary>
    /// 資料讀取的方式: 
    /// 1. PReadValue => 產品相關資料的讀取
    /// 2. OReadValue => 通用設定資料的讀取
    /// 3. SReadValue => 模組設定資料的讀取
    /// 
    /// Log輸出的方式:
    /// 1. public void LogSay(EnLoggerType mType, params string[] msg);
    ///    LogMode=0 msg固定取用陣列第一項目值
    ///    LogMode=1 msg依類型不同取用項目值
    ///    Type="OP" 取用陣列第一項目值
    ///    Type="Alarm" [0]:模組名稱 [1]:錯誤代碼 [2]:錯誤內容 [3]:持續時間 (*由ShowAlarm函式處理)
    ///    Type="Comm" [0]:模組名稱 [1]:記錄內容
    ///    Type="SPC" [0~N]:欄位值
    /// 
    /// Alarm輸出的方式: 
    /// 1. public void ShowAlarm(string AlarmLevel, int ErrorCode);
    /// 2. public void ShowAlarm(string AlarmLevel, int ErrorCode, params object[] args);
    /// AlarmLevel: "E/e","W/w","I/i"
    /// 
    /// 常用判斷:
    /// 1. IsSimulation() => 是否為模擬狀態 0:實機 1:亂數模擬 2:純模擬
    /// 2. mCanHome => 是否可歸零
    /// 3. mHomeOk => 歸零完畢時，需設定此變數為 true
    /// 4. mLotend => 是否可結批
    /// 5. mLotendOk => 結批完畢時，需設定此變數為 true
    /// 
    /// 常用函式:
    /// 1. SetCanLotEnd: 通知模組可以進行結批
    /// 2. GetLotEndOk: 取得模組是否結批完成
    /// 3. GetLotend: 取得模組是否正在進行結批
    /// 4. SetLotEndOk: 設定模組結批完成
    /// 5. IsSimulation: 取得模組是否在模擬狀態
    /// 6. SetCanHome: 通知模組可以進行歸零
    /// 7. GetHomeOk: 取得模組歸零結果
    /// 8. SReadValue: 取得模組內部指定欄位資料
    /// 9. SSetValue: 設定模組內部指定欄位資料
    /// 10. SaveFile: 通知模組進行資料存檔
    /// 11. PReadValue: 取得產品設定指定表格/欄位資料
    /// 12. OReadValue: 取得通用設定指定欄位資料
    /// 13. GetUseModule: 取得模組開關設定
    /// 14. GetModuleID: 取得模組編號設定
    /// 
    /// 常用資料變數:
    /// 1. PackageName: 目前模組正在使用的產品名稱
    /// 2. IsAutoMode: 模組是否處理Auto模式
    /// 3. RunTM: MyTimer型別，可用於Auto流程
    /// 4. HomeTM: MyTimer型別，可用於Home流程
    /// </summary>
    /// 

    public enum eCylinder
    {
        ClampY,
        ClampZ,
        DoorY,
        DoorZ,
        Table,
        Convex,
        Latch,
        Inch8CstClamp,
        Mapping,
    }

    public enum LP_Type
    {
        Unknow = 0,
        Foup = 1,
        Cassette = 2,
    }

    public partial class LPB : BaseModuleInterface
    {
        public class LightData
        {
            public LP_Light Light;
            public OutBit ob_Light;
            public bool bBlink;
            public bool bOn;
            public bool bOldState;
        }

        #region IO
        private Cylinder Cylinder_ClampY;
        private Cylinder Cylinder_ClampZ;
        private Cylinder Cylinder_DoorY;
        private Cylinder Cylinder_DoorZ;
        private Cylinder Cylinder_Table;
        private Cylinder Cylinder_Convex;
        private Cylinder Cylinder_Latch;
        private Cylinder Cylinder_Inch8CstClamp;
        private Cylinder Cylinder_Mapping;

        private Nozzle Nozzle_DoorVaccum;

        private DigitalInput DI_ConvexDetect;
        private DigitalInput DI_CoverDetect;
        private DigitalInput DI_ArmDetect;
        //private DigitalInput DI_Inch8_Detect;
        //private DigitalInput DI_Inch8_2_Detect;
        //private DigitalInput DI_Foup_Detect;
        //private DigitalInput DI_Cassette_Detect;
        private DigitalInput[] DI_PlaceDetect;

        private List<LightData> Indicator_Lights;
        #endregion

        #region 設定參數
        private struct BasicValue
        {
            public bool UseLogFlowChartRunTime;
            public bool bIsSimulation;

            public int CylinderActionDelayTime;
            public int CylinderActionTimeout;
            public int CylinderDoorZActionDelayTime;
            public int CylinderDoorZActionTimeout;
            public int VacuumActionDelayTime;
            public int VacuumActionTimeout;
        }
        private BasicValue BValue;

        private struct PackageValue
        {

        }
        private PackageValue PValue;

        private struct OptionValue
        {
            public bool DryRun;
        }

        private OptionValue OValue;
        #endregion

        #region 其他表單處理相關變數
        private Thread DialogFormThread = null;                             // 其他表單處理專用執行緒
        private bool StopDialogFormThread = true;                           // 其他表單處理專用執行緒運行旗標

        private bool ShowInputCassetteIDForm = false;
        private DialogResult InputCassetteIDFormRturn = DialogResult.None;
        #endregion

        #region 模組變數
        private FLP_ActionMode _FLP_ActionMode;
        private JActionFlag Flag_FLP_Action;
        private JActionFlag Flag_Scan_Action;

        private LP_Type MyLP_Type;
        private bool bCanLock;
        private bool bCanUnlock;
        private bool bManualStart;
        private bool bManualCanRun;
        private bool bTimeReset;
        private string sFLPID;

        private List<Button> list_Button = new List<Button>();
        private List<int> SensorOn = new List<int>();
        private List<int> SensorOff = new List<int>();
        private bool bScanSingnalChange = false;
        private SlotState[] MyFoupSlotState;
        #endregion

        public LPB()
        {
            InitializeComponent();

            CreateComponentList();
            DialogFormThread = new Thread(PPFAProcess);
            StopDialogFormThread = false;
            DialogFormThread.Start();

            IntPtr hwnd = this.Handle;
            this.Location = new Point(0, 0);
            this.Dock = DockStyle.Fill;
            this.Refresh();
        }

        #region 繼承函數

        //模組解構使用
        public override void DisposeTH()
        {
            StopDialogFormThread = true;
            DialogFormThread.Join();
            base.DisposeTH();
        }

        //程式初始化
        public override void Initial()
        {
            DataReset();
            InitialNozzle();
            InitialCylinder();
            InitialDigitalInput();

            Flag_FLP_Action = new JActionFlag();
            Flag_Scan_Action = new JActionFlag();

            if (true)
            {
                btn_Convex_SW.Visible = false;  //AWEX12000 無此氣缸隱藏此Button
            }

            list_Button = FindButtons(this);
        }

        //持續偵測函數
        public override void AlwaysRun()
        {
            if (DI_ArmDetect != null && DI_ArmDetect.ValueOff)
            {
                if (MT_DoorZ != null)
                {
                    if (MT_DoorZ.Busy())
                    {
                        MT_DoorZ.FastStop();
                        ShowModuleAlarm("E", 8);//偵測到手臂，禁止開門Z軸上升
                    }
                }
                //if (Cylinder_DoorZ != null)
                //{
                //    if (Cylinder_DoorZ.OnSensorValue == false && Cylinder_DoorZ.OffSensorValue == false)
                //    {
                //        ob_DoorZ_Up.Value = false;
                //        ob_DoorZ_Down.Value = false;
                //        ShowModuleAlarm("E", 8);//偵測到手臂，禁止開門Z軸上升
                //    }
                //}
            }
        } //持續掃描
        public override int ScanIO()
        {
            if (ib_ManualButton.Value)
                bManualStart = true;
            if (!ib_ManualButton.Value && bManualStart)
            {
                bManualStart = false;
                bManualCanRun = true;
            }

            if (Indicator_Lights != null)
            {
                try
                {
                    ThreeValued rt = GetLoadPortPlaceState();
                    switch (rt)
                    {
                        case ThreeValued.FALSE:
                            Indicator_Lights[(int)LP_Light.Placement].ob_Light.Value = false;
                            Indicator_Lights[(int)LP_Light.Presense].ob_Light.Value = false;
                            break;
                        case ThreeValued.TRUE:
                            Indicator_Lights[(int)LP_Light.Placement].ob_Light.Value = true;
                            Indicator_Lights[(int)LP_Light.Presense].ob_Light.Value = true;
                            break;
                        case ThreeValued.UNKNOWN:
                            Indicator_Lights[(int)LP_Light.Placement].ob_Light.Value = false;
                            Indicator_Lights[(int)LP_Light.Presense].ob_Light.Value = true;
                            break;
                        default:
                            break;
                    }
                }
                catch { }
            }
            return 0;
        } //掃描硬體按鈕IO

        //歸零相關函數
        public override void HomeReset()
        {
            DataReset();

            MT_DoorZ.HomeReset();

            mCanHome = false;
            mHomeOk = false;
            mLotend = false;
            mLotendOk = false;
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Reset();
            Flag_Scan_Action.Reset();
            MyLP_Type = LP_Type.Unknow;
            bCanLock = false;
            bManualCanRun = false;

            //流程重置
            FC_LOCK_START.TaskReset();
            FC_UNLOCK_START.TaskReset();
            FC_OPEN_START.TaskReset();
            FC_CLOSE_START.TaskReset();
            FC_INPUTID_START.TaskReset();
            FC_HOME_START.TaskReset();
            FC_Convex_Cylinder_START.TaskReset();//v1.0.0.3
            FC_SCAN_START.TaskReset();
            
            ResetLightSignal();

        } //歸零前的重置
        public override bool Home()
        {
            if (bTimeReset)
            {
                HomeTM.Restart();
                bTimeReset = false;
            }
            FC_HOME_START.MainRun();
            FC_CLOSE_START.MainRun();
            FC_OPEN_START.MainRun();
            FC_UNLOCK_START.MainRun();
            FC_LOCK_START.MainRun();
            FC_Convex_Cylinder_START.MainRun(); //v1.0.0.3
            FC_SCAN_START.MainRun();
            return mHomeOk;
        } //歸零

        //運轉相關函數
        public override void ServoOn()
        {
            MT_DoorZ.ServoOn(true);
        } //Motor Servo On
        public override void ServoOff()
        {
            MT_DoorZ.ServoOn(false);
        } //Motor Servo Off
        public override void RunReset() { } //運轉前初始化
        public override void Run()
        {
            if (bTimeReset)
            {
                HomeTM.Restart();
                bTimeReset = false;
            }

            FC_CLOSE_START.MainRun();
            FC_OPEN_START.MainRun();
            FC_UNLOCK_START.MainRun();
            FC_LOCK_START.MainRun();
            FC_INPUTID_START.MainRun();
            FC_Convex_Cylinder_START.MainRun(); //v1.0.0.3
            FC_SCAN_START.MainRun();
        } //運轉
        public override void SetSpeed(bool bHome = false)
        {
            int SPD = 10000;
            int ACC_MULTIPLE;// = 100000;
            int ACC_DEC = 100000;
            int SPEED_RATE = OReadValue("機台速率").ToInt();

            //=====================Elevator Motor===============================//
            if (MT_DoorZ != null)
            {

                if (!bHome)
                {
                    SPD = (SReadValue("MT_DOOR_Z_SPEED").ToInt() * SPEED_RATE) / 100;
                    ACC_MULTIPLE = SReadValue("MT_DOOR_Z_ACC_MULTIPLE").ToInt();
                    ACC_DEC = (SPD * ACC_MULTIPLE);
                }
                MT_DoorZ.SetSpeed(SPD);
                MT_DoorZ.SetAcceleration(ACC_DEC);
                MT_DoorZ.SetDeceleration(ACC_DEC);
            }
        } //速度設定

        public void SetMotorSpeed(FAO_SpeedMode mode)
        {
            int SPD = 10000;
            int ACC_MULTIPLE;// = 100000;
            int ACC_DEC = 100000;
            int SPEED_RATE = OReadValue("機台速率").ToInt();

            //=====================Elevator Motor===============================//
            if (MT_DoorZ != null)
            {
                switch (mode)
                {
                    case FAO_SpeedMode.Scan:
                        SPEED_RATE = SReadValue("MT_DOOR_Z_SCAN_RATE").ToInt();
                        SPD = (SReadValue("MT_DOOR_Z_SPEED").ToInt() * SPEED_RATE) / 100;
                        break;
                    case FAO_SpeedMode.Normal:
                        SPD = (SReadValue("MT_DOOR_Z_SPEED").ToInt() * SPEED_RATE) / 100;
                        break;
                    default:
                        break;
                }

                ACC_MULTIPLE = SReadValue("MT_DOOR_Z_ACC_MULTIPLE").ToInt();
                ACC_DEC = (SPD * ACC_MULTIPLE);

                MT_DoorZ.SetSpeed(SPD);
                MT_DoorZ.SetAcceleration(ACC_DEC);
                MT_DoorZ.SetDeceleration(ACC_DEC);
            }
        }

        //手動相關函數
        public override void ManualReset() { } //手動運行前置設定
        public override void ManualRun() { } //手動模式運行

        //停止所有馬達
        public override void StopMotor()
        {
            bTimeReset = true;
            base.StopMotor();
        }

        public override void AfterSaveParam()
        {
            LoadBasicData();
            //base.AfterSaveParam();
        }
        #endregion

        #region 私有函數
        /// <summary>
        /// 初始化Sensor Input
        /// </summary>
        private void InitialDigitalInput()
        {
            DI_ConvexDetect = new DigitalInput(ib_ConvexDetect);
            DI_ArmDetect = new DigitalInput(ib_ArmDetect);
            DI_CoverDetect = new DigitalInput(ib_CoverDetect);
            //DI_Inch8_Detect = new DigitalInput(ib_8Inch);
            //DI_Inch8_2_Detect = new DigitalInput(ib_8Inch_2);
            //DI_Foup_Detect = new DigitalInput(ib_Foup);
            //DI_Cassette_Detect = new DigitalInput(ib_Cassette);
            DI_PlaceDetect = new DigitalInput[3] { new DigitalInput(ib_PlaceDetect_Left), new DigitalInput(ib_PlaceDetect_Right), new DigitalInput(ib_PlaceDetect_Down) };

            DI_ConvexDetect.Simulation = IsSimulation() != 0;
            DI_ArmDetect.Simulation = IsSimulation() != 0;
            DI_CoverDetect.Simulation = IsSimulation() != 0;
            //DI_Foup_Detect.Simulation = IsSimulation() != 0;
            //DI_Cassette_Detect.Simulation = IsSimulation() != 0;

            foreach (DigitalInput DI_Input in DI_PlaceDetect)
            {
                DI_Input.Simulation = IsSimulation() != 0;
            }

            //順序不要動
            Indicator_Lights = new List<LightData>();
            Indicator_Lights.Add(new LightData { Light = LP_Light.Manual, ob_Light = ob_Manual_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.Auto, ob_Light = ob_Auto_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.Presense, ob_Light = ob_Presense_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.Placement, ob_Light = ob_Placement_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.ReadyToLoad, ob_Light = ob_Load_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.ReadyToUnload, ob_Light = ob_Unload_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.Alarm, ob_Light = ob_Alarm_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.Reserve, ob_Light = ob_Reserve_Light, bBlink = false, bOn = false });
            Indicator_Lights.Add(new LightData { Light = LP_Light.ManualButton, ob_Light = ob_ManualButton_Light, bBlink = false, bOn = false });
        }

        /// <summary>
        /// 初始化吸嘴
        /// </summary>
        private void InitialNozzle()
        {
            Nozzle_DoorVaccum = new Nozzle(null, null, null, ib_VaccumDetect, ob_Vaccum, ob_Destory);

            Nozzle_DoorVaccum.Simulation = IsSimulation() != 0;
        }

        /// <summary>
        /// 初始化汽缸
        /// </summary>
        private void InitialCylinder()
        {
            Cylinder_ClampY = new Cylinder(ob_ClampY_Clamp, ob_ClampY_Release, ib_ClampY_Clamp, ib_ClampY_Release, eCylinder.ClampY.ToString());
            Cylinder_ClampZ = new Cylinder(ob_ClampZ_Up, ob_ClampZ_Down, ib_ClampZ_Up, ib_ClampZ_Down, eCylinder.ClampZ.ToString());
            Cylinder_DoorY = new Cylinder(ob_DoorY_Out, ob_DoorY_Back, ib_DoorY_Out, ib_DoorY_Back, eCylinder.DoorY.ToString());
            //Cylinder_DoorZ = new Cylinder(ob_DoorZ_Up, ob_DoorZ_Down, ib_DoorZ_Up, ib_DoorZ_Down, eCylinder.DoorZ.ToString());
            Cylinder_Table = new Cylinder(ob_Table_Out, ob_Table_Back, ib_Table_Out, ib_Table_Back, eCylinder.Table.ToString());
            Cylinder_Convex = new Cylinder(ob_Convex_Out, ob_Convex_Back, ib_Convex_Out, ib_Convex_Back, eCylinder.Convex.ToString());
            Cylinder_Latch = new Cylinder(ob_Latch_Unlock, ob_Latch_Lock, ib_Latch_Unlock, ib_Latch_Lock, eCylinder.Latch.ToString());
            Cylinder_Inch8CstClamp = new Cylinder(ob_Inch8CstClamp_Lock, ob_Inch8CstClamp_Unlock, ib_Inch8CstClamp_On, ib_Inch8CstClamp_Off, eCylinder.Inch8CstClamp.ToString());
            Cylinder_Mapping = new Cylinder(OB_MappingCY_Push, OB_MappingCY_Pull, IB_MappingCY_On, IB_MappingCY_Off);

            bool bIsSimulation = IsSimulation() != 0;
            Cylinder_ClampY.Simulation = bIsSimulation;
            Cylinder_ClampZ.Simulation = bIsSimulation;
            Cylinder_DoorY.Simulation = bIsSimulation;
            //Cylinder_DoorZ.Simulation = bIsSimulation;
            Cylinder_Table.Simulation = bIsSimulation;
            Cylinder_Convex.Simulation = bIsSimulation;
            Cylinder_Latch.Simulation = bIsSimulation;
            Cylinder_Inch8CstClamp.Simulation = bIsSimulation;
            Cylinder_Mapping.Simulation = bIsSimulation;

            Cylinder_ClampY.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_ClampZ.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_DoorY.OnCylinderChange += CyActionTimeUpdete;
            //Cylinder_DoorZ.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_Table.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_Convex.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_Latch.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_Inch8CstClamp.OnCylinderChange += CyActionTimeUpdete;
            Cylinder_Mapping.OnCylinderChange += CyActionTimeUpdete;
        }

        private void CyActionTimeUpdete(string name, string time)
        {
            eCylinder eCy;

            if (Enum.TryParse(name, out eCy) == false)
                return;

            try
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    Button btn = list_Button.Find(x => x.Tag.ToString() == name);
                    if (btn != null)
                    {
                        btn.Text = "Switch(" + time + ")";
                    }
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// 尋找所有Button
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        private List<Button> FindButtons(Control parent)
        {
            List<Button> result = new List<Button>();

            foreach (Control control in parent.Controls)
            {
                if (control is Button)
                {
                    if (((Button)control).Text == "Switch")
                        result.Add((Button)control);
                }

                // 遞迴搜尋子控制項
                result.AddRange(FindButtons(control));
            }

            return result;
        }
        /// <summary>
        /// 汽缸手動開關
        /// </summary>
        /// <param name="CY"></param>
        private void CY_Switch(Cylinder CY)
        {
            bool b1 = CY.OnCtrlValue;
            //bool b2 = CY.OffCtrlValue;

            ThreeValued rt = (b1 == true) ? CY.Off() : CY.On();
        }

        /// <summary>
        /// 儲存流程花費時間
        /// </summary>
        /// <param name="FlowChart_MainRun">MainRun的流程</param>
        /// <param name="Msg">其他訊息</param>
        private void LogFlowChartRunTime(FlowChart FlowChart_MainRun, string Msg = "", bool bHome = false)
        {
            if (BValue.UseLogFlowChartRunTime)
            {
                LogRecord.LogTrace("FLP", FlowChart_MainRun, Msg, bHome);
            }
        }

        /// <summary>
        /// 檢查開門Z軸汽缸位置
        /// </summary>
        /// <param name="bUp"></param>
        /// <returns></returns>
        private bool CheckDoorZStation(bool bUp)
        {
            if (BValue.bIsSimulation)
                return true;
            if (true)
                return true;    //Z軸氣缸改馬達

            bool b1 = Cylinder_DoorZ.OnSensorValue;
            bool b2 = Cylinder_DoorZ.OffSensorValue;
            if (bUp)
            {
                if (b1 && !b2)
                    return true;
            }
            else
            {
                if (!b1 && b2)
                    return true;
            }
            return false;
        }

        #region Button
        /// <summary>
        /// 汽缸手動開關
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cylider_Switch_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            eCylinder eCY;
            Cylinder CY = null;

            if (!Enum.TryParse(btn.Tag.ToString(), out eCY))
                return;

            switch (eCY)
            {
                case eCylinder.ClampY:
                    CY = Cylinder_ClampY;
                    break;
                case eCylinder.ClampZ:
                    CY = Cylinder_ClampZ;
                    break;
                case eCylinder.DoorY:
                    CY = Cylinder_DoorY;
                    break;
                case eCylinder.DoorZ:
                    CY = Cylinder_DoorZ;
                    break;
                case eCylinder.Table:
                    CY = Cylinder_Table;
                    break;
                case eCylinder.Convex:
                    CY = Cylinder_Convex;
                    break;
                case eCylinder.Latch:
                    CY = Cylinder_Latch;
                    break;
                case eCylinder.Inch8CstClamp:
                    CY = Cylinder_Inch8CstClamp;
                    break;
                case eCylinder.Mapping:
                    CY = Cylinder_Mapping;
                    break;
            }

            if (CY != null)
                CY_Switch(CY);
        }

        #endregion
        /// <summary>
        /// 控制汽缸
        /// </summary>
        /// <param name="eCy"></param>
        /// <param name="bOn"></param>
        /// <returns></returns>
        private bool Cylinder_Ctrl(eCylinder eCy, ECylinderAction eAction)
        {
            Cylinder Cy = null;
            switch (eCy)
            {
                case eCylinder.ClampY:
                    Cy = Cylinder_ClampY;
                    break;
                case eCylinder.ClampZ:
                    Cy = Cylinder_ClampZ;
                    break;
                case eCylinder.DoorY:
                    Cy = Cylinder_DoorY;
                    break;
                case eCylinder.DoorZ:
                    Cy = Cylinder_DoorZ;
                    break;
                case eCylinder.Table:
                    Cy = Cylinder_Table;
                    break;
                case eCylinder.Convex:
                    if (true) return true;  //AWEX12000無此氣缸 直接return true;
                    Cy = Cylinder_Convex;
                    break;
                case eCylinder.Latch:
                    Cy = Cylinder_Latch;
                    break;
                case eCylinder.Inch8CstClamp:
                    Cy = Cylinder_Inch8CstClamp;
                    break;
                case eCylinder.Mapping:
                    Cy = Cylinder_Mapping;
                    break;
                default:
                    Cy = null;
                    break;
            }

            int DelayTime = 0;
            int Timeout = 0;
            if (Cy == Cylinder_DoorZ)
            {
                DelayTime = BValue.CylinderDoorZActionDelayTime;
                Timeout = BValue.CylinderDoorZActionTimeout;
            }
            else
            {
                DelayTime = BValue.CylinderActionDelayTime;
                Timeout = BValue.CylinderActionTimeout;
            }

            ThreeValued rt = ThreeValued.UNKNOWN;
            switch (eAction)
            {
                case ECylinderAction.Close:
                    rt = Cy.Off(DelayTime, Timeout);
                    break;
                case ECylinderAction.Open:
                    rt = Cy.On(DelayTime, Timeout);
                    break;
                default:
                    break;
            }

            if (rt == ThreeValued.TRUE)
            {
                return true;
            }
            else if (rt == ThreeValued.FALSE)
            {
                string sSwitch = ECylinderAction.Open.ToString();
                switch (eCy)
                {
                    case eCylinder.ClampY:
                        ShowAlarm("E", 16, sSwitch);
                        break;
                    case eCylinder.ClampZ:
                        ShowAlarm("E", 15, sSwitch);
                        break;
                    case eCylinder.DoorY:
                        ShowAlarm("E", 12, sSwitch);
                        break;
                    case eCylinder.DoorZ:
                        ShowAlarm("E", 13, sSwitch);
                        break;
                    case eCylinder.Table:
                        ShowAlarm("E", 18, sSwitch);
                        break;
                    case eCylinder.Convex:
                        ShowAlarm("E", 14, sSwitch);
                        break;
                    case eCylinder.Latch:
                        ShowAlarm("E", 17, sSwitch);
                        break;
                    default:
                        break;
                }
            }
            return false;
        }

        /// <summary>
        /// 偵測突出偵測汽缸是否安全 For WTR
        /// </summary>
        /// <param name="SW">沒有用到</param>
        /// <returns></returns>
        private bool ConvexCylinderIsSafe(bool SW)
        {
            bool b1 = Cylinder_Convex.OffSensorValue;
            bool b2 = Cylinder_Convex.OnSensorValue;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 委派 DoorZ汽缸是否安全 For WTR
        /// </summary>
        /// <param name="SW">沒有用到</param>
        /// <returns></returns>
        private bool DoorZCylinderIsSafe(bool SW)
        {
            return true;    //Z軸氣缸改馬達
            bool b1 = Cylinder_DoorZ.OffSensorValue;
            bool b2 = Cylinder_DoorZ.OnSensorValue;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            return false;
        }

        private void ResetLightSignal()
        {
            foreach (LightData LD in Indicator_Lights)
            {
                LD.bOn = false;
                LD.bBlink = false;
                LD.ob_Light.Value = false;
            }
        }

        private void PPFAProcess(object obj)
        {
            while (!StopDialogFormThread)
            {
                while (ShowInputCassetteIDForm)
                {
                    InputCassetteIDForm InputCstIDForm = new InputCassetteIDForm("LPB");
                    InputCstIDForm.ShowForm();
                    InputCassetteIDFormRturn = InputCstIDForm.GetActionResult;
                    sFLPID = InputCstIDForm.GetCstID;
                    //DataLayer.sCarrierID_1 = LPS.FoupID;//100523 ted add
                    ShowInputCassetteIDForm = false;
                    InputCstIDForm.Close();
                }

                Thread.Sleep(10);
            }
        }
        #endregion

        #region 公用函數
        /// <summary>
        /// 委派 偵測突出偵測汽缸是否安全 For WTR
        /// </summary>
        /// <returns></returns>
        public StatusDelegateCtrl GetConvexCylinderIsSafe()
        {
            return new StatusDelegateCtrl(ConvexCylinderIsSafe);
        }
        /// <summary>
        /// 委派 DoorZ汽缸是否安全 For WTR
        /// </summary>
        /// <returns></returns>
        public StatusDelegateCtrl GetDoorZCylinderIsSafe()
        {
            return new StatusDelegateCtrl(DoorZCylinderIsSafe);
        }

        public ThreeValued GetLoadPortPlaceState()
        {
            if (DI_PlaceDetect == null)
            {
                return ThreeValued.UNKNOWN;
            }

            bool bSame = false;
            for (int i = 0; i < DI_PlaceDetect.Length - 1; i++)
            {
                if (DI_PlaceDetect[i].ValueOff == DI_PlaceDetect[i + 1].ValueOff)
                    bSame = true;
                else
                {
                    bSame = false;
                    break;
                }
            }

            if (bSame)
            {
                if (DI_PlaceDetect[0].ValueOff)
                    return ThreeValued.TRUE;
                else
                    return ThreeValued.FALSE;
            }
            else
            {
                return ThreeValued.UNKNOWN;
            }
        }

        /// <summary>
        /// 取得Type(Cassette or Foup)
        /// </summary>
        /// <returns></returns>
        public LP_Type GetLoadPortType()
        {
            return LP_Type.Foup;
            //if (BValue.bIsSimulation)
            //{
            //    return LP_Type.Foup;
            //}

            //if (DI_Cassette_Detect.ValueOn == DI_Foup_Detect.ValueOn)
            //    return LP_Type.Unknow;
            //else if (DI_Cassette_Detect.ValueOn)
            //    return LP_Type.Cassette;
            //else if (DI_Foup_Detect.ValueOn)
            //    return LP_Type.Foup;
            //else
            //    return LP_Type.Unknow;
        }

        /// <summary>
        /// 設定燈號狀態
        /// </summary>
        /// <param name="Light">哪個燈</param>
        /// <param name="bOn">是否亮燈</param>
        /// <param name="bBlink">是否閃爍</param>
        public void SetLightData(LP_Light Light, LP_Light_Mode mode)
        {
            int Index = Indicator_Lights.FindIndex(x => x.Light == Light);
            switch (mode)
            {
                case LP_Light_Mode.On:
                    Indicator_Lights[Index].ob_Light.Value = true;
                    Indicator_Lights[Index].bOn = true;
                    Indicator_Lights[Index].bBlink = false;
                    break;
                case LP_Light_Mode.Blink:
                    Indicator_Lights[Index].bOn = true;
                    Indicator_Lights[Index].bBlink = true;
                    break;
                case LP_Light_Mode.Off:
                    Indicator_Lights[Index].ob_Light.Value = false;
                    Indicator_Lights[Index].bOn = false;
                    Indicator_Lights[Index].bBlink = false;
                    break;
            }
        }

        public void SetCanLock(bool b)
        {
            bCanLock = b;
        }

        public void SetCanUnlock(bool b)
        {
            bCanUnlock = b;
        }

        public void ResetManualButtonSingal()
        {
            bManualCanRun = false;
        }

        public bool GetManualButtonSingal()
        {
            return bManualCanRun;
        }

        public string GetFoupID()
        {
            return sFLPID;
        }

        public void ShowModuleAlarm(string AlarmLevel, int ErrorCode, params object[] args)
        {
            if (AlarmLevel == "E" || AlarmLevel == "e")
            {
                SetLightData(LP_Light.Alarm, LP_Light_Mode.Blink);
            }
            ShowAlarm(AlarmLevel, ErrorCode, args);
        }

        public void FlowChartRecord()
        {
            List<FlowChart> FCs = new List<FlowChart>();
            FCs.Add(FC_HOME_START);
            FCs.Add(FC_LOCK_START);
            FCs.Add(FC_UNLOCK_START);
            FCs.Add(FC_OPEN_START);
            FCs.Add(FC_CLOSE_START);
            FCs.Add(FC_INPUTID_START);
            FCs.Add(FC_Convex_Cylinder_START);
            LogRecord.FlowChartRecord("FLP", FCs);
        }

        public bool IsSafeRobotCanEnter(bool SW = true)
        {
            if (IsSimulation() != 0)
            {
                return true;
            }
            int Pos = MT_DoorZ.ReadEncPos();
            return Math.Abs(Pos - SReadValue("MotorZ_WaitPos").ToInt()) < 100;
        }

        public bool GetMotorIsOnOpenPos()
        {
            if (IsSimulation() != 0)
            {
                return true;
            }
            int pos = MT_DoorZ.ReadEncPos();
            return Math.Abs(pos - SReadValue("OpenPos").ToInt()) < 100;
        }

        public bool GetMotorZIsOnWaitPos()
        {
            if (IsSimulation() != 0)
            {
                return true;
            }
            int pos = MT_DoorZ.ReadEncPos();
            return Math.Abs(pos - SReadValue("MotorZ_WaitPos").ToInt()) < 100;
        }

        public string Get_Foup_ScanData()
        {
            string str = "";
            if (MyFoupSlotState != null)
            {
                for (int i = (MyFoupSlotState.Length - 1); i >= 0; i--)
                {
                    switch (MyFoupSlotState[i]._WaferState)
                    {
                        case WaferState.NoWafer:
                            {
                                str += "1";
                            }
                            break;

                        case WaferState.WaferDtected:
                            {
                                str += "3";
                            }
                            break;

                        case WaferState.ThicknessOverLimit:
                            {
                                str += "4";
                            }
                            break;

                        case WaferState.WaferPosError:
                            {
                                str += "5";
                            }
                            break;

                        default:
                            {
                                str += "0";
                            }
                            break;
                    }
                }
            }

            return str;
        }

        public bool GetIsDummy()
        {
            return SReadValue("Foup_WaferType").ToInt() == 1;
        }
        #endregion

        #region CommonObj
        public void LoadBasicData()
        {
            BValue.UseLogFlowChartRunTime = SReadValue("UseLogFlowChartRunTime").ToBoolean();
            BValue.bIsSimulation = IsSimulation() != 0;

            BValue.CylinderActionDelayTime = SReadValue("CylinderActionDelayTime").ToInt();
            BValue.CylinderActionTimeout = SReadValue("CylinderActionTimeout").ToInt();
            BValue.CylinderDoorZActionDelayTime = SReadValue("CylinderDoorZActionDelayTime").ToInt();
            BValue.CylinderDoorZActionTimeout = SReadValue("CylinderDoorZActionTimeout").ToInt();
            BValue.VacuumActionDelayTime = SReadValue("VacuumActionDelayTime").ToInt();
            BValue.VacuumActionTimeout = SReadValue("VacuumActionTimeout").ToInt();
            return;
        }

        public void LoadPackageData()
        {
            return;
        }

        public void LoadOptionData()
        {
            OValue.DryRun = OReadValue("DryRun").ToBoolean();
            return;
        }

        public void DataReset()
        {
            LoadBasicData();
            LoadPackageData();
            LoadOptionData();
            return;
        }

        public bool SetCommand(FLP_ActionMode Action)
        {
            if (this.GetUseModule().Equals(false))
            {
                return true;
            }

            if (!Flag_FLP_Action.IsDoing())
            {
                _FLP_ActionMode = Action;
                Flag_FLP_Action.DoIt();
                return true;
            }
            return false;
        }

        public bool GetActionResult()
        {
            if (this.GetUseModule().Equals(false))
            {
                return true;
            }

            if (Flag_FLP_Action.IsDone())
            {
                return true;
            }
            return false;
        }

        public bool IsAxisZSafe()
        {
            return true;
        }

        #endregion

        #region 汽缸安全偵測

        private bool ob_DoorZ_Up_IsSafeToAction(object sender)
        {
            //if (DI_ArmDetect.ValueOn)
            //{
            //    //if (Cylinder_DoorZ.OnSensorValue == false && Cylinder_DoorZ.OffSensorValue == false)
            //    {
            //        //ob_DoorZ_Up.Value = false;
            //        //ob_DoorZ_Down.Value = false;
            //        ShowModuleAlarm("E", 8);//偵測到手臂，禁止開門Z軸上升
            //        return false;
            //    }
            //}

            //bool b1 = Cylinder_Convex.OnSensorValue;
            //bool b2 = Cylinder_Convex.OffSensorValue;
            bool b1 = Cylinder_Mapping.OnSensorValue;
            bool b2 = Cylinder_Mapping.OffSensorValue;
            if (b1 == true || b2 == false)
            {
                ShowModuleAlarm("E", 2);  //突出偵測汽缸未收回，開門Z軸汽缸禁止上升
                return false;
            }

            bool b3 = ib_DoorY_Back.Value;
            bool b4 = ib_DoorY_Out.Value;
            if (b3 == true || b4 == false)
            {
                ShowModuleAlarm("E", 21);
                return false;
            }

            //bool b5 = MTrayData.tdLowerArm.HasBin((byte)EBinDefine.HasProduct) > 0;
            //bool b6 = MTrayData.tdUpperArm.HasBin((byte)EBinDefine.HasProduct) > 0;
            //if (b5 == true || b6 == true)
            //{
            //    ShowModuleAlarm("E", 24);
            //    return false;
            //}
            return true;
        }

        private bool ob_DoorZ_Down_IsSafeToAction(object sender)
        {
            bool b1 = ib_DoorY_Out.Value;
            bool b2 = ib_DoorY_Back.Value;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            else
            {
                ShowModuleAlarm("E", 21);
                return false;
            }
        }

        private bool ob_Convex_Out_IsSafeToAction(object sender)
        {
            if (CheckDoorZStation(false))
                return true;
            else
            {
                ShowModuleAlarm("E", 1);  //開門Z軸未下降，突出偵測汽缸禁止伸出
                return false;
            }
        }

        private bool ob_DoorY_Back_IsSafeToAction(object sender)
        {
            if (CheckDoorZStation(true))
                return true;
            else
            {
                ShowModuleAlarm("E", 3);  //開門Z軸未上升，開門Z軸禁止收回
                return false;
            }
        }


        private bool ob_ClampY_Clamp_IsSafeToAction(object sender)
        {
            bool b1 = ib_ClampZ_Up.Value;
            bool b2 = ib_ClampZ_Down.Value;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            else
            {
                ShowModuleAlarm("E", 22); //夾持Z軸未上升，夾持Y軸禁止移動
                return false;
            }
        }

        private bool ob_ClampY_Release_IsSafeToAction(object sender)
        {
            bool b1 = ib_ClampZ_Up.Value;
            bool b2 = ib_ClampZ_Down.Value;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            else
            {
                ShowModuleAlarm("E", 22); //夾持Z軸未上升，夾持Y軸禁止移動
                return false;
            }
        }

        private bool ob_Table_Back_IsSafeToAction(object sender)
        {
            bool b1 = ib_Latch_Lock.Value;
            bool b2 = ib_Latch_Unlock.Value;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            else
            {
                ShowModuleAlarm("E", 23); //Latch汽缸未上鎖，Table禁止移動
                return false;
            }
        }

        private bool ob_Table_Out_IsSafeToAction(object sender)
        {
            bool b1 = ib_Latch_Lock.Value;
            bool b2 = ib_Latch_Unlock.Value;
            if (b1 == true && b2 == false)
            {
                return true;
            }
            else
            {
                ShowModuleAlarm("E", 23); //Latch汽缸未上鎖，Table禁止移動
                return false;
            }
        }
        #endregion

        #region ======================================================== Home ================================================================
        private FlowChart.FCRESULT FC_HOME_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_WaitCmd_Run()
        {
            if (mCanHome)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CheckHasCassette_Run()
        {
            ThreeValued rt = GetLoadPortPlaceState();
            switch (rt)
            {
                case ThreeValued.TRUE:
                    LogFlowChartRunTime(FC_HOME_START);
                    return FlowChart.FCRESULT.CASE1;

                case ThreeValued.FALSE:
                    LogFlowChartRunTime(FC_HOME_START);
                    return FlowChart.FCRESULT.NEXT;

                case ThreeValued.UNKNOWN:
                    ShowAlarm("E", 7);//放置偵測異常
                    break;
            }
            LogFlowChartRunTime(FC_HOME_START);
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Home_DoLock_Run()
        {
            bool rt = SetCommand(FLP_ActionMode.Lock);
            if (rt)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_LockDone_Run()
        {
            bool rt = GetActionResult();
            if (rt)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_DoClose_Run()
        {
            bool rt = SetCommand(FLP_ActionMode.Close);
            if (rt)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CloseDone_Run()
        {
            bool rt = GetActionResult();
            if (rt)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_DoUnlock_Run()
        {
            bool rt = SetCommand(FLP_ActionMode.Unlock);
            if (rt)
            {
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_UnlockDone_Run()
        {
            bool rt = GetActionResult();
            if (rt)
            {
                mHomeOk = true;
                LogFlowChartRunTime(FC_HOME_START);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Done_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion ======================================================== Home ================================================================

        #region ======================================================== Lock ================================================================
        private FlowChart.FCRESULT FC_LOCK_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.Lock)
                {
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_LOCK_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_ClampZUp_Run()
        {
            if (Cylinder_Ctrl(eCylinder.ClampZ, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_LOCK_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_ClampYClamp_Run()
        {
            if (Cylinder_Ctrl(eCylinder.ClampY, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_LOCK_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_ClampZDown_Run()
        {
            ThreeValued rt = Cylinder_ClampZ.Off(); //要判斷兩個燈都沒亮

            if (RunTM.On(BValue.CylinderActionDelayTime))
            {
                if (BValue.bIsSimulation || OValue.DryRun)
                {
                    LogFlowChartRunTime(FC_LOCK_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }

                bool b1 = Cylinder_ClampZ.OnSensorValue;
                bool b2 = Cylinder_ClampZ.OffSensorValue;
                if (b1 == false && b2 == false)
                {
                    LogFlowChartRunTime(FC_LOCK_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (RunTM.On(BValue.CylinderActionTimeout))
            {
                RunTM.Restart();
                ShowAlarm("E", 15, "DOWN");//夾持Z軸汽缸動作逾時，{0}
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_Down_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_LOCK_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_Next_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Lock_Next_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        #endregion ======================================================== Lock ================================================================

        #region ======================================================== Unlock ================================================================
        private FlowChart.FCRESULT FC_UNLOCK_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.Unlock)
                {
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_UNLOCK_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_ClampZUp_Run()
        {
            if (Cylinder_Ctrl(eCylinder.ClampZ, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_UNLOCK_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_ClampYRelease_Run()
        {
            if (Cylinder_Ctrl(eCylinder.ClampY, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_UNLOCK_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_ClampZDown_Run()
        {
            if (Cylinder_Ctrl(eCylinder.ClampZ, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_UNLOCK_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_Done_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_UNLOCK_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_Next_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Unlock_Next_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion ======================================================== Unlock ================================================================

        #region ======================================================== Open ================================================================
        private FlowChart.FCRESULT FC_OPEN_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.Open)
                {
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_OPEN_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_CheckType_Run()
        {
            //FLP模組 暫不需分TYPE
            //MyLP_Type = GetLoadPortType();    

            //if (BValue.bIsSimulation || OValue.DryRun)
            //{
            //    MyLP_Type = LP_Type.Foup;
            //}

            //if (MyLP_Type == LP_Type.Cassette || MyLP_Type == LP_Type.Foup)
            //{
            //    LogFlowChartRunTime(FC_OPEN_START);
            //    RunTM.Restart();
            //    return FlowChart.FCRESULT.NEXT;
            //}
            //else
            //{
            //    ShowAlarm("E", 9);//LaodPort Type辨識錯誤
            //}
            //return FlowChart.FCRESULT.IDLE;
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_CheckNoCover_Run()
        {
            ThreeValued rt = DI_CoverDetect.On(100, 1000);
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (rt == ThreeValued.FALSE)
            {
                ShowAlarm("E", 6); //偵測有Cover，請將Cover移除
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_LatchKeyOff_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Latch, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_TableForward_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Table, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                //if (MyLP_Type == LP_Type.Foup)    //FLP模組 暫不需分TYPE
                //    return FlowChart.FCRESULT.CASE1;
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_VaccumOn_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued rt = Nozzle_DoorVaccum.VacuumOnAndCheck(BValue.VacuumActionDelayTime, BValue.VacuumActionTimeout);
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (rt == ThreeValued.FALSE)
            {
                ShowAlarm("E", 10);//真空吸取失敗，請檢查
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_CoverDetect_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued rt = DI_CoverDetect.Off(100, 1000);
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (rt == ThreeValued.FALSE)
            {
                ShowAlarm("E", 11);//偵測無蓋，請檢查
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_LatchKeyOn_Run()
        {
            if (RunTM.On(1000))
            {
                if (Cylinder_Ctrl(eCylinder.Latch, ECylinderAction.Open))
                {
                    LogFlowChartRunTime(FC_OPEN_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_DoorYPush_Run()
        {
            if (Cylinder_Ctrl(eCylinder.DoorY, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_FristConvexDetect_Run()
        {
            ThreeValued rt = DI_ArmDetect.On(100, 1000);
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                if (true) return FlowChart.FCRESULT.CASE1;
                return FlowChart.FCRESULT.NEXT;
            }
            else if (rt == ThreeValued.FALSE)
            {
                ShowAlarm("E", 4);//偵測Wafer突出，請檢查
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_DoorZDown_Run()
        {
            if (Cylinder_Ctrl(eCylinder.DoorZ, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_ConvexCyOn_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_2ndConvexDetect_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_OPEN_START, "DryRun");
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            //return FlowChart.FCRESULT.NEXT; //6/13 Munin
            ThreeValued rt = DI_ConvexDetect.On(100, 1000);
            //if (RunTM.On(1000))
            //{
                if (rt == ThreeValued.TRUE)         //橘色燈
                {
                    LogFlowChartRunTime(FC_OPEN_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                else if (rt == ThreeValued.FALSE)   //綠色燈
                {
                    ShowAlarm("E", 4);//偵測Wafer突出，請檢查
                }
                return FlowChart.FCRESULT.IDLE;
            //}
            //return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_ConvexCyOff_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_OPEN_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_Done_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_OPEN_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_Next_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_Next_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_MoveZtoFirstPos_Run()
        {
            bool b1 = MoveDoorZToPos(SReadValue("ScanFristPos").ToInt());
            if (b1)
            {
                RunTM.Restart();
                LogFlowChartRunTime(FC_OPEN_START);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_MappingCylinderOn_Run()
        {
            bool b1 = Cylinder_Ctrl(eCylinder.Mapping, ECylinderAction.Open);
            if (b1)
            {
                RunTM.Restart();
                Flag_Scan_Action.DoIt();
                LogFlowChartRunTime(FC_OPEN_START);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_MoveZtoSecondPos_Run()
        {
            ThreeValued tRet = DI_ConvexDetect.On();
            if (tRet == ThreeValued.FALSE)
            {
                MT_DoorZ.FastStop();
                ShowAlarm("E", 4);//偵測Wafer突出，請檢查
                return FlowChart.FCRESULT.IDLE;
            }
            bool b1 = MoveDoorZToPos(SReadValue("ScanSecondPos").ToInt());
            if (b1)
            {
                RunTM.Restart();
                Flag_Scan_Action.Done();
                LogFlowChartRunTime(FC_OPEN_START);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_MappingCylinderOff_Run()
        {
            bool b1 = Cylinder_Ctrl(eCylinder.Mapping, ECylinderAction.Close);
            if (b1)
            {
                RunTM.Restart();
                LogFlowChartRunTime(FC_OPEN_START);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_MoveZtoWaitingPos_Run()
        {
            bool b1 = MoveDoorZToPos(SReadValue("MotorZ_WaitPos").ToInt());
            if (b1)
            {
                RunTM.Restart();
                LogFlowChartRunTime(FC_OPEN_START);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Open_CalculationResult_Run()
        {
            Mapping FoupMapping = new Mapping();

            if (OReadValue("ModuleTest").ToBoolean() == true || IsSimulation() > 0)
            {
                FoupMapping.iScanWaferFirstTheoreticalPos = SReadValue("WaferFirstTheoreticalPos").ToInt();
                FoupMapping.iTotalLevel = 25;
                FoupMapping.iScanPitch = 10000;
                FoupMapping.iWaferThick = 800;
                FoupMapping.iWaferThickOffset = 500;
                FoupMapping.iWaferStationOffset = 1000;
                TrayDataSetting.tdFoup2.YN = 25;
                TrayDataSetting.tdFoup2.XN = 1;
            }
            else
            {
                FoupMapping.iScanWaferFirstTheoreticalPos = SReadValue("WaferFirstTheoreticalPos").ToInt();
                FoupMapping.iTotalLevel = PReadValue("Foup_YN").ToInt();
                FoupMapping.iScanPitch = PReadValue("Foup_Pitch").ToInt();
                FoupMapping.iWaferThick = PReadValue("Wafer_Thickness").ToInt();
                FoupMapping.iWaferThickOffset = PReadValue("Wafer_AllowableThicknessRange").ToInt();
                FoupMapping.iWaferStationOffset = PReadValue("Wafer_PositionOffset").ToInt();
                TrayDataSetting.tdFoup2.YN = PReadValue("Foup_YN").ToInt();
                TrayDataSetting.tdFoup2.XN = PReadValue("Foup_XN").ToInt();
            }

            WaferState[] waferState = FoupMapping.CalScanResult(SensorOff, SensorOn);

            MyFoupSlotState = new SlotState[PReadValue("Foup_YN").ToInt()];
            MyFoupSlotState = FoupMapping.SlotStates;

            if (OReadValue("DryRun").ToBoolean())
            {
                for (int i = 0; i < waferState.Length; i++)
                {
                    if (GetIsDummy() == false)
                        TrayDataSetting.tdFoup2.CellSet(0, 0, 0, i, (byte)_BinDefine.HasWafer, 0);
                }
            }
            else
            {
                for (int i = 0; i < waferState.Length; i++)
                {
                    switch (waferState[i])
                    {
                        case WaferState.NoWafer:
                            {
                                TrayDataSetting.tdFoup2.CellSet(0, 0, 0, i, (byte)_BinDefine.NoWafer, 0);
                            }
                            break;

                        case WaferState.WaferDtected:
                            {
                                if (GetIsDummy() == false)
                                    TrayDataSetting.tdFoup2.CellSet(0, 0, 0, i, (byte)_BinDefine.HasWafer, 0);
                                else
                                    TrayDataSetting.tdFoup2.CellSet(0, 0, 0, i, (byte)_BinDefine.DummyWafer, 0);
                            }
                            break;

                        case WaferState.ThicknessOverLimit:
                        case WaferState.WaferPosError:
                            TrayDataSetting.tdFoup2.CellSet(0, 0, 0, i, (byte)_BinDefine.WaferNG, 0);

                            break;
                    }
                }
            }
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_Next_4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Open_Next_3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #region SCAN FLOW
        private FlowChart.FCRESULT FC_SCAN_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_SCAN_IsScanFlagDoit_Run()
        {
            if (Flag_Scan_Action.IsDoIt())
            {
                SensorOn.Clear();
                SensorOff.Clear();
                bScanSingnalChange = true;
                Flag_Scan_Action.Doing();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_SCAN_ListAddPos_Run()
        {
            if (Flag_Scan_Action.IsDone())
            {
                return FlowChart.FCRESULT.NEXT;
            }

            bool b1 = IB_Wafer_Mapping_Sensor.Value;
            if (bScanSingnalChange != b1)
            {
                bScanSingnalChange = !bScanSingnalChange;
                if (bScanSingnalChange)
                {
                    int pos = MT_DoorZ.ReadEncPos();
                    SensorOn.Add(pos);
                }
                else
                {
                    int pos = MT_DoorZ.ReadEncPos();
                    SensorOff.Add(pos);
                }
            }

            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_SCAN_NEXT_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_SCAN_NEXT_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion SCAN FLOW
        #endregion ======================================================== Open ================================================================

        #region ======================================================== Close ================================================================

        private FlowChart.FCRESULT FC_CLOSE_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Close_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.Close)
                {
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_CLOSE_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_ConvexCyOff_Run()
        {
            bool b1 = Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Close);
            bool b2 = Cylinder_Ctrl(eCylinder.Mapping, ECylinderAction.Close);
            //if (Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Close))
            if (b1 && b2)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_DoorYPush_Run()
        {
            if (Cylinder_Ctrl(eCylinder.DoorY, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_VaccumOn_Run()
        {
            bool b1 = Nozzle_DoorVaccum.VacuumOn(100);
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_CoverDetect_Run()
        {
            if (BValue.bIsSimulation)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued rt = DI_CoverDetect.Off(100, 500);
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (rt == ThreeValued.FALSE)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_CheckHasFoup_Run()
        {
            MyLP_Type = GetLoadPortType();
            if (MyLP_Type == LP_Type.Foup)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                RunTM.Restart();
                ShowAlarm("E", 5);//有蓋無Foup無法關門，請檢查
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_CheckPlacement_Run()
        {
            ThreeValued rt = GetLoadPortPlaceState();
            if (rt == ThreeValued.TRUE)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                ShowAlarm("E", 7);//放置偵測異常，無法關門
            }
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_Close_VaccumOff_Run()
        {
            bool b1 = Nozzle_DoorVaccum.VacuumOff(100);
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_DoorZUp_Run()
        {
            bool b1 = MoveDoorZToPos(SReadValue("OpenPos").ToInt());
            //if (Cylinder_Ctrl(eCylinder.DoorZ, ECylinderAction.Open))
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_DoorYPull_Run()
        {
            if (Cylinder_Ctrl(eCylinder.DoorY, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_2ndVaccumOff_Run()
        {
            bool b1 = Nozzle_DoorVaccum.VacuumOff(100);
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_LatchKeyOff_Run()
        {
            if (RunTM.On(1000))
            {
                if (Cylinder_Ctrl(eCylinder.Latch, ECylinderAction.Close))
                {
                    LogFlowChartRunTime(FC_CLOSE_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_DestoryOn_Run()
        {
            bool b1 = Nozzle_DoorVaccum.VacuumOff(100);
            Nozzle_DoorVaccum.DestoryCtrlValue = true;
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_TablePull_Run()
        {
            if (RunTM.On(1000))
            {
                if (Cylinder_Ctrl(eCylinder.Table, ECylinderAction.Close))
                {
                    LogFlowChartRunTime(FC_CLOSE_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_DestoryOff_Run()
        {
            bool b1 = Nozzle_DoorVaccum.DestoryOff(100);
            if (b1)
            {
                LogFlowChartRunTime(FC_CLOSE_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Close_Done_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_CLOSE_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Close_Next_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Close_Next_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion ======================================================== Close ================================================================

        #region ======================================================== INPUTID ================================================================
        private FlowChart.FCRESULT FC_INPUTID_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_InputID_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.InputID)
                {
                    sFLPID = "";
                    InputCassetteIDFormRturn = System.Windows.Forms.DialogResult.None;
                    ShowInputCassetteIDForm = true;
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_INPUTID_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_InputID_DoInputID_Run()
        {
            switch (InputCassetteIDFormRturn)
            {
                case DialogResult.Cancel:
                    LogFlowChartRunTime(FC_INPUTID_START);
                    return FlowChart.FCRESULT.NEXT;
                case DialogResult.OK:
                    LogFlowChartRunTime(FC_INPUTID_START);
                    return FlowChart.FCRESULT.NEXT;
                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_InputID_Done_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_INPUTID_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_InputID_Next_1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_InputID_Next_2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion ======================================================== INPUTID ================================================================

        private FlowChart.FCRESULT FC_Convex_Cylinder_START_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Convex_Cylinder_WaitCmd_Run()
        {
            if (Flag_FLP_Action.IsDoIt())
            {
                if (_FLP_ActionMode == FLP_ActionMode.Convex_Cylinder)
                {
                    Flag_FLP_Action.Doing();
                    LogFlowChartRunTime(FC_Convex_Cylinder_START);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        

        private FlowChart.FCRESULT flowChart1_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Open))
            {
                LogFlowChartRunTime(FC_Convex_Cylinder_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT flowChart2_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_Convex_Cylinder_START, "DryRun");
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            //return FlowChart.FCRESULT.NEXT; //6/13 Munin
            ThreeValued rt = DI_ConvexDetect.On(100, 1000);
            //if (RunTM.On(1000))
            //{
            if (rt == ThreeValued.TRUE)         //橘色燈
            {
                LogFlowChartRunTime(FC_Convex_Cylinder_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (rt == ThreeValued.FALSE)   //綠色燈
            {
                ShowAlarm("E", 4);//偵測Wafer突出，請檢查
            }
            return FlowChart.FCRESULT.IDLE;
            //}
            //return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT flowChart3_Run()
        {
            if (Cylinder_Ctrl(eCylinder.Convex, ECylinderAction.Close))
            {
                LogFlowChartRunTime(FC_Convex_Cylinder_START);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Convex_Cylinder_Done_Run()
        {
            _FLP_ActionMode = FLP_ActionMode.None;
            Flag_FLP_Action.Done();
            RunTM.Restart();
            LogFlowChartRunTime(FC_Convex_Cylinder_START);
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Convex_Cylinder_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowChart1.MainRun();
        }

        private bool MT_DoorZ_IsSafeToRun()
        {
            bool bRet = true;
            if (DI_ArmDetect != null && DI_ArmDetect.ValueOff)
            {
                if (MT_DoorZ != null)
                {
                    bRet = false;
                }
            }
            return bRet;
        }

        private bool OB_MappingCY_Push_IsSafeToAction(object sender)
        {
            if (IsSimulation() > 0)
            {
                return true;
            }
            int iMotorPos = MT_DoorZ.ReadEncPos();
            if (iMotorPos > SReadValue("ScanFristPos").ToInt() + 200 || iMotorPos < SReadValue("ScanSecondPos").ToInt() - 200)
            {
                ShowAlarm("E", 31); //Z軸未到安全位置，Mapping Sensor汽缸禁止移動
                return false;
            }
            return true;
        }

        private bool MoveDoorZToPos(int pos)
        {
            if (IsSimulation() != 0)
            {
                return true;
            }
            if (DI_ArmDetect != null && DI_ArmDetect.ValueOff) return false;
            return MT_DoorZ.G00(pos);
        }


    }
}

