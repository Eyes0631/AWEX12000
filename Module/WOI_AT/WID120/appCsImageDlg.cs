using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCs
{
    public partial class AppCsImageDlg : Form
    {
        public AppCsImageDlg()
        {
            InitializeComponent();
        }

        private void AppCsImageDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hide on close
            e.Cancel = true;
            Hide();
        }
    }
}
