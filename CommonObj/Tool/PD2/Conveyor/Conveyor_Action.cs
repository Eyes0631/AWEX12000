using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using CommonObj;
using PaeLibProVSDKEx;
using ProVLib;

namespace PD2_SDK
{
    public partial class ConveyorBaseModule
    {
        /// <summary>
        /// 設定工作速度
        /// </summary>
        public virtual void SetSpeed()
        {
            if (IO_MOTOR.MO_Conveyor != null)
            {
                if (dMotorConveyor_ACC_MULTIPLE > 10 || dMotorConveyor_ACC_MULTIPLE < 0)
                {
                    dMotorConveyor_ACC_MULTIPLE = 1;
                }
                if (dMotorConveyor_DEC_MULTIPLE > 10 || dMotorConveyor_DEC_MULTIPLE < 0)
                {
                    dMotorConveyor_DEC_MULTIPLE = 1;
                }
                IO_MOTOR.MO_Conveyor.SetSpeed(iMotorConveyor_Speed);
                IO_MOTOR.MO_Conveyor.SetAcceleration((int)(iMotorConveyor_Speed * dMotorConveyor_ACC_MULTIPLE));
                IO_MOTOR.MO_Conveyor.SetDeceleration((int)(iMotorConveyor_Speed * dMotorConveyor_DEC_MULTIPLE));
            }

            if (IO_MOTOR.MO_AxisU != null)
            {
                if (iMotorU_ACC_MULTIPLE > 10 || iMotorU_ACC_MULTIPLE < 0)
                {
                    iMotorU_ACC_MULTIPLE = 1;
                }
                if (iMotorU_DEC_MULTIPLE > 10 || iMotorU_DEC_MULTIPLE < 0)
                {
                    iMotorU_DEC_MULTIPLE = 1;
                }
                IO_MOTOR.MO_AxisU.SetSpeed(iMotorU_Speed);
                IO_MOTOR.MO_AxisU.SetAcceleration(iMotorU_Speed * iMotorU_ACC_MULTIPLE);
                IO_MOTOR.MO_AxisU.SetDeceleration(iMotorU_Speed * iMotorU_DEC_MULTIPLE);
            }
        }
        /// <summary>
        /// 設定慢速
        /// </summary>
        public virtual void SetSlowSpeed(Motor[] MO_Driven_Conveyors)
        {
            if (IO_MOTOR.MO_Conveyor != null)
            {
                if (dMotorConveyor_ACC_MULTIPLE > 10 || dMotorConveyor_ACC_MULTIPLE < 0)
                {
                    dMotorConveyor_ACC_MULTIPLE = 1;
                }
                if (dMotorConveyor_DEC_MULTIPLE > 10 || dMotorConveyor_DEC_MULTIPLE < 0)
                {
                    dMotorConveyor_DEC_MULTIPLE = 1;
                }
                //IO_MOTOR.MO_Conveyor.SpeedOverride(MO_Driven_Conveyors, (int)(iMotorConveyor_Speed * (iMotorConveyor_SlowSpeedRate / 100.0)));
                IO_MOTOR.MO_Conveyor.SetSpeed((int)(iMotorConveyor_Speed));
                IO_MOTOR.MO_Conveyor.SetAcceleration((int)(iMotorConveyor_Speed * (iMotorConveyor_SlowSpeedRate / 100.0) * dMotorConveyor_ACC_MULTIPLE));
                IO_MOTOR.MO_Conveyor.SetDeceleration((int)(iMotorConveyor_Speed * (iMotorConveyor_SlowSpeedRate / 100.0) * dMotorConveyor_DEC_MULTIPLE));
            }
        }

