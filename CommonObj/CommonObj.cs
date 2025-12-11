using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NLog;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
//using PD2_SDK;
using KCSDK;
using SANWA_Robot;

namespace CommonObj
{
    public delegate void StatusDelegateTransfer(bool SW);//PD2 v1.0.1.2
    public delegate bool StatusDelegateCtrl(bool SW = true);

    #region enum
    public enum EngravingMode   //Gary 20240626
    {
        Unknow,
        Front,
        Back,
    }

    public enum _BinDefine
    {
        None = 0,           // 初始化  
        HasWafer = 1,       // 有晶圓
        NoWafer = 2,        // 沒有晶圓
        Exchange = 3,       // 正在作業中
        WaferNG = 4,        // 異常NG
        WaferTakeOff = 5,   // Carrier上待移除的晶圓
        PutBackWafer = 6,   // 放回Foup後的晶圓
        DummyWafer = 7,     // Dummy 晶圓
        PickWafer = 8,             // 要作業
        ToUVAT = 9,             // 要作業
        WCS_Home_DetectionCompleted = 10,    //WCS Carrier偵測完成
        PickDummy = 11,
        Booking_A = 12,
        Booking_B = 13,
        DoAlign = 14,
        Disabled = 15,
    }

    public enum FAO_SpeedMode
    {
        Scan,
        Normal,
        Home,
    }

    public enum ePPMAction
    {
        [Description("預設")]
        None,
        [Description("烤箱要出料")]
        OVDTranferOut,
        [Description("烤箱要入料")]
        OVDTranferIn,
        [Description("NG Panel要出料")]
        OVDNGPanelOut_OVD,
        [Description("NG Panel要出料")]
        OVDNGPanelOut_N2B,
        [Description("氮氣櫃要出料")]
        N2BPanelOut,
        [Description("烤箱不進氮氣櫃出料")]
        OVDTranferOut_Direct,
    }

    public enum ePTMFAction
    {
        [Description("預設")]
        None,
        [Description("手臂到中繼站")]
        PPMToPTMF,
        [Description("中繼站到PVL")]
        PTMFToPVL,
        [Description("NGPanel從PVL回到中繼站")]
        PVLToPTMF,
    }

    public enum eSTORAGELocation
    {
        None,
        OVD_Up,
        OVD_Down,
        N2B_Up,
        N2B_Down,
        N2B,
        OVD,
        NBM,
        UBM,
    }

    /// <summary>
    /// 馬達移動狀態
    /// </summary>
    public enum MotorMoveStatus
    {
        [Description("移動中")]
        Busy,
        [Description("點位錯誤")]
        PosError,
        [Description("移動完成")]
        Complete,
        [Description("未知")]
        Unknow,
    }
    public enum EControlOnOff
    {
        None = 0,
        [Description("開啟")]
        ON = 1,
        [Description("關閉")]
        OFF = 2,
    }

    public enum EStatusOnOff //無關A/B接點
    {
        None = 0,
        [Description("有訊號")]
        ON = 1,
        [Description("無訊號")]
        OFF = 2,
    }


    public enum ECylinderAction
    {
        [Description("開")]
        On,
        [Description("開啟")]
        Open,
        [Description("上")]
        Up,
        [Description("向前")]
        Forward,
        [Description("垂直")]
        Vertical,
        [Description("夾起")]
        Clamp,
        [Description("順時針")]
        Clock,
        [Description("以操作面向左")]
        Left,
        [Description("阻擋")]
        Block,
        [Description("鎖")]
        Lock,

        [Description("關")]
        Off,
        [Description("關閉")]
        Close,
        [Description("下")]
        Down,
        [Description("向後")]
        Backward,
        [Description("水平")]
        Horizontal,
        [Description("放開")]
        UnClamp,
        [Description("逆時針")]
        AntiClock,
        [Description("以操作面向右")]
        Right,
        [Description("解除阻擋")]
        UnBlock,
        [Description("解鎖")]
        UnLock,
    }

    public enum ECassette
    {
        [Description("上層晶舟盒")]
        UpperCassette,
        [Description("下層晶舟盒")]
        LowerCassette,
    }

    public enum EHolder
    {
        [Description("掛架A側")]
        HolderA,
        [Description("掛架B側")]
        HolderB,
        [Description("掛架AB側一起")]
        HolderA_B,
    }

    public enum EMainFlowRunMode
    {
        [Description("初始化流程")]
        InitialCheck = 0,
        [Description("開始生產產品")]
        Produce,
        [Description("DummyWafer進入流程")]
        Dummy_In,
        [Description("DummyWafer退出流程")]
        Dummy_Out,
        [Description("DummyWafer交換流程")]
        Dummy_OutIn,
    }

