using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProVIFM;
using ProVLib;
using KCSDK;

using PaeLibGeneral;
using PaeLibProVSDKEx;
using CommonObj;
using System.Reflection;
using Microsoft.VisualBasic.Logging;
using SANWA_Aligner;
using NPOI.SS.Formula.Functions;
using SANWA_Robot;

namespace AWEX12000
{
    //使用者修改 (主控流程)
    public partial class MainFlowF : Form
    {
        #region 使用者修改 (定義各模組指標，方便使用)

        private BaseModuleInterface mMAA;
        private BaseModuleInterface mLPA;
        private BaseModuleInterface mLPB;
        private BaseModuleInterface mLPC;
        private BaseModuleInterface mLPD;
        private BaseModuleInterface mWTR_A;
        private BaseModuleInterface mWTR_B;
        private BaseModuleInterface mWAS_A;
        private BaseModuleInterface mWAS_B;
        private BaseModuleInterface mWOI_AT;
        private BaseModuleInterface mWOI_AB;
        private BaseModuleInterface mWOI_BT;
        private BaseModuleInterface mWOI_BB;
        #endregion

        public List<FlowChart> FlowChartList = new List<FlowChart>();
        public bool mHomeOk;

        #region Enum_Definition
        public enum AlarmCode
        {
            //使用者修改 (定義各模組的Alarm代碼)

        }
        #endregion

        #region Struct_Definition
        //使用者修改 (定義各模組的Struct結構)
        public struct OptionValue
        {
            public bool DryRun;
            public bool NonStopMode;
        }
        private OptionValue OValue;

        public struct PackageValue
        { }
        private PackageValue PValue;
        #endregion

        #region 定義各模組名稱
        public const string ModuleName_MAA = "MAA";
        public const string ModuleName_LPA = "LPA";
        public const string ModuleName_LPB = "LPB";
        public const string ModuleName_LPC = "LPC";
        public const string ModuleName_LPD = "LPD";
        public const string ModuleName_WTR_A = "WTR_A";
        public const string ModuleName_WTR_B = "WTR_B";
        public const string ModuleName_WAS_A = "WAS_A";
        public const string ModuleName_WAS_B = "WAS_B";
        public const string ModuleName_WOI_AT = "WOI_AT";
        public const string ModuleName_WOI_AB = "WOI_AB";
        public const string ModuleName_WOI_BT = "WOI_BT";
        public const string ModuleName_WOI_BB = "WOI_BB";
        #endregion

        #region Variable_Definition
        private MyTimer TM_Delay_LPA = null;
        private MyTimer TM_Delay_LPB = null;
        private MyTimer TM_Delay_LPC = null;
        private MyTimer TM_Delay_LPD = null;
        private MyTimer TM_Delay_WTR_A = null;
        private MyTimer TM_Delay_WTR_B = null;
        private MyTimer TM_Delay_WAS_A = null;
        private MyTimer TM_Delay_WAS_B = null;
        private MyTimer TM_Delay_WOI_AT = null;
        private MyTimer TM_Delay_WOI_AB = null;
        private MyTimer TM_Delay_WOI_BT = null;
        private MyTimer TM_Delay_WOI_BB = null;

        private bool bManualTest = false;
        //TODO:
        private bool _ContinueRun = false;
        private bool bUpdateDataGridView = false;
        private int iWorkCount = 0;
        //
        private AlignerCommand AlignerCmd = new AlignerCommand();
        private RobotCommand RobotCmd = new RobotCommand();
        private RobotCommand RobotPickCmd = new RobotCommand();
        private RobotCommand RobotPlaceCmd = new RobotCommand();
        private bool OCROnTop = true;
        private SlotMapping AlignerA_Job = new SlotMapping();
        private SlotMapping AlignerB_Job = new SlotMapping();
        private SlotMapping LeftUpperArm_Job = new SlotMapping();
        private SlotMapping LeftLowerArm_Job = new SlotMapping();
        private SlotMapping LeftArm_Job = new SlotMapping();
        private SlotMapping RightUpperArm_Job = new SlotMapping();
        private SlotMapping RightLowerArm_Job = new SlotMapping();
        private SlotMapping RightArm_Job = new SlotMapping();   

        private readonly List<WaferTransferJob> _Joblist = new List<WaferTransferJob>();
        private JActionTask Task_WTR_A_SendAction = new JActionTask();
        private JActionTask Task_WTR_B_SendAction = new JActionTask();
        private JActionTask Task_WTR_A_ReceiveAction = new JActionTask();
        private JActionTask Task_WTR_B_ReceiveAction = new JActionTask();
        private JActionTask Task_WTR_A_LoadAction = new JActionTask();
        private JActionTask Task_WTR_B_LoadAction = new JActionTask();
        private JActionTask Task_WTR_A_UnloadAction = new JActionTask();
        private JActionTask Task_WTR_B_UnloadAction = new JActionTask();
        #endregion

        #region Flag_Definition
        #region Initial_Flag
        private JActionFlag mFlag_LPA_Home;
        private JActionFlag mFlag_LPB_Home;
        private JActionFlag mFlag_LPC_Home;
        private JActionFlag mFlag_LPD_Home;
        private JActionFlag mFlag_WTR_A_Home;
        private JActionFlag mFlag_WTR_B_Home;
        private JActionFlag mFlag_WAS_A_Home;
        private JActionFlag mFlag_WAS_B_Home;
        private JActionFlag mFlag_WOI_AT_Home;
        private JActionFlag mFlag_WOI_AB_Home;
        private JActionFlag mFlag_WOI_BT_Home;
        private JActionFlag mFlag_WOI_BB_Home;
        #endregion
        #region LotEnd_Flag
        private JActionFlag mFlag_LPA_LotEnd;
        private JActionFlag mFlag_LPB_LotEnd;
        private JActionFlag mFlag_LPC_LotEnd;
        private JActionFlag mFlag_LPD_LotEnd;
        private JActionFlag mFlag_WTR_A_LotEnd;
        private JActionFlag mFlag_WTR_B_LotEnd;
        private JActionFlag mFlag_WAS_A_LotEnd;
        private JActionFlag mFlag_WAS_B_LotEnd;
        private JActionFlag mFlag_WOI_AT_LotEnd;
        private JActionFlag mFlag_WOI_AB_LotEnd;
        private JActionFlag mFlag_WOI_BT_LotEnd;
        private JActionFlag mFlag_WOI_BB_LotEnd;
        private JActionFlag mFlag_MainFlowF_LotEnd;
        #endregion
        #endregion

        public MainFlowF()
        {
            InitializeComponent();

            TopLevel = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //找出所有的主控FlowChart
            GetControls(this);

            #region 使用者修改 (定義各模組指標，方便使用)

            mMAA = (BaseModuleInterface)FormSet.mMSS.GetModule("MAA");
            mLPA = (BaseModuleInterface)FormSet.mMSS.GetModule("LPA");
            mLPB = (BaseModuleInterface)FormSet.mMSS.GetModule("LPB");
            mLPC = (BaseModuleInterface)FormSet.mMSS.GetModule("LPC");
            mLPD = (BaseModuleInterface)FormSet.mMSS.GetModule("LPD");
            mWTR_A = (BaseModuleInterface)FormSet.mMSS.GetModule("WTR_A");
            mWTR_B = (BaseModuleInterface)FormSet.mMSS.GetModule("WTR_B");
            mWAS_A = (BaseModuleInterface)FormSet.mMSS.GetModule("WAS_A");
            mWAS_B = (BaseModuleInterface)FormSet.mMSS.GetModule("WAS_B");
            mWOI_AT = (BaseModuleInterface)FormSet.mMSS.GetModule("WOI_AT");
            mWOI_AB = (BaseModuleInterface)FormSet.mMSS.GetModule("WOI_AB");
            mWOI_BT = (BaseModuleInterface)FormSet.mMSS.GetModule("WOI_BT");
            mWOI_BB = (BaseModuleInterface)FormSet.mMSS.GetModule("WOI_BB");

            #endregion

            #region 初始化Timer
            TM_Delay_LPA = new MyTimer();
            TM_Delay_LPB = new MyTimer();
            TM_Delay_LPC = new MyTimer();
            TM_Delay_LPD = new MyTimer();
            TM_Delay_WTR_A = new MyTimer();
            TM_Delay_WTR_B = new MyTimer();
            TM_Delay_WAS_A = new MyTimer();
            TM_Delay_WAS_B = new MyTimer();
            TM_Delay_WOI_AT = new MyTimer();
            TM_Delay_WOI_AB = new MyTimer();
            TM_Delay_WOI_BT = new MyTimer();
            TM_Delay_WOI_BB = new MyTimer();

            TM_Delay_LPA.AutoReset = false;
            TM_Delay_LPB.AutoReset = false;
            TM_Delay_LPC.AutoReset = false;
            TM_Delay_LPD.AutoReset = false;
            TM_Delay_WTR_A.AutoReset = false;
            TM_Delay_WTR_B.AutoReset = false;
            TM_Delay_WAS_A.AutoReset = false;
            TM_Delay_WAS_B.AutoReset = false;
            TM_Delay_WOI_AT.AutoReset = false;
            TM_Delay_WOI_AB.AutoReset = false;
            TM_Delay_WOI_BT.AutoReset = false;
            TM_Delay_WOI_BB.AutoReset = false;
            #endregion

            #region 初始化Flag
            mFlag_LPA_Home = new JActionFlag();
            mFlag_LPB_Home = new JActionFlag();
            mFlag_LPC_Home = new JActionFlag();
            mFlag_LPD_Home = new JActionFlag();
            mFlag_WTR_A_Home = new JActionFlag();
            mFlag_WTR_B_Home = new JActionFlag();
            mFlag_WAS_A_Home = new JActionFlag();
            mFlag_WAS_B_Home = new JActionFlag();
            mFlag_WOI_AT_Home = new JActionFlag();
            mFlag_WOI_AB_Home = new JActionFlag();
            mFlag_WOI_BT_Home = new JActionFlag();
            mFlag_WOI_BB_Home = new JActionFlag();
            mFlag_LPA_LotEnd = new JActionFlag();
            mFlag_LPB_LotEnd = new JActionFlag();
            mFlag_LPC_LotEnd = new JActionFlag();
            mFlag_LPD_LotEnd = new JActionFlag();
            mFlag_WTR_A_LotEnd = new JActionFlag();
            mFlag_WTR_B_LotEnd = new JActionFlag();
            mFlag_WAS_A_LotEnd = new JActionFlag();
            mFlag_WAS_B_LotEnd = new JActionFlag();
            mFlag_WOI_AT_LotEnd = new JActionFlag();
            mFlag_WOI_AB_LotEnd = new JActionFlag();
            mFlag_WOI_BT_LotEnd = new JActionFlag();
            mFlag_WOI_BB_LotEnd = new JActionFlag();
            mFlag_MainFlowF_LotEnd = new JActionFlag();
            #endregion
        }

