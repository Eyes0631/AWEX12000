using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ProVIFM;
using ProVLib;
using KCSDK;
using CommonObj;
using SANWA_Robot;
using PaeLibGeneral;

namespace WTR_A
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
    public partial class WTR_A : BaseModuleInterface
    {
        public WTR_A()
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

        #region 模組變數
        private bool bIsSimulation = false;

        protected MyTimer ConnectTM = new MyTimer();

        #region Flag
        JActionFlag Flag_HomeCmdStart = new JActionFlag();
        JActionFlag Flag_CommandAction = new JActionFlag();
        #endregion

        private JTimer JTimerCloseAir = new JTimer();
        RobotCommand RobotCmd = new RobotCommand();
        WTR_ActionMode _ActionMode = WTR_ActionMode.None;
        private string sMappingData;
        private ThreeValued PickResult;
        private ThreeValued PlaceResult;
        private ThreeValued CheckHasWaferResult;
        #region 其他表單處理相關變數
        private Thread DialogFormThread = null;                 // 其他表單處理專用執行緒
        private bool StopDialogFormThread = true;               // 其他表單處理專用執行緒運行旗標

        private string sGetPutErrorTitle = "";
        private bool bShowGetPutErrorFailForm = false;
        private Failure_Action GetPutErrorFailAction = Failure_Action.None;

        #endregion

        #region 安全保護
        private StatusDelegateCtrl IOStatus_FLP_DoorZCy_IsSafe;
        private StatusDelegateCtrl IOStatus_FLP_ConvexCy_IsSafe;
        private StatusDelegateCtrl IOStatus_LSM_GateCy_IsSafe;
        private StatusDelegateCtrl IOStatus_WAR_Arm_IsSafe;

        public void SetIOStatus_FLP_DoorZCy_IsSafe(StatusDelegateCtrl Dele)// LPA ConvexCylinderIsSafe
        {
            IOStatus_FLP_DoorZCy_IsSafe = Dele;
        }

        public void SetIOStatus_FLP_ConvexCy_IsSafe(StatusDelegateCtrl Dele)// LPA ConvexCylinderIsSafe
        {
            IOStatus_FLP_ConvexCy_IsSafe = Dele;
        }

        public void SetIOStatus_LSM_GateCy_IsSafe(StatusDelegateCtrl Dele)// LPA ConvexCylinderIsSafe
        {
            IOStatus_LSM_GateCy_IsSafe = Dele;
        }

        public void SetIOStatus_WAR_ArmMotorZ_IsSafe(StatusDelegateCtrl Dele)// LPA ConvexCylinderIsSafe
        {
            IOStatus_WAR_Arm_IsSafe = Dele;
        }
        #endregion

        #endregion

        #region 繼承函數

        //模組解構使用
        public override void DisposeTH()
        {
            StopDialogFormThread = true;
            DialogFormThread.Join();

            RobotVacuumSwitch(EControlOnOff.OFF);

            JTimerCloseAir.Reset();
            OB_LowerNegativePressure_Off.On(200);
            OB_UpperNegativePressure_Off.On(200);

            while (JTimerCloseAir.Count(200) == false)
            {

            }
            OB_LowerNegativePressure_Off.Value = false;
            OB_UpperNegativePressure_Off.Value = false;

            base.DisposeTH();
        }

        //程式初始化
        public override void Initial()
        {
            bIsSimulation = IsSimulation() > 0;
            DataReset();
            Robot.StationName = "Robot";
            Robot.Initial(new SANWA_Robot.RobotParser_SANWA_Robot("Robot", Robot.ConnectedMode));
            Robot.SetIPnPort(SValue.Robot_IP, (ushort)SValue.Robot_Port);
        }

        //持續偵測函數
        public override void AlwaysRun() //持續掃描
        {

        }
        public override int ScanIO() { return 0; } //掃描硬體按鈕IO

        //歸零相關函數
        public override void HomeReset()  //歸零前的重置
        {
            Robot.AlarmReset();
            Flag_HomeCmdStart.Reset();
            FC_Home_Start.TaskReset();
            FC_Home_Command_Start.TaskReset();
            mCanHome = false;
            mHomeOk = false;
        }
        public override bool Home() //歸零 
        {
            FC_Home_Start.MainRun();
            FC_Home_Command_Start.MainRun();
            return mHomeOk;
        }

        //運轉相關函數
        public override void ServoOn() { } //Motor Servo On
        public override void ServoOff() { } //Motor Servo Off
        public override void RunReset()  //運轉前初始化
        {
            _ActionMode = WTR_ActionMode.None;
            Flag_CommandAction.Reset();
            FC_Auto_Get_Start.TaskReset();
            FC_Auto_Put_Start.TaskReset();
            FC_Auto_Mapping_Start.TaskReset();
            FC_Auto_PreAction_Start.TaskReset();
            FC_Auto_Home_Start.TaskReset();
        }
        public override void Run()  //運轉
        {
            FC_Auto_Get_Start.MainRun();
            FC_Auto_Put_Start.MainRun();
            FC_Auto_Mapping_Start.MainRun();
            FC_Auto_PreAction_Start.MainRun();
            FC_Auto_Home_Start.MainRun();
        }
        public override void SetSpeed(bool bHome = false) { } //速度設定

        //手動相關函數
        public override void ManualReset() { } //手動運行前置設定
        public override void ManualRun() { } //手動模式運行

        //停止所有馬達
        public override void StopMotor()
        {
            base.StopMotor();
        }

        public override void AfterSaveParam()
        {
            LoadBasicData();
            Robot.SetIPnPort(SValue.Robot_IP, (ushort)SValue.Robot_Port);
            //base.AfterSaveParam();
        }
        #endregion

        #region 設定參數
        public void DataReset()
        {
            LoadBasicData();
            LoadOptionData();
            LoadPackageData();
        }

        public void LoadBasicData()
        {
            SValue.SimulationMappingData = SReadValue("SimulationMappingData").ToString();
            SValue.Robot_IP = SReadValue("Robot_IP").ToString();
            SValue.Robot_Port = SReadValue("Robot_Port").ToInt();
            SValue.Robot_Speed = SReadValue("Robot_Speed").ToInt();
            SValue.Robot_Thin_Speed = SReadValue("Robot_Thin_Speed").ToInt();
            SValue.Robot_Timeout = SReadValue("Robot_Timeout").ToInt();
            SValue.SimulationDelayTime = SReadValue("SimulationDelayTime").ToInt();
            SValue.Use_TwoStepPick = SReadValue("Use_TwoStepPick").ToBoolean();
            SValue.TwoStagePickDelayTime = SReadValue("TwoStagePickDelayTime").ToInt();
            SValue.Put_TwoStagePickDelayTime = SReadValue("Put_TwoStagePickDelayTime").ToInt();//v1.0.0.20
            SValue.Put_Use_TwoStepPick = SReadValue("Put_TwoStepPick").ToBoolean(); //v1.0.0.20
            SValue.bIsSimulation = IsSimulation() > 0;
        }

        public void LoadOptionData()
        {
            OValue.DryRun = OReadValue("DryRun").ToBoolean();
        }

        public void LoadPackageData()
        {

        }

        public struct BasicValue
        {
            public string SimulationMappingData;
            public string Robot_IP;
            public int Robot_Port;
            public int Robot_Speed;
            public int Robot_Thin_Speed;//薄片機械手速度 v1.0.0.3 Munin
            public int Robot_Timeout;
            public int SimulationDelayTime;
            public bool bIsSimulation;

            public int TwoStagePickDelayTime;//v.1.0.0.2 
            public bool Use_TwoStepPick;//v1.0.0.2

            public bool Put_Use_TwoStepPick; //v1.0.0.20
            public int Put_TwoStagePickDelayTime;//v1.0.0.20

        }

        private BasicValue SValue;

        public struct OptionValue
        {
            public bool DryRun;
        }

        private OptionValue OValue;
        #endregion

        #region 上位指令
        public bool SetCommand(WTR_ActionMode Action, RobotCommand Cmd)
        {
            if (GetUseModule() == false)
            {
                return false;
            }

            if (Flag_CommandAction.IsDoing() == false)
            {
                _ActionMode = Action;
                RobotCmd = Cmd;
                Flag_CommandAction.DoIt();
                return true;
            }
            return false;
        }

        public bool GetActionResult()
        {
            if (GetUseModule() == false)
            {
                return true;
            }

            if (Flag_CommandAction.IsDone())
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 私有函數
        private void PPFAProcess(object obj)
        {
            while (!StopDialogFormThread)
            {
                while (bShowGetPutErrorFailForm)
                {
                    GetPutErrorFailAction = Failure_Action.None;
                    string Title = sGetPutErrorTitle;
                    string[] btnName = { "Retry", "Remove" };
                    Failure_Action[] btnActions = { Failure_Action.Retry, Failure_Action.Remove };//v1.0.0.18修正命名//{ Failure_Action.Ignore, Failure_Action.Remove };
                    Failure_Action_Form FailForm = new Failure_Action_Form(Title, btnName, btnActions);
                    FailForm.Text = "Robot Fail Action Form"; //v1.0.0.13 Munin                  
                    FailForm.ShowForm();
                    GetPutErrorFailAction = FailForm.GetResult();
                    bShowGetPutErrorFailForm = false;
                    FailForm.Close();
                }
                Thread.Sleep(10);
            }
        }

        private void LogTrace(FlowChart FC, string Msg, bool bHome = false)
        {
            LogRecord.LogTrace("WTR", FC, Msg, bHome);
        }

        private void BU2_Log_File(string Bu2_Lot,     //批號       //1.0.0.21   
                                    string stype,       //狀態
                                    string PackageName,//產品名稱
                                    string Msg,         //資訊
                                    string Numeric,     //數值
                                    string WorkSequence,//當前片數
                                    string alignOCR,
                                    string laserOCR,
                                    string sliceCount)  //總片數
        {

            LogRecord.BU2_Log_File(Bu2_Lot, stype, PackageName, Msg, Numeric, WorkSequence, alignOCR, laserOCR, sliceCount);
        }

        private bool Home_SetCommand(RobotCommand Cmd)
        {
            if (Flag_HomeCmdStart.IsDoing() == false)
            {
                RobotCmd = Cmd;
                Flag_HomeCmdStart.DoIt();
                return true;
            }
            return false;
        }

        #endregion

        #region 公用函數
        public string GetMappingData()
        {
            if (sMappingData == null)
                return "";
            return sMappingData;
        }

        public void FlowChartRecord()
        {
            List<FlowChart> FCs = new List<FlowChart>();
            FCs.Add(FC_Home_Start);
            FCs.Add(FC_Home_Command_Start);
            FCs.Add(FC_Auto_Get_Start);
            FCs.Add(FC_Auto_Put_Start);
            FCs.Add(FC_Auto_Mapping_Start);
            FCs.Add(FC_Auto_PreAction_Start);
            FCs.Add(FC_Auto_Home_Start);

            LogRecord.FlowChartRecord("WTR", FCs);
        }

        public void RobotVacuumSwitch(EControlOnOff state)
        {
            switch (state)
            {
                case EControlOnOff.OFF:
                    {
                        OB_LowerNegativePressure_On.Value = false;
                        OB_LowerNegativePressure_Off.Value = true;
                        OB_UpperNegativePressure_On.Value = false;
                        OB_UpperNegativePressure_Off.Value = true;
                    }
                    break;

                case EControlOnOff.ON:
                    {
                        OB_LowerNegativePressure_On.Value = true;
                        OB_LowerNegativePressure_Off.Value = false;
                        OB_UpperNegativePressure_On.Value = true;
                        OB_UpperNegativePressure_Off.Value = false;
                    }
                    break;

                case EControlOnOff.None:
                default:
                    {
                        OB_LowerNegativePressure_On.Value = false;
                        OB_LowerNegativePressure_Off.Value = false;
                        OB_UpperNegativePressure_On.Value = false;
                        OB_UpperNegativePressure_Off.Value = false;
                    }
                    break;
            }
        }

        public ThreeValued GetPickResult()
        {
            return PickResult;
        }

        public ThreeValued GetPlaceResult()
        {
            return PlaceResult;
        }

        public ThreeValued GetCheckHasWaferResult()
        {
            return CheckHasWaferResult;
        }
        #endregion

        #region Robot指令
        public RobotCommand GetRobotCommnad(CommDef Cmd, params object[] Parameters)
        {
            RobotCommand m_Cmd = new RobotCommand();

            try
            {
                switch (Cmd)
                {
                    case CommDef.GET_STS:
                    case CommDef.CMD_HOME:
                    case CommDef.SET_RESET:
                        {
                            m_Cmd.Command = Cmd;
                        }
                        break;

                    case CommDef.CMD_WRLS:
                    case CommDef.CMD_WHLD:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Parameter_1 = ((int)(Arm)Parameters[0]).ToString();
                        }
                        break;

                    case CommDef.SET_SP:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Parameter_1 = ((int)Parameters[0]).ToString();
                        }
                        break;

                    case CommDef.CMD_MAP:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Station = (DefStation)Parameters[0];
                            m_Cmd.Parameter_1 = ((int)(DefStation)Parameters[0]).ToString();
                            m_Cmd.Parameter_2 = ((int)Parameters[1]).ToString();
                            m_Cmd.Parameter_3 = ((int)Parameters[2]).ToString();
                        }
                        break;
                    case CommDef.GET_MAP:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Parameter_1 = ((int)(GetMappingDataDirection)Parameters[0]).ToString();
                        }
                        break;
                    case CommDef.CMD_GET:
                    case CommDef.CMD_PUT:
                        {   //誰看得懂Parameters順序，最後還不是得翻手冊
                            //Get__ 有五個參數 1.Point (站別) 2.Slot 3.Arm(1:R 2:L 3:All) 4.al (0:no Alignment 1:have Aligment) 5:option : 直接給0
                            m_Cmd.Command = Cmd;
                            m_Cmd.Station = (DefStation)Parameters[0];
                            m_Cmd.Parameter_1 = ((int)(DefStation)Parameters[0]).ToString();
                            m_Cmd.Parameter_2 = (int.Parse(Parameters[1].ToString())).ToString();//((int)Parameters[1]).ToString();
                            m_Cmd.Parameter_3 = ((int)(Arm)Parameters[2]).ToString();
                            m_Cmd.Parameter_4 = (int.Parse(Parameters[3].ToString())).ToString();//((int)Parameters[3]).ToString();
                            m_Cmd.Parameter_5 = (int.Parse(Parameters[4].ToString())).ToString();//((int)Parameters[4]).ToString();

                            m_Cmd.ilevel = int.Parse(Parameters[1].ToString());// (int)Parameters[1];
                            m_Cmd.Arm = (Arm)Parameters[2];
                        }
                        break;
                    case CommDef.CMD_GETW:
                    case CommDef.CMD_PUTW:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Station = (DefStation)Parameters[0];
                            m_Cmd.Parameter_1 = ((int)(DefStation)Parameters[0]).ToString();
                            m_Cmd.Parameter_2 = ((int)Parameters[1]).ToString();
                            m_Cmd.Parameter_3 = ((int)(Arm)Parameters[2]).ToString();

                            m_Cmd.ilevel = (int)Parameters[1];
                            m_Cmd.Arm = (Arm)Parameters[2];
                        }
                        break;
                    case CommDef.SET_TIME:
                    case CommDef.SET_MODE:
                        {
                            m_Cmd.Command = Cmd;
                            m_Cmd.Parameter_1 = Parameters[0].ToString();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                ShowAlarm("E", 10);
                m_Cmd = null;
            }

            return m_Cmd;
        }
        #endregion

        #region 流程

        #region 歸零指令傳送流程
        private FlowChart.FCRESULT FC_Home_Command_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_CommandStart_WaitCommand_Run()
        {
            if (Flag_HomeCmdStart.IsDoIt())
            {
                Flag_HomeCmdStart.IsDoing();
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CommandStart_DoCommand_Run()
        {
            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Home_Command_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                HomeTM.Restart();
            }
            else if (HomeTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                HomeTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CommandStart_CommandFinish_Run()
        {
            if (Robot.IsIDLE())
            {
                LogTrace(FC_Home_Command_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                if (RobotCmd.Command == CommDef.CMD_WHLD)
                {
                    RobotCommand RevData = (RobotCommand)Robot.GetReceiveData();
                    if (RevData.RSLT == "9380a000" || RevData.RSLT == "9380a100")
                    {
                        Robot.AlarmReset();
                        return FlowChart.FCRESULT.NEXT;
                    }
                }
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Home_Command_Start, "ErrorHappen:" + Robot.GetErrorCode(), true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (HomeTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Home_Command_Start, "Timeout", true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CommandStart_Done_Run()
        {
            Flag_HomeCmdStart.Done();
            LogTrace(FC_Home_Command_Start, null, true);
            HomeTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion

        #region HOME
        private FlowChart.FCRESULT FC_Home_Retry_Run()
        {//共用
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_Next_Run()
        {//共用
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_WaitCmdDone_Run()
        {//共用
            if (Flag_HomeCmdStart.IsDone())
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Start_Run()
        {
            HomeTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_WaitCmd_Run()
        {
            if (mCanHome)
            {
                RobotVacuumSwitch(EControlOnOff.ON);
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Connect_Run()
        {
            if (bIsSimulation == true)
            {
                LogTrace(FC_Home_Start, "bIsSimulation", true);
                return FlowChart.FCRESULT.CASE1;
            }

            //連線前先確認是否己經連線
            if (Robot.IsConnect() == true)
            {
                HomeTM.Restart();
                LogTrace(FC_Home_Start, "IsConnect", true);
                return FlowChart.FCRESULT.NEXT;
            }

            Robot.SetIPnPort(SValue.Robot_IP, (ushort)SValue.Robot_Port);
            if (Robot.Connect() == true)
            {
                if (HomeTM.On(2000))
                {
                    HomeTM.Restart();
                    LogTrace(FC_Home_Start, "Connect", true);
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            else
            {
                if (HomeTM.On(5000))
                {
                    HomeTM.Restart();
                    ShowAlarm("E", 1);//Robot連線逾時
                    return FlowChart.FCRESULT.IDLE;
                }
                ConnectTM.Restart();
                return FlowChart.FCRESULT.CASE2;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Simulation_Run()
        {
            LogTrace(FC_Home_Start, null, true);
            HomeTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Home_ArmVacOn_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WHLD, Arm.L);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_GetArmStatus_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.GET_STS);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_ChkArmHasNoWafer_Run()
        {
            SANWA_RobotStatus Status = (SANWA_RobotStatus)Robot.GetStatus();
            if (Status.iBlade_L_Vaccum == 0)//L 軸吸著 Sensor 0 = OFF 1 = ON 
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                ShowAlarm("E", 5);
                LogTrace(FC_Home_Start, "有Wafer", true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
        }

        private FlowChart.FCRESULT FC_Home_ArmVacOff_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WRLS, Arm.L);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Arm2VacOn_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WHLD, Arm.U);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_GetArm2Status_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.GET_STS);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_ChkArm2HasNoWafer_Run()
        {
            SANWA_RobotStatus Status = (SANWA_RobotStatus)Robot.GetStatus();
            if (Status.iBlade_R_Vaccum == 0)//R 軸吸著 Sensor 0 = OFF 1 = ON 
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                ShowAlarm("E", 4);
                LogTrace(FC_Home_Start, "有Wafer", true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
        }

        private FlowChart.FCRESULT FC_Home_Arm2VacOff_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WRLS, Arm.U);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_DoHome_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_HOME);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_SetSpeed_Doit_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.SET_SP, SValue.Robot_Speed);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_SetTime_Doit_Run()
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("yyyy:MM:dd:HH:mm:ss");

            RobotCommand Cmd = GetRobotCommnad(CommDef.SET_TIME, formattedTime);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_End_Run()
        {
            if (mHomeOk == false)
            {
                RobotVacuumSwitch(EControlOnOff.OFF);
                mHomeOk = true;
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion HOME

        private FlowChart.FCRESULT FC_Auto_Next_Run()
        {//共用
            return FlowChart.FCRESULT.NEXT;
        }

        #region GET
        private FlowChart.FCRESULT FC_Auto_Get_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Get_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.Get)
                {
                    Flag_CommandAction.Doing();
                    PickResult = ThreeValued.UNKNOWN;

                    //-----v1.0.0.3-----
                    if (SValue.Use_TwoStepPick)
                    {
                        
                        LogTrace(FC_Auto_Get_Start, "TwoStepPick");
                        //BU2_Log_File(DataLayer.BU2_Lot, null, "OP", PackageName, "TwoStepPick",null, null, null, null);
                        BU2_Log_File(null, null, "OP", PackageName, "TwoStepPick", null, null, null, null); 
                        RunTM.Restart();
                        return FlowChart.FCRESULT.CASE1;
                    }
                    //-----v1.0.0.3-----

                    LogTrace(FC_Auto_Get_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoAction_Run()
        {

            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }
            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    PickResult = ThreeValued.TRUE;//-----v1.0.0.4-----
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PickResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Get_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Get_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_FailAction_Run()
        {
            switch (GetPutErrorFailAction)
            {
                case Failure_Action.Retry:
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Retry」");
                    LogTrace(FC_Auto_Get_Start, "Retry");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;

                case Failure_Action.Remove:
                    PickResult = ThreeValued.FALSE;
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Remove」");
                    LogTrace(FC_Auto_Get_Start, "Remove");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        #region -----v1.0.0.3------
        private FlowChart.FCRESULT FC_Auto_Get_DoGetStep1_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }
            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }


            //Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)   //RobotCmd.Parameter_1, RobotCmd.Parameter_2, RobotCmd.Parameter_3, RobotCmd.Parameter_4, 3);
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_GET, RobotCmd.Station, RobotCmd.Parameter_2, RobotCmd.Arm, RobotCmd.Parameter_4, 2);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoGetStep1_Done_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PickResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Get_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Get_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_FailAction2_Run()
        {
            switch (GetPutErrorFailAction)
            {
                case Failure_Action.Retry:
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Retry」");
                    LogTrace(FC_Auto_Get_Start, "Retry");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;

                case Failure_Action.Remove:
                    PickResult = ThreeValued.FALSE;
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Remove」");
                    LogTrace(FC_Auto_Get_Start, "Remove");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoGetStepDelay_Run()
        {
            if (RunTM.On(SValue.TwoStagePickDelayTime))
            {
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoGetStep2_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }
            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }
            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_GET, RobotCmd.Station, RobotCmd.Parameter_2, RobotCmd.Arm, RobotCmd.Parameter_4, 3);
            //RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_GET, RobotCmd.Parameter_1, RobotCmd.Parameter_2, RobotCmd.Parameter_3, RobotCmd.Parameter_4, 3);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Get_DoGetStep2_Done_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    PickResult = ThreeValued.TRUE;//-----v1.0.0.4-----
                    LogTrace(FC_Auto_Get_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PickResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Get_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Get_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "取料失敗，請檢查";
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Get_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion -----v1.0.0.3------

        private FlowChart.FCRESULT FC_Auto_Get_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_Get_Start, null);
            RunTM.Restart();

            return FlowChart.FCRESULT.NEXT;
        }
        #endregion GET

        #region PUT
        private FlowChart.FCRESULT FC_Auto_Put_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Put_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.Put)
                {
                    Flag_CommandAction.Doing();
                    PlaceResult = ThreeValued.UNKNOWN;

                    //if (SValue.Put_Use_TwoStepPick)//v1.0.0.20
                    //{
                    //    LogTrace(FC_Auto_Put_Start, "Put_TwoStepPick");
                    //    RunTM.Restart();
                    //    return FlowChart.FCRESULT.CASE1;
                    //}

                    LogTrace(FC_Auto_Put_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }
            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    PlaceResult = ThreeValued.TRUE;//v1.0.0.4
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PlaceResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Put_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Put_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_FailAction_Run()
        {
            switch (GetPutErrorFailAction)
            {
                case Failure_Action.Retry:
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Retry」");
                    LogTrace(FC_Auto_Put_Start, "Retry");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;

                case Failure_Action.Remove:
                    PlaceResult = ThreeValued.FALSE;
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Remove」");
                    LogTrace(FC_Auto_Put_Start, "Remove");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_Put_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion PUT

        #region Mapping
        private FlowChart.FCRESULT FC_Auto_Mapping_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.Mapping)
                {
                    Flag_CommandAction.Doing();
                    LogTrace(FC_Auto_Mapping_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Mapping_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }
            //安全保護 Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Auto_Mapping_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Mapping_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_Mapping_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Mapping_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Mapping_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_FailAction_Run()
        {
            LogTrace(FC_Auto_Mapping_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_FailAction_2_Run()
        {
            LogTrace(FC_Auto_Mapping_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT; return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_DoGetMappingData_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Mapping_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.GET_MAP, GetMappingDataDirection.DownToUp);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Mapping_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_GetMappingDataDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    sMappingData = SValue.SimulationMappingData;

                    LogTrace(FC_Auto_Mapping_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                RobotCommand Cmd = (RobotCommand)Robot.GetReceiveData();
                sMappingData = Cmd.RevDAT;
                LogTrace(FC_Auto_Mapping_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Mapping_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Mapping_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Mapping_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_Mapping_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion Mapping

        #region PreAction
        private FlowChart.FCRESULT FC_Auto_PreAction_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.PreAction)
                {
                    Flag_CommandAction.Doing();
                    LogTrace(FC_Auto_PreAction_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_PreAction_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Auto_PreAction_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_PreAction_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_PreAction_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_PreAction_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_PreAction_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_FailAction_Run()
        {
            LogTrace(FC_Auto_PreAction_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_PreAction_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion PreAction

        #region AUTO HOME
        private FlowChart.FCRESULT FC_Auto_Home_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Home_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.Home)
                {
                    Flag_CommandAction.Doing();
                    LogTrace(FC_Auto_Home_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Home_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Home_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Robot.SetCommand(RobotCmd);
            if (b1)
            {
                LogTrace(FC_Auto_Home_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Home_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Home_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_PreAction_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_PreAction_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_PreAction_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Home_FailAction_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Home_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_Home_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion AUTO HOME

        #endregion 流程

        private void bt_VacuumOff_Click(object sender, EventArgs e)
        {
            RobotVacuumSwitch(EControlOnOff.ON);
        }

        private void bt_VacuumOn_Click(object sender, EventArgs e)
        {
            RobotVacuumSwitch(EControlOnOff.OFF);
            while (OB_LowerNegativePressure_Off.On(200) == false)
            {
            }
            OB_LowerNegativePressure_Off.Value = false;
            while (OB_UpperNegativePressure_Off.On(200) == false)
            { }
            OB_UpperNegativePressure_Off.Value = false;
        }

        private bool Robot_IsSafeToAction(string station)
        {
            DefStation St;
            if (Enum.TryParse(station, out St))
            {
                switch (St)
                {
                    case DefStation.MiddleStage:
                        if (IOStatus_WAR_Arm_IsSafe() == false)
                        {
                            ShowAlarm("E", 15);
                            return false;
                        }
                        break;
                    case DefStation.AlignerA:
                    case DefStation.AlignerB:
                        break;
                    case DefStation.Laser:
                        if (IOStatus_LSM_GateCy_IsSafe() == false)
                        {
                            ShowAlarm("E", 14);
                            return false;
                        }
                        break;
                    case DefStation.FoupA:
                    case DefStation.FoupB:
                    case DefStation.FoupC:
                    case DefStation.FoupD:
                    case DefStation.Mapping_Foup:
                        if (IOStatus_FLP_ConvexCy_IsSafe() == false)
                        {
                            ShowAlarm("E", 12);
                            return false;
                        }

                        if (IOStatus_FLP_DoorZCy_IsSafe() == false)
                        {
                            ShowAlarm("E", 13);
                            return false;
                        }
                        break;
                    default:
                        break;
                }

                return true;
            }
            return false;
        }

        private FlowChart.FCRESULT FC_Home_Reset_Run()
        {
            RobotCommand Cmd = GetRobotCommnad(CommDef.SET_RESET);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_Delay_Run()
        {
            if (ConnectTM.On(1000))
            {
                LogTrace(FC_Home_Start, null, true);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_SetMode_Doit_Run()
        {
            //return FlowChart.FCRESULT.IDLE;
            string mode = OValue.DryRun ? "1" : "0";
            RobotCommand Cmd = GetRobotCommnad(CommDef.SET_MODE, mode);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        #region Check Arm Has Wafer
        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WTR_ActionMode.CheckArmHasWafer)
                {
                    CheckHasWaferResult = ThreeValued.UNKNOWN;
                    Flag_CommandAction.Doing();
                    LogTrace(FC_Auto_CheckHasWafer_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOn_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WHLD, RobotCmd.Arm);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOnDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_GetStutes_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.GET_STS);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_GetStutesDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_CheckArmHasWafer_Run()
        {
            SANWA_RobotStatus Status = (SANWA_RobotStatus)Robot.GetStatus();

            switch (RobotCmd.Arm)
            {
                case Arm.L:
                    if (Status.iBlade_L_Vaccum == 0)//L 軸吸著 Sensor 0 = OFF 1 = ON 
                    {
                        CheckHasWaferResult = ThreeValued.TRUE;
                        LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                        RunTM.Restart();
                        return FlowChart.FCRESULT.NEXT;
                    }
                    else
                    {
                        CheckHasWaferResult = ThreeValued.FALSE;
                        LogTrace(FC_Auto_CheckHasWafer_Start, "有Wafer", true);
                        RunTM.Restart();
                        return FlowChart.FCRESULT.CASE1;
                    }
                //break;
                case Arm.A:
                    if (Status.iBlade_R_Vaccum == 0)//R 軸吸著 Sensor 0 = OFF 1 = ON 
                    {
                        CheckHasWaferResult = ThreeValued.TRUE;
                        LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                        RunTM.Restart();
                        return FlowChart.FCRESULT.NEXT;
                    }
                    else
                    {
                        CheckHasWaferResult = ThreeValued.FALSE;
                        LogTrace(FC_Auto_CheckHasWafer_Start, "有Wafer", true);
                        RunTM.Restart();
                        return FlowChart.FCRESULT.CASE1;
                    }
                //break;
                default:
                    break;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOff_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_WRLS, RobotCmd.Arm);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOffDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_CheckHasWafer_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WTR_ActionMode.None;
            LogTrace(FC_Auto_CheckHasWafer_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion Check Arm Has Wafer

        private FlowChart.FCRESULT FC_Auto_Put_Next_2_Run() // v1.0.0.20
        {
            return FlowChart.FCRESULT.NEXT;
        }

        #region Put放置二段
        private FlowChart.FCRESULT FC_Auto_Put_FailAction_2_Run()// v1.0.0.20
        {
            switch (GetPutErrorFailAction)
            {
                case Failure_Action.Retry:
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Retry」");
                    LogTrace(FC_Auto_Put_Start, "Retry");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;

                case Failure_Action.Remove:
                    PlaceResult = ThreeValued.FALSE;
                    LogSay(EnLoggerType.EnLog_OP, "WTR，使用者按下「Remove」");
                    LogTrace(FC_Auto_Put_Start, "Remove");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoPutStep1_Run()// v1.0.0.20
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {

                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_PUT, RobotCmd.Station, RobotCmd.Parameter_2, RobotCmd.Arm, RobotCmd.Parameter_4, 1);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoPutStep1_Done_Run()// v1.0.0.20
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    PlaceResult = ThreeValued.TRUE;//v1.0.0.4
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PlaceResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Put_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Put_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoPutStepDelay_Run()// v1.0.0.20
        {
            if (RunTM.On(SValue.Put_TwoStagePickDelayTime))
            {
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoPutStep2_Run()// v1.0.0.20
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            //安全保護  Parameter_1為站號
            if (Robot_IsSafeToAction(((DefStation)(int.Parse(RobotCmd.Parameter_1))).ToString()) == false)
            {
                return FlowChart.FCRESULT.IDLE;
            }

            RobotCommand Cmd = GetRobotCommnad(CommDef.CMD_PUT, RobotCmd.Station, RobotCmd.Parameter_2, RobotCmd.Arm, RobotCmd.Parameter_4, 3);
            bool b1 = Robot.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                ShowAlarm("E", 3);//Robot動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Put_DoPutStep2_Done_Run()// v1.0.0.20
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    PlaceResult = ThreeValued.TRUE;//v1.0.0.4
                    LogTrace(FC_Auto_Put_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Robot.IsIDLE())
            {
                PlaceResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_Put_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Robot.ErrorHappened())
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 2, Robot.GetErrorCode());//Robot發生異常，Error Code:{0}
                LogTrace(FC_Auto_Put_Start, "ErrorHappen:" + Robot.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Robot_Timeout))
            {
                sGetPutErrorTitle = "放料失敗，請檢查";
                GetPutErrorFailAction = Failure_Action.None;
                bShowGetPutErrorFailForm = true;

                ShowAlarm("E", 3);//Robot動作逾時
                LogTrace(FC_Auto_Put_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
    }
}

