using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProVLib;
using PaeLibGeneral;
using System.Threading;

namespace CommonObj.ModbusTCP.TapeRemove
{
    public partial class TapeRemove_Control : UserControl
    {
        public TapeRemove_Control()
        {
            InitializeComponent();

            IntPtr hwnd = this.Handle;
            this.Refresh();

            Thread_FlowChart = new Thread(Cycle);
            StopFlowChartThread = false;
            Thread_FlowChart.Start();
        }

        public enum TapeRemove_Action_Mode
        {
            None,
            ScanStatus,
        }

        private Thread Thread_FlowChart;
        private bool StopFlowChartThread;
        private TapeRemoveMBX TR = new TapeRemoveMBX("192.168.0.110", "502", "TapeRemove");
        private static CancellationTokenSource _cancellationTokenSource;
        private MyTimer RunTM = new MyTimer();
        private TapeRemoveMBX.RB_SignalDefine RB_Signal = new TapeRemoveMBX.RB_SignalDefine();

        public string sIP 
        {
            set 
            {
                if (TR != null) 
                    TR.IP = value; 
            }
        }

        public string sPort 
        {
            set 
            { 
                if (TR != null) 
                    TR.Port = value;
            }
        }

        public bool bIsSimulation = false;
        public bool bUpdateMsg = true;
        private bool bRun = false;

        public void Connect()
        {
            bRun = true;
            if (TR.Connected == false)
            {
                TR.Connect();
            }
        }

        public void Disconnect()
        {
            bRun = false;
            ManualReset();
            TR.DisConnect();
        }

        public bool Connected
        {
            get { return TR.Connected; }
        }

