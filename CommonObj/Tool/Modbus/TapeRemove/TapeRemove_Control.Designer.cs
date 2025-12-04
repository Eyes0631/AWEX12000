namespace CommonObj.ModbusTCP.TapeRemove
{
    partial class TapeRemove_Control
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.led_RB_CV1_Out_Request = new KCSDK.LEDLabel();
            this.led_RB_CV1_Out_Busy = new KCSDK.LEDLabel();
            this.led_RB_CV1_Out_Complete = new KCSDK.LEDLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.led_RB_Pause = new KCSDK.LEDLabel();
            this.led_RB_Ready = new KCSDK.LEDLabel();
            this.led_RB_CV1_DoDeTape = new KCSDK.LEDLabel();
            this.led_TOOL_Pause = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Ready = new KCSDK.LEDLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.FC_DeTapeStatus_Next = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_CheckConnect = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_Connect = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_ReadToolStatus = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_ReadToolStatusDone = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_UpdateData = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_WriteRobotStatus = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_WriteRobotStatusDone = new ProVLib.FlowChart();
            this.FC_DeTapeStatus_Start = new ProVLib.FlowChart();
            this.tp_Signal = new System.Windows.Forms.TabPage();
            this.lb_RB_WaferSize = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lb_TOOL_WaferSize = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lb_MachineMode = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.led_RB_NotifyInitial = new KCSDK.LEDLabel();
            this.led_RB_CV1_DoReject = new KCSDK.LEDLabel();
            this.led_RB_CV2_DoReject = new KCSDK.LEDLabel();
            this.led_TOOL_Alarm = new KCSDK.LEDLabel();
            this.led_TOOL_InitailDone = new KCSDK.LEDLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.led_TOOL_CV2_Cut_Use = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Use = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_DeTapeNG = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_CutNG = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_AlignEnd = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_AlignStart = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_CutArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_LaserArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_DeTapeArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_RollerDown_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_DeTape_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_RollerDown_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_DeTape_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_LaserMeasurement_OK = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Cut_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Cut_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_CCD_CheckCutOK = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Receive_Permission = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Receive_Complete = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Receive_Busy = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Out_Request = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Out_Complete = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Out_Busy = new KCSDK.LEDLabel();
            this.led_TOOL_CV2_Ready = new KCSDK.LEDLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.led_TOOL_CV1_Cut_Use = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Use = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_DeTapeNG = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_CutNG = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_AlignEnd = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_AlignStart = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_CutArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_LaserArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_DeTapeArmIsSafe = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_RollerDown_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_DeTape_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_RollerDown_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_DeTape_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_LaserMeasurement_OK = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Cut_End = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Cut_Start = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_CCD_CheckCutOK = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Receive_Permission = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Receive_Complete = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Receive_Busy = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Out_Request = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Out_Complete = new KCSDK.LEDLabel();
            this.led_TOOL_CV1_Out_Busy = new KCSDK.LEDLabel();
            this.led_RB_CV2_Receive_Permission = new KCSDK.LEDLabel();
            this.led_RB_CV2_Receive_Complete = new KCSDK.LEDLabel();
            this.led_RB_CV2_Receive_Busy = new KCSDK.LEDLabel();
            this.led_RB_CV2_Out_Request = new KCSDK.LEDLabel();
            this.led_RB_CV2_Out_Complete = new KCSDK.LEDLabel();
            this.led_RB_CV2_Out_Busy = new KCSDK.LEDLabel();
            this.led_RB_CV2_DoDeTape = new KCSDK.LEDLabel();
            this.led_RB_CV1_Receive_Permission = new KCSDK.LEDLabel();
            this.led_RB_CV1_Receive_Complete = new KCSDK.LEDLabel();
            this.led_RB_CV1_Receive_Busy = new KCSDK.LEDLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_AlarmCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lb_CV2_DeTape_Current_Axiz18 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_CV1_DeTape_Current_Axiz18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_CV2_ESD = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_CV1_ESD = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_CV2_CCD_DeTapeResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_CV2_CCD_CutResult = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_CV2_CutNeedles_UseCount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_CV2_DeTape_Current_Axiz17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lb_CV2_CutNeedles_Current = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lb_CV2_LaserMeasurementData = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lb_CV1_CCD_DeTapeResult = new System.Windows.Forms.Label();
            this.lable21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lb_CV1_CCD_CutResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_CV1_CutNeedles_UseCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_CV1_DeTape_Current_Axiz17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_CV1_CutNeedles_Current = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_CV1_LaserMeasurementData = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_RollerDownPressure = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TapeUseCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.led_RB_CV1_DoUnloadLoad = new KCSDK.LEDLabel();
            this.led_RB_CV2_DoUnloadLoad = new KCSDK.LEDLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tp_Signal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 227);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1137, 307);
            this.textBox1.TabIndex = 13;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(145, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(116, 35);
            this.btnDisconnect.TabIndex = 16;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(26, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 35);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // led_RB_CV1_Out_Request
            // 
            this.led_RB_CV1_Out_Request.Caption = "RB CV1 出片要求";
            this.led_RB_CV1_Out_Request.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Out_Request.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Out_Request.Location = new System.Drawing.Point(25, 95);
            this.led_RB_CV1_Out_Request.Name = "led_RB_CV1_Out_Request";
            this.led_RB_CV1_Out_Request.Size = new System.Drawing.Size(190, 30);
            this.led_RB_CV1_Out_Request.TabIndex = 116;
            this.led_RB_CV1_Out_Request.Value = false;
            // 
            // led_RB_CV1_Out_Busy
            // 
            this.led_RB_CV1_Out_Busy.Caption = "RB CV1 出片中";
            this.led_RB_CV1_Out_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Out_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Out_Busy.Location = new System.Drawing.Point(25, 130);
            this.led_RB_CV1_Out_Busy.Name = "led_RB_CV1_Out_Busy";
            this.led_RB_CV1_Out_Busy.Size = new System.Drawing.Size(190, 30);
            this.led_RB_CV1_Out_Busy.TabIndex = 117;
            this.led_RB_CV1_Out_Busy.Value = false;
            // 
            // led_RB_CV1_Out_Complete
            // 
            this.led_RB_CV1_Out_Complete.Caption = "RB CV1 出片完畢";
            this.led_RB_CV1_Out_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Out_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Out_Complete.Location = new System.Drawing.Point(25, 165);
            this.led_RB_CV1_Out_Complete.Name = "led_RB_CV1_Out_Complete";
            this.led_RB_CV1_Out_Complete.Size = new System.Drawing.Size(190, 30);
            this.led_RB_CV1_Out_Complete.TabIndex = 118;
            this.led_RB_CV1_Out_Complete.Value = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 119;
            this.label1.Text = "Robot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "撕膜機";
            // 
            // led_RB_Pause
            // 
            this.led_RB_Pause.Caption = "暫停";
            this.led_RB_Pause.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_Pause.CpationColor = System.Drawing.Color.Black;
            this.led_RB_Pause.Location = new System.Drawing.Point(232, 60);
            this.led_RB_Pause.Name = "led_RB_Pause";
            this.led_RB_Pause.Size = new System.Drawing.Size(146, 30);
            this.led_RB_Pause.TabIndex = 123;
            this.led_RB_Pause.Value = false;
            // 
            // led_RB_Ready
            // 
            this.led_RB_Ready.Caption = "RB Ready";
            this.led_RB_Ready.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_Ready.CpationColor = System.Drawing.Color.Black;
            this.led_RB_Ready.Location = new System.Drawing.Point(25, 60);
            this.led_RB_Ready.Name = "led_RB_Ready";
            this.led_RB_Ready.Size = new System.Drawing.Size(190, 30);
            this.led_RB_Ready.TabIndex = 124;
            this.led_RB_Ready.Value = false;
            // 
            // led_RB_CV1_DoDeTape
            // 
            this.led_RB_CV1_DoDeTape.Caption = "RB CV1 執行撕膜動作";
            this.led_RB_CV1_DoDeTape.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_DoDeTape.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_DoDeTape.Location = new System.Drawing.Point(25, 200);
            this.led_RB_CV1_DoDeTape.Name = "led_RB_CV1_DoDeTape";
            this.led_RB_CV1_DoDeTape.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV1_DoDeTape.TabIndex = 125;
            this.led_RB_CV1_DoDeTape.Value = false;
            // 
            // led_TOOL_Pause
            // 
            this.led_TOOL_Pause.Caption = "暫停";
            this.led_TOOL_Pause.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_Pause.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_Pause.Location = new System.Drawing.Point(410, 60);
            this.led_TOOL_Pause.Name = "led_TOOL_Pause";
            this.led_TOOL_Pause.Size = new System.Drawing.Size(146, 30);
            this.led_TOOL_Pause.TabIndex = 132;
            this.led_TOOL_Pause.Value = false;
            // 
            // led_TOOL_CV1_Ready
            // 
            this.led_TOOL_CV1_Ready.Caption = "TOOL CV1 Ready";
            this.led_TOOL_CV1_Ready.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Ready.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Ready.Location = new System.Drawing.Point(15, 25);
            this.led_TOOL_CV1_Ready.Name = "led_TOOL_CV1_Ready";
            this.led_TOOL_CV1_Ready.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Ready.TabIndex = 140;
            this.led_TOOL_CV1_Ready.Value = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tp_Signal);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1576, 900);
            this.tabControl1.TabIndex = 122;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_Next);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_UpdateData);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_WriteRobotStatusDone);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_WriteRobotStatus);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_ReadToolStatusDone);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_ReadToolStatus);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_Connect);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_CheckConnect);
            this.tabPage1.Controls.Add(this.FC_DeTapeStatus_Start);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnDisconnect);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1568, 865);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FC_DeTapeStatus_Next
            // 
            this.FC_DeTapeStatus_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_Next.CASE1 = null;
            this.FC_DeTapeStatus_Next.CASE2 = null;
            this.FC_DeTapeStatus_Next.CASE3 = null;
            this.FC_DeTapeStatus_Next.CASE4 = null;
            this.FC_DeTapeStatus_Next.ContinueRun = false;
            this.FC_DeTapeStatus_Next.EndFC = null;
            this.FC_DeTapeStatus_Next.ErrID = 0;
            this.FC_DeTapeStatus_Next.InAlarm = false;
            this.FC_DeTapeStatus_Next.IsFlowHead = false;
            this.FC_DeTapeStatus_Next.Location = new System.Drawing.Point(1093, 187);
            this.FC_DeTapeStatus_Next.LockUI = false;
            this.FC_DeTapeStatus_Next.Message = null;
            this.FC_DeTapeStatus_Next.MsgID = 0;
            this.FC_DeTapeStatus_Next.Name = "FC_DeTapeStatus_Next";
            this.FC_DeTapeStatus_Next.NEXT = this.FC_DeTapeStatus_CheckConnect;
            this.FC_DeTapeStatus_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_Next.OverTimeSpec = 100;
            this.FC_DeTapeStatus_Next.Running = false;
            this.FC_DeTapeStatus_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_DeTapeStatus_Next.SlowRunCycle = -1;
            this.FC_DeTapeStatus_Next.StartFC = null;
            this.FC_DeTapeStatus_Next.Text = "Next";
            this.FC_DeTapeStatus_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_Next_Run);
            // 
            // FC_DeTapeStatus_CheckConnect
            // 
            this.FC_DeTapeStatus_CheckConnect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_CheckConnect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_CheckConnect.CASE1 = this.FC_DeTapeStatus_Connect;
            this.FC_DeTapeStatus_CheckConnect.CASE2 = null;
            this.FC_DeTapeStatus_CheckConnect.CASE3 = null;
            this.FC_DeTapeStatus_CheckConnect.CASE4 = null;
            this.FC_DeTapeStatus_CheckConnect.ContinueRun = false;
            this.FC_DeTapeStatus_CheckConnect.EndFC = null;
            this.FC_DeTapeStatus_CheckConnect.ErrID = 0;
            this.FC_DeTapeStatus_CheckConnect.InAlarm = false;
            this.FC_DeTapeStatus_CheckConnect.IsFlowHead = false;
            this.FC_DeTapeStatus_CheckConnect.Location = new System.Drawing.Point(860, 47);
            this.FC_DeTapeStatus_CheckConnect.LockUI = false;
            this.FC_DeTapeStatus_CheckConnect.Message = null;
            this.FC_DeTapeStatus_CheckConnect.MsgID = 0;
            this.FC_DeTapeStatus_CheckConnect.Name = "FC_DeTapeStatus_CheckConnect";
            this.FC_DeTapeStatus_CheckConnect.NEXT = this.FC_DeTapeStatus_ReadToolStatus;
            this.FC_DeTapeStatus_CheckConnect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_CheckConnect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_CheckConnect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_CheckConnect.OverTimeSpec = 100;
            this.FC_DeTapeStatus_CheckConnect.Running = false;
            this.FC_DeTapeStatus_CheckConnect.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_CheckConnect.SlowRunCycle = -1;
            this.FC_DeTapeStatus_CheckConnect.StartFC = null;
            this.FC_DeTapeStatus_CheckConnect.Text = "確認連線";
            this.FC_DeTapeStatus_CheckConnect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_CheckConnect_Run);
            // 
            // FC_DeTapeStatus_Connect
            // 
            this.FC_DeTapeStatus_Connect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_Connect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_Connect.CASE1 = null;
            this.FC_DeTapeStatus_Connect.CASE2 = null;
            this.FC_DeTapeStatus_Connect.CASE3 = null;
            this.FC_DeTapeStatus_Connect.CASE4 = null;
            this.FC_DeTapeStatus_Connect.ContinueRun = false;
            this.FC_DeTapeStatus_Connect.EndFC = null;
            this.FC_DeTapeStatus_Connect.ErrID = 0;
            this.FC_DeTapeStatus_Connect.InAlarm = false;
            this.FC_DeTapeStatus_Connect.IsFlowHead = false;
            this.FC_DeTapeStatus_Connect.Location = new System.Drawing.Point(777, 47);
            this.FC_DeTapeStatus_Connect.LockUI = false;
            this.FC_DeTapeStatus_Connect.Message = null;
            this.FC_DeTapeStatus_Connect.MsgID = 0;
            this.FC_DeTapeStatus_Connect.Name = "FC_DeTapeStatus_Connect";
            this.FC_DeTapeStatus_Connect.NEXT = this.FC_DeTapeStatus_CheckConnect;
            this.FC_DeTapeStatus_Connect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_Connect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_Connect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_Connect.OverTimeSpec = 100;
            this.FC_DeTapeStatus_Connect.Running = false;
            this.FC_DeTapeStatus_Connect.Size = new System.Drawing.Size(50, 20);
            this.FC_DeTapeStatus_Connect.SlowRunCycle = -1;
            this.FC_DeTapeStatus_Connect.StartFC = null;
            this.FC_DeTapeStatus_Connect.Text = "連線";
            this.FC_DeTapeStatus_Connect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_Connect_Run);
            // 
            // FC_DeTapeStatus_ReadToolStatus
            // 
            this.FC_DeTapeStatus_ReadToolStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_ReadToolStatus.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_ReadToolStatus.CASE1 = null;
            this.FC_DeTapeStatus_ReadToolStatus.CASE2 = null;
            this.FC_DeTapeStatus_ReadToolStatus.CASE3 = null;
            this.FC_DeTapeStatus_ReadToolStatus.CASE4 = null;
            this.FC_DeTapeStatus_ReadToolStatus.ContinueRun = false;
            this.FC_DeTapeStatus_ReadToolStatus.EndFC = null;
            this.FC_DeTapeStatus_ReadToolStatus.ErrID = 0;
            this.FC_DeTapeStatus_ReadToolStatus.InAlarm = false;
            this.FC_DeTapeStatus_ReadToolStatus.IsFlowHead = false;
            this.FC_DeTapeStatus_ReadToolStatus.Location = new System.Drawing.Point(860, 75);
            this.FC_DeTapeStatus_ReadToolStatus.LockUI = false;
            this.FC_DeTapeStatus_ReadToolStatus.Message = null;
            this.FC_DeTapeStatus_ReadToolStatus.MsgID = 0;
            this.FC_DeTapeStatus_ReadToolStatus.Name = "FC_DeTapeStatus_ReadToolStatus";
            this.FC_DeTapeStatus_ReadToolStatus.NEXT = this.FC_DeTapeStatus_ReadToolStatusDone;
            this.FC_DeTapeStatus_ReadToolStatus.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_ReadToolStatus.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_ReadToolStatus.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_ReadToolStatus.OverTimeSpec = 100;
            this.FC_DeTapeStatus_ReadToolStatus.Running = false;
            this.FC_DeTapeStatus_ReadToolStatus.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_ReadToolStatus.SlowRunCycle = -1;
            this.FC_DeTapeStatus_ReadToolStatus.StartFC = null;
            this.FC_DeTapeStatus_ReadToolStatus.Text = "讀取 Tool 狀態";
            this.FC_DeTapeStatus_ReadToolStatus.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_ReadToolStatus_Run);
            // 
            // FC_DeTapeStatus_ReadToolStatusDone
            // 
            this.FC_DeTapeStatus_ReadToolStatusDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_ReadToolStatusDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_ReadToolStatusDone.CASE1 = this.FC_DeTapeStatus_ReadToolStatus;
            this.FC_DeTapeStatus_ReadToolStatusDone.CASE2 = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.CASE3 = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.CASE4 = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.ContinueRun = false;
            this.FC_DeTapeStatus_ReadToolStatusDone.EndFC = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.ErrID = 0;
            this.FC_DeTapeStatus_ReadToolStatusDone.InAlarm = false;
            this.FC_DeTapeStatus_ReadToolStatusDone.IsFlowHead = false;
            this.FC_DeTapeStatus_ReadToolStatusDone.Location = new System.Drawing.Point(860, 103);
            this.FC_DeTapeStatus_ReadToolStatusDone.LockUI = false;
            this.FC_DeTapeStatus_ReadToolStatusDone.Message = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.MsgID = 0;
            this.FC_DeTapeStatus_ReadToolStatusDone.Name = "FC_DeTapeStatus_ReadToolStatusDone";
            this.FC_DeTapeStatus_ReadToolStatusDone.NEXT = this.FC_DeTapeStatus_UpdateData;
            this.FC_DeTapeStatus_ReadToolStatusDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_ReadToolStatusDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_ReadToolStatusDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_ReadToolStatusDone.OverTimeSpec = 100;
            this.FC_DeTapeStatus_ReadToolStatusDone.Running = false;
            this.FC_DeTapeStatus_ReadToolStatusDone.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_ReadToolStatusDone.SlowRunCycle = -1;
            this.FC_DeTapeStatus_ReadToolStatusDone.StartFC = null;
            this.FC_DeTapeStatus_ReadToolStatusDone.Text = "讀取完成";
            this.FC_DeTapeStatus_ReadToolStatusDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_ReadToolStatusDone_Run);
            // 
            // FC_DeTapeStatus_UpdateData
            // 
            this.FC_DeTapeStatus_UpdateData.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_UpdateData.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_UpdateData.CASE1 = null;
            this.FC_DeTapeStatus_UpdateData.CASE2 = null;
            this.FC_DeTapeStatus_UpdateData.CASE3 = null;
            this.FC_DeTapeStatus_UpdateData.CASE4 = null;
            this.FC_DeTapeStatus_UpdateData.ContinueRun = false;
            this.FC_DeTapeStatus_UpdateData.EndFC = null;
            this.FC_DeTapeStatus_UpdateData.ErrID = 0;
            this.FC_DeTapeStatus_UpdateData.InAlarm = false;
            this.FC_DeTapeStatus_UpdateData.IsFlowHead = false;
            this.FC_DeTapeStatus_UpdateData.Location = new System.Drawing.Point(860, 131);
            this.FC_DeTapeStatus_UpdateData.LockUI = false;
            this.FC_DeTapeStatus_UpdateData.Message = null;
            this.FC_DeTapeStatus_UpdateData.MsgID = 0;
            this.FC_DeTapeStatus_UpdateData.Name = "FC_DeTapeStatus_UpdateData";
            this.FC_DeTapeStatus_UpdateData.NEXT = this.FC_DeTapeStatus_WriteRobotStatus;
            this.FC_DeTapeStatus_UpdateData.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_UpdateData.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_UpdateData.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_UpdateData.OverTimeSpec = 100;
            this.FC_DeTapeStatus_UpdateData.Running = false;
            this.FC_DeTapeStatus_UpdateData.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_UpdateData.SlowRunCycle = -1;
            this.FC_DeTapeStatus_UpdateData.StartFC = null;
            this.FC_DeTapeStatus_UpdateData.Text = "更新資料";
            this.FC_DeTapeStatus_UpdateData.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_UpdateData_Run);
            // 
            // FC_DeTapeStatus_WriteRobotStatus
            // 
            this.FC_DeTapeStatus_WriteRobotStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_WriteRobotStatus.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_WriteRobotStatus.CASE1 = null;
            this.FC_DeTapeStatus_WriteRobotStatus.CASE2 = null;
            this.FC_DeTapeStatus_WriteRobotStatus.CASE3 = null;
            this.FC_DeTapeStatus_WriteRobotStatus.CASE4 = null;
            this.FC_DeTapeStatus_WriteRobotStatus.ContinueRun = false;
            this.FC_DeTapeStatus_WriteRobotStatus.EndFC = null;
            this.FC_DeTapeStatus_WriteRobotStatus.ErrID = 0;
            this.FC_DeTapeStatus_WriteRobotStatus.InAlarm = false;
            this.FC_DeTapeStatus_WriteRobotStatus.IsFlowHead = false;
            this.FC_DeTapeStatus_WriteRobotStatus.Location = new System.Drawing.Point(860, 159);
            this.FC_DeTapeStatus_WriteRobotStatus.LockUI = false;
            this.FC_DeTapeStatus_WriteRobotStatus.Message = null;
            this.FC_DeTapeStatus_WriteRobotStatus.MsgID = 0;
            this.FC_DeTapeStatus_WriteRobotStatus.Name = "FC_DeTapeStatus_WriteRobotStatus";
            this.FC_DeTapeStatus_WriteRobotStatus.NEXT = this.FC_DeTapeStatus_WriteRobotStatusDone;
            this.FC_DeTapeStatus_WriteRobotStatus.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_WriteRobotStatus.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_WriteRobotStatus.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_WriteRobotStatus.OverTimeSpec = 100;
            this.FC_DeTapeStatus_WriteRobotStatus.Running = false;
            this.FC_DeTapeStatus_WriteRobotStatus.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_WriteRobotStatus.SlowRunCycle = -1;
            this.FC_DeTapeStatus_WriteRobotStatus.StartFC = null;
            this.FC_DeTapeStatus_WriteRobotStatus.Text = "寫入 Robot 狀態";
            this.FC_DeTapeStatus_WriteRobotStatus.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_WriteRobotStatus_Run);
            // 
            // FC_DeTapeStatus_WriteRobotStatusDone
            // 
            this.FC_DeTapeStatus_WriteRobotStatusDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_WriteRobotStatusDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_WriteRobotStatusDone.CASE1 = this.FC_DeTapeStatus_WriteRobotStatus;
            this.FC_DeTapeStatus_WriteRobotStatusDone.CASE2 = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.CASE3 = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.CASE4 = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.ContinueRun = false;
            this.FC_DeTapeStatus_WriteRobotStatusDone.EndFC = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.ErrID = 0;
            this.FC_DeTapeStatus_WriteRobotStatusDone.InAlarm = false;
            this.FC_DeTapeStatus_WriteRobotStatusDone.IsFlowHead = false;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Location = new System.Drawing.Point(860, 187);
            this.FC_DeTapeStatus_WriteRobotStatusDone.LockUI = false;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Message = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.MsgID = 0;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Name = "FC_DeTapeStatus_WriteRobotStatusDone";
            this.FC_DeTapeStatus_WriteRobotStatusDone.NEXT = this.FC_DeTapeStatus_Next;
            this.FC_DeTapeStatus_WriteRobotStatusDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_WriteRobotStatusDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_WriteRobotStatusDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_WriteRobotStatusDone.OverTimeSpec = 100;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Running = false;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_WriteRobotStatusDone.SlowRunCycle = -1;
            this.FC_DeTapeStatus_WriteRobotStatusDone.StartFC = null;
            this.FC_DeTapeStatus_WriteRobotStatusDone.Text = "寫入完成";
            this.FC_DeTapeStatus_WriteRobotStatusDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_WriteRobotStatusDone_Run);
            // 
            // FC_DeTapeStatus_Start
            // 
            this.FC_DeTapeStatus_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_DeTapeStatus_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_DeTapeStatus_Start.CASE1 = null;
            this.FC_DeTapeStatus_Start.CASE2 = null;
            this.FC_DeTapeStatus_Start.CASE3 = null;
            this.FC_DeTapeStatus_Start.CASE4 = null;
            this.FC_DeTapeStatus_Start.ContinueRun = false;
            this.FC_DeTapeStatus_Start.EndFC = null;
            this.FC_DeTapeStatus_Start.ErrID = 0;
            this.FC_DeTapeStatus_Start.InAlarm = false;
            this.FC_DeTapeStatus_Start.IsFlowHead = false;
            this.FC_DeTapeStatus_Start.Location = new System.Drawing.Point(860, 19);
            this.FC_DeTapeStatus_Start.LockUI = false;
            this.FC_DeTapeStatus_Start.Message = null;
            this.FC_DeTapeStatus_Start.MsgID = 0;
            this.FC_DeTapeStatus_Start.Name = "FC_DeTapeStatus_Start";
            this.FC_DeTapeStatus_Start.NEXT = this.FC_DeTapeStatus_CheckConnect;
            this.FC_DeTapeStatus_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_DeTapeStatus_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_DeTapeStatus_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_DeTapeStatus_Start.OverTimeSpec = 100;
            this.FC_DeTapeStatus_Start.Running = false;
            this.FC_DeTapeStatus_Start.Size = new System.Drawing.Size(200, 20);
            this.FC_DeTapeStatus_Start.SlowRunCycle = -1;
            this.FC_DeTapeStatus_Start.StartFC = null;
            this.FC_DeTapeStatus_Start.Text = "撕膜機交握";
            this.FC_DeTapeStatus_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_DeTapeStatus_Start_Run);
            // 
            // tp_Signal
            // 
            this.tp_Signal.AutoScroll = true;
            this.tp_Signal.BackColor = System.Drawing.SystemColors.Control;
            this.tp_Signal.Controls.Add(this.led_RB_CV2_DoUnloadLoad);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_DoUnloadLoad);
            this.tp_Signal.Controls.Add(this.lb_RB_WaferSize);
            this.tp_Signal.Controls.Add(this.label37);
            this.tp_Signal.Controls.Add(this.lb_TOOL_WaferSize);
            this.tp_Signal.Controls.Add(this.label36);
            this.tp_Signal.Controls.Add(this.lb_MachineMode);
            this.tp_Signal.Controls.Add(this.label33);
            this.tp_Signal.Controls.Add(this.led_RB_NotifyInitial);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_DoReject);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_DoReject);
            this.tp_Signal.Controls.Add(this.led_TOOL_Alarm);
            this.tp_Signal.Controls.Add(this.led_TOOL_InitailDone);
            this.tp_Signal.Controls.Add(this.groupBox2);
            this.tp_Signal.Controls.Add(this.groupBox1);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Receive_Permission);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Receive_Complete);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Receive_Busy);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Out_Request);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Out_Complete);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_Out_Busy);
            this.tp_Signal.Controls.Add(this.led_RB_CV2_DoDeTape);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Receive_Permission);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Receive_Complete);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Receive_Busy);
            this.tp_Signal.Controls.Add(this.label1);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Out_Request);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Out_Complete);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_Out_Busy);
            this.tp_Signal.Controls.Add(this.label2);
            this.tp_Signal.Controls.Add(this.led_RB_Pause);
            this.tp_Signal.Controls.Add(this.led_RB_Ready);
            this.tp_Signal.Controls.Add(this.led_RB_CV1_DoDeTape);
            this.tp_Signal.Controls.Add(this.led_TOOL_Pause);
            this.tp_Signal.Location = new System.Drawing.Point(4, 31);
            this.tp_Signal.Name = "tp_Signal";
            this.tp_Signal.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Signal.Size = new System.Drawing.Size(1568, 865);
            this.tp_Signal.TabIndex = 1;
            this.tp_Signal.Text = "訊號";
            // 
            // lb_RB_WaferSize
            // 
            this.lb_RB_WaferSize.AutoSize = true;
            this.lb_RB_WaferSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RB_WaferSize.Location = new System.Drawing.Point(233, 174);
            this.lb_RB_WaferSize.Name = "lb_RB_WaferSize";
            this.lb_RB_WaferSize.Size = new System.Drawing.Size(52, 21);
            this.lb_RB_WaferSize.TabIndex = 215;
            this.lb_RB_WaferSize.Text = "None";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label37.Location = new System.Drawing.Point(233, 141);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 21);
            this.label37.TabIndex = 214;
            this.label37.Text = "RB 設定Wafer尺寸:";
            // 
            // lb_TOOL_WaferSize
            // 
            this.lb_TOOL_WaferSize.AutoSize = true;
            this.lb_TOOL_WaferSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TOOL_WaferSize.Location = new System.Drawing.Point(1196, 60);
            this.lb_TOOL_WaferSize.Name = "lb_TOOL_WaferSize";
            this.lb_TOOL_WaferSize.Size = new System.Drawing.Size(52, 21);
            this.lb_TOOL_WaferSize.TabIndex = 213;
            this.lb_TOOL_WaferSize.Text = "None";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label36.Location = new System.Drawing.Point(1049, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(141, 21);
            this.label36.TabIndex = 212;
            this.label36.Text = "撕膜機Wafer尺寸:";
            // 
            // lb_MachineMode
            // 
            this.lb_MachineMode.AutoSize = true;
            this.lb_MachineMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_MachineMode.Location = new System.Drawing.Point(957, 60);
            this.lb_MachineMode.Name = "lb_MachineMode";
            this.lb_MachineMode.Size = new System.Drawing.Size(52, 21);
            this.lb_MachineMode.TabIndex = 211;
            this.lb_MachineMode.Text = "None";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label33.Location = new System.Drawing.Point(857, 60);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 21);
            this.label33.TabIndex = 210;
            this.label33.Text = "撕膜機模式:";
            // 
            // led_RB_NotifyInitial
            // 
            this.led_RB_NotifyInitial.Caption = "通知初始化";
            this.led_RB_NotifyInitial.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_NotifyInitial.CpationColor = System.Drawing.Color.Black;
            this.led_RB_NotifyInitial.Location = new System.Drawing.Point(232, 95);
            this.led_RB_NotifyInitial.Name = "led_RB_NotifyInitial";
            this.led_RB_NotifyInitial.Size = new System.Drawing.Size(146, 30);
            this.led_RB_NotifyInitial.TabIndex = 209;
            this.led_RB_NotifyInitial.Value = false;
            // 
            // led_RB_CV1_DoReject
            // 
            this.led_RB_CV1_DoReject.Caption = "RB CV1 執行出片動作";
            this.led_RB_CV1_DoReject.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_DoReject.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_DoReject.Location = new System.Drawing.Point(25, 235);
            this.led_RB_CV1_DoReject.Name = "led_RB_CV1_DoReject";
            this.led_RB_CV1_DoReject.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV1_DoReject.TabIndex = 208;
            this.led_RB_CV1_DoReject.Value = false;
            // 
            // led_RB_CV2_DoReject
            // 
            this.led_RB_CV2_DoReject.Caption = "RB CV2 執行出片動作";
            this.led_RB_CV2_DoReject.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_DoReject.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_DoReject.Location = new System.Drawing.Point(25, 585);
            this.led_RB_CV2_DoReject.Name = "led_RB_CV2_DoReject";
            this.led_RB_CV2_DoReject.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV2_DoReject.TabIndex = 207;
            this.led_RB_CV2_DoReject.Value = false;
            // 
            // led_TOOL_Alarm
            // 
            this.led_TOOL_Alarm.Caption = "Alarm";
            this.led_TOOL_Alarm.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_Alarm.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_Alarm.Location = new System.Drawing.Point(730, 60);
            this.led_TOOL_Alarm.Name = "led_TOOL_Alarm";
            this.led_TOOL_Alarm.Size = new System.Drawing.Size(146, 30);
            this.led_TOOL_Alarm.TabIndex = 206;
            this.led_TOOL_Alarm.Value = false;
            // 
            // led_TOOL_InitailDone
            // 
            this.led_TOOL_InitailDone.Caption = "初始化完成";
            this.led_TOOL_InitailDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_InitailDone.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_InitailDone.Location = new System.Drawing.Point(562, 60);
            this.led_TOOL_InitailDone.Name = "led_TOOL_InitailDone";
            this.led_TOOL_InitailDone.Size = new System.Drawing.Size(146, 30);
            this.led_TOOL_InitailDone.TabIndex = 205;
            this.led_TOOL_InitailDone.Value = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Cut_Use);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Use);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_DeTapeNG);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_CutNG);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_AlignEnd);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_AlignStart);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_CutArmIsSafe);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_LaserArmIsSafe);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_DeTapeArmIsSafe);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_RollerDown_End);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_DeTape_Start);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_RollerDown_Start);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_DeTape_End);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_LaserMeasurement_OK);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Cut_End);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Cut_Start);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_CCD_CheckCutOK);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Receive_Permission);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Receive_Complete);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Receive_Busy);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Out_Request);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Out_Complete);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Out_Busy);
            this.groupBox2.Controls.Add(this.led_TOOL_CV2_Ready);
            this.groupBox2.Location = new System.Drawing.Point(964, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 732);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CV2";
            // 
            // led_TOOL_CV2_Cut_Use
            // 
            this.led_TOOL_CV2_Cut_Use.Caption = "TOOL CV2 使用破口";
            this.led_TOOL_CV2_Cut_Use.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Cut_Use.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Cut_Use.Location = new System.Drawing.Point(15, 340);
            this.led_TOOL_CV2_Cut_Use.Name = "led_TOOL_CV2_Cut_Use";
            this.led_TOOL_CV2_Cut_Use.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Cut_Use.TabIndex = 177;
            this.led_TOOL_CV2_Cut_Use.Value = false;
            // 
            // led_TOOL_CV2_Use
            // 
            this.led_TOOL_CV2_Use.Caption = "TOOL CV2 使用";
            this.led_TOOL_CV2_Use.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Use.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Use.Location = new System.Drawing.Point(15, 305);
            this.led_TOOL_CV2_Use.Name = "led_TOOL_CV2_Use";
            this.led_TOOL_CV2_Use.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Use.TabIndex = 176;
            this.led_TOOL_CV2_Use.Value = false;
            // 
            // led_TOOL_CV2_DeTapeNG
            // 
            this.led_TOOL_CV2_DeTapeNG.Caption = "TOOL CV2 撕膜NG";
            this.led_TOOL_CV2_DeTapeNG.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_DeTapeNG.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_DeTapeNG.Location = new System.Drawing.Point(250, 410);
            this.led_TOOL_CV2_DeTapeNG.Name = "led_TOOL_CV2_DeTapeNG";
            this.led_TOOL_CV2_DeTapeNG.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_DeTapeNG.TabIndex = 175;
            this.led_TOOL_CV2_DeTapeNG.Value = false;
            // 
            // led_TOOL_CV2_CutNG
            // 
            this.led_TOOL_CV2_CutNG.Caption = "TOOL CV2 破口NG";
            this.led_TOOL_CV2_CutNG.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_CutNG.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_CutNG.Location = new System.Drawing.Point(250, 375);
            this.led_TOOL_CV2_CutNG.Name = "led_TOOL_CV2_CutNG";
            this.led_TOOL_CV2_CutNG.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_CutNG.TabIndex = 174;
            this.led_TOOL_CV2_CutNG.Value = false;
            // 
            // led_TOOL_CV2_AlignEnd
            // 
            this.led_TOOL_CV2_AlignEnd.Caption = "TOOL CV2 Align End";
            this.led_TOOL_CV2_AlignEnd.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_AlignEnd.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_AlignEnd.Location = new System.Drawing.Point(250, 340);
            this.led_TOOL_CV2_AlignEnd.Name = "led_TOOL_CV2_AlignEnd";
            this.led_TOOL_CV2_AlignEnd.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_AlignEnd.TabIndex = 173;
            this.led_TOOL_CV2_AlignEnd.Value = false;
            // 
            // led_TOOL_CV2_AlignStart
            // 
            this.led_TOOL_CV2_AlignStart.Caption = "TOOL CV2 Align Start";
            this.led_TOOL_CV2_AlignStart.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_AlignStart.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_AlignStart.Location = new System.Drawing.Point(250, 305);
            this.led_TOOL_CV2_AlignStart.Name = "led_TOOL_CV2_AlignStart";
            this.led_TOOL_CV2_AlignStart.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_AlignStart.TabIndex = 172;
            this.led_TOOL_CV2_AlignStart.Value = false;
            // 
            // led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff
            // 
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Caption = "TOOL CV2 頂針到接料點且破真空";
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Location = new System.Drawing.Point(15, 585);
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Name = "led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff";
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.TabIndex = 170;
            this.led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff.Value = false;
            // 
            // led_TOOL_CV2_CutArmIsSafe
            // 
            this.led_TOOL_CV2_CutArmIsSafe.Caption = "TOOL CV2 破口機構是否安全";
            this.led_TOOL_CV2_CutArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_CutArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_CutArmIsSafe.Location = new System.Drawing.Point(15, 550);
            this.led_TOOL_CV2_CutArmIsSafe.Name = "led_TOOL_CV2_CutArmIsSafe";
            this.led_TOOL_CV2_CutArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV2_CutArmIsSafe.TabIndex = 171;
            this.led_TOOL_CV2_CutArmIsSafe.Value = false;
            // 
            // led_TOOL_CV2_LaserArmIsSafe
            // 
            this.led_TOOL_CV2_LaserArmIsSafe.Caption = "TOOL CV2 雷射測距手臂是否安全";
            this.led_TOOL_CV2_LaserArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_LaserArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_LaserArmIsSafe.Location = new System.Drawing.Point(15, 515);
            this.led_TOOL_CV2_LaserArmIsSafe.Name = "led_TOOL_CV2_LaserArmIsSafe";
            this.led_TOOL_CV2_LaserArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV2_LaserArmIsSafe.TabIndex = 170;
            this.led_TOOL_CV2_LaserArmIsSafe.Value = false;
            // 
            // led_TOOL_CV2_DeTapeArmIsSafe
            // 
            this.led_TOOL_CV2_DeTapeArmIsSafe.Caption = "TOOL CV2 撕膜手臂是否安全";
            this.led_TOOL_CV2_DeTapeArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_DeTapeArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_DeTapeArmIsSafe.Location = new System.Drawing.Point(15, 480);
            this.led_TOOL_CV2_DeTapeArmIsSafe.Name = "led_TOOL_CV2_DeTapeArmIsSafe";
            this.led_TOOL_CV2_DeTapeArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV2_DeTapeArmIsSafe.TabIndex = 169;
            this.led_TOOL_CV2_DeTapeArmIsSafe.Value = false;
            // 
            // led_TOOL_CV2_RollerDown_End
            // 
            this.led_TOOL_CV2_RollerDown_End.Caption = "TOOL CV2 滾輪下壓動作End";
            this.led_TOOL_CV2_RollerDown_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_RollerDown_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_RollerDown_End.Location = new System.Drawing.Point(250, 270);
            this.led_TOOL_CV2_RollerDown_End.Name = "led_TOOL_CV2_RollerDown_End";
            this.led_TOOL_CV2_RollerDown_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_RollerDown_End.TabIndex = 165;
            this.led_TOOL_CV2_RollerDown_End.Value = false;
            // 
            // led_TOOL_CV2_DeTape_Start
            // 
            this.led_TOOL_CV2_DeTape_Start.Caption = "TOOL CV2 撕膜動作Start";
            this.led_TOOL_CV2_DeTape_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_DeTape_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_DeTape_Start.Location = new System.Drawing.Point(250, 166);
            this.led_TOOL_CV2_DeTape_Start.Name = "led_TOOL_CV2_DeTape_Start";
            this.led_TOOL_CV2_DeTape_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_DeTape_Start.TabIndex = 162;
            this.led_TOOL_CV2_DeTape_Start.Value = false;
            // 
            // led_TOOL_CV2_RollerDown_Start
            // 
            this.led_TOOL_CV2_RollerDown_Start.Caption = "TOOL CV2 滾輪下壓動作Start";
            this.led_TOOL_CV2_RollerDown_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_RollerDown_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_RollerDown_Start.Location = new System.Drawing.Point(250, 235);
            this.led_TOOL_CV2_RollerDown_Start.Name = "led_TOOL_CV2_RollerDown_Start";
            this.led_TOOL_CV2_RollerDown_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_RollerDown_Start.TabIndex = 164;
            this.led_TOOL_CV2_RollerDown_Start.Value = false;
            // 
            // led_TOOL_CV2_DeTape_End
            // 
            this.led_TOOL_CV2_DeTape_End.Caption = "TOOL CV2 撕膜動作End";
            this.led_TOOL_CV2_DeTape_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_DeTape_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_DeTape_End.Location = new System.Drawing.Point(250, 200);
            this.led_TOOL_CV2_DeTape_End.Name = "led_TOOL_CV2_DeTape_End";
            this.led_TOOL_CV2_DeTape_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_DeTape_End.TabIndex = 163;
            this.led_TOOL_CV2_DeTape_End.Value = false;
            // 
            // led_TOOL_CV2_LaserMeasurement_OK
            // 
            this.led_TOOL_CV2_LaserMeasurement_OK.Caption = "TOOL CV2 雷射測距完成";
            this.led_TOOL_CV2_LaserMeasurement_OK.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_LaserMeasurement_OK.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_LaserMeasurement_OK.Location = new System.Drawing.Point(250, 25);
            this.led_TOOL_CV2_LaserMeasurement_OK.Name = "led_TOOL_CV2_LaserMeasurement_OK";
            this.led_TOOL_CV2_LaserMeasurement_OK.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_LaserMeasurement_OK.TabIndex = 158;
            this.led_TOOL_CV2_LaserMeasurement_OK.Value = false;
            // 
            // led_TOOL_CV2_Cut_End
            // 
            this.led_TOOL_CV2_Cut_End.Caption = "TOOL CV2 破口針頭動作End";
            this.led_TOOL_CV2_Cut_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Cut_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Cut_End.Location = new System.Drawing.Point(250, 95);
            this.led_TOOL_CV2_Cut_End.Name = "led_TOOL_CV2_Cut_End";
            this.led_TOOL_CV2_Cut_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_Cut_End.TabIndex = 160;
            this.led_TOOL_CV2_Cut_End.Value = false;
            // 
            // led_TOOL_CV2_Cut_Start
            // 
            this.led_TOOL_CV2_Cut_Start.Caption = "TOOL CV2 破口針頭動作Start";
            this.led_TOOL_CV2_Cut_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Cut_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Cut_Start.Location = new System.Drawing.Point(250, 60);
            this.led_TOOL_CV2_Cut_Start.Name = "led_TOOL_CV2_Cut_Start";
            this.led_TOOL_CV2_Cut_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_Cut_Start.TabIndex = 159;
            this.led_TOOL_CV2_Cut_Start.Value = false;
            // 
            // led_TOOL_CV2_CCD_CheckCutOK
            // 
            this.led_TOOL_CV2_CCD_CheckCutOK.Caption = "TOOL CV2 CCD檢查破口完成";
            this.led_TOOL_CV2_CCD_CheckCutOK.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_CCD_CheckCutOK.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_CCD_CheckCutOK.Location = new System.Drawing.Point(250, 130);
            this.led_TOOL_CV2_CCD_CheckCutOK.Name = "led_TOOL_CV2_CCD_CheckCutOK";
            this.led_TOOL_CV2_CCD_CheckCutOK.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV2_CCD_CheckCutOK.TabIndex = 161;
            this.led_TOOL_CV2_CCD_CheckCutOK.Value = false;
            // 
            // led_TOOL_CV2_Receive_Permission
            // 
            this.led_TOOL_CV2_Receive_Permission.Caption = "TOOL CV2 收收許可";
            this.led_TOOL_CV2_Receive_Permission.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Receive_Permission.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Receive_Permission.Location = new System.Drawing.Point(15, 165);
            this.led_TOOL_CV2_Receive_Permission.Name = "led_TOOL_CV2_Receive_Permission";
            this.led_TOOL_CV2_Receive_Permission.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Receive_Permission.TabIndex = 155;
            this.led_TOOL_CV2_Receive_Permission.Value = false;
            // 
            // led_TOOL_CV2_Receive_Complete
            // 
            this.led_TOOL_CV2_Receive_Complete.Caption = "TOOL CV2 收片完畢";
            this.led_TOOL_CV2_Receive_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Receive_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Receive_Complete.Location = new System.Drawing.Point(15, 235);
            this.led_TOOL_CV2_Receive_Complete.Name = "led_TOOL_CV2_Receive_Complete";
            this.led_TOOL_CV2_Receive_Complete.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Receive_Complete.TabIndex = 157;
            this.led_TOOL_CV2_Receive_Complete.Value = false;
            // 
            // led_TOOL_CV2_Receive_Busy
            // 
            this.led_TOOL_CV2_Receive_Busy.Caption = "TOOL CV2 收片中";
            this.led_TOOL_CV2_Receive_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Receive_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Receive_Busy.Location = new System.Drawing.Point(15, 200);
            this.led_TOOL_CV2_Receive_Busy.Name = "led_TOOL_CV2_Receive_Busy";
            this.led_TOOL_CV2_Receive_Busy.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Receive_Busy.TabIndex = 156;
            this.led_TOOL_CV2_Receive_Busy.Value = false;
            // 
            // led_TOOL_CV2_Out_Request
            // 
            this.led_TOOL_CV2_Out_Request.Caption = "TOOL CV2 出片要求";
            this.led_TOOL_CV2_Out_Request.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Out_Request.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Out_Request.Location = new System.Drawing.Point(15, 60);
            this.led_TOOL_CV2_Out_Request.Name = "led_TOOL_CV2_Out_Request";
            this.led_TOOL_CV2_Out_Request.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Out_Request.TabIndex = 151;
            this.led_TOOL_CV2_Out_Request.Value = false;
            // 
            // led_TOOL_CV2_Out_Complete
            // 
            this.led_TOOL_CV2_Out_Complete.Caption = "TOOL CV2 出片完畢";
            this.led_TOOL_CV2_Out_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Out_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Out_Complete.Location = new System.Drawing.Point(15, 130);
            this.led_TOOL_CV2_Out_Complete.Name = "led_TOOL_CV2_Out_Complete";
            this.led_TOOL_CV2_Out_Complete.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Out_Complete.TabIndex = 153;
            this.led_TOOL_CV2_Out_Complete.Value = false;
            // 
            // led_TOOL_CV2_Out_Busy
            // 
            this.led_TOOL_CV2_Out_Busy.Caption = "TOOL CV2 出片中";
            this.led_TOOL_CV2_Out_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Out_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Out_Busy.Location = new System.Drawing.Point(15, 95);
            this.led_TOOL_CV2_Out_Busy.Name = "led_TOOL_CV2_Out_Busy";
            this.led_TOOL_CV2_Out_Busy.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Out_Busy.TabIndex = 152;
            this.led_TOOL_CV2_Out_Busy.Value = false;
            // 
            // led_TOOL_CV2_Ready
            // 
            this.led_TOOL_CV2_Ready.Caption = "TOOL CV2 Ready";
            this.led_TOOL_CV2_Ready.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV2_Ready.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV2_Ready.Location = new System.Drawing.Point(15, 25);
            this.led_TOOL_CV2_Ready.Name = "led_TOOL_CV2_Ready";
            this.led_TOOL_CV2_Ready.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV2_Ready.TabIndex = 140;
            this.led_TOOL_CV2_Ready.Value = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Cut_Use);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Use);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_DeTapeNG);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_CutNG);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_AlignEnd);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_AlignStart);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_CutArmIsSafe);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_LaserArmIsSafe);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_DeTapeArmIsSafe);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_RollerDown_End);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_DeTape_Start);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_RollerDown_Start);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_DeTape_End);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_LaserMeasurement_OK);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Cut_End);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Cut_Start);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_CCD_CheckCutOK);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Receive_Permission);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Receive_Complete);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Receive_Busy);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Out_Request);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Out_Complete);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Out_Busy);
            this.groupBox1.Controls.Add(this.led_TOOL_CV1_Ready);
            this.groupBox1.Location = new System.Drawing.Point(395, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 732);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CV1";
            // 
            // led_TOOL_CV1_Cut_Use
            // 
            this.led_TOOL_CV1_Cut_Use.Caption = "TOOL CV1 使用破口";
            this.led_TOOL_CV1_Cut_Use.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Cut_Use.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Cut_Use.Location = new System.Drawing.Point(15, 340);
            this.led_TOOL_CV1_Cut_Use.Name = "led_TOOL_CV1_Cut_Use";
            this.led_TOOL_CV1_Cut_Use.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Cut_Use.TabIndex = 175;
            this.led_TOOL_CV1_Cut_Use.Value = false;
            // 
            // led_TOOL_CV1_Use
            // 
            this.led_TOOL_CV1_Use.Caption = "TOOL CV1 使用";
            this.led_TOOL_CV1_Use.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Use.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Use.Location = new System.Drawing.Point(15, 305);
            this.led_TOOL_CV1_Use.Name = "led_TOOL_CV1_Use";
            this.led_TOOL_CV1_Use.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Use.TabIndex = 174;
            this.led_TOOL_CV1_Use.Value = false;
            // 
            // led_TOOL_CV1_DeTapeNG
            // 
            this.led_TOOL_CV1_DeTapeNG.Caption = "TOOL CV1 撕膜NG";
            this.led_TOOL_CV1_DeTapeNG.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_DeTapeNG.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_DeTapeNG.Location = new System.Drawing.Point(250, 410);
            this.led_TOOL_CV1_DeTapeNG.Name = "led_TOOL_CV1_DeTapeNG";
            this.led_TOOL_CV1_DeTapeNG.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_DeTapeNG.TabIndex = 173;
            this.led_TOOL_CV1_DeTapeNG.Value = false;
            // 
            // led_TOOL_CV1_CutNG
            // 
            this.led_TOOL_CV1_CutNG.Caption = "TOOL CV1 破口NG";
            this.led_TOOL_CV1_CutNG.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_CutNG.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_CutNG.Location = new System.Drawing.Point(250, 375);
            this.led_TOOL_CV1_CutNG.Name = "led_TOOL_CV1_CutNG";
            this.led_TOOL_CV1_CutNG.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_CutNG.TabIndex = 172;
            this.led_TOOL_CV1_CutNG.Value = false;
            // 
            // led_TOOL_CV1_AlignEnd
            // 
            this.led_TOOL_CV1_AlignEnd.Caption = "TOOL CV1 Align End";
            this.led_TOOL_CV1_AlignEnd.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_AlignEnd.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_AlignEnd.Location = new System.Drawing.Point(250, 340);
            this.led_TOOL_CV1_AlignEnd.Name = "led_TOOL_CV1_AlignEnd";
            this.led_TOOL_CV1_AlignEnd.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_AlignEnd.TabIndex = 171;
            this.led_TOOL_CV1_AlignEnd.Value = false;
            // 
            // led_TOOL_CV1_AlignStart
            // 
            this.led_TOOL_CV1_AlignStart.Caption = "TOOL CV1 Align Start";
            this.led_TOOL_CV1_AlignStart.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_AlignStart.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_AlignStart.Location = new System.Drawing.Point(250, 305);
            this.led_TOOL_CV1_AlignStart.Name = "led_TOOL_CV1_AlignStart";
            this.led_TOOL_CV1_AlignStart.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_AlignStart.TabIndex = 170;
            this.led_TOOL_CV1_AlignStart.Value = false;
            // 
            // led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff
            // 
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Caption = "TOOL CV1 頂針到接料點且破真空";
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Location = new System.Drawing.Point(15, 585);
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Name = "led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff";
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.TabIndex = 169;
            this.led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff.Value = false;
            // 
            // led_TOOL_CV1_CutArmIsSafe
            // 
            this.led_TOOL_CV1_CutArmIsSafe.Caption = "TOOL CV1 破口機構是否安全";
            this.led_TOOL_CV1_CutArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_CutArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_CutArmIsSafe.Location = new System.Drawing.Point(15, 550);
            this.led_TOOL_CV1_CutArmIsSafe.Name = "led_TOOL_CV1_CutArmIsSafe";
            this.led_TOOL_CV1_CutArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV1_CutArmIsSafe.TabIndex = 168;
            this.led_TOOL_CV1_CutArmIsSafe.Value = false;
            // 
            // led_TOOL_CV1_LaserArmIsSafe
            // 
            this.led_TOOL_CV1_LaserArmIsSafe.Caption = "TOOL CV1 雷射測距手臂是否安全";
            this.led_TOOL_CV1_LaserArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_LaserArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_LaserArmIsSafe.Location = new System.Drawing.Point(15, 515);
            this.led_TOOL_CV1_LaserArmIsSafe.Name = "led_TOOL_CV1_LaserArmIsSafe";
            this.led_TOOL_CV1_LaserArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV1_LaserArmIsSafe.TabIndex = 167;
            this.led_TOOL_CV1_LaserArmIsSafe.Value = false;
            // 
            // led_TOOL_CV1_DeTapeArmIsSafe
            // 
            this.led_TOOL_CV1_DeTapeArmIsSafe.Caption = "TOOL CV1 撕膜手臂是否安全";
            this.led_TOOL_CV1_DeTapeArmIsSafe.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_DeTapeArmIsSafe.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_DeTapeArmIsSafe.Location = new System.Drawing.Point(15, 480);
            this.led_TOOL_CV1_DeTapeArmIsSafe.Name = "led_TOOL_CV1_DeTapeArmIsSafe";
            this.led_TOOL_CV1_DeTapeArmIsSafe.Size = new System.Drawing.Size(300, 30);
            this.led_TOOL_CV1_DeTapeArmIsSafe.TabIndex = 166;
            this.led_TOOL_CV1_DeTapeArmIsSafe.Value = false;
            // 
            // led_TOOL_CV1_RollerDown_End
            // 
            this.led_TOOL_CV1_RollerDown_End.Caption = "TOOL CV1 滾輪下壓動作End";
            this.led_TOOL_CV1_RollerDown_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_RollerDown_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_RollerDown_End.Location = new System.Drawing.Point(250, 270);
            this.led_TOOL_CV1_RollerDown_End.Name = "led_TOOL_CV1_RollerDown_End";
            this.led_TOOL_CV1_RollerDown_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_RollerDown_End.TabIndex = 165;
            this.led_TOOL_CV1_RollerDown_End.Value = false;
            // 
            // led_TOOL_CV1_DeTape_Start
            // 
            this.led_TOOL_CV1_DeTape_Start.Caption = "TOOL CV1 撕膜動作Start";
            this.led_TOOL_CV1_DeTape_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_DeTape_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_DeTape_Start.Location = new System.Drawing.Point(250, 165);
            this.led_TOOL_CV1_DeTape_Start.Name = "led_TOOL_CV1_DeTape_Start";
            this.led_TOOL_CV1_DeTape_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_DeTape_Start.TabIndex = 162;
            this.led_TOOL_CV1_DeTape_Start.Value = false;
            // 
            // led_TOOL_CV1_RollerDown_Start
            // 
            this.led_TOOL_CV1_RollerDown_Start.Caption = "TOOL CV1 滾輪下壓動作Start";
            this.led_TOOL_CV1_RollerDown_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_RollerDown_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_RollerDown_Start.Location = new System.Drawing.Point(250, 235);
            this.led_TOOL_CV1_RollerDown_Start.Name = "led_TOOL_CV1_RollerDown_Start";
            this.led_TOOL_CV1_RollerDown_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_RollerDown_Start.TabIndex = 164;
            this.led_TOOL_CV1_RollerDown_Start.Value = false;
            // 
            // led_TOOL_CV1_DeTape_End
            // 
            this.led_TOOL_CV1_DeTape_End.Caption = "TOOL CV1 撕膜動作End";
            this.led_TOOL_CV1_DeTape_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_DeTape_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_DeTape_End.Location = new System.Drawing.Point(250, 200);
            this.led_TOOL_CV1_DeTape_End.Name = "led_TOOL_CV1_DeTape_End";
            this.led_TOOL_CV1_DeTape_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_DeTape_End.TabIndex = 163;
            this.led_TOOL_CV1_DeTape_End.Value = false;
            // 
            // led_TOOL_CV1_LaserMeasurement_OK
            // 
            this.led_TOOL_CV1_LaserMeasurement_OK.Caption = "TOOL CV1 雷射測距完成";
            this.led_TOOL_CV1_LaserMeasurement_OK.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_LaserMeasurement_OK.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_LaserMeasurement_OK.Location = new System.Drawing.Point(250, 25);
            this.led_TOOL_CV1_LaserMeasurement_OK.Name = "led_TOOL_CV1_LaserMeasurement_OK";
            this.led_TOOL_CV1_LaserMeasurement_OK.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_LaserMeasurement_OK.TabIndex = 158;
            this.led_TOOL_CV1_LaserMeasurement_OK.Value = false;
            // 
            // led_TOOL_CV1_Cut_End
            // 
            this.led_TOOL_CV1_Cut_End.Caption = "TOOL CV1 破口針頭動作End";
            this.led_TOOL_CV1_Cut_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Cut_End.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Cut_End.Location = new System.Drawing.Point(250, 95);
            this.led_TOOL_CV1_Cut_End.Name = "led_TOOL_CV1_Cut_End";
            this.led_TOOL_CV1_Cut_End.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_Cut_End.TabIndex = 160;
            this.led_TOOL_CV1_Cut_End.Value = false;
            // 
            // led_TOOL_CV1_Cut_Start
            // 
            this.led_TOOL_CV1_Cut_Start.Caption = "TOOL CV1 破口針頭動作Start";
            this.led_TOOL_CV1_Cut_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Cut_Start.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Cut_Start.Location = new System.Drawing.Point(250, 60);
            this.led_TOOL_CV1_Cut_Start.Name = "led_TOOL_CV1_Cut_Start";
            this.led_TOOL_CV1_Cut_Start.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_Cut_Start.TabIndex = 159;
            this.led_TOOL_CV1_Cut_Start.Value = false;
            // 
            // led_TOOL_CV1_CCD_CheckCutOK
            // 
            this.led_TOOL_CV1_CCD_CheckCutOK.Caption = "TOOL CV1 CCD檢查破口完成";
            this.led_TOOL_CV1_CCD_CheckCutOK.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_CCD_CheckCutOK.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_CCD_CheckCutOK.Location = new System.Drawing.Point(250, 130);
            this.led_TOOL_CV1_CCD_CheckCutOK.Name = "led_TOOL_CV1_CCD_CheckCutOK";
            this.led_TOOL_CV1_CCD_CheckCutOK.Size = new System.Drawing.Size(280, 30);
            this.led_TOOL_CV1_CCD_CheckCutOK.TabIndex = 161;
            this.led_TOOL_CV1_CCD_CheckCutOK.Value = false;
            // 
            // led_TOOL_CV1_Receive_Permission
            // 
            this.led_TOOL_CV1_Receive_Permission.Caption = "TOOL CV1 收收許可";
            this.led_TOOL_CV1_Receive_Permission.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Receive_Permission.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Receive_Permission.Location = new System.Drawing.Point(15, 165);
            this.led_TOOL_CV1_Receive_Permission.Name = "led_TOOL_CV1_Receive_Permission";
            this.led_TOOL_CV1_Receive_Permission.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Receive_Permission.TabIndex = 155;
            this.led_TOOL_CV1_Receive_Permission.Value = false;
            // 
            // led_TOOL_CV1_Receive_Complete
            // 
            this.led_TOOL_CV1_Receive_Complete.Caption = "TOOL CV1 收片完畢";
            this.led_TOOL_CV1_Receive_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Receive_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Receive_Complete.Location = new System.Drawing.Point(15, 235);
            this.led_TOOL_CV1_Receive_Complete.Name = "led_TOOL_CV1_Receive_Complete";
            this.led_TOOL_CV1_Receive_Complete.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Receive_Complete.TabIndex = 157;
            this.led_TOOL_CV1_Receive_Complete.Value = false;
            // 
            // led_TOOL_CV1_Receive_Busy
            // 
            this.led_TOOL_CV1_Receive_Busy.Caption = "TOOL CV1 收片中";
            this.led_TOOL_CV1_Receive_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Receive_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Receive_Busy.Location = new System.Drawing.Point(15, 200);
            this.led_TOOL_CV1_Receive_Busy.Name = "led_TOOL_CV1_Receive_Busy";
            this.led_TOOL_CV1_Receive_Busy.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Receive_Busy.TabIndex = 156;
            this.led_TOOL_CV1_Receive_Busy.Value = false;
            // 
            // led_TOOL_CV1_Out_Request
            // 
            this.led_TOOL_CV1_Out_Request.Caption = "TOOL CV1 出片要求";
            this.led_TOOL_CV1_Out_Request.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Out_Request.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Out_Request.Location = new System.Drawing.Point(15, 60);
            this.led_TOOL_CV1_Out_Request.Name = "led_TOOL_CV1_Out_Request";
            this.led_TOOL_CV1_Out_Request.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Out_Request.TabIndex = 151;
            this.led_TOOL_CV1_Out_Request.Value = false;
            // 
            // led_TOOL_CV1_Out_Complete
            // 
            this.led_TOOL_CV1_Out_Complete.Caption = "TOOL CV1 出片完畢";
            this.led_TOOL_CV1_Out_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Out_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Out_Complete.Location = new System.Drawing.Point(15, 130);
            this.led_TOOL_CV1_Out_Complete.Name = "led_TOOL_CV1_Out_Complete";
            this.led_TOOL_CV1_Out_Complete.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Out_Complete.TabIndex = 153;
            this.led_TOOL_CV1_Out_Complete.Value = false;
            // 
            // led_TOOL_CV1_Out_Busy
            // 
            this.led_TOOL_CV1_Out_Busy.Caption = "TOOL CV1 出片中";
            this.led_TOOL_CV1_Out_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_TOOL_CV1_Out_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_TOOL_CV1_Out_Busy.Location = new System.Drawing.Point(15, 95);
            this.led_TOOL_CV1_Out_Busy.Name = "led_TOOL_CV1_Out_Busy";
            this.led_TOOL_CV1_Out_Busy.Size = new System.Drawing.Size(220, 30);
            this.led_TOOL_CV1_Out_Busy.TabIndex = 152;
            this.led_TOOL_CV1_Out_Busy.Value = false;
            // 
            // led_RB_CV2_Receive_Permission
            // 
            this.led_RB_CV2_Receive_Permission.Caption = "RB CV2 收收許可";
            this.led_RB_CV2_Receive_Permission.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Receive_Permission.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Receive_Permission.Location = new System.Drawing.Point(25, 620);
            this.led_RB_CV2_Receive_Permission.Name = "led_RB_CV2_Receive_Permission";
            this.led_RB_CV2_Receive_Permission.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV2_Receive_Permission.TabIndex = 155;
            this.led_RB_CV2_Receive_Permission.Value = false;
            // 
            // led_RB_CV2_Receive_Complete
            // 
            this.led_RB_CV2_Receive_Complete.Caption = "RB CV2 收片完畢";
            this.led_RB_CV2_Receive_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Receive_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Receive_Complete.Location = new System.Drawing.Point(25, 690);
            this.led_RB_CV2_Receive_Complete.Name = "led_RB_CV2_Receive_Complete";
            this.led_RB_CV2_Receive_Complete.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV2_Receive_Complete.TabIndex = 157;
            this.led_RB_CV2_Receive_Complete.Value = false;
            // 
            // led_RB_CV2_Receive_Busy
            // 
            this.led_RB_CV2_Receive_Busy.Caption = "RB CV2 收片中";
            this.led_RB_CV2_Receive_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Receive_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Receive_Busy.Location = new System.Drawing.Point(25, 655);
            this.led_RB_CV2_Receive_Busy.Name = "led_RB_CV2_Receive_Busy";
            this.led_RB_CV2_Receive_Busy.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV2_Receive_Busy.TabIndex = 156;
            this.led_RB_CV2_Receive_Busy.Value = false;
            // 
            // led_RB_CV2_Out_Request
            // 
            this.led_RB_CV2_Out_Request.Caption = "RB CV2 出片要求";
            this.led_RB_CV2_Out_Request.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Out_Request.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Out_Request.Location = new System.Drawing.Point(25, 445);
            this.led_RB_CV2_Out_Request.Name = "led_RB_CV2_Out_Request";
            this.led_RB_CV2_Out_Request.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV2_Out_Request.TabIndex = 151;
            this.led_RB_CV2_Out_Request.Value = false;
            // 
            // led_RB_CV2_Out_Complete
            // 
            this.led_RB_CV2_Out_Complete.Caption = "RB CV2 出片完畢";
            this.led_RB_CV2_Out_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Out_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Out_Complete.Location = new System.Drawing.Point(25, 515);
            this.led_RB_CV2_Out_Complete.Name = "led_RB_CV2_Out_Complete";
            this.led_RB_CV2_Out_Complete.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV2_Out_Complete.TabIndex = 153;
            this.led_RB_CV2_Out_Complete.Value = false;
            // 
            // led_RB_CV2_Out_Busy
            // 
            this.led_RB_CV2_Out_Busy.Caption = "RB CV2 出片中";
            this.led_RB_CV2_Out_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_Out_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_Out_Busy.Location = new System.Drawing.Point(25, 480);
            this.led_RB_CV2_Out_Busy.Name = "led_RB_CV2_Out_Busy";
            this.led_RB_CV2_Out_Busy.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV2_Out_Busy.TabIndex = 152;
            this.led_RB_CV2_Out_Busy.Value = false;
            // 
            // led_RB_CV2_DoDeTape
            // 
            this.led_RB_CV2_DoDeTape.Caption = "RB CV2 執行撕膜動作";
            this.led_RB_CV2_DoDeTape.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_DoDeTape.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_DoDeTape.Location = new System.Drawing.Point(25, 550);
            this.led_RB_CV2_DoDeTape.Name = "led_RB_CV2_DoDeTape";
            this.led_RB_CV2_DoDeTape.Size = new System.Drawing.Size(225, 30);
            this.led_RB_CV2_DoDeTape.TabIndex = 154;
            this.led_RB_CV2_DoDeTape.Value = false;
            // 
            // led_RB_CV1_Receive_Permission
            // 
            this.led_RB_CV1_Receive_Permission.Caption = "RB CV1 收收許可";
            this.led_RB_CV1_Receive_Permission.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Receive_Permission.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Receive_Permission.Location = new System.Drawing.Point(25, 270);
            this.led_RB_CV1_Receive_Permission.Name = "led_RB_CV1_Receive_Permission";
            this.led_RB_CV1_Receive_Permission.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV1_Receive_Permission.TabIndex = 148;
            this.led_RB_CV1_Receive_Permission.Value = false;
            // 
            // led_RB_CV1_Receive_Complete
            // 
            this.led_RB_CV1_Receive_Complete.Caption = "RB CV1 收片完畢";
            this.led_RB_CV1_Receive_Complete.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Receive_Complete.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Receive_Complete.Location = new System.Drawing.Point(25, 340);
            this.led_RB_CV1_Receive_Complete.Name = "led_RB_CV1_Receive_Complete";
            this.led_RB_CV1_Receive_Complete.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV1_Receive_Complete.TabIndex = 150;
            this.led_RB_CV1_Receive_Complete.Value = false;
            // 
            // led_RB_CV1_Receive_Busy
            // 
            this.led_RB_CV1_Receive_Busy.Caption = "RB CV1 收片中";
            this.led_RB_CV1_Receive_Busy.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_Receive_Busy.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_Receive_Busy.Location = new System.Drawing.Point(25, 305);
            this.led_RB_CV1_Receive_Busy.Name = "led_RB_CV1_Receive_Busy";
            this.led_RB_CV1_Receive_Busy.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV1_Receive_Busy.TabIndex = 149;
            this.led_RB_CV1_Receive_Busy.Value = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.lb_AlarmCode);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.lb_CV2_DeTape_Current_Axiz18);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lb_CV1_DeTape_Current_Axiz18);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.lb_CV2_ESD);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.lb_CV1_ESD);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lb_CV2_CCD_DeTapeResult);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.lb_CV2_CCD_CutResult);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.lb_CV2_CutNeedles_UseCount);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.lb_CV2_DeTape_Current_Axiz17);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.lb_CV2_CutNeedles_Current);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.lb_CV2_LaserMeasurementData);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.lb_CV1_CCD_DeTapeResult);
            this.tabPage3.Controls.Add(this.lable21);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.lb_CV1_CCD_CutResult);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.lb_CV1_CutNeedles_UseCount);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lb_CV1_DeTape_Current_Axiz17);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.lb_CV1_CutNeedles_Current);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.lb_CV1_LaserMeasurementData);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lb_RollerDownPressure);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lb_TapeUseCount);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1568, 874);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "數值監控";
            // 
            // lb_AlarmCode
            // 
            this.lb_AlarmCode.AutoSize = true;
            this.lb_AlarmCode.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_AlarmCode.Location = new System.Drawing.Point(882, 38);
            this.lb_AlarmCode.Name = "lb_AlarmCode";
            this.lb_AlarmCode.Size = new System.Drawing.Size(64, 16);
            this.lb_AlarmCode.TabIndex = 256;
            this.lb_AlarmCode.Text = "0000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(606, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 255;
            this.label7.Text = "AlarmCode";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label32.Location = new System.Drawing.Point(995, 231);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 16);
            this.label32.TabIndex = 254;
            this.label32.Text = "%";
            // 
            // lb_CV2_DeTape_Current_Axiz18
            // 
            this.lb_CV2_DeTape_Current_Axiz18.AutoSize = true;
            this.lb_CV2_DeTape_Current_Axiz18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_DeTape_Current_Axiz18.Location = new System.Drawing.Point(882, 231);
            this.lb_CV2_DeTape_Current_Axiz18.Name = "lb_CV2_DeTape_Current_Axiz18";
            this.lb_CV2_DeTape_Current_Axiz18.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_DeTape_Current_Axiz18.TabIndex = 253;
            this.lb_CV2_DeTape_Current_Axiz18.Text = "0000000";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label34.Location = new System.Drawing.Point(606, 231);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(137, 16);
            this.label34.TabIndex = 252;
            this.label34.Text = "CV2 撕膜電流18軸";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(438, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 251;
            this.label4.Text = "%";
            // 
            // lb_CV1_DeTape_Current_Axiz18
            // 
            this.lb_CV1_DeTape_Current_Axiz18.AutoSize = true;
            this.lb_CV1_DeTape_Current_Axiz18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_DeTape_Current_Axiz18.Location = new System.Drawing.Point(325, 231);
            this.lb_CV1_DeTape_Current_Axiz18.Name = "lb_CV1_DeTape_Current_Axiz18";
            this.lb_CV1_DeTape_Current_Axiz18.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_DeTape_Current_Axiz18.TabIndex = 250;
            this.lb_CV1_DeTape_Current_Axiz18.Text = "0000000";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label25.Location = new System.Drawing.Point(49, 231);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 16);
            this.label25.TabIndex = 249;
            this.label25.Text = "CV1 撕膜電流18軸";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(995, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 16);
            this.label22.TabIndex = 248;
            this.label22.Text = "V";
            // 
            // lb_CV2_ESD
            // 
            this.lb_CV2_ESD.AutoSize = true;
            this.lb_CV2_ESD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_ESD.Location = new System.Drawing.Point(882, 393);
            this.lb_CV2_ESD.Name = "lb_CV2_ESD";
            this.lb_CV2_ESD.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_ESD.TabIndex = 247;
            this.lb_CV2_ESD.Text = "0000000";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.Location = new System.Drawing.Point(606, 393);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 16);
            this.label29.TabIndex = 246;
            this.label29.Text = "CV2 撕膜ESD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(438, 402);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 16);
            this.label17.TabIndex = 245;
            this.label17.Text = "V";
            // 
            // lb_CV1_ESD
            // 
            this.lb_CV1_ESD.AutoSize = true;
            this.lb_CV1_ESD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_ESD.Location = new System.Drawing.Point(325, 402);
            this.lb_CV1_ESD.Name = "lb_CV1_ESD";
            this.lb_CV1_ESD.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_ESD.TabIndex = 244;
            this.lb_CV1_ESD.Text = "0000000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(49, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 243;
            this.label14.Text = "CV1 撕膜ESD";
            // 
            // lb_CV2_CCD_DeTapeResult
            // 
            this.lb_CV2_CCD_DeTapeResult.AutoSize = true;
            this.lb_CV2_CCD_DeTapeResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_CCD_DeTapeResult.Location = new System.Drawing.Point(882, 355);
            this.lb_CV2_CCD_DeTapeResult.Name = "lb_CV2_CCD_DeTapeResult";
            this.lb_CV2_CCD_DeTapeResult.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_CCD_DeTapeResult.TabIndex = 242;
            this.lb_CV2_CCD_DeTapeResult.Text = "0000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(606, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 16);
            this.label8.TabIndex = 241;
            this.label8.Text = "CV2 CCD判斷撕膜狀況結果";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(995, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 240;
            this.label12.Text = "次";
            // 
            // lb_CV2_CCD_CutResult
            // 
            this.lb_CV2_CCD_CutResult.AutoSize = true;
            this.lb_CV2_CCD_CutResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_CCD_CutResult.Location = new System.Drawing.Point(882, 318);
            this.lb_CV2_CCD_CutResult.Name = "lb_CV2_CCD_CutResult";
            this.lb_CV2_CCD_CutResult.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_CCD_CutResult.TabIndex = 239;
            this.lb_CV2_CCD_CutResult.Text = "0000000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(606, 279);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 16);
            this.label16.TabIndex = 238;
            this.label16.Text = "CV2 破口針頭使用次數";
            // 
            // lb_CV2_CutNeedles_UseCount
            // 
            this.lb_CV2_CutNeedles_UseCount.AutoSize = true;
            this.lb_CV2_CutNeedles_UseCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_CutNeedles_UseCount.Location = new System.Drawing.Point(882, 279);
            this.lb_CV2_CutNeedles_UseCount.Name = "lb_CV2_CutNeedles_UseCount";
            this.lb_CV2_CutNeedles_UseCount.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_CutNeedles_UseCount.TabIndex = 237;
            this.lb_CV2_CutNeedles_UseCount.Text = "0000000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(606, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 16);
            this.label19.TabIndex = 236;
            this.label19.Text = "CV2 CCD檢查破口結果";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(995, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 16);
            this.label21.TabIndex = 235;
            this.label21.Text = "%";
            // 
            // lb_CV2_DeTape_Current_Axiz17
            // 
            this.lb_CV2_DeTape_Current_Axiz17.AutoSize = true;
            this.lb_CV2_DeTape_Current_Axiz17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_DeTape_Current_Axiz17.Location = new System.Drawing.Point(882, 193);
            this.lb_CV2_DeTape_Current_Axiz17.Name = "lb_CV2_DeTape_Current_Axiz17";
            this.lb_CV2_DeTape_Current_Axiz17.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_DeTape_Current_Axiz17.TabIndex = 234;
            this.lb_CV2_DeTape_Current_Axiz17.Text = "0000000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(606, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 16);
            this.label23.TabIndex = 233;
            this.label23.Text = "CV2 撕膜電流17軸";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(995, 155);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 16);
            this.label24.TabIndex = 232;
            this.label24.Text = "%";
            // 
            // lb_CV2_CutNeedles_Current
            // 
            this.lb_CV2_CutNeedles_Current.AutoSize = true;
            this.lb_CV2_CutNeedles_Current.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_CutNeedles_Current.Location = new System.Drawing.Point(882, 155);
            this.lb_CV2_CutNeedles_Current.Name = "lb_CV2_CutNeedles_Current";
            this.lb_CV2_CutNeedles_Current.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_CutNeedles_Current.TabIndex = 231;
            this.lb_CV2_CutNeedles_Current.Text = "0000000";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.Location = new System.Drawing.Point(606, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 16);
            this.label26.TabIndex = 230;
            this.label26.Text = "CV2 破口針頭電流";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(995, 117);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 16);
            this.label28.TabIndex = 229;
            this.label28.Text = "um";
            // 
            // lb_CV2_LaserMeasurementData
            // 
            this.lb_CV2_LaserMeasurementData.AutoSize = true;
            this.lb_CV2_LaserMeasurementData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV2_LaserMeasurementData.Location = new System.Drawing.Point(882, 117);
            this.lb_CV2_LaserMeasurementData.Name = "lb_CV2_LaserMeasurementData";
            this.lb_CV2_LaserMeasurementData.Size = new System.Drawing.Size(64, 16);
            this.lb_CV2_LaserMeasurementData.TabIndex = 228;
            this.lb_CV2_LaserMeasurementData.Text = "0000000";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.Location = new System.Drawing.Point(606, 117);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(105, 16);
            this.label30.TabIndex = 227;
            this.label30.Text = "CV2 雷射測距";
            // 
            // lb_CV1_CCD_DeTapeResult
            // 
            this.lb_CV1_CCD_DeTapeResult.AutoSize = true;
            this.lb_CV1_CCD_DeTapeResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_CCD_DeTapeResult.Location = new System.Drawing.Point(325, 362);
            this.lb_CV1_CCD_DeTapeResult.Name = "lb_CV1_CCD_DeTapeResult";
            this.lb_CV1_CCD_DeTapeResult.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_CCD_DeTapeResult.TabIndex = 226;
            this.lb_CV1_CCD_DeTapeResult.Text = "0000000";
            // 
            // lable21
            // 
            this.lable21.AutoSize = true;
            this.lable21.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable21.Location = new System.Drawing.Point(49, 362);
            this.lable21.Name = "lable21";
            this.lable21.Size = new System.Drawing.Size(200, 16);
            this.lable21.TabIndex = 225;
            this.lable21.Text = "CV1 CCD判斷撕膜狀況結果";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label27.Location = new System.Drawing.Point(438, 279);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 16);
            this.label27.TabIndex = 224;
            this.label27.Text = "次";
            // 
            // lb_CV1_CCD_CutResult
            // 
            this.lb_CV1_CCD_CutResult.AutoSize = true;
            this.lb_CV1_CCD_CutResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_CCD_CutResult.Location = new System.Drawing.Point(325, 325);
            this.lb_CV1_CCD_CutResult.Name = "lb_CV1_CCD_CutResult";
            this.lb_CV1_CCD_CutResult.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_CCD_CutResult.TabIndex = 223;
            this.lb_CV1_CCD_CutResult.Text = "0000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(49, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 16);
            this.label11.TabIndex = 222;
            this.label11.Text = "CV1 破口針頭使用次數";
            // 
            // lb_CV1_CutNeedles_UseCount
            // 
            this.lb_CV1_CutNeedles_UseCount.AutoSize = true;
            this.lb_CV1_CutNeedles_UseCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_CutNeedles_UseCount.Location = new System.Drawing.Point(325, 279);
            this.lb_CV1_CutNeedles_UseCount.Name = "lb_CV1_CutNeedles_UseCount";
            this.lb_CV1_CutNeedles_UseCount.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_CutNeedles_UseCount.TabIndex = 221;
            this.lb_CV1_CutNeedles_UseCount.Text = "0000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(49, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 16);
            this.label10.TabIndex = 220;
            this.label10.Text = "CV1 CCD檢查破口結果";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(438, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 219;
            this.label15.Text = "%";
            // 
            // lb_CV1_DeTape_Current_Axiz17
            // 
            this.lb_CV1_DeTape_Current_Axiz17.AutoSize = true;
            this.lb_CV1_DeTape_Current_Axiz17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_DeTape_Current_Axiz17.Location = new System.Drawing.Point(325, 189);
            this.lb_CV1_DeTape_Current_Axiz17.Name = "lb_CV1_DeTape_Current_Axiz17";
            this.lb_CV1_DeTape_Current_Axiz17.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_DeTape_Current_Axiz17.TabIndex = 218;
            this.lb_CV1_DeTape_Current_Axiz17.Text = "0000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(49, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 16);
            this.label13.TabIndex = 217;
            this.label13.Text = "CV1 撕膜電流17軸";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(437, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 16);
            this.label18.TabIndex = 216;
            this.label18.Text = "%";
            // 
            // lb_CV1_CutNeedles_Current
            // 
            this.lb_CV1_CutNeedles_Current.AutoSize = true;
            this.lb_CV1_CutNeedles_Current.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_CutNeedles_Current.Location = new System.Drawing.Point(324, 152);
            this.lb_CV1_CutNeedles_Current.Name = "lb_CV1_CutNeedles_Current";
            this.lb_CV1_CutNeedles_Current.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_CutNeedles_Current.TabIndex = 215;
            this.lb_CV1_CutNeedles_Current.Text = "0000000";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label31.Location = new System.Drawing.Point(48, 152);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(137, 16);
            this.label31.TabIndex = 214;
            this.label31.Text = "CV1 破口針頭電流";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(436, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 213;
            this.label9.Text = "um";
            // 
            // lb_CV1_LaserMeasurementData
            // 
            this.lb_CV1_LaserMeasurementData.AutoSize = true;
            this.lb_CV1_LaserMeasurementData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CV1_LaserMeasurementData.Location = new System.Drawing.Point(324, 117);
            this.lb_CV1_LaserMeasurementData.Name = "lb_CV1_LaserMeasurementData";
            this.lb_CV1_LaserMeasurementData.Size = new System.Drawing.Size(64, 16);
            this.lb_CV1_LaserMeasurementData.TabIndex = 212;
            this.lb_CV1_LaserMeasurementData.Text = "0000000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(47, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 16);
            this.label20.TabIndex = 211;
            this.label20.Text = "CV1 雷射測距";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(438, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 210;
            this.label6.Text = "kPa";
            // 
            // lb_RollerDownPressure
            // 
            this.lb_RollerDownPressure.AutoSize = true;
            this.lb_RollerDownPressure.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_RollerDownPressure.Location = new System.Drawing.Point(326, 77);
            this.lb_RollerDownPressure.Name = "lb_RollerDownPressure";
            this.lb_RollerDownPressure.Size = new System.Drawing.Size(64, 16);
            this.lb_RollerDownPressure.TabIndex = 209;
            this.lb_RollerDownPressure.Text = "0000000";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label40.Location = new System.Drawing.Point(49, 77);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(104, 16);
            this.label40.TabIndex = 208;
            this.label40.Text = "滾輪下壓力道";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(438, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 207;
            this.label5.Text = "次";
            // 
            // lb_TapeUseCount
            // 
            this.lb_TapeUseCount.AutoSize = true;
            this.lb_TapeUseCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TapeUseCount.Location = new System.Drawing.Point(326, 38);
            this.lb_TapeUseCount.Name = "lb_TapeUseCount";
            this.lb_TapeUseCount.Size = new System.Drawing.Size(64, 16);
            this.lb_TapeUseCount.TabIndex = 206;
            this.lb_TapeUseCount.Text = "0000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 205;
            this.label3.Text = "膠帶使用次數";
            // 
            // led_RB_CV1_DoUnloadLoad
            // 
            this.led_RB_CV1_DoUnloadLoad.Caption = "RB CV1 執行Unload Load";
            this.led_RB_CV1_DoUnloadLoad.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV1_DoUnloadLoad.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV1_DoUnloadLoad.Location = new System.Drawing.Point(25, 375);
            this.led_RB_CV1_DoUnloadLoad.Name = "led_RB_CV1_DoUnloadLoad";
            this.led_RB_CV1_DoUnloadLoad.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV1_DoUnloadLoad.TabIndex = 216;
            this.led_RB_CV1_DoUnloadLoad.Value = false;
            // 
            // led_RB_CV2_DoUnloadLoad
            // 
            this.led_RB_CV2_DoUnloadLoad.Caption = "RB CV2 執行Unload Load";
            this.led_RB_CV2_DoUnloadLoad.CaptionFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.led_RB_CV2_DoUnloadLoad.CpationColor = System.Drawing.Color.Black;
            this.led_RB_CV2_DoUnloadLoad.Location = new System.Drawing.Point(26, 725);
            this.led_RB_CV2_DoUnloadLoad.Name = "led_RB_CV2_DoUnloadLoad";
            this.led_RB_CV2_DoUnloadLoad.Size = new System.Drawing.Size(224, 30);
            this.led_RB_CV2_DoUnloadLoad.TabIndex = 217;
            this.led_RB_CV2_DoUnloadLoad.Value = false;
            // 
            // TapeRemove_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Name = "TapeRemove_Control";
            this.Size = new System.Drawing.Size(1576, 900);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tp_Signal.ResumeLayout(false);
            this.tp_Signal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private KCSDK.LEDLabel led_RB_CV1_Out_Request;
        private KCSDK.LEDLabel led_RB_CV1_Out_Busy;
        private KCSDK.LEDLabel led_RB_CV1_Out_Complete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KCSDK.LEDLabel led_RB_Pause;
        private KCSDK.LEDLabel led_RB_Ready;
        private KCSDK.LEDLabel led_RB_CV1_DoDeTape;
        private KCSDK.LEDLabel led_TOOL_Pause;
        private KCSDK.LEDLabel led_TOOL_CV1_Ready;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tp_Signal;
        private ProVLib.FlowChart FC_DeTapeStatus_Next;
        private ProVLib.FlowChart FC_DeTapeStatus_CheckConnect;
        private ProVLib.FlowChart FC_DeTapeStatus_Connect;
        private ProVLib.FlowChart FC_DeTapeStatus_ReadToolStatus;
        private ProVLib.FlowChart FC_DeTapeStatus_ReadToolStatusDone;
        private ProVLib.FlowChart FC_DeTapeStatus_UpdateData;
        private ProVLib.FlowChart FC_DeTapeStatus_WriteRobotStatus;
        private ProVLib.FlowChart FC_DeTapeStatus_WriteRobotStatusDone;
        private ProVLib.FlowChart FC_DeTapeStatus_Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private KCSDK.LEDLabel led_TOOL_CV2_RollerDown_End;
        private KCSDK.LEDLabel led_TOOL_CV2_DeTape_Start;
        private KCSDK.LEDLabel led_TOOL_CV2_RollerDown_Start;
        private KCSDK.LEDLabel led_TOOL_CV2_DeTape_End;
        private KCSDK.LEDLabel led_TOOL_CV2_LaserMeasurement_OK;
        private KCSDK.LEDLabel led_TOOL_CV2_Cut_End;
        private KCSDK.LEDLabel led_TOOL_CV2_Cut_Start;
        private KCSDK.LEDLabel led_TOOL_CV2_CCD_CheckCutOK;
        private KCSDK.LEDLabel led_TOOL_CV2_Receive_Permission;
        private KCSDK.LEDLabel led_TOOL_CV2_Receive_Complete;
        private KCSDK.LEDLabel led_TOOL_CV2_Receive_Busy;
        private KCSDK.LEDLabel led_TOOL_CV2_Out_Request;
        private KCSDK.LEDLabel led_TOOL_CV2_Out_Complete;
        private KCSDK.LEDLabel led_TOOL_CV2_Out_Busy;
        private KCSDK.LEDLabel led_TOOL_CV2_Ready;
        private System.Windows.Forms.GroupBox groupBox1;
        private KCSDK.LEDLabel led_TOOL_CV1_RollerDown_End;
        private KCSDK.LEDLabel led_TOOL_CV1_DeTape_Start;
        private KCSDK.LEDLabel led_TOOL_CV1_RollerDown_Start;
        private KCSDK.LEDLabel led_TOOL_CV1_DeTape_End;
        private KCSDK.LEDLabel led_TOOL_CV1_LaserMeasurement_OK;
        private KCSDK.LEDLabel led_TOOL_CV1_Cut_End;
        private KCSDK.LEDLabel led_TOOL_CV1_Cut_Start;
        private KCSDK.LEDLabel led_TOOL_CV1_CCD_CheckCutOK;
        private KCSDK.LEDLabel led_TOOL_CV1_Receive_Permission;
        private KCSDK.LEDLabel led_TOOL_CV1_Receive_Complete;
        private KCSDK.LEDLabel led_TOOL_CV1_Receive_Busy;
        private KCSDK.LEDLabel led_TOOL_CV1_Out_Request;
        private KCSDK.LEDLabel led_TOOL_CV1_Out_Complete;
        private KCSDK.LEDLabel led_TOOL_CV1_Out_Busy;
        private KCSDK.LEDLabel led_RB_CV2_Receive_Permission;
        private KCSDK.LEDLabel led_RB_CV2_Receive_Complete;
        private KCSDK.LEDLabel led_RB_CV2_Receive_Busy;
        private KCSDK.LEDLabel led_RB_CV2_Out_Request;
        private KCSDK.LEDLabel led_RB_CV2_Out_Complete;
        private KCSDK.LEDLabel led_RB_CV2_Out_Busy;
        private KCSDK.LEDLabel led_RB_CV2_DoDeTape;
        private KCSDK.LEDLabel led_RB_CV1_Receive_Permission;
        private KCSDK.LEDLabel led_RB_CV1_Receive_Complete;
        private KCSDK.LEDLabel led_RB_CV1_Receive_Busy;
        private KCSDK.LEDLabel led_TOOL_InitailDone;
        private KCSDK.LEDLabel led_TOOL_Alarm;
        private KCSDK.LEDLabel led_RB_CV1_DoReject;
        private KCSDK.LEDLabel led_RB_CV2_DoReject;
        private KCSDK.LEDLabel led_RB_NotifyInitial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_CV2_ESD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_CV1_ESD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_CV2_CCD_DeTapeResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_CV2_CCD_CutResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_CV2_CutNeedles_UseCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_CV2_DeTape_Current_Axiz17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_CV2_CutNeedles_Current;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lb_CV2_LaserMeasurementData;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lb_CV1_CCD_DeTapeResult;
        private System.Windows.Forms.Label lable21;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lb_CV1_CCD_CutResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_CV1_CutNeedles_UseCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_CV1_DeTape_Current_Axiz17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_CV1_CutNeedles_Current;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_CV1_LaserMeasurementData;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_RollerDownPressure;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TapeUseCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lb_CV2_DeTape_Current_Axiz18;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_CV1_DeTape_Current_Axiz18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lb_AlarmCode;
        private System.Windows.Forms.Label label7;
        private KCSDK.LEDLabel led_TOOL_CV2_CutArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV2_LaserArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV2_DeTapeArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV1_CutArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV1_LaserArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV1_DeTapeArmIsSafe;
        private KCSDK.LEDLabel led_TOOL_CV2_AlignEnd;
        private KCSDK.LEDLabel led_TOOL_CV2_AlignStart;
        private KCSDK.LEDLabel led_TOOL_CV2_Ejector_MoveToLoadPos_VacuumOff;
        private KCSDK.LEDLabel led_TOOL_CV1_AlignEnd;
        private KCSDK.LEDLabel led_TOOL_CV1_AlignStart;
        private KCSDK.LEDLabel led_TOOL_CV1_Ejector_MoveToLoadPos_VacuumOff;
        private System.Windows.Forms.Label lb_MachineMode;
        private System.Windows.Forms.Label label33;
        private KCSDK.LEDLabel led_TOOL_CV2_DeTapeNG;
        private KCSDK.LEDLabel led_TOOL_CV2_CutNG;
        private KCSDK.LEDLabel led_TOOL_CV1_DeTapeNG;
        private KCSDK.LEDLabel led_TOOL_CV1_CutNG;
        private System.Windows.Forms.Label lb_TOOL_WaferSize;
        private System.Windows.Forms.Label label36;
        private KCSDK.LEDLabel led_TOOL_CV2_Cut_Use;
        private KCSDK.LEDLabel led_TOOL_CV2_Use;
        private KCSDK.LEDLabel led_TOOL_CV1_Cut_Use;
        private KCSDK.LEDLabel led_TOOL_CV1_Use;
        private System.Windows.Forms.Label lb_RB_WaferSize;
        private System.Windows.Forms.Label label37;
        private KCSDK.LEDLabel led_RB_CV2_DoUnloadLoad;
        private KCSDK.LEDLabel led_RB_CV1_DoUnloadLoad;

    }
}
