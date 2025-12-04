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

    public partial class Elevator_ConveyorModule : ElevatorBaseModule
    {
        public Elevator_ConveyorModule(string moduleName, DelShowAlarm ShowAlarm, Elevator_IO_MOTOR Elev_IO_MOTOR, Conveyor_IO_MOTOR[] Conveyor_IO_MOTOR)
            : base(moduleName, ShowAlarm, Elev_IO_MOTOR)
        {
            //建構輸送帶
            Module_Conveyors = new ConveyorBaseModule[Conveyor_IO_MOTOR.Length];
            for (int i = 0; i < Conveyor_IO_MOTOR.Length; i++)
            {
                Module_Conveyors[i] = new ConveyorBaseModule(moduleName, ShowAlarm, Conveyor_IO_MOTOR[i]);
                Module_Conveyors[i].iAlarmCodeShift = (Module_Conveyors[i].GetAlarmCodeEndIndex * i);
            }

            this.iAlarmCodeShift = (Module_Conveyors[0].GetAlarmCodeEndIndex * Conveyor_IO_MOTOR.Length);
        }
        
        #region 參數
        //輸送帶
        [Description("輸送帶工作速度")]
        public int iMotorConveyor_Speed
        {
            get { return Module_Conveyors[0].iMotorConveyor_Speed; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iMotorConveyor_Speed = value;
                }
            }
        }
        [Description("輸送帶工作速度-慢")]
        public int iMotorConveyor_SlowSpeedRate
        {
            get { return Module_Conveyors[0].iMotorConveyor_SlowSpeedRate; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iMotorConveyor_SlowSpeedRate = value;
                }
            }
        }
        [Description("輸送帶工作加速度，最大10")]
        public double dMotorConveyor_ACC_MULTIPLE
        {
            get { return Module_Conveyors[0].dMotorConveyor_ACC_MULTIPLE; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].dMotorConveyor_ACC_MULTIPLE = value;
                }
            }
        }
        [Description("輸送帶工作減速度，最大10")]
        public double dMotorConveyor_DEC_MULTIPLE
        {
            get { return Module_Conveyors[0].dMotorConveyor_DEC_MULTIPLE; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].dMotorConveyor_DEC_MULTIPLE = value;
                }
            }
        }
        [Description("輸送帶進出料距離")]
        public int iTransfer_Distance
        {
            get { return Module_Conveyors[0].iTransfer_Distance; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iTransfer_Distance = value;
                }
            }
        }
        [Description("輸送帶進出料未到位多跑距離")]
        public int iTransferRunMore_Distance
        {
            get { return Module_Conveyors[0].iTransferRunMore_Distance; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iTransferRunMore_Distance = value;
                }
            }
        }
        [Description("預備到料Sensor與到料Sensor距離-前")]
        public int iPreInPos_InPos_Distance_Front
        {
            get { return Module_Conveyors[0].iPreInPos_InPos_Distance_Front; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iPreInPos_InPos_Distance_Front = value;
                }
            }
        }
        [Description("預備到料Sensor與到料Sensor距離-後")]
        public int iPreInPos_InPos_Distance_Back
        {
            get { return Module_Conveyors[0].iPreInPos_InPos_Distance_Back; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iPreInPos_InPos_Distance_Back = value;
                }
            }
        }

         [Description("脫離Sensor距離")]
        public int iLeaveSensor_Distance
        {
            get { return Module_Conveyors[0].iLeaveSensor_Distance; }
            set
            {
                for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].iLeaveSensor_Distance = value;
                }
            }
        }
        
        #endregion 參數

        #region 私有函數
        private ConveyorBaseModule[] Module_Conveyors;

        private void SetSpeed()
        {
        }
        #endregion 私有函數

        #region 公用函數
        public bool ConveyorTaskReset(int index)
        {
            if (index >= Module_Conveyors.Length)
                return false;

            if (bIsSimulation == true)//v1.0.0.13 ted
            {
                 for (int i = 0; i < Module_Conveyors.Length; i++)
                {
                    Module_Conveyors[i].bIsSimulation = true;
                }
            }

            return Module_Conveyors[index - 1].TaskReset();
        }

        public ThreeValued ConveyorMove1(int index, Motor[] MO_Driven_Conveyors, EDirection DIR)
        {
            if (index >= Module_Conveyors.Length)
                return ThreeValued.UNKNOWN;

            return Module_Conveyors[index - 1].ConveyorMove1(MO_Driven_Conveyors, DIR);
        }

        public ThreeValued ConveyorMove2(int index, Motor[] MO_Driven_Conveyors, EDirection DIR)
        {
            if (index >= Module_Conveyors.Length)
                return ThreeValued.UNKNOWN;

            return Module_Conveyors[index - 1].ConveyorMove2(MO_Driven_Conveyors, DIR);
        }
        #endregion 公用函數
    }
}
