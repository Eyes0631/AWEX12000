using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SANWA_Robot
{
    public class RobotCommandDefine
    {
        const string _STX = "$";
        const byte _CR = 0x0D;
        const byte _LF = 0x0A;
        const byte _ACK = 0x06;
        const byte _NAK = 0x15;
    }

    public class SANWA_RobotStatus
    {
        public int iStarting;           //起動中   0 = 起動中 1 = 起動終了 2 = 系統異常 (起動失敗) 
        public int iControlMode;        //控制狀態 1 = Serial 通信 2 = PLC 控制 3 = 教導器
        public int iIsError;            //異常狀態 0 = 正常 1 = 有異常發生
        public int iReserve_1;          //預備 不定
        public int iAction;             //動作 0 = 停止中 1 = 動作中
        public int iPause;              //暫停 0 = 正常 1 = 暫停中
        public int iResetRequest;       //重置請求 0 = 不需要重置 1 = 需要進行重置(RESET)
        public int iStepAction;         //Step 動作 0 = 非執行 1 = Step 等待中
        public int iManunal;            //Manual 0 =自動模式 1 = 手動模式
        public int iServoOn;            //Servo On 0 = Servo off 1 = Servo On
        public int iFanError;           //FAN 異常 0 = 異常 1 = FAN 正常
        public int iEncoderPower;       //Encoder 電力 0 = 異常 (更換要求) 1=正常
        public int iArmInterferenceArea;//Arm 干涉區域 0 = 正常 1 = Arm 於干涉區域
        public int iSolenoidAction;     //電磁閥操作中 0 = 正常 1 = 電磁閥操作中
        public int iORG_Search;         //搜尋 ORG 位置 0 = OCR 搜尋未完成 1= ORG 搜尋完成
        public int iReserve_2;          //預備 不定
        public int iBlade_R_ORG;        //R 軸原點 0 = 非原點 1 = 原點
        public int iBlade_R_HasProduct; //R 軸基板有無 Sensor 0 = OFF 1 = ON
        public int iBlade_R_Vaccum;     //R 軸吸著 Sensor 0 = OFF 1 = ON 
        public int iBlade_R_END_EF_1;   //R 軸 END-EF 開闔位置 1 0 = OFF 1 = ON
        public int iBlade_R_END_EF_2;   //R 軸 END-EF 開闔位置 2 0 = OFF 1 = ON
        public int iBlade_R_END_EF_3;   //R 軸 END-EF 開闔位置 3 0 = OFF 1 = ON
        public int iBlade_R_END_EF_4;   //R 軸 END-EF 開闔位置 4 0 = OFF 1 = ON
        public int iBlade_R_SHOCK;      //R 軸 SHOCK Sensor 0 = OFF 1 = ON
        public int iBlade_L_ORG;        //L 軸原點 0 = 非原點 1 = 原點
        public int iBlade_L_HasProduct; //L 軸基板有無 Sensor 0 = OFF 1 = ON
        public int iBlade_L_Vaccum;     //L 軸吸著 Sensor 0 = OFF 1 = ON 
        public int iBlade_L_END_EF_1;   //L 軸 END-EF 開闔位置 1 0 = OFF 1 = ON
        public int iBlade_L_END_EF_2;   //L 軸 END-EF 開闔位置 2 0 = OFF 1 = ON
        public int iBlade_L_END_EF_3;   //L 軸 END-EF 開闔位置 3 0 = OFF 1 = ON
        public int iBlade_L_END_EF_4;   //L 軸 END-EF 開闔位置 4 0 = OFF 1 = ON
        public int iBlade_L_SHOCK;      //L 軸 SHOCK Sensor 0 = OFF 1 = ON

        public string ErrorCode;        //Robot回應的錯誤碼
    }

    public class RobotCommand
    {
        public DefStation Station { get; set; }

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

        public Arm Arm;
        public string arm
        {
            get { return ((int)Arm).ToString(); }
        }
        public int ilevel { get; set; }//取片層數
        public int COUNT { get; set; }//1~42 讀取 HWID 後的連續 I/O 數量，預設為 1 (HWID + COUNT <= (1 + 硬體 IO 總數量)
        //public string no { get; set; }//參數名稱
        //public string v1 { get; set; }//參數名稱
        //public string sv { get; set; }//參數名稱
        //public string m1 { get; set; }//參數名稱
        //public string axis { get; set; }//參數名稱
        //public string pno { get; set; }//參數名稱 Teach 點位 || 
        //public string slot { get; set; }//參數名稱
        //public string a1 { get; set; }//參數名稱
        //public string opt { get; set; }//參數名稱
        //public string step { get; set; }//參數名稱
        //public string col { get; set; }//參數名稱
        //public string speed { get; set; }//參數名稱
        public string mp { get; set; }//Mapping Data 0 : 無基板 1 : 有基板 W : 厚度異常 E : 基板傾斜異常
        //public List<string> mp_thickness = new List<string>();//Mapping Data 厚度
        public string RSLT { get; set; }//指令執行結果
        //public SANWA_RobotMode _RobotMode;

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

    public enum Arm : byte// (1 byte)
    {
        None = 0,
        U = 1,// Upper elbow. 手臂定義R為上手臂
        L = 2,// Lower elbow. 手臂定義L為上手臂
        A = 3,// Automatic (Automatically selected posture with the proper path).
    }

    public enum SANWA_Solenoid
    {
        Blade_R = 1,
        Blade_L = 2,
        Blade_R_Pad1 = 3,
        Blade_R_Pad2 = 4,
        Blade_L_Pad1 = 5,
        Blade_L_Pad2 = 6,
        Blade_R_END_EF_1 = 7,
        Blade_R_END_EF_2 = 8,
        Blade_L_END_EF_1 = 9,
        Blade_L_END_EF_2 = 10,
    }

    public enum SANWA_RobotMode
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
        [Description("傳遞盒A")]
        FoupA = 1,
        [Description("傳遞盒B")]
        FoupB = 2,
        [Description("傳遞盒C")]
        FoupC = 3,
        [Description("傳遞盒D")]
        FoupD = 4,
        [Description("晶舟盒-上")]
        Cassette_Up = 5,
        [Description("晶舟盒-下")]
        Cassette_Down = 6,
        [Description("Dummy Wafer")]
        DummyWafer = 7,
        [Description("尋邊機A")]
        AlignerA = 8,
        [Description("尋邊機B")]
        AlignerB = 9,
        [Description("中繼站")]
        MiddleStage = 10,
        [Description("打印區")]
        Laser = 11,

        //Mapping
        [Description("傳遞盒-Mapping")]
        Mapping_Foup = 12,
        [Description("晶舟盒-上-Mapping")]
        Mapping_Cassette_Up = 13,
        [Description("晶舟盒-下-Mapping")]
        Mapping_Cassette_Down = 14,
        [Description("DummyWafer-Mapping")]
        Mapping_DummyWafer = 15,
    }

    public enum CommDef
    {
        #region GET
        [Description("讀取指定實體 I/O 狀態(支援多片讀取)")]
        GET_BRDIO = 0,
        [Description("錯誤履歷取得")]
        GET_ERR = 1,
        [Description("與 E84 溝通(選購)")]
        GET_E84,
        [Description("Mapping 結果取得")]
        GET_MAP,
        [Description("取得 Mapping 厚度結果(選購)")]
        GET_MAPT,
        [Description("取得 Mapping 的座標位置")]
        GET_MAPRD,
        [Description("取得 Multi I/O 指定觸發條件，使 Robot 自動停止的設定(選購)")]
        GET_MITFR,
        [Description("讀取目前 Robot 動作模式")]
        GET_MODE,
        [Description("依據 I/O 名稱讀取狀態(選購)")]
        GET_NMEIO,
        [Description("取得 Robot 參數值")]
        GET_PARAM,
        [Description("取得 Robot 參數詳細資料")]
        GET_PARSY,
        [Description("取得指定點位欄位的資訊")]
        GET_PDATA,
        [Description("取得基板的狀態(選購)")]
        GET_PNSTS,
        [Description("取得目前 Robot 各軸的位置")]
        GET_POS,
        [Description("讀取目前 Robot 所在的點位位置")]
        GET_RBPOS,
        [Description("IO 狀態取得")]
        GET_RIO,
        [Description("一次取得多個 I/O 狀態")]
        GET_RIOMC,
        [Description("速度限制取得")]
        GET_SP,
        [Description("Robot 狀態取得")]
        GET_STS,
        [Description("電磁閥狀態取得")]
        GET_SV,
        [Description("讀取指定 RFID 某段落的內容(選購)")]
        GET_TAGDT,
        [Description("讀取指定 Cassette 的名稱(選購)")]
        GET_TAGID,
        [Description("讀取 Point Data 裡的各軸位置(R~X 五軸)")]
        GET_TEACH,
        [Description("讀取目前韌體版本")]
        GET_VER,
        [Description("讀取目前時間")]
        GET_TIME,
        #endregion GET

        #region SET
        [Description("Battery Alarm Clear")]
        SET_BATCL,
        [Description("指定實體 I/O 的 output 狀態")]
        SET_BRDIO,
        [Description("暫停解除")]
        SET_CONT,
        [Description("Absolute Encoder Alarm Clear")]
        SET_ENCCL,
        [Description("Abssolute Encoder Offset")]
        SET_ENCOF,
        [Description("將 Point Data 從 CF/micro SD 卡載入")]
        SET_LOADP,
        [Description("儲存 Log file")]
        SET_LOGSV,
        [Description("設定 Multi I/O 指定觸發條件，使 Robot 自動停止的功能")]
        SET_MITFR,
        [Description("Robot 動作模式選擇設定")]
        SET_MODE,
        [Description("依據 I/O 名稱設定狀態(選購)")]
        SET_NMEIO,
        [Description("設定 Robot 參數值")]
        SET_PARAM,
        [Description("動作暫停")]
        SET_PAUSE,
        [Description("設定指定點位參數")]
        SET_PDATA,
        [Description("Error 解除")]
        SET_RESET,
        [Description("IO 狀態設定")]
        SET_RIO,
        [Description("儲存 Robot 參數")]
        SET_SAVE,
        [Description("將 Point Data 存入 CF/micro SD 卡")]
        SET_SAVEP,
        [Description("Servo On")]
        SET_SERVO,
        [Description("速度限制設定")]
        SET_SP,
        [Description("動作停止")]
        SET_STOP,
        [Description("Step 動作等待解除")]
        SET_STPDO,
        [Description("電磁閥狀態設定")]
        SET_SV,
        [Description("寫入 RFID 某段落的內容(選購)")]
        SET_TAGDT,
        [Description("寫入 Tag 的 ID(選購)")]
        SET_TAGID,
        [Description("將目前各軸的位置寫入指定的 Point Data")]
        SET_TEACH,
        [Description("強制觸發所有開啟的 IO(選購)")]
        SET_TGEVT,
        [Description("更新目前時間")]
        SET_TIME,
        #endregion SET

        #region CMD
        [Description("端面檢出 (選購)")]
        CMD_ALX,
        [Description("取片+放片 動作指令(Exchange)")]
        CMD_CARRY,
        [Description("單軸 ORG Search")]
        CMD_EORG,
        [Description("End-EF Calibration (選購)")]
        CMD_FOKCB,
        [Description("End-EF 開合位置變更(選購)")]
        CMD_FORK,
        [Description("取片")]
        CMD_GET,
        [Description("分步取片")]
        CMD_GETST,
        [Description("取片 T，X，Z 軸到位後停止")]
        CMD_GETW,
        [Description("各軸移動至 HOME 位置 ")]
        CMD_HOME,
        [Description("Mapping (選購)")]
        CMD_MAP,
        [Description("移動指定軸到指定位置")]
        CMD_MOVED,
        [Description("多軸同時移動")]
        CMD_MOVEM,
        [Description("根據點位指定移動位置動作 ")]
        CMD_MOVEP,
        [Description("指定任意軸移動到 Teach 點位位置")]
        CMD_MOVDP,
        [Description("Multi Panel 選擇命令(選購)")]
        CMD_MULSE,
        [Description("ORG Search")]
        CMD_ORG,
        [Description("移動指定位置執行 Pusher 動作")]
        CMD_PUSH,
        [Description("放片")]
        CMD_PUT,
        [Description("分步放片")]
        CMD_PUTST,
        [Description("放片 T，X，Z 軸到位後停止")]
        CMD_PUTW,
        [Description("Arm 回 HOME 位置")]
        CMD_RET,
        [Description("各軸回 home 的速度回 ORG 的位置，並確認 ORG Sensor")]
        CMD_RHOME,
        [Description("各軸安全回 HOME 位置")]
        CMD_SHOME,
        [Description("真空保持")]
        CMD_WHLD,
        [Description("真空解除")]
        CMD_WRLS,
        [Description("單獨做翻轉動作")]
        CMD_FLIP,
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

    public enum GetMappingDataDirection
    {
        [Description("由下往上 Mapping Buffer1 之結果")]
        DownToUp = 1,
        [Description("由上往下 Mapping Buffer2 之結果")]
        UpToDown = 2,
        [Description("合上下 Mapping 之結果")]
        Merge = 3,
    }
}
