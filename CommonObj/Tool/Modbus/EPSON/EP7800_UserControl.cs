using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonObj.Tool.Modbus.EPSON
{
    public partial class EP7800_UserControl : UserControl
    {
        private EP7800 _EP7800 = new EP7800("COM1", "9600", "8", "1", "None");
        private bool bCycle = false;
        private float fMax = 0.0f;
        private float fMIn = 0.0f;

        public EP7800_UserControl()
        {
            InitializeComponent();
            _EP7800.delShowMsg += ShowMsg;
            cbx_Command.Items.AddRange(GetCommandList());
            cbx_Command.SelectedIndex = 0;
        }

        private void ShowMsg(string Msg)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                textBox1.AppendText(Msg);
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _EP7800.DisConnect();
            _EP7800.SetComPort("COM4", "19200", "8", "1", "None");
            _EP7800.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _EP7800.DisConnect();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            _EP7800.ReadValue(StringToFunctionCode(cbx_Command.SelectedItem.ToString()), 1); 
        }

        private void btn_Writte_Click(object sender, EventArgs e)
        {
            _EP7800.WritteValue(StringToFunctionCode(cbx_Command.SelectedItem.ToString()), 1); 
        }

        private void btn_Cycle_Click(object sender, EventArgs e)
        {
            bCycle = !bCycle;
            if (bCycle)
            {
                fMax = 0.0f;
                fMIn = 0.0f;
                btn_Cycle.Text = "Stop";
            }
            else
            {
                btn_Cycle.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (_EP7800.Connected)
            {
                if (bCycle)
                {
                    if (_EP7800.OnReadFinish)
                    {
                        _EP7800.ReadValue(FunctionCode.CurrentFlowValue, 1);
                    }
                }
            }

            tbx_Now_Pressure.Text = _EP7800.fPressureValue.ToString();

            if (fMax < _EP7800.fPressureValue)
                fMax = _EP7800.fPressureValue;

            if (fMIn > _EP7800.fPressureValue)
                fMIn = _EP7800.fPressureValue;

            tbx_Max_Pressure.Text = fMax.ToString();
            tbx_Min_Pressure.Text = fMIn.ToString();

            timer1.Enabled = true;
        }

        private string[] GetCommandList()
        {
            List<string> listName = new List<string>();
            listName.AddRange(Enum.GetNames(typeof(FunctionCode)));

            string[] enumNames = listName.ToArray();
            return enumNames;
        }

        private FunctionCode StringToFunctionCode(string func)
        {
            if (func == null)
                return FunctionCode.CurrentPressureValue;

            FunctionCode eFunc;
            if (Enum.TryParse(func, out eFunc))
                return eFunc;
            return FunctionCode.CurrentPressureValue;
        }
    }
}