    public enum EControlFlipAngle
    {
        None = 0,
        [Description("0度")]
        _0 = 1,
        [Description("180度")]
        _180 = 2,
    }

    public enum EWorkingDirection
    {
        _none,
        [Description("上鎖")]
        _lock,
        [Description("解鎖")]
        _unlock,
    }

    public enum ETrayViewUpdate
    {
        None,
        [Description("取")]
        _Pick,
        [Description("放")]
        _Place,
        [Description("放置中，需等待檢查完成")]
        _Placeing,
    }

    public enum EHolderComponent
    {
        [Description("晶圓")]
        _Wafer,
        [Description("內蓋")]
        _Inner,
        [Description("外蓋")]
        _External,
    }

    public enum EDryMode
    {
        [Description("模式1")]
        _Mode1,
        [Description("模式2")]
        _Mode2,
        [Description("模式3")]
        _Mode3,
    }

    public enum ELocationDefine_X
    {
        [Description("初始化")]
        Default,
        [Description("正向移動(右)")]
        Passive,
        [Description("負向移動(左)")]
        Negative,
    }

    /// <summary>
    /// A/B向只適用南茂掛架電鍍機使用
    /// </summary>
    public enum ELocationDefine_Y
    {
        [Description("初始化")]
        Default,
        [Description("正向移動(前)(B)")]
        Passive,
        [Description("負向移動(後)(A)")]
        Negative,
    }

    public enum LP_Light
    {
        Manual,
        Auto,
        Presense,
        Placement,
        ReadyToLoad,
        ReadyToUnload,
        Alarm,
        Reserve,
        ManualButton,
    }

    public enum LP_Light_Mode
    {
        On = 0,
        Off = 1,
        Blink = 2,
    }


    public enum eStatus
    {
        None,
        OK,
        NG,
    }

    public enum Select_Action
    {
        None = 0,
        Retry = 1,
        Ignore = 2,
        Cancel = 3,
        OK = 4,
        WorkEnd = 5,
    }

    public enum eCO2MeterValue
    {
        None,
        AirPressure,
        FlowRate,
        Power,
        IsReading,
    }

    public enum EWaferSize
    {

    }

    public enum eConnectedMode
    {
        Ethernet,
        RS232,
    }

    public enum CheckMode
    {
        On,
        Off,
    }

    #endregion enum

    #region class

    public class _CommonObj
    {
        /// <summary>
        /// 獲得時間字串
        /// </summary>
        /// <returns></returns>
        public static string GetDateTime()
        {
            return DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss");
        }