        public virtual bool ConveyorsG01(Motor[] MO_Driven_Conveyors, EDirection DIR, int Dis)
        {
            if (bIsSimulation == true)//v1.0.0.7 ted
            {
                return true;
            }

            //G01(Motor[] Motors, int[] Positions); Positions長度比Motors多1，因為要包含自己，Positions[0]是主軸的     
            if (MO_Driven_Conveyors == null || MO_Driven_Conveyors.Length <= 0)//當MO_Driven_Conveyors沒有值時使用G00，防止例外
            {
                return ConveyorG00(DIR, Dis);
            }
            else
            {
                int[] ipos = new int[MO_Driven_Conveyors.Length + 1];
                for (int i = 0; i < MO_Driven_Conveyors.Length + 1; i++)
                {
                    ipos[i] = (DIR == EDirection.Forward) ? Dis : -Dis;
                }

                return IO_MOTOR.MO_Conveyor.G01(MO_Driven_Conveyors, ipos);
            }
        }

        public virtual bool ConveyorG00(EDirection DIR, int Dis)
        {
            int ipos = (DIR == EDirection.Forward) ? Dis : -Dis;
            return IO_MOTOR.MO_Conveyor.G00(ipos);
        }

        public virtual bool ResetConveyorsPos(Motor[] MO_Driven_Conveyors)
        {
            IO_MOTOR.MO_Conveyor.SetPos(0);
            IO_MOTOR.MO_Conveyor.SetEncoderPos(0);

            if (MO_Driven_Conveyors != null)
            {
                for (int i = 0; i < MO_Driven_Conveyors.Length; i++)
                {
                    MO_Driven_Conveyors[i].SetPos(0);
                    MO_Driven_Conveyors[i].SetEncoderPos(0);
                }
            }
            return true;
        }

        public virtual bool ConveyorsStop(Motor[] MO_Driven_Conveyors)
        {
            IO_MOTOR.MO_Conveyor.Stop();

            if (MO_Driven_Conveyors != null)
            {
                for (int i = 0; i < MO_Driven_Conveyors.Length; i++)
                {
                    MO_Driven_Conveyors[i].Stop();
                }
            }
            return true;
        }

        /// <summary>
        /// 讓Conveyor持續移動
        /// </summary>
        /// <param name="DIR"></param>
        public virtual void ConveyorKeepMoving(EDirection DIR)
        {
            if (DIR == EDirection.Forward)
                IO_MOTOR.MO_Conveyor.JogN();
            else
                IO_MOTOR.MO_Conveyor.JogP();
        }


