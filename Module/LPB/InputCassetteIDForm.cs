using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPB
{
    public partial class InputCassetteIDForm : Form
    {
        private string sCstID = "";
        public string GetCstID { get { return sCstID; } }


        private DialogResult btn_Result = DialogResult.None;
        public DialogResult GetActionResult
        {
            get { return btn_Result; }
        }

        public InputCassetteIDForm(string Stage)
        {
            InitializeComponent();
            label1.Text = Stage;
            keyBoardEx1.KeyPressed += Keyboard_KeyPressed;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (textBox_CstID.Text == "")
            {
                MessageBox.Show("Input the [Material ID].");
                return;
            }

            sCstID = textBox_CstID.Text;
            
            btn_Result = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }

        public void ShowForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            sCstID = "";
            btn_Result = System.Windows.Forms.DialogResult.Cancel;
            this.Hide();
        }

        private void textBox_CstID_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool b1 = (int)e.KeyChar >= 48 && (int)e.KeyChar <= 90;
            bool b2 = (int)e.KeyChar >= 97 && (int)e.KeyChar <= 122;
            bool b3 = (int)e.KeyChar == 8;
            bool b4 = (int)e.KeyChar == 13;
            if (!b1 && !b2 && !b3)
            {
                e.Handled = true;
            }
            if (b4)
            {
                btn_OK_Click(sender, e);
            }
        }

        private void Keyboard_KeyPressed(object sender, string e)
        {
            if (e == "Back")
            {
                string str = textBox_CstID.Text;
                if (str != null && str != "")
                    textBox_CstID.Text = str.Substring(0, str.Length - 1);
            }
            else if (e == "Del")
            {
                textBox_CstID.Text = string.Empty;
            }
            else
            {
                textBox_CstID.Text += e;
            }
        }

        private void InputCassetteIDForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyBoardEx1.DisposeTH();
        }

    }
}
