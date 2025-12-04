using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KCSDK;
using PaeLibGeneral;
using ProVLib;
using System.Windows.Forms;

namespace CommonObj
{

    #region class
    public delegate bool StatusDelegateCtrl(bool SW = true);

    public class CommonObj
    {

    }

    public class CommandClass
    {
        public CommandClass()
        {
            dPoint = new PointDT();
            iPoint = new IPointDT();

            eWOI_ActionMode = new WOI_ActionMode();
            eWTS_ActionMode = new WTS_ActionMode();
            eMAA_ActionMode = new MAA_ActionMode();
            eWFI_ActionMode = new WFI_ActionMode();
            eWCS_ActionMode = new WCS_ActionMode();
            eCLP_ActionMode = new CLP_ActionMode();

            iZSlot = -1;
        }

        public PointDT dPoint;
        public IPointDT iPoint;

        public WOI_ActionMode eWOI_ActionMode;
        public WTS_ActionMode eWTS_ActionMode;
        public MAA_ActionMode eMAA_ActionMode;
        public WFI_ActionMode eWFI_ActionMode;
        public WCS_ActionMode eWCS_ActionMode;
        public CLP_ActionMode eCLP_ActionMode;

        public int iZSlot;
    }

    //若須回傳資訊，請放入此類別
    public class ReturnClass
    {
        public bool Ret = false;
        public string sOCR = "";
        public string sBarCode = "";
    }

    //By Max, 20220418
    public class VIDDS
    {
        private static readonly object Mutex = new object();
        private static volatile KCSDK.DataManagement _instance;

        private VIDDS()
        {
            _instance = new DataManagement();
        }

