using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProVIFM;

namespace AWEX12000
{
    public partial class InitialForm : Form
    {
        #region 使用者修改 (定義各模組指標)

        //private BaseModuleInterface mTray = null;

        #endregion

        public InitialForm()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            #region 使用者修改 (取得各模組指標)

            //mTray = (BaseModuleInterface)FormSet.mMSS.GetModule("Tray");

            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SYSPara.LogSay(EnLoggerType.EnLog_OP, "使用者按下「歸零取消」");

            tmRefresh.Enabled = false;
            SYSPara.SysState = StateMode.SM_ABORT;
            Parent = null;
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {
            btnCancel.Top = 0;
            btnCancel.Left = FormSet.mInitialF.Width - FormSet.mInitialF.btnCancel.Width;
        }

        public void Reset()
        {
            tmRefresh.Enabled = true;
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            tmRefresh.Enabled = false;

            #region 使用者修改 (各模組歸零狀態的顯示)

            //if (mTray != null)
            //    lbTray.Value = mTray.mHomeOk;
            //else
            //    lbTray.BackColor = Color.Red;

            #endregion

            tmRefresh.Enabled = true;
        }
    }
}
