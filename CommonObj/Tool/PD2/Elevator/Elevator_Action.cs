using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using CommonObj;

namespace PD2_SDK
{
    public partial class ElevatorBaseModule
    {
        public virtual int CalPos(int slot, TransferMode Direction)
        {
            int pos = iFristLayerPos + (slot - 1) * iPitch;
            switch (Direction)
            {
                case TransferMode.Output:
                    pos += iOutputOffset;
                    break;
                case TransferMode.Input:
                    pos += iInputOffset;
                    break;
                default:
                    break;
            }
            return pos;
        }

        public virtual void SetSpeed()
        {
            if (IO_MOTOR.MO_AxisZ != null)
            {
                if (dMotorZ_ACC_MULTIPLE > 10 || dMotorZ_ACC_MULTIPLE < 0)
                {
                    dMotorZ_ACC_MULTIPLE = 1;
                } if (dMotorZ_DEC_MULTIPLE > 10 || dMotorZ_DEC_MULTIPLE < 0)
                {
                    dMotorZ_DEC_MULTIPLE = 1;
                }
                IO_MOTOR.MO_AxisZ.SetSpeed(iMotorZ_Speed);
                IO_MOTOR.MO_AxisZ.SetAcceleration((int)(iMotorZ_Speed * dMotorZ_ACC_MULTIPLE));
                IO_MOTOR.MO_AxisZ.SetDeceleration((int)(iMotorZ_Speed * dMotorZ_DEC_MULTIPLE));
            }
        }

        public bool TaskReset()
        {
            AutoTask.Reset();
            RunTM.Restart();
            return true;
        }
        /// <summary>
        /// 移動到指定層數
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="Direction"></param>
        /// <returns></returns>
        public virtual ThreeValued MoveToLayer(int slot, TransferMode Direction)
        {
            string ActionNmae="MoveToLayer-";
            int ipos = 0;
            switch (AutoTask.Value)
            {
                case 0:
                    {//計算點位
                        ipos = CalPos(slot, Direction);
                        RunTM.Restart();
                        AutoTask.Next(10);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "計算點位:" + ipos.ToString());
                    }
                    break;
                case 10:
                    {//設定速度
                        SetSpeed();
                        RunTM.Restart();
                        AutoTask.Next(20);
                        LogRecord.LogTrace(MyModuleName, ActionNmae + "設定速度");
                    }
                    break;
                case 20:
                    {//釋放箝制器
                        if (IO_MOTOR.Ob_MotorZ_Clamp == null)
                        {
                            RunTM.Restart();
                            AutoTask.Next(30);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "釋放箝制器:NULL");
                        }
                        else
                        {
                            if (bIsSimulation)
                            {
                                RunTM.Restart();
                                AutoTask.Next(30);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "釋放箝制器:Simulation");
                            }

                            if (IO_MOTOR.Ob_MotorZ_Clamp.On(500))
                            {
                                RunTM.Restart();
                                AutoTask.Next(30);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "釋放箝制器");
                            }
                        }
                    }
                    break;
                case 30:
                    {//馬達移動
                        if (bIsSimulation)
                        {
                            RunTM.Restart();
                            AutoTask.Next(40);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "馬達移動:Simulation");
                        }

                        bool b1 = IO_MOTOR.MO_AxisZ.G00(ipos);
                        if (b1)
                        {
                            RunTM.Restart();
                            AutoTask.Next(40);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "馬達移動");
                        }

                        if (RunTM.On(10000))
                        {
                            ShowAlarm("E", (int)AlarmCode.AxisZ_ActionTimeout);
                        }
                    }
                    break;
                case 40:
                    {//夾持箝制器
                        if (IO_MOTOR.Ob_MotorZ_Clamp == null)
                        {
                            RunTM.Restart();
                            AutoTask.Next(999);
                            LogRecord.LogTrace(MyModuleName, ActionNmae + "夾持箝制器:NULL");
                        }
                        else
                        {
                            if (bIsSimulation)
                            {
                                RunTM.Restart();
                                AutoTask.Next(999);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "夾持箝制器:Simulation");
                            }

                            if (IO_MOTOR.Ob_MotorZ_Clamp.Off(500))
                            {
                                RunTM.Restart();
                                AutoTask.Next(999);
                                LogRecord.LogTrace(MyModuleName, ActionNmae + "夾持箝制器");
                            }
                        }
                    }
                    break;
                case 999:
                    {//完成
                        //LogRecord.LogTrace(MyModuleName, ActionNmae + "Done");
                        return ThreeValued.TRUE;
                    }
                //break;
                default:
                    break;
            }
            return ThreeValued.UNKNOWN;
        }
    }
}