        #region 動作函數

        //初始化函數
        public void Initial()
        {
        }

        //持續掃描
        public void AlwaysRun()
        {

        }

        //掃描硬體按鈕IO
        public void ScanIO()
        {
            #region 架構使用 (處理MAA的硬體按鈕IO對應的動作)

            if ((SYSPara.ManualControlIO) && (SYSPara.RunMode != RunModeDT.MANUAL))
                return;

            int result = ((BaseModuleInterface)mMAA).ScanIO();

            //Start Button
            if ((result & 0x01) == 1)
            {
                if (!SYSPara.SysRun)
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「生產開始」");

                SYSPara.ErrorStop = false;
                SYSPara.Alarm.ClearAll();
                SYSPara.MusicOn = true;
                SYSPara.SysRun = true;

                SYSPara.CallProc(ModuleName_LPA, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPB, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPC, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPD, "ResetAlarm");

                TimerReset();
            }
            //Stop Button
            if (((result >> 1) & 0x01) == 1)
            {
                if (SYSPara.SysRun)
                    SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「生產暫停」");

                if (SYSPara.SysState == StateMode.SM_ALARM)
                {
                    SYSPara.ErrorStop = false;
                    SYSPara.SysState = StateMode.SM_PAUSE;
                }

                SYSPara.MusicOn = false;
                SYSPara.SysRun = false;
                FormSet.mMSS.M_Stop();
            }
            //Alarm Result Button
            if (((result >> 2) & 0x01) == 1)
            {
                SYSPara.Alarm.ClearAll();
                if (SYSPara.SysState == StateMode.SM_ALARM || SYSPara.SysState == StateMode.SM_PAUSE)
                {
                    SYSPara.ErrorStop = false;
                    SYSPara.SysState = StateMode.SM_PAUSE;
                }
                SYSPara.MusicOn = false;

                SYSPara.CallProc(ModuleName_LPA, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPB, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPC, "ResetAlarm");
                SYSPara.CallProc(ModuleName_LPD, "ResetAlarm");
            }

            #endregion
        }

        //歸零前的重置
        public void HomeReset()
        {
            #region 使用者修改 (針對各模式的歸零前置設定)

            FC_Initial_LPA_HomeStart.TaskReset();
            FC_Initial_LPB_HomeStart.TaskReset();
            FC_Initial_LPC_HomeStart.TaskReset();
            FC_Initial_LPD_HomeStart.TaskReset();
            FC_Initial_WTR_A_HomeStart.TaskReset();
            FC_Initial_WTR_B_HomeStart.TaskReset();
            FC_Initial_WAS_A_HomeStart.TaskReset();
            FC_Initial_WAS_B_HomeStart.TaskReset();
            FC_Initial_WOI_AT_HomeStart.TaskReset();
            FC_Initial_WOI_AB_HomeStart.TaskReset();
            FC_Initial_WOI_BT_HomeStart.TaskReset();
            FC_Initial_WOI_BB_HomeStart.TaskReset();
            #endregion
            DataReset();
            mHomeOk = false;
        }

        //歸零
        public bool Home()
        {
            FC_Initial_LPA_HomeStart.MainRun();
            FC_Initial_LPB_HomeStart.MainRun();
            FC_Initial_LPC_HomeStart.MainRun();
            FC_Initial_LPD_HomeStart.MainRun();
            FC_Initial_WTR_A_HomeStart.MainRun();
            FC_Initial_WTR_B_HomeStart.MainRun();
            FC_Initial_WAS_A_HomeStart.MainRun();
            FC_Initial_WAS_B_HomeStart.MainRun();
            FC_Initial_WOI_AT_HomeStart.MainRun();
            FC_Initial_WOI_AB_HomeStart.MainRun();
            FC_Initial_WOI_BT_HomeStart.MainRun();
            FC_Initial_WOI_BB_HomeStart.MainRun();

            if (mFlag_LPA_Home.IsDone() && mFlag_LPB_Home.IsDone() &&
                mFlag_LPC_Home.IsDone() && mFlag_LPD_Home.IsDone() &&
                mFlag_WTR_A_Home.IsDone() && mFlag_WTR_B_Home.IsDone() &&
                mFlag_WAS_A_Home.IsDone() && mFlag_WAS_B_Home.IsDone() &&
                mFlag_WOI_AT_Home.IsDone() && mFlag_WOI_AB_Home.IsDone() &&
                mFlag_WOI_BT_Home.IsDone() && mFlag_WOI_BB_Home.IsDone())
            {
                mHomeOk = true;
            }
            return mHomeOk;
        }

        //運轉前初始化
        public void RunReset()
        {
            //Load Port FC Task Reset
            FC_Auto_LoadPort1_Start.TaskReset();
            FC_Auto_LoadPort2_Start.TaskReset();
            FC_Auto_LoadPort3_Start.TaskReset();
            FC_Auto_LoadPort4_Start.TaskReset();
            //WAS FC Task Reset
            FC_Auto_WAS_A_AligmentRESTAction_Start.TaskReset();
            FC_Auto_WAS_B_AligmentRESTAction_Start.TaskReset();
            FC_Auto_WAS_A_AligmentAction_Start.TaskReset();
            FC_Auto_WAS_B_AligmentAction_Start.TaskReset();
            //WOI FC Task Reset
            FC_Auto_WOI_AT_Start.TaskReset();
            FC_Auto_WOI_AB_Start.TaskReset();
            FC_Auto_WOI_BT_Start.TaskReset();
            FC_Auto_WOI_BB_Start.TaskReset();
            //WTR FC Task Reset
            FC_Auto_WTRMain_Start.TaskReset();
            FC_Auto_WTR_A_Action_Start.TaskReset();
            FC_Auto_WTR_B_Action_Start.TaskReset();
        }

        //運轉
        public void Run()
        {
            //Load Port FC Task MainRun
            FC_Auto_LoadPort1_Start.MainRun();
            FC_Auto_LoadPort2_Start.MainRun();
            FC_Auto_LoadPort3_Start.MainRun();
            FC_Auto_LoadPort4_Start.MainRun();
            //WAS FC Task MainRun
            FC_Auto_WAS_A_AligmentRESTAction_Start.MainRun();
            FC_Auto_WAS_B_AligmentRESTAction_Start.MainRun();
            FC_Auto_WAS_A_AligmentAction_Start.MainRun();
            FC_Auto_WAS_B_AligmentAction_Start.MainRun();
            //WOI FC Task MainRun
            FC_Auto_WOI_AT_Start.MainRun();
            FC_Auto_WOI_AB_Start.MainRun();
            FC_Auto_WOI_BT_Start.MainRun();
            FC_Auto_WOI_BB_Start.MainRun();
            //WTR FC Task MainRun
            FC_Auto_WTRMain_Start.MainRun();
            FC_Auto_WTR_A_Action_Start.MainRun();
            FC_Auto_WTR_B_Action_Start.MainRun();

            if (mFlag_LPA_LotEnd.IsDone() &&
                mFlag_LPB_LotEnd.IsDone() &&
                mFlag_LPC_LotEnd.IsDone() &&
                mFlag_LPD_LotEnd.IsDone() &&
                mFlag_WTR_A_LotEnd.IsDone() &&
                mFlag_WTR_B_LotEnd.IsDone() &&
                mFlag_WAS_A_LotEnd.IsDone() &&
                mFlag_WAS_B_LotEnd.IsDone() &&
                mFlag_WOI_AT_LotEnd.IsDone() &&
                mFlag_WOI_AB_LotEnd.IsDone() &&
                mFlag_WOI_BT_LotEnd.IsDone() &&
                mFlag_WOI_BB_LotEnd.IsDone() &&
                mFlag_MainFlowF_LotEnd.IsDone())
            {
                SYSPara.LotendOk = true;
            }
        }

        //手動運行前置設定
        public void ManualReset()
        {
        }

        //手動模式運行
        public void ManualRun()
        {
        }

        //維修模式前置設定
        public void MaintenanceReset()
        {
        }

        //維修模式運行
        public void MaintenanceRun()
        {
        }

        #endregion

        #region 私有函數

        private void GetControls(Control ctr)
        {
            foreach (Control myctr in ctr.Controls)
            {
                //如果傳進來的控制項有子控制項的話
                if (myctr.HasChildren == true)
                {
                    //就遞迴呼叫自己
                    GetControls(myctr);
                }

                if (myctr is FlowChart)
                    FlowChartList.Add((FlowChart)myctr);
            }
        }

