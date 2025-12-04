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
using SANWA_Aligner;
using PaeLibGeneral;

namespace WAS_B
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
    public partial class WAS_B: BaseModuleInterface
    {
        public WAS_B()
        {
            InitializeComponent();

            CreateComponentList();

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

        AlignerCommand AlignerCmd = new AlignerCommand();
        WAS_ActionMode _ActionMode = WAS_ActionMode.None;
        #endregion

        #region 繼承函數

        //模組解構使用
        public override void DisposeTH()
        {
            base.DisposeTH();
        }

        //程式初始化
        public override void Initial()
        {
            bIsSimulation = IsSimulation() > 0;
            DataReset();
            Aligner.StationName = "Aligner";
            Aligner.Initial(new SANWA_Aligner.RobotParser_SANWA_Aligner("Aligner", Aligner.ConnectedMode));
            //Aligner.SetComPort(SValue.COMPort, SValue.Baudrate, SValue.DataBits, SValue.StopBits, SValue.Parity);
            Aligner.SetIPnPort(SValue.Aligner_IP, (ushort)SValue.Aligner_Port);
        }

        //持續偵測函數
        public override void AlwaysRun() { } //持續掃描
        public override int ScanIO() { return 0; } //掃描硬體按鈕IO

        //歸零相關函數
        public override void HomeReset()  //歸零前的重置
        {
            Aligner.AlarmReset();
            Flag_HomeCmdStart.Reset();
            FC_Home_Start.TaskReset();
            FC_Home_Command_Start.TaskReset();
            mCanHome = false;
            mHomeOk = false;
        }
        public override bool Home()
        {
            FC_Home_Start.MainRun();
            FC_Home_Command_Start.MainRun();
            return mHomeOk;
        } //歸零

        //運轉相關函數
        public override void ServoOn() { } //Motor Servo On
        public override void ServoOff() { } //Motor Servo Off
        public override void RunReset() //運轉前初始化
        {
            _ActionMode = WAS_ActionMode.None;
            Flag_CommandAction.Reset();
            FC_Auto_Align_Start.TaskReset();
            FC_Auto_VaccumSW_Start.TaskReset();
            FC_Auto_PreAction_Start.TaskReset();
            FC_Auto_CheckHasWafer_Start.TaskReset();//v1.0.0.4
        }
        public override void Run()  //運轉
        {
            FC_Auto_Align_Start.MainRun();
            FC_Auto_VaccumSW_Start.MainRun();
            FC_Auto_PreAction_Start.MainRun();
            FC_Auto_CheckHasWafer_Start.MainRun();//v1.0.0.4
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
            Aligner.SetIPnPort(SValue.Aligner_IP, (ushort)SValue.Aligner_Port);
            //Aligner.SetComPort(SValue.COMPort, SValue.Baudrate, SValue.DataBits, SValue.StopBits, SValue.Parity);
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
            //SValue.COMPort = cb_COMPort.Items[SReadValue("COMPort").ToInt()].ToString();
            //SValue.Baudrate = cb_Baudrate.Items[SReadValue("Baudrate").ToInt()].ToString();
            //SValue.DataBits = cb_DataBits.Items[SReadValue("DataBits").ToInt()].ToString();
            //SValue.Parity = cb_Parity.Items[SReadValue("Parity").ToInt()].ToString();
            //SValue.StopBits = cv_StopBits.Items[SReadValue("StopBits").ToInt()].ToString();
            SValue.Aligner_Speed = SReadValue("Aligner_Speed").ToInt();
            SValue.Aligner_Timeout = SReadValue("Aligner_Timeout").ToInt();
            SValue.SimulationDelayTime = SReadValue("SimulationDelayTime").ToInt();
            SValue.TeachAngleMaxCount = SReadValue("TeachAngleMaxCount").ToInt();

            SValue.Aligner_IP = SReadValue("Aligner_IP").ToString();
            SValue.Aligner_Port = SReadValue("Aligner_Port").ToInt();
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
            //public string COMPort;
            //public string Baudrate;
            //public string DataBits;
            //public string Parity;
            //public string StopBits;
            public int Aligner_Speed;
            public int Aligner_Timeout;
            public int SimulationDelayTime;
            public int TeachAngleMaxCount;

            public string Aligner_IP;
            public int Aligner_Port;
        }

        private BasicValue SValue;

        public struct OptionValue
        {
            public bool DryRun;
        }

        private OptionValue OValue;
        #endregion

        #region 上位指令
        public bool SetCommand(WAS_ActionMode Action, AlignerCommand Cmd)
        {
            if (GetUseModule() == false)
            {
                return false;
            }

            if (Flag_CommandAction.IsDoing() == false)
            {
                _ActionMode = Action;
                AlignerCmd = Cmd;
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

        private void LogTrace(FlowChart FC, string Msg, bool bHome = false)
        {
            LogRecord.LogTrace("WAS", FC, Msg, bHome);
        }

        private bool Home_SetCommand(AlignerCommand Cmd)
        {
            if (Flag_HomeCmdStart.IsDoing() == false)
            {
                AlignerCmd = Cmd;
                Flag_HomeCmdStart.DoIt();
                return true;
            }
            return false;
        }

        #endregion

        #region 公用函數
        public int GetTeachAngleMaxCount()
        {
            return SValue.TeachAngleMaxCount;
        }

        public void FlowChartRecord()
        {
            List<FlowChart> FCs = new List<FlowChart>();
            FCs.Add(FC_Home_Start);
            FCs.Add(FC_Home_Command_Start);
            FCs.Add(FC_Auto_Align_Start);
            FCs.Add(FC_Auto_VaccumSW_Start);
            FCs.Add(FC_Auto_PreAction_Start);

            LogRecord.FlowChartRecord("WAS", FCs);
        }

        public void VacuumSwitch(EControlOnOff state)
        {
            switch (state)
            {
                case EControlOnOff.OFF:
                    {
                        OB_NegativePressure_On.Value = false;
                        OB_NegativePressure_Off.Value = true;
                    }
                    break;

                case EControlOnOff.ON:
                    {
                        OB_NegativePressure_On.Value = true;
                        OB_NegativePressure_Off.Value = false;
                    }
                    break;

                case EControlOnOff.None:
                default:
                    {
                        OB_NegativePressure_On.Value = false;
                        OB_NegativePressure_Off.Value = false;
                    }
                    break;
            }
        }

        //-----v1.0.0.4-----
        private ThreeValued CheckHasWaferResult;
        public ThreeValued GetCheckHasWaferResult()
        {
            return CheckHasWaferResult;
        }
        //-----v1.0.0.4-----
        #endregion

        #region Aligner指令
        public AlignerCommand GetAlignerCommnad(CommDef Cmd, params object[] Parameters)
        {
            AlignerCommand m_Cmd = new AlignerCommand();
            switch (Cmd)
            {
                case CommDef.GET_STS:
                case CommDef.CMD_HOME:
                case CommDef.SET_RESET:
                case CommDef.CMD_ORG:
                    {
                        m_Cmd.Command = Cmd;
                    }
                    break;

                case CommDef.SET_SP:
                    {
                        m_Cmd.Command = Cmd;
                        m_Cmd.Parameter_1 = ((int)Parameters[0]).ToString();
                    }
                    break;
                case CommDef.CMD_ALIGN:
                    {
                        m_Cmd.Command = Cmd;
                        m_Cmd.Parameter_1 = ((int)(ALIGN_TYPE)Parameters[0]).ToString();
                        m_Cmd.Parameter_2 = ((int)Parameters[1]).ToString();
                        m_Cmd.Parameter_3 = ((int)Parameters[2]).ToString();
                        m_Cmd.Parameter_4 = ((int)Parameters[3]).ToString();
                    }
                    break;
                case CommDef.SET_WTYPE:
                    {
                        m_Cmd.Command = Cmd;
                        m_Cmd.Parameter_1 = ((int)Parameters[0]).ToString();
                        m_Cmd.Parameter_2 = ((int)Parameters[1]).ToString();
                    }
                    break;
                case CommDef.SET_TIME:
                    {
                        m_Cmd.Command = Cmd;
                        m_Cmd.Parameter_1 = Parameters[0].ToString();
                    }
                    break;
                case CommDef.CMD_WRLS:
                case CommDef.CMD_WHLD:
                    {
                        m_Cmd.Command = Cmd;
                        m_Cmd.Parameter_1 = "1";//固定
                    }
                    break;
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
            bool b1 = Aligner.SetCommand(AlignerCmd);
            if (b1)
            {
                LogTrace(FC_Home_Command_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                HomeTM.Restart();
            }
            else if (HomeTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                HomeTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_CommandStart_CommandFinish_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Home_Command_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                if (AlignerCmd.Command == CommDef.CMD_WHLD)
                {
                    AlignerCommand RevData = (AlignerCommand)Aligner.GetReceiveData();
                    if (RevData.RSLT == "9380a000")
                    {
                        Aligner.AlarmReset();
                        return FlowChart.FCRESULT.NEXT;
                    }
                }

                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Home_Command_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (HomeTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
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
                VacuumSwitch(EControlOnOff.ON);
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
            if (Aligner.IsConnect() == true)
            {
                HomeTM.Restart();
                LogTrace(FC_Home_Start, "IsConnect", true);
                return FlowChart.FCRESULT.NEXT;
            }

            //Aligner.SetComPort(SValue.COMPort, SValue.Baudrate, SValue.DataBits, SValue.StopBits, SValue.Parity);
            Aligner.SetIPnPort(SValue.Aligner_IP, (ushort)SValue.Aligner_Port);

            if (Aligner.Connect() == true)
            {
                HomeTM.Restart();
                LogTrace(FC_Home_Start, "Connect", true);
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                if (HomeTM.On(5000))
                {
                    HomeTM.Restart();
                    ShowAlarm("E", 1);//Aligner連線逾時
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

        private FlowChart.FCRESULT FC_Home_VacOn_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_WHLD);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_GetStatus_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.GET_STS);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_ChkHasNoWafer_Run()
        {
            SANWA_AlignerStatus Status = (SANWA_AlignerStatus)Aligner.GetStatus();
            if (Status.iAxis_X_Vaccum == 0)//L 軸吸著 Sensor 0 = OFF 1 = ON 
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

        private FlowChart.FCRESULT FC_Home_VacOff_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_WRLS);
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
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_ORG);
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
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.SET_SP, SValue.Aligner_Speed);
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Home_SetSWaferType_Doit_Run()
        {
            //if (PackageName != null && PackageName != "")
            //{
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.SET_WTYPE, 12, 0);//目前固定12吋、Notch Type
            bool b1 = Home_SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Home_Start, null, true);
                HomeTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
            //}
            //else
            //{
            //    LogTrace(FC_Home_Start, "NoPackageName", true);
            //    return FlowChart.FCRESULT.CASE1;
            //}
        }

        private FlowChart.FCRESULT FC_Home_SetTime_Doit_Run()
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("yyyy:MM:dd:HH:mm:ss");

            AlignerCommand Cmd = GetAlignerCommnad(CommDef.SET_TIME, formattedTime);
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
                VacuumSwitch(EControlOnOff.OFF);
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

        #region ALIGN
        private FlowChart.FCRESULT FC_Auto_Align_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Align_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WAS_ActionMode.Align)
                {
                    Flag_CommandAction.Doing();
                    LogTrace(FC_Auto_Align_Start, null);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_DoVacOn_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_WHLD);
            bool b1 = Aligner.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Align_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_VacOnDone_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_Align_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("I", 5);//如錯誤代碼：86830000，Offset 超過設定範圍
                ShowAlarm("I", 6);//晶圓保持(吸附)失敗(有 Timeout 參數)
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}

                LogTrace(FC_Auto_Align_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_Align_Start, "Timeout", true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_DoPreAlign_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_HOME);
            bool b1 = Aligner.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_Align_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_PreAlignDone_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_Align_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("I", 5);//如錯誤代碼：86830000，Offset 超過設定範圍
                ShowAlarm("I", 6);//晶圓保持(吸附)失敗(有 Timeout 參數)
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}

                LogTrace(FC_Auto_Align_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_Align_Start, "Timeout", true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }
        private FlowChart.FCRESULT FC_Auto_Align_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Align_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Aligner.SetCommand(AlignerCmd);
            if (b1)
            {
                LogTrace(FC_Auto_Align_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_Align_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_Align_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            string ErrorCode = Aligner.GetErrorCode(); //v1.0.0.14 Munin
            if (ErrorCode.StartsWith("868300"))
            {
                ShowAlarm("I", 5);//如錯誤代碼：86830000，Offset 超過設定範圍    v1.0.0.8
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_Align_Start, "ErrorHappen:" + Aligner.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (Aligner.ErrorHappened())
            {
                //ShowAlarm("I", 5);//如錯誤代碼：86830000，Offset 超過設定範圍    v1.0.0.8
                //ShowAlarm("I", 6);//晶圓保持(吸附)失敗(有 Timeout 參數)          v1.0.0.8
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_Align_Start, "ErrorHappen:" + Aligner.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_Align_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_Align_FailAction_Run()
        {
            //共用
            LogTrace(FC_Auto_Align_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_Align_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WAS_ActionMode.None;
            LogTrace(FC_Auto_Align_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion ALIGN

        #region VaccumSW
        private FlowChart.FCRESULT FC_Auto_VaccumSW_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_VaccumSW_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WAS_ActionMode.VaccumSW)
                {
                    Flag_CommandAction.Doing();

                    string msg = "";
                    if (AlignerCmd.Command == CommDef.CMD_WHLD)
                    {
                        msg = "真空開";
                    }
                    else if (AlignerCmd.Command == CommDef.CMD_WRLS)
                    {
                        msg = "真空關";
                    }
                    LogTrace(FC_Auto_VaccumSW_Start, msg);
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_VaccumSW_DoAction_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_VaccumSW_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            bool b1 = Aligner.SetCommand(AlignerCmd);
            if (b1)
            {
                LogTrace(FC_Auto_VaccumSW_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_VaccumSW_DoActionDone_Run()
        {
            if (bIsSimulation)
            {
                if (RunTM.On(SValue.SimulationDelayTime))
                {
                    LogTrace(FC_Auto_VaccumSW_Start, "Simulation");
                    RunTM.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
                return FlowChart.FCRESULT.IDLE;
            }

            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_VaccumSW_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_VaccumSW_Start, "ErrorHappen:" + Aligner.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_VaccumSW_Start, "Timeout");
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_VaccumSW_FailAction_Run()
        {
            LogTrace(FC_Auto_Align_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_VaccumSW_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WAS_ActionMode.None;
            LogTrace(FC_Auto_VaccumSW_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion VaccumSW

        #region PreAction
        private FlowChart.FCRESULT FC_Auto_PreAction_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_PreAction_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WAS_ActionMode.PreAction)
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

            bool b1 = Aligner.SetCommand(AlignerCmd);
            if (b1)
            {
                LogTrace(FC_Auto_PreAction_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
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

            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_PreAction_Start, null);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_PreAction_Start, "ErrorHappen:" + Aligner.GetErrorCode());
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
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
            _ActionMode = WAS_ActionMode.None;
            LogTrace(FC_Auto_PreAction_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion PreAction

        private void bt_VacuumOn_Click(object sender, EventArgs e)
        {
            VacuumSwitch(EControlOnOff.ON);
        }


        #endregion 流程

        private void bt_VacuumOff_Click(object sender, EventArgs e)
        {
            VacuumSwitch(EControlOnOff.OFF);
            while (OB_NegativePressure_Off.On(200) == false)
            {
            }
            OB_NegativePressure_Off.Value = false;
        }

        private FlowChart.FCRESULT FC_Home_Reset_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.SET_RESET);
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

        //-----v1.0.0.4-----
        #region Check Has Wafer
        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_WaitCommand_Run()
        {
            if (Flag_CommandAction.IsDoIt())
            {
                if (_ActionMode == WAS_ActionMode.CheckHasWafer)
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
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_WHLD);
            bool b1 = Aligner.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOnDone_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout", true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_GetStatus_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.GET_STS);
            bool b1 = Aligner.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_GetStatusDone_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout", true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_CheckHasWafer_Run()
        {
            SANWA_AlignerStatus Status = (SANWA_AlignerStatus)Aligner.GetStatus();
            if (Status.iAxis_X_Vaccum == 0)//L 軸吸著 Sensor 0 = OFF 1 = ON 
            {
                CheckHasWaferResult = ThreeValued.FALSE;
                LogTrace(FC_Auto_CheckHasWafer_Start, "False");
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else
            {
                CheckHasWaferResult = ThreeValued.TRUE;
                LogTrace(FC_Auto_CheckHasWafer_Start, "TRUE");
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOff_Run()
        {
            AlignerCommand Cmd = GetAlignerCommnad(CommDef.CMD_WRLS);
            bool b1 = Aligner.SetCommand(Cmd);
            if (b1)
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                RunTM.Restart();
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                RunTM.Restart();
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_VacOffDone_Run()
        {
            if (Aligner.IsIDLE())
            {
                LogTrace(FC_Auto_CheckHasWafer_Start, null, true);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            else if (Aligner.ErrorHappened())
            {
                ShowAlarm("E", 2, Aligner.GetErrorCode());//Aligner發生異常，Error Code:{0}
                LogTrace(FC_Auto_CheckHasWafer_Start, "ErrorHappen:" + Aligner.GetErrorCode(), true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            else if (RunTM.On(SValue.Aligner_Timeout))
            {
                ShowAlarm("E", 3);//Aligner動作逾時
                LogTrace(FC_Auto_CheckHasWafer_Start, "Timeout", true);
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_FailAction_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_FailAction2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_FailAction3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Done_Run()
        {
            Flag_CommandAction.Done();
            _ActionMode = WAS_ActionMode.None;
            LogTrace(FC_Auto_CheckHasWafer_Start, null);
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_CheckHasWafer_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion Check Has Wafer
        //-----v1.0.0.4-----
    }
}

