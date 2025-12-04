using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObj
{
    public enum SECS_Command
    {
        None = 0,
        GetLotInfo = 1,                 //取得批號資訊          Equipment -> HOST
        RecipeDownloadFinish = 2,       //Recipe下載完成        HOST -> Equipment
        RecipeCheck = 3,                //確認Recipe是否正確    Equipment -> HOST
        MID = 4,                        //上傳Wafer資訊         Equipment -> HOST
        RecipeUpload = 5,               //上傳Recipe資訊        Equipment -> HOST
        UnKnow = 999,
    }

    public enum ControlMode
    {
        Local,
        Remote,
    }

    public enum SocketType
    {
        Server,
        Client
    }

    public enum PortMode
    {
        Auto = 0,
        Manual = 1,
    }

    public enum PortCassetteAlive
    {
        HasNoCassette = 0,
        HasCassette,
    }

    public enum MachineState
    {
        INIT,
        IDLE,
        EXECUTING,
        PAUSE,
        NORMAL,
        SETUP,
        PM,
        DOWN,
        CHANGELINE,
    }

    public enum DispatchState
    {
        None = 0,
        WaitCommand = 1,
        WaitWorKDone = 2,
        NoProductionData = 3,
        DummyNotEnough = 4,
    }

    public enum RequestSupplyCarrierData
    {
        None = 0,
        WaitCommand = 1,
        NoWafer = 2,
        OnlyDummy = 3,
    }


    public class MISCParametersData
    {
        //public EWaferSize WaferType;                        //吋別
        public PortMode Port1Mode;                          //Port1模式
        public PortMode Port2Mode;                          //Port2模式
        public PortMode Port3Mode;                          //Port3模式
        public PortCassetteAlive Port1CassetteAlive;        //Port1是否有盒
        public PortCassetteAlive Port2CassetteAlive;        //Port2是否有盒
        public PortCassetteAlive Port3CassetteAlive;        //Port3是否有盒
        public MachineState MachineState_;                  //機台狀態
        public int Port1CassetteWaferQuantity;              //Port1盒內Wafer數量
        public int Port2CassetteWaferQuantity;              //Port2盒內Wafer數量
        public int Port3CassetteWaferQuantity;              //Port3盒內Wafer數量
        public int CurrentEquipmentWaferQuantity;           //機台內 Wafer 數量
        public float ESD;                                     //靜電值 Gary v1.0.2.32
        public int DeTapeCount;                             //撕膜數量 Gary v1.0.2.32

        public void Reset()
        {
            //WaferType = EWaferSize.None;
            Port1Mode = PortMode.Manual;
            Port2Mode = PortMode.Manual;
            Port3Mode = PortMode.Manual;
            Port1CassetteAlive = PortCassetteAlive.HasCassette;
            Port2CassetteAlive = PortCassetteAlive.HasNoCassette;
            Port3CassetteAlive = PortCassetteAlive.HasNoCassette;
            Port1CassetteWaferQuantity = 0;
            Port1CassetteWaferQuantity = 0;
            Port1CassetteWaferQuantity = 0;
            MachineState_ = MachineState.INIT;
            CurrentEquipmentWaferQuantity = 0;
            ESD = 0;
            DeTapeCount = 0;
        }
    }

    public enum GetLotInfoNG_Define
    {
        NG_RunCard,
        NG_OPID,
        NG_CstNo,
    }

    public enum MID_NG_Define
    {
        NG_RepeatMapping,    //重複轉檔
        NG_FrameID_Error,    //Frame ID格式錯誤
        NG_WaferID_Error,    //Wafer ID比對錯誤
        NG_MapNotFound,      //圖檔不存在
    }


}
