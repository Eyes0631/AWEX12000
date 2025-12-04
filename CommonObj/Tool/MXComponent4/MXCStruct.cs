using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace CommonObj
{
    public class MXC4Struct
    {
        //v1.0.0.17 noke
        public static List<HandOverSignal> HandOverSignals = new List<HandOverSignal>();
        public static List<PanelDataFlow> PanelDataFlows = new List<PanelDataFlow>();

        public MXC4Struct()
        {
        }

        public MXCAction Action
        {
            get;
            set;
        }

        public MXCLocation Location
        {
            get;
            set;
        }

        public eMXC_IO_Read IO_Num
        {
            get;
            set;
        }

        public eMXC_ID ID_Num
        {
            get;
            set;
        }

        public HandOver_Define.eHandOver NowHandOver
        {
            get;
            set;
        }

        public MXCNGReason NGReason
        {
            get;
            set;
        }

        public string ID //ID結果
        {
            get;
            set;
        }

        public bool IO //ID結果
        {
            get;
            set;
        }

        public Dictionary<object, string> Dictionary //v1.0.0.11 ted
        {
            get;
            set;
        }

        //需要自己新增欄位
        public int GetOVDIO(HandOver_Define.eHandOver HandOver)
        {
            switch (HandOver)
            {
                //case HandOver_Define.eHandOver.eEFEM_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_OVD_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_OVD_Doit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Done:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_OVD_Done;
                //    }
                //case HandOver_Define.eHandOver.eInLine_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_OVD_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_OVD_Doit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Done:
                //    {
                //        return (int)eMXC_IO_Read.eInline_OVD_Done;
                //    }
                default:
                    break;
            }
            return 0;
        }

        public int GetN2BIO(HandOver_Define.eHandOver HandOver)
        {
            switch (HandOver)
            {
                //case HandOver_Define.eHandOver.eEFEM_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_N2B_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_N2B_Doit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Done:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_N2B_Done;
                //    }
                //case HandOver_Define.eHandOver.eInLine_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_N2B_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_N2B_Doit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Done:
                //    {
                //        return (int)eMXC_IO_Read.eInline_N2B_IsDoit;
                //    }
                default:
                    break;
            }
            return 0;
        }

        public int GetPVD_Up_IO(HandOver_Define.eHandOver HandOver)
        {
            switch (HandOver)
            {
                case HandOver_Define.eHandOver.eEFEM_IsDoit:
                    {
                        return (int)eMXC_IO_Read.eEFEM_PVLU_IsDoit;
                    }
                case HandOver_Define.eHandOver.eEFEM_Doit:
                    {
                        return (int)eMXC_IO_Read.eEFEM_PVLU_Doit;
                    }
                case HandOver_Define.eHandOver.eEFEM_Done:
                    {
                        return (int)eMXC_IO_Read.eEFEM_PVLU_Done;
                    }
                case HandOver_Define.eHandOver.eInLine_IsDoit:
                    {
                        return (int)eMXC_IO_Read.eInline_PVLU_IsDoit;
                    }
                case HandOver_Define.eHandOver.eInLine_Doit:
                    {
                        return (int)eMXC_IO_Read.eInline_PVLU_Doit;
                    }
                case HandOver_Define.eHandOver.eInLine_Done:
                    {
                        return (int)eMXC_IO_Read.eInline_PVLU_Done;
                    }
                default:
                    break;
            }
            return 0;
        }

        public int GetPVD_Down_IO(HandOver_Define.eHandOver HandOver)
        {
            switch (HandOver)
            {
                //case HandOver_Define.eHandOver.eEFEM_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_PVLD_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_PVLD_Doit;
                //    }
                //case HandOver_Define.eHandOver.eEFEM_Done:
                //    {
                //        return (int)eMXC_IO_Read.eEFEM_PVLD_Done;
                //    }
                //case HandOver_Define.eHandOver.eInLine_IsDoit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_PVLD_IsDoit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Doit:
                //    {
                //        return (int)eMXC_IO_Read.eInline_PVLD_Doit;
                //    }
                //case HandOver_Define.eHandOver.eInLine_Done:
                //    {
                //        return (int)eMXC_IO_Read.eInline_PVLD_Done;
                //    }
                default:
                    break;
            }
            return 0;
        }


    }

    public enum MXCAction
    {
        None,
        WriteID,//有ID就是有料
        WritePanelInfo,//有ID就是有料
        ReadID,
        HandOver_Write,
        HandOver_Read,
        HandOver,
        Reject,
        GetCommand,
        WriteIO,
        WriteRandom,
        PollingCOM,//讀取上位命令
    }

    /////////////////////////////////////不能任意修改設定位置/////////////////////////////////////
    public enum MXCLocation
    {
        None,
        CoveyorIn = 10000,
        PTI = 10400,
        PPM_Upper = 10800,
        PPM_Lower = 11200,
        Plasma = 11600,
        Buffer_1 = 12000,
        Buffer_2 = 12400,
        Buffer_3 = 12800,
        Buffer_4 = 13200,
        PTO = 13600,
        CoveyorOut = 14000,

        //DVID 2byte v1.0.0.11 ted

        RemoteControl = 30000,
        WorkingFlow = 30001,
        CurrCommState = 30002,
        CurrControlState = 30003,
        PreControlState = 30004,
        CurrProcessState = 30005,
        PreProcessState = 30006,

        //DVID A20
        MDLN = 30020,
        SOFTREV = 30040,
        //
        //
        LOTSTARTTIME = 30100,
        LOTRUNTIME = 30120,
        LOTENDTIME = 30140,
        PackageName = 30160,
        AlarmID = 30180,
        AlarmText = 30200,
        OP_ID = 30220,
        LOTID = 30240,
        LOTCOUNT = 30260,
        REPAIR_ID = 30280,
        SEASON_ID = 30300,

        AvgPower = 30320,
        AvgFlowRate = 30340,
        AvgAirPressure = 30360,
    }

    public enum eMXCRemoteControl//v1.0.0.11 ted
    {
        START = 0,// = machine start action
        PAUSE,// = machine suspende action
        LOTEND,// = Lot end.
        PP_SELECT,// = Select recipe. (Reserved)                
        None,//初始狀態
    }

    public enum eMXCWorkingFlow//v1.0.0.11 ted
    {
        PVD = 0,// = Normal Work Flow.
        CLEAN_TABLE,// = Move All Panel / Carrier Output.
        REJECT,// = Reject Flow
        Wait_REJECT,// = Wait Reject
        SELFCLEAN,// = SELFCLEAN Flow.
        SEASON,// = SEASON Flow.
        SEASON_SWAP,// = SEASON Swap Flow.
        None,//初始狀態
    }

    public enum eMXCCommState//v1.0.0.11 ted
    {
        DISABLED = 0,
        COMMUNICATING,
    }

    public enum eMXCControlState//v1.0.0.11 ted
    {
        OFFLINE_EQUIPMENT_OFFLINE = 0,
        OFFLINE_ATTEMPT_ONLINE,
        OFFLINE_HOST_OFFLINE,
        ONLINE_LOCAL,
        ONLINE_REMOTE,
    }

    public enum eMXCProcessState//v1.0.0.11 ted
    {
        IDLE = 0,//(default)
        HOME,//
        INITIAL,//
        SETUP,//
        START,//
        PAUSE,//
        ALARM,//(Maching Not Working)
        PM,//
    }

    /////////////////////////////////////不能任意修改設定位置/////////////////////////////////////

    /// <summary>
    /// 
    /// 1燈號代表烤片完成
    /// 2燈號代表烤片完成
    /// 3燈號代表烤片完成
    /// 4燈號代表烤片完成
    /// 5燈號代表烤片完成
    /// 6燈號代表烤片完成
    /// 
    /// 有ID代表有料
    /// 
    /// OVD開門出料流程///////////
    /// 
    /// //None
    /// 
    /// L_Ready  : false 
    /// L_Doit   : false
    /// L_Done   : false
    /// P_Ready  : false    
    /// P_Doit   : false
    /// P_Done   : false
    /// DIR      : false
    /// 
    /// //ProV 通知開始取料
    /// L_Ready  : false 
    /// L_Doit   : false
    /// L_Done   : false
    /// P_Ready  : true    
    /// P_Doit   : false
    /// P_Done   : false
    /// DIR      : false
    /// 
    /// Linco 收到出料通知
    /// L_Ready  : true 
    /// L_Doit   : false
    /// L_Done   : false
    /// P_Ready  : true    
    /// P_Doit   : false
    /// P_Done   : false
    /// DIR      : false
    /// 
    /// ProV 通知準備收料
    /// L_Ready  : true 
    /// L_Doit   : false
    /// L_Done   : false
    /// P_Ready  : true    
    /// P_Doit   : true
    /// P_Done   : false
    /// DIR      : false
    /// 
    /// 凌嘉 通知準備出料
    /// L_Ready  : true 
    /// L_Doit   : true
    /// L_Done   : false
    /// P_Ready  : true    
    /// P_Doit   : true
    /// P_Done   : false
    /// DIR      : false 
    /// 
    /// 手臂取料  
    /// 
    /// ProV 通知取料完成
    /// L_Ready  : true 
    /// L_Doit   : true
    /// L_Done   : false
    /// P_Ready  : true    
    /// P_Doit   : true
    /// P_Done   : true
    /// DIR      : false
    /// 
    /// 凌嘉 通知關門完成
    /// L_Ready  : true 
    /// L_Doit   : true
    /// L_Done   : true
    /// P_Ready  : true    
    /// P_Doit   : true
    /// P_Done   : true
    /// DIR      : false
    /// 
    /// ProV 狀態復歸
    /// L_Ready  : true 
    /// L_Doit   : true
    /// L_Done   : true
    /// P_Ready  : false    
    /// P_Doit   : false
    /// P_Done   : false
    /// DIR      : false
    /// 
    /// 凌嘉 狀態復歸
    /// L_Ready  : false 
    /// L_Doit   : false
    /// L_Done   : false
    /// P_Ready  : false    
    /// P_Doit   : false
    /// P_Done   : false
    /// DIR      : false
    /// 
    ///    
    /// 
    /// </summary>
    //public enum MXCHandOverStatus
    //{
    //    None,
    //    IsReady,//針對整個腔室詢問
    //    Ready,
    //    //open
    //    OpenDoit,
    //    OpenDone,
    //    //Close
    //    CloseDoit,
    //    CloseDone,
    //    //
    //    ACK,
    //    NAK,
    //    //
    //    IsConveyorIn,
    //    ConveyorInDoit,
    //    ConveyorInDone,
    //    //
    //    IsConveyorOut,
    //    ConveyorOutDoit,
    //    ConveyorOutDone,
    //}

    public enum MXCNGReason
    {
        Timeout,
        Reject,
        IDFail,
    }


    public enum eMXC_ID
    {
        eOVD_Level_1 = 1,
        eOVD_Level_2,
        eOVD_Level_3,
        eOVD_Level_4,
        eOVD_Level_5,
        eOVD_Level_6,

        eN2B_Level_1 = 10,
        eN2B_Level_2,
        eN2B_Level_3,
        eN2B_Level_4,
        eN2B_Level_5,
        eN2B_Level_6,

        eNBM_Level_1 = 20,
        eNBM_Level_2,
        eNBM_Level_3,
        eNBM_Level_4,
        eNBM_Level_5,
        eNBM_Level_6,
        eNBM_Level_7,
        eNBM_Level_8,

        eUBM_Level_1 = 30,
        eUBM_Level_2,
        eUBM_Level_3,
        eUBM_Level_4,
        eUBM_Level_5,
        eUBM_Level_6,

        eCONVEYOR_IN = 40,
        ePTMB,
        ePTMF,
        ePPM,
        eNGM,
        ePVDL_UP,
        ePVDL_Down,//Carrier ID
        ePVDU_UP,
        ePVDU_Down,//Carrier ID
        ePVU,//Carrier ID
        ePBM,
        eCONVEYOR_OUT,//51


    }

    public enum eMXC_IO_Read
    {
        eNone,

        eInline_CNVI_Ready = 0x1E00,
        eInline_CNVI_IsDoit,
        eInline_CNVI_Doit,
        eInline_CNVI_Done,

        eInline_PVLU_Ready = 0x1E30,
        eInline_PVLU_IsDoit,
        eInline_PVLU_Doit,
        eInline_PVLU_Done,

        eInline_CNVO_Ready = 0x1E70,
        eInline_CNVO_IsDoit,
        eInline_CNVO_Doit,
        eInline_CNVO_Done,

        //EFEM

        eEFEM_CNVI_Ready = 0x1F00,
        eEFEM_CNVI_IsDoit,
        eEFEM_CNVI_Doit,
        eEFEM_CNVI_Done,

        eEFEM_PVLU_Ready = 0x1F30,
        eEFEM_PVLU_IsDoit,
        eEFEM_PVLU_Doit,
        eEFEM_PVLU_Done,

        eEFEM_CNVO_Ready = 0x1F70,
        eEFEM_CNVO_IsDoit,
        eEFEM_CNVO_Doit,
        eEFEM_CNVO_Done,

        eEnd = 0x1F7F,//決定讀取寫入長度
    }

    public enum eMXC_IO_Write
    {
        eEFEM_CNVI_Ready = 0x1F00,
        eEFEM_CNVI_IsDoit,
        eEFEM_CNVI_Doit,
        eEFEM_CNVI_Done,

        eEFEM_PVLU_Ready = 0x1F30,
        eEFEM_PVLU_IsDoit,
        eEFEM_PVLU_Doit,
        eEFEM_PVLU_Done,

        eEFEM_CNVO_Ready = 0x1F70,
        eEFEM_CNVO_IsDoit,
        eEFEM_CNVO_Doit,
        eEFEM_CNVO_Done,

        eEnd = 0x1F7F,//決定讀取寫入長度
    }

    public delegate bool DelMXCSetAction(MXC4Struct MXC);

    public class HandOver_Define
    {
        //
        int iStep = 0;

        private bool bEFEM_IsDoit;
        private bool bEFEM_Doit;
        private bool bEFEM_Done;
        private bool bInLine_IsDoit;
        private bool bInLine_Doit;
        private bool bInLine_Done;

        private eHandOver eNowHandOver;

        private DelMXCSetAction _DelMXCSetAction;

        public void SetDelMXCSetAction(DelMXCSetAction MXCn)
        {
            _DelMXCSetAction = MXCn;
        }

        //public bool SetAction(MXC4Struct Action)
        //{
        //    return _DelMXCSetAction(Action);        
        //}

        public eHandOver NowHandOver
        {

            get
            {
                return eNowHandOver;
            }

        }

        public bool EFEM_IsDoit
        {
            get
            {
                return bEFEM_IsDoit;
            }
        }
        public bool EFEM_Doit
        {
            get
            {
                return bEFEM_Doit;
            }
        }
        public bool EFEM_Done
        {
            get
            {
                return bEFEM_Done;
            }
        }
        public bool InLine_IsDoit
        {
            get
            {
                return bInLine_IsDoit;
            }
        }
        public bool InLine_Doit
        {
            get
            {
                return bInLine_Doit;
            }
        }
        public bool InLine_Done
        {
            get
            {
                return bInLine_Done;
            }
        }

        public enum eHandOver
        {
            [Description("重置")]
            eReset,
            [Description("詢問是否開始動作")]
            eEFEM_IsDoit,
            [Description("詢問是否可以開門或開始轉動")]
            eEFEM_Doit,
            [Description("手臂工作完成並到安全位置-->Inline可以開始關門")]
            eEFEM_Done,
            [Description("接收到開始動作指令")]
            eInLine_IsDoit,
            [Description("開門完成-->EFEM可以開始取放料")]
            eInLine_Doit,
            [Description("Inline關門完成")]
            eInLine_Done,
        }


        public void Reset()
        {
            iStep = 1;
            bEFEM_IsDoit = false;
            bEFEM_Doit = false;
            bEFEM_Done = false;
            bInLine_IsDoit = false;
            bInLine_Doit = false;
            bInLine_Done = false;
        }

        public bool HandOver(MXC4Struct Action)
        {
            //紀錄現在狀態
            eNowHandOver = Action.NowHandOver;

            eMXC_IO_Read eIO_Read = eMXC_IO_Read.eNone;

            switch (Action.Location)
            {
                case MXCLocation.CoveyorIn:
                    break;
                case MXCLocation.Buffer_1:
                case MXCLocation.Buffer_2:
                case MXCLocation.Buffer_3:
                case MXCLocation.Buffer_4:
                    {
                        eIO_Read = (eMXC_IO_Read)Action.GetN2BIO(eNowHandOver);
                    }
                    break;
                default:
                    break;
            }

            switch (eNowHandOver)
            {
                case eHandOver.eReset:
                    {
                        Reset();
                    }
                    break;
                case eHandOver.eEFEM_IsDoit:
                    {
                        if (_DelMXCSetAction(Action))
                        {
                            bEFEM_IsDoit = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case eHandOver.eEFEM_Doit:
                    {
                        if (_DelMXCSetAction(Action))
                        {
                            bEFEM_Doit = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case eHandOver.eEFEM_Done:
                    {
                        if (_DelMXCSetAction(Action))
                        {
                            bEFEM_Done = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case eHandOver.eInLine_IsDoit:
                    {
                        bInLine_IsDoit = true;
                    }
                    break;
                case eHandOver.eInLine_Doit:
                    {
                        bInLine_Doit = true;
                    }
                    break;
                case eHandOver.eInLine_Done:
                    {
                        bInLine_Done = true;
                    }
                    break;
                default:
                    break;
            }

            switch (iStep)
            {
                case 1:
                    {
                        //
                        iStep = 10;
                    }
                    break;
                case 10:
                    {
                        if (bEFEM_IsDoit == true && GetMXC_Bool_Value(eIO_Read))
                        {
                            //
                            iStep = 20;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 20:
                    {
                        if (bInLine_IsDoit == true && GetMXC_Bool_Value(eIO_Read))//開門完成
                        {
                            //
                            iStep = 30;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 30:
                    {
                        if (bEFEM_Doit == true && GetMXC_Bool_Value(eIO_Read))
                        {
                            //
                            iStep = 40;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 40:
                    {
                        if (bInLine_Doit == true && GetMXC_Bool_Value(eIO_Read))
                        {
                            //
                            iStep = 50;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 50:
                    {
                        if (bEFEM_Done == true && GetMXC_Bool_Value(eIO_Read))
                        {
                            //
                            iStep = 60;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 60:
                    {
                        if (bInLine_Done == true && GetMXC_Bool_Value(eIO_Read))
                        {
                            //
                            iStep = 90;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 90:
                    {
                        return true;
                    }
                default:
                    break;
            }
            return false;
        }

        private bool GetMXC_Bool_Value(eMXC_IO_Read Address)
        {
            return DataLayer.b_ay_MXC_IO_Read[(int)Address - (int)eMXC_IO_Read.eInline_CNVI_Ready];
        }

        public bool HandOver(eHandOver eHO)
        {
            //紀錄現在狀態
            eNowHandOver = eHO;

            switch (eHO)
            {
                case eHandOver.eReset:
                    {
                        Reset();
                    }
                    break;
                case eHandOver.eEFEM_IsDoit:
                    {
                        bEFEM_IsDoit = true;
                    }
                    break;
                case eHandOver.eEFEM_Doit:
                    {
                        bEFEM_Doit = true;
                    }
                    break;
                case eHandOver.eEFEM_Done:
                    {
                        bEFEM_Done = true;
                    }
                    break;
                case eHandOver.eInLine_IsDoit:
                    {
                        bInLine_IsDoit = true;
                    }
                    break;
                case eHandOver.eInLine_Doit:
                    {
                        bInLine_Doit = true;
                    }
                    break;
                case eHandOver.eInLine_Done:
                    {
                        bInLine_Done = true;
                    }
                    break;
                default:
                    break;
            }

            switch (iStep)
            {
                case 1:
                    {
                        //
                        iStep = 10;
                    }
                    break;
                case 10:
                    {
                        if (bEFEM_IsDoit == true)
                        {
                            //
                            iStep = 20;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 20:
                    {
                        if (bInLine_IsDoit == true)//開門完成
                        {
                            //
                            iStep = 30;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 30:
                    {
                        if (bEFEM_Doit == true)
                        {
                            //
                            iStep = 40;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 40:
                    {
                        if (bInLine_Doit == true)
                        {
                            //
                            iStep = 50;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 50:
                    {
                        if (bEFEM_Done == true)
                        {
                            //
                            iStep = 60;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 60:
                    {
                        if (bInLine_Done == true)
                        {
                            //
                            iStep = 90;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 90:
                    {
                        return true;
                    }
                default:
                    break;
            }
            return false;
        }









    }

    
     #region MXC UI  //v1.0.0.17 noke
		 
    //noke
    public class HandOverSignal
    {
        public string 流向 { get; set; }
        public Nullable<int> Ready { get; set; }
        public Nullable<int> IsDoit { get; set; }
        public Nullable<int> Doint { get; set; }
        public Nullable<int> Done { get; set; }
        public Nullable<int> Floor1 { get; set; }
        public Nullable<int> Floor2 { get; set; }
        public Nullable<int> Floor3 { get; set; }
        public Nullable<int> Floor4 { get; set; }
        public Nullable<int> Floor5 { get; set; }
        public Nullable<int> Floor6 { get; set; }

        private MXCOM MXC4;
        private int startIndex;
        private bool hasFloors;

        public HandOverSignal(MXCOM MXC4, string name, int startIndex, bool hasFloors = false)
        {
            this.MXC4 = MXC4;
            流向 = name;
            this.startIndex = startIndex;
            this.hasFloors = hasFloors;
        }

        public void Read()
        {
            Ready = GetBValue(startIndex);
            IsDoit = GetBValue(startIndex + 1);
            Doint = GetBValue(startIndex + 2);
            Done = GetBValue(startIndex + 3);
            if (hasFloors)
            {
                Floor1 = GetBValue(startIndex + 4);
                Floor2 = GetBValue(startIndex + 5);
                Floor3 = GetBValue(startIndex + 6);
                Floor4 = GetBValue(startIndex + 7);
                Floor5 = GetBValue(startIndex + 8);
                Floor6 = GetBValue(startIndex + 9);
            }
        }

        private int GetBValue(int inum)
        {
            short oShort;
            int oInt;
            int iRet = MXC4.GetDevice("B", inum, out oShort, out oInt);
            if (iRet == 0)
            {
                return oShort == 1 ? 1 : 0;
            }
            throw new Exception("B讀值發生錯誤");
        }
    }
    //noke 
    public class PanelDataFlow
    {
        public string 名稱 { get; set; }
        public string 生產日期 { get; set; }
        public string 流水號 { get; set; }
        public string 批號 { get; set; }
        public string OP編號 { get; set; }
        public string 所在層數 { get; set; }
        public string PanelID { get; set; }
        public string CarrirID { get; set; }
        public string 客戶名稱 { get; set; }
        public string 手動輸入PanelID { get; set; }
        public string 手動輸入CarrirID { get; set; }
        public string 產品總類 { get; set; }
        public string 入料時間 { get; set; }
        public string 出料時間 { get; set; }
        public string 烤箱破腔時間 { get; set; }
        public string 氮氣櫃破腔時間 { get; set; }
        public string Carrir破腔時間 { get; set; }

        private MXCOM MXC4;
        private int startIndex;

        public PanelDataFlow(MXCOM MXC4, string name, int startIndex)
        {
            this.MXC4 = MXC4;
            名稱 = name;
            this.startIndex = startIndex;
        }

        public void Read()
        {
            生產日期 = GetZRValue(startIndex);
            流水號 = GetZRValue(startIndex + 20);
            批號 = GetZRValue(startIndex + 40);
            OP編號 = GetZRValue(startIndex + 60);
            所在層數 = GetZRValue(startIndex + 80);
            PanelID = GetZRValue(startIndex + 100);
            CarrirID = GetZRValue(startIndex + 120);
            客戶名稱 = GetZRValue(startIndex + 140);
            手動輸入PanelID = GetZRValue(startIndex + 160);
            手動輸入CarrirID = GetZRValue(startIndex + 180);
            產品總類 = GetZRValue(startIndex + 200);
            入料時間 = GetZRValue(startIndex + 220);
            出料時間 = GetZRValue(startIndex + 240);
            烤箱破腔時間 = GetZRValue(startIndex + 260);
            氮氣櫃破腔時間 = GetZRValue(startIndex + 280);
            Carrir破腔時間 = GetZRValue(startIndex + 300);
        }

        private string GetZRValue(int inum)
        {
            string s = "";
            int iRet = MXC4.ReadDeviceBlock2("ZR", inum, 20, ref s);
            if (iRet == 0)
            {
                var stringArray = s.Split('\0');
                var sb = new StringBuilder();
                foreach (var ch in stringArray)
                {
                    sb.Append(ch);
                }
                return sb.ToString();
            }
            throw new Exception("ZR讀值發生錯誤");
        }
    }
    ///end
	#endregion MXC UI

   








    ///end
}
