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
    /*
     * Alarm定義
     * 
     * 1 光閘上偵測，Z軸禁止移動
     * 2 光閘下偵測，Z軸禁止移動
     * 3 光閘前偵測，Z軸禁止移動
     * 4 光閘後偵測，Z軸禁止移動
     * 5 光閘左偵測，Z軸禁止移動
     * 6 光閘右偵測，Z軸禁止移動
     * 7 斷頭前偵測，Z軸禁止移動
     * 8 斷頭後偵測，Z軸禁止移動
     * 9 斷頭左偵測，Z軸禁止移動
     * 10 斷頭右偵測，Z軸禁止移動
     * 11 Z軸移動逾時
    */

    public class Elevator_IO_MOTOR
    {
        [Description("上方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Up = null;
        [Description("下方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Down = null;
        [Description("前方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Front = null;
        [Description("後方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Back = null;
        [Description("右方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Right = null;
        [Description("左方光閘，B接點")]
        public DigitalInput DI_LightCurtain_Left = null;
        [Description("前方斷頭，B接點")]
        public DigitalInput DI_ObstacleDetection_Front = null;
        [Description("後方斷頭，B接點")]
        public DigitalInput DI_ObstacleDetection_Back = null;
        [Description("左方斷頭，B接點")]
        public DigitalInput DI_ObstacleDetection_Left = null;
        [Description("右方斷頭，B接點")]
        public DigitalInput DI_ObstacleDetection_Right = null;
        [Description("Z軸箝制器，B接點，On:釋放、Off:夾持")]
        public OutBit Ob_MotorZ_Clamp = null;
        
        [Description("Z軸馬達")]
        public Motor MO_AxisZ = null;
    }

    public partial class ElevatorBaseModule : BaseModule
    {
        public ElevatorBaseModule(string moduleName, DelShowAlarm ShowAlarm, Elevator_IO_MOTOR MyIO_MOTOR)
            : base(ShowAlarm)
        {
            MyModuleName = moduleName;
            IO_MOTOR = MyIO_MOTOR;
            DI_LightCurtains = new DigitalInput[6];
            DI_LightCurtains[0] = IO_MOTOR.DI_LightCurtain_Up;
            DI_LightCurtains[1] = IO_MOTOR.DI_LightCurtain_Down;
            DI_LightCurtains[2] = IO_MOTOR.DI_LightCurtain_Front;
            DI_LightCurtains[3] = IO_MOTOR.DI_LightCurtain_Back;
            DI_LightCurtains[4] = IO_MOTOR.DI_LightCurtain_Left;
            DI_LightCurtains[5] = IO_MOTOR.DI_LightCurtain_Right;

            DI_ObstacleDetections = new DigitalInput[4];
            DI_ObstacleDetections[0] = IO_MOTOR.DI_ObstacleDetection_Front;
            DI_ObstacleDetections[1] = IO_MOTOR.DI_ObstacleDetection_Back;
            DI_ObstacleDetections[2] = IO_MOTOR.DI_ObstacleDetection_Left;
            DI_ObstacleDetections[3] = IO_MOTOR.DI_ObstacleDetection_Right;

            IO_MOTOR.MO_AxisZ.IsSafeToRun += MO_AxisZ_IsSafeToRun;
        }

        public enum MyClinder
        {
        }
        /*
        * Alarm定義
        * 
        * 1 光閘上偵測，Z軸禁止移動
        * 2 光閘下偵測，Z軸禁止移動
        * 3 光閘前偵測，Z軸禁止移動
        * 4 光閘後偵測，Z軸禁止移動
        * 5 光閘左偵測，Z軸禁止移動
        * 6 光閘右偵測，Z軸禁止移動
        * 7 斷頭前偵測，Z軸禁止移動
        * 8 斷頭後偵測，Z軸禁止移動
        * 9 斷頭左偵測，Z軸禁止移動
        * 10 斷頭右偵測，Z軸禁止移動
        * 11 Z軸移動逾時
        */
        public enum AlarmCode
        {
            Shutter_Up_Alarm = 1,
            Shutter_Down_Alarm = 2,
            Shutter_Front_Alarm = 3,
            Shutter_Back_Alarm = 4,
            Shutter_Left_Alarm = 5,
            Shutter_Right_Alarm = 6,
            Protrusion_Front = 7,
            Protrusion_Back = 8,
            Protrusion_Left = 9,
            Protrusion_Right = 10,
            AxisZ_ActionTimeout = 11,
            End,//放最後
        }
        #region 參數

        [Description("台車Pitch")]
        public int iPitch = 0;
        [Description("第一層點位")]
        public int iFristLayerPos = 0;
        [Description("出料Offset")]
        public int iOutputOffset = 0;
        [Description("入料Offset")]
        public int iInputOffset = 0;
        [Description("Z軸工作速度")]
        public int iMotorZ_Speed = 0;
        [Description("Z軸工作加速度，最大10")]
        public int iMotorZ_ACC_MULTIPLE = 0;
        [Description("Z軸工作減速度，最大10")]
        public int iMotorZ_DEC_MULTIPLE = 0;

        #endregion 參數

        #region 私有函數
        protected Elevator_IO_MOTOR IO_MOTOR;
        private DigitalInput[] DI_LightCurtains;
        private DigitalInput[] DI_ObstacleDetections;
        #endregion 私有函數

        #region 公用函數
        public bool MO_AxisZ_IsSafeToRun()
        {
            if (IO_MOTOR.MO_AxisZ == null)
            {
                return true;
            }

            for (int i = 0; i < DI_LightCurtains.Length; i++)
            {
                if (DI_LightCurtains[i] != null)
                {
                    if (DI_LightCurtains[i].ValueOff)
                    {
                        IO_MOTOR.MO_AxisZ.FastStop();
                        ShowAlarm("E", i + 1);
                        return false;
                    }
                }
            }

            for (int i = 0; i < DI_ObstacleDetections.Length; i++)
            {
                if (DI_LightCurtains[i] != null)
                {
                    if (DI_LightCurtains[i].ValueOff)
                    {
                        IO_MOTOR.MO_AxisZ.FastStop();
                        ShowAlarm("E", i + 1 + 6);
                        return false;
                    }
                }
            }
            return true;
        }

        public int GetAlarmCodeEndIndex
        {
            get { return (int)AlarmCode.End - 1; }
        }
        #endregion 公用函數
    }
}