        private void DataReset()
        {
            #region 資料重置
            mFlag_LPA_Home.Reset();
            mFlag_LPB_Home.Reset();
            mFlag_LPC_Home.Reset();
            mFlag_LPD_Home.Reset();
            mFlag_WTR_A_Home.Reset();
            mFlag_WTR_B_Home.Reset();
            mFlag_WAS_A_Home.Reset();
            mFlag_WAS_B_Home.Reset();
            mFlag_WOI_AT_Home.Reset();
            mFlag_WOI_AB_Home.Reset();
            mFlag_WOI_BT_Home.Reset();
            mFlag_WOI_BB_Home.Reset();
            mFlag_LPA_LotEnd.Reset();
            mFlag_LPB_LotEnd.Reset();
            mFlag_LPC_LotEnd.Reset();
            mFlag_LPD_LotEnd.Reset();
            mFlag_WTR_A_LotEnd.Reset();
            mFlag_WTR_B_LotEnd.Reset();
            mFlag_WAS_A_LotEnd.Reset();
            mFlag_WAS_B_LotEnd.Reset();
            mFlag_WOI_AT_LotEnd.Reset();
            mFlag_WOI_AB_LotEnd.Reset();
            mFlag_WOI_BT_LotEnd.Reset();
            mFlag_WOI_BB_LotEnd.Reset();
            mFlag_MainFlowF_LotEnd.Reset();

            SYSPara.CallProc(ModuleName_LPA, "DataReset");
            SYSPara.CallProc(ModuleName_LPB, "DataReset");
            SYSPara.CallProc(ModuleName_LPC, "DataReset");
            SYSPara.CallProc(ModuleName_LPD, "DataReset");
            SYSPara.CallProc(ModuleName_WTR_A, "DataReset");
            SYSPara.CallProc(ModuleName_WTR_B, "DataReset");
            SYSPara.CallProc(ModuleName_WAS_A, "DataReset");
            SYSPara.CallProc(ModuleName_WAS_B, "DataReset");
            SYSPara.CallProc(ModuleName_WOI_AT, "DataReset");
            SYSPara.CallProc(ModuleName_WOI_AB, "DataReset");
            SYSPara.CallProc(ModuleName_WOI_BT, "DataReset");
            SYSPara.CallProc(ModuleName_WOI_BB, "DataReset");

            TrayDataSetting.TrayDataReset();

            LoadOptionData();
            LoadPackageData();
            #endregion

        }

        private void LogDebug(string msg)
        {
            if (SYSPara.OReadValue("EnalbeDebugLog").ToBoolean())
            {
                JLogger.LogDebug("Debug", "MainFlow | " + msg);
            }
        }

        public void FlowChartRecord()
        {
            List<FlowChart> FCs = new List<FlowChart>();
            FCs.Add(FC_Initial_LPA_HomeStart);
            FCs.Add(FC_Initial_LPB_HomeStart);
            FCs.Add(FC_Initial_LPC_HomeStart);
            FCs.Add(FC_Initial_LPD_HomeStart);
            FCs.Add(FC_Initial_WTR_A_HomeStart);
            FCs.Add(FC_Initial_WTR_B_HomeStart);
            FCs.Add(FC_Initial_WAS_A_HomeStart);
            FCs.Add(FC_Initial_WAS_B_HomeStart);
            FCs.Add(FC_Initial_WOI_AT_HomeStart);
            FCs.Add(FC_Initial_WOI_AB_HomeStart);
            FCs.Add(FC_Initial_WOI_BT_HomeStart);
            FCs.Add(FC_Initial_WOI_BB_HomeStart);

            FCs.Add(FC_Auto_LoadPort1_Start);
            FCs.Add(FC_Auto_LoadPort2_Start);
            FCs.Add(FC_Auto_LoadPort3_Start);
            FCs.Add(FC_Auto_LoadPort4_Start);
            FCs.Add(FC_Auto_WAS_A_AligmentRESTAction_Start);
            FCs.Add(FC_Auto_WAS_A_AligmentAction_Start);
            FCs.Add(FC_Auto_WAS_B_AligmentRESTAction_Start);
            FCs.Add(FC_Auto_WAS_B_AligmentAction_Start);
            FCs.Add(FC_Auto_WOI_AT_Start);
            FCs.Add(FC_Auto_WOI_AB_Start);
            FCs.Add(FC_Auto_WOI_BT_Start);
            FCs.Add(FC_Auto_WOI_BB_Start);
            FCs.Add(FC_Auto_WTRMain_Start);
            FCs.Add(FC_Auto_WTR_A_Action_Start);
            FCs.Add(FC_Auto_WTR_B_Action_Start);

            LogRecord.FlowChartRecord("MainFlow", FCs);
        }

        /// <summary>
        /// 儲存流程花費時間
        /// </summary>
        /// <param name="FlowChart_MainRun">MainRun的流程</param>
        /// <param name="Msg">其他訊息</param>
        private void LogFlowChartRunTime(FlowChart FlowChart_MainRun, string Msg = "", bool bHome = false)
        {
            if (SYSPara.OReadValue("UseLogFlowChartRunTime").ToBoolean())
            {
                LogRecord.LogTrace("FLP_MainFlow", FlowChart_MainRun, Msg, bHome);
            }
        }

        private void LoadPackageData()
        { }

        private void LoadOptionData()
        {
            OValue.DryRun = SYSPara.OReadValue("DryRun").ToBoolean();
        }

        private void TimerReset()
        {
            SYSPara.CallProc(ModuleName_LPA, "TimerReset");
            SYSPara.CallProc(ModuleName_LPB, "TimerReset");
            SYSPara.CallProc(ModuleName_LPC, "TimerReset");
            SYSPara.CallProc(ModuleName_LPD, "TimerReset");
            SYSPara.CallProc(ModuleName_WTR_A, "TimerReset");
            SYSPara.CallProc(ModuleName_WTR_B, "TimerReset");
            SYSPara.CallProc(ModuleName_WAS_A, "TimerReset");
            SYSPara.CallProc(ModuleName_WAS_B, "TimerReset");
            SYSPara.CallProc(ModuleName_WOI_AT, "TimerReset");
            SYSPara.CallProc(ModuleName_WOI_AB, "TimerReset");
            SYSPara.CallProc(ModuleName_WOI_BT, "TimerReset");
            SYSPara.CallProc(ModuleName_WOI_BB, "TimerReset");
            TM_Delay_LPA.Restart();
            TM_Delay_LPB.Restart();
            TM_Delay_LPC.Restart();
            TM_Delay_LPD.Restart();
            TM_Delay_WTR_A.Restart();
            TM_Delay_WTR_B.Restart();
            TM_Delay_WAS_A.Restart();
            TM_Delay_WAS_B.Restart();
            TM_Delay_WOI_AT.Restart();
            TM_Delay_WOI_AB.Restart();
            TM_Delay_WOI_BT.Restart();
            TM_Delay_WOI_BB.Restart();
        }

        private AlignerCommand GetAlignerCommand_WAS_A(SANWA_Aligner.CommDef Cmd, params object[] Paramater)
        {
            return (AlignerCommand)SYSPara.CallProc(ModuleName_WAS_A, "GetAlignerCommnad", Cmd, Paramater);
        }

        private AlignerCommand GetAlignerCommand_WAS_B(SANWA_Aligner.CommDef Cmd, params object[] Paramater)
        {
            return (AlignerCommand)SYSPara.CallProc(ModuleName_WAS_B, "GetAlignerCommnad", Cmd, Paramater);
        }
        
        private RobotCommand GetRobotCommand_A(SANWA_Robot.CommDef Cmd, params object[] Paramater)
        {   
            return (RobotCommand)SYSPara.CallProc(ModuleName_WTR_A, "GetRobotCommnad", Cmd, Paramater);
        }

        private RobotCommand GetRobotCommand_B(SANWA_Robot.CommDef Cmd, params object[] Paramater)
        {
            return (RobotCommand)SYSPara.CallProc(ModuleName_WTR_B, "GetRobotCommnad", Cmd, Paramater);
        }