        private void ShowMsg(string Msg)
        {
            if (bUpdateMsg)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    textBox1.AppendText(Msg);
                });
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Cycle()
        {
            try
            {
                while (!StopFlowChartThread)
                {
                    FC_DeTapeStatus_Start.MainRun();
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("DeTapeError Error," + msg);
                Initial();
            }
        }

        #region 公用函數

        //模組解構使用
        public void DisposeTH()
        {
            // 取消背景工作
            //_cancellationTokenSource.Cancel();
            StopFlowChartThread = true;
            Thread_FlowChart.Join();
        }

        public void Initial()
        {
            TR.delShowMsg = null;
            TR.delShowMsg += ShowMsg;
            ManualReset();

        }

        public void ManualReset()
        {
            FC_DeTapeStatus_Start.TaskReset();

            //UpdateData();
        }

        public bool SaveLog
        {
            set { TR.SaveLog = value; }
        }
        #endregion 公用函數

        private FlowChart.FCRESULT FC_DeTapeStatus_Start_Run()
        {
            //if (bIsSimulation)
                //return FlowChart.FCRESULT.IDLE;
            if (bRun)
            {
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_CheckConnect_Run()
        {
            if (TR.Connected == false)
            {
                if (RunTM.On(3000))
                {
                    RunTM.Restart();
                    return FlowChart.FCRESULT.CASE1;
                }
                //MBX.Connect(SReadValue("IP").ToString(), SReadValue("Port").ToString());
            }
            else
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_Connect_Run()
        {
            TR.Connect();
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_ReadToolStatus_Run()
        {
            //if (RunTM.On(500))
            {
                TR.ReadHoldingRegisters((byte)MBX_Function.ReadToolSignal, 0, 31232, 50);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_ReadToolStatusDone_Run()
        {
            if (TR.OnReadFinish)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (RunTM.On(3000))
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_UpdateData_Run()
        {
            TapeRemoveMBX.TOOL_SignalDefine Tool_Signal = TR.GetToolSignal;
            DataLayer.TapeRemove_TOOL_Signal = Tool_Signal;
            DataLayer.DeTapeCount = Tool_Signal.iTOOL_TapeUseCount;//v1.1.0.5 更新撕膜次數

            this.Invoke((MethodInvoker)delegate
            {
                led_TOOL_Alarm.Value = Tool_Signal.bTOOL_Alarm;
                led_TOOL_Pause.Value = Tool_Signal.bTOOL_Pause;
                led_TOOL_InitailDone.Value = Tool_Signal.bTOOL_InitialDone;
                lb_TapeUseCount.Text = string.Format("{0:0.00}", Tool_Signal.iTOOL_TapeUseCount.ToString());
                lb_RollerDownPressure.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_RollerDownPressure.ToString());
                lb_AlarmCode.Text = Tool_Signal.iTOOL_AlarmCode.ToString();
                lb_TOOL_WaferSize.Text = Tool_Signal.eTOOL_WaferSize == EWaferSize.Wafer_8 ? "8" : "12";
                //CV1
                led_TOOL_CV1_Ready.Value = Tool_Signal.bTOOL_CV1_Ready;
                led_TOOL_CV1_Receive_Permission.Value = Tool_Signal.bTOOL_CV1_Receive_Permission;
                led_TOOL_CV1_Receive_Busy.Value = Tool_Signal.bTOOL_CV1_Receive_Busy;
                led_TOOL_CV1_Receive_Complete.Value = Tool_Signal.bTOOL_CV1_Receive_Complete;
                led_TOOL_CV1_Out_Request.Value = Tool_Signal.bTOOL_CV1_Out_Request;
                led_TOOL_CV1_Out_Busy.Value = Tool_Signal.bTOOL_CV1_Out_Busy;
                led_TOOL_CV1_Out_Complete.Value = Tool_Signal.bTOOL_CV1_Out_Complete;

                led_TOOL_CV1_LaserMeasurement_OK.Value = Tool_Signal.bTOOL_CV1_LaserMeasurement_OK;
                led_TOOL_CV1_Cut_Start.Value = Tool_Signal.bTOOL_CV1_Cut_Start;
                led_TOOL_CV1_Cut_End.Value = Tool_Signal.bTOOL_CV1_Cut_End;
                led_TOOL_CV1_CCD_CheckCutOK.Value = Tool_Signal.bTOOL_CV1_CCD_CheckCutOK;
                led_TOOL_CV1_DeTape_Start.Value = Tool_Signal.bTOOL_CV1_DeTape_Start;
                led_TOOL_CV1_DeTape_End.Value = Tool_Signal.bTOOL_CV1_DeTape_End;
                led_TOOL_CV1_RollerDown_Start.Value = Tool_Signal.bTOOL_CV1_RollerDown_Start;
                led_TOOL_CV1_RollerDown_End.Value = Tool_Signal.bTOOL_CV1_RollerDown_End;
                led_TOOL_CV1_DeTapeNG.Value = Tool_Signal.bTOOL_CV1_DeTapeNG;
                led_TOOL_CV1_AlignStart.Value = Tool_Signal.bTOOL_CV1_Align_Start;
                led_TOOL_CV1_AlignEnd.Value = Tool_Signal.bTOOL_CV1_Align_End;
                led_TOOL_CV1_CutNG.Value = Tool_Signal.bTOOL_CV1_CutNG;
                led_TOOL_CV1_Use.Value = Tool_Signal.bTOOL_CV1_Use;
                led_TOOL_CV1_Cut_Use.Value = Tool_Signal.bTOOL_CV1_Cut_Use;

                led_TOOL_CV1_DeTapeArmIsSafe.Value = Tool_Signal.bTOOL_CV1_DeTapeArmIsSafe;
                led_TOOL_CV1_LaserArmIsSafe.Value = Tool_Signal.bTOOL_CV1_LaserArmIsSafe;
                led_TOOL_CV1_CutArmIsSafe.Value = Tool_Signal.bTOOL_CV1_CutArmIsSafe;
                led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Value = Tool_Signal.bTOOL_CV1_Ejector_MoveToLoadPos_VacuumOff;

                lb_CV1_LaserMeasurementData.Text = Tool_Signal.fTOOL_CV1_LaserMeasurementData.ToString();
                lb_CV1_CutNeedles_Current.Text = Tool_Signal.fTOOL_CV1_CutNeedles_Current.ToString();
                lb_CV1_DeTape_Current_Axiz17.Text = Tool_Signal.fTOOL_CV1_DeTape_Current_Axiz17.ToString();
                lb_CV1_DeTape_Current_Axiz18.Text = Tool_Signal.fTOOL_CV1_DeTape_Current_Axiz18.ToString();
                lb_CV1_ESD.Text = Tool_Signal.fTOOL_CV1_ESD.ToString();

                lb_CV1_CutNeedles_UseCount.Text = Tool_Signal.iTOOL_CV1_CutNeedles_UseCount.ToString();
                lb_CV1_CCD_CutResult.Text = Tool_Signal.iTOOL_CV1_CCD_CutResult.ToString();
                lb_CV1_CutNeedles_Current.Text = Tool_Signal.iTOOL_CV1_CutNeedles_Current.ToString();
                lb_CV1_CCD_DeTapeResult.Text = Tool_Signal.iTOOL_CV1_CCD_DeTapeResult.ToString();

                lb_CV1_LaserMeasurementData.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV1_LaserMeasurementData.ToString());
                lb_CV1_CutNeedles_Current.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV1_CutNeedles_Current.ToString());
                lb_CV1_ESD.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV1_ESD.ToString());

                //CV2
                led_TOOL_CV2_Ready.Value = Tool_Signal.bTOOL_CV2_Ready;
                led_TOOL_CV2_Receive_Permission.Value = Tool_Signal.bTOOL_CV2_Receive_Permission;
                led_TOOL_CV2_Receive_Busy.Value = Tool_Signal.bTOOL_CV2_Receive_Busy;
                led_TOOL_CV2_Receive_Complete.Value = Tool_Signal.bTOOL_CV2_Receive_Complete;
                led_TOOL_CV2_Out_Request.Value = Tool_Signal.bTOOL_CV2_Out_Request;
                led_TOOL_CV2_Out_Busy.Value = Tool_Signal.bTOOL_CV2_Out_Busy;
                led_TOOL_CV2_Out_Complete.Value = Tool_Signal.bTOOL_CV2_Out_Complete;

                led_TOOL_CV2_LaserMeasurement_OK.Value = Tool_Signal.bTOOL_CV2_LaserMeasurement_OK;
                led_TOOL_CV2_Cut_Start.Value = Tool_Signal.bTOOL_CV2_Cut_Start;
                led_TOOL_CV2_Cut_End.Value = Tool_Signal.bTOOL_CV2_Cut_End;
                led_TOOL_CV2_CCD_CheckCutOK.Value = Tool_Signal.bTOOL_CV2_CCD_CheckCutOK;
                led_TOOL_CV2_DeTape_Start.Value = Tool_Signal.bTOOL_CV2_DeTape_Start;
                led_TOOL_CV2_DeTape_End.Value = Tool_Signal.bTOOL_CV2_DeTape_End;
                led_TOOL_CV2_RollerDown_Start.Value = Tool_Signal.bTOOL_CV2_RollerDown_Start;
                led_TOOL_CV2_RollerDown_End.Value = Tool_Signal.bTOOL_CV2_RollerDown_End;
                led_TOOL_CV2_DeTapeNG.Value = Tool_Signal.bTOOL_CV2_DeTapeNG;
                led_TOOL_CV2_AlignStart.Value = Tool_Signal.bTOOL_CV2_Align_Start;
                led_TOOL_CV2_AlignEnd.Value = Tool_Signal.bTOOL_CV2_Align_End;
                led_TOOL_CV2_CutNG.Value = Tool_Signal.bTOOL_CV2_CutNG;
                led_TOOL_CV2_Use.Value = Tool_Signal.bTOOL_CV2_Use;
                led_TOOL_CV2_Cut_Use.Value = Tool_Signal.bTOOL_CV2_Cut_Use;

                led_TOOL_CV2_DeTapeArmIsSafe.Value = Tool_Signal.bTOOL_CV2_DeTapeArmIsSafe;
                led_TOOL_CV2_LaserArmIsSafe.Value = Tool_Signal.bTOOL_CV2_LaserArmIsSafe;
                led_TOOL_CV2_CutArmIsSafe.Value = Tool_Signal.bTOOL_CV2_CutArmIsSafe;
                led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Value = Tool_Signal.bTOOL_CV2_Ejector_MoveToLoadPos_VacuumOff;

                lb_CV2_LaserMeasurementData.Text = Tool_Signal.fTOOL_CV2_LaserMeasurementData.ToString();
                lb_CV2_CutNeedles_Current.Text = Tool_Signal.fTOOL_CV2_CutNeedles_Current.ToString();
                lb_CV2_DeTape_Current_Axiz17.Text = Tool_Signal.fTOOL_CV2_DeTape_Current_Axiz17.ToString();
                lb_CV2_DeTape_Current_Axiz18.Text = Tool_Signal.fTOOL_CV2_DeTape_Current_Axiz18.ToString();
                lb_CV2_ESD.Text = Tool_Signal.fTOOL_CV2_ESD.ToString();

                lb_CV2_CutNeedles_UseCount.Text = Tool_Signal.iTOOL_CV2_CutNeedles_UseCount.ToString();
                lb_CV2_CCD_CutResult.Text = Tool_Signal.iTOOL_CV2_CCD_CutResult.ToString();
                lb_CV2_CutNeedles_Current.Text = Tool_Signal.iTOOL_CV2_CutNeedles_Current.ToString();
                lb_CV2_CCD_DeTapeResult.Text = Tool_Signal.iTOOL_CV2_CCD_DeTapeResult.ToString();

                lb_CV2_LaserMeasurementData.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV2_LaserMeasurementData.ToString());
                lb_CV2_CutNeedles_Current.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV2_CutNeedles_Current.ToString());
                lb_CV2_ESD.Text = string.Format("{0:0.00}", Tool_Signal.fTOOL_CV2_ESD.ToString());

                string mode = "";
                switch (Tool_Signal.eTOOL_Machine_Status)
                {
                    case TOOL_Machine_Status.Manual:
                        mode = "手動";
                        break;
                    case TOOL_Machine_Status.Semi_Automatic:
                        mode = "半自動";
                        break;
                    case TOOL_Machine_Status.Auto:
                        mode = "自動";
                        break;
                    default:
                        break;
                }
                lb_MachineMode.Text = mode;
                //RB
                RB_Signal = DataLayer.TapeRemove_RB_Signal;

                led_RB_NotifyInitial.Value = RB_Signal.bRB_NotifyInitial;
                led_RB_Ready.Value = RB_Signal.bRB_Ready;
                led_RB_Pause.Value = RB_Signal.bRB_Pause;

                led_RB_CV1_Out_Request.Value = RB_Signal.bRB_CV1_Out_Request;
                led_RB_CV1_Out_Busy.Value = RB_Signal.bRB_CV1_Out_Busy;
                led_RB_CV1_Out_Complete.Value = RB_Signal.bRB_CV1_Out_Complete;
                led_RB_CV1_Receive_Permission.Value = RB_Signal.bRB_CV1_Receive_Permission;
                led_RB_CV1_Receive_Busy.Value = RB_Signal.bRB_CV1_Receive_Busy;
                led_RB_CV1_Receive_Complete.Value = RB_Signal.bRB_CV1_Receive_Complete;
                led_RB_CV1_DoDeTape.Value = RB_Signal.bRB_CV1_DoDeTape;
                led_RB_CV1_DoReject.Value = RB_Signal.bRB_CV1_DoReject;
                led_RB_CV1_DoUnloadLoad.Value = RB_Signal.bRB_CV1_DoUnload_Load;//1.1.0.3

                led_RB_CV2_Out_Request.Value = RB_Signal.bRB_CV2_Out_Request;
                led_RB_CV2_Out_Busy.Value = RB_Signal.bRB_CV2_Out_Busy;
                led_RB_CV2_Out_Complete.Value = RB_Signal.bRB_CV2_Out_Complete;
                led_RB_CV2_Receive_Permission.Value = RB_Signal.bRB_CV2_Receive_Permission;
                led_RB_CV2_Receive_Busy.Value = RB_Signal.bRB_CV2_Receive_Busy;
                led_RB_CV2_Receive_Complete.Value = RB_Signal.bRB_CV2_Receive_Complete;
                led_RB_CV2_DoDeTape.Value = RB_Signal.bRB_CV2_DoDeTape;
                led_RB_CV2_DoReject.Value = RB_Signal.bRB_CV2_DoReject;
                led_RB_CV2_DoUnloadLoad.Value = RB_Signal.bRB_CV2_DoUnload_Load;//1.1.0.3

                lb_RB_WaferSize.Text = RB_Signal.iRB_WaferSize.ToString();
            });
            //todo
            RunTM.Restart();
            return FlowChart.FCRESULT.NEXT;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_WriteRobotStatus_Run()
        {
            //if (RunTM.On(500))
            {
                ushort[] data = new ushort[10];
                bool[] b = new bool[16];
              
                b[7] = RB_Signal.bRB_Ready;
                b[9] = RB_Signal.bRB_Pause;

                data[0] = ClientMBX.BoolArrayToWord(b);

                b = new bool[16];
                b[0] = RB_Signal.bRB_CV1_Out_Request;
                b[1] = RB_Signal.bRB_CV1_Out_Busy;
                b[2] = RB_Signal.bRB_CV1_Out_Complete;
                b[3] = RB_Signal.bRB_CV1_Receive_Permission;
                b[4] = RB_Signal.bRB_CV1_Receive_Busy;
                b[5] = RB_Signal.bRB_CV1_Receive_Complete;
                b[6] = RB_Signal.bRB_CV1_DoDeTape;
                b[7] = RB_Signal.bRB_CV1_DoReject;
                b[8] = RB_Signal.bRB_CV1_DoUnload_Load;//1.1.0.3

                data[2] = ClientMBX.BoolArrayToWord(b);

                b = new bool[16];
                b[0] = RB_Signal.bRB_CV2_Out_Request;
                b[1] = RB_Signal.bRB_CV2_Out_Busy;
                b[2] = RB_Signal.bRB_CV2_Out_Complete;
                b[3] = RB_Signal.bRB_CV2_Receive_Permission;
                b[4] = RB_Signal.bRB_CV2_Receive_Busy;
                b[5] = RB_Signal.bRB_CV2_Receive_Complete;
                b[6] = RB_Signal.bRB_CV2_DoDeTape;
                b[7] = RB_Signal.bRB_CV2_DoReject;
                b[8] = RB_Signal.bRB_CV2_DoUnload_Load;//1.1.0.3

                data[4] = ClientMBX.BoolArrayToWord(b);

                data[6] = (ushort)RB_Signal.iRB_WaferSize;

                TR.WriteMultipleRegisters((byte)MBX_Function.WriteRobotSignal, 0, 30720, data);
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_WriteRobotStatusDone_Run()
        {
            if (TR.OnReadFinish)
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.NEXT;
            }

            if (RunTM.On(3000))
            {
                RunTM.Restart();
                return FlowChart.FCRESULT.CASE1;
            }
            return FlowChart.FCRESULT.IDLE;
        }

        private FlowChart.FCRESULT FC_DeTapeStatus_Next_Run()
        {
            return FlowChart.FCRESULT.NEXT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLayer.TapeRemove_RB_Signal.bRB_CV1_Out_Request = true;
        }

    }
}