        /// <summary>
        /// 以Home Sensor當安全移動sensor使用
        /// </summary>
        /// <param name="motor"></param>
        /// <returns></returns>
        public static bool GetHomeSensorOn(Motor motor)
        {
            bool b = motor.IsHomeOn;
            byte u2 = 0, u4 = 0;
            motor.GetAlarmStatus(ref u2, ref u4);
            bool status = ((u4 & 0x2) == 0x2);
            return status;
        }
        /// <summary>
        /// 移動馬達並判斷馬達是否到位
        /// </summary>
        /// <param name="motor"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static MotorMoveStatus MotorMove(Motor motor, int pos)
        {
            bool b1 = motor.G00(pos);
            if (b1)
            {
                int nowPos = motor.ReadEncPos();
                if (Math.Abs(nowPos - pos) < 100)
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

        public static bool WaferChecksumIsOK(string WaferID) //12/23 改用此CheckSum //1.0.0.20
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

        /// <summary>
        /// U67YC04-A0 : 驗證字串
        /// </summary>
        /// <param name="waferID"></param>
        /// <returns></returns>
        public static bool WaferChecksumIsOK_GPT(string waferID)
        {
            // 確保 waferID 長度足夠
            if (string.IsNullOrEmpty(waferID) || waferID.Length < 2)
                return false;

            // 取得原始校驗碼 (最後兩個字元)
            string originalChecksum = waferID.Substring(waferID.Length - 2, 2);

            // 取出不包含校驗碼的部分，並替換最後兩個字元為 "A0"
            string newWaferID = waferID.Substring(0, waferID.Length - 2) + "A0";

            int sum = 0;
            int weight = 1; // 初始權重
            int length = newWaferID.Length;

            // 計算加權總和
            for (int i = length - 1; i >= 0; i--)
            {
                int value = newWaferID[i] - 32; // 轉換 ASCII 值並去除 32 (空格)
                sum = (sum + value * weight) % 59; // 累加加權值並取 Mod 59
                weight = (weight * 8) % 59; // 更新權重 (8^n % 59)
            }

            // 計算校驗 Key
            int key = (59 - sum) % 59;

            // 將 Key 轉為 6 位元二進制並拆成兩組 3 位元
            string binaryString = Convert.ToString(key, 2).PadLeft(6, '0');
            string firstHalf = binaryString.Substring(0, 3);
            string secondHalf = binaryString.Substring(3, 3);

            // 轉換為對應的字元
            char firstChar = (char)('A' + Convert.ToInt32(firstHalf, 2));
            char secondChar = (char)('0' + Convert.ToInt32(secondHalf, 2));

            // 組成新的校驗碼
            string newChecksum = string.Format("{0}{1}", firstChar, secondChar);

            // 比對校驗碼是否一致
            return newChecksum == originalChecksum;
        }
        /// <summary>
        /// Mian Function DeepSeek
        /// </summary>
        /// <param name="waferID"></param>
        /// <returns></returns>
        public static bool WaferChecksumIsOK_DeepSeek(string waferID)
        {
            // 確保 waferID 長度足夠
            if (string.IsNullOrEmpty(waferID) || waferID.Length < 2)
                return false;

            // 取得原始校驗碼 (最後兩個字元)
            string originalChecksum = waferID.Substring(waferID.Length - 2, 2);

            // 計算新的校驗碼
            string newChecksum = CalculateChecksum(waferID);

            // 比對校驗碼是否一致
            return newChecksum == originalChecksum;
        }
        /// <summary>
        /// Sub Function DeepSeek
        /// </summary>
        /// <param name="waferID"></param>
        /// <returns></returns>
        private static string CalculateChecksum(string waferID)
        {
            // 取出不包含校驗碼的部分，並替換最後兩個字元為 "A0"
            string newWaferID = waferID.Substring(0, waferID.Length - 2) + "A0";

            int sum = 0;
            int weight = 1; // 初始權重
            int length = newWaferID.Length;

            // 計算加權總和
            for (int i = length - 1; i >= 0; i--)
            {
                int value = newWaferID[i] - 32; // 轉換 ASCII 值並去除 32 (空格)
                sum = (sum + value * weight) % 59; // 累加加權值並取 Mod 59
                weight = (weight * 8) % 59; // 更新權重 (8^n % 59)
            }

            // 計算校驗 Key
            int key = (59 - sum) % 59;

            // 將 Key 轉為 6 位元二進制並拆成兩組 3 位元
            int firstHalf = (key >> 3) & 0x07; // 取前 3 位
            int secondHalf = key & 0x07;       // 取後 3 位

            // 轉換為對應的字元
            char firstChar = (char)('A' + firstHalf);
            char secondChar = (char)('0' + secondHalf);

            // 組成新的校驗碼
            return string.Format("{0}{1}", firstChar, secondChar);
        }

        #region Sensor All/Any

        public static ThreeValued MyAll(DigitalInput[] di, CheckMode mode, int waittime, int timeout)
        {
            ThreeValued[] ret = new ThreeValued[di.Length];
            for (int i = 0; i < di.Length; i++)
            {
                if (mode == CheckMode.On)
                {
                    ret[i] = di[i].On(waittime, timeout);
                }
                else
                    if (mode == CheckMode.Off)
                    {
                        ret[i] = di[i].Off(waittime, timeout);
                    }
            }

            if (ret.All(x => x == ThreeValued.TRUE))
                return ThreeValued.TRUE;

            return ThreeValued.UNKNOWN;
        }

        public static ThreeValued MyAny(DigitalInput[] di, CheckMode mode, int waittime, int timeout)
        {
            ThreeValued[] ret = new ThreeValued[di.Length];
            for (int i = 0; i < di.Length; i++)
            {
                if (mode == CheckMode.On)
                {
                    ret[i] = di[i].On(waittime, timeout);
                    if (ret[i] == ThreeValued.TRUE)
                        return ThreeValued.TRUE;
                }
                else
                if (mode == CheckMode.Off)
                {
                    ret[i] = di[i].Off(waittime, timeout);
                    if (ret[i] == ThreeValued.TRUE)
                        return ThreeValued.TRUE;
                }
        }
            return ThreeValued.UNKNOWN;
        }

        #endregion Sensor All/Any

        #region 固定參數
        public const string HTL_ModuleName = "HTL";
        public const string NBM_ModuleName = "NBM";
        public const string NGM_ModuleName = "NGM";
        public const string PPM_ModuleName = "PPM";
        public const string PTMF_ModuleName = "PTMF";

        public const string PTMB_ModuleName = "PTMB";
        public const string PVL_ModuleName = "PVL";
        #endregion

    }

    public enum EBinDefine
    {
        [Description("初始化 & 無產品")]
        None = 0,
        [Description("產品片")]
        Panel,
        [Description("Carrier + Panel")]
        Combine,
        [Description("異常工作產品")]
        Panel_NG,
        [Description("只有載具")]
        Carrier,
        [Description("RepairPanel")]
        Panel_Repair,
        [Description("SeasonPanel")]
        Panel_Season,
        [Description("烘烤中")]
        Panel_Broil,
        [Description("烘烤完成")]
        Panel_BroilDone,
        [Description("停用")]
        Disable,
    }

    public class CommandClass
    {
        public CommandClass()
        {
            dPoint = new PointDT();
            iPoint = new IPointDT();

            ePPM_ActionMode = new enum_PPM_ActionMode();
            ePTI_ActionMode = new enum_PTI_ActionMode();
            ePTO_ActionMode = new enum_PTO_ActionMode();
        }

        public PointDT dPoint;
        public IPointDT iPoint;

        public enum_PPM_ActionMode ePPM_ActionMode;
        public enum_PTI_ActionMode ePTI_ActionMode;
        public enum_PTO_ActionMode ePTO_ActionMode;
        
        public int iZSlot;
        //public TransferMode _TransferMode;
        //public Motor[] MotorList;
        //public EDirection MT_Direction;
    }

    //若須回傳資訊，請放入此類別
    public class ReturnClass
    {
        //public bool Ret = false;
        //public string sOCR = "";
        //public string sBarCode = "";


        public bool Ret { get; set; }
        public string BarCode { get; set; }
        public string OCR { get; set; }
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

    #region OEEperformance Define
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
    #endregion OEEperformance Define

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

        public static void BU2_Log_File  //v1.0.0.21
            (
            string Bu2_Lot,     //批號         
            string stype,       //狀態
            string PackageName,//產品名稱
            string Msg,         //資訊
            string Numeric,     //數值
            string WorkSequence,//當前片數
            string alignOCR,
            string laserOCR,
            string sliceCount)  //總片數
        //v1.0.0.17
        {
            bool bFirst = false;

            string timestamp = DateTime.Now.ToString("yyyyMMdd");
            string timeDatas = DateTime.Now.ToString("HH:mm:ss.fff");
            string Filepath = "D:\\BU2_Log\\" + timestamp + ".csv";
            string logEntry = timestamp + "," + timeDatas + "," +
                                Bu2_Lot + "," + stype + "," +
                                PackageName + "," + Msg + "," + Numeric + "," +
                                WorkSequence + "," + alignOCR + laserOCR + "," + sliceCount;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Filepath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                if (!fi.Exists)
                {
                    bFirst = true;
                }

                System.IO.StreamWriter sw = new System.IO.StreamWriter(Filepath, true);
                if (bFirst)
                {
                    string title;
                    title = "日期,時間,內批,Type,程式,資訊,數值,Destination_Slot,Align_OCR,Laser_OCR,片數";
                    sw.WriteLine(title);
                }
                sw.WriteLine(logEntry);
                sw.Close();
            }
            catch
            {
                //SYSPara.LogSay(EnLoggerType.EnLog_OP, "BU2_Log存取異常");
                //SYSPara.ShowAlarm("E", 999);
            }

        }
    }//PD2 v1.0.1.3

