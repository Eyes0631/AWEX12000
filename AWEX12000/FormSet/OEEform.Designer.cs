namespace ProVSimpleProject
{
    partial class OEEform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OEEform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reAnalyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.calculationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmGroupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbOEEprogress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastEditDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcOEE = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chartQty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMUBA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAvailability = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOperationTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.tbOEE = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbAlarmDailyCount = new System.Windows.Forms.TextBox();
            this.tmUpdateData = new System.Windows.Forms.Timer(this.components);
            this.tmUpdateStatus = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tcOEE.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMUBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseHover += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reAnalyseToolStripMenuItem,
            this.toolStripMenuItem2,
            this.calculationTypeToolStripMenuItem,
            this.alarmGroupByToolStripMenuItem,
            this.exportToolStripMenuItem1});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // reAnalyseToolStripMenuItem
            // 
            this.reAnalyseToolStripMenuItem.Name = "reAnalyseToolStripMenuItem";
            this.reAnalyseToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.reAnalyseToolStripMenuItem.Text = "Re-Analyse";
            this.reAnalyseToolStripMenuItem.Click += new System.EventHandler(this.reAnalyseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // calculationTypeToolStripMenuItem
            // 
            this.calculationTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overallToolStripMenuItem,
            this.dailyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.yearlyToolStripMenuItem});
            this.calculationTypeToolStripMenuItem.Name = "calculationTypeToolStripMenuItem";
            this.calculationTypeToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.calculationTypeToolStripMenuItem.Text = "Production Period";
            // 
            // overallToolStripMenuItem
            // 
            this.overallToolStripMenuItem.CheckOnClick = true;
            this.overallToolStripMenuItem.Name = "overallToolStripMenuItem";
            this.overallToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.overallToolStripMenuItem.Text = "Overall";
            this.overallToolStripMenuItem.Click += new System.EventHandler(this.overallToolStripMenuItem_Click);
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.CheckOnClick = true;
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.dailyToolStripMenuItem.Text = "Daily";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.overallToolStripMenuItem_Click);
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Checked = true;
            this.weeklyToolStripMenuItem.CheckOnClick = true;
            this.weeklyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.weeklyToolStripMenuItem.Text = "Weekly";
            this.weeklyToolStripMenuItem.Click += new System.EventHandler(this.overallToolStripMenuItem_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.CheckOnClick = true;
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.overallToolStripMenuItem_Click);
            // 
            // yearlyToolStripMenuItem
            // 
            this.yearlyToolStripMenuItem.CheckOnClick = true;
            this.yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            this.yearlyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.yearlyToolStripMenuItem.Text = "Yearly";
            this.yearlyToolStripMenuItem.Click += new System.EventHandler(this.overallToolStripMenuItem_Click);
            // 
            // alarmGroupByToolStripMenuItem
            // 
            this.alarmGroupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenuItem,
            this.errorCodeToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.alarmGroupByToolStripMenuItem.Name = "alarmGroupByToolStripMenuItem";
            this.alarmGroupByToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.alarmGroupByToolStripMenuItem.Text = "Alarm Group By";
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.CheckOnClick = true;
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.moduleToolStripMenuItem.Text = "Module";
            this.moduleToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // errorCodeToolStripMenuItem
            // 
            this.errorCodeToolStripMenuItem.CheckOnClick = true;
            this.errorCodeToolStripMenuItem.Name = "errorCodeToolStripMenuItem";
            this.errorCodeToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.errorCodeToolStripMenuItem.Text = "Error Code";
            this.errorCodeToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Checked = true;
            this.messageToolStripMenuItem.CheckOnClick = true;
            this.messageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(231, 24);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // openLogFileDialog
            // 
            this.openLogFileDialog.FileName = "openFileDialog1";
            // 
            // dgvAlarms
            // 
            this.dgvAlarms.AllowUserToAddRows = false;
            this.dgvAlarms.AllowUserToDeleteRows = false;
            this.dgvAlarms.AllowUserToResizeColumns = false;
            this.dgvAlarms.AllowUserToResizeRows = false;
            this.dgvAlarms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlarms.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvAlarms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlarms.ColumnHeadersHeight = 50;
            this.dgvAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Module,
            this.ErrorCode,
            this.AlarmMessage,
            this.Count,
            this.Percentage,
            this.CumulativePercentage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarms.EnableHeadersVisualStyles = false;
            this.dgvAlarms.Location = new System.Drawing.Point(3, 3);
            this.dgvAlarms.Name = "dgvAlarms";
            this.dgvAlarms.ReadOnly = true;
            this.dgvAlarms.RowHeadersVisible = false;
            this.dgvAlarms.RowTemplate.Height = 24;
            this.dgvAlarms.Size = new System.Drawing.Size(1120, 715);
            this.dgvAlarms.TabIndex = 1;
            this.dgvAlarms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmsGropubyMsg_CellClick);
            this.dgvAlarms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmsGropubyMsg_CellDoubleClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 80;
            // 
            // Module
            // 
            this.Module.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            this.Module.ReadOnly = true;
            this.Module.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Module.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ErrorCode
            // 
            this.ErrorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ErrorCode.HeaderText = "Error Code";
            this.ErrorCode.Name = "ErrorCode";
            this.ErrorCode.ReadOnly = true;
            this.ErrorCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ErrorCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AlarmMessage
            // 
            this.AlarmMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AlarmMessage.DefaultCellStyle = dataGridViewCellStyle2;
            this.AlarmMessage.HeaderText = "Alarm Message";
            this.AlarmMessage.Name = "AlarmMessage";
            this.AlarmMessage.ReadOnly = true;
            this.AlarmMessage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlarmMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlarmMessage.Width = 500;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.Width = 80;
            // 
            // Percentage
            // 
            this.Percentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            this.Percentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Percentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Percentage.Width = 120;
            // 
            // CumulativePercentage
            // 
            this.CumulativePercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CumulativePercentage.HeaderText = "Cumulative Percentage";
            this.CumulativePercentage.Name = "CumulativePercentage";
            this.CumulativePercentage.ReadOnly = true;
            this.CumulativePercentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CumulativePercentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CumulativePercentage.Width = 120;
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.tsslStatus,
            this.tspbOEEprogress,
            this.toolStripStatusLabel2,
            this.tsslVersion,
            this.toolStripStatusLabel4,
            this.tsslLastEditDate,
            this.toolStripStatusLabel5,
            this.tsslAuthor});
            this.statusStrip.Location = new System.Drawing.Point(0, 781);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1384, 30);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.AutoSize = false;
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel7.Text = "Status";
            // 
            // tsslStatus
            // 
            this.tsslStatus.AutoSize = false;
            this.tsslStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(727, 25);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "顯示目前狀態";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbOEEprogress
            // 
            this.tspbOEEprogress.Name = "tspbOEEprogress";
            this.tspbOEEprogress.Size = new System.Drawing.Size(100, 24);
            this.tspbOEEprogress.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel2.Text = "Version";
            // 
            // tsslVersion
            // 
            this.tsslVersion.AutoSize = false;
            this.tsslVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(100, 25);
            this.tsslVersion.Text = "最新版次";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel4.Text = "Date";
            // 
            // tsslLastEditDate
            // 
            this.tsslLastEditDate.AutoSize = false;
            this.tsslLastEditDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslLastEditDate.Name = "tsslLastEditDate";
            this.tsslLastEditDate.Size = new System.Drawing.Size(100, 25);
            this.tsslLastEditDate.Text = "最後修改日期";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel5.Text = "Author";
            // 
            // tsslAuthor
            // 
            this.tsslAuthor.AutoSize = false;
            this.tsslAuthor.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslAuthor.Name = "tsslAuthor";
            this.tsslAuthor.Size = new System.Drawing.Size(100, 25);
            this.tsslAuthor.Text = "作者";
            // 
            // tcOEE
            // 
            this.tcOEE.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcOEE.Controls.Add(this.tabPage3);
            this.tcOEE.Controls.Add(this.tabPage1);
            this.tcOEE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOEE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOEE.ItemSize = new System.Drawing.Size(130, 25);
            this.tcOEE.Location = new System.Drawing.Point(0, 27);
            this.tcOEE.Name = "tcOEE";
            this.tcOEE.SelectedIndex = 0;
            this.tcOEE.Size = new System.Drawing.Size(1384, 754);
            this.tcOEE.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOEE.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Controls.Add(this.dgvProduction);
            this.tabPage3.Controls.Add(this.tbOEE);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1376, 721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Production";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Controls.Add(this.chartQty);
            this.flowLayoutPanel1.Controls.Add(this.chartUPH);
            this.flowLayoutPanel1.Controls.Add(this.chartYield);
            this.flowLayoutPanel1.Controls.Add(this.chartMUBA);
            this.flowLayoutPanel1.Controls.Add(this.chartAvailability);
            this.flowLayoutPanel1.Controls.Add(this.chartOperationTime);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 270);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1376, 451);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // chartQty
            // 
            this.chartQty.BackColor = System.Drawing.Color.DimGray;
            this.chartQty.BorderlineColor = System.Drawing.Color.Gold;
            this.chartQty.Location = new System.Drawing.Point(3, 3);
            this.chartQty.Name = "chartQty";
            this.chartQty.Size = new System.Drawing.Size(300, 225);
            this.chartQty.TabIndex = 4;
            // 
            // chartUPH
            // 
            this.chartUPH.BackColor = System.Drawing.Color.DimGray;
            this.chartUPH.BorderlineColor = System.Drawing.Color.Gold;
            this.chartUPH.Location = new System.Drawing.Point(309, 3);
            this.chartUPH.Name = "chartUPH";
            this.chartUPH.Size = new System.Drawing.Size(300, 225);
            this.chartUPH.TabIndex = 8;
            // 
            // chartYield
            // 
            this.chartYield.BackColor = System.Drawing.Color.DimGray;
            this.chartYield.BorderlineColor = System.Drawing.Color.Gold;
            this.chartYield.Location = new System.Drawing.Point(615, 3);
            this.chartYield.Name = "chartYield";
            this.chartYield.Size = new System.Drawing.Size(300, 225);
            this.chartYield.TabIndex = 5;
            // 
            // chartMUBA
            // 
            this.chartMUBA.BackColor = System.Drawing.Color.DimGray;
            this.chartMUBA.BorderlineColor = System.Drawing.Color.Gold;
            this.chartMUBA.Location = new System.Drawing.Point(921, 3);
            this.chartMUBA.Name = "chartMUBA";
            this.chartMUBA.Size = new System.Drawing.Size(300, 225);
            this.chartMUBA.TabIndex = 9;
            // 
            // chartAvailability
            // 
            this.chartAvailability.BackColor = System.Drawing.Color.DimGray;
            this.chartAvailability.BorderlineColor = System.Drawing.Color.Gold;
            this.chartAvailability.Location = new System.Drawing.Point(3, 234);
            this.chartAvailability.Name = "chartAvailability";
            this.chartAvailability.Size = new System.Drawing.Size(300, 225);
            this.chartAvailability.TabIndex = 7;
            // 
            // chartOperationTime
            // 
            this.chartOperationTime.BackColor = System.Drawing.Color.DimGray;
            this.chartOperationTime.BorderlineColor = System.Drawing.Color.Gold;
            this.chartOperationTime.Location = new System.Drawing.Point(309, 234);
            this.chartOperationTime.Name = "chartOperationTime";
            this.chartOperationTime.Size = new System.Drawing.Size(300, 225);
            this.chartOperationTime.TabIndex = 10;
            // 
            // dgvProduction
            // 
            this.dgvProduction.AllowUserToAddRows = false;
            this.dgvProduction.AllowUserToDeleteRows = false;
            this.dgvProduction.AllowUserToResizeColumns = false;
            this.dgvProduction.AllowUserToResizeRows = false;
            this.dgvProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProduction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduction.EnableHeadersVisualStyles = false;
            this.dgvProduction.Location = new System.Drawing.Point(0, 60);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.ReadOnly = true;
            this.dgvProduction.RowHeadersVisible = false;
            this.dgvProduction.RowTemplate.Height = 24;
            this.dgvProduction.Size = new System.Drawing.Size(1376, 210);
            this.dgvProduction.TabIndex = 0;
            // 
            // tbOEE
            // 
            this.tbOEE.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOEE.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOEE.Location = new System.Drawing.Point(0, 0);
            this.tbOEE.Multiline = true;
            this.tbOEE.Name = "tbOEE";
            this.tbOEE.ReadOnly = true;
            this.tbOEE.Size = new System.Drawing.Size(1376, 60);
            this.tbOEE.TabIndex = 3;
            this.tbOEE.Text = "Overview";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAlarms);
            this.tabPage1.Controls.Add(this.tbAlarmDailyCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1376, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarm List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbAlarmDailyCount
            // 
            this.tbAlarmDailyCount.BackColor = System.Drawing.Color.DimGray;
            this.tbAlarmDailyCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbAlarmDailyCount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlarmDailyCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbAlarmDailyCount.Location = new System.Drawing.Point(1123, 3);
            this.tbAlarmDailyCount.Multiline = true;
            this.tbAlarmDailyCount.Name = "tbAlarmDailyCount";
            this.tbAlarmDailyCount.ReadOnly = true;
            this.tbAlarmDailyCount.Size = new System.Drawing.Size(250, 715);
            this.tbAlarmDailyCount.TabIndex = 3;
            // 
            // tmUpdateData
            // 
            this.tmUpdateData.Interval = 10;
            this.tmUpdateData.Tick += new System.EventHandler(this.tmUpdateData_Tick);
            // 
            // tmUpdateStatus
            // 
            this.tmUpdateStatus.Tick += new System.EventHandler(this.tmUpdateStatus_Tick);
            // 
            // OEEform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 811);
            this.Controls.Add(this.tcOEE);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OEEform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEE performance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OEEform_FormClosing);
            this.Load += new System.EventHandler(this.OEEform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tcOEE.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMUBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openLogFileDialog;
        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastEditDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsslAuthor;
        private System.Windows.Forms.TabControl tcOEE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbAlarmDailyCount;
        private System.Windows.Forms.Timer tmUpdateData;
        private System.Windows.Forms.ToolStripProgressBar tspbOEEprogress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.TextBox tbOEE;
        private System.Windows.Forms.ToolStripMenuItem calculationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmGroupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reAnalyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Timer tmUpdateStatus;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativePercentage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQty;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvailability;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUPH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMUBA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOperationTime;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
    }
}

