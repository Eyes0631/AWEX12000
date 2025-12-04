using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonObj
{
    public partial class Failure_Action_Form : Form
    {
        public bool CheckAgain = false;
        public Select_Action BtnResult = Select_Action.None;
        public Failure_Action_Form(string Msg, string[] btnName, Select_Action[] btnAction)
        {
            InitializeComponent();
            label_Msg.Text = Msg;

            if (btnName.Length != btnAction.Length)
                MessageBox.Show(Msg + "表單設定錯誤");

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
            this.BringToFront();
            this.ShowDialog();
        }

        public Select_Action GetResult()
        {
            return BtnResult;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Select_Action btnAction = Select_Action.None;
            if (Enum.TryParse<Select_Action>(btn.Tag.ToString(), out btnAction))
            {
                if (btnAction != Select_Action.None)
                {
                    if (CheckAgain)
                    {
                        DialogResult result = MessageBox.Show("是否【" + btn.Text + "】", "提示", MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }
                    }
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