        /// <summary>
        /// 偵測有無料
        /// </summary>
        /// <param name="PS"></param>
        /// <param name="DIR"></param>
        /// <param name="bHasProduct">true:真測有料、false:偵測無料</param>
        /// <returns></returns>
        public virtual ThreeValued DetectPosSensor(PosSensor PS, EDirection DIR, bool bHasProduct = true)
        {
            DigitalInput[] di_Sensors = GetSensorByPosition(PS, DIR);
            if (di_Sensors == null)
                return ThreeValued.TRUE;

            ThreeValued[] t_result = new ThreeValued[di_Sensors.Length];

            if (bHasProduct == true)
            {
                for (int i = 0; i < di_Sensors.Length; i++)//v1.0.0.13 ted
                {
                    if (di_Sensors[i] == null)
                    {
                        t_result[i] = ThreeValued.TRUE;
                    }
                    else
                    {
                        t_result[i] = di_Sensors[i].On(iSensor_DelayTime, iSensor_Timeout);
                    }
                }
            }
            else
            {
                for (int i = 0; i < di_Sensors.Length; i++)//v1.0.0.13 ted
                {
                    if (di_Sensors[i] == null)
                    {
                        t_result[i] = ThreeValued.TRUE;
                    }
                    else
                    {
                        t_result[i] = di_Sensors[i].Off(iSensor_DelayTime, iSensor_Timeout);
                    }
                }
            }

            if (t_result.All(x => x == ThreeValued.TRUE))
            {
                return ThreeValued.TRUE;
            }

            if (t_result.Contains(ThreeValued.FALSE))
            {
                return ThreeValued.FALSE;
            }

            return ThreeValued.UNKNOWN;
        }
        //
        private DigitalInput[] GetSensorByPosition(PosSensor ps, EDirection dir)//Ted
        {
            switch (ps)
            {
                case PosSensor.PreInPos:
                    {
                        return dir == EDirection.Forward
                                    ? new DigitalInput[1] { IO_MOTOR.DI_Board_PreInPos_Front }
                                    : new DigitalInput[1] { IO_MOTOR.DI_Board_PreInPos_Back };

                    }
                case PosSensor.InPos:
                    {
                        return dir == EDirection.Forward
                                    ? new DigitalInput[2] { IO_MOTOR.DI_Board_InPos_Front, IO_MOTOR.DI_Board_InPos_Front_2 }
                                    : new DigitalInput[2] { IO_MOTOR.DI_Board_InPos_Back, IO_MOTOR.DI_Board_InPos_Back_2 };
                    }
                case PosSensor.InPos_Single:
                    {
                        return dir == EDirection.Backward
                                    ? new DigitalInput[1] { IO_MOTOR.DI_Board_InPos_Front }
                                    : new DigitalInput[1] { IO_MOTOR.DI_Board_InPos_Back };
                    }
                default:
                    return null;
            }
        }
        /// <summary>
        /// 控制氣缸
        /// </summary>
        /// <param name="CY"></param>
        /// <param name="eAction"></param>
        /// <returns></returns>
        private ThreeValued Cylinder_Ctrl(MyClinder CY, ECylinderAction eAction)
        {
            if (bIsSimulation)
            {
                return ThreeValued.TRUE;
            }

            Cylinder Cy = null;
            switch (CY)
            {
                case MyClinder.Stopper_Front:
                    Cy = IO_MOTOR.CY_Stopper_Front;
                    break;
                case MyClinder.Stopper_Front_2:
                    Cy = IO_MOTOR.CY_Stopper_Front_2; ;
                    break;
                case MyClinder.Stopper_Back:
                    Cy = IO_MOTOR.CY_Stopper_Back; ;
                    break;
                case MyClinder.Stopper_Back_2:
                    Cy = IO_MOTOR.CY_Stopper_Back_2; ;
                    break;
                default:
                    Cy = null;
                    break;
            }

            int DelayTime = 0;
            int Timeout = 0;

            DelayTime = iCylinder_DelayTime;
            Timeout = iCylinder_Timeout;

            ThreeValued rt = ThreeValued.UNKNOWN;
            switch (eAction)
            {
                case ECylinderAction.Close:
                    rt = Cy.Off(DelayTime, Timeout);
                    break;
                case ECylinderAction.Open:
                    rt = Cy.On(DelayTime, Timeout);
                    break;
                default:
                    break;
            }

            if (rt == ThreeValued.FALSE)
            {
                string sSwitch = ""; ;
                switch (CY)
                {
                    case MyClinder.Stopper_Front:
                        sSwitch = eAction == ECylinderAction.Open ? "Up" : "Down";
                        ShowAlarm("E", (int)AlarmCode.Stopper_Front_ActionTimeout);
                        break;
                    case MyClinder.Stopper_Front_2:
                        sSwitch = eAction == ECylinderAction.Open ? "Up" : "Down";
                        ShowAlarm("E", (int)AlarmCode.Stopper_Front_2_ActionTimeout);
                        break;
                    case MyClinder.Stopper_Back:
                        sSwitch = eAction == ECylinderAction.Open ? "Front" : "Back";
                        ShowAlarm("E", (int)AlarmCode.Stopper_Back_ActionTimeout);
                        break;
                    case MyClinder.Stopper_Back_2:
                        sSwitch = eAction == ECylinderAction.Open ? "Up" : "Down";
                        ShowAlarm("E", (int)AlarmCode.Stopper_Back_2_ActionTimeout);
                        break;
                    default:
                        break;
                }
            }
            return rt;
        }
        /// <summary>
        /// Switch更新
        /// </summary>
        /// <returns></returns>
        public bool TaskReset()
        {
            AutoTask.Reset();
            RunTM.Restart();
            return true;
        }
        /// <summary>
        /// 從另外一個Conveyor接收，一邊到位Sensor遮到就算到位，多顆同動
        /// </summary>
        /// <param name="MO_Driven_Conveyors"></param>
        /// <param name="DIR"></param>
        /// <param name="Driven_DIR"></param>
        /// <returns></returns>
        public virtual ThreeValued ConveyorMove1(Motor[] MO_Driven_Conveyors, EDirection DIR)
        {
            string ActionNmae = "ConveyorMove1-";
            int[] ipos = new int[MO_Driven_Conveyors.Length + 1];
            switch (AutoTask.Value)
            {
                case 0:
                    {//Reset
                        ResetConveyorsPos(MO_Driven_Conveyors);
                        SetSpeed();
                        RunTM.Restart();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "Reset");
                    }
                    break;
                case 10:
                    {//傳輸
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        ThreeValued tv = DetectPosSensor(PosSensor.PreInPos, DIR, true);
                        if (bDryRun && RunTM.On(5000))
                        {
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "DryRun");
                        }

                        if (tv == ThreeValued.TRUE)
                        {//預到位Sensor
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "PreInPos On");
                        }

