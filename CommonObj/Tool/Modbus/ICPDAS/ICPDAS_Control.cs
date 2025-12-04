using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonObj.ModbusTCP
{
    public partial class ICPDAS_Control : UserControl
    {
        private ICPDAS_t_P_ET_DA2 t_P_ET_DA2 = new ICPDAS_t_P_ET_DA2("172.16.0.1","502");

        public ICPDAS_Control()
        {
            InitializeComponent();
            t_P_ET_DA2.delShowMsg += ShowMsg;
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
            t_P_ET_DA2.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            t_P_ET_DA2.DisConnect();
        }

        private void btn_AO_SetValue_Click(object sender, EventArgs e)
        {
            switch (cbx_Channels.SelectedIndex)
            {
                case 0:
                    t_P_ET_DA2.SetOutput(ICPDAS_t_P_ET_DA2.MPort.AO_0, (float)numericUpDown_AO.Value);
                    break;
                case 1:
                    t_P_ET_DA2.SetOutput(ICPDAS_t_P_ET_DA2.MPort.AO_1, (float)numericUpDown_AO.Value);
                    break;
            }
        }

        private void btn_AO_SetMode_Click(object sender, EventArgs e)
        {
            ICPDAS_t_P_ET_DA2.Mode mode;
            switch (cbx_Mode.SelectedIndex)
            {
                case 0:
                    mode = ICPDAS_t_P_ET_DA2.Mode.Current1;
                    break;
                case 1:
                    mode = ICPDAS_t_P_ET_DA2.Mode.Current2;
                    break;
                case 2:
                    mode = ICPDAS_t_P_ET_DA2.Mode.Volt;
                    break;
                default:
                    return;
            }

            switch (cbx_Channels.SelectedIndex)
            {
                case 0:
                    t_P_ET_DA2.SetMode(ICPDAS_t_P_ET_DA2.MPort.AO_0, mode);
                    break;
                case 1:
                    t_P_ET_DA2.SetMode(ICPDAS_t_P_ET_DA2.MPort.AO_1, mode);
                    break;
            }
        }
    }
}
