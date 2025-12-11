namespace WAS_A
{
    partial class WAS_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WAS_A));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cv_StopBits = new KCSDK.DComboBox();
            this.cb_DataBits = new KCSDK.DComboBox();
            this.cb_Parity = new KCSDK.DComboBox();
            this.cb_Baudrate = new KCSDK.DComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cb_COMPort = new KCSDK.DComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FC_Home_DoHome = new ProVLib.FlowChart();
            this.FC_Home_DoHomeDone = new ProVLib.FlowChart();
            this.FC_Home_SetSpeed_Doit = new ProVLib.FlowChart();
            this.FC_Home_SetSpeed_Done = new ProVLib.FlowChart();
            this.FC_Home_SetSWaferType_Doit = new ProVLib.FlowChart();
            this.FC_Home_Pass = new ProVLib.FlowChart();
            this.FC_Home_SetTime_Doit = new ProVLib.FlowChart();
            this.FC_Home_SetTime_Done = new ProVLib.FlowChart();
            this.FC_Home_End = new ProVLib.FlowChart();
            this.FC_Home_SetWaferType_Done = new ProVLib.FlowChart();
            this.FC_Home_ChkHasNoWafer = new ProVLib.FlowChart();
            this.FC_Home_Retry1 = new ProVLib.FlowChart();
            this.FC_Home_VacOn = new ProVLib.FlowChart();
            this.FC_Home_VacOnDone = new ProVLib.FlowChart();
            this.FC_Home_GetStatus = new ProVLib.FlowChart();
            this.FC_Home_GetStatusDone = new ProVLib.FlowChart();
            this.FC_Home_VacOff = new ProVLib.FlowChart();
            this.FC_Home_VacOffDone = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_Next = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_WaitCommand = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_DoCommand = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_CommandFinish = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_Retry = new ProVLib.FlowChart();
            this.FC_Home_CommandStart_Done = new ProVLib.FlowChart();
            this.FC_Home_Command_Start = new ProVLib.FlowChart();
            this.FC_Home_Simulation = new ProVLib.FlowChart();
            this.FC_Home_Connect = new ProVLib.FlowChart();
            this.FC_Home_Delay = new ProVLib.FlowChart();
            this.FC_Home_Reset = new ProVLib.FlowChart();
            this.FC_Home_Reset_Done = new ProVLib.FlowChart();
            this.FC_Home_Start = new ProVLib.FlowChart();
            this.FC_Home_WaitCmd = new ProVLib.FlowChart();
            this.dFieldEdit12 = new KCSDK.DFieldEdit();
            this.dFieldEdit2 = new KCSDK.DFieldEdit();
            this.FC_Auto_Align_Next = new ProVLib.FlowChart();
            this.FC_Auto_Align_WaitCommand = new ProVLib.FlowChart();
            this.FC_Auto_Align_DoVacOn = new ProVLib.FlowChart();
            this.FC_Auto_Align_VacOnDone = new ProVLib.FlowChart();
            this.FC_Auto_Align_FailAction3 = new ProVLib.FlowChart();
            this.FC_Auto_Align_DoPreAlign = new ProVLib.FlowChart();
            this.FC_Auto_Align_PreAlignDone = new ProVLib.FlowChart();
            this.FC_Auto_Align_FailAction2 = new ProVLib.FlowChart();
            this.FC_Auto_Align_DoAction = new ProVLib.FlowChart();
            this.FC_Auto_Align_DoActionDone = new ProVLib.FlowChart();
            this.FC_Auto_Align_FailAction = new ProVLib.FlowChart();
            this.FC_Auto_Align_Done = new ProVLib.FlowChart();
            this.FC_Auto_Align_Start = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_Next = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_WaitCommand = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_DoAction = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_DoActionDone = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_FailAction = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_Done = new ProVLib.FlowChart();
            this.FC_Auto_VaccumSW_Start = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_Next = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_WaitCommand = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_DoAction = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_DoActionDone = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_FailAction = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_Done = new ProVLib.FlowChart();
            this.FC_Auto_PreAction_Start = new ProVLib.FlowChart();
            this.dFieldEdit3 = new KCSDK.DFieldEdit();
            this.dFieldEdit1 = new KCSDK.DFieldEdit();
            this.dFieldEdit4 = new KCSDK.DFieldEdit();
            this.dFieldEdit17 = new KCSDK.DFieldEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.OB_NegativePressure_On = new ProVLib.OutBit();
            this.OB_NegativePressure_Off = new ProVLib.OutBit();
            this.bt_VacuumOff = new System.Windows.Forms.Button();
            this.bt_VacuumOn = new System.Windows.Forms.Button();
            this.FC_Auto_CheckHasWafer_CheckHasWafer = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_VacOff = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_VacOffDone = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_FailAction3 = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_Done = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_Next = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_WaitCommand = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_VacOn = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_VacOnDone = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_FailAction = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_GetStatus = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_GetStatusDone = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_FailAction2 = new ProVLib.FlowChart();
            this.FC_Auto_CheckHasWafer_Start = new ProVLib.FlowChart();
            this.Aligner = new RobotControl.RobotControl();
            this.label14 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.tpFlow.SuspendLayout();
            this.tpSuperSetting.SuspendLayout();
            this.TabFlow.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAuto.SuspendLayout();
            this.tpCheck.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.Images.SetKeyName(0, "position.png");
            this.imgList.Images.SetKeyName(1, "motor.png");
            this.imgList.Images.SetKeyName(2, "setting.png");
            this.imgList.Images.SetKeyName(3, "checklist.png");
            this.imgList.Images.SetKeyName(4, "edit.png");
            this.imgList.Images.SetKeyName(5, "save.png");
            this.imgList.Images.SetKeyName(6, "cancel.png");
            this.imgList.Images.SetKeyName(7, "addrow.png");
            this.imgList.Images.SetKeyName(8, "delrow1.png");
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(1028, 717);
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.label14);
            this.tpControl.Controls.Add(this.groupBox11);
            this.tpControl.Controls.Add(this.Aligner);
            this.tpControl.Size = new System.Drawing.Size(1020, 649);
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.dFieldEdit1);
            this.tpSetting.Controls.Add(this.dFieldEdit2);
            this.tpSetting.Controls.SetChildIndex(this.dFieldEdit2, 0);
            this.tpSetting.Controls.SetChildIndex(this.dFieldEdit1, 0);
            // 
            // tpSuperSetting
            // 
            this.tpSuperSetting.Controls.Add(this.groupBox1);
            this.tpSuperSetting.Controls.Add(this.dFieldEdit3);
            this.tpSuperSetting.Controls.Add(this.panel1);
            this.tpSuperSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpSuperSetting.Controls.SetChildIndex(this.panel1, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.dFieldEdit3, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.FC_Home_Delay);
            this.tpHome.Controls.Add(this.FC_Home_Reset_Done);
            this.tpHome.Controls.Add(this.FC_Home_Reset);
            this.tpHome.Controls.Add(this.FC_Home_Pass);
            this.tpHome.Controls.Add(this.FC_Home_SetTime_Done);
            this.tpHome.Controls.Add(this.FC_Home_SetTime_Doit);
            this.tpHome.Controls.Add(this.FC_Home_SetWaferType_Done);
            this.tpHome.Controls.Add(this.FC_Home_SetSWaferType_Doit);
            this.tpHome.Controls.Add(this.FC_Home_WaitCmd);
            this.tpHome.Controls.Add(this.FC_Home_ChkHasNoWafer);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_Next);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_Done);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_Retry);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_CommandFinish);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_DoCommand);
            this.tpHome.Controls.Add(this.FC_Home_CommandStart_WaitCommand);
            this.tpHome.Controls.Add(this.FC_Home_Command_Start);
            this.tpHome.Controls.Add(this.FC_Home_VacOffDone);
            this.tpHome.Controls.Add(this.FC_Home_VacOnDone);
            this.tpHome.Controls.Add(this.FC_Home_VacOff);
            this.tpHome.Controls.Add(this.FC_Home_VacOn);
            this.tpHome.Controls.Add(this.FC_Home_SetSpeed_Done);
            this.tpHome.Controls.Add(this.FC_Home_SetSpeed_Doit);
            this.tpHome.Controls.Add(this.FC_Home_Retry1);
            this.tpHome.Controls.Add(this.FC_Home_Simulation);
            this.tpHome.Controls.Add(this.FC_Home_End);
            this.tpHome.Controls.Add(this.FC_Home_DoHomeDone);
            this.tpHome.Controls.Add(this.FC_Home_DoHome);
            this.tpHome.Controls.Add(this.FC_Home_GetStatusDone);
            this.tpHome.Controls.Add(this.FC_Home_GetStatus);
            this.tpHome.Controls.Add(this.FC_Home_Connect);
            this.tpHome.Controls.Add(this.FC_Home_Start);
            // 
            // tpAuto
            // 
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_FailAction);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_FailAction2);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_FailAction3);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_Next);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_WaitCommand);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_Start);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_CheckHasWafer);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_VacOffDone);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_VacOnDone);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_VacOff);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_VacOn);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_GetStatusDone);
            this.tpAuto.Controls.Add(this.FC_Auto_CheckHasWafer_GetStatus);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_FailAction3);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_FailAction2);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_PreAlignDone);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_DoPreAlign);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_VacOnDone);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_DoVacOn);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_Next);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_FailAction);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_DoActionDone);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_DoAction);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_WaitCommand);
            this.tpAuto.Controls.Add(this.FC_Auto_PreAction_Start);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_Next);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_FailAction);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_DoActionDone);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_DoAction);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_WaitCommand);
            this.tpAuto.Controls.Add(this.FC_Auto_VaccumSW_Start);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_Next);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_FailAction);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_DoActionDone);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_DoAction);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_WaitCommand);
            this.tpAuto.Controls.Add(this.FC_Auto_Align_Start);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cv_StopBits);
            this.panel1.Controls.Add(this.cb_DataBits);
            this.panel1.Controls.Add(this.cb_Parity);
            this.panel1.Controls.Add(this.cb_Baudrate);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.cb_COMPort);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(887, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 210);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // cv_StopBits
            // 
            this.cv_StopBits.BackColor = System.Drawing.SystemColors.Window;
            this.cv_StopBits.DataName = "StopBits";
            this.cv_StopBits.DataSource = this.SetDS;
            this.cv_StopBits.DefaultValue = 0;
            this.cv_StopBits.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cv_StopBits.FormattingEnabled = true;
            this.cv_StopBits.IsModified = false;
            this.cv_StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cv_StopBits.Location = new System.Drawing.Point(202, 111);
            this.cv_StopBits.ModifiedColor = System.Drawing.Color.Aqua;
            this.cv_StopBits.Name = "cv_StopBits";
            this.cv_StopBits.NoChangeInAuto = false;
            this.cv_StopBits.Size = new System.Drawing.Size(171, 29);
            this.cv_StopBits.TabIndex = 61;
            // 
            // cb_DataBits
            // 
            this.cb_DataBits.BackColor = System.Drawing.SystemColors.Window;
            this.cb_DataBits.DataName = "DataBits";
            this.cb_DataBits.DataSource = this.SetDS;
            this.cb_DataBits.DefaultValue = 0;
            this.cb_DataBits.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_DataBits.FormattingEnabled = true;
            this.cb_DataBits.IsModified = false;
            this.cb_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_DataBits.Location = new System.Drawing.Point(202, 78);
            this.cb_DataBits.ModifiedColor = System.Drawing.Color.Aqua;
            this.cb_DataBits.Name = "cb_DataBits";
            this.cb_DataBits.NoChangeInAuto = false;
            this.cb_DataBits.Size = new System.Drawing.Size(171, 29);
            this.cb_DataBits.TabIndex = 60;
            // 
            // cb_Parity
            // 
            this.cb_Parity.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Parity.DataName = "Parity";
            this.cb_Parity.DataSource = this.SetDS;
            this.cb_Parity.DefaultValue = 0;
            this.cb_Parity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Parity.FormattingEnabled = true;
            this.cb_Parity.IsModified = false;
            this.cb_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_Parity.Location = new System.Drawing.Point(202, 144);
            this.cb_Parity.ModifiedColor = System.Drawing.Color.Aqua;
            this.cb_Parity.Name = "cb_Parity";
            this.cb_Parity.NoChangeInAuto = false;
            this.cb_Parity.Size = new System.Drawing.Size(171, 29);
            this.cb_Parity.TabIndex = 59;
            // 
            // cb_Baudrate
            // 
            this.cb_Baudrate.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Baudrate.DataName = "Baudrate";
            this.cb_Baudrate.DataSource = this.SetDS;
            this.cb_Baudrate.DefaultValue = 0;
            this.cb_Baudrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Baudrate.FormattingEnabled = true;
            this.cb_Baudrate.IsModified = false;
            this.cb_Baudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_Baudrate.Location = new System.Drawing.Point(202, 45);
            this.cb_Baudrate.ModifiedColor = System.Drawing.Color.Aqua;
            this.cb_Baudrate.Name = "cb_Baudrate";
            this.cb_Baudrate.NoChangeInAuto = false;
            this.cb_Baudrate.Size = new System.Drawing.Size(171, 29);
            this.cb_Baudrate.TabIndex = 58;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Lime;
            this.textBox7.Location = new System.Drawing.Point(12, 111);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(171, 29);
            this.textBox7.TabIndex = 32;
            this.textBox7.Text = "停止位";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_COMPort
            // 
            this.cb_COMPort.BackColor = System.Drawing.SystemColors.Window;
            this.cb_COMPort.DataName = "COMPort";
            this.cb_COMPort.DataSource = this.SetDS;
            this.cb_COMPort.DefaultValue = 1;
            this.cb_COMPort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_COMPort.FormattingEnabled = true;
            this.cb_COMPort.IsModified = false;
            this.cb_COMPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cb_COMPort.Location = new System.Drawing.Point(202, 12);
            this.cb_COMPort.ModifiedColor = System.Drawing.Color.Aqua;
            this.cb_COMPort.Name = "cb_COMPort";
            this.cb_COMPort.NoChangeInAuto = false;
            this.cb_COMPort.Size = new System.Drawing.Size(171, 29);
            this.cb_COMPort.TabIndex = 57;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Lime;
            this.textBox6.Location = new System.Drawing.Point(12, 144);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(171, 29);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "校驗位";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Lime;
            this.textBox5.Location = new System.Drawing.Point(12, 78);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(171, 29);
            this.textBox5.TabIndex = 30;
            this.textBox5.Text = "數據位";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(12, 45);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(171, 29);
            this.textBox4.TabIndex = 29;
            this.textBox4.Text = "波特率";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(171, 29);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "COM Port";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FC_Home_DoHome
            // 
            this.FC_Home_DoHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoHome.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoHome.CASE1 = null;
            this.FC_Home_DoHome.CASE2 = null;
            this.FC_Home_DoHome.CASE3 = null;
            this.FC_Home_DoHome.CASE4 = null;
            this.FC_Home_DoHome.ContinueRun = false;
            this.FC_Home_DoHome.DesignTimeParent = null;
            this.FC_Home_DoHome.EndFC = null;
            this.FC_Home_DoHome.ErrID = 0;
            this.FC_Home_DoHome.InAlarm = false;
            this.FC_Home_DoHome.IsFlowHead = false;
            this.FC_Home_DoHome.Location = new System.Drawing.Point(210, 286);
            this.FC_Home_DoHome.LockUI = false;
            this.FC_Home_DoHome.Message = null;
            this.FC_Home_DoHome.MsgID = 0;
            this.FC_Home_DoHome.Name = "FC_Home_DoHome";
            this.FC_Home_DoHome.NEXT = this.FC_Home_DoHomeDone;
            this.FC_Home_DoHome.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoHome.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoHome.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoHome.OverTimeSpec = 100;
            this.FC_Home_DoHome.Running = false;
            this.FC_Home_DoHome.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_DoHome.SlowRunCycle = -1;
            this.FC_Home_DoHome.StartFC = null;
            this.FC_Home_DoHome.Text = "Do Home";
            this.FC_Home_DoHome.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoHome_Run);
            // 
            // FC_Home_DoHomeDone
            // 
            this.FC_Home_DoHomeDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoHomeDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoHomeDone.CASE1 = null;
            this.FC_Home_DoHomeDone.CASE2 = null;
            this.FC_Home_DoHomeDone.CASE3 = null;
            this.FC_Home_DoHomeDone.CASE4 = null;
            this.FC_Home_DoHomeDone.ContinueRun = false;
            this.FC_Home_DoHomeDone.DesignTimeParent = null;
            this.FC_Home_DoHomeDone.EndFC = null;
            this.FC_Home_DoHomeDone.ErrID = 0;
            this.FC_Home_DoHomeDone.InAlarm = false;
            this.FC_Home_DoHomeDone.IsFlowHead = false;
            this.FC_Home_DoHomeDone.Location = new System.Drawing.Point(210, 314);
            this.FC_Home_DoHomeDone.LockUI = false;
            this.FC_Home_DoHomeDone.Message = null;
            this.FC_Home_DoHomeDone.MsgID = 0;
            this.FC_Home_DoHomeDone.Name = "FC_Home_DoHomeDone";
            this.FC_Home_DoHomeDone.NEXT = this.FC_Home_SetSpeed_Doit;
            this.FC_Home_DoHomeDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoHomeDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoHomeDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoHomeDone.OverTimeSpec = 100;
            this.FC_Home_DoHomeDone.Running = false;
            this.FC_Home_DoHomeDone.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_DoHomeDone.SlowRunCycle = -1;
            this.FC_Home_DoHomeDone.StartFC = null;
            this.FC_Home_DoHomeDone.Text = "Do Home Done";
            this.FC_Home_DoHomeDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_SetSpeed_Doit
            // 
            this.FC_Home_SetSpeed_Doit.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetSpeed_Doit.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetSpeed_Doit.CASE1 = null;
            this.FC_Home_SetSpeed_Doit.CASE2 = null;
            this.FC_Home_SetSpeed_Doit.CASE3 = null;
            this.FC_Home_SetSpeed_Doit.CASE4 = null;
            this.FC_Home_SetSpeed_Doit.ContinueRun = false;
            this.FC_Home_SetSpeed_Doit.DesignTimeParent = null;
            this.FC_Home_SetSpeed_Doit.EndFC = null;
            this.FC_Home_SetSpeed_Doit.ErrID = 0;
            this.FC_Home_SetSpeed_Doit.InAlarm = false;
            this.FC_Home_SetSpeed_Doit.IsFlowHead = false;
            this.FC_Home_SetSpeed_Doit.Location = new System.Drawing.Point(210, 342);
            this.FC_Home_SetSpeed_Doit.LockUI = false;
            this.FC_Home_SetSpeed_Doit.Message = null;
            this.FC_Home_SetSpeed_Doit.MsgID = 0;
            this.FC_Home_SetSpeed_Doit.Name = "FC_Home_SetSpeed_Doit";
            this.FC_Home_SetSpeed_Doit.NEXT = this.FC_Home_SetSpeed_Done;
            this.FC_Home_SetSpeed_Doit.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetSpeed_Doit.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetSpeed_Doit.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetSpeed_Doit.OverTimeSpec = 100;
            this.FC_Home_SetSpeed_Doit.Running = false;
            this.FC_Home_SetSpeed_Doit.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetSpeed_Doit.SlowRunCycle = -1;
            this.FC_Home_SetSpeed_Doit.StartFC = null;
            this.FC_Home_SetSpeed_Doit.Text = "Do Set Speed Doit";
            this.FC_Home_SetSpeed_Doit.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_SetSpeed_Doit_Run);
            // 
            // FC_Home_SetSpeed_Done
            // 
            this.FC_Home_SetSpeed_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetSpeed_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetSpeed_Done.CASE1 = null;
            this.FC_Home_SetSpeed_Done.CASE2 = null;
            this.FC_Home_SetSpeed_Done.CASE3 = null;
            this.FC_Home_SetSpeed_Done.CASE4 = null;
            this.FC_Home_SetSpeed_Done.ContinueRun = false;
            this.FC_Home_SetSpeed_Done.DesignTimeParent = null;
            this.FC_Home_SetSpeed_Done.EndFC = null;
            this.FC_Home_SetSpeed_Done.ErrID = 0;
            this.FC_Home_SetSpeed_Done.InAlarm = false;
            this.FC_Home_SetSpeed_Done.IsFlowHead = false;
            this.FC_Home_SetSpeed_Done.Location = new System.Drawing.Point(210, 370);
            this.FC_Home_SetSpeed_Done.LockUI = false;
            this.FC_Home_SetSpeed_Done.Message = null;
            this.FC_Home_SetSpeed_Done.MsgID = 0;
            this.FC_Home_SetSpeed_Done.Name = "FC_Home_SetSpeed_Done";
            this.FC_Home_SetSpeed_Done.NEXT = this.FC_Home_SetSWaferType_Doit;
            this.FC_Home_SetSpeed_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetSpeed_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetSpeed_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetSpeed_Done.OverTimeSpec = 100;
            this.FC_Home_SetSpeed_Done.Running = false;
            this.FC_Home_SetSpeed_Done.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetSpeed_Done.SlowRunCycle = -1;
            this.FC_Home_SetSpeed_Done.StartFC = null;
            this.FC_Home_SetSpeed_Done.Text = "Do Set Speed Done";
            this.FC_Home_SetSpeed_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_SetSWaferType_Doit
            // 
            this.FC_Home_SetSWaferType_Doit.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetSWaferType_Doit.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetSWaferType_Doit.CASE1 = this.FC_Home_Pass;
            this.FC_Home_SetSWaferType_Doit.CASE2 = null;
            this.FC_Home_SetSWaferType_Doit.CASE3 = null;
            this.FC_Home_SetSWaferType_Doit.CASE4 = null;
            this.FC_Home_SetSWaferType_Doit.ContinueRun = false;
            this.FC_Home_SetSWaferType_Doit.DesignTimeParent = null;
            this.FC_Home_SetSWaferType_Doit.EndFC = null;
            this.FC_Home_SetSWaferType_Doit.ErrID = 0;
            this.FC_Home_SetSWaferType_Doit.InAlarm = false;
            this.FC_Home_SetSWaferType_Doit.IsFlowHead = false;
            this.FC_Home_SetSWaferType_Doit.Location = new System.Drawing.Point(210, 398);
            this.FC_Home_SetSWaferType_Doit.LockUI = false;
            this.FC_Home_SetSWaferType_Doit.Message = null;
            this.FC_Home_SetSWaferType_Doit.MsgID = 0;
            this.FC_Home_SetSWaferType_Doit.Name = "FC_Home_SetSWaferType_Doit";
            this.FC_Home_SetSWaferType_Doit.NEXT = this.FC_Home_SetWaferType_Done;
            this.FC_Home_SetSWaferType_Doit.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetSWaferType_Doit.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetSWaferType_Doit.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetSWaferType_Doit.OverTimeSpec = 100;
            this.FC_Home_SetSWaferType_Doit.Running = false;
            this.FC_Home_SetSWaferType_Doit.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetSWaferType_Doit.SlowRunCycle = -1;
            this.FC_Home_SetSWaferType_Doit.StartFC = null;
            this.FC_Home_SetSWaferType_Doit.Text = "Do Set WaferType  Doit";
            this.FC_Home_SetSWaferType_Doit.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_SetSWaferType_Doit_Run);
            // 
            // FC_Home_Pass
            // 
            this.FC_Home_Pass.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Pass.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Pass.CASE1 = null;
            this.FC_Home_Pass.CASE2 = null;
            this.FC_Home_Pass.CASE3 = null;
            this.FC_Home_Pass.CASE4 = null;
            this.FC_Home_Pass.ContinueRun = false;
            this.FC_Home_Pass.DesignTimeParent = null;
            this.FC_Home_Pass.EndFC = null;
            this.FC_Home_Pass.ErrID = 0;
            this.FC_Home_Pass.InAlarm = false;
            this.FC_Home_Pass.IsFlowHead = false;
            this.FC_Home_Pass.Location = new System.Drawing.Point(471, 398);
            this.FC_Home_Pass.LockUI = false;
            this.FC_Home_Pass.Message = null;
            this.FC_Home_Pass.MsgID = 0;
            this.FC_Home_Pass.Name = "FC_Home_Pass";
            this.FC_Home_Pass.NEXT = this.FC_Home_SetTime_Doit;
            this.FC_Home_Pass.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Pass.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Pass.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Pass.OverTimeSpec = 100;
            this.FC_Home_Pass.Running = false;
            this.FC_Home_Pass.Size = new System.Drawing.Size(50, 20);
            this.FC_Home_Pass.SlowRunCycle = -1;
            this.FC_Home_Pass.StartFC = null;
            this.FC_Home_Pass.Text = "Pass";
            // 
            // FC_Home_SetTime_Doit
            // 
            this.FC_Home_SetTime_Doit.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetTime_Doit.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetTime_Doit.CASE1 = null;
            this.FC_Home_SetTime_Doit.CASE2 = null;
            this.FC_Home_SetTime_Doit.CASE3 = null;
            this.FC_Home_SetTime_Doit.CASE4 = null;
            this.FC_Home_SetTime_Doit.ContinueRun = false;
            this.FC_Home_SetTime_Doit.DesignTimeParent = null;
            this.FC_Home_SetTime_Doit.EndFC = null;
            this.FC_Home_SetTime_Doit.ErrID = 0;
            this.FC_Home_SetTime_Doit.InAlarm = false;
            this.FC_Home_SetTime_Doit.IsFlowHead = false;
            this.FC_Home_SetTime_Doit.Location = new System.Drawing.Point(210, 454);
            this.FC_Home_SetTime_Doit.LockUI = false;
            this.FC_Home_SetTime_Doit.Message = null;
            this.FC_Home_SetTime_Doit.MsgID = 0;
            this.FC_Home_SetTime_Doit.Name = "FC_Home_SetTime_Doit";
            this.FC_Home_SetTime_Doit.NEXT = this.FC_Home_SetTime_Done;
            this.FC_Home_SetTime_Doit.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetTime_Doit.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetTime_Doit.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetTime_Doit.OverTimeSpec = 100;
            this.FC_Home_SetTime_Doit.Running = false;
            this.FC_Home_SetTime_Doit.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetTime_Doit.SlowRunCycle = -1;
            this.FC_Home_SetTime_Doit.StartFC = null;
            this.FC_Home_SetTime_Doit.Text = "Do Set Time Doit";
            this.FC_Home_SetTime_Doit.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_SetTime_Doit_Run);
            // 
            // FC_Home_SetTime_Done
            // 
            this.FC_Home_SetTime_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetTime_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetTime_Done.CASE1 = null;
            this.FC_Home_SetTime_Done.CASE2 = null;
            this.FC_Home_SetTime_Done.CASE3 = null;
            this.FC_Home_SetTime_Done.CASE4 = null;
            this.FC_Home_SetTime_Done.ContinueRun = false;
            this.FC_Home_SetTime_Done.DesignTimeParent = null;
            this.FC_Home_SetTime_Done.EndFC = null;
            this.FC_Home_SetTime_Done.ErrID = 0;
            this.FC_Home_SetTime_Done.InAlarm = false;
            this.FC_Home_SetTime_Done.IsFlowHead = false;
            this.FC_Home_SetTime_Done.Location = new System.Drawing.Point(210, 482);
            this.FC_Home_SetTime_Done.LockUI = false;
            this.FC_Home_SetTime_Done.Message = null;
            this.FC_Home_SetTime_Done.MsgID = 0;
            this.FC_Home_SetTime_Done.Name = "FC_Home_SetTime_Done";
            this.FC_Home_SetTime_Done.NEXT = this.FC_Home_End;
            this.FC_Home_SetTime_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetTime_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetTime_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetTime_Done.OverTimeSpec = 100;
            this.FC_Home_SetTime_Done.Running = false;
            this.FC_Home_SetTime_Done.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetTime_Done.SlowRunCycle = -1;
            this.FC_Home_SetTime_Done.StartFC = null;
            this.FC_Home_SetTime_Done.Text = "Do Set Time Done";
            this.FC_Home_SetTime_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_End
            // 
            this.FC_Home_End.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_End.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_End.CASE1 = null;
            this.FC_Home_End.CASE2 = null;
            this.FC_Home_End.CASE3 = null;
            this.FC_Home_End.CASE4 = null;
            this.FC_Home_End.ContinueRun = false;
            this.FC_Home_End.DesignTimeParent = null;
            this.FC_Home_End.EndFC = null;
            this.FC_Home_End.ErrID = 0;
            this.FC_Home_End.InAlarm = false;
            this.FC_Home_End.IsFlowHead = false;
            this.FC_Home_End.Location = new System.Drawing.Point(210, 510);
            this.FC_Home_End.LockUI = false;
            this.FC_Home_End.Message = null;
            this.FC_Home_End.MsgID = 0;
            this.FC_Home_End.Name = "FC_Home_End";
            this.FC_Home_End.NEXT = null;
            this.FC_Home_End.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_End.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_End.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_End.OverTimeSpec = 100;
            this.FC_Home_End.Running = false;
            this.FC_Home_End.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_End.SlowRunCycle = -1;
            this.FC_Home_End.StartFC = null;
            this.FC_Home_End.Text = "Home End";
            this.FC_Home_End.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_End_Run);
            // 
            // FC_Home_SetWaferType_Done
            // 
            this.FC_Home_SetWaferType_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_SetWaferType_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_SetWaferType_Done.CASE1 = null;
            this.FC_Home_SetWaferType_Done.CASE2 = null;
            this.FC_Home_SetWaferType_Done.CASE3 = null;
            this.FC_Home_SetWaferType_Done.CASE4 = null;
            this.FC_Home_SetWaferType_Done.ContinueRun = false;
            this.FC_Home_SetWaferType_Done.DesignTimeParent = null;
            this.FC_Home_SetWaferType_Done.EndFC = null;
            this.FC_Home_SetWaferType_Done.ErrID = 0;
            this.FC_Home_SetWaferType_Done.InAlarm = false;
            this.FC_Home_SetWaferType_Done.IsFlowHead = false;
            this.FC_Home_SetWaferType_Done.Location = new System.Drawing.Point(210, 426);
            this.FC_Home_SetWaferType_Done.LockUI = false;
            this.FC_Home_SetWaferType_Done.Message = null;
            this.FC_Home_SetWaferType_Done.MsgID = 0;
            this.FC_Home_SetWaferType_Done.Name = "FC_Home_SetWaferType_Done";
            this.FC_Home_SetWaferType_Done.NEXT = this.FC_Home_SetTime_Doit;
            this.FC_Home_SetWaferType_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_SetWaferType_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_SetWaferType_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_SetWaferType_Done.OverTimeSpec = 100;
            this.FC_Home_SetWaferType_Done.Running = false;
            this.FC_Home_SetWaferType_Done.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_SetWaferType_Done.SlowRunCycle = -1;
            this.FC_Home_SetWaferType_Done.StartFC = null;
            this.FC_Home_SetWaferType_Done.Text = "Do Set WaferType Done";
            this.FC_Home_SetWaferType_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_ChkHasNoWafer
            // 
            this.FC_Home_ChkHasNoWafer.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_ChkHasNoWafer.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_ChkHasNoWafer.CASE1 = this.FC_Home_Retry1;
            this.FC_Home_ChkHasNoWafer.CASE2 = null;
            this.FC_Home_ChkHasNoWafer.CASE3 = null;
            this.FC_Home_ChkHasNoWafer.CASE4 = null;
            this.FC_Home_ChkHasNoWafer.ContinueRun = false;
            this.FC_Home_ChkHasNoWafer.DesignTimeParent = null;
            this.FC_Home_ChkHasNoWafer.EndFC = null;
            this.FC_Home_ChkHasNoWafer.ErrID = 0;
            this.FC_Home_ChkHasNoWafer.InAlarm = false;
            this.FC_Home_ChkHasNoWafer.IsFlowHead = false;
            this.FC_Home_ChkHasNoWafer.Location = new System.Drawing.Point(210, 202);
            this.FC_Home_ChkHasNoWafer.LockUI = false;
            this.FC_Home_ChkHasNoWafer.Message = null;
            this.FC_Home_ChkHasNoWafer.MsgID = 0;
            this.FC_Home_ChkHasNoWafer.Name = "FC_Home_ChkHasNoWafer";
            this.FC_Home_ChkHasNoWafer.NEXT = this.FC_Home_VacOff;
            this.FC_Home_ChkHasNoWafer.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_ChkHasNoWafer.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_ChkHasNoWafer.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_ChkHasNoWafer.OverTimeSpec = 100;
            this.FC_Home_ChkHasNoWafer.Running = false;
            this.FC_Home_ChkHasNoWafer.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_ChkHasNoWafer.SlowRunCycle = -1;
            this.FC_Home_ChkHasNoWafer.StartFC = null;
            this.FC_Home_ChkHasNoWafer.Text = "Chk Has No Wafer";
            this.FC_Home_ChkHasNoWafer.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_ChkHasNoWafer_Run);
            // 
            // FC_Home_Retry1
            // 
            this.FC_Home_Retry1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Retry1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Retry1.CASE1 = null;
            this.FC_Home_Retry1.CASE2 = null;
            this.FC_Home_Retry1.CASE3 = null;
            this.FC_Home_Retry1.CASE4 = null;
            this.FC_Home_Retry1.ContinueRun = false;
            this.FC_Home_Retry1.DesignTimeParent = null;
            this.FC_Home_Retry1.EndFC = null;
            this.FC_Home_Retry1.ErrID = 0;
            this.FC_Home_Retry1.InAlarm = false;
            this.FC_Home_Retry1.IsFlowHead = false;
            this.FC_Home_Retry1.Location = new System.Drawing.Point(471, 202);
            this.FC_Home_Retry1.LockUI = false;
            this.FC_Home_Retry1.Message = null;
            this.FC_Home_Retry1.MsgID = 0;
            this.FC_Home_Retry1.Name = "FC_Home_Retry1";
            this.FC_Home_Retry1.NEXT = this.FC_Home_VacOn;
            this.FC_Home_Retry1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Retry1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Retry1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Retry1.OverTimeSpec = 100;
            this.FC_Home_Retry1.Running = false;
            this.FC_Home_Retry1.Size = new System.Drawing.Size(50, 20);
            this.FC_Home_Retry1.SlowRunCycle = -1;
            this.FC_Home_Retry1.StartFC = null;
            this.FC_Home_Retry1.Text = "Retry";
            this.FC_Home_Retry1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Retry_Run);
            // 
            // FC_Home_VacOn
            // 
            this.FC_Home_VacOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_VacOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_VacOn.CASE1 = null;
            this.FC_Home_VacOn.CASE2 = null;
            this.FC_Home_VacOn.CASE3 = null;
            this.FC_Home_VacOn.CASE4 = null;
            this.FC_Home_VacOn.ContinueRun = false;
            this.FC_Home_VacOn.DesignTimeParent = null;
            this.FC_Home_VacOn.EndFC = null;
            this.FC_Home_VacOn.ErrID = 0;
            this.FC_Home_VacOn.InAlarm = false;
            this.FC_Home_VacOn.IsFlowHead = false;
            this.FC_Home_VacOn.Location = new System.Drawing.Point(210, 91);
            this.FC_Home_VacOn.LockUI = false;
            this.FC_Home_VacOn.Message = null;
            this.FC_Home_VacOn.MsgID = 0;
            this.FC_Home_VacOn.Name = "FC_Home_VacOn";
            this.FC_Home_VacOn.NEXT = this.FC_Home_VacOnDone;
            this.FC_Home_VacOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_VacOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_VacOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_VacOn.OverTimeSpec = 100;
            this.FC_Home_VacOn.Running = false;
            this.FC_Home_VacOn.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_VacOn.SlowRunCycle = -1;
            this.FC_Home_VacOn.StartFC = null;
            this.FC_Home_VacOn.Text = "Vac On";
            this.FC_Home_VacOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_VacOn_Run);
            // 
            // FC_Home_VacOnDone
            // 
            this.FC_Home_VacOnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_VacOnDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_VacOnDone.CASE1 = null;
            this.FC_Home_VacOnDone.CASE2 = null;
            this.FC_Home_VacOnDone.CASE3 = null;
            this.FC_Home_VacOnDone.CASE4 = null;
            this.FC_Home_VacOnDone.ContinueRun = false;
            this.FC_Home_VacOnDone.DesignTimeParent = null;
            this.FC_Home_VacOnDone.EndFC = null;
            this.FC_Home_VacOnDone.ErrID = 0;
            this.FC_Home_VacOnDone.InAlarm = false;
            this.FC_Home_VacOnDone.IsFlowHead = false;
            this.FC_Home_VacOnDone.Location = new System.Drawing.Point(210, 119);
            this.FC_Home_VacOnDone.LockUI = false;
            this.FC_Home_VacOnDone.Message = null;
            this.FC_Home_VacOnDone.MsgID = 0;
            this.FC_Home_VacOnDone.Name = "FC_Home_VacOnDone";
            this.FC_Home_VacOnDone.NEXT = this.FC_Home_GetStatus;
            this.FC_Home_VacOnDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_VacOnDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_VacOnDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_VacOnDone.OverTimeSpec = 100;
            this.FC_Home_VacOnDone.Running = false;
            this.FC_Home_VacOnDone.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_VacOnDone.SlowRunCycle = -1;
            this.FC_Home_VacOnDone.StartFC = null;
            this.FC_Home_VacOnDone.Text = "Vac On Done";
            this.FC_Home_VacOnDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_GetStatus
            // 
            this.FC_Home_GetStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_GetStatus.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_GetStatus.CASE1 = null;
            this.FC_Home_GetStatus.CASE2 = null;
            this.FC_Home_GetStatus.CASE3 = null;
            this.FC_Home_GetStatus.CASE4 = null;
            this.FC_Home_GetStatus.ContinueRun = false;
            this.FC_Home_GetStatus.DesignTimeParent = null;
            this.FC_Home_GetStatus.EndFC = null;
            this.FC_Home_GetStatus.ErrID = 0;
            this.FC_Home_GetStatus.InAlarm = false;
            this.FC_Home_GetStatus.IsFlowHead = false;
            this.FC_Home_GetStatus.Location = new System.Drawing.Point(210, 147);
            this.FC_Home_GetStatus.LockUI = false;
            this.FC_Home_GetStatus.Message = null;
            this.FC_Home_GetStatus.MsgID = 0;
            this.FC_Home_GetStatus.Name = "FC_Home_GetStatus";
            this.FC_Home_GetStatus.NEXT = this.FC_Home_GetStatusDone;
            this.FC_Home_GetStatus.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_GetStatus.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_GetStatus.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_GetStatus.OverTimeSpec = 100;
            this.FC_Home_GetStatus.Running = false;
            this.FC_Home_GetStatus.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_GetStatus.SlowRunCycle = -1;
            this.FC_Home_GetStatus.StartFC = null;
            this.FC_Home_GetStatus.Text = "Get  Status";
            this.FC_Home_GetStatus.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_GetStatus_Run);
            // 
            // FC_Home_GetStatusDone
            // 
            this.FC_Home_GetStatusDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_GetStatusDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_GetStatusDone.CASE1 = null;
            this.FC_Home_GetStatusDone.CASE2 = null;
            this.FC_Home_GetStatusDone.CASE3 = null;
            this.FC_Home_GetStatusDone.CASE4 = null;
            this.FC_Home_GetStatusDone.ContinueRun = false;
            this.FC_Home_GetStatusDone.DesignTimeParent = null;
            this.FC_Home_GetStatusDone.EndFC = null;
            this.FC_Home_GetStatusDone.ErrID = 0;
            this.FC_Home_GetStatusDone.InAlarm = false;
            this.FC_Home_GetStatusDone.IsFlowHead = false;
            this.FC_Home_GetStatusDone.Location = new System.Drawing.Point(210, 175);
            this.FC_Home_GetStatusDone.LockUI = false;
            this.FC_Home_GetStatusDone.Message = null;
            this.FC_Home_GetStatusDone.MsgID = 0;
            this.FC_Home_GetStatusDone.Name = "FC_Home_GetStatusDone";
            this.FC_Home_GetStatusDone.NEXT = this.FC_Home_ChkHasNoWafer;
            this.FC_Home_GetStatusDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_GetStatusDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_GetStatusDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_GetStatusDone.OverTimeSpec = 100;
            this.FC_Home_GetStatusDone.Running = false;
            this.FC_Home_GetStatusDone.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_GetStatusDone.SlowRunCycle = -1;
            this.FC_Home_GetStatusDone.StartFC = null;
            this.FC_Home_GetStatusDone.Text = "Get Status Done";
            this.FC_Home_GetStatusDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_VacOff
            // 
            this.FC_Home_VacOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_VacOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_VacOff.CASE1 = null;
            this.FC_Home_VacOff.CASE2 = null;
            this.FC_Home_VacOff.CASE3 = null;
            this.FC_Home_VacOff.CASE4 = null;
            this.FC_Home_VacOff.ContinueRun = false;
            this.FC_Home_VacOff.DesignTimeParent = null;
            this.FC_Home_VacOff.EndFC = null;
            this.FC_Home_VacOff.ErrID = 0;
            this.FC_Home_VacOff.InAlarm = false;
            this.FC_Home_VacOff.IsFlowHead = false;
            this.FC_Home_VacOff.Location = new System.Drawing.Point(210, 230);
            this.FC_Home_VacOff.LockUI = false;
            this.FC_Home_VacOff.Message = null;
            this.FC_Home_VacOff.MsgID = 0;
            this.FC_Home_VacOff.Name = "FC_Home_VacOff";
            this.FC_Home_VacOff.NEXT = this.FC_Home_VacOffDone;
            this.FC_Home_VacOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_VacOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_VacOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_VacOff.OverTimeSpec = 100;
            this.FC_Home_VacOff.Running = false;
            this.FC_Home_VacOff.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_VacOff.SlowRunCycle = -1;
            this.FC_Home_VacOff.StartFC = null;
            this.FC_Home_VacOff.Text = "Vac Off";
            this.FC_Home_VacOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_VacOff_Run);
            // 
            // FC_Home_VacOffDone
            // 
            this.FC_Home_VacOffDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_VacOffDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_VacOffDone.CASE1 = null;
            this.FC_Home_VacOffDone.CASE2 = null;
            this.FC_Home_VacOffDone.CASE3 = null;
            this.FC_Home_VacOffDone.CASE4 = null;
            this.FC_Home_VacOffDone.ContinueRun = false;
            this.FC_Home_VacOffDone.DesignTimeParent = null;
            this.FC_Home_VacOffDone.EndFC = null;
            this.FC_Home_VacOffDone.ErrID = 0;
            this.FC_Home_VacOffDone.InAlarm = false;
            this.FC_Home_VacOffDone.IsFlowHead = false;
            this.FC_Home_VacOffDone.Location = new System.Drawing.Point(210, 258);
            this.FC_Home_VacOffDone.LockUI = false;
            this.FC_Home_VacOffDone.Message = null;
            this.FC_Home_VacOffDone.MsgID = 0;
            this.FC_Home_VacOffDone.Name = "FC_Home_VacOffDone";
            this.FC_Home_VacOffDone.NEXT = this.FC_Home_DoHome;
            this.FC_Home_VacOffDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_VacOffDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_VacOffDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_VacOffDone.OverTimeSpec = 100;
            this.FC_Home_VacOffDone.Running = false;
            this.FC_Home_VacOffDone.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_VacOffDone.SlowRunCycle = -1;
            this.FC_Home_VacOffDone.StartFC = null;
            this.FC_Home_VacOffDone.Text = "Vac Off Done";
            this.FC_Home_VacOffDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_CommandStart_Next
            // 
            this.FC_Home_CommandStart_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_Next.CASE1 = null;
            this.FC_Home_CommandStart_Next.CASE2 = null;
            this.FC_Home_CommandStart_Next.CASE3 = null;
            this.FC_Home_CommandStart_Next.CASE4 = null;
            this.FC_Home_CommandStart_Next.ContinueRun = false;
            this.FC_Home_CommandStart_Next.DesignTimeParent = null;
            this.FC_Home_CommandStart_Next.EndFC = null;
            this.FC_Home_CommandStart_Next.ErrID = 0;
            this.FC_Home_CommandStart_Next.InAlarm = false;
            this.FC_Home_CommandStart_Next.IsFlowHead = false;
            this.FC_Home_CommandStart_Next.Location = new System.Drawing.Point(716, 144);
            this.FC_Home_CommandStart_Next.LockUI = false;
            this.FC_Home_CommandStart_Next.Message = null;
            this.FC_Home_CommandStart_Next.MsgID = 0;
            this.FC_Home_CommandStart_Next.Name = "FC_Home_CommandStart_Next";
            this.FC_Home_CommandStart_Next.NEXT = this.FC_Home_CommandStart_WaitCommand;
            this.FC_Home_CommandStart_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_Next.OverTimeSpec = 100;
            this.FC_Home_CommandStart_Next.Running = false;
            this.FC_Home_CommandStart_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_Home_CommandStart_Next.SlowRunCycle = -1;
            this.FC_Home_CommandStart_Next.StartFC = null;
            this.FC_Home_CommandStart_Next.Text = "Next";
            this.FC_Home_CommandStart_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Next_Run);
            // 
            // FC_Home_CommandStart_WaitCommand
            // 
            this.FC_Home_CommandStart_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_WaitCommand.CASE1 = null;
            this.FC_Home_CommandStart_WaitCommand.CASE2 = null;
            this.FC_Home_CommandStart_WaitCommand.CASE3 = null;
            this.FC_Home_CommandStart_WaitCommand.CASE4 = null;
            this.FC_Home_CommandStart_WaitCommand.ContinueRun = false;
            this.FC_Home_CommandStart_WaitCommand.DesignTimeParent = null;
            this.FC_Home_CommandStart_WaitCommand.EndFC = null;
            this.FC_Home_CommandStart_WaitCommand.ErrID = 0;
            this.FC_Home_CommandStart_WaitCommand.InAlarm = false;
            this.FC_Home_CommandStart_WaitCommand.IsFlowHead = false;
            this.FC_Home_CommandStart_WaitCommand.Location = new System.Drawing.Point(791, 60);
            this.FC_Home_CommandStart_WaitCommand.LockUI = false;
            this.FC_Home_CommandStart_WaitCommand.Message = null;
            this.FC_Home_CommandStart_WaitCommand.MsgID = 0;
            this.FC_Home_CommandStart_WaitCommand.Name = "FC_Home_CommandStart_WaitCommand";
            this.FC_Home_CommandStart_WaitCommand.NEXT = this.FC_Home_CommandStart_DoCommand;
            this.FC_Home_CommandStart_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_WaitCommand.OverTimeSpec = 100;
            this.FC_Home_CommandStart_WaitCommand.Running = false;
            this.FC_Home_CommandStart_WaitCommand.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_CommandStart_WaitCommand.SlowRunCycle = -1;
            this.FC_Home_CommandStart_WaitCommand.StartFC = null;
            this.FC_Home_CommandStart_WaitCommand.Text = "Wait Command";
            this.FC_Home_CommandStart_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CommandStart_WaitCommand_Run);
            // 
            // FC_Home_CommandStart_DoCommand
            // 
            this.FC_Home_CommandStart_DoCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_DoCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_DoCommand.CASE1 = null;
            this.FC_Home_CommandStart_DoCommand.CASE2 = null;
            this.FC_Home_CommandStart_DoCommand.CASE3 = null;
            this.FC_Home_CommandStart_DoCommand.CASE4 = null;
            this.FC_Home_CommandStart_DoCommand.ContinueRun = false;
            this.FC_Home_CommandStart_DoCommand.DesignTimeParent = null;
            this.FC_Home_CommandStart_DoCommand.EndFC = null;
            this.FC_Home_CommandStart_DoCommand.ErrID = 0;
            this.FC_Home_CommandStart_DoCommand.InAlarm = false;
            this.FC_Home_CommandStart_DoCommand.IsFlowHead = false;
            this.FC_Home_CommandStart_DoCommand.Location = new System.Drawing.Point(791, 88);
            this.FC_Home_CommandStart_DoCommand.LockUI = false;
            this.FC_Home_CommandStart_DoCommand.Message = null;
            this.FC_Home_CommandStart_DoCommand.MsgID = 0;
            this.FC_Home_CommandStart_DoCommand.Name = "FC_Home_CommandStart_DoCommand";
            this.FC_Home_CommandStart_DoCommand.NEXT = this.FC_Home_CommandStart_CommandFinish;
            this.FC_Home_CommandStart_DoCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_DoCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_DoCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_DoCommand.OverTimeSpec = 100;
            this.FC_Home_CommandStart_DoCommand.Running = false;
            this.FC_Home_CommandStart_DoCommand.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_CommandStart_DoCommand.SlowRunCycle = -1;
            this.FC_Home_CommandStart_DoCommand.StartFC = null;
            this.FC_Home_CommandStart_DoCommand.Text = "Do Command";
            this.FC_Home_CommandStart_DoCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CommandStart_DoCommand_Run);
            // 
            // FC_Home_CommandStart_CommandFinish
            // 
            this.FC_Home_CommandStart_CommandFinish.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_CommandFinish.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_CommandFinish.CASE1 = this.FC_Home_CommandStart_Retry;
            this.FC_Home_CommandStart_CommandFinish.CASE2 = null;
            this.FC_Home_CommandStart_CommandFinish.CASE3 = null;
            this.FC_Home_CommandStart_CommandFinish.CASE4 = null;
            this.FC_Home_CommandStart_CommandFinish.ContinueRun = false;
            this.FC_Home_CommandStart_CommandFinish.DesignTimeParent = null;
            this.FC_Home_CommandStart_CommandFinish.EndFC = null;
            this.FC_Home_CommandStart_CommandFinish.ErrID = 0;
            this.FC_Home_CommandStart_CommandFinish.InAlarm = false;
            this.FC_Home_CommandStart_CommandFinish.IsFlowHead = false;
            this.FC_Home_CommandStart_CommandFinish.Location = new System.Drawing.Point(791, 116);
            this.FC_Home_CommandStart_CommandFinish.LockUI = false;
            this.FC_Home_CommandStart_CommandFinish.Message = null;
            this.FC_Home_CommandStart_CommandFinish.MsgID = 0;
            this.FC_Home_CommandStart_CommandFinish.Name = "FC_Home_CommandStart_CommandFinish";
            this.FC_Home_CommandStart_CommandFinish.NEXT = this.FC_Home_CommandStart_Done;
            this.FC_Home_CommandStart_CommandFinish.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_CommandFinish.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_CommandFinish.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_CommandFinish.OverTimeSpec = 100;
            this.FC_Home_CommandStart_CommandFinish.Running = false;
            this.FC_Home_CommandStart_CommandFinish.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_CommandStart_CommandFinish.SlowRunCycle = -1;
            this.FC_Home_CommandStart_CommandFinish.StartFC = null;
            this.FC_Home_CommandStart_CommandFinish.Text = "Command Finish";
            this.FC_Home_CommandStart_CommandFinish.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CommandStart_CommandFinish_Run);
            // 
            // FC_Home_CommandStart_Retry
            // 
            this.FC_Home_CommandStart_Retry.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_Retry.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_Retry.CASE1 = null;
            this.FC_Home_CommandStart_Retry.CASE2 = null;
            this.FC_Home_CommandStart_Retry.CASE3 = null;
            this.FC_Home_CommandStart_Retry.CASE4 = null;
            this.FC_Home_CommandStart_Retry.ContinueRun = false;
            this.FC_Home_CommandStart_Retry.DesignTimeParent = null;
            this.FC_Home_CommandStart_Retry.EndFC = null;
            this.FC_Home_CommandStart_Retry.ErrID = 0;
            this.FC_Home_CommandStart_Retry.InAlarm = false;
            this.FC_Home_CommandStart_Retry.IsFlowHead = false;
            this.FC_Home_CommandStart_Retry.Location = new System.Drawing.Point(1053, 116);
            this.FC_Home_CommandStart_Retry.LockUI = false;
            this.FC_Home_CommandStart_Retry.Message = null;
            this.FC_Home_CommandStart_Retry.MsgID = 0;
            this.FC_Home_CommandStart_Retry.Name = "FC_Home_CommandStart_Retry";
            this.FC_Home_CommandStart_Retry.NEXT = this.FC_Home_CommandStart_DoCommand;
            this.FC_Home_CommandStart_Retry.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_Retry.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_Retry.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_Retry.OverTimeSpec = 100;
            this.FC_Home_CommandStart_Retry.Running = false;
            this.FC_Home_CommandStart_Retry.Size = new System.Drawing.Size(50, 20);
            this.FC_Home_CommandStart_Retry.SlowRunCycle = -1;
            this.FC_Home_CommandStart_Retry.StartFC = null;
            this.FC_Home_CommandStart_Retry.Text = "Retry";
            this.FC_Home_CommandStart_Retry.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Retry_Run);
            // 
            // FC_Home_CommandStart_Done
            // 
            this.FC_Home_CommandStart_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CommandStart_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CommandStart_Done.CASE1 = null;
            this.FC_Home_CommandStart_Done.CASE2 = null;
            this.FC_Home_CommandStart_Done.CASE3 = null;
            this.FC_Home_CommandStart_Done.CASE4 = null;
            this.FC_Home_CommandStart_Done.ContinueRun = false;
            this.FC_Home_CommandStart_Done.DesignTimeParent = null;
            this.FC_Home_CommandStart_Done.EndFC = null;
            this.FC_Home_CommandStart_Done.ErrID = 0;
            this.FC_Home_CommandStart_Done.InAlarm = false;
            this.FC_Home_CommandStart_Done.IsFlowHead = false;
            this.FC_Home_CommandStart_Done.Location = new System.Drawing.Point(791, 144);
            this.FC_Home_CommandStart_Done.LockUI = false;
            this.FC_Home_CommandStart_Done.Message = null;
            this.FC_Home_CommandStart_Done.MsgID = 0;
            this.FC_Home_CommandStart_Done.Name = "FC_Home_CommandStart_Done";
            this.FC_Home_CommandStart_Done.NEXT = this.FC_Home_CommandStart_Next;
            this.FC_Home_CommandStart_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CommandStart_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CommandStart_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CommandStart_Done.OverTimeSpec = 100;
            this.FC_Home_CommandStart_Done.Running = false;
            this.FC_Home_CommandStart_Done.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_CommandStart_Done.SlowRunCycle = -1;
            this.FC_Home_CommandStart_Done.StartFC = null;
            this.FC_Home_CommandStart_Done.Text = "Done";
            this.FC_Home_CommandStart_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CommandStart_Done_Run);
            // 
            // FC_Home_Command_Start
            // 
            this.FC_Home_Command_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Command_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Command_Start.CASE1 = null;
            this.FC_Home_Command_Start.CASE2 = null;
            this.FC_Home_Command_Start.CASE3 = null;
            this.FC_Home_Command_Start.CASE4 = null;
            this.FC_Home_Command_Start.ContinueRun = false;
            this.FC_Home_Command_Start.DesignTimeParent = null;
            this.FC_Home_Command_Start.EndFC = null;
            this.FC_Home_Command_Start.ErrID = 0;
            this.FC_Home_Command_Start.InAlarm = false;
            this.FC_Home_Command_Start.IsFlowHead = false;
            this.FC_Home_Command_Start.Location = new System.Drawing.Point(791, 32);
            this.FC_Home_Command_Start.LockUI = false;
            this.FC_Home_Command_Start.Message = null;
            this.FC_Home_Command_Start.MsgID = 0;
            this.FC_Home_Command_Start.Name = "FC_Home_Command_Start";
            this.FC_Home_Command_Start.NEXT = this.FC_Home_CommandStart_WaitCommand;
            this.FC_Home_Command_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Command_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Command_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Command_Start.OverTimeSpec = 100;
            this.FC_Home_Command_Start.Running = false;
            this.FC_Home_Command_Start.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_Command_Start.SlowRunCycle = -1;
            this.FC_Home_Command_Start.StartFC = null;
            this.FC_Home_Command_Start.Text = "Command Start";
            this.FC_Home_Command_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Command_Start_Run);
            // 
            // FC_Home_Simulation
            // 
            this.FC_Home_Simulation.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Simulation.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Simulation.CASE1 = null;
            this.FC_Home_Simulation.CASE2 = null;
            this.FC_Home_Simulation.CASE3 = null;
            this.FC_Home_Simulation.CASE4 = null;
            this.FC_Home_Simulation.ContinueRun = false;
            this.FC_Home_Simulation.DesignTimeParent = null;
            this.FC_Home_Simulation.EndFC = null;
            this.FC_Home_Simulation.ErrID = 0;
            this.FC_Home_Simulation.InAlarm = false;
            this.FC_Home_Simulation.IsFlowHead = false;
            this.FC_Home_Simulation.Location = new System.Drawing.Point(56, 63);
            this.FC_Home_Simulation.LockUI = false;
            this.FC_Home_Simulation.Message = null;
            this.FC_Home_Simulation.MsgID = 0;
            this.FC_Home_Simulation.Name = "FC_Home_Simulation";
            this.FC_Home_Simulation.NEXT = this.FC_Home_End;
            this.FC_Home_Simulation.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Simulation.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Simulation.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Simulation.OverTimeSpec = 100;
            this.FC_Home_Simulation.Running = false;
            this.FC_Home_Simulation.Size = new System.Drawing.Size(103, 20);
            this.FC_Home_Simulation.SlowRunCycle = -1;
            this.FC_Home_Simulation.StartFC = null;
            this.FC_Home_Simulation.Text = "Simulation";
            this.FC_Home_Simulation.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Simulation_Run);
            // 
            // FC_Home_Connect
            // 
            this.FC_Home_Connect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Connect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Connect.CASE1 = this.FC_Home_Simulation;
            this.FC_Home_Connect.CASE2 = this.FC_Home_Delay;
            this.FC_Home_Connect.CASE3 = null;
            this.FC_Home_Connect.CASE4 = null;
            this.FC_Home_Connect.ContinueRun = false;
            this.FC_Home_Connect.DesignTimeParent = null;
            this.FC_Home_Connect.EndFC = null;
            this.FC_Home_Connect.ErrID = 0;
            this.FC_Home_Connect.InAlarm = false;
            this.FC_Home_Connect.IsFlowHead = false;
            this.FC_Home_Connect.Location = new System.Drawing.Point(210, 63);
            this.FC_Home_Connect.LockUI = false;
            this.FC_Home_Connect.Message = null;
            this.FC_Home_Connect.MsgID = 0;
            this.FC_Home_Connect.Name = "FC_Home_Connect";
            this.FC_Home_Connect.NEXT = this.FC_Home_Reset;
            this.FC_Home_Connect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Connect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Connect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Connect.OverTimeSpec = 100;
            this.FC_Home_Connect.Running = false;
            this.FC_Home_Connect.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_Connect.SlowRunCycle = -1;
            this.FC_Home_Connect.StartFC = null;
            this.FC_Home_Connect.Text = "Connect";
            this.FC_Home_Connect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Connect_Run);
            // 
            // FC_Home_Delay
            // 
            this.FC_Home_Delay.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Delay.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Delay.CASE1 = null;
            this.FC_Home_Delay.CASE2 = null;
            this.FC_Home_Delay.CASE3 = null;
            this.FC_Home_Delay.CASE4 = null;
            this.FC_Home_Delay.ContinueRun = false;
            this.FC_Home_Delay.DesignTimeParent = null;
            this.FC_Home_Delay.EndFC = null;
            this.FC_Home_Delay.ErrID = 0;
            this.FC_Home_Delay.InAlarm = false;
            this.FC_Home_Delay.IsFlowHead = false;
            this.FC_Home_Delay.Location = new System.Drawing.Point(471, 32);
            this.FC_Home_Delay.LockUI = false;
            this.FC_Home_Delay.Message = null;
            this.FC_Home_Delay.MsgID = 0;
            this.FC_Home_Delay.Name = "FC_Home_Delay";
            this.FC_Home_Delay.NEXT = this.FC_Home_Connect;
            this.FC_Home_Delay.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Delay.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Delay.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Delay.OverTimeSpec = 100;
            this.FC_Home_Delay.Running = false;
            this.FC_Home_Delay.Size = new System.Drawing.Size(50, 20);
            this.FC_Home_Delay.SlowRunCycle = -1;
            this.FC_Home_Delay.StartFC = null;
            this.FC_Home_Delay.Text = "Delay";
            this.FC_Home_Delay.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Delay_Run);
            // 
            // FC_Home_Reset
            // 
            this.FC_Home_Reset.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Reset.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Reset.CASE1 = null;
            this.FC_Home_Reset.CASE2 = null;
            this.FC_Home_Reset.CASE3 = null;
            this.FC_Home_Reset.CASE4 = null;
            this.FC_Home_Reset.ContinueRun = false;
            this.FC_Home_Reset.DesignTimeParent = null;
            this.FC_Home_Reset.EndFC = null;
            this.FC_Home_Reset.ErrID = 0;
            this.FC_Home_Reset.InAlarm = false;
            this.FC_Home_Reset.IsFlowHead = false;
            this.FC_Home_Reset.Location = new System.Drawing.Point(471, 63);
            this.FC_Home_Reset.LockUI = false;
            this.FC_Home_Reset.Message = null;
            this.FC_Home_Reset.MsgID = 0;
            this.FC_Home_Reset.Name = "FC_Home_Reset";
            this.FC_Home_Reset.NEXT = this.FC_Home_Reset_Done;
            this.FC_Home_Reset.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Reset.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Reset.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Reset.OverTimeSpec = 100;
            this.FC_Home_Reset.Running = false;
            this.FC_Home_Reset.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_Reset.SlowRunCycle = -1;
            this.FC_Home_Reset.StartFC = null;
            this.FC_Home_Reset.Text = "Reset";
            this.FC_Home_Reset.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Reset_Run);
            // 
            // FC_Home_Reset_Done
            // 
            this.FC_Home_Reset_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Reset_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Reset_Done.CASE1 = null;
            this.FC_Home_Reset_Done.CASE2 = null;
            this.FC_Home_Reset_Done.CASE3 = null;
            this.FC_Home_Reset_Done.CASE4 = null;
            this.FC_Home_Reset_Done.ContinueRun = false;
            this.FC_Home_Reset_Done.DesignTimeParent = null;
            this.FC_Home_Reset_Done.EndFC = null;
            this.FC_Home_Reset_Done.ErrID = 0;
            this.FC_Home_Reset_Done.InAlarm = false;
            this.FC_Home_Reset_Done.IsFlowHead = false;
            this.FC_Home_Reset_Done.Location = new System.Drawing.Point(471, 91);
            this.FC_Home_Reset_Done.LockUI = false;
            this.FC_Home_Reset_Done.Message = null;
            this.FC_Home_Reset_Done.MsgID = 0;
            this.FC_Home_Reset_Done.Name = "FC_Home_Reset_Done";
            this.FC_Home_Reset_Done.NEXT = this.FC_Home_VacOn;
            this.FC_Home_Reset_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Reset_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Reset_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Reset_Done.OverTimeSpec = 100;
            this.FC_Home_Reset_Done.Running = false;
            this.FC_Home_Reset_Done.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_Reset_Done.SlowRunCycle = -1;
            this.FC_Home_Reset_Done.StartFC = null;
            this.FC_Home_Reset_Done.Text = "Reset Done";
            this.FC_Home_Reset_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmdDone_Run);
            // 
            // FC_Home_Start
            // 
            this.FC_Home_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Start.CASE1 = null;
            this.FC_Home_Start.CASE2 = null;
            this.FC_Home_Start.CASE3 = null;
            this.FC_Home_Start.CASE4 = null;
            this.FC_Home_Start.ContinueRun = false;
            this.FC_Home_Start.DesignTimeParent = null;
            this.FC_Home_Start.EndFC = null;
            this.FC_Home_Start.ErrID = 0;
            this.FC_Home_Start.InAlarm = false;
            this.FC_Home_Start.IsFlowHead = false;
            this.FC_Home_Start.Location = new System.Drawing.Point(210, 7);
            this.FC_Home_Start.LockUI = false;
            this.FC_Home_Start.Message = null;
            this.FC_Home_Start.MsgID = 0;
            this.FC_Home_Start.Name = "FC_Home_Start";
            this.FC_Home_Start.NEXT = this.FC_Home_WaitCmd;
            this.FC_Home_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Start.OverTimeSpec = 100;
            this.FC_Home_Start.Running = false;
            this.FC_Home_Start.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_Start.SlowRunCycle = -1;
            this.FC_Home_Start.StartFC = null;
            this.FC_Home_Start.Text = "Home Start";
            this.FC_Home_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Start_Run);
            // 
            // FC_Home_WaitCmd
            // 
            this.FC_Home_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_WaitCmd.CASE1 = null;
            this.FC_Home_WaitCmd.CASE2 = null;
            this.FC_Home_WaitCmd.CASE3 = null;
            this.FC_Home_WaitCmd.CASE4 = null;
            this.FC_Home_WaitCmd.ContinueRun = false;
            this.FC_Home_WaitCmd.DesignTimeParent = null;
            this.FC_Home_WaitCmd.EndFC = null;
            this.FC_Home_WaitCmd.ErrID = 0;
            this.FC_Home_WaitCmd.InAlarm = false;
            this.FC_Home_WaitCmd.IsFlowHead = false;
            this.FC_Home_WaitCmd.Location = new System.Drawing.Point(210, 35);
            this.FC_Home_WaitCmd.LockUI = false;
            this.FC_Home_WaitCmd.Message = null;
            this.FC_Home_WaitCmd.MsgID = 0;
            this.FC_Home_WaitCmd.Name = "FC_Home_WaitCmd";
            this.FC_Home_WaitCmd.NEXT = this.FC_Home_Connect;
            this.FC_Home_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_WaitCmd.OverTimeSpec = 100;
            this.FC_Home_WaitCmd.Running = false;
            this.FC_Home_WaitCmd.Size = new System.Drawing.Size(228, 20);
            this.FC_Home_WaitCmd.SlowRunCycle = -1;
            this.FC_Home_WaitCmd.StartFC = null;
            this.FC_Home_WaitCmd.Text = "Wait Command";
            this.FC_Home_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmd_Run);
            // 
            // dFieldEdit12
            // 
            this.dFieldEdit12.AutoFocus = false;
            this.dFieldEdit12.Caption = "Speed";
            this.dFieldEdit12.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit12.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit12.DataName = "Aligner_Speed";
            this.dFieldEdit12.DataSource = this.SetDS;
            this.dFieldEdit12.DefaultValue = "10";
            this.dFieldEdit12.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit12.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit12.EditWidth = 150;
            this.dFieldEdit12.FieldValue = "";
            this.dFieldEdit12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit12.IsModified = false;
            this.dFieldEdit12.Location = new System.Drawing.Point(35, 128);
            this.dFieldEdit12.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit12.MaxValue = 100D;
            this.dFieldEdit12.MinValue = 10D;
            this.dFieldEdit12.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit12.Name = "dFieldEdit12";
            this.dFieldEdit12.NoChangeInAuto = false;
            this.dFieldEdit12.Size = new System.Drawing.Size(369, 29);
            this.dFieldEdit12.StepValue = 0D;
            this.dFieldEdit12.TabIndex = 18;
            this.dFieldEdit12.Unit = "%";
            this.dFieldEdit12.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit12.UnitWidth = 50;
            this.dFieldEdit12.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit2
            // 
            this.dFieldEdit2.AutoFocus = false;
            this.dFieldEdit2.Caption = "Aligner Action Timeout";
            this.dFieldEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.DataName = "Aligner_Timeout";
            this.dFieldEdit2.DataSource = this.SetDS;
            this.dFieldEdit2.DefaultValue = null;
            this.dFieldEdit2.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.EditWidth = 100;
            this.dFieldEdit2.FieldValue = "0";
            this.dFieldEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.IsModified = false;
            this.dFieldEdit2.Location = new System.Drawing.Point(47, 104);
            this.dFieldEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit2.MaxValue = 2000000D;
            this.dFieldEdit2.MinValue = 0D;
            this.dFieldEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit2.Name = "dFieldEdit2";
            this.dFieldEdit2.NoChangeInAuto = false;
            this.dFieldEdit2.Size = new System.Drawing.Size(419, 29);
            this.dFieldEdit2.StepValue = 0D;
            this.dFieldEdit2.TabIndex = 7;
            this.dFieldEdit2.Unit = "ms";
            this.dFieldEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.UnitWidth = 80;
            this.dFieldEdit2.ValueType = KCSDK.ValueDataType.Int;
            // 
            // FC_Auto_Align_Next
            // 
            this.FC_Auto_Align_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_Next.CASE1 = null;
            this.FC_Auto_Align_Next.CASE2 = null;
            this.FC_Auto_Align_Next.CASE3 = null;
            this.FC_Auto_Align_Next.CASE4 = null;
            this.FC_Auto_Align_Next.ContinueRun = false;
            this.FC_Auto_Align_Next.DesignTimeParent = null;
            this.FC_Auto_Align_Next.EndFC = null;
            this.FC_Auto_Align_Next.ErrID = 0;
            this.FC_Auto_Align_Next.InAlarm = false;
            this.FC_Auto_Align_Next.IsFlowHead = false;
            this.FC_Auto_Align_Next.Location = new System.Drawing.Point(644, 241);
            this.FC_Auto_Align_Next.LockUI = false;
            this.FC_Auto_Align_Next.Message = null;
            this.FC_Auto_Align_Next.MsgID = 0;
            this.FC_Auto_Align_Next.Name = "FC_Auto_Align_Next";
            this.FC_Auto_Align_Next.NEXT = this.FC_Auto_Align_WaitCommand;
            this.FC_Auto_Align_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_Next.OverTimeSpec = 100;
            this.FC_Auto_Align_Next.Running = false;
            this.FC_Auto_Align_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_Auto_Align_Next.SlowRunCycle = -1;
            this.FC_Auto_Align_Next.StartFC = null;
            this.FC_Auto_Align_Next.Text = "Next";
            this.FC_Auto_Align_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Next_Run);
            // 
            // FC_Auto_Align_WaitCommand
            // 
            this.FC_Auto_Align_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_WaitCommand.CASE1 = null;
            this.FC_Auto_Align_WaitCommand.CASE2 = null;
            this.FC_Auto_Align_WaitCommand.CASE3 = null;
            this.FC_Auto_Align_WaitCommand.CASE4 = null;
            this.FC_Auto_Align_WaitCommand.ContinueRun = false;
            this.FC_Auto_Align_WaitCommand.DesignTimeParent = null;
            this.FC_Auto_Align_WaitCommand.EndFC = null;
            this.FC_Auto_Align_WaitCommand.ErrID = 0;
            this.FC_Auto_Align_WaitCommand.InAlarm = false;
            this.FC_Auto_Align_WaitCommand.IsFlowHead = false;
            this.FC_Auto_Align_WaitCommand.Location = new System.Drawing.Point(729, 45);
            this.FC_Auto_Align_WaitCommand.LockUI = false;
            this.FC_Auto_Align_WaitCommand.Message = null;
            this.FC_Auto_Align_WaitCommand.MsgID = 0;
            this.FC_Auto_Align_WaitCommand.Name = "FC_Auto_Align_WaitCommand";
            this.FC_Auto_Align_WaitCommand.NEXT = this.FC_Auto_Align_DoVacOn;
            this.FC_Auto_Align_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_WaitCommand.OverTimeSpec = 100;
            this.FC_Auto_Align_WaitCommand.Running = false;
            this.FC_Auto_Align_WaitCommand.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_WaitCommand.SlowRunCycle = -1;
            this.FC_Auto_Align_WaitCommand.StartFC = null;
            this.FC_Auto_Align_WaitCommand.Text = "Wait Command";
            this.FC_Auto_Align_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_WaitCommand_Run);
            // 
            // FC_Auto_Align_DoVacOn
            // 
            this.FC_Auto_Align_DoVacOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_DoVacOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_DoVacOn.CASE1 = null;
            this.FC_Auto_Align_DoVacOn.CASE2 = null;
            this.FC_Auto_Align_DoVacOn.CASE3 = null;
            this.FC_Auto_Align_DoVacOn.CASE4 = null;
            this.FC_Auto_Align_DoVacOn.ContinueRun = false;
            this.FC_Auto_Align_DoVacOn.DesignTimeParent = null;
            this.FC_Auto_Align_DoVacOn.EndFC = null;
            this.FC_Auto_Align_DoVacOn.ErrID = 0;
            this.FC_Auto_Align_DoVacOn.InAlarm = false;
            this.FC_Auto_Align_DoVacOn.IsFlowHead = false;
            this.FC_Auto_Align_DoVacOn.Location = new System.Drawing.Point(729, 73);
            this.FC_Auto_Align_DoVacOn.LockUI = false;
            this.FC_Auto_Align_DoVacOn.Message = null;
            this.FC_Auto_Align_DoVacOn.MsgID = 0;
            this.FC_Auto_Align_DoVacOn.Name = "FC_Auto_Align_DoVacOn";
            this.FC_Auto_Align_DoVacOn.NEXT = this.FC_Auto_Align_VacOnDone;
            this.FC_Auto_Align_DoVacOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_DoVacOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_DoVacOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_DoVacOn.OverTimeSpec = 100;
            this.FC_Auto_Align_DoVacOn.Running = false;
            this.FC_Auto_Align_DoVacOn.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_DoVacOn.SlowRunCycle = -1;
            this.FC_Auto_Align_DoVacOn.StartFC = null;
            this.FC_Auto_Align_DoVacOn.Text = "Do Vacuum On";
            this.FC_Auto_Align_DoVacOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_DoVacOn_Run);
            // 
            // FC_Auto_Align_VacOnDone
            // 
            this.FC_Auto_Align_VacOnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_VacOnDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_VacOnDone.CASE1 = this.FC_Auto_Align_FailAction3;
            this.FC_Auto_Align_VacOnDone.CASE2 = null;
            this.FC_Auto_Align_VacOnDone.CASE3 = null;
            this.FC_Auto_Align_VacOnDone.CASE4 = null;
            this.FC_Auto_Align_VacOnDone.ContinueRun = false;
            this.FC_Auto_Align_VacOnDone.DesignTimeParent = null;
            this.FC_Auto_Align_VacOnDone.EndFC = null;
            this.FC_Auto_Align_VacOnDone.ErrID = 0;
            this.FC_Auto_Align_VacOnDone.InAlarm = false;
            this.FC_Auto_Align_VacOnDone.IsFlowHead = false;
            this.FC_Auto_Align_VacOnDone.Location = new System.Drawing.Point(729, 101);
            this.FC_Auto_Align_VacOnDone.LockUI = false;
            this.FC_Auto_Align_VacOnDone.Message = null;
            this.FC_Auto_Align_VacOnDone.MsgID = 0;
            this.FC_Auto_Align_VacOnDone.Name = "FC_Auto_Align_VacOnDone";
            this.FC_Auto_Align_VacOnDone.NEXT = this.FC_Auto_Align_DoPreAlign;
            this.FC_Auto_Align_VacOnDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_VacOnDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_VacOnDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_VacOnDone.OverTimeSpec = 100;
            this.FC_Auto_Align_VacOnDone.Running = false;
            this.FC_Auto_Align_VacOnDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_VacOnDone.SlowRunCycle = -1;
            this.FC_Auto_Align_VacOnDone.StartFC = null;
            this.FC_Auto_Align_VacOnDone.Text = "Vacuum On Done";
            this.FC_Auto_Align_VacOnDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_VacOnDone_Run);
            // 
            // FC_Auto_Align_FailAction3
            // 
            this.FC_Auto_Align_FailAction3.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_FailAction3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_FailAction3.CASE1 = null;
            this.FC_Auto_Align_FailAction3.CASE2 = null;
            this.FC_Auto_Align_FailAction3.CASE3 = null;
            this.FC_Auto_Align_FailAction3.CASE4 = null;
            this.FC_Auto_Align_FailAction3.ContinueRun = false;
            this.FC_Auto_Align_FailAction3.DesignTimeParent = null;
            this.FC_Auto_Align_FailAction3.EndFC = null;
            this.FC_Auto_Align_FailAction3.ErrID = 0;
            this.FC_Auto_Align_FailAction3.InAlarm = false;
            this.FC_Auto_Align_FailAction3.IsFlowHead = false;
            this.FC_Auto_Align_FailAction3.Location = new System.Drawing.Point(970, 101);
            this.FC_Auto_Align_FailAction3.LockUI = false;
            this.FC_Auto_Align_FailAction3.Message = null;
            this.FC_Auto_Align_FailAction3.MsgID = 0;
            this.FC_Auto_Align_FailAction3.Name = "FC_Auto_Align_FailAction3";
            this.FC_Auto_Align_FailAction3.NEXT = this.FC_Auto_Align_DoVacOn;
            this.FC_Auto_Align_FailAction3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_FailAction3.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_FailAction3.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_FailAction3.OverTimeSpec = 100;
            this.FC_Auto_Align_FailAction3.Running = false;
            this.FC_Auto_Align_FailAction3.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_FailAction3.SlowRunCycle = -1;
            this.FC_Auto_Align_FailAction3.StartFC = null;
            this.FC_Auto_Align_FailAction3.Text = "Fail Action";
            this.FC_Auto_Align_FailAction3.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_FailAction_Run);
            // 
            // FC_Auto_Align_DoPreAlign
            // 
            this.FC_Auto_Align_DoPreAlign.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_DoPreAlign.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_DoPreAlign.CASE1 = null;
            this.FC_Auto_Align_DoPreAlign.CASE2 = null;
            this.FC_Auto_Align_DoPreAlign.CASE3 = null;
            this.FC_Auto_Align_DoPreAlign.CASE4 = null;
            this.FC_Auto_Align_DoPreAlign.ContinueRun = false;
            this.FC_Auto_Align_DoPreAlign.DesignTimeParent = null;
            this.FC_Auto_Align_DoPreAlign.EndFC = null;
            this.FC_Auto_Align_DoPreAlign.ErrID = 0;
            this.FC_Auto_Align_DoPreAlign.InAlarm = false;
            this.FC_Auto_Align_DoPreAlign.IsFlowHead = false;
            this.FC_Auto_Align_DoPreAlign.Location = new System.Drawing.Point(729, 129);
            this.FC_Auto_Align_DoPreAlign.LockUI = false;
            this.FC_Auto_Align_DoPreAlign.Message = null;
            this.FC_Auto_Align_DoPreAlign.MsgID = 0;
            this.FC_Auto_Align_DoPreAlign.Name = "FC_Auto_Align_DoPreAlign";
            this.FC_Auto_Align_DoPreAlign.NEXT = this.FC_Auto_Align_PreAlignDone;
            this.FC_Auto_Align_DoPreAlign.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_DoPreAlign.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_DoPreAlign.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_DoPreAlign.OverTimeSpec = 100;
            this.FC_Auto_Align_DoPreAlign.Running = false;
            this.FC_Auto_Align_DoPreAlign.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_DoPreAlign.SlowRunCycle = -1;
            this.FC_Auto_Align_DoPreAlign.StartFC = null;
            this.FC_Auto_Align_DoPreAlign.Text = "Do PreAlign";
            this.FC_Auto_Align_DoPreAlign.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_DoPreAlign_Run);
            // 
            // FC_Auto_Align_PreAlignDone
            // 
            this.FC_Auto_Align_PreAlignDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_PreAlignDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_PreAlignDone.CASE1 = this.FC_Auto_Align_FailAction2;
            this.FC_Auto_Align_PreAlignDone.CASE2 = null;
            this.FC_Auto_Align_PreAlignDone.CASE3 = null;
            this.FC_Auto_Align_PreAlignDone.CASE4 = null;
            this.FC_Auto_Align_PreAlignDone.ContinueRun = false;
            this.FC_Auto_Align_PreAlignDone.DesignTimeParent = null;
            this.FC_Auto_Align_PreAlignDone.EndFC = null;
            this.FC_Auto_Align_PreAlignDone.ErrID = 0;
            this.FC_Auto_Align_PreAlignDone.InAlarm = false;
            this.FC_Auto_Align_PreAlignDone.IsFlowHead = false;
            this.FC_Auto_Align_PreAlignDone.Location = new System.Drawing.Point(729, 157);
            this.FC_Auto_Align_PreAlignDone.LockUI = false;
            this.FC_Auto_Align_PreAlignDone.Message = null;
            this.FC_Auto_Align_PreAlignDone.MsgID = 0;
            this.FC_Auto_Align_PreAlignDone.Name = "FC_Auto_Align_PreAlignDone";
            this.FC_Auto_Align_PreAlignDone.NEXT = this.FC_Auto_Align_DoAction;
            this.FC_Auto_Align_PreAlignDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_PreAlignDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_PreAlignDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_PreAlignDone.OverTimeSpec = 100;
            this.FC_Auto_Align_PreAlignDone.Running = false;
            this.FC_Auto_Align_PreAlignDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_PreAlignDone.SlowRunCycle = -1;
            this.FC_Auto_Align_PreAlignDone.StartFC = null;
            this.FC_Auto_Align_PreAlignDone.Text = "PreAlign Done";
            this.FC_Auto_Align_PreAlignDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_PreAlignDone_Run);
            // 
            // FC_Auto_Align_FailAction2
            // 
            this.FC_Auto_Align_FailAction2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_FailAction2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_FailAction2.CASE1 = null;
            this.FC_Auto_Align_FailAction2.CASE2 = null;
            this.FC_Auto_Align_FailAction2.CASE3 = null;
            this.FC_Auto_Align_FailAction2.CASE4 = null;
            this.FC_Auto_Align_FailAction2.ContinueRun = false;
            this.FC_Auto_Align_FailAction2.DesignTimeParent = null;
            this.FC_Auto_Align_FailAction2.EndFC = null;
            this.FC_Auto_Align_FailAction2.ErrID = 0;
            this.FC_Auto_Align_FailAction2.InAlarm = false;
            this.FC_Auto_Align_FailAction2.IsFlowHead = false;
            this.FC_Auto_Align_FailAction2.Location = new System.Drawing.Point(970, 157);
            this.FC_Auto_Align_FailAction2.LockUI = false;
            this.FC_Auto_Align_FailAction2.Message = null;
            this.FC_Auto_Align_FailAction2.MsgID = 0;
            this.FC_Auto_Align_FailAction2.Name = "FC_Auto_Align_FailAction2";
            this.FC_Auto_Align_FailAction2.NEXT = this.FC_Auto_Align_DoVacOn;
            this.FC_Auto_Align_FailAction2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_FailAction2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_FailAction2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_FailAction2.OverTimeSpec = 100;
            this.FC_Auto_Align_FailAction2.Running = false;
            this.FC_Auto_Align_FailAction2.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_FailAction2.SlowRunCycle = -1;
            this.FC_Auto_Align_FailAction2.StartFC = null;
            this.FC_Auto_Align_FailAction2.Text = "Fail Action";
            this.FC_Auto_Align_FailAction2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_FailAction_Run);
            // 
            // FC_Auto_Align_DoAction
            // 
            this.FC_Auto_Align_DoAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_DoAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_DoAction.CASE1 = null;
            this.FC_Auto_Align_DoAction.CASE2 = null;
            this.FC_Auto_Align_DoAction.CASE3 = null;
            this.FC_Auto_Align_DoAction.CASE4 = null;
            this.FC_Auto_Align_DoAction.ContinueRun = false;
            this.FC_Auto_Align_DoAction.DesignTimeParent = null;
            this.FC_Auto_Align_DoAction.EndFC = null;
            this.FC_Auto_Align_DoAction.ErrID = 0;
            this.FC_Auto_Align_DoAction.InAlarm = false;
            this.FC_Auto_Align_DoAction.IsFlowHead = false;
            this.FC_Auto_Align_DoAction.Location = new System.Drawing.Point(729, 185);
            this.FC_Auto_Align_DoAction.LockUI = false;
            this.FC_Auto_Align_DoAction.Message = null;
            this.FC_Auto_Align_DoAction.MsgID = 0;
            this.FC_Auto_Align_DoAction.Name = "FC_Auto_Align_DoAction";
            this.FC_Auto_Align_DoAction.NEXT = this.FC_Auto_Align_DoActionDone;
            this.FC_Auto_Align_DoAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_DoAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_DoAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_DoAction.OverTimeSpec = 100;
            this.FC_Auto_Align_DoAction.Running = false;
            this.FC_Auto_Align_DoAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_DoAction.SlowRunCycle = -1;
            this.FC_Auto_Align_DoAction.StartFC = null;
            this.FC_Auto_Align_DoAction.Text = "Do Action";
            this.FC_Auto_Align_DoAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_DoAction_Run);
            // 
            // FC_Auto_Align_DoActionDone
            // 
            this.FC_Auto_Align_DoActionDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_DoActionDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_DoActionDone.CASE1 = this.FC_Auto_Align_FailAction;
            this.FC_Auto_Align_DoActionDone.CASE2 = null;
            this.FC_Auto_Align_DoActionDone.CASE3 = null;
            this.FC_Auto_Align_DoActionDone.CASE4 = null;
            this.FC_Auto_Align_DoActionDone.ContinueRun = false;
            this.FC_Auto_Align_DoActionDone.DesignTimeParent = null;
            this.FC_Auto_Align_DoActionDone.EndFC = null;
            this.FC_Auto_Align_DoActionDone.ErrID = 0;
            this.FC_Auto_Align_DoActionDone.InAlarm = false;
            this.FC_Auto_Align_DoActionDone.IsFlowHead = false;
            this.FC_Auto_Align_DoActionDone.Location = new System.Drawing.Point(729, 213);
            this.FC_Auto_Align_DoActionDone.LockUI = false;
            this.FC_Auto_Align_DoActionDone.Message = null;
            this.FC_Auto_Align_DoActionDone.MsgID = 0;
            this.FC_Auto_Align_DoActionDone.Name = "FC_Auto_Align_DoActionDone";
            this.FC_Auto_Align_DoActionDone.NEXT = this.FC_Auto_Align_Done;
            this.FC_Auto_Align_DoActionDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_DoActionDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_DoActionDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_DoActionDone.OverTimeSpec = 100;
            this.FC_Auto_Align_DoActionDone.Running = false;
            this.FC_Auto_Align_DoActionDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_DoActionDone.SlowRunCycle = -1;
            this.FC_Auto_Align_DoActionDone.StartFC = null;
            this.FC_Auto_Align_DoActionDone.Text = "Do Action Done";
            this.FC_Auto_Align_DoActionDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_DoActionDone_Run);
            // 
            // FC_Auto_Align_FailAction
            // 
            this.FC_Auto_Align_FailAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_FailAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_FailAction.CASE1 = null;
            this.FC_Auto_Align_FailAction.CASE2 = null;
            this.FC_Auto_Align_FailAction.CASE3 = null;
            this.FC_Auto_Align_FailAction.CASE4 = null;
            this.FC_Auto_Align_FailAction.ContinueRun = false;
            this.FC_Auto_Align_FailAction.DesignTimeParent = null;
            this.FC_Auto_Align_FailAction.EndFC = null;
            this.FC_Auto_Align_FailAction.ErrID = 0;
            this.FC_Auto_Align_FailAction.InAlarm = false;
            this.FC_Auto_Align_FailAction.IsFlowHead = false;
            this.FC_Auto_Align_FailAction.Location = new System.Drawing.Point(970, 213);
            this.FC_Auto_Align_FailAction.LockUI = false;
            this.FC_Auto_Align_FailAction.Message = null;
            this.FC_Auto_Align_FailAction.MsgID = 0;
            this.FC_Auto_Align_FailAction.Name = "FC_Auto_Align_FailAction";
            this.FC_Auto_Align_FailAction.NEXT = this.FC_Auto_Align_DoVacOn;
            this.FC_Auto_Align_FailAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_FailAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_FailAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_FailAction.OverTimeSpec = 100;
            this.FC_Auto_Align_FailAction.Running = false;
            this.FC_Auto_Align_FailAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_FailAction.SlowRunCycle = -1;
            this.FC_Auto_Align_FailAction.StartFC = null;
            this.FC_Auto_Align_FailAction.Text = "Fail Action";
            this.FC_Auto_Align_FailAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_FailAction_Run);
            // 
            // FC_Auto_Align_Done
            // 
            this.FC_Auto_Align_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_Done.CASE1 = null;
            this.FC_Auto_Align_Done.CASE2 = null;
            this.FC_Auto_Align_Done.CASE3 = null;
            this.FC_Auto_Align_Done.CASE4 = null;
            this.FC_Auto_Align_Done.ContinueRun = false;
            this.FC_Auto_Align_Done.DesignTimeParent = null;
            this.FC_Auto_Align_Done.EndFC = null;
            this.FC_Auto_Align_Done.ErrID = 0;
            this.FC_Auto_Align_Done.InAlarm = false;
            this.FC_Auto_Align_Done.IsFlowHead = false;
            this.FC_Auto_Align_Done.Location = new System.Drawing.Point(729, 241);
            this.FC_Auto_Align_Done.LockUI = false;
            this.FC_Auto_Align_Done.Message = null;
            this.FC_Auto_Align_Done.MsgID = 0;
            this.FC_Auto_Align_Done.Name = "FC_Auto_Align_Done";
            this.FC_Auto_Align_Done.NEXT = this.FC_Auto_Align_Next;
            this.FC_Auto_Align_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_Done.OverTimeSpec = 100;
            this.FC_Auto_Align_Done.Running = false;
            this.FC_Auto_Align_Done.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_Done.SlowRunCycle = -1;
            this.FC_Auto_Align_Done.StartFC = null;
            this.FC_Auto_Align_Done.Text = "Done";
            this.FC_Auto_Align_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_Done_Run);
            // 
            // FC_Auto_Align_Start
            // 
            this.FC_Auto_Align_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Align_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Align_Start.CASE1 = null;
            this.FC_Auto_Align_Start.CASE2 = null;
            this.FC_Auto_Align_Start.CASE3 = null;
            this.FC_Auto_Align_Start.CASE4 = null;
            this.FC_Auto_Align_Start.ContinueRun = false;
            this.FC_Auto_Align_Start.DesignTimeParent = null;
            this.FC_Auto_Align_Start.EndFC = null;
            this.FC_Auto_Align_Start.ErrID = 0;
            this.FC_Auto_Align_Start.InAlarm = false;
            this.FC_Auto_Align_Start.IsFlowHead = false;
            this.FC_Auto_Align_Start.Location = new System.Drawing.Point(729, 17);
            this.FC_Auto_Align_Start.LockUI = false;
            this.FC_Auto_Align_Start.Message = null;
            this.FC_Auto_Align_Start.MsgID = 0;
            this.FC_Auto_Align_Start.Name = "FC_Auto_Align_Start";
            this.FC_Auto_Align_Start.NEXT = this.FC_Auto_Align_WaitCommand;
            this.FC_Auto_Align_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Align_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Align_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Align_Start.OverTimeSpec = 100;
            this.FC_Auto_Align_Start.Running = false;
            this.FC_Auto_Align_Start.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_Align_Start.SlowRunCycle = -1;
            this.FC_Auto_Align_Start.StartFC = null;
            this.FC_Auto_Align_Start.Text = "Align Start";
            this.FC_Auto_Align_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Align_Start_Run);
            // 
            // FC_Auto_VaccumSW_Next
            // 
            this.FC_Auto_VaccumSW_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_Next.CASE1 = null;
            this.FC_Auto_VaccumSW_Next.CASE2 = null;
            this.FC_Auto_VaccumSW_Next.CASE3 = null;
            this.FC_Auto_VaccumSW_Next.CASE4 = null;
            this.FC_Auto_VaccumSW_Next.ContinueRun = false;
            this.FC_Auto_VaccumSW_Next.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_Next.EndFC = null;
            this.FC_Auto_VaccumSW_Next.ErrID = 0;
            this.FC_Auto_VaccumSW_Next.InAlarm = false;
            this.FC_Auto_VaccumSW_Next.IsFlowHead = false;
            this.FC_Auto_VaccumSW_Next.Location = new System.Drawing.Point(57, 152);
            this.FC_Auto_VaccumSW_Next.LockUI = false;
            this.FC_Auto_VaccumSW_Next.Message = null;
            this.FC_Auto_VaccumSW_Next.MsgID = 0;
            this.FC_Auto_VaccumSW_Next.Name = "FC_Auto_VaccumSW_Next";
            this.FC_Auto_VaccumSW_Next.NEXT = this.FC_Auto_VaccumSW_WaitCommand;
            this.FC_Auto_VaccumSW_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_Next.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_Next.Running = false;
            this.FC_Auto_VaccumSW_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_Auto_VaccumSW_Next.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_Next.StartFC = null;
            this.FC_Auto_VaccumSW_Next.Text = "Next";
            this.FC_Auto_VaccumSW_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Next_Run);
            // 
            // FC_Auto_VaccumSW_WaitCommand
            // 
            this.FC_Auto_VaccumSW_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_WaitCommand.CASE1 = null;
            this.FC_Auto_VaccumSW_WaitCommand.CASE2 = null;
            this.FC_Auto_VaccumSW_WaitCommand.CASE3 = null;
            this.FC_Auto_VaccumSW_WaitCommand.CASE4 = null;
            this.FC_Auto_VaccumSW_WaitCommand.ContinueRun = false;
            this.FC_Auto_VaccumSW_WaitCommand.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_WaitCommand.EndFC = null;
            this.FC_Auto_VaccumSW_WaitCommand.ErrID = 0;
            this.FC_Auto_VaccumSW_WaitCommand.InAlarm = false;
            this.FC_Auto_VaccumSW_WaitCommand.IsFlowHead = false;
            this.FC_Auto_VaccumSW_WaitCommand.Location = new System.Drawing.Point(142, 68);
            this.FC_Auto_VaccumSW_WaitCommand.LockUI = false;
            this.FC_Auto_VaccumSW_WaitCommand.Message = null;
            this.FC_Auto_VaccumSW_WaitCommand.MsgID = 0;
            this.FC_Auto_VaccumSW_WaitCommand.Name = "FC_Auto_VaccumSW_WaitCommand";
            this.FC_Auto_VaccumSW_WaitCommand.NEXT = this.FC_Auto_VaccumSW_DoAction;
            this.FC_Auto_VaccumSW_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_WaitCommand.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_WaitCommand.Running = false;
            this.FC_Auto_VaccumSW_WaitCommand.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_WaitCommand.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_WaitCommand.StartFC = null;
            this.FC_Auto_VaccumSW_WaitCommand.Text = "Wait Command";
            this.FC_Auto_VaccumSW_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_WaitCommand_Run);
            // 
            // FC_Auto_VaccumSW_DoAction
            // 
            this.FC_Auto_VaccumSW_DoAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_DoAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_DoAction.CASE1 = null;
            this.FC_Auto_VaccumSW_DoAction.CASE2 = null;
            this.FC_Auto_VaccumSW_DoAction.CASE3 = null;
            this.FC_Auto_VaccumSW_DoAction.CASE4 = null;
            this.FC_Auto_VaccumSW_DoAction.ContinueRun = false;
            this.FC_Auto_VaccumSW_DoAction.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_DoAction.EndFC = null;
            this.FC_Auto_VaccumSW_DoAction.ErrID = 0;
            this.FC_Auto_VaccumSW_DoAction.InAlarm = false;
            this.FC_Auto_VaccumSW_DoAction.IsFlowHead = false;
            this.FC_Auto_VaccumSW_DoAction.Location = new System.Drawing.Point(142, 96);
            this.FC_Auto_VaccumSW_DoAction.LockUI = false;
            this.FC_Auto_VaccumSW_DoAction.Message = null;
            this.FC_Auto_VaccumSW_DoAction.MsgID = 0;
            this.FC_Auto_VaccumSW_DoAction.Name = "FC_Auto_VaccumSW_DoAction";
            this.FC_Auto_VaccumSW_DoAction.NEXT = this.FC_Auto_VaccumSW_DoActionDone;
            this.FC_Auto_VaccumSW_DoAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_DoAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_DoAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_DoAction.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_DoAction.Running = false;
            this.FC_Auto_VaccumSW_DoAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_DoAction.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_DoAction.StartFC = null;
            this.FC_Auto_VaccumSW_DoAction.Text = "Do Action";
            this.FC_Auto_VaccumSW_DoAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_DoAction_Run);
            // 
            // FC_Auto_VaccumSW_DoActionDone
            // 
            this.FC_Auto_VaccumSW_DoActionDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_DoActionDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_DoActionDone.CASE1 = this.FC_Auto_VaccumSW_FailAction;
            this.FC_Auto_VaccumSW_DoActionDone.CASE2 = null;
            this.FC_Auto_VaccumSW_DoActionDone.CASE3 = null;
            this.FC_Auto_VaccumSW_DoActionDone.CASE4 = null;
            this.FC_Auto_VaccumSW_DoActionDone.ContinueRun = false;
            this.FC_Auto_VaccumSW_DoActionDone.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_DoActionDone.EndFC = null;
            this.FC_Auto_VaccumSW_DoActionDone.ErrID = 0;
            this.FC_Auto_VaccumSW_DoActionDone.InAlarm = false;
            this.FC_Auto_VaccumSW_DoActionDone.IsFlowHead = false;
            this.FC_Auto_VaccumSW_DoActionDone.Location = new System.Drawing.Point(142, 124);
            this.FC_Auto_VaccumSW_DoActionDone.LockUI = false;
            this.FC_Auto_VaccumSW_DoActionDone.Message = null;
            this.FC_Auto_VaccumSW_DoActionDone.MsgID = 0;
            this.FC_Auto_VaccumSW_DoActionDone.Name = "FC_Auto_VaccumSW_DoActionDone";
            this.FC_Auto_VaccumSW_DoActionDone.NEXT = this.FC_Auto_VaccumSW_Done;
            this.FC_Auto_VaccumSW_DoActionDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_DoActionDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_DoActionDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_DoActionDone.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_DoActionDone.Running = false;
            this.FC_Auto_VaccumSW_DoActionDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_DoActionDone.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_DoActionDone.StartFC = null;
            this.FC_Auto_VaccumSW_DoActionDone.Text = "Do Action Done";
            this.FC_Auto_VaccumSW_DoActionDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_DoActionDone_Run);
            // 
            // FC_Auto_VaccumSW_FailAction
            // 
            this.FC_Auto_VaccumSW_FailAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_FailAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_FailAction.CASE1 = null;
            this.FC_Auto_VaccumSW_FailAction.CASE2 = null;
            this.FC_Auto_VaccumSW_FailAction.CASE3 = null;
            this.FC_Auto_VaccumSW_FailAction.CASE4 = null;
            this.FC_Auto_VaccumSW_FailAction.ContinueRun = false;
            this.FC_Auto_VaccumSW_FailAction.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_FailAction.EndFC = null;
            this.FC_Auto_VaccumSW_FailAction.ErrID = 0;
            this.FC_Auto_VaccumSW_FailAction.InAlarm = false;
            this.FC_Auto_VaccumSW_FailAction.IsFlowHead = false;
            this.FC_Auto_VaccumSW_FailAction.Location = new System.Drawing.Point(383, 124);
            this.FC_Auto_VaccumSW_FailAction.LockUI = false;
            this.FC_Auto_VaccumSW_FailAction.Message = null;
            this.FC_Auto_VaccumSW_FailAction.MsgID = 0;
            this.FC_Auto_VaccumSW_FailAction.Name = "FC_Auto_VaccumSW_FailAction";
            this.FC_Auto_VaccumSW_FailAction.NEXT = this.FC_Auto_VaccumSW_DoAction;
            this.FC_Auto_VaccumSW_FailAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_FailAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_FailAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_FailAction.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_FailAction.Running = false;
            this.FC_Auto_VaccumSW_FailAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_FailAction.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_FailAction.StartFC = null;
            this.FC_Auto_VaccumSW_FailAction.Text = "Fail Action";
            this.FC_Auto_VaccumSW_FailAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_FailAction_Run);
            // 
            // FC_Auto_VaccumSW_Done
            // 
            this.FC_Auto_VaccumSW_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_Done.CASE1 = null;
            this.FC_Auto_VaccumSW_Done.CASE2 = null;
            this.FC_Auto_VaccumSW_Done.CASE3 = null;
            this.FC_Auto_VaccumSW_Done.CASE4 = null;
            this.FC_Auto_VaccumSW_Done.ContinueRun = false;
            this.FC_Auto_VaccumSW_Done.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_Done.EndFC = null;
            this.FC_Auto_VaccumSW_Done.ErrID = 0;
            this.FC_Auto_VaccumSW_Done.InAlarm = false;
            this.FC_Auto_VaccumSW_Done.IsFlowHead = false;
            this.FC_Auto_VaccumSW_Done.Location = new System.Drawing.Point(142, 152);
            this.FC_Auto_VaccumSW_Done.LockUI = false;
            this.FC_Auto_VaccumSW_Done.Message = null;
            this.FC_Auto_VaccumSW_Done.MsgID = 0;
            this.FC_Auto_VaccumSW_Done.Name = "FC_Auto_VaccumSW_Done";
            this.FC_Auto_VaccumSW_Done.NEXT = this.FC_Auto_VaccumSW_Next;
            this.FC_Auto_VaccumSW_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_Done.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_Done.Running = false;
            this.FC_Auto_VaccumSW_Done.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_Done.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_Done.StartFC = null;
            this.FC_Auto_VaccumSW_Done.Text = "Done";
            this.FC_Auto_VaccumSW_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_Done_Run);
            // 
            // FC_Auto_VaccumSW_Start
            // 
            this.FC_Auto_VaccumSW_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_VaccumSW_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_VaccumSW_Start.CASE1 = null;
            this.FC_Auto_VaccumSW_Start.CASE2 = null;
            this.FC_Auto_VaccumSW_Start.CASE3 = null;
            this.FC_Auto_VaccumSW_Start.CASE4 = null;
            this.FC_Auto_VaccumSW_Start.ContinueRun = false;
            this.FC_Auto_VaccumSW_Start.DesignTimeParent = null;
            this.FC_Auto_VaccumSW_Start.EndFC = null;
            this.FC_Auto_VaccumSW_Start.ErrID = 0;
            this.FC_Auto_VaccumSW_Start.InAlarm = false;
            this.FC_Auto_VaccumSW_Start.IsFlowHead = false;
            this.FC_Auto_VaccumSW_Start.Location = new System.Drawing.Point(142, 40);
            this.FC_Auto_VaccumSW_Start.LockUI = false;
            this.FC_Auto_VaccumSW_Start.Message = null;
            this.FC_Auto_VaccumSW_Start.MsgID = 0;
            this.FC_Auto_VaccumSW_Start.Name = "FC_Auto_VaccumSW_Start";
            this.FC_Auto_VaccumSW_Start.NEXT = this.FC_Auto_VaccumSW_WaitCommand;
            this.FC_Auto_VaccumSW_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_VaccumSW_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_VaccumSW_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_VaccumSW_Start.OverTimeSpec = 100;
            this.FC_Auto_VaccumSW_Start.Running = false;
            this.FC_Auto_VaccumSW_Start.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_VaccumSW_Start.SlowRunCycle = -1;
            this.FC_Auto_VaccumSW_Start.StartFC = null;
            this.FC_Auto_VaccumSW_Start.Text = "VaccumSW Start";
            this.FC_Auto_VaccumSW_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_VaccumSW_Start_Run);
            // 
            // FC_Auto_PreAction_Next
            // 
            this.FC_Auto_PreAction_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_Next.CASE1 = null;
            this.FC_Auto_PreAction_Next.CASE2 = null;
            this.FC_Auto_PreAction_Next.CASE3 = null;
            this.FC_Auto_PreAction_Next.CASE4 = null;
            this.FC_Auto_PreAction_Next.ContinueRun = false;
            this.FC_Auto_PreAction_Next.DesignTimeParent = null;
            this.FC_Auto_PreAction_Next.EndFC = null;
            this.FC_Auto_PreAction_Next.ErrID = 0;
            this.FC_Auto_PreAction_Next.InAlarm = false;
            this.FC_Auto_PreAction_Next.IsFlowHead = false;
            this.FC_Auto_PreAction_Next.Location = new System.Drawing.Point(57, 348);
            this.FC_Auto_PreAction_Next.LockUI = false;
            this.FC_Auto_PreAction_Next.Message = null;
            this.FC_Auto_PreAction_Next.MsgID = 0;
            this.FC_Auto_PreAction_Next.Name = "FC_Auto_PreAction_Next";
            this.FC_Auto_PreAction_Next.NEXT = this.FC_Auto_PreAction_WaitCommand;
            this.FC_Auto_PreAction_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_Next.OverTimeSpec = 100;
            this.FC_Auto_PreAction_Next.Running = false;
            this.FC_Auto_PreAction_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_Auto_PreAction_Next.SlowRunCycle = -1;
            this.FC_Auto_PreAction_Next.StartFC = null;
            this.FC_Auto_PreAction_Next.Text = "Next";
            this.FC_Auto_PreAction_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Next_Run);
            // 
            // FC_Auto_PreAction_WaitCommand
            // 
            this.FC_Auto_PreAction_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_WaitCommand.CASE1 = null;
            this.FC_Auto_PreAction_WaitCommand.CASE2 = null;
            this.FC_Auto_PreAction_WaitCommand.CASE3 = null;
            this.FC_Auto_PreAction_WaitCommand.CASE4 = null;
            this.FC_Auto_PreAction_WaitCommand.ContinueRun = false;
            this.FC_Auto_PreAction_WaitCommand.DesignTimeParent = null;
            this.FC_Auto_PreAction_WaitCommand.EndFC = null;
            this.FC_Auto_PreAction_WaitCommand.ErrID = 0;
            this.FC_Auto_PreAction_WaitCommand.InAlarm = false;
            this.FC_Auto_PreAction_WaitCommand.IsFlowHead = false;
            this.FC_Auto_PreAction_WaitCommand.Location = new System.Drawing.Point(142, 264);
            this.FC_Auto_PreAction_WaitCommand.LockUI = false;
            this.FC_Auto_PreAction_WaitCommand.Message = null;
            this.FC_Auto_PreAction_WaitCommand.MsgID = 0;
            this.FC_Auto_PreAction_WaitCommand.Name = "FC_Auto_PreAction_WaitCommand";
            this.FC_Auto_PreAction_WaitCommand.NEXT = this.FC_Auto_PreAction_DoAction;
            this.FC_Auto_PreAction_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_WaitCommand.OverTimeSpec = 100;
            this.FC_Auto_PreAction_WaitCommand.Running = false;
            this.FC_Auto_PreAction_WaitCommand.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_WaitCommand.SlowRunCycle = -1;
            this.FC_Auto_PreAction_WaitCommand.StartFC = null;
            this.FC_Auto_PreAction_WaitCommand.Text = "Wait Command";
            this.FC_Auto_PreAction_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_WaitCommand_Run);
            // 
            // FC_Auto_PreAction_DoAction
            // 
            this.FC_Auto_PreAction_DoAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_DoAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_DoAction.CASE1 = null;
            this.FC_Auto_PreAction_DoAction.CASE2 = null;
            this.FC_Auto_PreAction_DoAction.CASE3 = null;
            this.FC_Auto_PreAction_DoAction.CASE4 = null;
            this.FC_Auto_PreAction_DoAction.ContinueRun = false;
            this.FC_Auto_PreAction_DoAction.DesignTimeParent = null;
            this.FC_Auto_PreAction_DoAction.EndFC = null;
            this.FC_Auto_PreAction_DoAction.ErrID = 0;
            this.FC_Auto_PreAction_DoAction.InAlarm = false;
            this.FC_Auto_PreAction_DoAction.IsFlowHead = false;
            this.FC_Auto_PreAction_DoAction.Location = new System.Drawing.Point(142, 292);
            this.FC_Auto_PreAction_DoAction.LockUI = false;
            this.FC_Auto_PreAction_DoAction.Message = null;
            this.FC_Auto_PreAction_DoAction.MsgID = 0;
            this.FC_Auto_PreAction_DoAction.Name = "FC_Auto_PreAction_DoAction";
            this.FC_Auto_PreAction_DoAction.NEXT = this.FC_Auto_PreAction_DoActionDone;
            this.FC_Auto_PreAction_DoAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_DoAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_DoAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_DoAction.OverTimeSpec = 100;
            this.FC_Auto_PreAction_DoAction.Running = false;
            this.FC_Auto_PreAction_DoAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_DoAction.SlowRunCycle = -1;
            this.FC_Auto_PreAction_DoAction.StartFC = null;
            this.FC_Auto_PreAction_DoAction.Text = "Do Action";
            this.FC_Auto_PreAction_DoAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_DoAction_Run);
            // 
            // FC_Auto_PreAction_DoActionDone
            // 
            this.FC_Auto_PreAction_DoActionDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_DoActionDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_DoActionDone.CASE1 = this.FC_Auto_PreAction_FailAction;
            this.FC_Auto_PreAction_DoActionDone.CASE2 = null;
            this.FC_Auto_PreAction_DoActionDone.CASE3 = null;
            this.FC_Auto_PreAction_DoActionDone.CASE4 = null;
            this.FC_Auto_PreAction_DoActionDone.ContinueRun = false;
            this.FC_Auto_PreAction_DoActionDone.DesignTimeParent = null;
            this.FC_Auto_PreAction_DoActionDone.EndFC = null;
            this.FC_Auto_PreAction_DoActionDone.ErrID = 0;
            this.FC_Auto_PreAction_DoActionDone.InAlarm = false;
            this.FC_Auto_PreAction_DoActionDone.IsFlowHead = false;
            this.FC_Auto_PreAction_DoActionDone.Location = new System.Drawing.Point(142, 320);
            this.FC_Auto_PreAction_DoActionDone.LockUI = false;
            this.FC_Auto_PreAction_DoActionDone.Message = null;
            this.FC_Auto_PreAction_DoActionDone.MsgID = 0;
            this.FC_Auto_PreAction_DoActionDone.Name = "FC_Auto_PreAction_DoActionDone";
            this.FC_Auto_PreAction_DoActionDone.NEXT = this.FC_Auto_PreAction_Done;
            this.FC_Auto_PreAction_DoActionDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_DoActionDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_DoActionDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_DoActionDone.OverTimeSpec = 100;
            this.FC_Auto_PreAction_DoActionDone.Running = false;
            this.FC_Auto_PreAction_DoActionDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_DoActionDone.SlowRunCycle = -1;
            this.FC_Auto_PreAction_DoActionDone.StartFC = null;
            this.FC_Auto_PreAction_DoActionDone.Text = "Do Action Done";
            this.FC_Auto_PreAction_DoActionDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_DoActionDone_Run);
            // 
            // FC_Auto_PreAction_FailAction
            // 
            this.FC_Auto_PreAction_FailAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_FailAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_FailAction.CASE1 = null;
            this.FC_Auto_PreAction_FailAction.CASE2 = null;
            this.FC_Auto_PreAction_FailAction.CASE3 = null;
            this.FC_Auto_PreAction_FailAction.CASE4 = null;
            this.FC_Auto_PreAction_FailAction.ContinueRun = false;
            this.FC_Auto_PreAction_FailAction.DesignTimeParent = null;
            this.FC_Auto_PreAction_FailAction.EndFC = null;
            this.FC_Auto_PreAction_FailAction.ErrID = 0;
            this.FC_Auto_PreAction_FailAction.InAlarm = false;
            this.FC_Auto_PreAction_FailAction.IsFlowHead = false;
            this.FC_Auto_PreAction_FailAction.Location = new System.Drawing.Point(383, 320);
            this.FC_Auto_PreAction_FailAction.LockUI = false;
            this.FC_Auto_PreAction_FailAction.Message = null;
            this.FC_Auto_PreAction_FailAction.MsgID = 0;
            this.FC_Auto_PreAction_FailAction.Name = "FC_Auto_PreAction_FailAction";
            this.FC_Auto_PreAction_FailAction.NEXT = this.FC_Auto_PreAction_DoAction;
            this.FC_Auto_PreAction_FailAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_FailAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_FailAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_FailAction.OverTimeSpec = 100;
            this.FC_Auto_PreAction_FailAction.Running = false;
            this.FC_Auto_PreAction_FailAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_FailAction.SlowRunCycle = -1;
            this.FC_Auto_PreAction_FailAction.StartFC = null;
            this.FC_Auto_PreAction_FailAction.Text = "Fail Action";
            this.FC_Auto_PreAction_FailAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_FailAction_Run);
            // 
            // FC_Auto_PreAction_Done
            // 
            this.FC_Auto_PreAction_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_Done.CASE1 = null;
            this.FC_Auto_PreAction_Done.CASE2 = null;
            this.FC_Auto_PreAction_Done.CASE3 = null;
            this.FC_Auto_PreAction_Done.CASE4 = null;
            this.FC_Auto_PreAction_Done.ContinueRun = false;
            this.FC_Auto_PreAction_Done.DesignTimeParent = null;
            this.FC_Auto_PreAction_Done.EndFC = null;
            this.FC_Auto_PreAction_Done.ErrID = 0;
            this.FC_Auto_PreAction_Done.InAlarm = false;
            this.FC_Auto_PreAction_Done.IsFlowHead = false;
            this.FC_Auto_PreAction_Done.Location = new System.Drawing.Point(142, 348);
            this.FC_Auto_PreAction_Done.LockUI = false;
            this.FC_Auto_PreAction_Done.Message = null;
            this.FC_Auto_PreAction_Done.MsgID = 0;
            this.FC_Auto_PreAction_Done.Name = "FC_Auto_PreAction_Done";
            this.FC_Auto_PreAction_Done.NEXT = this.FC_Auto_PreAction_Next;
            this.FC_Auto_PreAction_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_Done.OverTimeSpec = 100;
            this.FC_Auto_PreAction_Done.Running = false;
            this.FC_Auto_PreAction_Done.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_Done.SlowRunCycle = -1;
            this.FC_Auto_PreAction_Done.StartFC = null;
            this.FC_Auto_PreAction_Done.Text = "Done";
            this.FC_Auto_PreAction_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_Done_Run);
            // 
            // FC_Auto_PreAction_Start
            // 
            this.FC_Auto_PreAction_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_PreAction_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_PreAction_Start.CASE1 = null;
            this.FC_Auto_PreAction_Start.CASE2 = null;
            this.FC_Auto_PreAction_Start.CASE3 = null;
            this.FC_Auto_PreAction_Start.CASE4 = null;
            this.FC_Auto_PreAction_Start.ContinueRun = false;
            this.FC_Auto_PreAction_Start.DesignTimeParent = null;
            this.FC_Auto_PreAction_Start.EndFC = null;
            this.FC_Auto_PreAction_Start.ErrID = 0;
            this.FC_Auto_PreAction_Start.InAlarm = false;
            this.FC_Auto_PreAction_Start.IsFlowHead = false;
            this.FC_Auto_PreAction_Start.Location = new System.Drawing.Point(142, 236);
            this.FC_Auto_PreAction_Start.LockUI = false;
            this.FC_Auto_PreAction_Start.Message = null;
            this.FC_Auto_PreAction_Start.MsgID = 0;
            this.FC_Auto_PreAction_Start.Name = "FC_Auto_PreAction_Start";
            this.FC_Auto_PreAction_Start.NEXT = this.FC_Auto_PreAction_WaitCommand;
            this.FC_Auto_PreAction_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_PreAction_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_PreAction_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_PreAction_Start.OverTimeSpec = 100;
            this.FC_Auto_PreAction_Start.Running = false;
            this.FC_Auto_PreAction_Start.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_PreAction_Start.SlowRunCycle = -1;
            this.FC_Auto_PreAction_Start.StartFC = null;
            this.FC_Auto_PreAction_Start.Text = "PreAction Start";
            this.FC_Auto_PreAction_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_PreAction_Start_Run);
            // 
            // dFieldEdit3
            // 
            this.dFieldEdit3.AutoFocus = false;
            this.dFieldEdit3.Caption = "Simulation Delay Time";
            this.dFieldEdit3.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit3.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.DataName = "SimulationDelayTime";
            this.dFieldEdit3.DataSource = this.SetDS;
            this.dFieldEdit3.DefaultValue = null;
            this.dFieldEdit3.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit3.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.EditWidth = 100;
            this.dFieldEdit3.FieldValue = "";
            this.dFieldEdit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit3.IsModified = false;
            this.dFieldEdit3.Location = new System.Drawing.Point(39, 298);
            this.dFieldEdit3.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit3.MaxValue = 2000000D;
            this.dFieldEdit3.MinValue = 0D;
            this.dFieldEdit3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit3.Name = "dFieldEdit3";
            this.dFieldEdit3.NoChangeInAuto = false;
            this.dFieldEdit3.Size = new System.Drawing.Size(369, 29);
            this.dFieldEdit3.StepValue = 0D;
            this.dFieldEdit3.TabIndex = 19;
            this.dFieldEdit3.Unit = "ms";
            this.dFieldEdit3.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.UnitWidth = 50;
            this.dFieldEdit3.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit1
            // 
            this.dFieldEdit1.AutoFocus = false;
            this.dFieldEdit1.Caption = "OCR角度搜尋次數";
            this.dFieldEdit1.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit1.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.DataName = "TeachAngleMaxCount";
            this.dFieldEdit1.DataSource = this.SetDS;
            this.dFieldEdit1.DefaultValue = null;
            this.dFieldEdit1.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit1.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.EditWidth = 100;
            this.dFieldEdit1.FieldValue = "";
            this.dFieldEdit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit1.IsModified = false;
            this.dFieldEdit1.Location = new System.Drawing.Point(47, 133);
            this.dFieldEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit1.MaxValue = 32D;
            this.dFieldEdit1.MinValue = 1D;
            this.dFieldEdit1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit1.Name = "dFieldEdit1";
            this.dFieldEdit1.NoChangeInAuto = false;
            this.dFieldEdit1.Size = new System.Drawing.Size(419, 29);
            this.dFieldEdit1.StepValue = 0D;
            this.dFieldEdit1.TabIndex = 8;
            this.dFieldEdit1.Unit = "t";
            this.dFieldEdit1.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.UnitWidth = 80;
            this.dFieldEdit1.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit4
            // 
            this.dFieldEdit4.AutoFocus = false;
            this.dFieldEdit4.Caption = "Aligner Port";
            this.dFieldEdit4.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit4.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.DataName = "Aligner_Port";
            this.dFieldEdit4.DataSource = this.SetDS;
            this.dFieldEdit4.DefaultValue = "5000";
            this.dFieldEdit4.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit4.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.EditWidth = 200;
            this.dFieldEdit4.FieldValue = "";
            this.dFieldEdit4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit4.IsModified = false;
            this.dFieldEdit4.Location = new System.Drawing.Point(35, 74);
            this.dFieldEdit4.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit4.MaxValue = 999999D;
            this.dFieldEdit4.MinValue = 0D;
            this.dFieldEdit4.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit4.Name = "dFieldEdit4";
            this.dFieldEdit4.NoChangeInAuto = false;
            this.dFieldEdit4.Size = new System.Drawing.Size(369, 29);
            this.dFieldEdit4.StepValue = 0D;
            this.dFieldEdit4.TabIndex = 21;
            this.dFieldEdit4.Unit = "";
            this.dFieldEdit4.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.UnitWidth = 0;
            this.dFieldEdit4.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit17
            // 
            this.dFieldEdit17.AutoFocus = false;
            this.dFieldEdit17.Caption = "Aligner IP";
            this.dFieldEdit17.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit17.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit17.DataName = "Aligner_IP";
            this.dFieldEdit17.DataSource = this.SetDS;
            this.dFieldEdit17.DefaultValue = null;
            this.dFieldEdit17.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit17.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit17.EditWidth = 200;
            this.dFieldEdit17.FieldValue = "";
            this.dFieldEdit17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit17.IsModified = false;
            this.dFieldEdit17.Location = new System.Drawing.Point(35, 45);
            this.dFieldEdit17.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit17.MaxValue = 999999D;
            this.dFieldEdit17.MinValue = -9999999D;
            this.dFieldEdit17.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit17.Name = "dFieldEdit17";
            this.dFieldEdit17.NoChangeInAuto = false;
            this.dFieldEdit17.Size = new System.Drawing.Size(369, 29);
            this.dFieldEdit17.StepValue = 0D;
            this.dFieldEdit17.TabIndex = 20;
            this.dFieldEdit17.Unit = "";
            this.dFieldEdit17.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit17.UnitWidth = 0;
            this.dFieldEdit17.ValueType = KCSDK.ValueDataType.String;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dFieldEdit17);
            this.groupBox1.Controls.Add(this.dFieldEdit4);
            this.groupBox1.Controls.Add(this.dFieldEdit12);
            this.groupBox1.Location = new System.Drawing.Point(4, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 210);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aligner設定";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.OB_NegativePressure_On);
            this.groupBox11.Controls.Add(this.OB_NegativePressure_Off);
            this.groupBox11.Controls.Add(this.bt_VacuumOff);
            this.groupBox11.Controls.Add(this.bt_VacuumOn);
            this.groupBox11.Location = new System.Drawing.Point(923, 60);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(220, 198);
            this.groupBox11.TabIndex = 75;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Vacuum";
            // 
            // OB_NegativePressure_On
            // 
            this.OB_NegativePressure_On.ActionCount = 0;
            this.OB_NegativePressure_On.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_NegativePressure_On.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.OB_NegativePressure_On.DesignTimeParent = null;
            this.OB_NegativePressure_On.ErrID = 0;
            this.OB_NegativePressure_On.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_NegativePressure_On.InAlarm = false;
            this.OB_NegativePressure_On.IOPort = "2116";
            this.OB_NegativePressure_On.IOType = ProVLib.EIOType.IOHSL;
            this.OB_NegativePressure_On.IsUseActionCount = false;
            this.OB_NegativePressure_On.Location = new System.Drawing.Point(6, 31);
            this.OB_NegativePressure_On.LockUI = false;
            this.OB_NegativePressure_On.Message = null;
            this.OB_NegativePressure_On.MsgID = 0;
            this.OB_NegativePressure_On.Name = "OB_NegativePressure_On";
            this.OB_NegativePressure_On.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_NegativePressure_On.RetryCount = 10;
            this.OB_NegativePressure_On.Running = false;
            this.OB_NegativePressure_On.Size = new System.Drawing.Size(200, 30);
            this.OB_NegativePressure_On.Text = "Negative Pressure On";
            this.OB_NegativePressure_On.Value = false;
            // 
            // OB_NegativePressure_Off
            // 
            this.OB_NegativePressure_Off.ActionCount = 0;
            this.OB_NegativePressure_Off.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_NegativePressure_Off.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.OB_NegativePressure_Off.DesignTimeParent = null;
            this.OB_NegativePressure_Off.ErrID = 0;
            this.OB_NegativePressure_Off.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_NegativePressure_Off.InAlarm = false;
            this.OB_NegativePressure_Off.IOPort = "2117";
            this.OB_NegativePressure_Off.IOType = ProVLib.EIOType.IOHSL;
            this.OB_NegativePressure_Off.IsUseActionCount = false;
            this.OB_NegativePressure_Off.Location = new System.Drawing.Point(6, 69);
            this.OB_NegativePressure_Off.LockUI = false;
            this.OB_NegativePressure_Off.Message = null;
            this.OB_NegativePressure_Off.MsgID = 0;
            this.OB_NegativePressure_Off.Name = "OB_NegativePressure_Off";
            this.OB_NegativePressure_Off.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_NegativePressure_Off.RetryCount = 10;
            this.OB_NegativePressure_Off.Running = false;
            this.OB_NegativePressure_Off.Size = new System.Drawing.Size(200, 30);
            this.OB_NegativePressure_Off.Text = "Negative Pressure Off";
            this.OB_NegativePressure_Off.Value = false;
            // 
            // bt_VacuumOff
            // 
            this.bt_VacuumOff.Location = new System.Drawing.Point(6, 144);
            this.bt_VacuumOff.Name = "bt_VacuumOff";
            this.bt_VacuumOff.Size = new System.Drawing.Size(200, 34);
            this.bt_VacuumOff.TabIndex = 21;
            this.bt_VacuumOff.Text = "Vacuum Off";
            this.bt_VacuumOff.UseVisualStyleBackColor = true;
            this.bt_VacuumOff.Click += new System.EventHandler(this.bt_VacuumOff_Click);
            // 
            // bt_VacuumOn
            // 
            this.bt_VacuumOn.Location = new System.Drawing.Point(6, 106);
            this.bt_VacuumOn.Name = "bt_VacuumOn";
            this.bt_VacuumOn.Size = new System.Drawing.Size(200, 34);
            this.bt_VacuumOn.TabIndex = 20;
            this.bt_VacuumOn.Text = "Vacuum On";
            this.bt_VacuumOn.UseVisualStyleBackColor = true;
            this.bt_VacuumOn.Click += new System.EventHandler(this.bt_VacuumOn_Click);
            // 
            // FC_Auto_CheckHasWafer_CheckHasWafer
            // 
            this.FC_Auto_CheckHasWafer_CheckHasWafer.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_CheckHasWafer.CASE1 = this.FC_Home_Retry1;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.CASE2 = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.CASE3 = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.CASE4 = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.EndFC = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.ErrID = 0;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.InAlarm = false;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Location = new System.Drawing.Point(729, 459);
            this.FC_Auto_CheckHasWafer_CheckHasWafer.LockUI = false;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Message = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.MsgID = 0;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Name = "FC_Auto_CheckHasWafer_CheckHasWafer";
            this.FC_Auto_CheckHasWafer_CheckHasWafer.NEXT = this.FC_Auto_CheckHasWafer_VacOff;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_CheckHasWafer.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_CheckHasWafer.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Running = false;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_CheckHasWafer.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.StartFC = null;
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Text = "Chk Has Wafer";
            this.FC_Auto_CheckHasWafer_CheckHasWafer.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_CheckHasWafer_Run);
            // 
            // FC_Auto_CheckHasWafer_VacOff
            // 
            this.FC_Auto_CheckHasWafer_VacOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_VacOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_VacOff.CASE1 = null;
            this.FC_Auto_CheckHasWafer_VacOff.CASE2 = null;
            this.FC_Auto_CheckHasWafer_VacOff.CASE3 = null;
            this.FC_Auto_CheckHasWafer_VacOff.CASE4 = null;
            this.FC_Auto_CheckHasWafer_VacOff.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_VacOff.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_VacOff.EndFC = null;
            this.FC_Auto_CheckHasWafer_VacOff.ErrID = 0;
            this.FC_Auto_CheckHasWafer_VacOff.InAlarm = false;
            this.FC_Auto_CheckHasWafer_VacOff.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_VacOff.Location = new System.Drawing.Point(729, 487);
            this.FC_Auto_CheckHasWafer_VacOff.LockUI = false;
            this.FC_Auto_CheckHasWafer_VacOff.Message = null;
            this.FC_Auto_CheckHasWafer_VacOff.MsgID = 0;
            this.FC_Auto_CheckHasWafer_VacOff.Name = "FC_Auto_CheckHasWafer_VacOff";
            this.FC_Auto_CheckHasWafer_VacOff.NEXT = this.FC_Auto_CheckHasWafer_VacOffDone;
            this.FC_Auto_CheckHasWafer_VacOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_VacOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_VacOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_VacOff.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_VacOff.Running = false;
            this.FC_Auto_CheckHasWafer_VacOff.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_VacOff.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_VacOff.StartFC = null;
            this.FC_Auto_CheckHasWafer_VacOff.Text = "Vac Off";
            this.FC_Auto_CheckHasWafer_VacOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_VacOff_Run);
            // 
            // FC_Auto_CheckHasWafer_VacOffDone
            // 
            this.FC_Auto_CheckHasWafer_VacOffDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_VacOffDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_VacOffDone.CASE1 = this.FC_Auto_CheckHasWafer_FailAction3;
            this.FC_Auto_CheckHasWafer_VacOffDone.CASE2 = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.CASE3 = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.CASE4 = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_VacOffDone.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.EndFC = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.ErrID = 0;
            this.FC_Auto_CheckHasWafer_VacOffDone.InAlarm = false;
            this.FC_Auto_CheckHasWafer_VacOffDone.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_VacOffDone.Location = new System.Drawing.Point(729, 515);
            this.FC_Auto_CheckHasWafer_VacOffDone.LockUI = false;
            this.FC_Auto_CheckHasWafer_VacOffDone.Message = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.MsgID = 0;
            this.FC_Auto_CheckHasWafer_VacOffDone.Name = "FC_Auto_CheckHasWafer_VacOffDone";
            this.FC_Auto_CheckHasWafer_VacOffDone.NEXT = this.FC_Auto_CheckHasWafer_Done;
            this.FC_Auto_CheckHasWafer_VacOffDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_VacOffDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_VacOffDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_VacOffDone.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_VacOffDone.Running = false;
            this.FC_Auto_CheckHasWafer_VacOffDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_VacOffDone.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_VacOffDone.StartFC = null;
            this.FC_Auto_CheckHasWafer_VacOffDone.Text = "Vac Off Done";
            this.FC_Auto_CheckHasWafer_VacOffDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_VacOffDone_Run);
            // 
            // FC_Auto_CheckHasWafer_FailAction3
            // 
            this.FC_Auto_CheckHasWafer_FailAction3.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_FailAction3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_FailAction3.CASE1 = null;
            this.FC_Auto_CheckHasWafer_FailAction3.CASE2 = null;
            this.FC_Auto_CheckHasWafer_FailAction3.CASE3 = null;
            this.FC_Auto_CheckHasWafer_FailAction3.CASE4 = null;
            this.FC_Auto_CheckHasWafer_FailAction3.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_FailAction3.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_FailAction3.EndFC = null;
            this.FC_Auto_CheckHasWafer_FailAction3.ErrID = 0;
            this.FC_Auto_CheckHasWafer_FailAction3.InAlarm = false;
            this.FC_Auto_CheckHasWafer_FailAction3.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_FailAction3.Location = new System.Drawing.Point(970, 515);
            this.FC_Auto_CheckHasWafer_FailAction3.LockUI = false;
            this.FC_Auto_CheckHasWafer_FailAction3.Message = null;
            this.FC_Auto_CheckHasWafer_FailAction3.MsgID = 0;
            this.FC_Auto_CheckHasWafer_FailAction3.Name = "FC_Auto_CheckHasWafer_FailAction3";
            this.FC_Auto_CheckHasWafer_FailAction3.NEXT = this.FC_Auto_CheckHasWafer_VacOff;
            this.FC_Auto_CheckHasWafer_FailAction3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_FailAction3.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction3.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction3.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_FailAction3.Running = false;
            this.FC_Auto_CheckHasWafer_FailAction3.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_FailAction3.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_FailAction3.StartFC = null;
            this.FC_Auto_CheckHasWafer_FailAction3.Text = "Fail Action";
            this.FC_Auto_CheckHasWafer_FailAction3.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_FailAction3_Run);
            // 
            // FC_Auto_CheckHasWafer_Done
            // 
            this.FC_Auto_CheckHasWafer_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_Done.CASE1 = null;
            this.FC_Auto_CheckHasWafer_Done.CASE2 = null;
            this.FC_Auto_CheckHasWafer_Done.CASE3 = null;
            this.FC_Auto_CheckHasWafer_Done.CASE4 = null;
            this.FC_Auto_CheckHasWafer_Done.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_Done.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_Done.EndFC = null;
            this.FC_Auto_CheckHasWafer_Done.ErrID = 0;
            this.FC_Auto_CheckHasWafer_Done.InAlarm = false;
            this.FC_Auto_CheckHasWafer_Done.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_Done.Location = new System.Drawing.Point(729, 543);
            this.FC_Auto_CheckHasWafer_Done.LockUI = false;
            this.FC_Auto_CheckHasWafer_Done.Message = null;
            this.FC_Auto_CheckHasWafer_Done.MsgID = 0;
            this.FC_Auto_CheckHasWafer_Done.Name = "FC_Auto_CheckHasWafer_Done";
            this.FC_Auto_CheckHasWafer_Done.NEXT = this.FC_Auto_CheckHasWafer_Next;
            this.FC_Auto_CheckHasWafer_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_Done.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_Done.Running = false;
            this.FC_Auto_CheckHasWafer_Done.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_Done.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_Done.StartFC = null;
            this.FC_Auto_CheckHasWafer_Done.Text = "Done";
            this.FC_Auto_CheckHasWafer_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_Done_Run);
            // 
            // FC_Auto_CheckHasWafer_Next
            // 
            this.FC_Auto_CheckHasWafer_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_Next.CASE1 = null;
            this.FC_Auto_CheckHasWafer_Next.CASE2 = null;
            this.FC_Auto_CheckHasWafer_Next.CASE3 = null;
            this.FC_Auto_CheckHasWafer_Next.CASE4 = null;
            this.FC_Auto_CheckHasWafer_Next.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_Next.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_Next.EndFC = null;
            this.FC_Auto_CheckHasWafer_Next.ErrID = 0;
            this.FC_Auto_CheckHasWafer_Next.InAlarm = false;
            this.FC_Auto_CheckHasWafer_Next.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_Next.Location = new System.Drawing.Point(644, 543);
            this.FC_Auto_CheckHasWafer_Next.LockUI = false;
            this.FC_Auto_CheckHasWafer_Next.Message = null;
            this.FC_Auto_CheckHasWafer_Next.MsgID = 0;
            this.FC_Auto_CheckHasWafer_Next.Name = "FC_Auto_CheckHasWafer_Next";
            this.FC_Auto_CheckHasWafer_Next.NEXT = this.FC_Auto_CheckHasWafer_WaitCommand;
            this.FC_Auto_CheckHasWafer_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_Next.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_Next.Running = false;
            this.FC_Auto_CheckHasWafer_Next.Size = new System.Drawing.Size(50, 20);
            this.FC_Auto_CheckHasWafer_Next.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_Next.StartFC = null;
            this.FC_Auto_CheckHasWafer_Next.Text = "Next";
            this.FC_Auto_CheckHasWafer_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_Next_Run);
            // 
            // FC_Auto_CheckHasWafer_WaitCommand
            // 
            this.FC_Auto_CheckHasWafer_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_WaitCommand.CASE1 = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.CASE2 = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.CASE3 = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.CASE4 = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_WaitCommand.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.EndFC = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.ErrID = 0;
            this.FC_Auto_CheckHasWafer_WaitCommand.InAlarm = false;
            this.FC_Auto_CheckHasWafer_WaitCommand.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_WaitCommand.Location = new System.Drawing.Point(729, 320);
            this.FC_Auto_CheckHasWafer_WaitCommand.LockUI = false;
            this.FC_Auto_CheckHasWafer_WaitCommand.Message = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.MsgID = 0;
            this.FC_Auto_CheckHasWafer_WaitCommand.Name = "FC_Auto_CheckHasWafer_WaitCommand";
            this.FC_Auto_CheckHasWafer_WaitCommand.NEXT = this.FC_Auto_CheckHasWafer_VacOn;
            this.FC_Auto_CheckHasWafer_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_WaitCommand.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_WaitCommand.Running = false;
            this.FC_Auto_CheckHasWafer_WaitCommand.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_WaitCommand.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_WaitCommand.StartFC = null;
            this.FC_Auto_CheckHasWafer_WaitCommand.Text = "Wait Command";
            this.FC_Auto_CheckHasWafer_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_WaitCommand_Run);
            // 
            // FC_Auto_CheckHasWafer_VacOn
            // 
            this.FC_Auto_CheckHasWafer_VacOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_VacOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_VacOn.CASE1 = null;
            this.FC_Auto_CheckHasWafer_VacOn.CASE2 = null;
            this.FC_Auto_CheckHasWafer_VacOn.CASE3 = null;
            this.FC_Auto_CheckHasWafer_VacOn.CASE4 = null;
            this.FC_Auto_CheckHasWafer_VacOn.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_VacOn.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_VacOn.EndFC = null;
            this.FC_Auto_CheckHasWafer_VacOn.ErrID = 0;
            this.FC_Auto_CheckHasWafer_VacOn.InAlarm = false;
            this.FC_Auto_CheckHasWafer_VacOn.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_VacOn.Location = new System.Drawing.Point(729, 348);
            this.FC_Auto_CheckHasWafer_VacOn.LockUI = false;
            this.FC_Auto_CheckHasWafer_VacOn.Message = null;
            this.FC_Auto_CheckHasWafer_VacOn.MsgID = 0;
            this.FC_Auto_CheckHasWafer_VacOn.Name = "FC_Auto_CheckHasWafer_VacOn";
            this.FC_Auto_CheckHasWafer_VacOn.NEXT = this.FC_Auto_CheckHasWafer_VacOnDone;
            this.FC_Auto_CheckHasWafer_VacOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_VacOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_VacOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_VacOn.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_VacOn.Running = false;
            this.FC_Auto_CheckHasWafer_VacOn.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_VacOn.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_VacOn.StartFC = null;
            this.FC_Auto_CheckHasWafer_VacOn.Text = "Vac On";
            this.FC_Auto_CheckHasWafer_VacOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_VacOn_Run);
            // 
            // FC_Auto_CheckHasWafer_VacOnDone
            // 
            this.FC_Auto_CheckHasWafer_VacOnDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_VacOnDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_VacOnDone.CASE1 = this.FC_Auto_CheckHasWafer_FailAction;
            this.FC_Auto_CheckHasWafer_VacOnDone.CASE2 = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.CASE3 = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.CASE4 = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_VacOnDone.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.EndFC = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.ErrID = 0;
            this.FC_Auto_CheckHasWafer_VacOnDone.InAlarm = false;
            this.FC_Auto_CheckHasWafer_VacOnDone.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_VacOnDone.Location = new System.Drawing.Point(729, 376);
            this.FC_Auto_CheckHasWafer_VacOnDone.LockUI = false;
            this.FC_Auto_CheckHasWafer_VacOnDone.Message = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.MsgID = 0;
            this.FC_Auto_CheckHasWafer_VacOnDone.Name = "FC_Auto_CheckHasWafer_VacOnDone";
            this.FC_Auto_CheckHasWafer_VacOnDone.NEXT = this.FC_Auto_CheckHasWafer_GetStatus;
            this.FC_Auto_CheckHasWafer_VacOnDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_VacOnDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_VacOnDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_VacOnDone.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_VacOnDone.Running = false;
            this.FC_Auto_CheckHasWafer_VacOnDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_VacOnDone.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_VacOnDone.StartFC = null;
            this.FC_Auto_CheckHasWafer_VacOnDone.Text = "Vac On Done";
            this.FC_Auto_CheckHasWafer_VacOnDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_VacOnDone_Run);
            // 
            // FC_Auto_CheckHasWafer_FailAction
            // 
            this.FC_Auto_CheckHasWafer_FailAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_FailAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_FailAction.CASE1 = null;
            this.FC_Auto_CheckHasWafer_FailAction.CASE2 = null;
            this.FC_Auto_CheckHasWafer_FailAction.CASE3 = null;
            this.FC_Auto_CheckHasWafer_FailAction.CASE4 = null;
            this.FC_Auto_CheckHasWafer_FailAction.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_FailAction.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_FailAction.EndFC = null;
            this.FC_Auto_CheckHasWafer_FailAction.ErrID = 0;
            this.FC_Auto_CheckHasWafer_FailAction.InAlarm = false;
            this.FC_Auto_CheckHasWafer_FailAction.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_FailAction.Location = new System.Drawing.Point(970, 376);
            this.FC_Auto_CheckHasWafer_FailAction.LockUI = false;
            this.FC_Auto_CheckHasWafer_FailAction.Message = null;
            this.FC_Auto_CheckHasWafer_FailAction.MsgID = 0;
            this.FC_Auto_CheckHasWafer_FailAction.Name = "FC_Auto_CheckHasWafer_FailAction";
            this.FC_Auto_CheckHasWafer_FailAction.NEXT = this.FC_Auto_CheckHasWafer_VacOn;
            this.FC_Auto_CheckHasWafer_FailAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_FailAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_FailAction.Running = false;
            this.FC_Auto_CheckHasWafer_FailAction.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_FailAction.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_FailAction.StartFC = null;
            this.FC_Auto_CheckHasWafer_FailAction.Text = "Fail Action";
            this.FC_Auto_CheckHasWafer_FailAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_FailAction_Run);
            // 
            // FC_Auto_CheckHasWafer_GetStatus
            // 
            this.FC_Auto_CheckHasWafer_GetStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_GetStatus.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_GetStatus.CASE1 = null;
            this.FC_Auto_CheckHasWafer_GetStatus.CASE2 = null;
            this.FC_Auto_CheckHasWafer_GetStatus.CASE3 = null;
            this.FC_Auto_CheckHasWafer_GetStatus.CASE4 = null;
            this.FC_Auto_CheckHasWafer_GetStatus.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_GetStatus.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_GetStatus.EndFC = null;
            this.FC_Auto_CheckHasWafer_GetStatus.ErrID = 0;
            this.FC_Auto_CheckHasWafer_GetStatus.InAlarm = false;
            this.FC_Auto_CheckHasWafer_GetStatus.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_GetStatus.Location = new System.Drawing.Point(729, 404);
            this.FC_Auto_CheckHasWafer_GetStatus.LockUI = false;
            this.FC_Auto_CheckHasWafer_GetStatus.Message = null;
            this.FC_Auto_CheckHasWafer_GetStatus.MsgID = 0;
            this.FC_Auto_CheckHasWafer_GetStatus.Name = "FC_Auto_CheckHasWafer_GetStatus";
            this.FC_Auto_CheckHasWafer_GetStatus.NEXT = this.FC_Auto_CheckHasWafer_GetStatusDone;
            this.FC_Auto_CheckHasWafer_GetStatus.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_GetStatus.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_GetStatus.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_GetStatus.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_GetStatus.Running = false;
            this.FC_Auto_CheckHasWafer_GetStatus.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_GetStatus.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_GetStatus.StartFC = null;
            this.FC_Auto_CheckHasWafer_GetStatus.Text = "Get  Status";
            this.FC_Auto_CheckHasWafer_GetStatus.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_GetStatus_Run);
            // 
            // FC_Auto_CheckHasWafer_GetStatusDone
            // 
            this.FC_Auto_CheckHasWafer_GetStatusDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_GetStatusDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_GetStatusDone.CASE1 = this.FC_Auto_CheckHasWafer_FailAction2;
            this.FC_Auto_CheckHasWafer_GetStatusDone.CASE2 = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.CASE3 = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.CASE4 = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_GetStatusDone.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.EndFC = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.ErrID = 0;
            this.FC_Auto_CheckHasWafer_GetStatusDone.InAlarm = false;
            this.FC_Auto_CheckHasWafer_GetStatusDone.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Location = new System.Drawing.Point(729, 432);
            this.FC_Auto_CheckHasWafer_GetStatusDone.LockUI = false;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Message = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.MsgID = 0;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Name = "FC_Auto_CheckHasWafer_GetStatusDone";
            this.FC_Auto_CheckHasWafer_GetStatusDone.NEXT = this.FC_Auto_CheckHasWafer_CheckHasWafer;
            this.FC_Auto_CheckHasWafer_GetStatusDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_GetStatusDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_GetStatusDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_GetStatusDone.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Running = false;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_GetStatusDone.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_GetStatusDone.StartFC = null;
            this.FC_Auto_CheckHasWafer_GetStatusDone.Text = "Get Status Done";
            this.FC_Auto_CheckHasWafer_GetStatusDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_GetStatusDone_Run);
            // 
            // FC_Auto_CheckHasWafer_FailAction2
            // 
            this.FC_Auto_CheckHasWafer_FailAction2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_FailAction2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_FailAction2.CASE1 = null;
            this.FC_Auto_CheckHasWafer_FailAction2.CASE2 = null;
            this.FC_Auto_CheckHasWafer_FailAction2.CASE3 = null;
            this.FC_Auto_CheckHasWafer_FailAction2.CASE4 = null;
            this.FC_Auto_CheckHasWafer_FailAction2.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_FailAction2.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_FailAction2.EndFC = null;
            this.FC_Auto_CheckHasWafer_FailAction2.ErrID = 0;
            this.FC_Auto_CheckHasWafer_FailAction2.InAlarm = false;
            this.FC_Auto_CheckHasWafer_FailAction2.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_FailAction2.Location = new System.Drawing.Point(970, 432);
            this.FC_Auto_CheckHasWafer_FailAction2.LockUI = false;
            this.FC_Auto_CheckHasWafer_FailAction2.Message = null;
            this.FC_Auto_CheckHasWafer_FailAction2.MsgID = 0;
            this.FC_Auto_CheckHasWafer_FailAction2.Name = "FC_Auto_CheckHasWafer_FailAction2";
            this.FC_Auto_CheckHasWafer_FailAction2.NEXT = this.FC_Auto_CheckHasWafer_GetStatus;
            this.FC_Auto_CheckHasWafer_FailAction2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_FailAction2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_FailAction2.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_FailAction2.Running = false;
            this.FC_Auto_CheckHasWafer_FailAction2.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_FailAction2.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_FailAction2.StartFC = null;
            this.FC_Auto_CheckHasWafer_FailAction2.Text = "Fail Action";
            this.FC_Auto_CheckHasWafer_FailAction2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_FailAction2_Run);
            // 
            // FC_Auto_CheckHasWafer_Start
            // 
            this.FC_Auto_CheckHasWafer_Start.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_CheckHasWafer_Start.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_CheckHasWafer_Start.CASE1 = null;
            this.FC_Auto_CheckHasWafer_Start.CASE2 = null;
            this.FC_Auto_CheckHasWafer_Start.CASE3 = null;
            this.FC_Auto_CheckHasWafer_Start.CASE4 = null;
            this.FC_Auto_CheckHasWafer_Start.ContinueRun = false;
            this.FC_Auto_CheckHasWafer_Start.DesignTimeParent = null;
            this.FC_Auto_CheckHasWafer_Start.EndFC = null;
            this.FC_Auto_CheckHasWafer_Start.ErrID = 0;
            this.FC_Auto_CheckHasWafer_Start.InAlarm = false;
            this.FC_Auto_CheckHasWafer_Start.IsFlowHead = false;
            this.FC_Auto_CheckHasWafer_Start.Location = new System.Drawing.Point(729, 292);
            this.FC_Auto_CheckHasWafer_Start.LockUI = false;
            this.FC_Auto_CheckHasWafer_Start.Message = null;
            this.FC_Auto_CheckHasWafer_Start.MsgID = 0;
            this.FC_Auto_CheckHasWafer_Start.Name = "FC_Auto_CheckHasWafer_Start";
            this.FC_Auto_CheckHasWafer_Start.NEXT = this.FC_Auto_CheckHasWafer_WaitCommand;
            this.FC_Auto_CheckHasWafer_Start.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_CheckHasWafer_Start.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_CheckHasWafer_Start.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_CheckHasWafer_Start.OverTimeSpec = 100;
            this.FC_Auto_CheckHasWafer_Start.Running = false;
            this.FC_Auto_CheckHasWafer_Start.Size = new System.Drawing.Size(181, 20);
            this.FC_Auto_CheckHasWafer_Start.SlowRunCycle = -1;
            this.FC_Auto_CheckHasWafer_Start.StartFC = null;
            this.FC_Auto_CheckHasWafer_Start.Text = "Check Has Wafer";
            this.FC_Auto_CheckHasWafer_Start.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_CheckHasWafer_Start_Run);
            // 
            // Aligner
            // 
            this.Aligner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aligner.ConnectedMode = CommonObj.eConnectedMode.Ethernet;
            this.Aligner.IsManualTest = false;
            this.Aligner.IsSaveLog = true;
            this.Aligner.IsSimulation = false;
            this.Aligner.Location = new System.Drawing.Point(17, 60);
            this.Aligner.MaximumSize = new System.Drawing.Size(900, 560);
            this.Aligner.MinimumSize = new System.Drawing.Size(900, 560);
            this.Aligner.Name = "Aligner";
            this.Aligner.SendACKAfterAction = false;
            this.Aligner.Size = new System.Drawing.Size(900, 560);
            this.Aligner.StationName = "Aligner";
            this.Aligner.TabIndex = 0;
            this.Aligner.UseCheckSum = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(2, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(252, 56);
            this.label14.TabIndex = 76;
            this.label14.Text = "WAS(Aligner模組)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WAS_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 717);
            this.Name = "WAS_A";
            this.Text = "WAS";
            this.tabMain.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpFlow.ResumeLayout(false);
            this.tpSuperSetting.ResumeLayout(false);
            this.TabFlow.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpAuto.ResumeLayout(false);
            this.tpCheck.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RobotControl.RobotControl Aligner;
        private System.Windows.Forms.Panel panel1;
        private KCSDK.DComboBox cv_StopBits;
        private KCSDK.DComboBox cb_DataBits;
        private KCSDK.DComboBox cb_Parity;
        private KCSDK.DComboBox cb_Baudrate;
        private System.Windows.Forms.TextBox textBox7;
        private KCSDK.DComboBox cb_COMPort;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private ProVLib.FlowChart FC_Home_ChkHasNoWafer;
        private ProVLib.FlowChart FC_Home_Retry1;
        private ProVLib.FlowChart FC_Home_VacOn;
        private ProVLib.FlowChart FC_Home_VacOnDone;
        private ProVLib.FlowChart FC_Home_GetStatus;
        private ProVLib.FlowChart FC_Home_GetStatusDone;
        private ProVLib.FlowChart FC_Home_VacOff;
        private ProVLib.FlowChart FC_Home_VacOffDone;
        private ProVLib.FlowChart FC_Home_DoHome;
        private ProVLib.FlowChart FC_Home_DoHomeDone;
        private ProVLib.FlowChart FC_Home_SetSpeed_Doit;
        private ProVLib.FlowChart FC_Home_SetSpeed_Done;
        private ProVLib.FlowChart FC_Home_End;
        private ProVLib.FlowChart FC_Home_CommandStart_Next;
        private ProVLib.FlowChart FC_Home_CommandStart_WaitCommand;
        private ProVLib.FlowChart FC_Home_CommandStart_DoCommand;
        private ProVLib.FlowChart FC_Home_CommandStart_CommandFinish;
        private ProVLib.FlowChart FC_Home_CommandStart_Retry;
        private ProVLib.FlowChart FC_Home_CommandStart_Done;
        private ProVLib.FlowChart FC_Home_Command_Start;
        private ProVLib.FlowChart FC_Home_Simulation;
        private ProVLib.FlowChart FC_Home_Connect;
        private ProVLib.FlowChart FC_Home_Start;
        private KCSDK.DFieldEdit dFieldEdit12;
        private KCSDK.DFieldEdit dFieldEdit2;
        private ProVLib.FlowChart FC_Auto_Align_Next;
        private ProVLib.FlowChart FC_Auto_Align_WaitCommand;
        private ProVLib.FlowChart FC_Auto_Align_DoAction;
        private ProVLib.FlowChart FC_Auto_Align_DoActionDone;
        private ProVLib.FlowChart FC_Auto_Align_FailAction;
        private ProVLib.FlowChart FC_Auto_Align_Done;
        private ProVLib.FlowChart FC_Auto_Align_Start;
        private ProVLib.FlowChart FC_Auto_VaccumSW_Next;
        private ProVLib.FlowChart FC_Auto_VaccumSW_WaitCommand;
        private ProVLib.FlowChart FC_Auto_VaccumSW_DoAction;
        private ProVLib.FlowChart FC_Auto_VaccumSW_DoActionDone;
        private ProVLib.FlowChart FC_Auto_VaccumSW_FailAction;
        private ProVLib.FlowChart FC_Auto_VaccumSW_Done;
        private ProVLib.FlowChart FC_Auto_VaccumSW_Start;
        private ProVLib.FlowChart FC_Auto_PreAction_Next;
        private ProVLib.FlowChart FC_Auto_PreAction_WaitCommand;
        private ProVLib.FlowChart FC_Auto_PreAction_DoAction;
        private ProVLib.FlowChart FC_Auto_PreAction_DoActionDone;
        private ProVLib.FlowChart FC_Auto_PreAction_FailAction;
        private ProVLib.FlowChart FC_Auto_PreAction_Done;
        private ProVLib.FlowChart FC_Auto_PreAction_Start;
        private ProVLib.FlowChart FC_Home_WaitCmd;
        private KCSDK.DFieldEdit dFieldEdit3;
        private KCSDK.DFieldEdit dFieldEdit1;
        private KCSDK.DFieldEdit dFieldEdit4;
        private KCSDK.DFieldEdit dFieldEdit17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox11;
        private ProVLib.OutBit OB_NegativePressure_On;
        private ProVLib.OutBit OB_NegativePressure_Off;
        private System.Windows.Forms.Button bt_VacuumOff;
        private System.Windows.Forms.Button bt_VacuumOn;
        private ProVLib.FlowChart FC_Home_SetTime_Done;
        private ProVLib.FlowChart FC_Home_SetTime_Doit;
        private ProVLib.FlowChart FC_Home_SetWaferType_Done;
        private ProVLib.FlowChart FC_Home_SetSWaferType_Doit;
        private ProVLib.FlowChart FC_Home_Pass;
        private ProVLib.FlowChart FC_Home_Reset_Done;
        private ProVLib.FlowChart FC_Home_Reset;
        private ProVLib.FlowChart FC_Home_Delay;
        private ProVLib.FlowChart FC_Auto_Align_VacOnDone;
        private ProVLib.FlowChart FC_Auto_Align_DoVacOn;
        private ProVLib.FlowChart FC_Auto_Align_FailAction3;
        private ProVLib.FlowChart FC_Auto_Align_DoPreAlign;
        private ProVLib.FlowChart FC_Auto_Align_PreAlignDone;
        private ProVLib.FlowChart FC_Auto_Align_FailAction2;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_CheckHasWafer;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_VacOff;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_VacOffDone;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_VacOnDone;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_GetStatus;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_GetStatusDone;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_VacOn;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_Start;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_Next;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_WaitCommand;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_Done;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_FailAction;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_FailAction2;
        private ProVLib.FlowChart FC_Auto_CheckHasWafer_FailAction3;
        private System.Windows.Forms.Label label14;


    }
}