namespace CommonObj
{
    partial class BaseMainFlowFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAuto = new System.Windows.Forms.TabPage();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InitialFlow_Done = new ProVLib.FlowChart();
            this.InitialFlow_Strat = new ProVLib.FlowChart();
            this.InitialFlow_Check = new ProVLib.FlowChart();
            this.InitialFlow = new ProVLib.FlowChart();
            this.tabControl1.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAuto);
            this.tabControl1.Controls.Add(this.tpHome);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.ItemSize = new System.Drawing.Size(220, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1231, 674);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tpAuto
            // 
            this.tpAuto.Location = new System.Drawing.Point(4, 34);
            this.tpAuto.Name = "tpAuto";
            this.tpAuto.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuto.Size = new System.Drawing.Size(1223, 636);
            this.tpAuto.TabIndex = 1;
            this.tpAuto.Text = "AutoMode";
            this.tpAuto.UseVisualStyleBackColor = true;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.InitialFlow_Done);
            this.tpHome.Controls.Add(this.InitialFlow_Strat);
            this.tpHome.Controls.Add(this.InitialFlow_Check);
            this.tpHome.Controls.Add(this.InitialFlow);
            this.tpHome.Location = new System.Drawing.Point(4, 34);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1223, 636);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Initial Mode";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1223, 636);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Check Before Lot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InitialFlow_Done
            // 
            this.InitialFlow_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.InitialFlow_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.InitialFlow_Done.CASE1 = null;
            this.InitialFlow_Done.CASE2 = null;
            this.InitialFlow_Done.CASE3 = null;
            this.InitialFlow_Done.CASE4 = null;
            this.InitialFlow_Done.ContinueRun = false;
            this.InitialFlow_Done.DesignTimeParent = null;
            this.InitialFlow_Done.EndFC = null;
            this.InitialFlow_Done.ErrID = 0;
            this.InitialFlow_Done.InAlarm = false;
            this.InitialFlow_Done.IsFlowHead = false;
            this.InitialFlow_Done.Location = new System.Drawing.Point(101, 249);
            this.InitialFlow_Done.LockUI = false;
            this.InitialFlow_Done.Message = null;
            this.InitialFlow_Done.MsgID = 0;
            this.InitialFlow_Done.Name = "InitialFlow_Done";
            this.InitialFlow_Done.NEXT = null;
            this.InitialFlow_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.InitialFlow_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.InitialFlow_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.InitialFlow_Done.OverTimeSpec = 100;
            this.InitialFlow_Done.Running = false;
            this.InitialFlow_Done.Size = new System.Drawing.Size(266, 30);
            this.InitialFlow_Done.SlowRunCycle = -1;
            this.InitialFlow_Done.StartFC = null;
            this.InitialFlow_Done.Text = "Initial Done";
            this.InitialFlow_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.InitialFlow_Done_Run);
            // 
            // InitialFlow_Strat
            // 
            this.InitialFlow_Strat.BackColor = System.Drawing.Color.RoyalBlue;
            this.InitialFlow_Strat.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.InitialFlow_Strat.CASE1 = null;
            this.InitialFlow_Strat.CASE2 = null;
            this.InitialFlow_Strat.CASE3 = null;
            this.InitialFlow_Strat.CASE4 = null;
            this.InitialFlow_Strat.ContinueRun = false;
            this.InitialFlow_Strat.DesignTimeParent = null;
            this.InitialFlow_Strat.EndFC = null;
            this.InitialFlow_Strat.ErrID = 0;
            this.InitialFlow_Strat.InAlarm = false;
            this.InitialFlow_Strat.IsFlowHead = false;
            this.InitialFlow_Strat.Location = new System.Drawing.Point(101, 191);
            this.InitialFlow_Strat.LockUI = false;
            this.InitialFlow_Strat.Message = null;
            this.InitialFlow_Strat.MsgID = 0;
            this.InitialFlow_Strat.Name = "InitialFlow_Strat";
            this.InitialFlow_Strat.NEXT = this.InitialFlow_Done;
            this.InitialFlow_Strat.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.InitialFlow_Strat.OrgLocation = new System.Drawing.Point(0, 0);
            this.InitialFlow_Strat.OrgSize = new System.Drawing.Size(0, 0);
            this.InitialFlow_Strat.OverTimeSpec = 100;
            this.InitialFlow_Strat.Running = false;
            this.InitialFlow_Strat.Size = new System.Drawing.Size(266, 30);
            this.InitialFlow_Strat.SlowRunCycle = -1;
            this.InitialFlow_Strat.StartFC = null;
            this.InitialFlow_Strat.Text = "Initial Start";
            this.InitialFlow_Strat.Run += new ProVLib.FlowChart.RunEventHandler(this.InitialFlow_Strat_Run);
            // 
            // InitialFlow_Check
            // 
            this.InitialFlow_Check.BackColor = System.Drawing.Color.RoyalBlue;
            this.InitialFlow_Check.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.InitialFlow_Check.CASE1 = null;
            this.InitialFlow_Check.CASE2 = null;
            this.InitialFlow_Check.CASE3 = null;
            this.InitialFlow_Check.CASE4 = null;
            this.InitialFlow_Check.ContinueRun = false;
            this.InitialFlow_Check.DesignTimeParent = null;
            this.InitialFlow_Check.EndFC = null;
            this.InitialFlow_Check.ErrID = 0;
            this.InitialFlow_Check.InAlarm = false;
            this.InitialFlow_Check.IsFlowHead = false;
            this.InitialFlow_Check.Location = new System.Drawing.Point(101, 133);
            this.InitialFlow_Check.LockUI = false;
            this.InitialFlow_Check.Message = null;
            this.InitialFlow_Check.MsgID = 0;
            this.InitialFlow_Check.Name = "InitialFlow_Check";
            this.InitialFlow_Check.NEXT = this.InitialFlow_Strat;
            this.InitialFlow_Check.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.InitialFlow_Check.OrgLocation = new System.Drawing.Point(0, 0);
            this.InitialFlow_Check.OrgSize = new System.Drawing.Size(0, 0);
            this.InitialFlow_Check.OverTimeSpec = 100;
            this.InitialFlow_Check.Running = false;
            this.InitialFlow_Check.Size = new System.Drawing.Size(266, 30);
            this.InitialFlow_Check.SlowRunCycle = -1;
            this.InitialFlow_Check.StartFC = null;
            this.InitialFlow_Check.Text = "Initial Can Start Check";
            this.InitialFlow_Check.Run += new ProVLib.FlowChart.RunEventHandler(this.InitialFlow_Check_Run);
            // 
            // InitialFlow
            // 
            this.InitialFlow.BackColor = System.Drawing.Color.RoyalBlue;
            this.InitialFlow.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.InitialFlow.CASE1 = null;
            this.InitialFlow.CASE2 = null;
            this.InitialFlow.CASE3 = null;
            this.InitialFlow.CASE4 = null;
            this.InitialFlow.ContinueRun = false;
            this.InitialFlow.DesignTimeParent = null;
            this.InitialFlow.EndFC = null;
            this.InitialFlow.ErrID = 0;
            this.InitialFlow.InAlarm = false;
            this.InitialFlow.IsFlowHead = false;
            this.InitialFlow.Location = new System.Drawing.Point(101, 75);
            this.InitialFlow.LockUI = false;
            this.InitialFlow.Message = null;
            this.InitialFlow.MsgID = 0;
            this.InitialFlow.Name = "InitialFlow";
            this.InitialFlow.NEXT = this.InitialFlow_Check;
            this.InitialFlow.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.InitialFlow.OrgLocation = new System.Drawing.Point(0, 0);
            this.InitialFlow.OrgSize = new System.Drawing.Size(0, 0);
            this.InitialFlow.OverTimeSpec = 100;
            this.InitialFlow.Running = false;
            this.InitialFlow.Size = new System.Drawing.Size(266, 30);
            this.InitialFlow.SlowRunCycle = -1;
            this.InitialFlow.StartFC = null;
            this.InitialFlow.Text = "Initial Flow";
            this.InitialFlow.Run += new ProVLib.FlowChart.RunEventHandler(this.InitialFlow_Run);
            // 
            // BaseMainFlowFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 674);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseMainFlowFrom";
            this.Text = "BaseMainFlowFrom";
            this.tabControl1.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tpAuto;
        public System.Windows.Forms.TabPage tpHome;
        public System.Windows.Forms.TabPage tabPage1;
        public ProVLib.FlowChart InitialFlow_Done;
        public ProVLib.FlowChart InitialFlow_Strat;
        public ProVLib.FlowChart InitialFlow_Check;
        public ProVLib.FlowChart InitialFlow;
    }
}