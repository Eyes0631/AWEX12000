using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using System.ComponentModel;
using System.Globalization;

namespace CommonObj
{
    public static class FlagDefine
    {
        //SubFlow PTI & PPM用/////////////////////////////////////////////
        [Description("PTI通知PPM取片")]
        public static JActionFlag Flag_SubFlow_PTI_Notiy_PPM_Pick = new JActionFlag();

        //SubFlow PTO & PPM用/////////////////////////////////////////////
        [Description("PTO通知PPM放片")]
        public static JActionFlag Flag_SubFlow_PTO_Notiy_PPM_Place = new JActionFlag();
        //SubFlow Plasma & PPM用/////////////////////////////////////////////
        [Description("Plasma通知PPM放片")]
        public static JActionFlag Flag_SubFlow_Plasma_Notiy_PPM_Place = new JActionFlag();
        [Description("Plasma通知PPM取片")]
        public static JActionFlag Flag_SubFlow_Plasma_Notiy_PPM_Pick = new JActionFlag();

        //SubFlow 全共用///////////////////////////////////////////////////////

        [Description("更新PANEL旗標 ")]
        public static JActionFlag Flag_Update_PanelInfo = new JActionFlag();

        [Description("更新SECS/GEM資訊旗標 ")]
        public static JActionFlag Flag_Update_Info = new JActionFlag();//v1.0.0.11 ted

        //SubFlow PPM用/////////////////////////////////////////////

        [Description("PVD與PVU交握")]
        public static JActionFlag Flag_SubFlow_PVD_HandOver = new JActionFlag();

        /// <summary>
        /// 交握旗標
        /// </summary>
        /// <returns></returns>
        public static JActionFlag Flag_LPA_Notify_WTR_Lock = new JActionFlag();
        public static JActionFlag Flag_LPB_Notify_WTR_Lock = new JActionFlag();
        public static JActionFlag Flag_LPC_Notify_WTR_Lock = new JActionFlag();
        public static JActionFlag Flag_LPD_Notify_WTR_Lock = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPA_CloseDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPB_CloseDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPC_CloseDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPD_CloseDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPA_OpenDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPB_OpenDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPC_OpenDoor = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_LPD_OpenDoor = new JActionFlag();
        public static JActionFlag Flag_LPA_Unload_Done = new JActionFlag();
        public static JActionFlag Flag_LPB_Unload_Done = new JActionFlag();
        public static JActionFlag Flag_LPC_Unload_Done = new JActionFlag();
        public static JActionFlag Flag_LPD_Unload_Done = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_WAS_A_PreAlign = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_WAS_B_PreAlign = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_WAS_A_Align = new JActionFlag();
        public static JActionFlag Flag_WTR_Notify_WAS_B_Align = new JActionFlag();  

        public static JActionFlag Flag_WAS_A_Notify_WOI_OCR = new JActionFlag();
        public static JActionFlag Flag_WAS_B_Notify_WOI_OCR = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_A_LoadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_A_UnloadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_B_LoadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_B_UnloadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_C_LoadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_C_UnloadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_D_LoadGateClose = new JActionFlag();
        public static JActionFlag Flag_Port_NotifyMAA_D_UnloadGateClose = new JActionFlag();
        public static JActionFlag Flag_WTR_A_Action = new JActionFlag();
        public static JActionFlag Flag_WTR_B_Action = new JActionFlag();
        public static void Reset()
        {
            Flag_SubFlow_PTI_Notiy_PPM_Pick.Reset();
            Flag_SubFlow_PTO_Notiy_PPM_Place.Reset();
            Flag_SubFlow_Plasma_Notiy_PPM_Pick.Reset();
            Flag_SubFlow_Plasma_Notiy_PPM_Place.Reset();
            Flag_Update_PanelInfo.Reset();
            Flag_Update_Info.Reset();
            Flag_SubFlow_PVD_HandOver.Reset();
            Flag_LPA_Notify_WTR_Lock.Reset();
            Flag_LPB_Notify_WTR_Lock.Reset();
            Flag_LPC_Notify_WTR_Lock.Reset();
            Flag_LPD_Notify_WTR_Lock.Reset();
            Flag_WTR_Notify_LPA_CloseDoor.Reset();
            Flag_WTR_Notify_LPB_CloseDoor.Reset();
            Flag_WTR_Notify_LPC_CloseDoor.Reset();
            Flag_WTR_Notify_LPD_CloseDoor.Reset();
            Flag_WTR_Notify_LPA_OpenDoor.Reset();
            Flag_WTR_Notify_LPB_OpenDoor.Reset();
            Flag_WTR_Notify_LPC_OpenDoor.Reset();
            Flag_WTR_Notify_LPD_OpenDoor.Reset();
            Flag_LPA_Unload_Done.Reset();
            Flag_LPB_Unload_Done.Reset();
            Flag_LPC_Unload_Done.Reset();
            Flag_LPD_Unload_Done.Reset();
            Flag_WTR_Notify_WAS_A_PreAlign.Reset();
            Flag_WTR_Notify_WAS_B_PreAlign.Reset();
            Flag_WTR_Notify_WAS_A_Align.Reset();
            Flag_WTR_Notify_WAS_B_Align.Reset();
            Flag_WAS_A_Notify_WOI_OCR.Reset();
            Flag_WAS_B_Notify_WOI_OCR.Reset();
            Flag_Port_NotifyMAA_A_LoadGateClose.Reset();
            Flag_Port_NotifyMAA_A_UnloadGateClose.Reset();
            Flag_Port_NotifyMAA_B_LoadGateClose.Reset();
            Flag_Port_NotifyMAA_B_UnloadGateClose.Reset();
            Flag_Port_NotifyMAA_C_LoadGateClose.Reset();
            Flag_Port_NotifyMAA_C_UnloadGateClose.Reset();
            Flag_Port_NotifyMAA_D_LoadGateClose.Reset();
            Flag_Port_NotifyMAA_D_UnloadGateClose.Reset();
            Flag_WTR_A_Action.Reset();
            Flag_WTR_B_Action.Reset();
        }


    }
}