        public static KCSDK.DataManagement DS
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new KCSDK.DataManagement();
                            _instance.ModifiedLog = false;
                            _instance.ModifiedLogToDB = false;
                        }
                    }
                }
                return _instance;
            }
        }

        public static DataTransfer ReadValue(String DataName)
        {
            return DS.ReadValue(DataName);
        }

        public static void SetValue(string FieldName, object value)
        {
            DS.SetData(FieldName, "String", value);
        }
    }

    public class OEEperformance //PD2
    {
        private string sInput = "";
        private string sOutput = "";
        private string sIndexTime = "";
        private string sUPH = "";
        private string sWorkTM = "";
        private string sManualTM = "";
        private string sStopTM = "";
        private string sOperationStartTM = "";

        public string Input
        {
            set
            {
                sInput = value;
            }
        }

        public string Output
        {
            set
            {
                sOutput = value;
            }
        }

        public string IndexTime
        {
            set
            {
                sIndexTime = value;
            }
        }

        public string UPH
        {
            set
            {
                sUPH = value;
            }
        }

        public string WorkTM
        {
            set
            {
                sWorkTM = value;
            }
        }

        public string ManualTM
        {
            set
            {
                sManualTM = value;
            }
        }

        public string StopTM
        {
            set
            {
                sStopTM = value;
            }
        }

        public string OperationStartTM
        {
            set
            {
                sOperationStartTM = value;
            }
        }

        public string GetFormatString()
        {
            string sSPCString = string.Format("WPH,{0},{1},{2},{3},{4},{5},{6},{7}",
                                sInput,//預計工作數量
                                sOutput,//實際工作完成數量
                                sIndexTime,//index time
                                sUPH,//估測WPH
                                sWorkTM,//工作時間
                                sManualTM,//機台手動時間
                                sStopTM,//工作暫停時間
                                sOperationStartTM//開始工作時間
                                );
            return sSPCString;
        }
    }

    public static class LogRecord
    {
        public static bool LogEnable_MainFlow = false;
        public static bool LogEnable_Module = false;

        public static void LogTrace_MainFlow(string ModuleName, FlowChart FC, string Msg, bool bHome = false)
        {
            if (LogEnable_MainFlow)
            {
                string com = " | ";
                string sMsg = "MainFlow" + ModuleName + com + FC.Text + com + FC.NowTask.Text + com + Msg + com + FC.NowTask.RunTime;
                if (bHome)
                {
                    JLogger.LogTrace("Home", sMsg);
                }
                else
                {
                    JLogger.LogTrace("Auto", sMsg);
                }
            }
        }

        public static void LogTrace(string ModuleName, FlowChart FC, string Msg, bool bHome = false)
        {
            if (LogEnable_Module)
            {
                string com = " | ";
                string sMsg = ModuleName + com + FC.Text + com + FC.NowTask.Text + com + Msg + com + FC.NowTask.RunTime;
                if (bHome)
                {
                    JLogger.LogTrace("Home", sMsg);
                }
                else
                {
                    JLogger.LogTrace("Auto", sMsg);
                }
            }
        }

        public static void LogTrace(string ModuleName, string Msg)
        {
            string com = " | ";
            string sMsg = ModuleName + com + Msg;
            JLogger.LogTrace("Any", sMsg);
        }

        public static void LogTrace(string FileName, string ModuleName, string Msg)
        {
            string com = " | ";
            string sMsg = ModuleName + com + Msg;
            JLogger.LogTrace(FileName, sMsg);
        }

        public static void FlowChartRecord(string ModuleName, List<FlowChart> FCs)
        {
            string FileName = "FlowChartRecord";
            JLogger.LogTrace(FileName, "========================= " + ModuleName + " =========================");

            foreach (FlowChart FC in FCs)
            {
                string com = " | ";
                string sMsg = FC.Text + com + FC.NowTask.Text;
                JLogger.LogTrace(FileName, sMsg);
            }

            JLogger.LogTrace(FileName, "========================= " + ModuleName + " =========================");
        }
    }//PD2 v1.0.1.3

    public class MES_ID_Data
    {
        public bool IsMatch;
        public string ID;
    }

    public static class TeachingData
    {
        public static WorkStation _TeachingWorkStation;
        public static int _TeachingLevel;

        public static IPointDT MotorMovePos = new IPointDT();
    }
    #endregion class

    #region enum

    public enum MotorMoveStatus
    {
        Busy,
        PosError,
        Complete,
        Unknow,
    }
    public enum EControlOnOff
    {
        None = 0,
        ON = 1,
        OFF = 2,
    }

    public enum ECylinderAction
    {
        Open,
        Close,
    }

    public enum Stage
    {
        UpperCassette,
        LowerCassette,
        ReadStage,
    }

    public enum CCD_RESULT
    {
        None,
        Wafer,          //Wafer
        Paper,          //隔離紙
        Ring,           //隔離環
        HaveCover,      //未開蓋
        BoxPlacePass,   //放置角度正確
        BoxPlaceErr,    //放置角度錯誤
        Empty,          //空盒
        Fail,           //辨識失敗
    }

    public enum EngravingMode   //Gary 20240626
    {
        Unknow,
        Front,
        Back,
    }

    #endregion enum

    public delegate void StatusDelegateTransfer(bool SW);//PD2 v1.0.1.2


    public class CommonFunction
    {
        public static bool GetHomeSensorOn(Motor motor)
        {
            bool b = motor.IsHomeOn;
            byte u2 = 0, u4 = 0;
            motor.GetAlarmStatus(ref u2, ref u4);
            bool status = ((u4 & 0x2) == 0x2);
            return status;
        }

        public static MotorMoveStatus MotorMove(Motor motor, int pos)
        {
            bool b1 = motor.G00(pos);
            if (b1)
            {
                int nowPos = motor.ReadEncPos();
                if (Math.Abs(nowPos - pos) < 150)
                {
                    return MotorMoveStatus.Complete;
                }
                else
                {
                    return MotorMoveStatus.PosError;
                }
            }
            else
            {
                return MotorMoveStatus.Busy;
            }
        }

        public static bool WaferChecksumIsOK_Ex(string WaferID)
        {
            string Orichecksum = WaferID.Substring(WaferID.Length - 2, 2);
            string NewWaferID = WaferID.Substring(0, WaferID.Length - 2) + "A0";

            int Count = NewWaferID.Length - 1;
            int Sum = 0;
            foreach (char c in NewWaferID)
            {
                int Value = (int)c - 32;
                int mod = 1;
                for (int i = 0; i < Count; i++)
                {
                    mod = (mod * 8) % 59;
                }
                Sum += (Value * mod) % 59;
                Count--;
            }

            int Key = 59 - (Sum % 59);
            string binaryString = Convert.ToString(Key, 2).PadLeft(6, '0');

            int midIndex = binaryString.Length / 2;
            string firstHalf = binaryString.Substring(0, midIndex);
            string secondHalf = binaryString.Substring(midIndex);

            int decimalNumber1 = Convert.ToInt32(firstHalf, 2);
            int decimalNumber2 = Convert.ToInt32(secondHalf, 2);

            char firstWord = (char)((int)'A' + decimalNumber1);
            char secondWord = (char)((int)'0' + decimalNumber2);

            string NewChecksum = firstWord.ToString() + secondWord.ToString();

            return NewChecksum == Orichecksum;
        }


        public static bool WaferChecksumIsOK(string WaferID) //v.1.0.0.15
        {
            string NewWaferID = WaferID;
            int Count = NewWaferID.Length - 1;
            int Sum = 0;
            foreach (char c in NewWaferID)
            {
                int Value = (int)c - 32;
                int mod = 1;
                for (int i = 0; i < Count; i++)
                {
                    mod = (mod * 8) % 59;
                }
                Sum += (Value * mod) % 59;
                Count--;
            }
            return (Sum % 59) == 0;
        }

        public static string OCR_ID_Transfer(OCR_Teach_Para para)
        {
            string old_ID = para.NowWaferID;
            string new_ID = "";

            try
            {
                if (para.OCR_1_Min > 0 && para.OCR_1_Max >= para.OCR_1_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_1_Min - 1, para.OCR_1_Max - para.OCR_1_Min + 1);
                }

                if (para.OCR_2_Min > 0 && para.OCR_2_Max >= para.OCR_2_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_2_Min - 1, para.OCR_2_Max - para.OCR_2_Min + 1);
                }

                if (para.OCR_3_Min > 0 && para.OCR_3_Max >= para.OCR_3_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_3_Min - 1, para.OCR_3_Max - para.OCR_3_Min + 1);
                }

                if (para.OCR_4_Min > 0 && para.OCR_4_Max >= para.OCR_4_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_4_Min - 1, para.OCR_4_Max - para.OCR_4_Min + 1);
                }

                new_ID += ",";

                if (para.OCR_5_Min > 0 && para.OCR_5_Max >= para.OCR_5_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_5_Min - 1, para.OCR_5_Max - para.OCR_5_Min + 1);
                }

                if (para.OCR_6_Min > 0 && para.OCR_6_Max >= para.OCR_6_Min)
                {
                    new_ID += old_ID.Substring(para.OCR_6_Min - 1, para.OCR_6_Max - para.OCR_6_Min + 1);
                }
            }
            catch(Exception ex)
            {
                new_ID = "Error:" + ex.Message;
            }
            return new_ID;
        }
    }

    public class OCR_Teach_Para
    {
        public string NowWaferID;
        public int OCR_1_Min = 0;
        public int OCR_1_Max = 0;
        public int OCR_2_Min = 0;
        public int OCR_2_Max = 0;
        public int OCR_3_Min = 0;
        public int OCR_3_Max = 0;
        public int OCR_4_Min = 0;
        public int OCR_4_Max = 0;
        public int OCR_5_Min = 0;
        public int OCR_5_Max = 0;
        public int OCR_6_Min = 0;
        public int OCR_6_Max = 0;
    }

    public class SlotState
    {
        public int WaferReferenceCenterPos { get; set; }        // 該層晶圓中心位置
        public int ReferenceCenterPosGap { get; set; }          // 與理論位置差距
        public int WaferThickness { get; set; }                 // Wafer厚度
        public int WaferReferenceThickness { get; set; }        // Wafer理論厚度
        public int WaferThicknessGap { get; set; }              // 與實際Wafer厚度差距
        public int WaferCenterPos { get; set; }                 // 實際晶圓中心位置
        public WaferState _WaferState { get; set; }             // 晶圓掃描狀態
    }

    public enum WaferState
    {
        None,
        NoWafer,                        // 無晶圓
        WaferDtected,                   // 有晶圓
        ThicknessOverLimit,             // 晶圓超出限制
        WaferPosError,          // 偵測到晶圓位置異常
        Error,
    }

    public class ROW_COL //v1.0.0.13
    {
        public string ROW { get; set; }
        public string COL { get; set; }
    }
    //End
}
