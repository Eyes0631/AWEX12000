using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOI_BB
{
    public enum Failure_Action
    {
        None,
        Retry,
        Ignore,
        Cancel,
        OpenOcrSoftware,
        Reject,
        ManualInput,
        Correction,
    }

    public partial class Failure_Action_Form : Form
    {
        public Failure_Action BtnResult = Failure_Action.None;
        public Failure_Action_Form(string Msg, string[] btnName, Failure_Action[] btnAction)
        {
            InitializeComponent();
            label_Msg.Text = Msg;

            if (btnName.Length != btnAction.Length)
                MessageBox.Show(Msg + "表單設定錯誤");

            int count = 0;

            for (int i = 0; i < btnName.Length; i++)
            {
                Button btn = new Button();
                btn.Text = btnName[i];
                btn.Tag = btnAction[i].ToString();
                btn.Name = i.ToString();
                btn.Height = panel1.Height;
                btn.Width = panel1.Width / btnName.Length;
                btn.Font = new Font("Verdana", 22F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                btn.Location = new Point(btn.Width * i, 0);
                btn.Click += btnResult_Click;
                panel1.Controls.Add(btn);
            }
        }


        public void ShowForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TopLevel = true;
            this.BringToFront();//v1.0.0.14 Munin
            this.ShowDialog();
        }

        public Failure_Action GetResult()
        {
            return BtnResult;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Failure_Action btnAction = Failure_Action.None;
            if (Enum.TryParse<Failure_Action>(btn.Tag.ToString(), out btnAction))
            {
                if (btnAction != Failure_Action.None)
                {
                    BtnResult = btnAction;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error,Action is None");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error,Invalid enum string");
                return;
            }
        }
    }

}