    public class MES_ID_Data
    {
        public bool IsMatch;
        public string ID;
    }

    public class JobReference
    {
        public WaferTransferJob ParentJob { get; set; }
        public SlotMapping OriginalMapping { get; set; }
        public SlotMapping CloneMapping { get; set; }
    }

    public class WaferTransferJob
    {
        public string JobName { get; set; }
        public bool RequiresAlignment { get; set; }
        public bool RequiresOCR { get; set; }
        public bool OCRType { get; set; }   //Value is True use Top OCR else if Value is false use bottom OCR
        public List<SlotMapping> Mappings { get; set; }

        public WaferTransferJob()
        {
            this.JobName = "WaferExchange";
            this.RequiresAlignment = false;
            this.RequiresOCR = false;
            this.OCRType = true;
            Mappings = new List<SlotMapping>();
        }

        public WaferTransferJob(string name, bool align)
        {
            JobName = name;
            RequiresAlignment = align;
            RequiresOCR = false;
            OCRType = true;
            Mappings = new List<SlotMapping>();
        }
    }

    // 單一晶圓的搬運映射結構
    public class SlotMapping
    {
        // 來源/目標 Foup 使用 DefStation 列舉
        public SANWA_Robot.DefStation SourceFoup { get; set; }
        public int SourceSlot { get; set; } // 1 到 25
        public int SourceSlotIndex { get { return SourceSlot - 1; } } // 0 到 24

