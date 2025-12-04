using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KCSDK;

namespace AWEX12000
{
    //使用者修改 (設備通用參數放置處)
    public partial class OptionF : BaseOptionF
    {
        public OptionF()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            //備份原始速率(安全門關閉時使用)
            SYSPara.OrgSysSpeedRate = SYSPara.OReadValue("機台速率").ToInt();
        }

        public void RefreshAllData()
        {
            OptionDS.Initial(SYSPara.SysDir + @"\LocalData\MachineSet.xml", "SYS");
            DataSnippet.DataGetAll(this);
            DataSnippet.ControlEnable(this, false);
        }
    }
}