                        if (b1)
                        {//走完還沒碰到
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳輸");
                        }
                    }
                    break;
                case 20:
                    {//設定減速
                        SetSlowSpeed(MO_Driven_Conveyors);
                        RunTM.Restart();
                        AutoTask.Next(30);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "設定減速");
                    }
                    break;
                case 30:
                    {//到位
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        if (b1 && bDryRun)
                        {
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "bDryRun");
                        }

                        ThreeValued tv = DetectPosSensor(PosSensor.InPos, DIR, true);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos On");
                        }

                        if (b1)
                        {
                            RunTM.Restart();
                            AutoTask.Next(40);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "未到位");
                        }
                    }
                    break;
                case 40:
                    {//多跑
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        int iDis = iTransfer_Distance + iTransferRunMore_Distance;
                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iDis);

                        ThreeValued tv = DetectPosSensor(PosSensor.InPos, DIR, true);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos On");
                        }

                        if (b1 && tv == ThreeValued.FALSE)
                        {
                            ShowAlarm("E", (int)AlarmCode.PanelTransfer_Timeout);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳送逾時");
                            return ThreeValued.FALSE;
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
                    break;
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// 從另外一個Conveyor接收，入料側Sensor先偵測有料，再偵測無料，兩側都要滅掉才算到位，多顆同動
        /// </summary>
        /// <param name="MO_Driven_Conveyors"></param>
        /// <param name="DIR"></param>
        /// <param name="Driven_DIR"></param>
        /// <returns></returns>
        public virtual ThreeValued ConveyorMove2(Motor[] MO_Driven_Conveyors, EDirection DIR)
        {
            string ActionNmae = "ConveyorMove2-";
            //int[] ipos = new int[MO_Driven_Conveyors.Length + 1];
            switch (AutoTask.Value)
            {
                case 0:
                    {//Reset
                        ResetConveyorsPos(MO_Driven_Conveyors);
                        SetSpeed();
                        RunTM.Restart();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "Reset");
                    }
                    break;
                case 10:
                    {//傳輸 先遮到入料側Senser
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            return ThreeValued.TRUE;//v1.0.0.7 ted
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        if (bDryRun)//Gary 20250901
                        {
                            if (b1)
                            {
                                RunTM.Restart();
                                AutoTask.Next(20);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "DryRun");
                                break;
                            }
                            else
                            {
                                return ThreeValued.UNKNOWN;
                            }
                        }


                        EDirection dir = (DIR == EDirection.Forward) ? EDirection.Backward : EDirection.Forward;//要相反
                        ThreeValued tv = DetectPosSensor(PosSensor.InPos, dir, true);
                        if (tv == ThreeValued.TRUE)// || bDryRun)
                        {//入料側到位Sensor
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "入料側Senser 偵測有料");
                        }

                        if (b1)
                        {//走完還沒碰到
                            RunTM.Restart();
                            ShowAlarm("E", (int)AlarmCode.PanelTransfer_Timeout);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳送逾時");
                            ResetConveyorsPos(MO_Driven_Conveyors);
                            return ThreeValued.FALSE;
                        }
                    }
                    break;
                case 20:
                    {//傳輸
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            return ThreeValued.TRUE;//v1.0.0.7 ted
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        if (bDryRun)//Gary 20250901
                        {
                            if (b1)
                            {
                                RunTM.Restart();
                                AutoTask.Next(30);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "DryRun");
                                break;
                            }
                            else
                            {
                                return ThreeValued.UNKNOWN;
                            }
                        }
                  
                        ThreeValued tv = DetectPosSensor(PosSensor.PreInPos, DIR, true);
      
                        if (tv == ThreeValued.TRUE)
                        {//預到位Sensor
                            RunTM.Restart();
                            AutoTask.Next(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "預到位Sensor 偵測有料");
                        }

                        if (b1)
                        {//走完還沒碰到
                            RunTM.Restart();
                            AutoTask.Next(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳輸");
                        }
                    }
                    break;
                case 30:
                    {//設定減速
                        SetSlowSpeed(MO_Driven_Conveyors);
                        RunTM.Restart();
                        AutoTask.Next(40);//v1.0.0.7 ted
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "設定減速");
                    }
                    break;
                case 40:
                    {//入料側Senser 偵測無料
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            return ThreeValued.TRUE;//v1.0.0.7 ted
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        EDirection dir = (DIR == EDirection.Forward) ? EDirection.Backward : EDirection.Forward;//要相反
                        ThreeValued tv = DetectPosSensor(PosSensor.InPos, dir, false);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(60);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "入料側Senser 偵測無料");
                            break;
                        }

                        if (b1)
                        {
                            RunTM.Restart();
                            AutoTask.Next(50);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "未到位");
                        }
                    }
                    break;
                case 50:
                    {//多跑
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(60);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            return ThreeValued.TRUE;//v1.0.0.7 ted
                        }

                        int iDis = iTransfer_Distance + iTransferRunMore_Distance;
                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iDis);

                        EDirection dir = (DIR == EDirection.Forward) ? EDirection.Backward : EDirection.Forward;//要相反
                        ThreeValued tv = DetectPosSensor(PosSensor.InPos, dir, false);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(60);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "入料側Senser 偵測無料");
                            break;
                        }

                        if (b1 && tv == ThreeValued.FALSE)
                        {
                            ShowAlarm("E", (int)AlarmCode.PanelTransfer_Timeout);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳送逾時");
                            return ThreeValued.FALSE;
                        }
                    }
                    break;
                case 60:
                    {//兩邊到位Sensor 偵測無料
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            return ThreeValued.TRUE;//v1.0.0.7 ted
                        }

                        EDirection dir = (DIR == EDirection.Forward) ? EDirection.Backward : EDirection.Forward;//要相反
                        ThreeValued[] tv = new ThreeValued[2];
                        tv[0] = DetectPosSensor(PosSensor.InPos, dir, false);
                        tv[1] = DetectPosSensor(PosSensor.InPos, DIR, false);
                        if (tv.All(x => x == ThreeValued.TRUE))
                        {
                            ConveyorsStop(MO_Driven_Conveyors);
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "脫離Sensor");
                            break;
                        }

                        if (tv.Contains(ThreeValued.FALSE))
                        {
                            ShowAlarm("E", (int)AlarmCode.PanelTransfer_Timeout);
                            RunTM.Restart();
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "未到位");
                            return ThreeValued.FALSE;
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
                    break;
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// PPM專用
        /// </summary>
        /// <param name="MO_Driven_Conveyors"></param>
        /// <param name="DIR"></param>
        /// <returns></returns>
        public virtual ThreeValued ConveyorMove3(Motor[] MO_Driven_Conveyors, EDirection DIR)
        {
            if (DIR == EDirection.Forward)//v1.0.0.20.ted inverse
            {
                DIR = EDirection.Backward;
            }
            else
            {
                DIR = EDirection.Forward;
            }

            string ActionNmae = "ConveyorMove3-";
            int[] ipos = new int[MO_Driven_Conveyors.Length + 1];
            switch (AutoTask.Value)
            {
                case 0:
                    {//Reset
                        ResetConveyorsPos(MO_Driven_Conveyors);
                        SetSpeed();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "Reset");
                    }
                    break;
                case 10:
                    {//傳輸 先遮到入料側Senser
                        if (bIsSimulation)
                        {
                            AutoTask.Next(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            break;
                        }

                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iTransfer_Distance);

                        ThreeValued tv = DetectPosSensor(PosSensor.PreInPos, DIR, true);//PPM不用相反//v1.0.0.21 ted
                        if (tv == ThreeValued.TRUE )
                        {//入料側到位Sensor
                            if (bDryRun)
                            {
                                if (b1 == true)
                                {
                                    AutoTask.Next(30);
                                    LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos_Single On"); 
                                }
                                else
                                {
                                    break;
                                }                                 
                            }
                            else
                            {
                                AutoTask.Next(30);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos_Single On");
                            }
                        }

                        if (b1)
                        {//走完還沒碰到
                            AutoTask.Next(0);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "PreInPos On");
                        }
                    }
                    break;
                case 30:
                    {//設定減速
                        SetSlowSpeed(MO_Driven_Conveyors);
                        AutoTask.Next(40);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "設定減速");
                    }
                    break;
                case 40:
                    {//多跑&到位偵測
                        if (bIsSimulation)
                        {
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                            break;
                        }

                        int iDis = iTransfer_Distance + iTransferRunMore_Distance;
                        bool b1 = ConveyorsG01(MO_Driven_Conveyors, DIR, iDis);//多跑

                        ThreeValued tv = DetectPosSensor(PosSensor.PreInPos, DIR, false);//PPM不用相反//v1.0.0.21 ted
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            ConveyorsStop(MO_Driven_Conveyors);
                            AutoTask.Next(999);//v1.0.0.20.ted
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos_Single On");
                        }

                        if (b1)
                        {
                            ResetConveyorsPos(MO_Driven_Conveyors);
                            AutoTask.Jump(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "未到位");
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// 控制止擋氣缸
        /// <summary>
        /// <param name="DIR"></param>
        /// <param name="ACT"></param>
        /// <returns></returns>
        public virtual ThreeValued DoControlStopper(EDirection DIR, ECylinderAction ACT)
        {
            string ActionNmae = "DoControlStopper-";
            int ipos = 0;
            switch (AutoTask.Value)
            {
                case 0:
                    {//止擋控制
                        ThreeValued[] rt = new ThreeValued[2] { ThreeValued.UNKNOWN, ThreeValued.UNKNOWN };
                        switch (DIR)
                        {
                            case EDirection.Forward:
                                rt[0] = (IO_MOTOR.CY_Stopper_Front != null) ? Cylinder_Ctrl(MyClinder.Stopper_Front, ACT) : ThreeValued.TRUE;
                                rt[1] = (IO_MOTOR.CY_Stopper_Front_2 != null) ? Cylinder_Ctrl(MyClinder.Stopper_Front_2, ACT) : ThreeValued.TRUE;
                                break;
                            case EDirection.Backward:
                                rt[0] = (IO_MOTOR.CY_Stopper_Back != null) ? Cylinder_Ctrl(MyClinder.Stopper_Back, ACT) : ThreeValued.TRUE;
                                rt[1] = (IO_MOTOR.CY_Stopper_Back_2 != null) ? Cylinder_Ctrl(MyClinder.Stopper_Back_2, ACT) : ThreeValued.TRUE;
                                break;
                            default:
                                break;
                        }

                        if (rt.All(x => x == ThreeValued.TRUE))
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "止擋開關:" + DIR.ToString() + "," + ACT.ToString());
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// 有無板偵測
        /// <summary>
        /// <param name="HasProduct"></param>
        /// <returns></returns>
        public virtual ThreeValued CheckPanelExist(bool HasProduct)
        {
            ThreeValued[] tv = new ThreeValued[2] { ThreeValued.UNKNOWN, ThreeValued.UNKNOWN };
            tv[0] = IO_MOTOR.DI_Board_InPos_Front.On(iSensor_DelayTime, iSensor_Timeout);
            tv[1] = IO_MOTOR.DI_Board_PreInPos_Back.On(iSensor_DelayTime, iSensor_Timeout);

            if (HasProduct)
            {
                if (tv.All(x => x == ThreeValued.TRUE))
                    return ThreeValued.TRUE;
                else if (tv.Any(x => x == ThreeValued.FALSE))
                    return ThreeValued.FALSE;
            }
            else
            {
                if (tv.All(x => x == ThreeValued.FALSE))
                    return ThreeValued.TRUE;
                else if (tv.Any(x => x == ThreeValued.TRUE))
                    return ThreeValued.FALSE;
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// 移動到指定點位並檢查
        /// </summary>
        /// <param name="Pos"></param>
        /// <param name="Detect"></param>
        /// <returns></returns>
        public virtual ThreeValued ConveyorMoveAndCheck(int Pos, DigitalInput Detect)
        {
            if (Detect == null)
            {
                return ThreeValued.FALSE;
            }

            string ActionNmae = "ConveyorMoveAndCheck-";
            int ipos = Pos;
            switch (AutoTask.Value)
            {
                case 0:
                    {//Reset
                        IO_MOTOR.MO_Conveyor.SetPos(0);
                        IO_MOTOR.MO_Conveyor.SetEncoderPos(0);

                        RunTM.Restart();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "Reset");
                    }
                    break;
                case 10:
                    {//傳輸
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        bool b1 = IO_MOTOR.MO_Conveyor.G00(ipos);

                        ThreeValued tv = ThreeValued.UNKNOWN;
                        tv = Detect.On(iSensor_DelayTime, iSensor_Timeout);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            IO_MOTOR.MO_Conveyor.Stop();
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos On");
                        }

                        if (b1)
                        {//走完還沒碰到
                            RunTM.Restart();
                            AutoTask.Next(20);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳輸");
                        }
                    }
                    break;
                case 20:
                    {//多跑
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        ipos = Pos + iTransferRunMore_Distance;
                        bool b1 = IO_MOTOR.MO_Conveyor.G00(ipos);

                        ThreeValued tv = ThreeValued.UNKNOWN;
                        tv = Detect.On(iSensor_DelayTime, iSensor_Timeout);
                        if (tv == ThreeValued.TRUE)
                        {//到位Sensor
                            IO_MOTOR.MO_Conveyor.Stop();
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "InPos On");
                        }

                        if (b1 && tv == ThreeValued.FALSE)
                        {
                            ShowAlarm("E", (int)AlarmCode.PanelTransfer_Timeout);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "傳送逾時");
                            return ThreeValued.FALSE;
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
            }
            return ThreeValued.UNKNOWN;
        }
        /// <summary>
        /// 有無板偵測
        /// <summary>
        /// <param name="HasProduct"></param>
        /// <returns></returns>
        public virtual ThreeValued AxisU_Move(int Pos)
        {
            if (IO_MOTOR.MO_AxisU == null)
            {
                return ThreeValued.FALSE;
            }

            string ActionNmae = "AxisU_Move-";
            int ipos = Pos;
            switch (AutoTask.Value)
            {
                case 0:
                    {//Reset
                        SetSpeed();
                        RunTM.Restart();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "Reset");
                    }
                    break;
                case 10:
                    {//U軸移動
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "Simulation");
                        }

                        bool b1 = IO_MOTOR.MO_AxisU.G00(ipos);

                        if (b1)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "U軸移動:" + ipos.ToString());
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
            }
            return ThreeValued.UNKNOWN;
        }
    }
}
