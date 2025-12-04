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
    public partial class MiniKeyBoard : Form
    {
        public event EventHandler<string> KeyPressed;
        private bool bNowIsUpcase;
        private List<Button> listBtn = new List<Button>();

        public MiniKeyBoard(Point p)
        {
            InitializeComponent();

            this.Size = new Size(0, 0);
            this.Visible = true;
            this.Hide();

            InitializeButtons();
            this.Location = p;

            bNowIsUpcase = true;
        }

        private void InitializeButtons()
        {
            listBtn.Clear();
            int iKeyBoard = 50;
            Font font = new Font("Arial", 16, FontStyle.Bold);
            // Create buttons 0-9
            for (int i = 0; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Name = "btn" + i.ToString();
                btn.Width = iKeyBoard;
                btn.Height = iKeyBoard;
                btn.Click += Btn_Click;
                btn.Font = font;
                flowLayoutPanel1.Controls.Add(btn);
                listBtn.Add(btn);
            }

            // Create buttons A-Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button btn = new Button();
                btn.Text = c.ToString();
                btn.Name = "btn" + c.ToString();
                btn.Width = iKeyBoard;
                btn.Height = iKeyBoard;
                btn.Click += Btn_Click;
                btn.Font = font;
                flowLayoutPanel1.Controls.Add(btn);
                listBtn.Add(btn);
            }

            // Create Back button
            Button btnDash = new Button();
            btnDash.Text = "-";
            btnDash.Name = "btnDash";
            btnDash.Width = iKeyBoard;
            btnDash.Height = iKeyBoard;
            btnDash.Click += Btn_Click;
            btnDash.Font = font;
            flowLayoutPanel1.Controls.Add(btnDash);
            listBtn.Add(btnDash);

            // Create Back button
            Button btnBack = new Button();
            btnBack.Text = "←";
            btnBack.Name = "btnBack";
            btnBack.Width = iKeyBoard;
            btnBack.Height = iKeyBoard;
            btnBack.Click += BtnBack_Click;
            btnBack.Font = font;
            flowLayoutPanel1.Controls.Add(btnBack);
            listBtn.Add(btnBack);

            // Create Clear button
            Button btnClear = new Button();
            btnClear.Text = "Del";
            btnClear.Name = "btnClear";
            btnClear.Width = iKeyBoard;
            btnClear.Height = iKeyBoard;
            btnClear.Click += BtnClear_Click;
            btnClear.Font = font;
            flowLayoutPanel1.Controls.Add(btnClear);
            listBtn.Add(btnClear);

            // Create Clear button
            Button btnUpcase = new Button();
            btnUpcase.Text = "";
            btnUpcase.Name = "btnUpcase";
            btnUpcase.Width = iKeyBoard;
            btnUpcase.Height = iKeyBoard;
            btnUpcase.Click += BtnUpcaseSW_Click;
            btnUpcase.Font = font;
            btnUpcase.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpcase.BackgroundImage = global::CommonObj.Properties.Resources.uppercase;
            flowLayoutPanel1.Controls.Add(btnUpcase);
            listBtn.Add(btnUpcase);

            this.Width = 11 * iKeyBoard + 10;
            this.Height = 5 * iKeyBoard;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (KeyPressed != null)
            {
                KeyPressed(this, btn.Text);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (KeyPressed != null)
            {
                KeyPressed(this, "Del");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (KeyPressed != null)
            {
                KeyPressed(this, "Back");
            }
        }

        private void BtnUpcaseSW_Click(object sender, EventArgs e)
        {
            if (bNowIsUpcase)
            {
                bNowIsUpcase = false;

                foreach (Button btn in listBtn)
                {
                    if (btn.Text != "Del")
                    {
                        string str = btn.Text.ToLower();
                        btn.Text = str;
                    }
                }

                listBtn.Find(x => x.Name == "btnUpcase").BackgroundImage = global::CommonObj.Properties.Resources.lowercase;

            }
            else
            {
                bNowIsUpcase = true;

                foreach (Button btn in listBtn)
                {
                    if (btn.Text != "Del")
                    {
                        string str = btn.Text.ToUpper();
                        btn.Text = str;
                    }
                }
                
                listBtn.Find(x => x.Name == "btnUpcase").BackgroundImage = global::CommonObj.Properties.Resources.uppercase;
            }
        }

        public void ShowForm(Point p)
        {
            this.Location = p;
            this.TopMost = true;
            this.Show();
        }
    }
}