        public SANWA_Robot.DefStation TargetFoup { get; set; }
        public int TargetSlot { get; set; } // 1 到 25
        public int TargetSlotIndex { get { return TargetSlot - 1; } } // 0 到 24

        public SANWA_Robot.DefStation NowStation { get; set; }
        public WaferState State { get; set; }
        public Arm arm {get; set; }

        public string WaferID { get; set; }

        public SlotMapping() { }

        public SlotMapping(SANWA_Robot.DefStation sFoup, int sSlot, SANWA_Robot.DefStation tFoup, int tSlot, string id)
        {
            this.SourceFoup = sFoup;
            this.SourceSlot = sSlot;
            this.TargetFoup = tFoup;
            this.TargetSlot = tSlot;
            this.NowStation = SANWA_Robot.DefStation.None;
            this.State = WaferState.None;
            this.arm = Arm.None;
            this.WaferID = id;
        }

        public void Reset()
        {
            this.SourceFoup = SANWA_Robot.DefStation.None;
            this.SourceSlot = -1;
            this.TargetFoup = SANWA_Robot.DefStation.None;
            this.TargetSlot = -1;
            this.NowStation = SANWA_Robot.DefStation.None;
            this.State = WaferState.None;
            this.arm = Arm.None;
            this.WaferID = string.Empty;
        }

        public SlotMapping Clone()
        {
            SlotMapping mapping = new SlotMapping();
            mapping.SourceFoup = SourceFoup;
            mapping.SourceSlot = SourceSlot;
            mapping.TargetFoup = TargetFoup;
            mapping.TargetSlot = TargetSlot;
            mapping.NowStation = NowStation;
            mapping.State = State;
            mapping.WaferID = WaferID;
            mapping.arm = arm;

            return mapping;
        }
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null) return value.ToString();

            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

    #endregion class

    public struct sCounter
    {
        public int iPlace;
        public int iPick;
        public void Reset()
        {
            iPlace = 0;
            iPick = 0;
        }
    };


    #region Function





    #endregion Function

    #region ProV Record Data Type
    public class ProVDT
    {
        //如果沒有指定檔名則使用型別命稱當成檔名
        public ProVDT()
        {
            m_FileName = this.GetType().Name + @".json";
        }

        #region 紀錄機台異常復歸是否進行中
        public static bool RecoveryRun = false;
        #endregion 紀錄機台異常復歸是否進行中

        #region 虛擬記憶體區塊
        private static readonly object Mutex = new object();
        private static volatile JMemoryMappedManager _instance;
        protected static Dictionary<string, int> fileNameMap = new Dictionary<string, int>();
        private string m_FileName = "";
        private static string m_PackageName = "";

        public string FileName
        {
            get
            {
                return m_FileName;
            }
            set { m_FileName = value; }
        }

        public static string PackageName
        {
            get
            {
                return m_PackageName;
            }
            set
            {
                m_PackageName = value;
            }
        }

