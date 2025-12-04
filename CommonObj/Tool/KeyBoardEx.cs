using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonObj
{
    [ToolboxItem(true)]
    public partial class KeyBoardEx : UserControl
    {
        private MiniKeyBoard MyKeyBoard;
        public event EventHandler<string> KeyPressed;

        public KeyBoardEx()
        {
            InitializeComponent();

            Point buttonLocation = btn_MyKeyboard.PointToScreen(Point.Empty);
            MyKeyBoard = new MiniKeyBoard(buttonLocation);
            MyKeyBoard.KeyPressed += Keyboard_KeyPressed;
        }

        private void btn_MyKeyboard_Click(object sender, EventArgs e)
        {
            if (MyKeyBoard.Visible)
            {
                MyKeyBoard.Hide();
            }
            else
            {
                Point buttonLocation = btn_MyKeyboard.PointToScreen(Point.Empty);
                buttonLocation.Y += btn_MyKeyboard.Height + 5;
                MyKeyBoard.ShowForm(buttonLocation);
            }
        }

        private void Keyboard_KeyPressed(object sender, string e)
        {
            if (KeyPressed != null)
            {
                KeyPressed(this, e);
            }
        }

        public void DisposeTH()
        {
            MyKeyBoard.Hide();
            MyKeyBoard.Dispose();
        }
    }
}
