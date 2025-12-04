using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObj.ModbusTCP.TapeRemove
{
    public enum MBX_Function
    {
        None = 0x00,
        ReadToolSignal = 0x01,
        WriteRobotSignal = 0x02,

        End = 0xFF,
    }

    public enum Step
    {
        ReadSignal,
        ReadFinish,
        WriteSignal,
        WriteFinish,
    }

    public enum TOOL_Machine_Status
    {
        Manual,
        Semi_Automatic,
        Auto
    }

    public class TapeRemoveMBX : ClientMBX
    {
        public enum Register
        {
            #region ROBOT

            /// <summary>
            /// 16 bit Robot 一般訊號
            /// 0	
            /// 1	通知機台初始化 0:None、1:OK
            /// 2	
            /// 3	
            /// 4	
            /// 5	
            /// 6	
            /// 7	
            /// 8	Health
            /// 9	ROBOT 暫停
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F
            /// </summary>
            Robot_Common_Signal = 00,

            /// <summary>
            /// 16 bit Robot CV1 交握訊號
            /// 0	ROBOT 出片要求
            /// 1	ROBOT 設備運轉中(出片中)
            /// 2	ROBOT 放片確認到位完畢
            /// 3	ROBOT 接收許可
            /// 4	ROBOT 運轉中(收片中)
            /// 5	ROBOT 接收完畢
            /// 6	ROBOT 通知執行撕膜動作 0:None、1:OK
            /// 7	ROBOT 通知執行退片動作 0:None、1:OK
            /// 8	ROBOT 執行Unload & Load //1.1.0.3
            /// 9	
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F
            /// </summary>
            Robot_CV1_Transfer_Signal = 02,         //Robot CV1 交握訊號

            /// <summary>
            /// 16 bit Robot CV2 交握訊號
            /// 0	EQ Ready設備RD(人機按鈕In-line設備溝通)
            /// 1	撕膜機 接收許可
            /// 2	撕膜機 運轉中(收片中)
            /// 3	撕膜機 接收完畢
            /// 4	撕膜機 出片要求
            /// 5	撕膜機 設備運轉中(出片中)
            /// 6	撕膜機 出片確認完畢
            /// 7	ROBOT 通知執行撕膜動作 0:None、1:OK
            /// 8	ROBOT 通知執行退片動作 0:None、1:OK
            /// 9	ROBOT 執行Unload & Load //1.1.0.3
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F
            /// </summary>
            Robot_CV2_Transfer_Signal = 04,         //Robot CV1 交握訊號

            Robot_WaferSize = 06,//設定撕膜機尺寸(8、12)

            #endregion ROBOT
            //=======================================================
            #region TOOL

            /// <summary>
            /// 16 bit Tool 一般訊號
            /// 0	Alarm
            /// 1	初始化完成 0:None、1:OK
            /// 2	
            /// 3	
            /// 4	
            /// 5	
            /// 6	
            /// 7	
            /// 8	Health
            /// 9	ROBOT 暫停
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F	
            /// </summary>
            Tool_Common_Signal = 500,

            /// <summary>
            /// 16 bit Tool CV1 交握訊號
            /// 0	EQ Ready設備RD(人機按鈕In-line設備溝通)
            /// 1	撕膜機 接收許可
            /// 2	撕膜機 運轉中(收片中)
            /// 3	撕膜機 接收完畢
            /// 4	撕膜機 出片要求
            /// 5	撕膜機 設備運轉中(出片中)
            /// 6	撕膜機 出片確認完畢
            /// 7	
            /// 8	
            /// 9	
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F
            /// </summary>
            Tool_CV1_Transfer_Signal = 502,         //Tool CV1 交握訊號

            /// <summary>
            /// 16 bit Tool CV2 旗標
            /// 0	雷射測距完成旗標
            /// 1	破口針頭動作Start旗標
            /// 2	破口針頭動作End旗標
            /// 3	CCD檢查破口完成旗標
            /// 4	撕膜動作Start旗標
            /// 5	撕膜動作End旗標
            /// 6	滾輪下壓動作Start旗標
            /// 7	滾輪下壓動作End旗標
            /// 8	CCD檢查撕膜結果完成旗標
            /// 9	撕膜NG退片
            /// A	Align Start
            /// B	Align End
            /// C	破口NG退片
            /// D	使用CV1
            /// E	使用破口
            /// F
            /// </summary>
            Tool_CV1_Flag = 503,                    //Tool CV1 旗標

            /// <summary>
            /// 16 bit Tool CV2 交握訊號
            /// 1	EQ Ready設備RD(人機按鈕In-line設備溝通)
            /// 2	撕膜機 接收許可
            /// 3	撕膜機 運轉中(收片中)
            /// 4	撕膜機 接收完畢
            /// 5	撕膜機 出片要求
            /// 6	撕膜機 設備運轉中(出片中)
            /// 7	撕膜機 出片確認完畢
            /// 8	
            /// 9	
            /// A	
            /// B	
            /// C	
            /// D	
            /// E	
            /// F	
            /// </summary>
            Tool_CV2_Transfer_Signal = 504,         //Tool CV2 交握訊號

            /// <summary>
            /// 16 bit Tool CV2 旗標
            /// 0	雷射測距完成旗標
            /// 1	破口針頭動作Start旗標
            /// 2	破口針頭動作End旗標
            /// 3	CCD檢查破口完成旗標
            /// 4	撕膜動作Start旗標
            /// 5	撕膜動作End旗標
            /// 6	滾輪下壓動作Start旗標
            /// 7	滾輪下壓動作End旗標
            /// 8	CCD檢查撕膜結果完成旗標
            /// 9	撕膜NG退片
            /// A	Align Start
            /// B	Align End
            /// C	破口NG退片
            /// D	使用CV2
            /// E	使用破口
            /// F
            /// </summary>
            Tool_CV2_Flag = 505,                    //Tool CV2 旗標

            Tool_WaferSize = 506,                   //撕膜機尺寸(8、12)
            Tool_TapeUseCount = 516,				//膠帶使用次數(計數)
            Tool_RollerDownPressure = 517,          //滾輪下壓力道(單位kPa)
            Tool_Machine_Status = 518,              //機台狀態(手動 = 0 / 半自動 = 1 / 自動 = 2)

            Tool_CV1_LaserData = 519,               //雷射測距數值[CV1]
            Tool_CV1_CutNeedles_Current = 521,      //破口針頭電流值[CV1]
            Tool_CV1_DeTape_Current = 522,          //撕膜電流值[CV1]
            Tool_CV1_CCD_CutResult = 523,           //CCD檢查破口數據[CV1]
            Tool_CV1_DeTape_ESD = 524,              //撕膜靜電值[CV1]
            Tool_CV1_CutNeedles_UseCount = 526,     //破口針頭使用次數(計數)[CV1]
            Tool_CV1_CCD_DeTapeResult = 527,        //CCD判斷撕膜狀況結果[CV1](OK = 1 / NG = 2)

            Tool_CV2_LaserData = 528,               //雷射測距數值[CV2]
            Tool_CV2_CutNeedles_Current = 530,      //破口針頭電流值[CV2]
            Tool_CV2_DeTape_Current = 531,          //撕膜電流值[CV2]
            Tool_CV2_CCD_CutResult = 532,           //CCD檢查破口數據[CV2]
            Tool_CV2_DeTape_ESD = 533,              //撕膜靜電值[CV2]
            Tool_CV2_CutNeedles_UseCount = 535,     //破口針頭使用次數(計數)[CV2]
            Tool_CV2_CCD_DeTapeResult = 536,        //CCD判斷撕膜狀況結果[CV2](OK = 1 / NG = 2)

            #endregion TOOL
        }

        public struct RB_SignalDefine
        {
            public bool bRB_NotifyInitial;
            public bool bRB_Ready;
            public bool bRB_Pause;

            public bool bRB_CV1_Out_Request;
            public bool bRB_CV1_Out_Busy;
            public bool bRB_CV1_Out_Complete;
            public bool bRB_CV1_Receive_Permission;
            public bool bRB_CV1_Receive_Busy;
            public bool bRB_CV1_Receive_Complete;
            public bool bRB_CV1_DoDeTape;
            public bool bRB_CV1_DoReject;
            public bool bRB_CV1_DoUnload_Load;//1.1.0.3

            public bool bRB_CV2_Out_Request;
            public bool bRB_CV2_Out_Busy;
            public bool bRB_CV2_Out_Complete;
            public bool bRB_CV2_Receive_Permission;
            public bool bRB_CV2_Receive_Busy;
            public bool bRB_CV2_Receive_Complete;
            public bool bRB_CV2_DoDeTape;
            public bool bRB_CV2_DoReject;
            public bool bRB_CV2_DoUnload_Load;//1.1.0.3

            public int iRB_WaferSize;

            public void Reset()
            {
                bRB_NotifyInitial = false;
                bRB_Ready = false;
                bRB_Pause = false;

                bRB_CV1_Out_Request = false;
                bRB_CV1_Out_Busy = false;
                bRB_CV1_Out_Complete = false;
                bRB_CV1_Receive_Permission = false;
                bRB_CV1_Receive_Busy = false;
                bRB_CV1_Receive_Complete = false;
                bRB_CV1_DoDeTape = false;
                bRB_CV1_DoReject = false;
                bRB_CV1_DoUnload_Load = false;//1.1.0.3

                bRB_CV2_Out_Request = false;
                bRB_CV2_Out_Busy = false;
                bRB_CV2_Out_Complete = false;
                bRB_CV2_Receive_Permission = false;
                bRB_CV2_Receive_Busy = false;
                bRB_CV2_Receive_Complete = false;
                bRB_CV2_DoDeTape = false;
                bRB_CV2_DoReject = false;
                bRB_CV2_DoUnload_Load = false;//1.1.0.3

                iRB_WaferSize = 0;
            }
        }

        public struct TOOL_SignalDefine
        {
            public bool bTOOL_Alarm;
            public bool bTOOL_InitialDone;
            public bool bTOOL_Pause;
            public int iTOOL_TapeUseCount;
            public float fTOOL_RollerDownPressure;
            public int iTOOL_AlarmCode;
            public TOOL_Machine_Status eTOOL_Machine_Status;
            public EWaferSize eTOOL_WaferSize;

            #region CV1
            public bool bTOOL_CV1_Ready;
            public bool bTOOL_CV1_Receive_Permission;
            public bool bTOOL_CV1_Receive_Busy;
            public bool bTOOL_CV1_Receive_Complete;
            public bool bTOOL_CV1_Out_Request;
            public bool bTOOL_CV1_Out_Busy;
            public bool bTOOL_CV1_Out_Complete;

            public bool bTOOL_CV1_LaserMeasurement_OK;
            public bool bTOOL_CV1_Cut_Start;
            public bool bTOOL_CV1_Cut_End;
            public bool bTOOL_CV1_CCD_CheckCutOK;
            public bool bTOOL_CV1_DeTape_Start;
            public bool bTOOL_CV1_DeTape_End;
            public bool bTOOL_CV1_RollerDown_Start;
            public bool bTOOL_CV1_RollerDown_End;
            public bool bTOOL_CV1_CCD_CheckDeTape_OK;
            public bool bTOOL_CV1_DeTapeNG;
            public bool bTOOL_CV1_Align_Start;
            public bool bTOOL_CV1_Align_End;
            public bool bTOOL_CV1_CutNG;
            public bool bTOOL_CV1_Use;
            public bool bTOOL_CV1_Cut_Use;

            public bool bTOOL_CV1_DeTapeArmIsSafe;
            public bool bTOOL_CV1_LaserArmIsSafe;
            public bool bTOOL_CV1_CutArmIsSafe;
            public bool bTOOL_CV1_Ejector_MoveToLoadPos_VacuumOff;

            public float fTOOL_CV1_LaserMeasurementData;
            public float fTOOL_CV1_CutNeedles_Current;
            public float fTOOL_CV1_DeTape_Current_Axiz17;
            public float fTOOL_CV1_DeTape_Current_Axiz18;
            public float fTOOL_CV1_ESD;
            public int iTOOL_CV1_CutNeedles_UseCount;
            public int iTOOL_CV1_CCD_CutResult;
            public int iTOOL_CV1_CutNeedles_Current;
            public int iTOOL_CV1_CCD_DeTapeResult;

            #endregion CV1

            #region CV2
            public bool bTOOL_CV2_Ready;
            public bool bTOOL_CV2_Receive_Permission;
            public bool bTOOL_CV2_Receive_Busy;
            public bool bTOOL_CV2_Receive_Complete;
            public bool bTOOL_CV2_Out_Request;
            public bool bTOOL_CV2_Out_Busy;
            public bool bTOOL_CV2_Out_Complete;

            public bool bTOOL_CV2_LaserMeasurement_OK;
            public bool bTOOL_CV2_Cut_Start;
            public bool bTOOL_CV2_Cut_End;
            public bool bTOOL_CV2_CCD_CheckCutOK;
            public bool bTOOL_CV2_DeTape_Start;
            public bool bTOOL_CV2_DeTape_End;
            public bool bTOOL_CV2_RollerDown_Start;
            public bool bTOOL_CV2_RollerDown_End;
            public bool bTOOL_CV2_CCD_CheckDeTape_OK;
            public bool bTOOL_CV2_DeTapeNG;
            public bool bTOOL_CV2_Align_Start;
            public bool bTOOL_CV2_Align_End;
            public bool bTOOL_CV2_CutNG;
            public bool bTOOL_CV2_Use;
            public bool bTOOL_CV2_Cut_Use;

            public bool bTOOL_CV2_DeTapeArmIsSafe;
            public bool bTOOL_CV2_LaserArmIsSafe;
            public bool bTOOL_CV2_CutArmIsSafe;
            public bool bTOOL_CV2_Ejector_MoveToLoadPos_VacuumOff;

            public float fTOOL_CV2_LaserMeasurementData;
            public float fTOOL_CV2_CutNeedles_Current;
            public float fTOOL_CV2_DeTape_Current_Axiz17;
            public float fTOOL_CV2_DeTape_Current_Axiz18;
            public float fTOOL_CV2_ESD;
            public int iTOOL_CV2_CutNeedles_UseCount;
            public int iTOOL_CV2_CCD_CutResult;
            public int iTOOL_CV2_CutNeedles_Current;
            public int iTOOL_CV2_CCD_DeTapeResult;

            #endregion CV2
        }

        private TOOL_SignalDefine TOOL_Signal = new TOOL_SignalDefine();
        public TOOL_SignalDefine GetToolSignal { get { return TOOL_Signal; } }

        public TapeRemoveMBX(string sIP, string sPort,string StationName)
        {
            delShowRecMsg += Decode;
            IP = sIP;
            Port = sPort;
            LogName = StationName;
        }

        private void Decode(byte[] data)
        {
            if (data[7] == 0x03)
            {
                String str = "";
                if (data[8] == 2)
                {

                }
                else
                {
                    switch ((MBX_Function)data[1])
                    {
                        case MBX_Function.None:
                            break;
                        case MBX_Function.ReadToolSignal:
                            {
                                byte[] dataText = new byte[data.Length - 9];//定義文字數組 
                                Array.Copy(data, 9, dataText, 0, dataText.Length);
                                ushort[] words = new ushort[dataText.Length / 2];

                                for (int i = 0, j = 0; i < dataText.Length; i += 2, j++)
                                {
                                    words[j] = (ushort)((dataText[i] << 8) | dataText[i + 1]);
                                }

                                bool[] Signals = BytesToBinaryBoolArray(words[0]);
                                TOOL_Signal.bTOOL_Alarm = Signals[0];
                                TOOL_Signal.bTOOL_InitialDone = Signals[1];

                                Signals = BytesToBinaryBoolArray(words[1]);
                                TOOL_Signal.bTOOL_CV1_DeTapeArmIsSafe = Signals[0];
                                TOOL_Signal.bTOOL_CV1_LaserArmIsSafe = Signals[1];
                                TOOL_Signal.bTOOL_CV1_CutArmIsSafe = Signals[2];
                                TOOL_Signal.bTOOL_CV1_Ejector_MoveToLoadPos_VacuumOff = Signals[3];
                                TOOL_Signal.bTOOL_CV2_DeTapeArmIsSafe = Signals[8];
                                TOOL_Signal.bTOOL_CV2_LaserArmIsSafe = Signals[9];
                                TOOL_Signal.bTOOL_CV2_CutArmIsSafe = Signals[10];
                                TOOL_Signal.bTOOL_CV2_Ejector_MoveToLoadPos_VacuumOff = Signals[11];

                                Signals = BytesToBinaryBoolArray(words[2]);
                                TOOL_Signal.bTOOL_CV1_Ready = Signals[0];
                                TOOL_Signal.bTOOL_CV1_Receive_Permission = Signals[1];
                                TOOL_Signal.bTOOL_CV1_Receive_Busy = Signals[2];
                                TOOL_Signal.bTOOL_CV1_Receive_Complete = Signals[3];
                                TOOL_Signal.bTOOL_CV1_Out_Request = Signals[4];
                                TOOL_Signal.bTOOL_CV1_Out_Busy = Signals[5];
                                TOOL_Signal.bTOOL_CV1_Out_Complete = Signals[6];

                                Signals = BytesToBinaryBoolArray(words[3]);
                                TOOL_Signal.bTOOL_CV1_LaserMeasurement_OK = Signals[0];
                                TOOL_Signal.bTOOL_CV1_Cut_Start = Signals[1];
                                TOOL_Signal.bTOOL_CV1_Cut_End = Signals[2];
                                TOOL_Signal.bTOOL_CV1_CCD_CheckCutOK = Signals[3];
                                TOOL_Signal.bTOOL_CV1_DeTape_Start = Signals[4];
                                TOOL_Signal.bTOOL_CV1_DeTape_End = Signals[5];
                                TOOL_Signal.bTOOL_CV1_RollerDown_Start = Signals[6];
                                TOOL_Signal.bTOOL_CV1_RollerDown_End = Signals[7];
                                TOOL_Signal.bTOOL_CV1_CCD_CheckDeTape_OK = Signals[8];
                                TOOL_Signal.bTOOL_CV1_DeTapeNG = Signals[9];
                                TOOL_Signal.bTOOL_CV1_Align_Start = Signals[10];
                                TOOL_Signal.bTOOL_CV1_Align_End = Signals[11];
                                TOOL_Signal.bTOOL_CV1_CutNG = Signals[12];
                                TOOL_Signal.bTOOL_CV1_Use = Signals[13];
                                TOOL_Signal.bTOOL_CV1_Cut_Use = Signals[14];

                                Signals = BytesToBinaryBoolArray(words[4]);
                                TOOL_Signal.bTOOL_CV2_Ready = Signals[0];
                                TOOL_Signal.bTOOL_CV2_Receive_Permission = Signals[1];
                                TOOL_Signal.bTOOL_CV2_Receive_Busy = Signals[2];
                                TOOL_Signal.bTOOL_CV2_Receive_Complete = Signals[3];
                                TOOL_Signal.bTOOL_CV2_Out_Request = Signals[4];
                                TOOL_Signal.bTOOL_CV2_Out_Busy = Signals[5];
                                TOOL_Signal.bTOOL_CV2_Out_Complete = Signals[6];

                                Signals = BytesToBinaryBoolArray(words[5]);
                                TOOL_Signal.bTOOL_CV2_LaserMeasurement_OK = Signals[0];
                                TOOL_Signal.bTOOL_CV2_Cut_Start = Signals[1];
                                TOOL_Signal.bTOOL_CV2_Cut_End = Signals[2];
                                TOOL_Signal.bTOOL_CV2_CCD_CheckCutOK = Signals[3];
                                TOOL_Signal.bTOOL_CV2_DeTape_Start = Signals[4];
                                TOOL_Signal.bTOOL_CV2_DeTape_End = Signals[5];
                                TOOL_Signal.bTOOL_CV2_RollerDown_Start = Signals[6];
                                TOOL_Signal.bTOOL_CV2_RollerDown_End = Signals[7];
                                TOOL_Signal.bTOOL_CV2_CCD_CheckDeTape_OK = Signals[8];
                                TOOL_Signal.bTOOL_CV2_DeTapeNG = Signals[9];
                                TOOL_Signal.bTOOL_CV2_Align_Start = Signals[10];
                                TOOL_Signal.bTOOL_CV2_Align_End = Signals[11];
                                TOOL_Signal.bTOOL_CV2_CutNG = Signals[12];
                                TOOL_Signal.bTOOL_CV2_Use = Signals[13];
                                TOOL_Signal.bTOOL_CV2_Cut_Use = Signals[14];

                                int WSize = BytesToInt32(words[6]);//防例外
                                TOOL_Signal.eTOOL_WaferSize = WSize == 8 ? EWaferSize.Wafer_8 : EWaferSize.Wafer_12;
                                TOOL_Signal.iTOOL_AlarmCode = BytesToInt32(words[8]);
                                TOOL_Signal.iTOOL_TapeUseCount = BytesToInt32(words[9]);
                                TOOL_Signal.fTOOL_RollerDownPressure = (float)(WordsToInt(words[10], words[11]) / 1000.0);

                                int state = BytesToInt32(words[12]);//防例外
                                TOOL_Signal.eTOOL_Machine_Status = (state < 3) ? (TOOL_Machine_Status)state : TOOL_Machine_Status.Manual;

                                TOOL_Signal.fTOOL_CV1_LaserMeasurementData = (float)(WordsToInt(words[22], words[23]) / 10.0);
                                TOOL_Signal.fTOOL_CV1_CutNeedles_Current = (float)(BytesToInt16(words[18]) / 10.0);
                                TOOL_Signal.fTOOL_CV1_DeTape_Current_Axiz17 = (float)(BytesToInt16(words[19]) / 10.0);
                                TOOL_Signal.fTOOL_CV1_DeTape_Current_Axiz18 = (float)(BytesToInt16(words[20]) / 10.0);
                                TOOL_Signal.iTOOL_CV1_CCD_CutResult = BytesToInt32(words[16]);
                                TOOL_Signal.fTOOL_CV1_ESD = (float)(WordsToInt(words[24], words[25]));
                                TOOL_Signal.iTOOL_CV1_CutNeedles_UseCount = WordsToInt(words[26], words[27]);
                                TOOL_Signal.iTOOL_CV1_CCD_DeTapeResult = BytesToInt32(words[17]);

                                TOOL_Signal.fTOOL_CV2_LaserMeasurementData = (float)(WordsToInt(words[38], words[39]) / 10.0);
                                TOOL_Signal.fTOOL_CV2_CutNeedles_Current = (float)(BytesToInt16(words[34]) / 10.0);
                                TOOL_Signal.fTOOL_CV2_DeTape_Current_Axiz17 = (float)(BytesToInt16(words[35]) / 10.0);
                                TOOL_Signal.fTOOL_CV2_DeTape_Current_Axiz18 = (float)(BytesToInt16(words[36]) / 10.0);
                                TOOL_Signal.iTOOL_CV2_CCD_CutResult = BytesToInt32(words[32]);
                                TOOL_Signal.fTOOL_CV2_ESD = (float)(WordsToInt(words[40], words[41]));
                                TOOL_Signal.iTOOL_CV2_CutNeedles_UseCount = WordsToInt(words[42], words[43]);
                                TOOL_Signal.iTOOL_CV2_CCD_DeTapeResult = BytesToInt32(words[33]);
                            }
                            break;
                        default:
                            break;
                    }
                    //byte[] dataText = new byte[data.Length - 9];//定義文字數組 
                    //Array.Copy(data, 9, dataText, 0, dataText.Length);

                    str = BitConverter.ToString(data);
                }
            }
        }

    }
}
