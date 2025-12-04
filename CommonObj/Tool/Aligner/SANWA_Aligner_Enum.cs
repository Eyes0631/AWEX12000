using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SANWA_Aligner
{
    public class AlignerCommandDefine
    {
        const string _STX = "$";
        const byte _CR = 0x0D;
        const byte _LF = 0x0A;
        const byte _ACK = 0x06;
        const byte _NAK = 0x15;
    }

    public class SANWA_AlignerStatus
    {
        public int iStarting;               //起動中   0 = 起動中 1 = 起動終了 2 = 系統異常 (起動失敗) 
        public int iControlMode;            //控制狀態 1 = Serial 通信 2 = PLC 控制 3 = 教導器
        public int iReserve_1;              //預備 不定
        public int iReserve_2;              //預備 不定
        public int iAction;                 //動作 0 = 停止中 1 = 動作中
        public int iPause;                  //暫停 0 = 正常 1 = 暫停中
        public int iIsError;                //異常發生 0 = 正常， 1 = 異常發生中
        public int iStepAction;             //Step 動作 0 = 非執行 1 = Step 等待中
        public int iManunal;                //Manual 0 =自動模式 1 = 手動模式
        public int iServoOn;                //Servo On 0 = Servo off 1 = Servo On
        public int iFanError;               //FAN 異常 0 = 異常 1 = FAN 正常
        public int iReserve_3;              //預備 不定
        public int iReserve_4;              //預備 不定
        public int iSolenoidAction;         //電磁閥操作中 0 = 正常 1 = 電磁閥操作中
        public int iORG_Search;             //搜尋 ORG 位置 0 = OCR 搜尋未完成 1= ORG 搜尋完成
        public int iReserve_5;              //預備 不定
        public int iAxis_X_Home;            //X 軸 HOME 點 0 = 非 HOME 點，1 = 在 HOME 點
        public int iAxis_X_HasProduct;      //X 軸基板有無 Sensor 0 = OFF， 1 = ON 
        public int iAxis_X_Vaccum;          //X 軸吸著 Sensor 0 = OFF， 1 = ON
        public int iWafer_Size_TensDigit;   //Wafer 尺寸十位數(0，1)
        public int iWafer_Size_UnitsDigit;  //Wafer 尺寸個位數
        public int iReserve_6;              //預備 不定
        public int iReserve_7;              //預備 不定
        public int iReserve_8;              //預備 不定
        public int iAxis_Y_Home;            //Y 軸 HOME 點 0 = 非 HOME 點，1 = HOME 點
        public int iReserve_9;              //預備 不定
        public int iReserve_10;             //預備 不定
        public int iReserve_11;             //預備 不定
        public int iReserve_12;             //預備 不定
        public int iReserve_13;             //預備 不定
        public int iReserve_14;             //預備 不定
        public int iReserve_15;             //預備 不定

        public string ErrorCode;        //Aligner回應的錯誤碼
    }

    public class AlignerCommand
    {
        public CommDef Command { get; set; }

        public string GetCommandType
        {
            get
            {
                string[] CommandAnalyze = Command.ToString().Split('_');
                return CommandAnalyze[0];
            }
        }

        public string GetCommandName
        {
            get
            {
                string[] CommandAnalyze = Command.ToString().Split('_');
                string CommandName = CommandAnalyze[1].PadRight(5, '_');
                return CommandName;
            }
        }

        public char UnitNo { get; set; }//1 Byte
        public string Errcd { get; set; }//Error code (4 bytes)
        public SANWA_IO _SANWA_IO { get; set; }//輸入輸出選擇
        public string GetIOType
        {
            get
            {
                return ((int)_SANWA_IO).ToString();
            }
        }

        public int COUNT { get; set; }//1~42 讀取 HWID 後的連續 I/O 數量，預設為 1 (HWID + COUNT <= (1 + 硬體 IO 總數量)
        public string no { get; set; }//參數名稱
        public string v1 { get; set; }//參數名稱
        public string sv { get; set; }//參數名稱
        public string m1 { get; set; }//參數名稱
        public string axis { get; set; }//參數名稱
        public string pno { get; set; }//參數名稱
        public string slot { get; set; }//參數名稱
        public string a1 { get; set; }//參數名稱
        public string opt { get; set; }//參數名稱
        public string step { get; set; }//參數名稱
        public string col { get; set; }//參數名稱
        public string speed { get; set; }//參數名稱
        public List<char> mp = new List<char>();//Mapping Data 0 : 無基板 1 : 有基板 W : 厚度異常 E : 基板傾斜異常
        public List<string> mp_thickness = new List<string>();//Mapping Data 厚度
        public string RSLT { get; set; }//指令執行結果
        public SANWA_AlignerMode _AlignerMode;

        public string Parameter_1 { get; set; }
        public string Parameter_2 { get; set; }
        public string Parameter_3 { get; set; }
        public string Parameter_4 { get; set; }
        public string Parameter_5 { get; set; }

        public string RevCheckSum { get; set; }
        public string RevADR { get; set; }
        public string RevFLG { get; set; }
        public string RevCMD { get; set; }
        public string RevDAT { get; set; }
        public string Error_msg { get; set; }
    }

    public enum SANWA_Solenoid
    {
        
    }

    public enum SANWA_AlignerMode
    {
        Normal = 0,
        Dry,
        Test,
        Step,
    }

    public enum SANWA_IO
    {
        OUTPUT = 0,
        INPUT = 1,
    }

    public enum DefStation
    {
        None,
    }

    public enum CommDef
    {
        #region GET
        [Description("Aligner 狀態取得")]
        GET_STS=0,
        [Description("IO 狀態取得")]
        GET_RIO=1,
        [Description("速度限制取得")]
        GET_SP,
        [Description("讀取 ALIGN 相關資訊")]
        GET_ALIGN,
        [Description("錯誤履歷取得")]
        GET_ERR,
        [Description("取得 Aligner 參數值")]
        GET_PARAM,
        [Description("取得 Aligner 參數詳細資料")]
        GET_PARSY,
        [Description("取得目前 Aligner 各軸的位置")]
        GET_POS,
        [Description("讀取目前韌體版本")]
        GET_VER,
        [Description("切換 Recipe")]
        GET_RCP,
        [Description("取得特殊尺寸 Wafer 設定")]
        GET_WFTYP,
        [Description("取得 Robot 取放位置設定值")]
        GET_ACPOS,
        [Description("取得標準尺寸類型與缺口型式")]
        GET_WTYPE,
        #endregion GET

        #region SET
        [Description("IO 狀態設定")]
        SET_RIO,
        [Description("速度限制設定")]
        SET_SP,
        [Description("Error 解除")]
        SET_RESET,
        [Description("Servo On")]
        SET_SERVO,
        [Description("儲存 Log file")]
        SET_LOGSV,
        [Description("設定 Aligner 參數值")]
        SET_PARAM,
        [Description("儲存 Aligner 參數")]
        SET_SAVE,
        [Description("指定標準尺寸與缺口型式")]
        SET_WTYPE,
        [Description("切換 Recipe")]
        SET_RCP,
        [Description("動作停止")]
        SET_STOP,
        [Description("讀取特殊尺寸 Wafer 設定。")]
        SET_WFTYP,
        [Description("設定 Robot 取放位置(以 Wafer 大小當成基準)")]
        SET_ACPOS,
        [Description("更新目前時間")]
        SET_TIME,
        #endregion SET

        #region CMD
        [Description("各軸移動至 HOME 位置 ")]
        CMD_HOME,
        [Description("移動指定軸到指定位置")]
        CMD_MOVED,
        [Description("ORG Search")]
        CMD_ORG,
        [Description("真空保持")]
        CMD_WHLD,
        [Description("真空解除")]
        CMD_WRLS,
        [Description("尋找晶圓(Wafer)缺口(notch/flat)後，移動至所需的角度位置。")]
        CMD_ALIGN,
        #endregion CMD

        ACK,
    }

    public enum ResCommand : int
    {
        ACKN_MSG, //ACKN message
        EVNT_MSG, //Event message
        FORMAT_ERR, //Format Error
        FIN_MSG, //End-of-execution Message
        NAK_MSG, //Response Message
    }

    public enum ALIGN_TYPE
    {
        [Description("不可回 home，直接根據上一次 align 結果，不再做尋邊動 作，直接到 notch/flat 指定角度，並補正偏心")]
        NotHome = 0,
        [Description("回 home，到 notch/flat 指定角度，並補正偏心")]
        Normal = 1,
        [Description("只做尋邊動作，aligner 不執行 notch/flat 指定角度與補正心")]
        OnlyAligner = 2,
    }

    public enum ALIGN_PARA_1  //選擇Z軸動作
    {
        [Description("無Z軸(Vacuum Type使用")]
        NoZAxis = 0,
        [Description("Align完成Z軸下降(保留)")]
        ZAxisDown = 1,
        [Description("Align完成Z軸上升(Clamp Type 使用")]
        ZAxisUp = 2,
    }

    public enum ALIGN_PARA_2  //選擇Z軸動作
    {
        [Description("快速模式,並以最短路徑到Notch/Flat指定角度")]
        FastMode = 0,
        [Description("正常模式,並以尋邊方向轉到Notch/Flat指定角度")]
        NomalMode = 1,
    }

}