        public static JMemoryMappedManager SMem
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new JMemoryMappedManager();
                            //為檔案資料準備101組虛擬記憶體空間，每組空間大小 65536 Bytes
                            //第0組紀錄Package名稱，其餘100組紀錄資料
                            for (int i = 0; i <= 100; ++i)
                            {
                                _instance.AddField(String.Format("Data_{0}", i), 65536, 0);
                            }
                            // Heartbeat
                            _instance.AddField(String.Format("Data_{0}", 101), 65536, 0);
                        }
                        _instance.Open("ProVSM");
                        LaunchProVDataRecoder();
                    }
                }
                return _instance;
            }
        }

        #endregion 虛擬記憶體區塊

        #region 序列化函式
        //Json Serialization Version
        public static bool LoadData<T>(ref T RecordObj) where T : ProVDT
        {
            try
            {
                String strName = "";
                String strTemp = "";
                if (ProVDT.PackageName == "")
                {
                    strName = @".\RecordData\" + RecordObj.FileName;
                    strTemp = @".\RecordData\" + @"Temp" + RecordObj.FileName;
                }
                else
                {
                    strName = @".\RecordData\" + ProVDT.PackageName + @"\" + RecordObj.FileName;
                    strTemp = @".\RecordData\" + ProVDT.PackageName + @"\Temp" + RecordObj.FileName;
                }

                if (File.Exists(strName))
                {
                    try
                    {
                        File.Copy(strName, strTemp, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    return false;
                }

                using (FileStream fs = new FileStream(strName, FileMode.Open))
                {
                    // 使用 StreamReader 從檔案中讀取 XML
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        String strObj = sr.ReadToEnd();
                        // 將 XML 反序列化為物件
                        RecordObj = JsonConvert.DeserializeObject<T>(strObj);
                    }
                }
            }
            catch (DirectoryNotFoundException dex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(dex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (FileNotFoundException fex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException ioex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(ioex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static ProVDT LoadKernalData<T>(T RecordObj) where T : ProVDT
        {
            ProVDT KnlData = null;
            try
            {
                String strName = "";
                String strTemp = "";
                if (ProVDT.PackageName == "")
                {
                    strName = @".\RecordData\" + RecordObj.FileName;
                    strTemp = @".\RecordData\" + @"Temp" + RecordObj.FileName;
                }
                else
                {
                    strName = @".\RecordData\" + ProVDT.PackageName + @"\" + RecordObj.FileName;
                    strTemp = @".\RecordData\" + ProVDT.PackageName + @"\Temp" + RecordObj.FileName;
                }

                if (File.Exists(strName))
                {
                    try
                    {
                        File.Copy(strName, strTemp, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                using (FileStream fs = new FileStream(strName, FileMode.Open))
                {
                    // 使用 StreamReader 從檔案中讀取 XML
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        String strObj = sr.ReadToEnd();
                        // 將 XML 反序列化為物件
                        KnlData = JsonConvert.DeserializeObject<ProVDT>(strObj);
                    }
                }
            }
            catch (DirectoryNotFoundException dex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(dex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException fex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioex)
            {
                //ProVDT.PackageName = "";
                MessageBox.Show(ioex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return KnlData;
        }

        //Json Serialization Version
        //static Stopwatch sw = new Stopwatch();
        //static Stopwatch sw2 = new Stopwatch();
        //static Stopwatch sw3 = new Stopwatch();
        //static long smemTick = 0;
        public static void SaveData<T>(T RecordObj, Control Ctrl = null) where T : ProVDT
        {
            //sw.Restart();
            //檢查ProVDataRecoder是否在執行，如未執行，則執行它
            LaunchProVDataRecoder();

            //byte[] byteArray = new byte[65536];
            //SMem.ReadBytes("Data_101", ref byteArray);
            //string myString = Encoding.UTF8.GetString(byteArray).Split('\0')[0];
            //if (String.IsNullOrEmpty(myString))
            //{
            //    LaunchProVDataRecoder(true);
            //    SMem.WriteBytes("Data_101", Encoding.UTF8.GetBytes(""));
            //}
            //else
            //{
            //    SMem.WriteBytes("Data_101", Encoding.UTF8.GetBytes(""));
            //}

            //將PackageName屬性當成資料夾名稱寫入虛擬記憶體的第0層
            //如果沒有指定PackageName屬性，則會將資料記錄在RecordData資料夾中
            //如果有指定PackageName屬性，則會將資料紀錄在RecordData\PackageName\的資料夾中
            String strFolderName = String.Format("Data_{0}", 0);
            SMem.WriteBytes(strFolderName, Encoding.UTF8.GetBytes(ProVDT.PackageName));
            //smemTick = sw.ElapsedTicks;

            RecordObj.RecordDT = DateTime.Now;
            //sw2.Restart();
            if (Ctrl != null)
                UpdateKernalData(RecordObj, Ctrl);
            //System.Diagnostics.Debug.Print("Update Elasped: {0} us", sw2.ElapsedTicks * 1000000.0 / Stopwatch.Frequency);

            //sw3.Restart();
            String strobj = JsonConvert.SerializeObject(RecordObj);
            //System.Diagnostics.Debug.Print("Serialize Elasped: {0} us", sw3.ElapsedTicks * 1000000.0 / Stopwatch.Frequency);

            //sw.Restart();
            if (!fileNameMap.ContainsKey(RecordObj.FileName))
            {
                String strFieldName = String.Format("Data_{0}", fileNameMap.Count + 1);
                SMem.WriteBytes(strFieldName, Encoding.UTF8.GetBytes(strobj));
                fileNameMap.Add(RecordObj.FileName, fileNameMap.Count + 1);
            }
            else
            {
                String strFieldName = String.Format("Data_{0}", fileNameMap[RecordObj.FileName]);
                SMem.WriteBytes(strFieldName, Encoding.UTF8.GetBytes(strobj));
            }
            //System.Diagnostics.Debug.Print("SMEM Elasped: {0} us", (smemTick + sw.ElapsedTicks) * 1000000.0 / Stopwatch.Frequency);
        }

        //傳回檔案紀錄日期時間
        public DateTime GetRecordDateTime()
        {
            return RecordDT;
        }

        private static bool bFirstRun = true;
        private static void LaunchProVDataRecoder()
        {
            Process[] process = Process.GetProcessesByName("ProVDataRecorder");
            int pCount = process.Count();

            if (pCount > 0 && !bFirstRun)
                return;
            foreach (var t in process)
            {
                t.Kill();
            }

            try
            {
                // 建立 ProcessStartInfo 物件
                ProcessStartInfo startInfoMotor = new ProcessStartInfo();

                // 設定 FileName 屬性
                startInfoMotor.FileName = @".\ProVDataRecorder.exe";

                // 設定 Arguments 屬性
                startInfoMotor.Arguments = "ProVSM";

                // 設定 UseShellExecute 屬性
                startInfoMotor.UseShellExecute = false;

                // 啟動處理序
                Process.Start(startInfoMotor);
                bFirstRun = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 底層資料區塊
        //宣告成Public的成員（不包含static成員，static成員需為該成員增加[JasonProperty] Attribute）會被JsonConvert序列化成字串
        //資料紀錄時的日期與時間
        public DateTime RecordDT = DateTime.Now;
        //紀錄底層元件狀態的Dictionary
        private Dictionary<String, int> mtrMap = new Dictionary<string, int>();
        public Dictionary<String, int> MotorMap
        {
            get
            {
                return mtrMap;
            }
            set { mtrMap = value; }
        }
        private Dictionary<String, bool> obMap = new Dictionary<string, bool>();
        public Dictionary<String, bool> DOMap
        {
            get
            {
                return obMap;
            }
            set { obMap = value; }
        }
        private Dictionary<String, float> aoMap = new Dictionary<string, float>();
        public Dictionary<String, float> AOMap
        {
            get
            {
                return aoMap;
            }
            set { aoMap = value; }
        }

        private Dictionary<String, String> fcMap = new Dictionary<string, string>();
        public Dictionary<String, String> FCMap
        {
            get
            {
                return fcMap;
            }
            set { fcMap = value; }
        }

        #region 更新底層元件的資料

        private static String FindFullPath(Control ctrl, out Control container)
        {
            //找出此元件完整的放置路徑
            StringBuilder sbName = new StringBuilder(ctrl.Name);
            Control ctlParent = ctrl.Parent;
            Control ctrlLast = ctrl;
            while (ctlParent != null)
            {
                ctrlLast = ctlParent;
                ctlParent = ctlParent.Parent;
                sbName.Insert(0, ctrlLast.Name + ".");
                if (ctlParent != null)
                {
                    Type type = ctlParent.GetType();
                    bool isForm = type == typeof(Form) || type.IsSubclassOf(typeof(Form));
                    if (isForm)
                    {
                        ctrlLast = ctlParent;
                        sbName.Insert(0, ctrlLast.Name + ".");
                        break;
                    }
                }
            }
            container = ctrlLast;
            return sbName.ToString();
        }

        private static void UpdateKernalData<T>(T RecordObj, Control Ctrl) where T : ProVDT
        {
            List<Motor> lstMotor = new List<Motor>();
            FindKernalObj(Ctrl, lstMotor);
            foreach (Motor mtr in lstMotor)
            {
                Control ctrlParent;
                String strName = FindFullPath(mtr, out ctrlParent);

                if (!RecordObj.MotorMap.ContainsKey(strName))
                {
                    RecordObj.MotorMap.Add(strName, mtr.ReadPos());
                }
                else
                {
                    RecordObj.MotorMap[strName] = mtr.ReadPos();
                }
            }

            List<OutBit> lstDO = new List<OutBit>();
            FindKernalObj(Ctrl, lstDO);

            foreach (OutBit ob in lstDO)
            {
                Control ctrlParent;
                String strName = FindFullPath(ob, out ctrlParent);

                if (!RecordObj.DOMap.ContainsKey(strName))
                {
                    RecordObj.DOMap.Add(strName, ob.Value);
                }
                else
                {
                    RecordObj.DOMap[strName] = ob.Value;
                }
            }

            //MainRunFCList有可能在執行Foreach過程中由底層變動（新增）
            //因此使用複製出來的那一份，以免發生集合已修改，列舉尚未執行的例外
            FlowChart[] FCArray = MainRunFCList.FCs.ToArray();
            foreach (FlowChart fc in FCArray)
            {
                //判斷fc（某一串流程的流程頭）是不是在此模組上
                if (fc.DesignTimeParent.Name == Ctrl.Name)
                {
                    Control ctrlParent;
                    String strName = FindFullPath(fc, out ctrlParent);

                    if (!RecordObj.FCMap.ContainsKey(strName))
                    {
                        RecordObj.FCMap.Add(strName, fc.NowTask.Name);
                    }
                    else
                    {
                        RecordObj.FCMap[strName] = fc.NowTask.Name;
                    }
                }
            }

            List<AnalogOut> lstAO = new List<AnalogOut>();
            FindKernalObj(Ctrl, lstAO);
            foreach (AnalogOut ao in lstAO)
            {
                Control ctrlParent;
                String strName = FindFullPath(ao, out ctrlParent);

                if (!RecordObj.AOMap.ContainsKey(strName))
                {
                    RecordObj.AOMap.Add(strName, ao.Value);
                }
                else
                {
                    RecordObj.AOMap[strName] = ao.Value;
                }
            }
        }
        #endregion 更新底層元件的資料

        //找給定模組上所有從TObjForm繼承下來的元件，其中T可能是Motor、OutBit、AnalogOut以及FlowChart
        private static void FindKernalObj<T>(Control control, List<T> objList) where T : TObjForm
        {
            T obj = control as T;
            if (obj != null)
            {
                objList.Add(obj);
            }

            foreach (Control childControl in control.Controls)
            {
                FindKernalObj(childControl, objList);
            }
        }

        public FlowChart GetKernalData(FlowChart fc)
        {
            if (fc == null)
            {
                throw new Exception("FlowChart is Null reference!!");
            }
            else
            {
                Control ctrlParent;
                String strName = FindFullPath(fc, out ctrlParent);

                FlowChart fcNow = null;

                if (FCMap.ContainsKey(strName) && ctrlParent != null)
                {
                    fcNow = ctrlParent.Controls.Find(FCMap[strName], true).FirstOrDefault() as FlowChart;
                }
                else
                {
                    String strEx = String.Format("Specified FlowChart: {0} Not Record in Map!!", fc.Name);
                    throw new Exception(strEx);
                }
                return fcNow;
            }
        }

        public int GetKernalData(Motor mtr)
        {
            if (mtr == null)
            {
                throw new Exception("Motor is Null reference!!");
            }
            else
            {
                Control ctrlParent;
                String strName = FindFullPath(mtr, out ctrlParent);

                int mtrPos = 0;

                if (MotorMap.ContainsKey(strName))
                {
                    mtrPos = MotorMap[strName];
                }
                else
                {
                    String strEx = String.Format("Specified Motor: {0} Not Record in Map!!", mtr.Name);
                    throw new Exception(strEx);

                }

                return mtrPos;
            }
        }

        public bool GetKernalData(OutBit ob)
        {
            if (ob == null)
            {
                throw new Exception("OutBit is Null reference!!");
            }
            else
            {
                Control ctrlParent;
                String strName = FindFullPath(ob, out ctrlParent);

                bool obState = false;

                if (DOMap.ContainsKey(strName))
                {
                    obState = DOMap[strName];
                }
                else
                {
                    String strEx = String.Format("Specified OutBit: {0} Not Record in Map!!", ob.Name);
                    throw new Exception(strEx);
                }

                return obState;
            }
        }

        public float GetKernalData(AnalogOut ao)
        {
            if (ao == null)
            {
                throw new Exception("AnalogOut is Null reference!!");
            }
            else
            {
                Control ctrlParent;
                String strName = FindFullPath(ao, out ctrlParent);

                float aoVal = 0F;

                if (AOMap.ContainsKey(strName))
                {
                    aoVal = AOMap[strName];
                }
                else
                {
                    String strEx = String.Format("Specified AnalogOut: {0} Not Record in Map!!", ao.Name);
                    throw new Exception(strEx);
                }

                return aoVal;
            }
        }
        #endregion 底層資料區塊
    }
    #endregion ProV Record Data Type

    #region RecoveryData

    public enum RecoveryData
    {
        MainFlow = 0,
        ModuleData,
        OutBit,
        MotorX,
        MotorY,
        MotorZ,
        MotorU,
        ECy, 
        FlowChart,
    }

    #endregion RecoveryData

    //End
}
