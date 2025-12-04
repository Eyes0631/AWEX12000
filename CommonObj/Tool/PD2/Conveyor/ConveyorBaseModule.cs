using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using PaeLibProVSDKEx;
using ProVLib;
using System.Windows.Forms;
using System.ComponentModel;

namespace PD2_SDK
{
    public class Conveyor_IO_MOTOR
    {
        public DigitalInput DI_ObstacleDetection_Right = null;
        [Description("板到位偵測-前")]
        public DigitalInput DI_Board_InPos_Front = null;
        [Description("板到位偵測2-前")]
        public DigitalInput DI_Board_InPos_Front_2 = null;
        [Description("板到位偵測-後")]
        public DigitalInput DI_Board_InPos_Back = null;
        [Description("板到位偵測2-後")]
        public DigitalInput DI_Board_InPos_Back_2 = null;
        [Description("板預備到位偵測-前")]
        public DigitalInput DI_Board_PreInPos_Front = null;
        [Description("板預備到位偵測-後")]
        public DigitalInput DI_Board_PreInPos_Back = null;

        [Description("止擋氣缸-前")]
        public Cylinder CY_Stopper_Front = null;
        [Description("止擋氣缸-後")]
        public Cylinder CY_Stopper_Back = null;
        [Description("止擋氣缸2-前")]
        public Cylinder CY_Stopper_Front_2 = null;
        [Description("止擋氣缸2-後")]
        public Cylinder CY_Stopper_Back_2 = null;


        [Description("輸送帶馬達")]
        public Motor MO_Conveyor = null;
        [Description("U軸馬達")]
        public Motor MO_AxisU = null;
    }

    public class Driven_IO_MOTOR//跨模組溝通用
    {
        [Description("輸送帶馬達")]
        public Motor MO_Conveyor;
        [Description("板到位偵測")]
        public DigitalInput DI_Board_InPos = null;
        [Description("板預備到位偵測")]
        public DigitalInput DI_Board_PreInPos = null;
    }

    public partial class ConveyorBaseModule : BaseModule
    {
        public ConveyorBaseModule(string moduleName, DelShowAlarm ShowAlarm, Conveyor_IO_MOTOR MyIO_MOTOR)
            : base(ShowAlarm)
        {
            IO_MOTOR = MyIO_MOTOR;

            IO_MOTOR.MO_Conveyor.IsSafeToRun += MO_Conveyor_IsSafeToRun;
        }

        public enum MyClinder
        {
            Stopper_Front,
            Stopper_Front_2,
            Stopper_Back,
            Stopper_Back_2,
        }

        public enum PosSensor
        {
            PreInPos,
            InPos,
            InPos_Single,
        }
        /*
        * Alarm定義
        * 
        * 1    止擋氣缸-前 動作逾時
        * 2    止擋氣缸-後 動作逾時
        * 3    止擋氣缸2-前 動作逾時
        * 4    止擋氣缸2-後 動作逾時
        * 5    Panel傳送逾時
        * 
        * 
        * 
        * 
        */
        public enum AlarmCode
        {
            Stopper_Front_ActionTimeout = 1,
            Stopper_Back_ActionTimeout = 2,
            Stopper_Front_2_ActionTimeout = 3,
            Stopper_Back_2_ActionTimeout = 4,
            PanelTransfer_Timeout = 5,
            End,//放最後
        }

        #region 參數

        [Description("輸送帶工作速度")]
        public int iMotorConveyor_Speed = 0;
        [Description("輸送帶工作速度-慢")]
        public int iMotorConveyor_SlowSpeedRate = 0;
        [Description("輸送帶工作加速度，最大10")]
        public double dMotorConveyor_ACC_MULTIPLE = 0;
        [Description("輸送帶工作減速度，最大10")]
        public double dMotorConveyor_DEC_MULTIPLE = 0;

        [Description("U軸工作速度")]
        public int iMotorU_Speed = 0;
        [Description("U軸工作加速度，最大10")]
        public int iMotorU_ACC_MULTIPLE = 0;
        [Description("U軸工作減速度，最大10")]
        public int iMotorU_DEC_MULTIPLE = 0;

        [Description("輸送帶進出料距離")]
        public int iTransfer_Distance = 0;
        [Description("輸送帶進出料未到位多跑距離")]
        public int iTransferRunMore_Distance = 0;
        [Description("預備到料Sensor與到料Sensor距離-前")]
        public int iPreInPos_InPos_Distance_Front = 0;
        [Description("預備到料Sensor與到料Sensor距離-後")]
        public int iPreInPos_InPos_Distance_Back = 0;
        [Description("脫離Sensor距離")]
        public int iLeaveSensor_Distance = 0;

        #endregion 參數

        #region 私有函數

        private Conveyor_IO_MOTOR IO_MOTOR;

        #endregion 私有函數

        #region 公用函數
        public bool MO_Conveyor_IsSafeToRun()
        {
            if (IO_MOTOR.MO_Conveyor == null)
            {
                return true;
            }
            return true;
        }

        public bool MO_AxisU_IsSafeToRun()
        {
            if (IO_MOTOR.MO_AxisU == null)
            {
                return true;
            }
            return true;
        }

        public int GetAlarmCodeEndIndex
        {
            get { return (int)AlarmCode.End; }
        }

        #endregion 公用函數
    }
}
