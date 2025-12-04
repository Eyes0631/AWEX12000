using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWEX12000
{
    public partial class AlarmMsgFrm : Form
    {
        bool IsDown = false;
        int NowX = 0;
        int NowY = 0;

        public AlarmMsgFrm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public void SetMsg(string s)
        {
            label1.Text = s;

            Graphics graph = this.CreateGraphics();
            SizeF sizef = graph.MeasureString(s, label1.Font);
            this.Width = (int)sizef.Width + 50 ;
            this.Height = (int)sizef.Height + 50;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                NowX = e.X;
                NowY = e.Y;
                IsDown = true;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                IsDown = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                int shiftX = NowX - e.X;
                int shiftY = NowY - e.Y;

                this.Left -= shiftX;
                this.Top -= shiftY;
            }
        }       
    }
}
