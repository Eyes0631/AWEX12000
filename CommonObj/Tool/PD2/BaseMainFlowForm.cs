using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProVLib;
using ProVIFM;
using PaeLibGeneral;

namespace CommonObj
{
    public partial class BaseMainFlowFrom : Form
    {
        public BaseMainFlowFrom()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.Visible = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;//UI會偷改這個參數，記得要檢查
        }

        protected string MainFlowName = "BaseMainFlow";

        public string SubFlowName = "";
        public string GetSubFlowName { get { return SubFlowName; } set { SubFlowName = value; } }

        protected bool mHomeOk = false;
        public bool GetHomeOK { get { return mHomeOk; } }

        protected bool mLotendOK = false;
        public bool LotendOK { get { return mLotendOK; } }

        protected MyTimer HomeTM = new MyTimer();

        protected MyTimer RunTM = new MyTimer();

        protected string ModuleName = "";

        //臨時測試動作使用
        protected bool bModuleTest = false;

        //計算用取放點位
        protected Point PLevel_tmp = new Point();

        //命令用取放點位
        protected Point PLevel = new Point();

        protected List<FlowChart> FC_RecordList = new List<FlowChart>();

        public List<FlowChart> FlowChartList = new List<FlowChart>();

        protected CommandClass CommClass = new CommandClass();

        #region 使用者修改 (定義各模組指標，方便使用)

        protected BaseModuleInterface mMAA;

        protected BaseModuleInterface mCLP;
        protected BaseModuleInterface mCSS;
        protected BaseModuleInterface mDBS;
        protected BaseModuleInterface mFHR;
        protected BaseModuleInterface mFLP;

        protected BaseModuleInterface mLHR;
        protected BaseModuleInterface mNSS;
        protected BaseModuleInterface mPHR;
        protected BaseModuleInterface mSDS;
        protected BaseModuleInterface mTHR;

        protected BaseModuleInterface mWAI;
        protected BaseModuleInterface mWBS;
        protected BaseModuleInterface mWTR;

        protected BaseModuleInterface mPBM;
        protected BaseModuleInterface mUBM;
        protected BaseModuleInterface mPVU;
        protected BaseModuleInterface mHTU;
        #endregion

        #region 動作函數 //+ By Multi MainFlow (Interface)

        //初始化函數
        public virtual void Initial()
        {

        }
        //持續掃描
        public virtual void AlwaysRun()
        {

        }
        //掃描硬體按鈕IO
        public virtual void ScanIO()
        {

        }
        //歸零前的重置
        public virtual void HomeReset()
        {
            InitialFlow.TaskReset();
            mHomeOk = false;
        }
        //歸零
        public virtual bool Home()
        {
            InitialFlow.MainRun();
            return mHomeOk;
        }
        //運轉前初始化
        public virtual void RunReset()
        {
            mLotendOK = false;
        }
        //運轉
        public virtual void Run()
        {
        }
        //手動運行前置設定
        public virtual void ManualReset()
        {
        }
        //手動模式運行
        public virtual void ManualRun()
        {
        }
        //維修模式前置設定
        public virtual void MaintenanceReset()
        {
        }
        //維修模式運行
        public virtual void MaintenanceRun()
        {
        }
        //解構
        public virtual void DisposeTH()
        {
        }
        //紀錄FlowChart運行
        public virtual void FlowChartRecord()
        {

        }

        public void LogTrace(FlowChart FC, string Msg = null, bool bHome = false)
        {
            LogRecord.LogTrace_MainFlow(MainFlowName, FC, Msg, bHome);
        }
        #endregion 動作函數 //+ By Multi MainFlow



        public virtual ThreeValued SetActionCommand(CommandClass CommClass)
        {
            return ThreeValued.UNKNOWN;
        }

        public virtual ThreeValued GetActionResult(CommandClass CommClass)
        {
            return ThreeValued.UNKNOWN;
        }

        public virtual void GetControls(Control ctr)
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
                {
                    FlowChart tmp = (FlowChart)myctr;

                    FlowChartList.Add(tmp);

                    if (tmp.IsFlowHead == true)
                    {
                        FC_RecordList.Add(tmp);
                    }
                }
            }
        }

        public virtual FlowChart.FCRESULT InitialFlow_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        public virtual FlowChart.FCRESULT InitialFlow_Check_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        public virtual FlowChart.FCRESULT InitialFlow_Strat_Run()
        {
            return default(FlowChart.FCRESULT);
        }

        public virtual FlowChart.FCRESULT InitialFlow_Done_Run()
        {
            mHomeOk = true;

            return FlowChart.FCRESULT.IDLE;
        }

    }
}



//#region 動作函數

////初始化函數
//public override void Initial()
//{

//}

////持續掃描
//public override void AlwaysRun()
//{

//}

////掃描硬體按鈕IO
//public override void ScanIO()
//{

//}

////歸零前的重置
//public override void HomeReset()
//{
//    #region 使用者修改 (針對各模式的歸零前置設定)

//    #endregion

//    mHomeOk = false;
//}

////歸零
//public override bool Home()
//{
//    return mHomeOk;
//}

////運轉前初始化
//public override void RunReset()
//{
//}

////運轉
//public override void Run()
//{
//    //是否進行結批流程
//    if (SYSPara.Lotend)
//    {
//        //設定MainFlow模組結批完成
//        SYSPara.LotendOk = true;
//    }
//}

////手動運行前置設定
//public override void ManualReset()
//{
//}

////手動模式運行
//public override void ManualRun()
//{
//}

////維修模式前置設定
//public override void MaintenanceReset()
//{
//}

////維修模式運行
//public override void MaintenanceRun()
//{
//}

////解構
//public override void DisposeTH()
//{

//}

//紀錄FlowChart運行
//public override void FlowChartRecord()
//{
//List<FlowChart> FCs = new List<FlowChart>();
//LogRecord.FlowChartRecord("WTR_SubFlow", FCs);
//}



//#endregion 動作函數