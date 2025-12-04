using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonObj;

namespace WOI_AB
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

            if (DataLayer.MES_ID != null && DataLayer.MES_ID.Length > 0)    //v1.0.0.9 改讀取MESID來選取
            {
                foreach (MES_ID_Data mesIdData in DataLayer.MES_ID) 
                {
                    comboBox_CstID.Items.Add(mesIdData.ID);
                }
            }
            //btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //if (textBox_CstID.Text == "")
            //{
            //    MessageBox.Show("Input the [CassetteID].");
            //    return;
            //}
            if (comboBox_CstID.Text == "") 
            {
                MessageBox.Show("Input the [CassetteID].");
                return;
            }
            sCstID = comboBox_CstID.Text;
            //sCstID = textBox_CstID.Text;
            btn_Result = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) //v1.0.0.5 新增Cancel按鈕 Munin
        {
            btn_Result = System.Windows.Forms.DialogResult.Cancel;
            this.Hide();
        }

        public void ShowForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowDialog();
        }

        private void comboBox_CstID_KeyPress(object sender, KeyPressEventArgs e) //v1.0.0.9 改讀取MESID來選取
        {
            bool b1 = (int)e.KeyChar >= 48 && (int)e.KeyChar <= 90;
            bool b2 = (int)e.KeyChar >= 97 && (int)e.KeyChar <= 122;
            bool b3 = (int)e.KeyChar == 13;//Enter
            bool b4 = (int)e.KeyChar == 8;//BackSpace
            bool b5 = (int)e.KeyChar == 95;// 底线 _
            bool b6 = (int)e.KeyChar == 32;// 空格
            bool b7 = (int)e.KeyChar == 45;// 符号 -
            if (!b1 && !b2 && !b3 && !b4 && !b5 && !b6 && !b7)
            {
                e.Handled = true;
            }
            if (b3)
            {
                btn_OK_Click(sender, e);
            }
        }

        

        //private void textBox_CstID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    bool b1 = (int)e.KeyChar >= 48 && (int)e.KeyChar <= 90;
        //    bool b2 = (int)e.KeyChar >= 97 && (int)e.KeyChar <= 122;
        //    bool b3 = (int)e.KeyChar == 13;//Enter
        //    bool b4 = (int)e.KeyChar == 8;//BackSpace
        //    if (!b1 && !b2 && !b3 && !b4)
        //    {
        //        e.Handled = true;
        //    }
        //    if (b3)
        //    {
        //        btn_OK_Click(sender, e);
        //    }
        //}

        
    }
}