        private bool TrayDataExchange(SANWA_Robot.DefStation station, Arm arm, bool bLeft, int level = 1)
        {
            bool bRet = true;
            switch (station)
            {
                case SANWA_Robot.DefStation.FoupA:
                    switch (arm)
                    {
                        case Arm.A:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_LeftLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_LeftUpperArm, level + 1);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_RightLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_RightUpperArm, level + 1);
                            }
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup1, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    
                    break;
                case SANWA_Robot.DefStation.FoupB:
                    switch (arm)
                    {
                        case Arm.A:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_LeftLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_LeftUpperArm, level + 1);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_RightLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_RightUpperArm, level + 1);
                            }
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup2, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    break;
                case SANWA_Robot.DefStation.FoupC:
                    switch (arm)
                    {
                        case Arm.A:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_LeftLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_LeftUpperArm, level + 1);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_RightLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_RightUpperArm, level + 1);
                            }
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup3, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    break;
                case SANWA_Robot.DefStation.FoupD:
                    switch (arm)
                    {
                        case Arm.A:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_LeftLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_LeftUpperArm, level + 1);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_RightLowerArm, level);
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_RightUpperArm, level + 1);
                            }
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Foup4, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    break;
                case SANWA_Robot.DefStation.AlignerA:
                    switch (arm)
                    {
                        case Arm.A:
                            bRet = false;
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner1, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner1, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner1, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner1, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    break;
                case SANWA_Robot.DefStation.AlignerB:
                    switch (arm)
                    {
                        case Arm.A:
                            bRet = false;
                            break;
                        case Arm.U:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner2, ref TrayDataSetting.tdex_LeftUpperArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner2, ref TrayDataSetting.tdex_RightUpperArm, level);
                            }
                            break;
                        case Arm.L:
                            if (bLeft)
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner2, ref TrayDataSetting.tdex_LeftLowerArm, level);
                            }
                            else
                            {
                                TrayDataSetting.DataChange(ref TrayDataSetting.tdex_Aligner2, ref TrayDataSetting.tdex_RightLowerArm, level);
                            }
                            break;
                        default:
                            bRet = false;
                            break;
                    }
                    break;
                default:
                    bRet = false;
                    break;
            }
            return bRet;
        }

        private void VacuumSwitch_A(EControlOnOff state)
        {
            SYSPara.CallProc(ModuleName_WTR_A, "RobotVacuumSwitch", state);
            SYSPara.CallProc(ModuleName_WAS_A, "VacuumSwitch", state);
        }

        private void VacuumSwitch_B(EControlOnOff state)
        {
            SYSPara.CallProc(ModuleName_WTR_B, "RobotVacuumSwitch", state);
            SYSPara.CallProc(ModuleName_WAS_B, "VacuumSwitch", state);
        }
        
        private JobReference FindJobReference(SANWA_Robot.DefStation station, WaferState state)
        {
            var queryResult = _Joblist
                .SelectMany(job => job.Mappings.Select(mapping => new { Job = job, Mapping = mapping }))
                .FirstOrDefault(item =>
                    item.Mapping.SourceFoup == station &&
                    item.Mapping.State == state
                );

            if (queryResult != null)
            {
                return new JobReference
                {
                    ParentJob = queryResult.Job,
                    OriginalMapping = queryResult.Mapping,
                    CloneMapping = queryResult.Mapping.Clone() 
                };
            }
            return null;
        }

        private SlotMapping GetTransferJob(SANWA_Robot.DefStation station, WaferState state)
        { 
            JobReference jobRef = FindJobReference(station, state);
    
            if (jobRef != null)
            {
                return jobRef.CloneMapping;
            }
            return null;
        }

        public bool RemoveTransferJob(SANWA_Robot.DefStation station, WaferState state)
        {
            JobReference jobRef = FindJobReference(station, state);

            if (jobRef == null)
            {
                return false;
            }

            jobRef.ParentJob.Mappings.Remove(jobRef.OriginalMapping);

            if (jobRef.ParentJob.Mappings.Count == 0)
            {
                _Joblist.Remove(jobRef.ParentJob);
            }

            return true;
        }

        private bool WTR_A_SendAction(SlotMapping ArmMapping)
        {
            bool bRet = false;
            bool b1 = false;
            JActionTask task = Task_WTR_A_SendAction;
            switch (task.Value)
            {
                case 0: //Initial
                    task.Next(10);
                break;
                case 10://Align REST DoIt
                    switch (ArmMapping.NowStation)
                    {
                        case SANWA_Robot.DefStation.AlignerA:
                            FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.DoIt();
                            b1 = true;
                            break;
                        case SANWA_Robot.DefStation.AlignerB:
                            FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.DoIt();
                            b1 = true;
                            break;
                        default:
                            b1 = false;
                            break;
                    }   
                    if (b1)
                        task.Next(20);
                break;
                case 20://Align REST IsDone
                    switch (ArmMapping.NowStation)
                    {
                        case SANWA_Robot.DefStation.AlignerA:
                            b1 = FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.IsDone();
                            break;
                        case SANWA_Robot.DefStation.AlignerB:
                            b1 = FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.IsDone();
                            break;
                        default:
                            break;
                    }
                    if (b1)
                    {
                        task.Next(30);
                    }
                break;
                case 30://Place Wafer to Alinger DoIt
                    RobotCmd = GetRobotCommand_A(SANWA_Robot.CommDef.CMD_PUT, ArmMapping.NowStation, 1, ArmMapping.arm, 0, 0);
                    b1 = (bool)SYSPara.CallProc(ModuleName_WTR_A, "SetCommand", WTR_ActionMode.Put, RobotCmd);
                    if (b1)
                    {
                        task.Next(40);
                    }
                break;
                case 40://Place Wafer to Alinger IsDone
                    b1 = (bool)SYSPara.CallProc(ModuleName_WTR_A, "GetActionResult");
                    if (b1)
                    {
                        
                        task.Next(50);
                    }
                break;
                case 50://DataExchange
                    bool bLeft = ArmMapping.arm == Arm.L ? true : false;
                    b1 = TrayDataExchange(ArmMapping.NowStation, ArmMapping.arm, bLeft, 1);
                    if (b1)
                    {
                        task.Next(99);
                    }
                break;
                case 99:
                    bRet = true;
                break;
            }
            return bRet;
        }
        private bool WTR_B_SendAction(SlotMapping ArmMapping)
        {
            bool bRet = false;
            bool b1 = false;
            JActionTask task = Task_WTR_B_SendAction;
            switch (task.Value)
            {
                case 0: //Initial
                    task.Next(10);
                break;
                case 10://Align REST DoIt
                    switch (ArmMapping.NowStation)
                    {
                        case SANWA_Robot.DefStation.AlignerA:
                            FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.DoIt();
                            b1 = true;
                            break;
                        case SANWA_Robot.DefStation.AlignerB:
                            FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.DoIt();
                            b1 = true;
                            break;
                        default:
                            b1 = false;
                            break;
                    }   
                    if (b1)
                        task.Next(20);
                break;
                case 20://Align REST IsDone
                    switch (ArmMapping.NowStation)
                    {
                        case SANWA_Robot.DefStation.AlignerA:
                            b1 = FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.IsDone();
                            break;
                        case SANWA_Robot.DefStation.AlignerB:
                            b1 = FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.IsDone();
                            break;
                        default:
                            break;
                    }
                    if (b1)
                    {
                        task.Next(30);
                    }
                break;
                case 30://Place Wafer to Alinger DoIt
                    RobotCmd = GetRobotCommand_A(SANWA_Robot.CommDef.CMD_PUT, ArmMapping.NowStation, 1, ArmMapping.arm, 0, 0);
                    b1 = (bool)SYSPara.CallProc(ModuleName_WTR_B, "SetCommand", WTR_ActionMode.Put, RobotCmd);
                    if (b1)
                    {
                        task.Next(40);
                    }
                break;
                case 40://Place Wafer to Alinger IsDone
                    b1 = (bool)SYSPara.CallProc(ModuleName_WTR_B, "GetActionResult");
                    if (b1)
                    {
                        
                        task.Next(50);
                    }
                break;
                case 50://DataExchange
                    bool bLeft = ArmMapping.arm == Arm.L ? true : false;
                    b1 = TrayDataExchange(ArmMapping.NowStation, ArmMapping.arm, bLeft, 1);
                    if (b1)
                    {
                        task.Next(99);
                    }
                break;
                case 99:
                    bRet = true;
                break;
            }
            return bRet;
        }
        #endregion

        #region FlowChart
        #region Initial_FlowChart_Functions
        #region LPA_Home
        private FlowChart.FCRESULT FC_Initial_LPA_HomeStart_Run()
        {
            mFlag_LPA_Home.DoIt();
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_LPA_WaitCommand_Run()
        {
            if (mFlag_WTR_A_Home.IsDone() && mFlag_WTR_B_Home.IsDone())
            {
                mFlag_LPA_Home.Doing();
                mLPA.SetCanHome();
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPA_IsModuleHomeDone_Run()
        {
            if (mLPA.GetUseModule() == false ||
                mLPA.mHomeOk == true)
            {
                mFlag_LPA_Home.Done();
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPA_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region LPB_Home
        private FlowChart.FCRESULT FC_Initial_LPB_HomeStart_Run()
        {
            mFlag_LPB_Home.DoIt();
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_LPB_WaitCommand_Run()
        {
            if (mFlag_WTR_A_Home.IsDone() && mFlag_WTR_B_Home.IsDone())
            {
                mFlag_LPB_Home.Doing();
                mLPB.SetCanHome();
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPB_IsModuleHomeDone_Run()
        {
            if (mLPB.GetUseModule() == false ||
                mLPB.mHomeOk == true)
            {
                mFlag_LPB_Home.Done();
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPB_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region LPC_Home
        private FlowChart.FCRESULT FC_Initial_LPC_HomeStart_Run()
        {
            mFlag_LPC_Home.DoIt();
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_LPC_WaitCommand_Run()
        {
            if (mFlag_WAS_A_Home.IsDone() && mFlag_WAS_B_Home.IsDone())
            {
                mFlag_LPC_Home.Doing();
                mLPC.SetCanHome();
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPC_IsModuleHomeDone_Run()
        {
            if (mLPC.GetUseModule() == false ||
                mLPC.mHomeOk == true)
            {
                mFlag_LPC_Home.Done();
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPC_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region LPD_Home
        private FlowChart.FCRESULT FC_Initial_LPD_HomeStart_Run()
        {
            mFlag_LPD_Home.DoIt();
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_LPD_WaitCommand_Run()
        {
            if (mFlag_WTR_A_Home.IsDone() && mFlag_WTR_B_Home.IsDone())
            {
                mFlag_LPD_Home.Doing();
                mLPD.SetCanHome();
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPD_IsModuleHomeDone_Run()
        {
            if (mLPD.GetUseModule() == false ||
                mLPD.mHomeOk == true)
            {
                mFlag_LPD_Home.Done();
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_LPD_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WTR_A_Home
        private FlowChart.FCRESULT FC_Initial_WTR_A_HomeStart_Run()
        {
            mFlag_WTR_A_Home.DoIt();
            TM_Delay_WTR_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_A_DataUpdate_Run()
        {
            TM_Delay_WTR_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_A_HomeDoIt_Run()
        {
            if (mFlag_LPA_Home.IsDoIt())
            {
                mFlag_LPA_Home.Doing();
                mWTR_A.SetCanHome();
                TM_Delay_WTR_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_A_ModuleHomeIsDone_Run()
        {
            if (mWTR_A.GetUseModule() == false ||
                mWTR_A.mHomeOk == true)
            {
                mFlag_WTR_A_Home.Done();
                TM_Delay_WTR_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_A_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WTR_B_Home
        private FlowChart.FCRESULT FC_Initial_WTR_B_HomeStart_Run()
        {
            mFlag_WTR_B_Home.DoIt();
            TM_Delay_WTR_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_B_DataUpdate_Run()
        {
            TM_Delay_WTR_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_B_HomeDoIt_Run()
        {
            if (mFlag_LPB_Home.IsDoIt())
            {
                mFlag_LPB_Home.Doing();
                mWTR_B.SetCanHome();
                TM_Delay_WTR_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;

        }

        private FlowChart.FCRESULT FC_Initial_WTR_B_ModuleHomeIsDone_Run()
        {
            if (mWTR_B.GetUseModule() == false ||
                mWTR_B.mHomeOk == true)
            {
                mFlag_WTR_B_Home.Done();
                TM_Delay_WTR_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WTR_B_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WAS_A_Home
        private FlowChart.FCRESULT FC_Initial_WAS_A_HomeStart_Run()
        {
            mFlag_WAS_A_Home.DoIt();
            TM_Delay_WAS_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_A_DataUpdate_Run()
        {
            TM_Delay_WAS_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_A_HomeDoIt_Run()
        {
            if (mFlag_WAS_A_Home.IsDoIt())
            {
                mFlag_WAS_A_Home.Doing();
                mWAS_A.SetCanHome();
                TM_Delay_WAS_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_A_ModuleIsHomeDone_Run()
        {
            if (mWAS_A.GetUseModule() == false ||
                mWAS_A.mHomeOk == true)
            {
                mFlag_WAS_A_Home.Done();
                TM_Delay_WAS_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_A_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WAS_B_Home
        private FlowChart.FCRESULT FC_Initial_WAS_B_HomeStart_Run()
        {
            mFlag_WAS_B_Home.DoIt();
            TM_Delay_WAS_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_B_DataUpdate_Run()
        {
            TM_Delay_WAS_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_B_HomeDoIt_Run()
        {
            if (mFlag_WAS_B_Home.IsDoIt())
            {
                mFlag_WAS_B_Home.Doing();
                mWAS_B.SetCanHome();
                TM_Delay_WAS_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_B_ModuleIsHomeDone_Run()
        {
            if (mWAS_B.GetUseModule() == false ||
                mWAS_B.mHomeOk == true)
            {
                mFlag_WAS_B_Home.Done();
                TM_Delay_WAS_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WAS_B_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WOI_AT_Home
        private FlowChart.FCRESULT FC_Initial_WOI_AT_HomeStart_Run()
        {
            mFlag_WOI_AT_Home.DoIt();
            TM_Delay_WOI_AT.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AT_WaitCommand_Run()
        {
            if (mFlag_WOI_AT_Home.IsDoIt())
            {
                mFlag_WOI_AT_Home.Doing();
                mWOI_AT.SetCanHome();
                TM_Delay_WOI_AT.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AT_IsModuleHomeDone_Run()
        {
            if (mWOI_AT.GetUseModule() == false ||
                mWOI_AT.mHomeOk == true)
            {
                mFlag_WOI_AT_Home.Done();
                TM_Delay_WOI_AT.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AT_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WOI_AB_Home
        private FlowChart.FCRESULT FC_Initial_WOI_AB_HomeStart_Run()
        {
            mFlag_WOI_AB_Home.DoIt();
            TM_Delay_WOI_AB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AB_WaitCommand_Run()
        {
            if (mFlag_WOI_AB_Home.IsDoIt())
            {
                mFlag_WOI_AB_Home.Doing();
                mWOI_AB.SetCanHome();
                TM_Delay_WOI_AB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AB_IsModuleHomeDone_Run()
        {
            if (mWOI_AB.GetUseModule() == false ||
                mWOI_AB.mHomeOk == true)
            {
                mFlag_WOI_AB_Home.Done();
                TM_Delay_WOI_AB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_AB_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WOI_BT_Home
        private FlowChart.FCRESULT FC_Initial_WOI_BT_HomeStart_Run()
        {
            mFlag_WOI_BT_Home.DoIt();
            TM_Delay_WOI_BT.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BT_WaitCommand_Run()
        {
            if (mFlag_WOI_BT_Home.IsDoIt())
            {
                mFlag_WOI_BT_Home.Doing();
                mWOI_BT.SetCanHome();
                TM_Delay_WOI_BT.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BT_IsModuleHomeDone_Run()
        {
            if (mWOI_BT.GetUseModule() == false ||
                mWOI_BT.mHomeOk == true)
            {
                mFlag_WOI_BT_Home.Done();
                TM_Delay_WOI_BT.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BT_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #region WOI_BB_Home
        private FlowChart.FCRESULT FC_Initial_WOI_BB_HomeStart_Run()
        {
            mFlag_WOI_BB_Home.DoIt();
            TM_Delay_WOI_BB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BB_WaitCommand_Run()
        {
            if (mFlag_WOI_BB_Home.IsDoIt())
            {
                mFlag_WOI_BB_Home.Doing();
                mWOI_BB.SetCanHome();
                TM_Delay_WOI_BB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BB_IsModuleHomeDone_Run()
        {
            if (mWOI_BB.GetUseModule() == false ||
                mWOI_BB.mHomeOk == true)
            {
                mFlag_WOI_BB_Home.Done();
                TM_Delay_WOI_BB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Initial_WOI_BB_HomeDone_Run()
        {
            return FlowChart.FCRESULT.IDLE;
        }
        #endregion
        #endregion Initial_FlowChart_Function
        #region Auto_FlowChart_Function
        #region LoadPort
        #region LoadPort1
        private FlowChart.FCRESULT FC_Auto_LoadPort1_Start_Run()
        {
            TM_Delay_LPA.Restart(); 
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Initial_Run()
        {
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_CheckPlaceState_Run()
        {
            SYSPara.CallProc(ModuleName_LPA, "SetCanLock", true);
            SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitHandOffReadyToReady_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                    TM_Delay_LPA.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start, "NonStopMode");
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            SYSPara.CallProc(ModuleName_LPA, "ShowModuleAlarm", "W", 25, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPA, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            
            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone()  )
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitHandOffReadyDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                    SYSPara.CallProc(ModuleName_LPA, "SetCanLock", false);
                    LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                    TM_Delay_LPA.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start, "NonStopMode");
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if ((bool)SYSPara.CallProc(ModuleName_LPA, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                SYSPara.CallProc(ModuleName_LPA, "SetCanLock", false);
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_CheckPlacement_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPA, "GetLoadPortPlaceState");
            switch (tRet)
            {
                case ThreeValued.TRUE:
                    LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                    TM_Delay_LPA.Restart();
                    return FlowChart.FCRESULT.NEXT;
                case ThreeValued.FALSE:
                case ThreeValued.UNKNOWN:
                    SYSPara.CallProc(ModuleName_LPA, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                    break;
            }
            LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_CheckClamp_Run()
        {
            //Metal 才需要檢查
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_InputID_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            // switch (InputCassetteIDFormRturn)
            // {
            //     case DialogResult.Cancel:
            //         return FlowChart.FCRESULT.CASE1;
            //     case DialogResult.OK:
            //         return FlowChart.FCRESULT.NEXT;
            //     default:
            //         break;
            // }
            // return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_DoLock_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "SetCommand", FLP_ActionMode.Lock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_LotIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_LPA_Notify_WTR_Lock.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitOpenCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_OpenDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "SetCommand", FLP_ActionMode.Open);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_OpenIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitCloseCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_CloseDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "SetCommand", FLP_ActionMode.Close);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_CloseIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_SetLight_Run()
        {
            SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitHandOffReadyToUnload_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPA, "GetLoadPortPlaceState");
            if (tRet != ThreeValued.TRUE && OValue.DryRun == false)
            {
                SYSPara.CallProc(ModuleName_LPA, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                return FlowChart.FCRESULT.IDLE;
            }

            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start, "NonStopMode");
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            SYSPara.CallProc(ModuleName_LPA, "ShowModuleAlarm", "W", 26, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPA, "GetManualButtonSingal") || bManualTest)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_UnlockDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "SetCommand", FLP_ActionMode.Unlock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_UnloadIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPA, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitHandOffUnloadDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPA, "SetCanUnlock", false);
                FlagDefine.Flag_LPA_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if ((bool)SYSPara.CallProc(ModuleName_LPA, "GetManualButtonSingal") || bManualTest || OValue.NonStopMode)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPA, "SetCanUnlock", false);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPA, "ResetManualButtonSingal");
                FlagDefine.Flag_LPA_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_WaitOtherLoadPort_Run()
        {
            if (FlagDefine.Flag_LPA_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPB_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPC_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPD_Unload_Done.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
                TM_Delay_LPA.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Done_Run()
        {
            FlagDefine.Flag_LPA_Unload_Done.Reset();
            LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Reset_Run()
        {
            SYSPara.CallProc(ModuleName_LPA, "SetCanLock", true);
            LogFlowChartRunTime(FC_Auto_LoadPort1_Start);
            TM_Delay_LPA.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort1_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion LoadPort1
        #region LoadPort2
        private FlowChart.FCRESULT FC_Auto_LoadPort2_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Initial_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_CheckPlaceState_Run()
        {
            SYSPara.CallProc(ModuleName_LPB, "SetCanLock", true);
            SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitHandOffReadyToLoad_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                    TM_Delay_LPB.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start, "NonStopMode");
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            SYSPara.CallProc(ModuleName_LPB, "ShowModuleAlarm", "W", 25, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPB, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitHandOffReadyDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                    SYSPara.CallProc(ModuleName_LPB, "SetCanLock", false);
                    LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                    TM_Delay_LPB.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start, "NonStopMode");
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            if ((bool)SYSPara.CallProc(ModuleName_LPB, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                SYSPara.CallProc(ModuleName_LPB, "SetCanLock", false);
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_CheckPlacement_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPB, "GetLoadPortPlaceState");
            switch (tRet)
            {
                case ThreeValued.TRUE:
                    LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                    TM_Delay_LPB.Restart();
                    return FlowChart.FCRESULT.NEXT;
                case ThreeValued.FALSE:
                case ThreeValued.UNKNOWN:
                    SYSPara.CallProc(ModuleName_LPB, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                    break;
            }
            LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_CheckClamp_Run()
        {
            //Metal 才需要檢查
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_InputID_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            // switch (InputCassetteIDFormRturn)
            // {
            //     case DialogResult.Cancel:
            //         return FlowChart.FCRESULT.CASE1;
            //     case DialogResult.OK:
            //         return FlowChart.FCRESULT.NEXT;
            //     default:
            //         break;
            // }
            // return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_DoLock_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "SetCommand", FLP_ActionMode.Lock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_LockIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_LPB_Notify_WTR_Lock.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitOpenCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_OpenDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "SetCommand", FLP_ActionMode.Open);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_OpenIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitCloseCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_CloseDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "SetCommand", FLP_ActionMode.Close);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_CloseIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_SetLight_Run()
        {
            SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitHandOffReadyToUnload_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPB, "GetLoadPortPlaceState");
            if (tRet != ThreeValued.TRUE && OValue.DryRun == false)
            {
                SYSPara.CallProc(ModuleName_LPB, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                return FlowChart.FCRESULT.IDLE;
            }
            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start, "NonStopMode");
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            SYSPara.CallProc(ModuleName_LPB, "ShowModuleAlarm", "W", 26, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPB, "GetManualButtonSingal") || bManualTest)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_UnlockDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "SetCommand", FLP_ActionMode.Unlock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_UnloadIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitHandOffUnloadDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPB, "SetCanUnlock", false);
                FlagDefine.Flag_LPB_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if ((bool)SYSPara.CallProc(ModuleName_LPB, "GetManualButtonSingal") || bManualTest || OValue.NonStopMode)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPB, "SetCanUnlock", false);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPB, "ResetManualButtonSingal");
                FlagDefine.Flag_LPB_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_WaitOtherLoadPort_Run()
        {
            if (FlagDefine.Flag_LPA_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPB_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPC_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPD_Unload_Done.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
                TM_Delay_LPB.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Done_Run()
        {
            FlagDefine.Flag_LPB_Unload_Done.Reset();
            LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Reset_Run()
        {
            SYSPara.CallProc(ModuleName_LPB, "SetCanLock", true);
            LogFlowChartRunTime(FC_Auto_LoadPort2_Start);
            TM_Delay_LPB.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort2_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region LoadPort3
        private FlowChart.FCRESULT FC_Auto_LoadPort3_Start_Run()
        {
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Initial_Run()
        {
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_CheckPlaceState_Run()
        {
            SYSPara.CallProc(ModuleName_LPC, "SetCanLock", true);
            SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitHandOffReadyToLoad_Run()
        {
            if(SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                    TM_Delay_LPC.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start, "NonStopMode");
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            SYSPara.CallProc(ModuleName_LPC, "ShowModuleAlarm", "W", 25, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPC, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitHandOffReadyDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                    SYSPara.CallProc(ModuleName_LPC, "SetCanLock", false);
                    LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                    TM_Delay_LPC.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start, "NonStopMode");
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            if ((bool)SYSPara.CallProc(ModuleName_LPC, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                SYSPara.CallProc(ModuleName_LPC, "SetCanLock", false);
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_CheckPlacement_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPC, "GetLoadPortPlaceState");
            switch (tRet)
            {
                case ThreeValued.TRUE:
                    LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                    TM_Delay_LPC.Restart();
                    return FlowChart.FCRESULT.NEXT;
                case ThreeValued.FALSE:
                case ThreeValued.UNKNOWN:
                    SYSPara.CallProc(ModuleName_LPC, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                    break;
            }
            LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_CheckClamp_Run()
        {
            //Metal 才需要檢查
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_InputID_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            // switch (InputCassetteIDFormRturn)
            // {
            //     case DialogResult.Cancel:
            //         return FlowChart.FCRESULT.CASE1;
            //     case DialogResult.OK:
            //         return FlowChart.FCRESULT.NEXT;
            //     default:
            //         break;
            // }
            // return FlowChart.FCRESULT.IDLE;

        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_DoLock_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "SetCommand", FLP_ActionMode.Lock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_LockIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_LPC_Notify_WTR_Lock.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitOpenCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_OpenDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "SetCommand", FLP_ActionMode.Open);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_OpenIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitCloseCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_CloseDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "SetCommand", FLP_ActionMode.Close);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_CloseIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_SetLight_Run()
        {
            SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitHandOffReadyToUnload_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPC, "GetLoadPortPlaceState");
            if (tRet != ThreeValued.TRUE && OValue.DryRun == false)
            {
                SYSPara.CallProc(ModuleName_LPC, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                return FlowChart.FCRESULT.IDLE;
            }
            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start, "NonStopMode");
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            SYSPara.CallProc(ModuleName_LPC, "ShowModuleAlarm", "W", 26, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPC, "GetManualButtonSingal") || bManualTest)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_UnlockDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "SetCommand", FLP_ActionMode.Unlock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_UnlockIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPC, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitHandOffUnloadDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPC, "SetCanUnlock", false);
                FlagDefine.Flag_LPC_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if ((bool)SYSPara.CallProc(ModuleName_LPC, "GetManualButtonSingal") || bManualTest || OValue.NonStopMode)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPC, "SetCanUnlock", false);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPC, "ResetManualButtonSingal");
                FlagDefine.Flag_LPC_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_WaitOtherLoadPort_Run()
        {
            if (FlagDefine.Flag_LPA_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPB_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPC_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPD_Unload_Done.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
                TM_Delay_LPC.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Done_Run()
        {
            FlagDefine.Flag_LPC_Unload_Done.Reset();
            LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Reset_Run()
        {
            SYSPara.CallProc(ModuleName_LPC, "SetCanLock", true);
            LogFlowChartRunTime(FC_Auto_LoadPort3_Start);
            TM_Delay_LPC.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort3_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region LoadPort4
        private FlowChart.FCRESULT FC_Auto_LoadPort4_Start_Run()
        {
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Initial_Run()
        {
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_CheckPlaceState_Run()
        {
            SYSPara.CallProc(ModuleName_LPD, "SetCanLock", true);
            SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitHandOffReadyToLoad_Run()
        {
            if(SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                    TM_Delay_LPD.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start, "NonStopMode");
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            SYSPara.CallProc(ModuleName_LPD, "ShowModuleAlarm", "W", 25, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPD, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Blink);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitHandOffReadyDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                if (bManualTest)
                {
                    bManualTest = false;
                    SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                    SYSPara.CallProc(ModuleName_LPD, "SetCanLock", false);
                    LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                    TM_Delay_LPD.Restart();
                    return FlowChart.FCRESULT.NEXT;
                }
            }

            if (OValue.NonStopMode)
            {
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start, "NonStopMode");
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            if ((bool)SYSPara.CallProc(ModuleName_LPD, "GetManualButtonSingal"))
            {
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToLoad, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                SYSPara.CallProc(ModuleName_LPD, "SetCanLock", false);
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_CheckPlacement_Run()
        {
            if (OValue.DryRun)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPD, "GetLoadPortPlaceState");
            switch (tRet)
            {
                case ThreeValued.TRUE:
                    LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                    TM_Delay_LPD.Restart();
                    return FlowChart.FCRESULT.NEXT;
                case ThreeValued.FALSE:
                case ThreeValued.UNKNOWN:
                    SYSPara.CallProc(ModuleName_LPD, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                    break;
            }
            LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_CheckClamp_Run()
        {
            //Metal 才需要檢查
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_InputID_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            // switch (InputCassetteIDFormRturn)
            // {
            //     case DialogResult.Cancel:
            //         return FlowChart.FCRESULT.CASE1;
            //     case DialogResult.OK:
            //         return FlowChart.FCRESULT.NEXT;
            //     default:
            //         break;
            // }
            // return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_DoLock_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "SetCommand", FLP_ActionMode.Lock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_LockIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_LPD_Notify_WTR_Lock.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitOpenCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_OpenDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "SetCommand", FLP_ActionMode.Open);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_OpenIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitCloseCommand_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.Doing();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_CloseDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "SetCommand", FLP_ActionMode.Close);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_CloseIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_SetLight_Run()
        {
            SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.On);
            SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.On);
            LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitHandOffReadyToUnload_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            ThreeValued tRet = (ThreeValued)SYSPara.CallProc(ModuleName_LPD, "GetLoadPortPlaceState");
            if (tRet != ThreeValued.TRUE && OValue.DryRun == false)
            {
                SYSPara.CallProc(ModuleName_LPD, "ShowModuleAlarm", "E", 7, null); //放置偵測異常
                return FlowChart.FCRESULT.IDLE;
            }
            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start, "NonStopMode");
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            SYSPara.CallProc(ModuleName_LPD, "ShowModuleAlarm", "W", 26, null);
            if ((bool)SYSPara.CallProc(ModuleName_LPD, "GetManualButtonSingal") || bManualTest)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_UnlockDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "SetCommand", FLP_ActionMode.Unlock);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_UnloadIsDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_LPD, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitHandOffUnloadDone_Run()
        {
            if (SYSPara.Simulation != 0)
            {
                SYSPara.CallProc(ModuleName_LPD, "SetCanUnlock", false);
                FlagDefine.Flag_LPD_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if ((bool)SYSPara.CallProc(ModuleName_LPD, "GetManualButtonSingal") || bManualTest || OValue.NonStopMode)
            {
                bManualTest = false;
                SYSPara.CallProc(ModuleName_LPD, "SetCanUnlock", false);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ReadyToUnload, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "SetLightData", LP_Light.ManualButton, LP_Light_Mode.Off);
                SYSPara.CallProc(ModuleName_LPD, "ResetManualButtonSingal");
                FlagDefine.Flag_LPD_Unload_Done.Done();
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_WaitOtherLoadPort_Run()
        {
            if (FlagDefine.Flag_LPA_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPB_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPC_Unload_Done.IsDone() &&
                FlagDefine.Flag_LPD_Unload_Done.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
                TM_Delay_LPD.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Done_Run()
        {
            FlagDefine.Flag_LPD_Unload_Done.Reset();
            LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Reset_Run()
        {
            SYSPara.CallProc(ModuleName_LPD, "SetCanLock", true);
            LogFlowChartRunTime(FC_Auto_LoadPort4_Start);
            TM_Delay_LPD.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_LoadPort4_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #endregion
        #region WTR
        #region WTRMain
        private FlowChart.FCRESULT FC_Auto_WTRMain_Start_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_CanPlaceCarrier_Run()
        {
            if (mLPA.GetUseModule() == false && mLPB.GetUseModule() == false &&
                mLPC.GetUseModule() == false && mLPD.GetUseModule() == false)
            {
                return FlowChart.FCRESULT.NEXT;
            }

            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_WTRMain_Start, "NonStopMode");
                return FlowChart.FCRESULT.NEXT;
            }

            if (FlagDefine.Flag_Port_NotifyMAA_A_LoadGateClose.IsDoIt() || 
                FlagDefine.Flag_Port_NotifyMAA_B_LoadGateClose.IsDoIt() ||
                FlagDefine.Flag_Port_NotifyMAA_C_LoadGateClose.IsDoIt() ||
                FlagDefine.Flag_Port_NotifyMAA_D_LoadGateClose.IsDoIt())
            {
                SYSPara.CallProc(ModuleName_MAA, "SwitchGatePass", true);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_PlaceCarrierFinish_Run()
        {
            if (mLPA.GetUseModule() == false && mLPB.GetUseModule() == false &&
                mLPC.GetUseModule() == false && mLPD.GetUseModule() == false)
            {
                _ContinueRun = false;
                return FlowChart.FCRESULT.NEXT;
            }

            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_WTRMain_Start, "NonStopMode");
                _ContinueRun = false;//v1.0.0.13
                return FlowChart.FCRESULT.NEXT;
            }

            if (FlagDefine.Flag_Port_NotifyMAA_A_LoadGateClose.IsDone() && FlagDefine.Flag_Port_NotifyMAA_B_LoadGateClose.IsDone() &&
                FlagDefine.Flag_Port_NotifyMAA_C_LoadGateClose.IsDone() && FlagDefine.Flag_Port_NotifyMAA_D_LoadGateClose.IsDone())
            {
                SYSPara.CallProc("MAA", "SwitchGatePass", false);
                _ContinueRun = false;//v1.0.0.13
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_WaitCanWork_Run()
        {
            if (FlagDefine.Flag_LPA_Notify_WTR_Lock.IsDone() &&
                FlagDefine.Flag_LPB_Notify_WTR_Lock.IsDone() &&
                FlagDefine.Flag_LPC_Notify_WTR_Lock.IsDone() &&
                FlagDefine.Flag_LPD_Notify_WTR_Lock.IsDone())
            {
                bUpdateDataGridView = true;
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_OpenCoverDoIt_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.IsDoing() == false)
            {
                FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.DoIt();
                VacuumSwitch_A(EControlOnOff.ON);
                VacuumSwitch_B(EControlOnOff.ON);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_OpenCoverDone_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_OpenDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPB_OpenDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPC_OpenDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPD_OpenDoor.IsDone())
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_MappingDoIt_Run()
        {
            //模組開門的時候就會做Mapping動作
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_MappingDone_Run()
        {
            //模組開門的時候就會做Mapping動作
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_SelectWorkMode_Run()
        {
            return FlowChart.FCRESULT.NEXT;
            //ModeForm ModeF = new ModeForm();
            //ModeF.StartPosition = FormStartPosition.CenterScreen;
            //ModeF.TopLevel = true;
            //ModeF.TopMost = true;
            //ModeForm.Activate();
            //ModeF.BringToFront();
            //DialogResult dr = ModeF.ShowDialog();
            //if (dr == System.Windows.Forms.DialogResult.OK)
            //{
            //    FormSet.mMainF1.DelegateUpdateIndexTime(DataLayer.CheckWorkCount.ToString(), 6);//Gary v1.0.0.11 
            //    return FlowChart.FCRESULT.NEXT;
            //}
            //return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_NeedLotEnd_Run()
        {
            if (SYSPara.Lotend)
            {
                if (FlagDefine.Flag_WTR_A_Action.IsDone() && 
                    FlagDefine.Flag_WTR_B_Action.IsDone())
                {
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.CASE1;            
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_WTRWorkDoIt_Run()
        {
            if (FlagDefine.Flag_WTR_A_Action.IsDoing() == false &&
                FlagDefine.Flag_WTR_B_Action.IsDoing() == false)
            {
                FlagDefine.Flag_WTR_A_Action.DoIt();
                FlagDefine.Flag_WTR_B_Action.DoIt();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_Next2_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_CloseCoverDoIt_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.IsDoing() == false &&
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.IsDoing() == false)
            {
                FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.DoIt();
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.DoIt();
                
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_CloseCoverDone_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_LPA_CloseDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPB_CloseDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPC_CloseDoor.IsDone() &&
                FlagDefine.Flag_WTR_Notify_LPD_CloseDoor.IsDone())
            {
                VacuumSwitch_A(EControlOnOff.OFF);
                VacuumSwitch_B(EControlOnOff.OFF);
                bManualTest = false;
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_CanTackoutCarrier_Run()
        {
            _ContinueRun = true;
            if (mLPA.GetUseModule() == false && mLPB.GetUseModule() == false &&
                mLPC.GetUseModule() == false && mLPD.GetUseModule() == false)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            if (OValue.NonStopMode)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            if (FlagDefine.Flag_Port_NotifyMAA_A_UnloadGateClose.IsDoIt() ||
                FlagDefine.Flag_Port_NotifyMAA_B_UnloadGateClose.IsDoIt() ||
                FlagDefine.Flag_Port_NotifyMAA_C_UnloadGateClose.IsDoIt() ||
                FlagDefine.Flag_Port_NotifyMAA_D_UnloadGateClose.IsDoIt())
            {
                SYSPara.CallProc(ModuleName_MAA, "SwitchGatePass", true);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_TakeoutCarrierFinish_Run()
        {
            if (mLPA.GetUseModule() == false && mLPB.GetUseModule() == false &&
                mLPC.GetUseModule() == false && mLPD.GetUseModule() == false)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            if (OValue.NonStopMode)
            {
                LogFlowChartRunTime(FC_Auto_WTRMain_Start, "NonStopMode");
                return FlowChart.FCRESULT.NEXT;
            }
            if (FlagDefine.Flag_Port_NotifyMAA_A_UnloadGateClose.IsDone() && FlagDefine.Flag_Port_NotifyMAA_B_UnloadGateClose.IsDone() &&
                FlagDefine.Flag_Port_NotifyMAA_C_UnloadGateClose.IsDone() && FlagDefine.Flag_Port_NotifyMAA_D_UnloadGateClose.IsDone())
            {
                SYSPara.CallProc("MAA", "SwitchGatePass", false);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_LotEnd_Run()
        {
            iWorkCount = 0;
            if (OValue.NonStopMode)
            {
                
            }
            else
            {
                SYSPara.ShowAlarm("i", 10);
            }
            if (SYSPara.Lotend)
            {
                SYSPara.LotendOk = true;
            }
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_Next3_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_Next4_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_MappingFail_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTRMain_Next5_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region WTR_A_Action
        private FlowChart.FCRESULT FC_Auto_WTR_A_Action_Start_Run()
        {
            TM_Delay_WTR_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }


        private FlowChart.FCRESULT FC_Auto_WTR_A_FlagIsDoIt_Run()
        {
            if (SYSPara.Lotend)
            {
                if (_Joblist.Count == 0)
                {
                    FlagDefine.Flag_WTR_A_Action.Done();
                    return FlowChart.FCRESULT.IDLE;
                }
            }

            if (FlagDefine.Flag_WTR_A_Action.IsDoIt())
            {
                LogFlowChartRunTime(FC_Auto_WTR_A_Action_Start);
                TM_Delay_WTR_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_IsNeedSendToAligner_Run()
        {
            //如果手臂的料、料的SlotMapping.State == NeedToDo 且 Aligner有空位則需要送去Aligner
            bool b1 = TrayDataSetting.tdex_Aligner1.IsContain(GlobalBinDefine.NoWaferBin);
            bool b2 = TrayDataSetting.tdex_Aligner2.IsContain(GlobalBinDefine.NoWaferBin);
            if (b1)
            {
                if (LeftUpperArm_Job != null &&
                    LeftUpperArm_Job.State == WaferState.NeedToDo)  
                {
                    LeftUpperArm_Job.NowStation = SANWA_Robot.DefStation.AlignerA;
                    LeftArm_Job = LeftUpperArm_Job;
                    return FlowChart.FCRESULT.NEXT;
                }
                else if (LeftLowerArm_Job != null &&
                    LeftLowerArm_Job.State == WaferState.NeedToDo)
                {
                    LeftLowerArm_Job.NowStation = SANWA_Robot.DefStation.AlignerA;
                    LeftArm_Job = LeftLowerArm_Job;
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            if (b2)
            {
                if (LeftUpperArm_Job != null &&
                    LeftUpperArm_Job.State == WaferState.NeedToDo)
                {
                    LeftUpperArm_Job.NowStation = SANWA_Robot.DefStation.AlignerB;
                    LeftArm_Job = LeftUpperArm_Job;
                    return FlowChart.FCRESULT.NEXT;
                }
                else if (LeftLowerArm_Job != null &&
                    LeftLowerArm_Job.State == WaferState.NeedToDo)
                {
                    LeftLowerArm_Job.NowStation = SANWA_Robot.DefStation.AlignerB;
                    LeftArm_Job = LeftLowerArm_Job;
                    return FlowChart.FCRESULT.NEXT;
                }
            }
            return FlowChart.FCRESULT.CASE1;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_ResetSendAction_Run()
        {
            Task_WTR_A_SendAction.Reset();
            TM_Delay_WTR_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_SendActionDoIt_Run()
        {
            bool b1 = WTR_A_SendAction(LeftArm_Job);
            if (b1)
            {
                TM_Delay_WTR_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_AlignementDoIt_Run()
        {
            switch (LeftArm_Job.NowStation)
            {
                case SANWA_Robot.DefStation.AlignerA:
                    {
                        if (FlagDefine.Flag_WTR_Notify_WAS_A_Align.IsDoing() == false)
                        {
                            FlagDefine.Flag_WTR_Notify_WAS_A_Align.DoIt();
                            return FlowChart.FCRESULT.NEXT;
                        }
                    }
                    break;
                case SANWA_Robot.DefStation.AlignerB:
                    {
                        if (FlagDefine.Flag_WTR_Notify_WAS_B_Align.IsDoing() == false)
                        {
                            FlagDefine.Flag_WTR_Notify_WAS_B_Align.DoIt();
                            return FlowChart.FCRESULT.NEXT;
                        }
                    }
                    break;
                default:
                    break;
            }   
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next6_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next7_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_IsNeedReceiveFromAligner_Run()
        {
            //如果Aligner有料且手臂沒料則需要從Aligner收料
            bool b1 = TrayDataSetting.tdex_Aligner1.IsContain(GlobalBinDefine.HasWaferBin);
            bool b2 = TrayDataSetting.tdex_Aligner2.IsContain(GlobalBinDefine.HasWaferBin);
            // bool b3 = TrayDataSetting.tdex_LeftUpperArm.IsContain(GlobalBinDefine.NoWaferBin);
            // bool b4 = TrayDataSetting.tdex_LeftUpperArm.IsContain(GlobalBinDefine.NoWaferBin);
            bool b3 = (LeftUpperArm_Job.State == WaferState.NoWafer);
            bool b4 = (LeftLowerArm_Job.State == WaferState.NoWafer);
            if (FlagDefine.Flag_WTR_Notify_WAS_A_Align.IsDone())
            {
                
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_ResetReceiveAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_ReceiveActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next5_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_IsNeedLoadFromPort_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_ResetLoadAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_LoadActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next4_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_IsNeedUnloadToPort_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_ResetUnloadAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_UnloadActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next3_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next1_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_A_Next2_Run()
        {
            return default(FlowChart.FCRESULT);
        }
        #endregion
        #region WTR_B_Action
        private FlowChart.FCRESULT FC_Auto_WTR_B_Action_Start_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_FlagIsDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_IsNeedSendToAligner_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_ResetSendAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_SendActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_AlignementDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next1_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next2_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_IsNeedReceiveFromAligner_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_ResetReceiveAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_ReceiveActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next3_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_IsNeedLoadFromPort_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_ResetLoadAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_LoadActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next4_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_IsNeedUnloadToPort_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_ResetUnloadAction_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_UnloadActionDoIt_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next5_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next6_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        private FlowChart.FCRESULT FC_Auto_WTR_B_Next7_Run()
        {
            return default(FlowChart.FCRESULT);
        }
        #endregion
        #endregion
        #region WAS
        #region WAS_A_RESTAction
        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentRESTAction_Start_Run()
        {
            TM_Delay_WAS_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }       

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentRESTAction_IsActionNeedToDo_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.Doing();
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentRESTAction_Start);
                TM_Delay_WAS_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentRESTAction_AlignRESTIsDone_Run()
        {
            AlignerCmd = GetAlignerCommand_WAS_A(SANWA_Aligner.CommDef.CMD_HOME);
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_A, "SetCommand", WAS_ActionMode.PreAction, AlignerCmd);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentRESTAction_Start);
                TM_Delay_WAS_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentRESTAction_ActionDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_A, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_WAS_A_PreAlign.Done();
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentRESTAction_Start);
                TM_Delay_WAS_A.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_Next1_Run()
        {
            TM_Delay_WAS_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_Next2_Run()
        {
            TM_Delay_WAS_A.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region WAS_A_AlimentAction
        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_Start_Run()
        {
            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start, "LotEnd Skip Aligment");
                return FlowChart.FCRESULT.CASE1;
            }
            
            if (FlagDefine.Flag_WTR_Notify_WAS_A_Align.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_WAS_A_Align.Doing();
                TrayDataSetting.tdex_Aligner1.ResetBin(new byte[] {(byte)_BinDefine.DoAlign});
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }   
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_AligmentDoIt_Run()
        {
            AlignerCmd = GetAlignerCommand_WAS_A(SANWA_Aligner.CommDef.CMD_ALIGN);
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_A, "SetCommand", WAS_ActionMode.Align, AlignerCmd);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_AligmentDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_A, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_WAS_A_Align.Done();
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_OCRAligmentDoIt_Run()
        {
            if (FlagDefine.Flag_WAS_A_Notify_WOI_OCR.IsDoing() == false)
            {
                FlagDefine.Flag_WAS_A_Notify_WOI_OCR.DoIt();
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_OCRAligmentDone_Run()
        {
            if (FlagDefine.Flag_WAS_A_Notify_WOI_OCR.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_AfterOCRActionDoIt_Run()
        {
            //這個版本沒有AfterAction
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_AfterOCRActionDone_Run()
        {
            //這個版本沒有AfterAction
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_AligmentActionDone_Run()
        {
            FlagDefine.Flag_WTR_Notify_WAS_A_Align.Done();
            LogFlowChartRunTime(FC_Auto_WAS_A_AligmentAction_Start);
            return FlowChart.FCRESULT.NEXT;;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_A_AligmentAction_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region WAS_B_RESTAction
        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_Start_Run()
        {
            TM_Delay_WAS_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_IsActionNeedToDo_Run()
        {
            if (FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.Doing();
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentRESTAction_Start);
                TM_Delay_WAS_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_AlignRESTIsDone_Run()
        {
            AlignerCmd = GetAlignerCommand_WAS_B(SANWA_Aligner.CommDef.CMD_HOME);
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_B, "SetCommand", WAS_ActionMode.PreAction, AlignerCmd);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentRESTAction_Start);
                TM_Delay_WAS_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_ActionDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_B, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_WAS_B_PreAlign.Done();
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentRESTAction_Start);
                TM_Delay_WAS_B.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_Next1_Run()
        {
            TM_Delay_WAS_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentRESTAction_Next2_Run()
        {
            TM_Delay_WAS_B.Restart();
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #region WAS_B_AligmentAction
        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_Start_Run()
        {
            if (mFlag_WTR_A_LotEnd.IsDone() && mFlag_WTR_B_LotEnd.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start, "LotEnd Skip Aligment");
                return FlowChart.FCRESULT.CASE1;
            }

            if (FlagDefine.Flag_WTR_Notify_WAS_B_Align.IsDoIt())
            {
                FlagDefine.Flag_WTR_Notify_WAS_B_Align.Doing();
                TrayDataSetting.tdex_Aligner2.ResetBin(new byte[] { (byte)_BinDefine.DoAlign });
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_AligmentDoIt_Run()
        {
            AlignerCmd = GetAlignerCommand_WAS_B(SANWA_Aligner.CommDef.CMD_ALIGN);
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_B, "SetCommand", WAS_ActionMode.Align, AlignerCmd);
            if (b1)
            {
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_AligmentDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WAS_B, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WTR_Notify_WAS_B_Align.Done();
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_OCRAligmentDoIt_Run()
        {
            if (FlagDefine.Flag_WAS_B_Notify_WOI_OCR.IsDoing() == false)
            {
                FlagDefine.Flag_WAS_B_Notify_WOI_OCR.DoIt();

                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_OCRAligmentDone_Run()
        {
            if (FlagDefine.Flag_WAS_B_Notify_WOI_OCR.IsDone())
            {
                LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_AfterOCRActionDoIt_Run()
        {
            //這個版本沒有AfterAction
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_AfterOCRActionDone_Run()
        {
            //這個版本沒有AfterAction
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_AligmentActionDone_Run()
        {
            FlagDefine.Flag_WTR_Notify_WAS_B_Align.Done();
            LogFlowChartRunTime(FC_Auto_WAS_B_AligmentAction_Start);
            return FlowChart.FCRESULT.NEXT;;
        }

        private FlowChart.FCRESULT FC_Auto_WAS_B_AligmentAction_Next1_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion
        #endregion WAS
        #region WOI
        #region WOI_AT
        private FlowChart.FCRESULT FC_Auto_WOI_AT_Start_Run()
        {
            if (FlagDefine.Flag_WAS_A_Notify_WOI_OCR.IsDoIt() && OCROnTop)
            {
                FlagDefine.Flag_WAS_A_Notify_WOI_OCR.Doing();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_AT_AlignDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_AT, "SetCommand", WOI_ActionMode.Inspection);
            if (b1)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }


        private FlowChart.FCRESULT FC_Auto_WOI_AT_AlignDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_AT, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WAS_A_Notify_WOI_OCR.Done();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_AT_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion WOI_AT
        #region WOI_AB
        private FlowChart.FCRESULT FC_Auto_WOI_AB_Start_Run()
        {
            if (FlagDefine.Flag_WAS_A_Notify_WOI_OCR.IsDoIt() && OCROnTop == false)
            {
                FlagDefine.Flag_WAS_A_Notify_WOI_OCR.Doing();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_AB_AlignDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_AB, "SetCommand", WOI_ActionMode.Inspection);
            if (b1)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_AB_AlignDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_AB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WAS_A_Notify_WOI_OCR.Done();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_AB_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion WOI_AB
        #region WOI_BT
        private FlowChart.FCRESULT FC_Auto_WOI_BT_Start_Run()
        {
            if (FlagDefine.Flag_WAS_B_Notify_WOI_OCR.IsDoIt() && OCROnTop)
            {
                FlagDefine.Flag_WAS_B_Notify_WOI_OCR.Doing();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BT_AlignDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_BT, "SetCommand", WOI_ActionMode.Inspection);
            if (b1)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BT_AlignDone_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_BT, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WAS_B_Notify_WOI_OCR.Done();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BT_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion WOI_BT
        #region WOI_BB
        private FlowChart.FCRESULT FC_Auto_WOI_BB_Start_Run()
        {
            if (FlagDefine.Flag_WAS_B_Notify_WOI_OCR.IsDoIt() && OCROnTop == false)
            {
                FlagDefine.Flag_WAS_B_Notify_WOI_OCR.Doing();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BB_AlignDoIt_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_BB, "SetCommand", WOI_ActionMode.Inspection);
            if (b1)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BB_Done_Run()
        {
            bool b1 = (bool)SYSPara.CallProc(ModuleName_WOI_BB, "GetActionResult");
            if (b1)
            {
                FlagDefine.Flag_WAS_B_Notify_WOI_OCR.Done();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_Auto_WOI_BB_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }
        #endregion WOI_BB
        #endregion WOI
        #endregion
        #endregion FlowChart
    }

    

}