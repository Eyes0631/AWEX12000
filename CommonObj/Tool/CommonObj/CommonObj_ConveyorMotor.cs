using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ProVLib;
using System.ComponentModel;
using PaeLibGeneral;

namespace CommonObj
{
    public static class CConveyorMotor
    {
        [Description("暫存儲存槽馬達1")]
        public static Motor MotorNBM_1 = new Motor();
        [Description("暫存儲存槽馬達2")]
        public static Motor MotorNBM_2 = new Motor();
        [Description("暫存儲存槽馬達3")]
        public static Motor MotorNBM_3 = new Motor();
        [Description("暫存儲存槽馬達4")]
        public static Motor MotorNBM_4 = new Motor();
        [Description("暫存儲存槽馬達5")]
        public static Motor MotorNBM_5 = new Motor();
        [Description("暫存儲存槽馬達6")]
        public static Motor MotorNBM_6 = new Motor();
        [Description("暫存儲存槽馬達7")]
        public static Motor MotorNBM_7 = new Motor();
        [Description("暫存儲存槽馬達8")]
        public static Motor MotorNBM_8 = new Motor();

        [Description("後中繼站馬達_中間")]
        public static Motor MotorPTMB_M = new Motor();
        [Description("後中繼站馬達_左邊")]
        public static Motor MotorPTMB_L = new Motor();
        [Description("後中繼站馬達_右邊")]
        public static Motor MotorPTMB_R = new Motor();
        [Description("後中繼站馬達_下方")]
        public static Motor MotorPTMB_B = new Motor();

        [Description("前中繼站馬達_中間")]
        public static Motor MotorPTMF_M = new Motor();
        [Description("前中繼站馬達_左邊")]
        public static Motor MotorPTMF_L = new Motor();
        [Description("前中繼站馬達_右邊")]
        public static Motor MotorPTMF_R = new Motor();

        [Description("手臂站馬達_前驅動")]
        public static Motor MotorPPM_F = new Motor();
        [Description("手臂站馬達_後驅動")]
        public static Motor MotorPPM_B = new Motor();

        [Description("NG站馬達")]
        public static Motor MotorNGM = new Motor();

        [Description("PVD_Loader馬達")]
        public static Motor MotorPVL = new Motor();



        //end
    }
}
