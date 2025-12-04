namespace WOI_AB
{
    partial class WOI_AB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WOI_AB));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ib_Ocr_Out = new ProVLib.InBit();
            this.ib_Ocr_Back = new ProVLib.InBit();
            this.ob_Ocr_Out = new ProVLib.OutBit();
            this.btn_Table_SW = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dFieldEdit2 = new KCSDK.DFieldEdit();
            this.FC_Home_Done = new ProVLib.FlowChart();
            this.FC_Home_DoOcrConnect = new ProVLib.FlowChart();
            this.FC_Home_OcrConnectDone = new ProVLib.FlowChart();
            this.FC_Home_DoInchSwitch = new ProVLib.FlowChart();
            this.FC_Home_InchSwitchDone = new ProVLib.FlowChart();
            this.FC_Home_OcrCyOff = new ProVLib.FlowChart();
            this.FC_Home_WaitCmd = new ProVLib.FlowChart();
            this.FC_HOME_START = new ProVLib.FlowChart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dFieldEdit31 = new KCSDK.DFieldEdit();
            this.dFieldEdit1 = new KCSDK.DFieldEdit();
            this.FC_AUTO_TRIGGER_START = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_Trigger = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_ReadIDFailResult = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_ManualInputIDResult = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_Done = new ProVLib.FlowChart();
            this.flowChart7 = new ProVLib.FlowChart();
            this.flowChart4 = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_Connect = new ProVLib.FlowChart();
            this.btn_ORC_Connect = new System.Windows.Forms.Button();
            this.btn_ORC_Read = new System.Windows.Forms.Button();
            this.btn_ORC_Disconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ReadTime = new System.Windows.Forms.Label();
            this.lb_WaferID = new System.Windows.Forms.Label();
            this.flowChart5 = new ProVLib.FlowChart();
            this.FC_Auto_OcrConnect_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_OcrConnect_Connect = new ProVLib.FlowChart();
            this.FC_Auto_OcrConnect_Done = new ProVLib.FlowChart();
            this.FC_Auto_Trigger_WaitCmd0 = new ProVLib.FlowChart();
            this.FC_AUTO_OCRCONNECT_START = new ProVLib.FlowChart();
            this.flowChart1 = new ProVLib.FlowChart();
            this.FC_AUTO_InchSwitch_WaitCmd = new ProVLib.FlowChart();
            this.FC_AUTO_InchSwitch_CyliderAction = new ProVLib.FlowChart();
            this.FC_AUTO_InchSwitch_Done = new ProVLib.FlowChart();
            this.flowChart8 = new ProVLib.FlowChart();
            this.FC_AUTO_INCH_SWITCH_START = new ProVLib.FlowChart();
            this.dCheckBox2 = new KCSDK.DCheckBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dCheckBox3 = new KCSDK.DCheckBox(this.components);
            this.dFieldEdit3 = new KCSDK.DFieldEdit();
            this.btn_OpenTeachingSoftware = new System.Windows.Forms.Button();
            this.pbx_OCR_Read = new System.Windows.Forms.PictureBox();
            this.lb_OcrResult = new System.Windows.Forms.Label();
            this.dCheckBox4 = new KCSDK.DCheckBox(this.components);
            this.FC_Auto_TeachAngleMode_Done = new ProVLib.FlowChart();
            this.flowChart6 = new ProVLib.FlowChart();
            this.flowChart9 = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_WaitCommand = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_Trigger = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_ReadIDFailResult = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_ManualInputIDResult = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_Connect = new ProVLib.FlowChart();
            this.FC_Auto_TeachAngleMode_START = new ProVLib.FlowChart();
            this.dFieldEdit4 = new KCSDK.DFieldEdit();
            this.dCheckBox1 = new KCSDK.DCheckBox(this.components);
            this.dCheckBox5 = new KCSDK.DCheckBox(this.components);
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
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OCR_Read)).BeginInit();
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
            this.tabMain.Size = new System.Drawing.Size(1280, 736);
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.label14);
            this.tpControl.Controls.Add(this.lb_OcrResult);
            this.tpControl.Controls.Add(this.pbx_OCR_Read);
            this.tpControl.Controls.Add(this.btn_OpenTeachingSoftware);
            this.tpControl.Controls.Add(this.groupBox1);
            this.tpControl.Controls.Add(this.flowLayoutPanel4);
            this.tpControl.Size = new System.Drawing.Size(1272, 668);
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.dCheckBox5);
            this.tpSetting.Controls.Add(this.dCheckBox4);
            this.tpSetting.Controls.Add(this.dFieldEdit3);
            this.tpSetting.Controls.Add(this.label1);
            this.tpSetting.Controls.Add(this.dCheckBox2);
            this.tpSetting.Controls.SetChildIndex(this.dCheckBox2, 0);
            this.tpSetting.Controls.SetChildIndex(this.label1, 0);
            this.tpSetting.Controls.SetChildIndex(this.dFieldEdit3, 0);
            this.tpSetting.Controls.SetChildIndex(this.dCheckBox4, 0);
            this.tpSetting.Controls.SetChildIndex(this.dCheckBox5, 0);
            // 
            // tpSuperSetting
            // 
            this.tpSuperSetting.Controls.Add(this.dCheckBox1);
            this.tpSuperSetting.Controls.Add(this.dFieldEdit4);
            this.tpSuperSetting.Controls.Add(this.dCheckBox3);
            this.tpSuperSetting.Controls.Add(this.flowLayoutPanel2);
            this.tpSuperSetting.Controls.Add(this.groupBox3);
            this.tpSuperSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpSuperSetting.Controls.SetChildIndex(this.groupBox3, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.dCheckBox3, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.dFieldEdit4, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.dCheckBox1, 0);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.FC_Home_InchSwitchDone);
            this.tpHome.Controls.Add(this.FC_Home_DoInchSwitch);
            this.tpHome.Controls.Add(this.FC_Home_OcrConnectDone);
            this.tpHome.Controls.Add(this.FC_Home_DoOcrConnect);
            this.tpHome.Controls.Add(this.FC_Home_OcrCyOff);
            this.tpHome.Controls.Add(this.FC_Home_Done);
            this.tpHome.Controls.Add(this.FC_Home_WaitCmd);
            this.tpHome.Controls.Add(this.FC_HOME_START);
            // 
            // tpAuto
            // 
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_ManualInputIDResult);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_ReadIDFailResult);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_Connect);
            this.tpAuto.Controls.Add(this.flowChart9);
            this.tpAuto.Controls.Add(this.flowChart6);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_Trigger);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_WaitCommand);
            this.tpAuto.Controls.Add(this.FC_Auto_TeachAngleMode_START);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_ManualInputIDResult);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_ReadIDFailResult);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_Connect);
            this.tpAuto.Controls.Add(this.flowChart1);
            this.tpAuto.Controls.Add(this.flowChart8);
            this.tpAuto.Controls.Add(this.FC_AUTO_InchSwitch_Done);
            this.tpAuto.Controls.Add(this.FC_AUTO_InchSwitch_CyliderAction);
            this.tpAuto.Controls.Add(this.FC_AUTO_InchSwitch_WaitCmd);
            this.tpAuto.Controls.Add(this.FC_AUTO_INCH_SWITCH_START);
            this.tpAuto.Controls.Add(this.flowChart5);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_WaitCmd0);
            this.tpAuto.Controls.Add(this.FC_Auto_OcrConnect_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_OcrConnect_Connect);
            this.tpAuto.Controls.Add(this.FC_Auto_OcrConnect_WaitCmd);
            this.tpAuto.Controls.Add(this.FC_AUTO_OCRCONNECT_START);
            this.tpAuto.Controls.Add(this.flowChart4);
            this.tpAuto.Controls.Add(this.flowChart7);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_Done);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_Trigger);
            this.tpAuto.Controls.Add(this.FC_Auto_Trigger_WaitCmd);
            this.tpAuto.Controls.Add(this.FC_AUTO_TRIGGER_START);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.ib_Ocr_Out);
            this.flowLayoutPanel4.Controls.Add(this.ib_Ocr_Back);
            this.flowLayoutPanel4.Controls.Add(this.ob_Ocr_Out);
            this.flowLayoutPanel4.Controls.Add(this.btn_Table_SW);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(751, 72);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(217, 197);
            this.flowLayoutPanel4.TabIndex = 15;
            this.flowLayoutPanel4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inch Switch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_Ocr_Out
            // 
            this.ib_Ocr_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Ocr_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.ib_Ocr_Out.DesignTimeParent = null;
            this.ib_Ocr_Out.ErrID = 0;
            this.ib_Ocr_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Ocr_Out.InAlarm = false;
            this.ib_Ocr_Out.IOPort = "";
            this.ib_Ocr_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Ocr_Out.Location = new System.Drawing.Point(3, 30);
            this.ib_Ocr_Out.LockUI = false;
            this.ib_Ocr_Out.Message = null;
            this.ib_Ocr_Out.MsgID = 0;
            this.ib_Ocr_Out.Name = "ib_Ocr_Out";
            this.ib_Ocr_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Ocr_Out.Running = false;
            this.ib_Ocr_Out.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Ocr_Out.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Ocr_Out.Simu_OutPort1 = null;
            this.ib_Ocr_Out.Simu_OutPort2 = null;
            this.ib_Ocr_Out.Simu_RandomNum = 2;
            this.ib_Ocr_Out.Simu_RandomTime = 100;
            this.ib_Ocr_Out.Simu_ReflectDelayTm = 100;
            this.ib_Ocr_Out.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Ocr_Out.Simu_Reverse = false;
            this.ib_Ocr_Out.Size = new System.Drawing.Size(211, 30);
            this.ib_Ocr_Out.Text = "On";
            // 
            // ib_Ocr_Back
            // 
            this.ib_Ocr_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Ocr_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.ib_Ocr_Back.DesignTimeParent = null;
            this.ib_Ocr_Back.ErrID = 0;
            this.ib_Ocr_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Ocr_Back.InAlarm = false;
            this.ib_Ocr_Back.IOPort = "";
            this.ib_Ocr_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Ocr_Back.Location = new System.Drawing.Point(3, 68);
            this.ib_Ocr_Back.LockUI = false;
            this.ib_Ocr_Back.Message = null;
            this.ib_Ocr_Back.MsgID = 0;
            this.ib_Ocr_Back.Name = "ib_Ocr_Back";
            this.ib_Ocr_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Ocr_Back.Running = false;
            this.ib_Ocr_Back.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Ocr_Back.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Ocr_Back.Simu_OutPort1 = null;
            this.ib_Ocr_Back.Simu_OutPort2 = null;
            this.ib_Ocr_Back.Simu_RandomNum = 2;
            this.ib_Ocr_Back.Simu_RandomTime = 100;
            this.ib_Ocr_Back.Simu_ReflectDelayTm = 100;
            this.ib_Ocr_Back.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Ocr_Back.Simu_Reverse = false;
            this.ib_Ocr_Back.Size = new System.Drawing.Size(211, 30);
            this.ib_Ocr_Back.Text = "Off";
            // 
            // ob_Ocr_Out
            // 
            this.ob_Ocr_Out.ActionCount = 0;
            this.ob_Ocr_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Ocr_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.ob_Ocr_Out.DesignTimeParent = null;
            this.ob_Ocr_Out.ErrID = 0;
            this.ob_Ocr_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Ocr_Out.InAlarm = false;
            this.ob_Ocr_Out.IOPort = "";
            this.ob_Ocr_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Ocr_Out.IsUseActionCount = false;
            this.ob_Ocr_Out.Location = new System.Drawing.Point(3, 106);
            this.ob_Ocr_Out.LockUI = false;
            this.ob_Ocr_Out.Message = null;
            this.ob_Ocr_Out.MsgID = 0;
            this.ob_Ocr_Out.Name = "ob_Ocr_Out";
            this.ob_Ocr_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Ocr_Out.RetryCount = 10;
            this.ob_Ocr_Out.Running = false;
            this.ob_Ocr_Out.Size = new System.Drawing.Size(211, 30);
            this.ob_Ocr_Out.Text = "Push";
            this.ob_Ocr_Out.Value = false;
            // 
            // btn_Table_SW
            // 
            this.btn_Table_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_Table_SW.Location = new System.Drawing.Point(3, 143);
            this.btn_Table_SW.Name = "btn_Table_SW";
            this.btn_Table_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_Table_SW.TabIndex = 39;
            this.btn_Table_SW.Tag = "Table";
            this.btn_Table_SW.Text = "Switch";
            this.btn_Table_SW.UseVisualStyleBackColor = false;
            this.btn_Table_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dFieldEdit2);
            this.groupBox3.Location = new System.Drawing.Point(6, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 132);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Socket Setting";
            // 
            // dFieldEdit2
            // 
            this.dFieldEdit2.AutoFocus = false;
            this.dFieldEdit2.Caption = "IP Address";
            this.dFieldEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.DataName = "OCRSocket_IpAddress";
            this.dFieldEdit2.DataSource = this.SetDS;
            this.dFieldEdit2.DefaultValue = null;
            this.dFieldEdit2.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.EditWidth = 250;
            this.dFieldEdit2.FieldValue = "";
            this.dFieldEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.IsModified = false;
            this.dFieldEdit2.Location = new System.Drawing.Point(16, 43);
            this.dFieldEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit2.MaxValue = 9999999D;
            this.dFieldEdit2.MinValue = -9999999D;
            this.dFieldEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit2.Name = "dFieldEdit2";
            this.dFieldEdit2.NoChangeInAuto = false;
            this.dFieldEdit2.Size = new System.Drawing.Size(400, 30);
            this.dFieldEdit2.StepValue = 0D;
            this.dFieldEdit2.TabIndex = 2;
            this.dFieldEdit2.Unit = "";
            this.dFieldEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.UnitWidth = 0;
            this.dFieldEdit2.ValueType = KCSDK.ValueDataType.String;
            // 
            // FC_Home_Done
            // 
            this.FC_Home_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Done.CASE1 = null;
            this.FC_Home_Done.CASE2 = null;
            this.FC_Home_Done.CASE3 = null;
            this.FC_Home_Done.CASE4 = null;
            this.FC_Home_Done.ContinueRun = false;
            this.FC_Home_Done.DesignTimeParent = null;
            this.FC_Home_Done.EndFC = null;
            this.FC_Home_Done.ErrID = 0;
            this.FC_Home_Done.InAlarm = false;
            this.FC_Home_Done.IsFlowHead = false;
            this.FC_Home_Done.Location = new System.Drawing.Point(344, 349);
            this.FC_Home_Done.LockUI = false;
            this.FC_Home_Done.Message = null;
            this.FC_Home_Done.MsgID = 0;
            this.FC_Home_Done.Name = "FC_Home_Done";
            this.FC_Home_Done.NEXT = null;
            this.FC_Home_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Done.OverTimeSpec = 100;
            this.FC_Home_Done.Running = false;
            this.FC_Home_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_Done.SlowRunCycle = -1;
            this.FC_Home_Done.StartFC = null;
            this.FC_Home_Done.Text = "Done";
            this.FC_Home_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Done_Run);
            // 
            // FC_Home_DoOcrConnect
            // 
            this.FC_Home_DoOcrConnect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoOcrConnect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoOcrConnect.CASE1 = null;
            this.FC_Home_DoOcrConnect.CASE2 = null;
            this.FC_Home_DoOcrConnect.CASE3 = null;
            this.FC_Home_DoOcrConnect.CASE4 = null;
            this.FC_Home_DoOcrConnect.ContinueRun = false;
            this.FC_Home_DoOcrConnect.DesignTimeParent = null;
            this.FC_Home_DoOcrConnect.EndFC = null;
            this.FC_Home_DoOcrConnect.ErrID = 0;
            this.FC_Home_DoOcrConnect.InAlarm = false;
            this.FC_Home_DoOcrConnect.IsFlowHead = false;
            this.FC_Home_DoOcrConnect.Location = new System.Drawing.Point(344, 197);
            this.FC_Home_DoOcrConnect.LockUI = false;
            this.FC_Home_DoOcrConnect.Message = null;
            this.FC_Home_DoOcrConnect.MsgID = 0;
            this.FC_Home_DoOcrConnect.Name = "FC_Home_DoOcrConnect";
            this.FC_Home_DoOcrConnect.NEXT = this.FC_Home_OcrConnectDone;
            this.FC_Home_DoOcrConnect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoOcrConnect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoOcrConnect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoOcrConnect.OverTimeSpec = 100;
            this.FC_Home_DoOcrConnect.Running = false;
            this.FC_Home_DoOcrConnect.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_DoOcrConnect.SlowRunCycle = -1;
            this.FC_Home_DoOcrConnect.StartFC = null;
            this.FC_Home_DoOcrConnect.Text = "Do Ocr_Connect";
            this.FC_Home_DoOcrConnect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoOcrConnect_Run);
            // 
            // FC_Home_OcrConnectDone
            // 
            this.FC_Home_OcrConnectDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_OcrConnectDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_OcrConnectDone.CASE1 = null;
            this.FC_Home_OcrConnectDone.CASE2 = null;
            this.FC_Home_OcrConnectDone.CASE3 = null;
            this.FC_Home_OcrConnectDone.CASE4 = null;
            this.FC_Home_OcrConnectDone.ContinueRun = false;
            this.FC_Home_OcrConnectDone.DesignTimeParent = null;
            this.FC_Home_OcrConnectDone.EndFC = null;
            this.FC_Home_OcrConnectDone.ErrID = 0;
            this.FC_Home_OcrConnectDone.InAlarm = false;
            this.FC_Home_OcrConnectDone.IsFlowHead = false;
            this.FC_Home_OcrConnectDone.Location = new System.Drawing.Point(344, 235);
            this.FC_Home_OcrConnectDone.LockUI = false;
            this.FC_Home_OcrConnectDone.Message = null;
            this.FC_Home_OcrConnectDone.MsgID = 0;
            this.FC_Home_OcrConnectDone.Name = "FC_Home_OcrConnectDone";
            this.FC_Home_OcrConnectDone.NEXT = this.FC_Home_DoInchSwitch;
            this.FC_Home_OcrConnectDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_OcrConnectDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_OcrConnectDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_OcrConnectDone.OverTimeSpec = 100;
            this.FC_Home_OcrConnectDone.Running = false;
            this.FC_Home_OcrConnectDone.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_OcrConnectDone.SlowRunCycle = -1;
            this.FC_Home_OcrConnectDone.StartFC = null;
            this.FC_Home_OcrConnectDone.Text = "Ocr_Connect Done";
            this.FC_Home_OcrConnectDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_OcrConnectDone_Run);
            // 
            // FC_Home_DoInchSwitch
            // 
            this.FC_Home_DoInchSwitch.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoInchSwitch.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoInchSwitch.CASE1 = null;
            this.FC_Home_DoInchSwitch.CASE2 = null;
            this.FC_Home_DoInchSwitch.CASE3 = null;
            this.FC_Home_DoInchSwitch.CASE4 = null;
            this.FC_Home_DoInchSwitch.ContinueRun = false;
            this.FC_Home_DoInchSwitch.DesignTimeParent = null;
            this.FC_Home_DoInchSwitch.EndFC = null;
            this.FC_Home_DoInchSwitch.ErrID = 0;
            this.FC_Home_DoInchSwitch.InAlarm = false;
            this.FC_Home_DoInchSwitch.IsFlowHead = false;
            this.FC_Home_DoInchSwitch.Location = new System.Drawing.Point(344, 273);
            this.FC_Home_DoInchSwitch.LockUI = false;
            this.FC_Home_DoInchSwitch.Message = null;
            this.FC_Home_DoInchSwitch.MsgID = 0;
            this.FC_Home_DoInchSwitch.Name = "FC_Home_DoInchSwitch";
            this.FC_Home_DoInchSwitch.NEXT = this.FC_Home_InchSwitchDone;
            this.FC_Home_DoInchSwitch.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoInchSwitch.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoInchSwitch.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoInchSwitch.OverTimeSpec = 100;
            this.FC_Home_DoInchSwitch.Running = false;
            this.FC_Home_DoInchSwitch.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_DoInchSwitch.SlowRunCycle = -1;
            this.FC_Home_DoInchSwitch.StartFC = null;
            this.FC_Home_DoInchSwitch.Text = "Do Inch Switch";
            this.FC_Home_DoInchSwitch.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoInchSwitch_Run);
            // 
            // FC_Home_InchSwitchDone
            // 
            this.FC_Home_InchSwitchDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_InchSwitchDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_InchSwitchDone.CASE1 = null;
            this.FC_Home_InchSwitchDone.CASE2 = null;
            this.FC_Home_InchSwitchDone.CASE3 = null;
            this.FC_Home_InchSwitchDone.CASE4 = null;
            this.FC_Home_InchSwitchDone.ContinueRun = false;
            this.FC_Home_InchSwitchDone.DesignTimeParent = null;
            this.FC_Home_InchSwitchDone.EndFC = null;
            this.FC_Home_InchSwitchDone.ErrID = 0;
            this.FC_Home_InchSwitchDone.InAlarm = false;
            this.FC_Home_InchSwitchDone.IsFlowHead = false;
            this.FC_Home_InchSwitchDone.Location = new System.Drawing.Point(344, 311);
            this.FC_Home_InchSwitchDone.LockUI = false;
            this.FC_Home_InchSwitchDone.Message = null;
            this.FC_Home_InchSwitchDone.MsgID = 0;
            this.FC_Home_InchSwitchDone.Name = "FC_Home_InchSwitchDone";
            this.FC_Home_InchSwitchDone.NEXT = this.FC_Home_Done;
            this.FC_Home_InchSwitchDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_InchSwitchDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_InchSwitchDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_InchSwitchDone.OverTimeSpec = 100;
            this.FC_Home_InchSwitchDone.Running = false;
            this.FC_Home_InchSwitchDone.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_InchSwitchDone.SlowRunCycle = -1;
            this.FC_Home_InchSwitchDone.StartFC = null;
            this.FC_Home_InchSwitchDone.Text = "Do Inch Switch Done";
            this.FC_Home_InchSwitchDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_InchSwitchDone_Run);
            // 
            // FC_Home_OcrCyOff
            // 
            this.FC_Home_OcrCyOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_OcrCyOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_OcrCyOff.CASE1 = null;
            this.FC_Home_OcrCyOff.CASE2 = null;
            this.FC_Home_OcrCyOff.CASE3 = null;
            this.FC_Home_OcrCyOff.CASE4 = null;
            this.FC_Home_OcrCyOff.ContinueRun = false;
            this.FC_Home_OcrCyOff.DesignTimeParent = null;
            this.FC_Home_OcrCyOff.EndFC = null;
            this.FC_Home_OcrCyOff.ErrID = 0;
            this.FC_Home_OcrCyOff.InAlarm = false;
            this.FC_Home_OcrCyOff.IsFlowHead = false;
            this.FC_Home_OcrCyOff.Location = new System.Drawing.Point(344, 159);
            this.FC_Home_OcrCyOff.LockUI = false;
            this.FC_Home_OcrCyOff.Message = null;
            this.FC_Home_OcrCyOff.MsgID = 0;
            this.FC_Home_OcrCyOff.Name = "FC_Home_OcrCyOff";
            this.FC_Home_OcrCyOff.NEXT = this.FC_Home_DoOcrConnect;
            this.FC_Home_OcrCyOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_OcrCyOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_OcrCyOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_OcrCyOff.OverTimeSpec = 100;
            this.FC_Home_OcrCyOff.Running = false;
            this.FC_Home_OcrCyOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_OcrCyOff.SlowRunCycle = -1;
            this.FC_Home_OcrCyOff.StartFC = null;
            this.FC_Home_OcrCyOff.Text = "Ocr Cylinder Off";
            this.FC_Home_OcrCyOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_OcrCyOff_Run);
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
            this.FC_Home_WaitCmd.Location = new System.Drawing.Point(344, 121);
            this.FC_Home_WaitCmd.LockUI = false;
            this.FC_Home_WaitCmd.Message = null;
            this.FC_Home_WaitCmd.MsgID = 0;
            this.FC_Home_WaitCmd.Name = "FC_Home_WaitCmd";
            this.FC_Home_WaitCmd.NEXT = this.FC_Home_OcrCyOff;
            this.FC_Home_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_WaitCmd.OverTimeSpec = 100;
            this.FC_Home_WaitCmd.Running = false;
            this.FC_Home_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_WaitCmd.SlowRunCycle = -1;
            this.FC_Home_WaitCmd.StartFC = null;
            this.FC_Home_WaitCmd.Text = "Wait Command";
            this.FC_Home_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmd_Run);
            // 
            // FC_HOME_START
            // 
            this.FC_HOME_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_HOME_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_HOME_START.CASE1 = null;
            this.FC_HOME_START.CASE2 = null;
            this.FC_HOME_START.CASE3 = null;
            this.FC_HOME_START.CASE4 = null;
            this.FC_HOME_START.ContinueRun = false;
            this.FC_HOME_START.DesignTimeParent = null;
            this.FC_HOME_START.EndFC = null;
            this.FC_HOME_START.ErrID = 0;
            this.FC_HOME_START.InAlarm = false;
            this.FC_HOME_START.IsFlowHead = false;
            this.FC_HOME_START.Location = new System.Drawing.Point(344, 83);
            this.FC_HOME_START.LockUI = false;
            this.FC_HOME_START.Message = null;
            this.FC_HOME_START.MsgID = 0;
            this.FC_HOME_START.Name = "FC_HOME_START";
            this.FC_HOME_START.NEXT = this.FC_Home_WaitCmd;
            this.FC_HOME_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_HOME_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_HOME_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_HOME_START.OverTimeSpec = 100;
            this.FC_HOME_START.Running = false;
            this.FC_HOME_START.Size = new System.Drawing.Size(200, 30);
            this.FC_HOME_START.SlowRunCycle = -1;
            this.FC_HOME_START.StartFC = null;
            this.FC_HOME_START.Text = "Initial Action Start";
            this.FC_HOME_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_HOME_START_Run);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit31);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 202);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(447, 81);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // dFieldEdit31
            // 
            this.dFieldEdit31.AutoFocus = false;
            this.dFieldEdit31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit31.Caption = "Cylinder Delay Time";
            this.dFieldEdit31.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit31.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.DataName = "CylinderActionDelayTime";
            this.dFieldEdit31.DataSource = this.SetDS;
            this.dFieldEdit31.DefaultValue = null;
            this.dFieldEdit31.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit31.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.EditWidth = 100;
            this.dFieldEdit31.FieldValue = "";
            this.dFieldEdit31.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit31.IsModified = false;
            this.dFieldEdit31.Location = new System.Drawing.Point(0, 0);
            this.dFieldEdit31.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit31.MaxValue = 100000D;
            this.dFieldEdit31.MinValue = 1D;
            this.dFieldEdit31.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit31.Name = "dFieldEdit31";
            this.dFieldEdit31.NoChangeInAuto = false;
            this.dFieldEdit31.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit31.StepValue = 0D;
            this.dFieldEdit31.TabIndex = 31;
            this.dFieldEdit31.Unit = "ms";
            this.dFieldEdit31.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.UnitWidth = 50;
            this.dFieldEdit31.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit1
            // 
            this.dFieldEdit1.AutoFocus = false;
            this.dFieldEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit1.Caption = "Cylinder Timeout";
            this.dFieldEdit1.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit1.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.DataName = "CylinderActionTimeout";
            this.dFieldEdit1.DataSource = this.SetDS;
            this.dFieldEdit1.DefaultValue = null;
            this.dFieldEdit1.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit1.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.EditWidth = 100;
            this.dFieldEdit1.FieldValue = "";
            this.dFieldEdit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit1.IsModified = false;
            this.dFieldEdit1.Location = new System.Drawing.Point(0, 29);
            this.dFieldEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit1.MaxValue = 100000D;
            this.dFieldEdit1.MinValue = 1D;
            this.dFieldEdit1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit1.Name = "dFieldEdit1";
            this.dFieldEdit1.NoChangeInAuto = false;
            this.dFieldEdit1.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit1.StepValue = 0D;
            this.dFieldEdit1.TabIndex = 32;
            this.dFieldEdit1.Unit = "ms";
            this.dFieldEdit1.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.UnitWidth = 50;
            this.dFieldEdit1.ValueType = KCSDK.ValueDataType.Int;
            // 
            // FC_AUTO_TRIGGER_START
            // 
            this.FC_AUTO_TRIGGER_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_TRIGGER_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_TRIGGER_START.CASE1 = null;
            this.FC_AUTO_TRIGGER_START.CASE2 = null;
            this.FC_AUTO_TRIGGER_START.CASE3 = null;
            this.FC_AUTO_TRIGGER_START.CASE4 = null;
            this.FC_AUTO_TRIGGER_START.ContinueRun = false;
            this.FC_AUTO_TRIGGER_START.DesignTimeParent = null;
            this.FC_AUTO_TRIGGER_START.EndFC = null;
            this.FC_AUTO_TRIGGER_START.ErrID = 0;
            this.FC_AUTO_TRIGGER_START.InAlarm = false;
            this.FC_AUTO_TRIGGER_START.IsFlowHead = false;
            this.FC_AUTO_TRIGGER_START.Location = new System.Drawing.Point(273, 59);
            this.FC_AUTO_TRIGGER_START.LockUI = false;
            this.FC_AUTO_TRIGGER_START.Message = null;
            this.FC_AUTO_TRIGGER_START.MsgID = 0;
            this.FC_AUTO_TRIGGER_START.Name = "FC_AUTO_TRIGGER_START";
            this.FC_AUTO_TRIGGER_START.NEXT = this.FC_Auto_Trigger_WaitCmd;
            this.FC_AUTO_TRIGGER_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_TRIGGER_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_TRIGGER_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_TRIGGER_START.OverTimeSpec = 100;
            this.FC_AUTO_TRIGGER_START.Running = false;
            this.FC_AUTO_TRIGGER_START.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_TRIGGER_START.SlowRunCycle = -1;
            this.FC_AUTO_TRIGGER_START.StartFC = null;
            this.FC_AUTO_TRIGGER_START.Text = "OCR Trigger Main";
            this.FC_AUTO_TRIGGER_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_TRIGGER_START_RUN);
            // 
            // FC_Auto_Trigger_WaitCmd
            // 
            this.FC_Auto_Trigger_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_WaitCmd.CASE1 = null;
            this.FC_Auto_Trigger_WaitCmd.CASE2 = null;
            this.FC_Auto_Trigger_WaitCmd.CASE3 = null;
            this.FC_Auto_Trigger_WaitCmd.CASE4 = null;
            this.FC_Auto_Trigger_WaitCmd.ContinueRun = false;
            this.FC_Auto_Trigger_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_Trigger_WaitCmd.EndFC = null;
            this.FC_Auto_Trigger_WaitCmd.ErrID = 0;
            this.FC_Auto_Trigger_WaitCmd.InAlarm = false;
            this.FC_Auto_Trigger_WaitCmd.IsFlowHead = false;
            this.FC_Auto_Trigger_WaitCmd.Location = new System.Drawing.Point(273, 97);
            this.FC_Auto_Trigger_WaitCmd.LockUI = false;
            this.FC_Auto_Trigger_WaitCmd.Message = null;
            this.FC_Auto_Trigger_WaitCmd.MsgID = 0;
            this.FC_Auto_Trigger_WaitCmd.Name = "FC_Auto_Trigger_WaitCmd";
            this.FC_Auto_Trigger_WaitCmd.NEXT = this.FC_Auto_Trigger_Trigger;
            this.FC_Auto_Trigger_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_Trigger_WaitCmd.Running = false;
            this.FC_Auto_Trigger_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_Trigger_WaitCmd.StartFC = null;
            this.FC_Auto_Trigger_WaitCmd.Text = "Wait Command";
            this.FC_Auto_Trigger_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_WaitCmd_Run);
            // 
            // FC_Auto_Trigger_Trigger
            // 
            this.FC_Auto_Trigger_Trigger.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_Trigger.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_Trigger.CASE1 = this.FC_Auto_Trigger_ReadIDFailResult;
            this.FC_Auto_Trigger_Trigger.CASE2 = this.FC_Auto_Trigger_Connect;
            this.FC_Auto_Trigger_Trigger.CASE3 = null;
            this.FC_Auto_Trigger_Trigger.CASE4 = null;
            this.FC_Auto_Trigger_Trigger.ContinueRun = false;
            this.FC_Auto_Trigger_Trigger.DesignTimeParent = null;
            this.FC_Auto_Trigger_Trigger.EndFC = null;
            this.FC_Auto_Trigger_Trigger.ErrID = 0;
            this.FC_Auto_Trigger_Trigger.InAlarm = false;
            this.FC_Auto_Trigger_Trigger.IsFlowHead = false;
            this.FC_Auto_Trigger_Trigger.Location = new System.Drawing.Point(273, 135);
            this.FC_Auto_Trigger_Trigger.LockUI = false;
            this.FC_Auto_Trigger_Trigger.Message = null;
            this.FC_Auto_Trigger_Trigger.MsgID = 0;
            this.FC_Auto_Trigger_Trigger.Name = "FC_Auto_Trigger_Trigger";
            this.FC_Auto_Trigger_Trigger.NEXT = this.FC_Auto_Trigger_Done;
            this.FC_Auto_Trigger_Trigger.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_Trigger.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_Trigger.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_Trigger.OverTimeSpec = 100;
            this.FC_Auto_Trigger_Trigger.Running = false;
            this.FC_Auto_Trigger_Trigger.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_Trigger.SlowRunCycle = -1;
            this.FC_Auto_Trigger_Trigger.StartFC = null;
            this.FC_Auto_Trigger_Trigger.Text = "Trigger";
            this.FC_Auto_Trigger_Trigger.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_Trigger_Run);
            // 
            // FC_Auto_Trigger_ReadIDFailResult
            // 
            this.FC_Auto_Trigger_ReadIDFailResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_ReadIDFailResult.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_ReadIDFailResult.CASE1 = this.FC_Auto_Trigger_Trigger;
            this.FC_Auto_Trigger_ReadIDFailResult.CASE2 = this.FC_Auto_Trigger_ManualInputIDResult;
            this.FC_Auto_Trigger_ReadIDFailResult.CASE3 = this.FC_Auto_Trigger_Done;
            this.FC_Auto_Trigger_ReadIDFailResult.CASE4 = null;
            this.FC_Auto_Trigger_ReadIDFailResult.ContinueRun = false;
            this.FC_Auto_Trigger_ReadIDFailResult.DesignTimeParent = null;
            this.FC_Auto_Trigger_ReadIDFailResult.EndFC = null;
            this.FC_Auto_Trigger_ReadIDFailResult.ErrID = 0;
            this.FC_Auto_Trigger_ReadIDFailResult.InAlarm = false;
            this.FC_Auto_Trigger_ReadIDFailResult.IsFlowHead = false;
            this.FC_Auto_Trigger_ReadIDFailResult.Location = new System.Drawing.Point(49, 135);
            this.FC_Auto_Trigger_ReadIDFailResult.LockUI = false;
            this.FC_Auto_Trigger_ReadIDFailResult.Message = null;
            this.FC_Auto_Trigger_ReadIDFailResult.MsgID = 0;
            this.FC_Auto_Trigger_ReadIDFailResult.Name = "FC_Auto_Trigger_ReadIDFailResult";
            this.FC_Auto_Trigger_ReadIDFailResult.NEXT = this.FC_Auto_Trigger_Connect;
            this.FC_Auto_Trigger_ReadIDFailResult.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_ReadIDFailResult.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_ReadIDFailResult.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_ReadIDFailResult.OverTimeSpec = 100;
            this.FC_Auto_Trigger_ReadIDFailResult.Running = false;
            this.FC_Auto_Trigger_ReadIDFailResult.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_ReadIDFailResult.SlowRunCycle = -1;
            this.FC_Auto_Trigger_ReadIDFailResult.StartFC = null;
            this.FC_Auto_Trigger_ReadIDFailResult.Text = "OCR Read ID Fail Result";
            this.FC_Auto_Trigger_ReadIDFailResult.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_ReadIDFailResult_Run);
            // 
            // FC_Auto_Trigger_ManualInputIDResult
            // 
            this.FC_Auto_Trigger_ManualInputIDResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_ManualInputIDResult.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_ManualInputIDResult.CASE1 = this.FC_Auto_Trigger_Trigger;
            this.FC_Auto_Trigger_ManualInputIDResult.CASE2 = null;
            this.FC_Auto_Trigger_ManualInputIDResult.CASE3 = null;
            this.FC_Auto_Trigger_ManualInputIDResult.CASE4 = null;
            this.FC_Auto_Trigger_ManualInputIDResult.ContinueRun = false;
            this.FC_Auto_Trigger_ManualInputIDResult.DesignTimeParent = null;
            this.FC_Auto_Trigger_ManualInputIDResult.EndFC = null;
            this.FC_Auto_Trigger_ManualInputIDResult.ErrID = 0;
            this.FC_Auto_Trigger_ManualInputIDResult.InAlarm = false;
            this.FC_Auto_Trigger_ManualInputIDResult.IsFlowHead = false;
            this.FC_Auto_Trigger_ManualInputIDResult.Location = new System.Drawing.Point(49, 173);
            this.FC_Auto_Trigger_ManualInputIDResult.LockUI = false;
            this.FC_Auto_Trigger_ManualInputIDResult.Message = null;
            this.FC_Auto_Trigger_ManualInputIDResult.MsgID = 0;
            this.FC_Auto_Trigger_ManualInputIDResult.Name = "FC_Auto_Trigger_ManualInputIDResult";
            this.FC_Auto_Trigger_ManualInputIDResult.NEXT = this.FC_Auto_Trigger_Done;
            this.FC_Auto_Trigger_ManualInputIDResult.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_ManualInputIDResult.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_ManualInputIDResult.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_ManualInputIDResult.OverTimeSpec = 100;
            this.FC_Auto_Trigger_ManualInputIDResult.Running = false;
            this.FC_Auto_Trigger_ManualInputIDResult.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_ManualInputIDResult.SlowRunCycle = -1;
            this.FC_Auto_Trigger_ManualInputIDResult.StartFC = null;
            this.FC_Auto_Trigger_ManualInputIDResult.Text = "OCR Manual Input ID Result";
            this.FC_Auto_Trigger_ManualInputIDResult.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_ManualInputIDResult_Run);
            // 
            // FC_Auto_Trigger_Done
            // 
            this.FC_Auto_Trigger_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_Done.CASE1 = null;
            this.FC_Auto_Trigger_Done.CASE2 = null;
            this.FC_Auto_Trigger_Done.CASE3 = null;
            this.FC_Auto_Trigger_Done.CASE4 = null;
            this.FC_Auto_Trigger_Done.ContinueRun = false;
            this.FC_Auto_Trigger_Done.DesignTimeParent = null;
            this.FC_Auto_Trigger_Done.EndFC = null;
            this.FC_Auto_Trigger_Done.ErrID = 0;
            this.FC_Auto_Trigger_Done.InAlarm = false;
            this.FC_Auto_Trigger_Done.IsFlowHead = false;
            this.FC_Auto_Trigger_Done.Location = new System.Drawing.Point(273, 173);
            this.FC_Auto_Trigger_Done.LockUI = false;
            this.FC_Auto_Trigger_Done.Message = null;
            this.FC_Auto_Trigger_Done.MsgID = 0;
            this.FC_Auto_Trigger_Done.Name = "FC_Auto_Trigger_Done";
            this.FC_Auto_Trigger_Done.NEXT = this.flowChart7;
            this.FC_Auto_Trigger_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_Done.OverTimeSpec = 100;
            this.FC_Auto_Trigger_Done.Running = false;
            this.FC_Auto_Trigger_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_Done.SlowRunCycle = -1;
            this.FC_Auto_Trigger_Done.StartFC = null;
            this.FC_Auto_Trigger_Done.Text = "Done";
            this.FC_Auto_Trigger_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_Done_Run);
            // 
            // flowChart7
            // 
            this.flowChart7.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart7.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart7.CASE1 = null;
            this.flowChart7.CASE2 = null;
            this.flowChart7.CASE3 = null;
            this.flowChart7.CASE4 = null;
            this.flowChart7.ContinueRun = false;
            this.flowChart7.DesignTimeParent = null;
            this.flowChart7.EndFC = null;
            this.flowChart7.ErrID = 0;
            this.flowChart7.InAlarm = false;
            this.flowChart7.IsFlowHead = false;
            this.flowChart7.Location = new System.Drawing.Point(497, 173);
            this.flowChart7.LockUI = false;
            this.flowChart7.Message = null;
            this.flowChart7.MsgID = 0;
            this.flowChart7.Name = "flowChart7";
            this.flowChart7.NEXT = this.flowChart4;
            this.flowChart7.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart7.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart7.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart7.OverTimeSpec = 100;
            this.flowChart7.Running = false;
            this.flowChart7.Size = new System.Drawing.Size(30, 30);
            this.flowChart7.SlowRunCycle = -1;
            this.flowChart7.StartFC = null;
            this.flowChart7.Text = "N";
            this.flowChart7.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // flowChart4
            // 
            this.flowChart4.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart4.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart4.CASE1 = null;
            this.flowChart4.CASE2 = null;
            this.flowChart4.CASE3 = null;
            this.flowChart4.CASE4 = null;
            this.flowChart4.ContinueRun = false;
            this.flowChart4.DesignTimeParent = null;
            this.flowChart4.EndFC = null;
            this.flowChart4.ErrID = 0;
            this.flowChart4.InAlarm = false;
            this.flowChart4.IsFlowHead = false;
            this.flowChart4.Location = new System.Drawing.Point(497, 97);
            this.flowChart4.LockUI = false;
            this.flowChart4.Message = null;
            this.flowChart4.MsgID = 0;
            this.flowChart4.Name = "flowChart4";
            this.flowChart4.NEXT = this.FC_Auto_Trigger_WaitCmd;
            this.flowChart4.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart4.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart4.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart4.OverTimeSpec = 100;
            this.flowChart4.Running = false;
            this.flowChart4.Size = new System.Drawing.Size(30, 30);
            this.flowChart4.SlowRunCycle = -1;
            this.flowChart4.StartFC = null;
            this.flowChart4.Text = "N";
            this.flowChart4.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_Auto_Trigger_Connect
            // 
            this.FC_Auto_Trigger_Connect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_Connect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_Connect.CASE1 = null;
            this.FC_Auto_Trigger_Connect.CASE2 = null;
            this.FC_Auto_Trigger_Connect.CASE3 = null;
            this.FC_Auto_Trigger_Connect.CASE4 = null;
            this.FC_Auto_Trigger_Connect.ContinueRun = false;
            this.FC_Auto_Trigger_Connect.DesignTimeParent = null;
            this.FC_Auto_Trigger_Connect.EndFC = null;
            this.FC_Auto_Trigger_Connect.ErrID = 0;
            this.FC_Auto_Trigger_Connect.InAlarm = false;
            this.FC_Auto_Trigger_Connect.IsFlowHead = false;
            this.FC_Auto_Trigger_Connect.Location = new System.Drawing.Point(49, 97);
            this.FC_Auto_Trigger_Connect.LockUI = false;
            this.FC_Auto_Trigger_Connect.Message = null;
            this.FC_Auto_Trigger_Connect.MsgID = 0;
            this.FC_Auto_Trigger_Connect.Name = "FC_Auto_Trigger_Connect";
            this.FC_Auto_Trigger_Connect.NEXT = this.FC_Auto_Trigger_Trigger;
            this.FC_Auto_Trigger_Connect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_Connect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_Connect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_Connect.OverTimeSpec = 100;
            this.FC_Auto_Trigger_Connect.Running = false;
            this.FC_Auto_Trigger_Connect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Trigger_Connect.SlowRunCycle = -1;
            this.FC_Auto_Trigger_Connect.StartFC = null;
            this.FC_Auto_Trigger_Connect.Text = "Connect";
            this.FC_Auto_Trigger_Connect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Trigger_Connect_Run);
            // 
            // btn_ORC_Connect
            // 
            this.btn_ORC_Connect.Location = new System.Drawing.Point(22, 40);
            this.btn_ORC_Connect.Name = "btn_ORC_Connect";
            this.btn_ORC_Connect.Size = new System.Drawing.Size(173, 45);
            this.btn_ORC_Connect.TabIndex = 16;
            this.btn_ORC_Connect.Text = "Connect";
            this.btn_ORC_Connect.UseVisualStyleBackColor = true;
            this.btn_ORC_Connect.Click += new System.EventHandler(this.btn_ORC_Connect_Click);
            // 
            // btn_ORC_Read
            // 
            this.btn_ORC_Read.Location = new System.Drawing.Point(201, 40);
            this.btn_ORC_Read.Name = "btn_ORC_Read";
            this.btn_ORC_Read.Size = new System.Drawing.Size(173, 45);
            this.btn_ORC_Read.TabIndex = 17;
            this.btn_ORC_Read.Text = "Read";
            this.btn_ORC_Read.UseVisualStyleBackColor = true;
            this.btn_ORC_Read.Click += new System.EventHandler(this.btn_ORC_Read_Click);
            // 
            // btn_ORC_Disconnect
            // 
            this.btn_ORC_Disconnect.Location = new System.Drawing.Point(22, 91);
            this.btn_ORC_Disconnect.Name = "btn_ORC_Disconnect";
            this.btn_ORC_Disconnect.Size = new System.Drawing.Size(173, 45);
            this.btn_ORC_Disconnect.TabIndex = 18;
            this.btn_ORC_Disconnect.Text = "Disconnect";
            this.btn_ORC_Disconnect.UseVisualStyleBackColor = true;
            this.btn_ORC_Disconnect.Click += new System.EventHandler(this.btn_ORC_Disconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_ReadTime);
            this.groupBox1.Controls.Add(this.lb_WaferID);
            this.groupBox1.Controls.Add(this.btn_ORC_Connect);
            this.groupBox1.Controls.Add(this.btn_ORC_Disconnect);
            this.groupBox1.Controls.Add(this.btn_ORC_Read);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 162);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OCR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Time(ms):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "WaferID:";
            // 
            // lb_ReadTime
            // 
            this.lb_ReadTime.AutoSize = true;
            this.lb_ReadTime.Location = new System.Drawing.Point(293, 112);
            this.lb_ReadTime.Name = "lb_ReadTime";
            this.lb_ReadTime.Size = new System.Drawing.Size(47, 21);
            this.lb_ReadTime.TabIndex = 20;
            this.lb_ReadTime.Text = "Time";
            // 
            // lb_WaferID
            // 
            this.lb_WaferID.AutoSize = true;
            this.lb_WaferID.Location = new System.Drawing.Point(293, 91);
            this.lb_WaferID.Name = "lb_WaferID";
            this.lb_WaferID.Size = new System.Drawing.Size(27, 21);
            this.lb_WaferID.TabIndex = 19;
            this.lb_WaferID.Text = "ID";
            // 
            // flowChart5
            // 
            this.flowChart5.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart5.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart5.CASE1 = null;
            this.flowChart5.CASE2 = null;
            this.flowChart5.CASE3 = null;
            this.flowChart5.CASE4 = null;
            this.flowChart5.ContinueRun = false;
            this.flowChart5.DesignTimeParent = null;
            this.flowChart5.EndFC = null;
            this.flowChart5.ErrID = 0;
            this.flowChart5.InAlarm = false;
            this.flowChart5.IsFlowHead = false;
            this.flowChart5.Location = new System.Drawing.Point(798, 97);
            this.flowChart5.LockUI = false;
            this.flowChart5.Message = null;
            this.flowChart5.MsgID = 0;
            this.flowChart5.Name = "flowChart5";
            this.flowChart5.NEXT = this.FC_Auto_OcrConnect_WaitCmd;
            this.flowChart5.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart5.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart5.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart5.OverTimeSpec = 100;
            this.flowChart5.Running = false;
            this.flowChart5.Size = new System.Drawing.Size(30, 30);
            this.flowChart5.SlowRunCycle = -1;
            this.flowChart5.StartFC = null;
            this.flowChart5.Text = "N";
            this.flowChart5.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_Auto_OcrConnect_WaitCmd
            // 
            this.FC_Auto_OcrConnect_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_OcrConnect_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_OcrConnect_WaitCmd.CASE1 = null;
            this.FC_Auto_OcrConnect_WaitCmd.CASE2 = null;
            this.FC_Auto_OcrConnect_WaitCmd.CASE3 = null;
            this.FC_Auto_OcrConnect_WaitCmd.CASE4 = null;
            this.FC_Auto_OcrConnect_WaitCmd.ContinueRun = false;
            this.FC_Auto_OcrConnect_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_OcrConnect_WaitCmd.EndFC = null;
            this.FC_Auto_OcrConnect_WaitCmd.ErrID = 0;
            this.FC_Auto_OcrConnect_WaitCmd.InAlarm = false;
            this.FC_Auto_OcrConnect_WaitCmd.IsFlowHead = false;
            this.FC_Auto_OcrConnect_WaitCmd.Location = new System.Drawing.Point(574, 97);
            this.FC_Auto_OcrConnect_WaitCmd.LockUI = false;
            this.FC_Auto_OcrConnect_WaitCmd.Message = null;
            this.FC_Auto_OcrConnect_WaitCmd.MsgID = 0;
            this.FC_Auto_OcrConnect_WaitCmd.Name = "FC_Auto_OcrConnect_WaitCmd";
            this.FC_Auto_OcrConnect_WaitCmd.NEXT = this.FC_Auto_OcrConnect_Connect;
            this.FC_Auto_OcrConnect_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_OcrConnect_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_OcrConnect_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_OcrConnect_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_OcrConnect_WaitCmd.Running = false;
            this.FC_Auto_OcrConnect_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_OcrConnect_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_OcrConnect_WaitCmd.StartFC = null;
            this.FC_Auto_OcrConnect_WaitCmd.Text = "Wait Command";
            this.FC_Auto_OcrConnect_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_OcrConnect_WaitCmd_Run);
            // 
            // FC_Auto_OcrConnect_Connect
            // 
            this.FC_Auto_OcrConnect_Connect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_OcrConnect_Connect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_OcrConnect_Connect.CASE1 = null;
            this.FC_Auto_OcrConnect_Connect.CASE2 = null;
            this.FC_Auto_OcrConnect_Connect.CASE3 = null;
            this.FC_Auto_OcrConnect_Connect.CASE4 = null;
            this.FC_Auto_OcrConnect_Connect.ContinueRun = false;
            this.FC_Auto_OcrConnect_Connect.DesignTimeParent = null;
            this.FC_Auto_OcrConnect_Connect.EndFC = null;
            this.FC_Auto_OcrConnect_Connect.ErrID = 0;
            this.FC_Auto_OcrConnect_Connect.InAlarm = false;
            this.FC_Auto_OcrConnect_Connect.IsFlowHead = false;
            this.FC_Auto_OcrConnect_Connect.Location = new System.Drawing.Point(574, 135);
            this.FC_Auto_OcrConnect_Connect.LockUI = false;
            this.FC_Auto_OcrConnect_Connect.Message = null;
            this.FC_Auto_OcrConnect_Connect.MsgID = 0;
            this.FC_Auto_OcrConnect_Connect.Name = "FC_Auto_OcrConnect_Connect";
            this.FC_Auto_OcrConnect_Connect.NEXT = this.FC_Auto_OcrConnect_Done;
            this.FC_Auto_OcrConnect_Connect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_OcrConnect_Connect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_OcrConnect_Connect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_OcrConnect_Connect.OverTimeSpec = 100;
            this.FC_Auto_OcrConnect_Connect.Running = false;
            this.FC_Auto_OcrConnect_Connect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_OcrConnect_Connect.SlowRunCycle = -1;
            this.FC_Auto_OcrConnect_Connect.StartFC = null;
            this.FC_Auto_OcrConnect_Connect.Text = "Connect";
            this.FC_Auto_OcrConnect_Connect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_OcrConnect_Connect_Run);
            // 
            // FC_Auto_OcrConnect_Done
            // 
            this.FC_Auto_OcrConnect_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_OcrConnect_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_OcrConnect_Done.CASE1 = null;
            this.FC_Auto_OcrConnect_Done.CASE2 = null;
            this.FC_Auto_OcrConnect_Done.CASE3 = null;
            this.FC_Auto_OcrConnect_Done.CASE4 = null;
            this.FC_Auto_OcrConnect_Done.ContinueRun = false;
            this.FC_Auto_OcrConnect_Done.DesignTimeParent = null;
            this.FC_Auto_OcrConnect_Done.EndFC = null;
            this.FC_Auto_OcrConnect_Done.ErrID = 0;
            this.FC_Auto_OcrConnect_Done.InAlarm = false;
            this.FC_Auto_OcrConnect_Done.IsFlowHead = false;
            this.FC_Auto_OcrConnect_Done.Location = new System.Drawing.Point(574, 173);
            this.FC_Auto_OcrConnect_Done.LockUI = false;
            this.FC_Auto_OcrConnect_Done.Message = null;
            this.FC_Auto_OcrConnect_Done.MsgID = 0;
            this.FC_Auto_OcrConnect_Done.Name = "FC_Auto_OcrConnect_Done";
            this.FC_Auto_OcrConnect_Done.NEXT = this.FC_Auto_Trigger_WaitCmd0;
            this.FC_Auto_OcrConnect_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_OcrConnect_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_OcrConnect_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_OcrConnect_Done.OverTimeSpec = 100;
            this.FC_Auto_OcrConnect_Done.Running = false;
            this.FC_Auto_OcrConnect_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_OcrConnect_Done.SlowRunCycle = -1;
            this.FC_Auto_OcrConnect_Done.StartFC = null;
            this.FC_Auto_OcrConnect_Done.Text = "Done";
            this.FC_Auto_OcrConnect_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_OcrConnect_Done_Run);
            // 
            // FC_Auto_Trigger_WaitCmd0
            // 
            this.FC_Auto_Trigger_WaitCmd0.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Trigger_WaitCmd0.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Trigger_WaitCmd0.CASE1 = null;
            this.FC_Auto_Trigger_WaitCmd0.CASE2 = null;
            this.FC_Auto_Trigger_WaitCmd0.CASE3 = null;
            this.FC_Auto_Trigger_WaitCmd0.CASE4 = null;
            this.FC_Auto_Trigger_WaitCmd0.ContinueRun = false;
            this.FC_Auto_Trigger_WaitCmd0.DesignTimeParent = null;
            this.FC_Auto_Trigger_WaitCmd0.EndFC = null;
            this.FC_Auto_Trigger_WaitCmd0.ErrID = 0;
            this.FC_Auto_Trigger_WaitCmd0.InAlarm = false;
            this.FC_Auto_Trigger_WaitCmd0.IsFlowHead = false;
            this.FC_Auto_Trigger_WaitCmd0.Location = new System.Drawing.Point(798, 173);
            this.FC_Auto_Trigger_WaitCmd0.LockUI = false;
            this.FC_Auto_Trigger_WaitCmd0.Message = null;
            this.FC_Auto_Trigger_WaitCmd0.MsgID = 0;
            this.FC_Auto_Trigger_WaitCmd0.Name = "FC_Auto_Trigger_WaitCmd0";
            this.FC_Auto_Trigger_WaitCmd0.NEXT = this.flowChart5;
            this.FC_Auto_Trigger_WaitCmd0.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Trigger_WaitCmd0.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Trigger_WaitCmd0.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Trigger_WaitCmd0.OverTimeSpec = 100;
            this.FC_Auto_Trigger_WaitCmd0.Running = false;
            this.FC_Auto_Trigger_WaitCmd0.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Trigger_WaitCmd0.SlowRunCycle = -1;
            this.FC_Auto_Trigger_WaitCmd0.StartFC = null;
            this.FC_Auto_Trigger_WaitCmd0.Text = "N";
            this.FC_Auto_Trigger_WaitCmd0.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_AUTO_OCRCONNECT_START
            // 
            this.FC_AUTO_OCRCONNECT_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_OCRCONNECT_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_OCRCONNECT_START.CASE1 = null;
            this.FC_AUTO_OCRCONNECT_START.CASE2 = null;
            this.FC_AUTO_OCRCONNECT_START.CASE3 = null;
            this.FC_AUTO_OCRCONNECT_START.CASE4 = null;
            this.FC_AUTO_OCRCONNECT_START.ContinueRun = false;
            this.FC_AUTO_OCRCONNECT_START.DesignTimeParent = null;
            this.FC_AUTO_OCRCONNECT_START.EndFC = null;
            this.FC_AUTO_OCRCONNECT_START.ErrID = 0;
            this.FC_AUTO_OCRCONNECT_START.InAlarm = false;
            this.FC_AUTO_OCRCONNECT_START.IsFlowHead = false;
            this.FC_AUTO_OCRCONNECT_START.Location = new System.Drawing.Point(574, 59);
            this.FC_AUTO_OCRCONNECT_START.LockUI = false;
            this.FC_AUTO_OCRCONNECT_START.Message = null;
            this.FC_AUTO_OCRCONNECT_START.MsgID = 0;
            this.FC_AUTO_OCRCONNECT_START.Name = "FC_AUTO_OCRCONNECT_START";
            this.FC_AUTO_OCRCONNECT_START.NEXT = this.FC_Auto_OcrConnect_WaitCmd;
            this.FC_AUTO_OCRCONNECT_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_OCRCONNECT_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_OCRCONNECT_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_OCRCONNECT_START.OverTimeSpec = 100;
            this.FC_AUTO_OCRCONNECT_START.Running = false;
            this.FC_AUTO_OCRCONNECT_START.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_OCRCONNECT_START.SlowRunCycle = -1;
            this.FC_AUTO_OCRCONNECT_START.StartFC = null;
            this.FC_AUTO_OCRCONNECT_START.Text = "OCR Connect Main";
            this.FC_AUTO_OCRCONNECT_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_OCRCONNECT_START_Run);
            // 
            // flowChart1
            // 
            this.flowChart1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart1.CASE1 = null;
            this.flowChart1.CASE2 = null;
            this.flowChart1.CASE3 = null;
            this.flowChart1.CASE4 = null;
            this.flowChart1.ContinueRun = false;
            this.flowChart1.DesignTimeParent = null;
            this.flowChart1.EndFC = null;
            this.flowChart1.ErrID = 0;
            this.flowChart1.InAlarm = false;
            this.flowChart1.IsFlowHead = false;
            this.flowChart1.Location = new System.Drawing.Point(1092, 97);
            this.flowChart1.LockUI = false;
            this.flowChart1.Message = null;
            this.flowChart1.MsgID = 0;
            this.flowChart1.Name = "flowChart1";
            this.flowChart1.NEXT = this.FC_AUTO_InchSwitch_WaitCmd;
            this.flowChart1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart1.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart1.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart1.OverTimeSpec = 100;
            this.flowChart1.Running = false;
            this.flowChart1.Size = new System.Drawing.Size(30, 30);
            this.flowChart1.SlowRunCycle = -1;
            this.flowChart1.StartFC = null;
            this.flowChart1.Text = "N";
            this.flowChart1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_AUTO_InchSwitch_WaitCmd
            // 
            this.FC_AUTO_InchSwitch_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_InchSwitch_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_InchSwitch_WaitCmd.CASE1 = null;
            this.FC_AUTO_InchSwitch_WaitCmd.CASE2 = null;
            this.FC_AUTO_InchSwitch_WaitCmd.CASE3 = null;
            this.FC_AUTO_InchSwitch_WaitCmd.CASE4 = null;
            this.FC_AUTO_InchSwitch_WaitCmd.ContinueRun = false;
            this.FC_AUTO_InchSwitch_WaitCmd.DesignTimeParent = null;
            this.FC_AUTO_InchSwitch_WaitCmd.EndFC = null;
            this.FC_AUTO_InchSwitch_WaitCmd.ErrID = 0;
            this.FC_AUTO_InchSwitch_WaitCmd.InAlarm = false;
            this.FC_AUTO_InchSwitch_WaitCmd.IsFlowHead = false;
            this.FC_AUTO_InchSwitch_WaitCmd.Location = new System.Drawing.Point(868, 97);
            this.FC_AUTO_InchSwitch_WaitCmd.LockUI = false;
            this.FC_AUTO_InchSwitch_WaitCmd.Message = null;
            this.FC_AUTO_InchSwitch_WaitCmd.MsgID = 0;
            this.FC_AUTO_InchSwitch_WaitCmd.Name = "FC_AUTO_InchSwitch_WaitCmd";
            this.FC_AUTO_InchSwitch_WaitCmd.NEXT = this.FC_AUTO_InchSwitch_CyliderAction;
            this.FC_AUTO_InchSwitch_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_InchSwitch_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_InchSwitch_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_InchSwitch_WaitCmd.OverTimeSpec = 100;
            this.FC_AUTO_InchSwitch_WaitCmd.Running = false;
            this.FC_AUTO_InchSwitch_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_InchSwitch_WaitCmd.SlowRunCycle = -1;
            this.FC_AUTO_InchSwitch_WaitCmd.StartFC = null;
            this.FC_AUTO_InchSwitch_WaitCmd.Text = "Wait Command";
            this.FC_AUTO_InchSwitch_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_InchSwitch_WaitCmd_Run);
            // 
            // FC_AUTO_InchSwitch_CyliderAction
            // 
            this.FC_AUTO_InchSwitch_CyliderAction.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_InchSwitch_CyliderAction.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_InchSwitch_CyliderAction.CASE1 = null;
            this.FC_AUTO_InchSwitch_CyliderAction.CASE2 = null;
            this.FC_AUTO_InchSwitch_CyliderAction.CASE3 = null;
            this.FC_AUTO_InchSwitch_CyliderAction.CASE4 = null;
            this.FC_AUTO_InchSwitch_CyliderAction.ContinueRun = false;
            this.FC_AUTO_InchSwitch_CyliderAction.DesignTimeParent = null;
            this.FC_AUTO_InchSwitch_CyliderAction.EndFC = null;
            this.FC_AUTO_InchSwitch_CyliderAction.ErrID = 0;
            this.FC_AUTO_InchSwitch_CyliderAction.InAlarm = false;
            this.FC_AUTO_InchSwitch_CyliderAction.IsFlowHead = false;
            this.FC_AUTO_InchSwitch_CyliderAction.Location = new System.Drawing.Point(868, 135);
            this.FC_AUTO_InchSwitch_CyliderAction.LockUI = false;
            this.FC_AUTO_InchSwitch_CyliderAction.Message = null;
            this.FC_AUTO_InchSwitch_CyliderAction.MsgID = 0;
            this.FC_AUTO_InchSwitch_CyliderAction.Name = "FC_AUTO_InchSwitch_CyliderAction";
            this.FC_AUTO_InchSwitch_CyliderAction.NEXT = this.FC_AUTO_InchSwitch_Done;
            this.FC_AUTO_InchSwitch_CyliderAction.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_InchSwitch_CyliderAction.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_InchSwitch_CyliderAction.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_InchSwitch_CyliderAction.OverTimeSpec = 100;
            this.FC_AUTO_InchSwitch_CyliderAction.Running = false;
            this.FC_AUTO_InchSwitch_CyliderAction.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_InchSwitch_CyliderAction.SlowRunCycle = -1;
            this.FC_AUTO_InchSwitch_CyliderAction.StartFC = null;
            this.FC_AUTO_InchSwitch_CyliderAction.Text = "Cylider Action";
            this.FC_AUTO_InchSwitch_CyliderAction.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_InchSwitch_CyliderAction_Run);
            // 
            // FC_AUTO_InchSwitch_Done
            // 
            this.FC_AUTO_InchSwitch_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_InchSwitch_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_InchSwitch_Done.CASE1 = null;
            this.FC_AUTO_InchSwitch_Done.CASE2 = null;
            this.FC_AUTO_InchSwitch_Done.CASE3 = null;
            this.FC_AUTO_InchSwitch_Done.CASE4 = null;
            this.FC_AUTO_InchSwitch_Done.ContinueRun = false;
            this.FC_AUTO_InchSwitch_Done.DesignTimeParent = null;
            this.FC_AUTO_InchSwitch_Done.EndFC = null;
            this.FC_AUTO_InchSwitch_Done.ErrID = 0;
            this.FC_AUTO_InchSwitch_Done.InAlarm = false;
            this.FC_AUTO_InchSwitch_Done.IsFlowHead = false;
            this.FC_AUTO_InchSwitch_Done.Location = new System.Drawing.Point(868, 173);
            this.FC_AUTO_InchSwitch_Done.LockUI = false;
            this.FC_AUTO_InchSwitch_Done.Message = null;
            this.FC_AUTO_InchSwitch_Done.MsgID = 0;
            this.FC_AUTO_InchSwitch_Done.Name = "FC_AUTO_InchSwitch_Done";
            this.FC_AUTO_InchSwitch_Done.NEXT = this.flowChart8;
            this.FC_AUTO_InchSwitch_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_InchSwitch_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_InchSwitch_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_InchSwitch_Done.OverTimeSpec = 100;
            this.FC_AUTO_InchSwitch_Done.Running = false;
            this.FC_AUTO_InchSwitch_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_InchSwitch_Done.SlowRunCycle = -1;
            this.FC_AUTO_InchSwitch_Done.StartFC = null;
            this.FC_AUTO_InchSwitch_Done.Text = "Done";
            this.FC_AUTO_InchSwitch_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_InchSwitch_Done_Run);
            // 
            // flowChart8
            // 
            this.flowChart8.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart8.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart8.CASE1 = null;
            this.flowChart8.CASE2 = null;
            this.flowChart8.CASE3 = null;
            this.flowChart8.CASE4 = null;
            this.flowChart8.ContinueRun = false;
            this.flowChart8.DesignTimeParent = null;
            this.flowChart8.EndFC = null;
            this.flowChart8.ErrID = 0;
            this.flowChart8.InAlarm = false;
            this.flowChart8.IsFlowHead = false;
            this.flowChart8.Location = new System.Drawing.Point(1092, 173);
            this.flowChart8.LockUI = false;
            this.flowChart8.Message = null;
            this.flowChart8.MsgID = 0;
            this.flowChart8.Name = "flowChart8";
            this.flowChart8.NEXT = this.flowChart1;
            this.flowChart8.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart8.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart8.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart8.OverTimeSpec = 100;
            this.flowChart8.Running = false;
            this.flowChart8.Size = new System.Drawing.Size(30, 30);
            this.flowChart8.SlowRunCycle = -1;
            this.flowChart8.StartFC = null;
            this.flowChart8.Text = "N";
            this.flowChart8.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_AUTO_INCH_SWITCH_START
            // 
            this.FC_AUTO_INCH_SWITCH_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_AUTO_INCH_SWITCH_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_AUTO_INCH_SWITCH_START.CASE1 = null;
            this.FC_AUTO_INCH_SWITCH_START.CASE2 = null;
            this.FC_AUTO_INCH_SWITCH_START.CASE3 = null;
            this.FC_AUTO_INCH_SWITCH_START.CASE4 = null;
            this.FC_AUTO_INCH_SWITCH_START.ContinueRun = false;
            this.FC_AUTO_INCH_SWITCH_START.DesignTimeParent = null;
            this.FC_AUTO_INCH_SWITCH_START.EndFC = null;
            this.FC_AUTO_INCH_SWITCH_START.ErrID = 0;
            this.FC_AUTO_INCH_SWITCH_START.InAlarm = false;
            this.FC_AUTO_INCH_SWITCH_START.IsFlowHead = false;
            this.FC_AUTO_INCH_SWITCH_START.Location = new System.Drawing.Point(868, 59);
            this.FC_AUTO_INCH_SWITCH_START.LockUI = false;
            this.FC_AUTO_INCH_SWITCH_START.Message = null;
            this.FC_AUTO_INCH_SWITCH_START.MsgID = 0;
            this.FC_AUTO_INCH_SWITCH_START.Name = "FC_AUTO_INCH_SWITCH_START";
            this.FC_AUTO_INCH_SWITCH_START.NEXT = this.FC_AUTO_InchSwitch_WaitCmd;
            this.FC_AUTO_INCH_SWITCH_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_AUTO_INCH_SWITCH_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_AUTO_INCH_SWITCH_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_AUTO_INCH_SWITCH_START.OverTimeSpec = 100;
            this.FC_AUTO_INCH_SWITCH_START.Running = false;
            this.FC_AUTO_INCH_SWITCH_START.Size = new System.Drawing.Size(200, 30);
            this.FC_AUTO_INCH_SWITCH_START.SlowRunCycle = -1;
            this.FC_AUTO_INCH_SWITCH_START.StartFC = null;
            this.FC_AUTO_INCH_SWITCH_START.Text = "Inch Switch Main";
            this.FC_AUTO_INCH_SWITCH_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_AUTO_INCH_SWITCH_START_Run);
            // 
            // dCheckBox2
            // 
            this.dCheckBox2.AutoSize = true;
            this.dCheckBox2.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox2.DataName = "UseTeachingSoftware";
            this.dCheckBox2.DataSource = this.SetDS;
            this.dCheckBox2.DefaultValue = false;
            this.dCheckBox2.IsModified = false;
            this.dCheckBox2.Location = new System.Drawing.Point(22, 75);
            this.dCheckBox2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox2.Name = "dCheckBox2";
            this.dCheckBox2.NoChangeInAuto = false;
            this.dCheckBox2.Size = new System.Drawing.Size(263, 30);
            this.dCheckBox2.TabIndex = 31;
            this.dCheckBox2.Text = "Use Teaching Software";
            this.dCheckBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(291, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "*When unable to read";
            // 
            // dCheckBox3
            // 
            this.dCheckBox3.AutoSize = true;
            this.dCheckBox3.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox3.DataName = "UseOCRInSimulation";
            this.dCheckBox3.DataSource = this.SetDS;
            this.dCheckBox3.DefaultValue = false;
            this.dCheckBox3.IsModified = false;
            this.dCheckBox3.Location = new System.Drawing.Point(476, 81);
            this.dCheckBox3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox3.Name = "dCheckBox3";
            this.dCheckBox3.NoChangeInAuto = false;
            this.dCheckBox3.Size = new System.Drawing.Size(258, 30);
            this.dCheckBox3.TabIndex = 33;
            this.dCheckBox3.Text = "Use OCR in Simulation";
            this.dCheckBox3.UseVisualStyleBackColor = true;
            // 
            // dFieldEdit3
            // 
            this.dFieldEdit3.AutoFocus = false;
            this.dFieldEdit3.Caption = "Teaching Software Path";
            this.dFieldEdit3.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit3.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.DataName = "B_sTeachingSoftwarePath";
            this.dFieldEdit3.DataSource = this.SetDS;
            this.dFieldEdit3.DefaultValue = null;
            this.dFieldEdit3.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit3.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.EditWidth = 350;
            this.dFieldEdit3.FieldValue = "";
            this.dFieldEdit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit3.IsModified = false;
            this.dFieldEdit3.Location = new System.Drawing.Point(22, 194);
            this.dFieldEdit3.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit3.MaxValue = 9999999D;
            this.dFieldEdit3.MinValue = -9999999D;
            this.dFieldEdit3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit3.Name = "dFieldEdit3";
            this.dFieldEdit3.NoChangeInAuto = false;
            this.dFieldEdit3.Size = new System.Drawing.Size(592, 30);
            this.dFieldEdit3.StepValue = 0D;
            this.dFieldEdit3.TabIndex = 33;
            this.dFieldEdit3.Unit = "";
            this.dFieldEdit3.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.UnitWidth = 0;
            this.dFieldEdit3.ValueType = KCSDK.ValueDataType.String;
            // 
            // btn_OpenTeachingSoftware
            // 
            this.btn_OpenTeachingSoftware.Location = new System.Drawing.Point(545, 72);
            this.btn_OpenTeachingSoftware.Name = "btn_OpenTeachingSoftware";
            this.btn_OpenTeachingSoftware.Size = new System.Drawing.Size(173, 68);
            this.btn_OpenTeachingSoftware.TabIndex = 20;
            this.btn_OpenTeachingSoftware.Text = "Open Teaching Software";
            this.btn_OpenTeachingSoftware.UseVisualStyleBackColor = true;
            this.btn_OpenTeachingSoftware.Click += new System.EventHandler(this.btn_OpenTeachingSoftware_Click);
            // 
            // pbx_OCR_Read
            // 
            this.pbx_OCR_Read.Location = new System.Drawing.Point(17, 223);
            this.pbx_OCR_Read.Name = "pbx_OCR_Read";
            this.pbx_OCR_Read.Size = new System.Drawing.Size(510, 273);
            this.pbx_OCR_Read.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_OCR_Read.TabIndex = 21;
            this.pbx_OCR_Read.TabStop = false;
            // 
            // lb_OcrResult
            // 
            this.lb_OcrResult.AutoSize = true;
            this.lb_OcrResult.BackColor = System.Drawing.Color.Gray;
            this.lb_OcrResult.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_OcrResult.ForeColor = System.Drawing.Color.Lime;
            this.lb_OcrResult.Location = new System.Drawing.Point(17, 223);
            this.lb_OcrResult.Name = "lb_OcrResult";
            this.lb_OcrResult.Size = new System.Drawing.Size(74, 47);
            this.lb_OcrResult.TabIndex = 22;
            this.lb_OcrResult.Text = "OK";
            // 
            // dCheckBox4
            // 
            this.dCheckBox4.AutoSize = true;
            this.dCheckBox4.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox4.DataName = "SaveOCRImage";
            this.dCheckBox4.DataSource = this.SetDS;
            this.dCheckBox4.DefaultValue = false;
            this.dCheckBox4.IsModified = false;
            this.dCheckBox4.Location = new System.Drawing.Point(22, 111);
            this.dCheckBox4.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox4.Name = "dCheckBox4";
            this.dCheckBox4.NoChangeInAuto = false;
            this.dCheckBox4.Size = new System.Drawing.Size(197, 30);
            this.dCheckBox4.TabIndex = 34;
            this.dCheckBox4.Text = "Save OCR Image";
            this.dCheckBox4.UseVisualStyleBackColor = true;
            // 
            // FC_Auto_TeachAngleMode_Done
            // 
            this.FC_Auto_TeachAngleMode_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_Done.CASE1 = null;
            this.FC_Auto_TeachAngleMode_Done.CASE2 = null;
            this.FC_Auto_TeachAngleMode_Done.CASE3 = null;
            this.FC_Auto_TeachAngleMode_Done.CASE4 = null;
            this.FC_Auto_TeachAngleMode_Done.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_Done.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_Done.EndFC = null;
            this.FC_Auto_TeachAngleMode_Done.ErrID = 0;
            this.FC_Auto_TeachAngleMode_Done.InAlarm = false;
            this.FC_Auto_TeachAngleMode_Done.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_Done.Location = new System.Drawing.Point(273, 411);
            this.FC_Auto_TeachAngleMode_Done.LockUI = false;
            this.FC_Auto_TeachAngleMode_Done.Message = null;
            this.FC_Auto_TeachAngleMode_Done.MsgID = 0;
            this.FC_Auto_TeachAngleMode_Done.Name = "FC_Auto_TeachAngleMode_Done";
            this.FC_Auto_TeachAngleMode_Done.NEXT = this.flowChart6;
            this.FC_Auto_TeachAngleMode_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_Done.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_Done.Running = false;
            this.FC_Auto_TeachAngleMode_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_Done.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_Done.StartFC = null;
            this.FC_Auto_TeachAngleMode_Done.Text = "Done";
            this.FC_Auto_TeachAngleMode_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_Done_Run);
            // 
            // flowChart6
            // 
            this.flowChart6.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart6.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart6.CASE1 = null;
            this.flowChart6.CASE2 = null;
            this.flowChart6.CASE3 = null;
            this.flowChart6.CASE4 = null;
            this.flowChart6.ContinueRun = false;
            this.flowChart6.DesignTimeParent = null;
            this.flowChart6.EndFC = null;
            this.flowChart6.ErrID = 0;
            this.flowChart6.InAlarm = false;
            this.flowChart6.IsFlowHead = false;
            this.flowChart6.Location = new System.Drawing.Point(497, 411);
            this.flowChart6.LockUI = false;
            this.flowChart6.Message = null;
            this.flowChart6.MsgID = 0;
            this.flowChart6.Name = "flowChart6";
            this.flowChart6.NEXT = this.flowChart9;
            this.flowChart6.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart6.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart6.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart6.OverTimeSpec = 100;
            this.flowChart6.Running = false;
            this.flowChart6.Size = new System.Drawing.Size(30, 30);
            this.flowChart6.SlowRunCycle = -1;
            this.flowChart6.StartFC = null;
            this.flowChart6.Text = "N";
            this.flowChart6.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // flowChart9
            // 
            this.flowChart9.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart9.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart9.CASE1 = null;
            this.flowChart9.CASE2 = null;
            this.flowChart9.CASE3 = null;
            this.flowChart9.CASE4 = null;
            this.flowChart9.ContinueRun = false;
            this.flowChart9.DesignTimeParent = null;
            this.flowChart9.EndFC = null;
            this.flowChart9.ErrID = 0;
            this.flowChart9.InAlarm = false;
            this.flowChart9.IsFlowHead = false;
            this.flowChart9.Location = new System.Drawing.Point(497, 335);
            this.flowChart9.LockUI = false;
            this.flowChart9.Message = null;
            this.flowChart9.MsgID = 0;
            this.flowChart9.Name = "flowChart9";
            this.flowChart9.NEXT = this.FC_Auto_TeachAngleMode_WaitCommand;
            this.flowChart9.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart9.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart9.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart9.OverTimeSpec = 100;
            this.flowChart9.Running = false;
            this.flowChart9.Size = new System.Drawing.Size(30, 30);
            this.flowChart9.SlowRunCycle = -1;
            this.flowChart9.StartFC = null;
            this.flowChart9.Text = "N";
            this.flowChart9.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_NEXT_Run);
            // 
            // FC_Auto_TeachAngleMode_WaitCommand
            // 
            this.FC_Auto_TeachAngleMode_WaitCommand.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_WaitCommand.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_WaitCommand.CASE1 = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.CASE2 = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.CASE3 = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.CASE4 = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_WaitCommand.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.EndFC = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.ErrID = 0;
            this.FC_Auto_TeachAngleMode_WaitCommand.InAlarm = false;
            this.FC_Auto_TeachAngleMode_WaitCommand.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_WaitCommand.Location = new System.Drawing.Point(273, 335);
            this.FC_Auto_TeachAngleMode_WaitCommand.LockUI = false;
            this.FC_Auto_TeachAngleMode_WaitCommand.Message = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.MsgID = 0;
            this.FC_Auto_TeachAngleMode_WaitCommand.Name = "FC_Auto_TeachAngleMode_WaitCommand";
            this.FC_Auto_TeachAngleMode_WaitCommand.NEXT = this.FC_Auto_TeachAngleMode_Trigger;
            this.FC_Auto_TeachAngleMode_WaitCommand.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_WaitCommand.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_WaitCommand.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_WaitCommand.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_WaitCommand.Running = false;
            this.FC_Auto_TeachAngleMode_WaitCommand.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_WaitCommand.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_WaitCommand.StartFC = null;
            this.FC_Auto_TeachAngleMode_WaitCommand.Text = "Wait Command";
            this.FC_Auto_TeachAngleMode_WaitCommand.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_WaitCommand_Run);
            // 
            // FC_Auto_TeachAngleMode_Trigger
            // 
            this.FC_Auto_TeachAngleMode_Trigger.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_Trigger.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_Trigger.CASE1 = this.FC_Auto_TeachAngleMode_ReadIDFailResult;
            this.FC_Auto_TeachAngleMode_Trigger.CASE2 = this.FC_Auto_TeachAngleMode_Connect;
            this.FC_Auto_TeachAngleMode_Trigger.CASE3 = null;
            this.FC_Auto_TeachAngleMode_Trigger.CASE4 = null;
            this.FC_Auto_TeachAngleMode_Trigger.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_Trigger.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_Trigger.EndFC = null;
            this.FC_Auto_TeachAngleMode_Trigger.ErrID = 0;
            this.FC_Auto_TeachAngleMode_Trigger.InAlarm = false;
            this.FC_Auto_TeachAngleMode_Trigger.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_Trigger.Location = new System.Drawing.Point(273, 373);
            this.FC_Auto_TeachAngleMode_Trigger.LockUI = false;
            this.FC_Auto_TeachAngleMode_Trigger.Message = null;
            this.FC_Auto_TeachAngleMode_Trigger.MsgID = 0;
            this.FC_Auto_TeachAngleMode_Trigger.Name = "FC_Auto_TeachAngleMode_Trigger";
            this.FC_Auto_TeachAngleMode_Trigger.NEXT = this.FC_Auto_TeachAngleMode_Done;
            this.FC_Auto_TeachAngleMode_Trigger.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_Trigger.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_Trigger.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_Trigger.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_Trigger.Running = false;
            this.FC_Auto_TeachAngleMode_Trigger.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_Trigger.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_Trigger.StartFC = null;
            this.FC_Auto_TeachAngleMode_Trigger.Text = "Trigger";
            this.FC_Auto_TeachAngleMode_Trigger.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_Trigger_Run);
            // 
            // FC_Auto_TeachAngleMode_ReadIDFailResult
            // 
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.CASE1 = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.CASE2 = this.FC_Auto_TeachAngleMode_ManualInputIDResult;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.CASE3 = this.FC_Auto_TeachAngleMode_Done;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.CASE4 = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.EndFC = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.ErrID = 0;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.InAlarm = false;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Location = new System.Drawing.Point(49, 373);
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.LockUI = false;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Message = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.MsgID = 0;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Name = "FC_Auto_TeachAngleMode_ReadIDFailResult";
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.NEXT = this.FC_Auto_TeachAngleMode_Connect;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Running = false;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.StartFC = null;
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Text = "OCR Read ID Fail Result";
            this.FC_Auto_TeachAngleMode_ReadIDFailResult.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_ReadIDFailResult_Run);
            // 
            // FC_Auto_TeachAngleMode_ManualInputIDResult
            // 
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.CASE1 = this.FC_Auto_TeachAngleMode_Trigger;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.CASE2 = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.CASE3 = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.CASE4 = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.EndFC = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.ErrID = 0;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.InAlarm = false;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Location = new System.Drawing.Point(49, 411);
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.LockUI = false;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Message = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.MsgID = 0;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Name = "FC_Auto_TeachAngleMode_ManualInputIDResult";
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.NEXT = this.FC_Auto_TeachAngleMode_Done;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Running = false;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.StartFC = null;
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Text = "OCR Manual Input ID Result";
            this.FC_Auto_TeachAngleMode_ManualInputIDResult.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_ManualInputIDResult_Run);
            // 
            // FC_Auto_TeachAngleMode_Connect
            // 
            this.FC_Auto_TeachAngleMode_Connect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_Connect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_Connect.CASE1 = null;
            this.FC_Auto_TeachAngleMode_Connect.CASE2 = null;
            this.FC_Auto_TeachAngleMode_Connect.CASE3 = null;
            this.FC_Auto_TeachAngleMode_Connect.CASE4 = null;
            this.FC_Auto_TeachAngleMode_Connect.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_Connect.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_Connect.EndFC = null;
            this.FC_Auto_TeachAngleMode_Connect.ErrID = 0;
            this.FC_Auto_TeachAngleMode_Connect.InAlarm = false;
            this.FC_Auto_TeachAngleMode_Connect.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_Connect.Location = new System.Drawing.Point(49, 335);
            this.FC_Auto_TeachAngleMode_Connect.LockUI = false;
            this.FC_Auto_TeachAngleMode_Connect.Message = null;
            this.FC_Auto_TeachAngleMode_Connect.MsgID = 0;
            this.FC_Auto_TeachAngleMode_Connect.Name = "FC_Auto_TeachAngleMode_Connect";
            this.FC_Auto_TeachAngleMode_Connect.NEXT = this.FC_Auto_TeachAngleMode_Trigger;
            this.FC_Auto_TeachAngleMode_Connect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_Connect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_Connect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_Connect.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_Connect.Running = false;
            this.FC_Auto_TeachAngleMode_Connect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_Connect.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_Connect.StartFC = null;
            this.FC_Auto_TeachAngleMode_Connect.Text = "Connect";
            this.FC_Auto_TeachAngleMode_Connect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_Connect_Run);
            // 
            // FC_Auto_TeachAngleMode_START
            // 
            this.FC_Auto_TeachAngleMode_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_TeachAngleMode_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_TeachAngleMode_START.CASE1 = null;
            this.FC_Auto_TeachAngleMode_START.CASE2 = null;
            this.FC_Auto_TeachAngleMode_START.CASE3 = null;
            this.FC_Auto_TeachAngleMode_START.CASE4 = null;
            this.FC_Auto_TeachAngleMode_START.ContinueRun = false;
            this.FC_Auto_TeachAngleMode_START.DesignTimeParent = null;
            this.FC_Auto_TeachAngleMode_START.EndFC = null;
            this.FC_Auto_TeachAngleMode_START.ErrID = 0;
            this.FC_Auto_TeachAngleMode_START.InAlarm = false;
            this.FC_Auto_TeachAngleMode_START.IsFlowHead = false;
            this.FC_Auto_TeachAngleMode_START.Location = new System.Drawing.Point(273, 297);
            this.FC_Auto_TeachAngleMode_START.LockUI = false;
            this.FC_Auto_TeachAngleMode_START.Message = null;
            this.FC_Auto_TeachAngleMode_START.MsgID = 0;
            this.FC_Auto_TeachAngleMode_START.Name = "FC_Auto_TeachAngleMode_START";
            this.FC_Auto_TeachAngleMode_START.NEXT = this.FC_Auto_TeachAngleMode_WaitCommand;
            this.FC_Auto_TeachAngleMode_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_TeachAngleMode_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_TeachAngleMode_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_TeachAngleMode_START.OverTimeSpec = 100;
            this.FC_Auto_TeachAngleMode_START.Running = false;
            this.FC_Auto_TeachAngleMode_START.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_TeachAngleMode_START.SlowRunCycle = -1;
            this.FC_Auto_TeachAngleMode_START.StartFC = null;
            this.FC_Auto_TeachAngleMode_START.Text = "Teach Angle Mode Main";
            this.FC_Auto_TeachAngleMode_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_TeachAngleMode_START_Run);
            // 
            // dFieldEdit4
            // 
            this.dFieldEdit4.AutoFocus = false;
            this.dFieldEdit4.Caption = "Save Image Folder Path";
            this.dFieldEdit4.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit4.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.DataName = "SaveImageFolderPath";
            this.dFieldEdit4.DataSource = this.SetDS;
            this.dFieldEdit4.DefaultValue = null;
            this.dFieldEdit4.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit4.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.EditWidth = 350;
            this.dFieldEdit4.FieldValue = "";
            this.dFieldEdit4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit4.IsModified = false;
            this.dFieldEdit4.Location = new System.Drawing.Point(22, 320);
            this.dFieldEdit4.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit4.MaxValue = 9999999D;
            this.dFieldEdit4.MinValue = -9999999D;
            this.dFieldEdit4.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit4.Name = "dFieldEdit4";
            this.dFieldEdit4.NoChangeInAuto = false;
            this.dFieldEdit4.Size = new System.Drawing.Size(592, 30);
            this.dFieldEdit4.StepValue = 0D;
            this.dFieldEdit4.TabIndex = 36;
            this.dFieldEdit4.Unit = "";
            this.dFieldEdit4.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.UnitWidth = 0;
            this.dFieldEdit4.ValueType = KCSDK.ValueDataType.String;
            // 
            // dCheckBox1
            // 
            this.dCheckBox1.AutoSize = true;
            this.dCheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox1.DataName = "UseLogFlowChartRunTime";
            this.dCheckBox1.DataSource = this.SetDS;
            this.dCheckBox1.DefaultValue = false;
            this.dCheckBox1.IsModified = false;
            this.dCheckBox1.Location = new System.Drawing.Point(476, 117);
            this.dCheckBox1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox1.Name = "dCheckBox1";
            this.dCheckBox1.NoChangeInAuto = false;
            this.dCheckBox1.Size = new System.Drawing.Size(267, 30);
            this.dCheckBox1.TabIndex = 37;
            this.dCheckBox1.Text = "Record FlowChart Time";
            this.dCheckBox1.UseVisualStyleBackColor = true;
            // 
            // dCheckBox5
            // 
            this.dCheckBox5.AutoSize = true;
            this.dCheckBox5.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox5.DataName = "CheckChecksum";
            this.dCheckBox5.DataSource = this.SetDS;
            this.dCheckBox5.DefaultValue = false;
            this.dCheckBox5.IsModified = false;
            this.dCheckBox5.Location = new System.Drawing.Point(22, 147);
            this.dCheckBox5.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox5.Name = "dCheckBox5";
            this.dCheckBox5.NoChangeInAuto = false;
            this.dCheckBox5.Size = new System.Drawing.Size(203, 30);
            this.dCheckBox5.TabIndex = 35;
            this.dCheckBox5.Text = "Check Checksum";
            this.dCheckBox5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(2, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 56);
            this.label14.TabIndex = 77;
            this.label14.Text = "WOIA(Aligner OCR)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WOI_AB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 736);
            this.Name = "WOI_AB";
            this.Text = "7";
            this.tabMain.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.tpFlow.ResumeLayout(false);
            this.tpSuperSetting.ResumeLayout(false);
            this.tpSuperSetting.PerformLayout();
            this.TabFlow.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpAuto.ResumeLayout(false);
            this.tpCheck.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OCR_Read)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private ProVLib.InBit ib_Ocr_Out;
        private ProVLib.InBit ib_Ocr_Back;
        private ProVLib.OutBit ob_Ocr_Out;
        private System.Windows.Forms.Button btn_Table_SW;
        private System.Windows.Forms.GroupBox groupBox3;
        private KCSDK.DFieldEdit dFieldEdit2;
        private ProVLib.FlowChart FC_Home_Done;
        private ProVLib.FlowChart FC_Home_DoOcrConnect;
        private ProVLib.FlowChart FC_Home_OcrCyOff;
        private ProVLib.FlowChart FC_Home_WaitCmd;
        private ProVLib.FlowChart FC_HOME_START;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private KCSDK.DFieldEdit dFieldEdit31;
        private KCSDK.DFieldEdit dFieldEdit1;
        private ProVLib.FlowChart FC_AUTO_TRIGGER_START;
        private ProVLib.FlowChart FC_Auto_Trigger_Done;
        private ProVLib.FlowChart FC_Auto_Trigger_Trigger;
        private ProVLib.FlowChart FC_Auto_Trigger_WaitCmd;
        private ProVLib.FlowChart flowChart4;
        private ProVLib.FlowChart flowChart7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ORC_Connect;
        private System.Windows.Forms.Button btn_ORC_Disconnect;
        private System.Windows.Forms.Button btn_ORC_Read;
        private System.Windows.Forms.Label lb_WaferID;
        private ProVLib.FlowChart flowChart5;
        private ProVLib.FlowChart FC_Auto_OcrConnect_WaitCmd;
        private ProVLib.FlowChart FC_Auto_OcrConnect_Connect;
        private ProVLib.FlowChart FC_Auto_OcrConnect_Done;
        private ProVLib.FlowChart FC_Auto_Trigger_WaitCmd0;
        private ProVLib.FlowChart FC_AUTO_OCRCONNECT_START;
        private ProVLib.FlowChart FC_Home_OcrConnectDone;
        private ProVLib.FlowChart flowChart1;
        private ProVLib.FlowChart FC_AUTO_InchSwitch_WaitCmd;
        private ProVLib.FlowChart FC_AUTO_InchSwitch_CyliderAction;
        private ProVLib.FlowChart FC_AUTO_InchSwitch_Done;
        private ProVLib.FlowChart flowChart8;
        private ProVLib.FlowChart FC_AUTO_INCH_SWITCH_START;
        private System.Windows.Forms.Label label1;
        private KCSDK.DCheckBox dCheckBox2;
        private KCSDK.DCheckBox dCheckBox3;
        private ProVLib.FlowChart FC_Home_InchSwitchDone;
        private ProVLib.FlowChart FC_Home_DoInchSwitch;
        private KCSDK.DFieldEdit dFieldEdit3;
        private System.Windows.Forms.Button btn_OpenTeachingSoftware;
        private ProVLib.FlowChart FC_Auto_Trigger_Connect;
        private ProVLib.FlowChart FC_Auto_Trigger_ReadIDFailResult;
        private ProVLib.FlowChart FC_Auto_Trigger_ManualInputIDResult;
        private System.Windows.Forms.PictureBox pbx_OCR_Read;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ReadTime;
        private System.Windows.Forms.Label lb_OcrResult;
        private KCSDK.DCheckBox dCheckBox4;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_Connect;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_Trigger;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_Done;
        private ProVLib.FlowChart flowChart6;
        private ProVLib.FlowChart flowChart9;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_WaitCommand;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_START;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_ManualInputIDResult;
        private ProVLib.FlowChart FC_Auto_TeachAngleMode_ReadIDFailResult;
        private KCSDK.DFieldEdit dFieldEdit4;
        private KCSDK.DCheckBox dCheckBox1;
        private KCSDK.DCheckBox dCheckBox5;
        private System.Windows.Forms.Label label14;



    }
}