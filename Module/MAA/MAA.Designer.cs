namespace MAA
{
    partial class MAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAA));
            ProVLib.MotorParam motorParam1 = new ProVLib.MotorParam();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SafeDoor8 = new ProVLib.InBit();
            this.SafeDoor7 = new ProVLib.InBit();
            this.SafeDoor6 = new ProVLib.InBit();
            this.SafeDoor5 = new ProVLib.InBit();
            this.SafeDoor4 = new ProVLib.InBit();
            this.SafeDoor3 = new ProVLib.InBit();
            this.SafeDoor2 = new ProVLib.InBit();
            this.SafeDoor1 = new ProVLib.InBit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AirSensor = new ProVLib.InBit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Music4 = new ProVLib.OutBit();
            this.Music3 = new ProVLib.OutBit();
            this.Music2 = new ProVLib.OutBit();
            this.Music1 = new ProVLib.OutBit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlueLight = new ProVLib.OutBit();
            this.RedLight = new ProVLib.OutBit();
            this.YellowLight = new ProVLib.OutBit();
            this.GreenLight = new ProVLib.OutBit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OB_AlarmResetButton = new ProVLib.OutBit();
            this.OB_StopButton = new ProVLib.OutBit();
            this.OB_StartButton = new ProVLib.OutBit();
            this.IB_StartButton = new ProVLib.InBit();
            this.IB_StopButton = new ProVLib.InBit();
            this.IB_AlarmResetButton = new ProVLib.InBit();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EMGA4 = new ProVLib.InBit();
            this.EMGA3 = new ProVLib.InBit();
            this.EMGA2 = new ProVLib.InBit();
            this.EMGA1 = new ProVLib.InBit();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.motor1 = new ProVLib.Motor();
            this.ib_Safety_Gate = new ProVLib.InBit();
            this.ib_KeySwitch = new ProVLib.InBit();
            this.tabMain.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tpFlow.SuspendLayout();
            this.TabFlow.SuspendLayout();
            this.tpCheck.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(1028, 651);
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.ib_KeySwitch);
            this.tpControl.Controls.Add(this.ib_Safety_Gate);
            this.tpControl.Controls.Add(this.groupBox7);
            this.tpControl.Controls.Add(this.groupBox6);
            this.tpControl.Controls.Add(this.groupBox5);
            this.tpControl.Controls.Add(this.groupBox4);
            this.tpControl.Controls.Add(this.groupBox3);
            this.tpControl.Controls.Add(this.groupBox2);
            this.tpControl.Controls.Add(this.groupBox1);
            this.tpControl.Size = new System.Drawing.Size(1020, 583);
            // 
            // tpSuperSetting
            // 
            this.tpSuperSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SafeDoor8);
            this.groupBox5.Controls.Add(this.SafeDoor7);
            this.groupBox5.Controls.Add(this.SafeDoor6);
            this.groupBox5.Controls.Add(this.SafeDoor5);
            this.groupBox5.Controls.Add(this.SafeDoor4);
            this.groupBox5.Controls.Add(this.SafeDoor3);
            this.groupBox5.Controls.Add(this.SafeDoor2);
            this.groupBox5.Controls.Add(this.SafeDoor1);
            this.groupBox5.Location = new System.Drawing.Point(469, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 301);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "安全門";
            // 
            // SafeDoor8
            // 
            this.SafeDoor8.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor8.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor8.DesignTimeParent = null;
            this.SafeDoor8.Enabled = false;
            this.SafeDoor8.ErrID = 0;
            this.SafeDoor8.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor8.InAlarm = false;
            this.SafeDoor8.IOPort = "0106";
            this.SafeDoor8.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor8.Location = new System.Drawing.Point(6, 253);
            this.SafeDoor8.LockUI = false;
            this.SafeDoor8.Message = null;
            this.SafeDoor8.MsgID = 0;
            this.SafeDoor8.Name = "SafeDoor8";
            this.SafeDoor8.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor8.Running = false;
            this.SafeDoor8.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor8.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor8.Simu_OutPort1 = null;
            this.SafeDoor8.Simu_OutPort2 = null;
            this.SafeDoor8.Simu_RandomNum = 2;
            this.SafeDoor8.Simu_RandomTime = 100;
            this.SafeDoor8.Simu_ReflectDelayTm = 100;
            this.SafeDoor8.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor8.Simu_Reverse = false;
            this.SafeDoor8.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor8.Text = "安全門 - 8";
            // 
            // SafeDoor7
            // 
            this.SafeDoor7.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor7.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor7.DesignTimeParent = null;
            this.SafeDoor7.Enabled = false;
            this.SafeDoor7.ErrID = 0;
            this.SafeDoor7.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor7.InAlarm = false;
            this.SafeDoor7.IOPort = "0106";
            this.SafeDoor7.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor7.Location = new System.Drawing.Point(6, 221);
            this.SafeDoor7.LockUI = false;
            this.SafeDoor7.Message = null;
            this.SafeDoor7.MsgID = 0;
            this.SafeDoor7.Name = "SafeDoor7";
            this.SafeDoor7.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor7.Running = false;
            this.SafeDoor7.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor7.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor7.Simu_OutPort1 = null;
            this.SafeDoor7.Simu_OutPort2 = null;
            this.SafeDoor7.Simu_RandomNum = 2;
            this.SafeDoor7.Simu_RandomTime = 100;
            this.SafeDoor7.Simu_ReflectDelayTm = 100;
            this.SafeDoor7.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor7.Simu_Reverse = false;
            this.SafeDoor7.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor7.Text = "安全門 - 7";
            // 
            // SafeDoor6
            // 
            this.SafeDoor6.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor6.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor6.DesignTimeParent = null;
            this.SafeDoor6.Enabled = false;
            this.SafeDoor6.ErrID = 0;
            this.SafeDoor6.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor6.InAlarm = false;
            this.SafeDoor6.IOPort = "0106";
            this.SafeDoor6.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor6.Location = new System.Drawing.Point(6, 189);
            this.SafeDoor6.LockUI = false;
            this.SafeDoor6.Message = null;
            this.SafeDoor6.MsgID = 0;
            this.SafeDoor6.Name = "SafeDoor6";
            this.SafeDoor6.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor6.Running = false;
            this.SafeDoor6.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor6.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor6.Simu_OutPort1 = null;
            this.SafeDoor6.Simu_OutPort2 = null;
            this.SafeDoor6.Simu_RandomNum = 2;
            this.SafeDoor6.Simu_RandomTime = 100;
            this.SafeDoor6.Simu_ReflectDelayTm = 100;
            this.SafeDoor6.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor6.Simu_Reverse = false;
            this.SafeDoor6.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor6.Text = "安全門 - 6";
            // 
            // SafeDoor5
            // 
            this.SafeDoor5.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor5.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor5.DesignTimeParent = null;
            this.SafeDoor5.Enabled = false;
            this.SafeDoor5.ErrID = 0;
            this.SafeDoor5.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor5.InAlarm = false;
            this.SafeDoor5.IOPort = "0106";
            this.SafeDoor5.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor5.Location = new System.Drawing.Point(6, 157);
            this.SafeDoor5.LockUI = false;
            this.SafeDoor5.Message = null;
            this.SafeDoor5.MsgID = 0;
            this.SafeDoor5.Name = "SafeDoor5";
            this.SafeDoor5.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor5.Running = false;
            this.SafeDoor5.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor5.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor5.Simu_OutPort1 = null;
            this.SafeDoor5.Simu_OutPort2 = null;
            this.SafeDoor5.Simu_RandomNum = 2;
            this.SafeDoor5.Simu_RandomTime = 100;
            this.SafeDoor5.Simu_ReflectDelayTm = 100;
            this.SafeDoor5.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor5.Simu_Reverse = false;
            this.SafeDoor5.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor5.Text = "安全門 - 5";
            // 
            // SafeDoor4
            // 
            this.SafeDoor4.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor4.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor4.DesignTimeParent = null;
            this.SafeDoor4.Enabled = false;
            this.SafeDoor4.ErrID = 0;
            this.SafeDoor4.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor4.InAlarm = false;
            this.SafeDoor4.IOPort = "0106";
            this.SafeDoor4.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor4.Location = new System.Drawing.Point(6, 125);
            this.SafeDoor4.LockUI = false;
            this.SafeDoor4.Message = null;
            this.SafeDoor4.MsgID = 0;
            this.SafeDoor4.Name = "SafeDoor4";
            this.SafeDoor4.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor4.Running = false;
            this.SafeDoor4.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor4.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor4.Simu_OutPort1 = null;
            this.SafeDoor4.Simu_OutPort2 = null;
            this.SafeDoor4.Simu_RandomNum = 2;
            this.SafeDoor4.Simu_RandomTime = 100;
            this.SafeDoor4.Simu_ReflectDelayTm = 100;
            this.SafeDoor4.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor4.Simu_Reverse = false;
            this.SafeDoor4.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor4.Text = "安全門 - 4";
            // 
            // SafeDoor3
            // 
            this.SafeDoor3.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor3.DesignTimeParent = null;
            this.SafeDoor3.Enabled = false;
            this.SafeDoor3.ErrID = 0;
            this.SafeDoor3.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor3.InAlarm = false;
            this.SafeDoor3.IOPort = "0106";
            this.SafeDoor3.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor3.Location = new System.Drawing.Point(6, 93);
            this.SafeDoor3.LockUI = false;
            this.SafeDoor3.Message = null;
            this.SafeDoor3.MsgID = 0;
            this.SafeDoor3.Name = "SafeDoor3";
            this.SafeDoor3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor3.Running = false;
            this.SafeDoor3.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor3.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor3.Simu_OutPort1 = null;
            this.SafeDoor3.Simu_OutPort2 = null;
            this.SafeDoor3.Simu_RandomNum = 2;
            this.SafeDoor3.Simu_RandomTime = 100;
            this.SafeDoor3.Simu_ReflectDelayTm = 100;
            this.SafeDoor3.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor3.Simu_Reverse = false;
            this.SafeDoor3.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor3.Text = "安全門 - 3";
            // 
            // SafeDoor2
            // 
            this.SafeDoor2.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor2.DesignTimeParent = null;
            this.SafeDoor2.Enabled = false;
            this.SafeDoor2.ErrID = 0;
            this.SafeDoor2.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor2.InAlarm = false;
            this.SafeDoor2.IOPort = "0105";
            this.SafeDoor2.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor2.Location = new System.Drawing.Point(6, 61);
            this.SafeDoor2.LockUI = false;
            this.SafeDoor2.Message = null;
            this.SafeDoor2.MsgID = 0;
            this.SafeDoor2.Name = "SafeDoor2";
            this.SafeDoor2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor2.Running = false;
            this.SafeDoor2.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor2.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor2.Simu_OutPort1 = null;
            this.SafeDoor2.Simu_OutPort2 = null;
            this.SafeDoor2.Simu_RandomNum = 2;
            this.SafeDoor2.Simu_RandomTime = 100;
            this.SafeDoor2.Simu_ReflectDelayTm = 100;
            this.SafeDoor2.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor2.Simu_Reverse = false;
            this.SafeDoor2.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor2.Text = "安全門 - 2";
            // 
            // SafeDoor1
            // 
            this.SafeDoor1.BackColor = System.Drawing.Color.RoyalBlue;
            this.SafeDoor1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.SafeDoor1.DesignTimeParent = null;
            this.SafeDoor1.Enabled = false;
            this.SafeDoor1.ErrID = 0;
            this.SafeDoor1.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.SafeDoor1.InAlarm = false;
            this.SafeDoor1.IOPort = "0104";
            this.SafeDoor1.IOType = ProVLib.EIOType.IODMCNET;
            this.SafeDoor1.Location = new System.Drawing.Point(6, 29);
            this.SafeDoor1.LockUI = false;
            this.SafeDoor1.Message = null;
            this.SafeDoor1.MsgID = 0;
            this.SafeDoor1.Name = "SafeDoor1";
            this.SafeDoor1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.SafeDoor1.Running = false;
            this.SafeDoor1.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.SafeDoor1.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.SafeDoor1.Simu_OutPort1 = null;
            this.SafeDoor1.Simu_OutPort2 = null;
            this.SafeDoor1.Simu_RandomNum = 2;
            this.SafeDoor1.Simu_RandomTime = 100;
            this.SafeDoor1.Simu_ReflectDelayTm = 100;
            this.SafeDoor1.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.SafeDoor1.Simu_Reverse = false;
            this.SafeDoor1.Size = new System.Drawing.Size(200, 30);
            this.SafeDoor1.Text = "安全門 - 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AirSensor);
            this.groupBox4.Location = new System.Drawing.Point(237, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 76);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "其他";
            // 
            // AirSensor
            // 
            this.AirSensor.BackColor = System.Drawing.Color.RoyalBlue;
            this.AirSensor.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.AirSensor.DesignTimeParent = null;
            this.AirSensor.ErrID = 0;
            this.AirSensor.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.AirSensor.InAlarm = false;
            this.AirSensor.IOPort = "1707";
            this.AirSensor.IOType = ProVLib.EIOType.IOHSL;
            this.AirSensor.Location = new System.Drawing.Point(6, 26);
            this.AirSensor.LockUI = false;
            this.AirSensor.Message = null;
            this.AirSensor.MsgID = 0;
            this.AirSensor.Name = "AirSensor";
            this.AirSensor.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.AirSensor.Running = false;
            this.AirSensor.Simu_Mode = ProVLib.SIMULATION_MODE.S_CONDITION;
            this.AirSensor.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_BLINK;
            this.AirSensor.Simu_OutPort1 = "2104";
            this.AirSensor.Simu_OutPort2 = "2105";
            this.AirSensor.Simu_RandomNum = 2;
            this.AirSensor.Simu_RandomTime = 1000;
            this.AirSensor.Simu_ReflectDelayTm = 100;
            this.AirSensor.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.AirSensor.Simu_Reverse = false;
            this.AirSensor.Size = new System.Drawing.Size(200, 30);
            this.AirSensor.Text = "空壓偵測";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Music4);
            this.groupBox3.Controls.Add(this.Music3);
            this.groupBox3.Controls.Add(this.Music2);
            this.groupBox3.Controls.Add(this.Music1);
            this.groupBox3.Location = new System.Drawing.Point(237, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 164);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系統音樂";
            // 
            // Music4
            // 
            this.Music4.ActionCount = 0;
            this.Music4.BackColor = System.Drawing.Color.RoyalBlue;
            this.Music4.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.Music4.DesignTimeParent = null;
            this.Music4.Enabled = false;
            this.Music4.ErrID = 42;
            this.Music4.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.Music4.InAlarm = false;
            this.Music4.IOPort = "210F";
            this.Music4.IOType = ProVLib.EIOType.IODMCNET;
            this.Music4.IsUseActionCount = false;
            this.Music4.Location = new System.Drawing.Point(6, 123);
            this.Music4.LockUI = false;
            this.Music4.Message = "Output Set Value Error";
            this.Music4.MsgID = 0;
            this.Music4.Name = "Music4";
            this.Music4.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.Music4.RetryCount = 10;
            this.Music4.Running = false;
            this.Music4.Size = new System.Drawing.Size(200, 30);
            this.Music4.Text = "音樂 - 4";
            this.Music4.Value = false;
            // 
            // Music3
            // 
            this.Music3.ActionCount = 0;
            this.Music3.BackColor = System.Drawing.Color.RoyalBlue;
            this.Music3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.Music3.DesignTimeParent = null;
            this.Music3.Enabled = false;
            this.Music3.ErrID = 42;
            this.Music3.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.Music3.InAlarm = false;
            this.Music3.IOPort = "210E";
            this.Music3.IOType = ProVLib.EIOType.IODMCNET;
            this.Music3.IsUseActionCount = false;
            this.Music3.Location = new System.Drawing.Point(6, 91);
            this.Music3.LockUI = false;
            this.Music3.Message = "Output Set Value Error";
            this.Music3.MsgID = 0;
            this.Music3.Name = "Music3";
            this.Music3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.Music3.RetryCount = 10;
            this.Music3.Running = false;
            this.Music3.Size = new System.Drawing.Size(200, 30);
            this.Music3.Text = "音樂 - 3";
            this.Music3.Value = false;
            // 
            // Music2
            // 
            this.Music2.ActionCount = 0;
            this.Music2.BackColor = System.Drawing.Color.RoyalBlue;
            this.Music2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.Music2.DesignTimeParent = null;
            this.Music2.Enabled = false;
            this.Music2.ErrID = 42;
            this.Music2.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.Music2.InAlarm = false;
            this.Music2.IOPort = "210D";
            this.Music2.IOType = ProVLib.EIOType.IODMCNET;
            this.Music2.IsUseActionCount = false;
            this.Music2.Location = new System.Drawing.Point(6, 59);
            this.Music2.LockUI = false;
            this.Music2.Message = "Output Set Value Error";
            this.Music2.MsgID = 0;
            this.Music2.Name = "Music2";
            this.Music2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.Music2.RetryCount = 10;
            this.Music2.Running = false;
            this.Music2.Size = new System.Drawing.Size(200, 30);
            this.Music2.Text = "音樂 - 2";
            this.Music2.Value = false;
            // 
            // Music1
            // 
            this.Music1.ActionCount = 0;
            this.Music1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Music1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.Music1.DesignTimeParent = null;
            this.Music1.ErrID = 42;
            this.Music1.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.Music1.InAlarm = false;
            this.Music1.IOPort = "210C";
            this.Music1.IOType = ProVLib.EIOType.IODMCNET;
            this.Music1.IsUseActionCount = false;
            this.Music1.Location = new System.Drawing.Point(6, 27);
            this.Music1.LockUI = false;
            this.Music1.Message = "Output Set Value Error";
            this.Music1.MsgID = 0;
            this.Music1.Name = "Music1";
            this.Music1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.Music1.RetryCount = 10;
            this.Music1.Running = false;
            this.Music1.Size = new System.Drawing.Size(200, 30);
            this.Music1.Text = "音樂 - 1";
            this.Music1.Value = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlueLight);
            this.groupBox2.Controls.Add(this.RedLight);
            this.groupBox2.Controls.Add(this.YellowLight);
            this.groupBox2.Controls.Add(this.GreenLight);
            this.groupBox2.Location = new System.Drawing.Point(690, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "警示燈";
            // 
            // BlueLight
            // 
            this.BlueLight.ActionCount = 0;
            this.BlueLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.BlueLight.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.BlueLight.DesignTimeParent = null;
            this.BlueLight.ErrID = 42;
            this.BlueLight.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.BlueLight.InAlarm = false;
            this.BlueLight.IOPort = "210A";
            this.BlueLight.IOType = ProVLib.EIOType.IODMCNET;
            this.BlueLight.IsUseActionCount = false;
            this.BlueLight.Location = new System.Drawing.Point(6, 125);
            this.BlueLight.LockUI = false;
            this.BlueLight.Message = "Output Set Value Error";
            this.BlueLight.MsgID = 0;
            this.BlueLight.Name = "BlueLight";
            this.BlueLight.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.BlueLight.RetryCount = 10;
            this.BlueLight.Running = false;
            this.BlueLight.Size = new System.Drawing.Size(200, 30);
            this.BlueLight.Text = "藍色訊號燈";
            this.BlueLight.Value = false;
            // 
            // RedLight
            // 
            this.RedLight.ActionCount = 0;
            this.RedLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.RedLight.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.RedLight.DesignTimeParent = null;
            this.RedLight.ErrID = 42;
            this.RedLight.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.RedLight.InAlarm = false;
            this.RedLight.IOPort = "210A";
            this.RedLight.IOType = ProVLib.EIOType.IODMCNET;
            this.RedLight.IsUseActionCount = false;
            this.RedLight.Location = new System.Drawing.Point(6, 93);
            this.RedLight.LockUI = false;
            this.RedLight.Message = "Output Set Value Error";
            this.RedLight.MsgID = 0;
            this.RedLight.Name = "RedLight";
            this.RedLight.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.RedLight.RetryCount = 10;
            this.RedLight.Running = false;
            this.RedLight.Size = new System.Drawing.Size(200, 30);
            this.RedLight.Text = "紅色訊號燈";
            this.RedLight.Value = false;
            // 
            // YellowLight
            // 
            this.YellowLight.ActionCount = 0;
            this.YellowLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.YellowLight.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.YellowLight.DesignTimeParent = null;
            this.YellowLight.ErrID = 42;
            this.YellowLight.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.YellowLight.InAlarm = false;
            this.YellowLight.IOPort = "2109";
            this.YellowLight.IOType = ProVLib.EIOType.IODMCNET;
            this.YellowLight.IsUseActionCount = false;
            this.YellowLight.Location = new System.Drawing.Point(6, 61);
            this.YellowLight.LockUI = false;
            this.YellowLight.Message = "Output Set Value Error";
            this.YellowLight.MsgID = 0;
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.YellowLight.RetryCount = 10;
            this.YellowLight.Running = false;
            this.YellowLight.Size = new System.Drawing.Size(200, 30);
            this.YellowLight.Text = "黃色訊號燈";
            this.YellowLight.Value = false;
            // 
            // GreenLight
            // 
            this.GreenLight.ActionCount = 0;
            this.GreenLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.GreenLight.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.GreenLight.DesignTimeParent = null;
            this.GreenLight.ErrID = 42;
            this.GreenLight.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.GreenLight.InAlarm = false;
            this.GreenLight.IOPort = "2108";
            this.GreenLight.IOType = ProVLib.EIOType.IODMCNET;
            this.GreenLight.IsUseActionCount = false;
            this.GreenLight.Location = new System.Drawing.Point(6, 29);
            this.GreenLight.LockUI = false;
            this.GreenLight.Message = "Output Set Value Error";
            this.GreenLight.MsgID = 0;
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.GreenLight.RetryCount = 10;
            this.GreenLight.Running = false;
            this.GreenLight.Size = new System.Drawing.Size(200, 30);
            this.GreenLight.Text = "綠色訊號燈";
            this.GreenLight.Value = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OB_AlarmResetButton);
            this.groupBox1.Controls.Add(this.OB_StopButton);
            this.groupBox1.Controls.Add(this.OB_StartButton);
            this.groupBox1.Controls.Add(this.IB_StartButton);
            this.groupBox1.Controls.Add(this.IB_StopButton);
            this.groupBox1.Controls.Add(this.IB_AlarmResetButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "機台按鈕";
            // 
            // OB_AlarmResetButton
            // 
            this.OB_AlarmResetButton.ActionCount = 0;
            this.OB_AlarmResetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_AlarmResetButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.OB_AlarmResetButton.DesignTimeParent = null;
            this.OB_AlarmResetButton.ErrID = 42;
            this.OB_AlarmResetButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_AlarmResetButton.InAlarm = false;
            this.OB_AlarmResetButton.IOPort = "2102";
            this.OB_AlarmResetButton.IOType = ProVLib.EIOType.IODMCNET;
            this.OB_AlarmResetButton.IsUseActionCount = false;
            this.OB_AlarmResetButton.Location = new System.Drawing.Point(6, 93);
            this.OB_AlarmResetButton.LockUI = false;
            this.OB_AlarmResetButton.Message = "Output Set Value Error";
            this.OB_AlarmResetButton.MsgID = 0;
            this.OB_AlarmResetButton.Name = "OB_AlarmResetButton";
            this.OB_AlarmResetButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_AlarmResetButton.RetryCount = 10;
            this.OB_AlarmResetButton.Running = false;
            this.OB_AlarmResetButton.Size = new System.Drawing.Size(200, 30);
            this.OB_AlarmResetButton.Text = "Alarm Reset";
            this.OB_AlarmResetButton.Value = false;
            // 
            // OB_StopButton
            // 
            this.OB_StopButton.ActionCount = 0;
            this.OB_StopButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_StopButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.OB_StopButton.DesignTimeParent = null;
            this.OB_StopButton.ErrID = 42;
            this.OB_StopButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_StopButton.InAlarm = false;
            this.OB_StopButton.IOPort = "2101";
            this.OB_StopButton.IOType = ProVLib.EIOType.IODMCNET;
            this.OB_StopButton.IsUseActionCount = false;
            this.OB_StopButton.Location = new System.Drawing.Point(6, 61);
            this.OB_StopButton.LockUI = false;
            this.OB_StopButton.Message = "Output Set Value Error";
            this.OB_StopButton.MsgID = 0;
            this.OB_StopButton.Name = "OB_StopButton";
            this.OB_StopButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_StopButton.RetryCount = 10;
            this.OB_StopButton.Running = false;
            this.OB_StopButton.Size = new System.Drawing.Size(200, 30);
            this.OB_StopButton.Text = "停止";
            this.OB_StopButton.Value = false;
            // 
            // OB_StartButton
            // 
            this.OB_StartButton.ActionCount = 0;
            this.OB_StartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_StartButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.OB_StartButton.DesignTimeParent = null;
            this.OB_StartButton.ErrID = 42;
            this.OB_StartButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_StartButton.InAlarm = false;
            this.OB_StartButton.IOPort = "2100";
            this.OB_StartButton.IOType = ProVLib.EIOType.IODMCNET;
            this.OB_StartButton.IsUseActionCount = false;
            this.OB_StartButton.Location = new System.Drawing.Point(6, 29);
            this.OB_StartButton.LockUI = false;
            this.OB_StartButton.Message = "Output Set Value Error";
            this.OB_StartButton.MsgID = 0;
            this.OB_StartButton.Name = "OB_StartButton";
            this.OB_StartButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_StartButton.RetryCount = 10;
            this.OB_StartButton.Running = true;
            this.OB_StartButton.Size = new System.Drawing.Size(200, 30);
            this.OB_StartButton.Text = "啟動";
            this.OB_StartButton.Value = false;
            // 
            // IB_StartButton
            // 
            this.IB_StartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_StartButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.IB_StartButton.DesignTimeParent = null;
            this.IB_StartButton.ErrID = 0;
            this.IB_StartButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_StartButton.InAlarm = false;
            this.IB_StartButton.IOPort = "0100";
            this.IB_StartButton.IOType = ProVLib.EIOType.IODMCNET;
            this.IB_StartButton.Location = new System.Drawing.Point(6, 131);
            this.IB_StartButton.LockUI = false;
            this.IB_StartButton.Message = null;
            this.IB_StartButton.MsgID = 0;
            this.IB_StartButton.Name = "IB_StartButton";
            this.IB_StartButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_StartButton.Running = false;
            this.IB_StartButton.Simu_Mode = ProVLib.SIMULATION_MODE.S_CONDITION;
            this.IB_StartButton.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_BLINK;
            this.IB_StartButton.Simu_OutPort1 = "2100";
            this.IB_StartButton.Simu_OutPort2 = null;
            this.IB_StartButton.Simu_RandomNum = 0;
            this.IB_StartButton.Simu_RandomTime = 100;
            this.IB_StartButton.Simu_ReflectDelayTm = 10;
            this.IB_StartButton.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_StartButton.Simu_Reverse = false;
            this.IB_StartButton.Size = new System.Drawing.Size(200, 30);
            this.IB_StartButton.Text = "啟動鈕偵測";
            // 
            // IB_StopButton
            // 
            this.IB_StopButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_StopButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.IB_StopButton.DesignTimeParent = null;
            this.IB_StopButton.ErrID = 0;
            this.IB_StopButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_StopButton.InAlarm = false;
            this.IB_StopButton.IOPort = "0101";
            this.IB_StopButton.IOType = ProVLib.EIOType.IODMCNET;
            this.IB_StopButton.Location = new System.Drawing.Point(6, 163);
            this.IB_StopButton.LockUI = false;
            this.IB_StopButton.Message = null;
            this.IB_StopButton.MsgID = 0;
            this.IB_StopButton.Name = "IB_StopButton";
            this.IB_StopButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_StopButton.Running = false;
            this.IB_StopButton.Simu_Mode = ProVLib.SIMULATION_MODE.S_CONDITION;
            this.IB_StopButton.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_BLINK;
            this.IB_StopButton.Simu_OutPort1 = "2101";
            this.IB_StopButton.Simu_OutPort2 = null;
            this.IB_StopButton.Simu_RandomNum = 0;
            this.IB_StopButton.Simu_RandomTime = 100;
            this.IB_StopButton.Simu_ReflectDelayTm = 10;
            this.IB_StopButton.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_StopButton.Simu_Reverse = false;
            this.IB_StopButton.Size = new System.Drawing.Size(200, 30);
            this.IB_StopButton.Text = "停止鈕偵測";
            // 
            // IB_AlarmResetButton
            // 
            this.IB_AlarmResetButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_AlarmResetButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.IB_AlarmResetButton.DesignTimeParent = null;
            this.IB_AlarmResetButton.ErrID = 0;
            this.IB_AlarmResetButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_AlarmResetButton.InAlarm = false;
            this.IB_AlarmResetButton.IOPort = "0102";
            this.IB_AlarmResetButton.IOType = ProVLib.EIOType.IODMCNET;
            this.IB_AlarmResetButton.Location = new System.Drawing.Point(6, 195);
            this.IB_AlarmResetButton.LockUI = false;
            this.IB_AlarmResetButton.Message = null;
            this.IB_AlarmResetButton.MsgID = 0;
            this.IB_AlarmResetButton.Name = "IB_AlarmResetButton";
            this.IB_AlarmResetButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_AlarmResetButton.Running = false;
            this.IB_AlarmResetButton.Simu_Mode = ProVLib.SIMULATION_MODE.S_CONDITION;
            this.IB_AlarmResetButton.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_BLINK;
            this.IB_AlarmResetButton.Simu_OutPort1 = "2102";
            this.IB_AlarmResetButton.Simu_OutPort2 = null;
            this.IB_AlarmResetButton.Simu_RandomNum = 0;
            this.IB_AlarmResetButton.Simu_RandomTime = 100;
            this.IB_AlarmResetButton.Simu_ReflectDelayTm = 10;
            this.IB_AlarmResetButton.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_AlarmResetButton.Simu_Reverse = false;
            this.IB_AlarmResetButton.Size = new System.Drawing.Size(200, 30);
            this.IB_AlarmResetButton.Text = "AlarmReset鈕偵測";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EMGA4);
            this.groupBox6.Controls.Add(this.EMGA3);
            this.groupBox6.Controls.Add(this.EMGA2);
            this.groupBox6.Controls.Add(this.EMGA1);
            this.groupBox6.Location = new System.Drawing.Point(15, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 171);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "緊急停止";
            // 
            // EMGA4
            // 
            this.EMGA4.BackColor = System.Drawing.Color.RoyalBlue;
            this.EMGA4.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.EMGA4.DesignTimeParent = null;
            this.EMGA4.Enabled = false;
            this.EMGA4.ErrID = 0;
            this.EMGA4.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.EMGA4.InAlarm = false;
            this.EMGA4.IOPort = "0105";
            this.EMGA4.IOType = ProVLib.EIOType.IODMCNET;
            this.EMGA4.Location = new System.Drawing.Point(6, 125);
            this.EMGA4.LockUI = false;
            this.EMGA4.Message = null;
            this.EMGA4.MsgID = 0;
            this.EMGA4.Name = "EMGA4";
            this.EMGA4.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.EMGA4.Running = false;
            this.EMGA4.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.EMGA4.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.EMGA4.Simu_OutPort1 = null;
            this.EMGA4.Simu_OutPort2 = null;
            this.EMGA4.Simu_RandomNum = 2;
            this.EMGA4.Simu_RandomTime = 100;
            this.EMGA4.Simu_ReflectDelayTm = 100;
            this.EMGA4.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.EMGA4.Simu_Reverse = false;
            this.EMGA4.Size = new System.Drawing.Size(200, 30);
            this.EMGA4.Text = "緊急停止-4(B)";
            // 
            // EMGA3
            // 
            this.EMGA3.BackColor = System.Drawing.Color.RoyalBlue;
            this.EMGA3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.EMGA3.DesignTimeParent = null;
            this.EMGA3.Enabled = false;
            this.EMGA3.ErrID = 0;
            this.EMGA3.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.EMGA3.InAlarm = false;
            this.EMGA3.IOPort = "0105";
            this.EMGA3.IOType = ProVLib.EIOType.IODMCNET;
            this.EMGA3.Location = new System.Drawing.Point(6, 93);
            this.EMGA3.LockUI = false;
            this.EMGA3.Message = null;
            this.EMGA3.MsgID = 0;
            this.EMGA3.Name = "EMGA3";
            this.EMGA3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.EMGA3.Running = false;
            this.EMGA3.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.EMGA3.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.EMGA3.Simu_OutPort1 = null;
            this.EMGA3.Simu_OutPort2 = null;
            this.EMGA3.Simu_RandomNum = 2;
            this.EMGA3.Simu_RandomTime = 100;
            this.EMGA3.Simu_ReflectDelayTm = 100;
            this.EMGA3.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.EMGA3.Simu_Reverse = false;
            this.EMGA3.Size = new System.Drawing.Size(200, 30);
            this.EMGA3.Text = "緊急停止-3(B)";
            // 
            // EMGA2
            // 
            this.EMGA2.BackColor = System.Drawing.Color.RoyalBlue;
            this.EMGA2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.EMGA2.DesignTimeParent = null;
            this.EMGA2.Enabled = false;
            this.EMGA2.ErrID = 0;
            this.EMGA2.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.EMGA2.InAlarm = false;
            this.EMGA2.IOPort = "0105";
            this.EMGA2.IOType = ProVLib.EIOType.IODMCNET;
            this.EMGA2.Location = new System.Drawing.Point(6, 61);
            this.EMGA2.LockUI = false;
            this.EMGA2.Message = null;
            this.EMGA2.MsgID = 0;
            this.EMGA2.Name = "EMGA2";
            this.EMGA2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.EMGA2.Running = false;
            this.EMGA2.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.EMGA2.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.EMGA2.Simu_OutPort1 = null;
            this.EMGA2.Simu_OutPort2 = null;
            this.EMGA2.Simu_RandomNum = 2;
            this.EMGA2.Simu_RandomTime = 100;
            this.EMGA2.Simu_ReflectDelayTm = 100;
            this.EMGA2.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.EMGA2.Simu_Reverse = false;
            this.EMGA2.Size = new System.Drawing.Size(200, 30);
            this.EMGA2.Text = "緊急停止-2(B)";
            // 
            // EMGA1
            // 
            this.EMGA1.BackColor = System.Drawing.Color.RoyalBlue;
            this.EMGA1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.EMGA1.DesignTimeParent = null;
            this.EMGA1.ErrID = 0;
            this.EMGA1.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.EMGA1.InAlarm = false;
            this.EMGA1.IOPort = "0103";
            this.EMGA1.IOType = ProVLib.EIOType.IODMCNET;
            this.EMGA1.Location = new System.Drawing.Point(6, 29);
            this.EMGA1.LockUI = false;
            this.EMGA1.Message = null;
            this.EMGA1.MsgID = 0;
            this.EMGA1.Name = "EMGA1";
            this.EMGA1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.EMGA1.Running = false;
            this.EMGA1.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.EMGA1.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.EMGA1.Simu_OutPort1 = null;
            this.EMGA1.Simu_OutPort2 = null;
            this.EMGA1.Simu_RandomNum = 0;
            this.EMGA1.Simu_RandomTime = 100;
            this.EMGA1.Simu_ReflectDelayTm = 100;
            this.EMGA1.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.EMGA1.Simu_Reverse = true;
            this.EMGA1.Size = new System.Drawing.Size(200, 30);
            this.EMGA1.Text = "緊急停止-1(B)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.motor1);
            this.groupBox7.Location = new System.Drawing.Point(696, 213);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(217, 164);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "警示燈";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // motor1
            // 
            this.motor1.Acceleration = 300000;
            this.motor1.AcceptDiffRange = ((uint)(0u));
            this.motor1.AddressID = 0;
            this.motor1.AlarmPolarity = ProVLib.ALMPOLARITY.ACTIVELOW;
            this.motor1.AxisDir = ProVLib.AxisDIRType.AXIS_X;
            this.motor1.AxisIndex = 0;
            this.motor1.BackColor = System.Drawing.Color.RoyalBlue;
            this.motor1.BasePulseCount = 0;
            this.motor1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.motor1.CMPSRC = ProVLib.ECMPSRC.CMPSRC_None;
            this.motor1.D2 = ((byte)(0));
            this.motor1.D4 = ((byte)(0));
            this.motor1.Deceleration = 300000;
            this.motor1.DelayTime = 0D;
            this.motor1.DesignTimeParent = null;
            this.motor1.Direction = true;
            this.motor1.DownZ1 = 0;
            this.motor1.DownZ2 = 0;
            this.motor1.DownZ3 = 0;
            this.motor1.EncGearRatio = 1D;
            this.motor1.EndX = 0;
            this.motor1.ErrID = 0;
            this.motor1.ExtraMotor = null;
            this.motor1.Function = ProVLib.ExtraFunction.None;
            this.motor1.GearRatio = 1D;
            this.motor1.GroupNo = ((short)(0));
            this.motor1.HomeBeforeGoto = false;
            this.motor1.HomeDirection = true;
            this.motor1.HomeMode = ProVLib.HOMEMODE.LIMITSNR;
            this.motor1.HomeOK = false;
            this.motor1.HomePos = 100;
            this.motor1.InAlarm = false;
            this.motor1.InitialPosition = 0;
            this.motor1.InitSpeed = 100;
            this.motor1.InPosOn = false;
            this.motor1.InposRange = 50;
            this.motor1.IOPort = "000";
            this.motor1.IsAlarmReseted = false;
            this.motor1.IsELSensorB = true;
            this.motor1.IsSensorB = true;
            this.motor1.IsUseMileage = false;
            this.motor1.IsUseSoftLimit = false;
            this.motor1.JogHighSpeed = 30000;
            this.motor1.JogLowSpeed = 1000;
            this.motor1.LimitX = 0;
            this.motor1.LimitZ = 0;
            this.motor1.LineID = ((uint)(0u));
            this.motor1.Location = new System.Drawing.Point(11, 29);
            this.motor1.LockUI = false;
            this.motor1.Message = null;
            this.motor1.Mileage = 0F;
            this.motor1.MNETSpeed = ProVLib.EMNETSPEED.MNET10M;
            motorParam1.Acceleration = 300000;
            motorParam1.AddressID = 0;
            motorParam1.AlarmPolarity = ProVLib.ALMPOLARITY.ACTIVELOW;
            motorParam1.AxisDIR = ProVLib.AxisDIRType.AXIS_X;
            motorParam1.AxisIndex = 0;
            motorParam1.BasePulseCount = 0;
            motorParam1.CMPSRC = ProVLib.ECMPSRC.CMPSRC_None;
            motorParam1.CommandPos = 0;
            motorParam1.Deceleration = 300000;
            motorParam1.DelayT = 0D;
            motorParam1.Direction = true;
            motorParam1.DownZ1 = 0;
            motorParam1.DownZ2 = 0;
            motorParam1.DownZ3 = 0;
            motorParam1.EncGearRatio = 1D;
            motorParam1.EncoderPos = 0;
            motorParam1.EndX = 0;
            motorParam1.ExtraMotor = null;
            motorParam1.Function = ProVLib.ExtraFunction.None;
            motorParam1.GearRatio = 1D;
            motorParam1.GroupNo = ((short)(0));
            motorParam1.HomeBeforeGoto = false;
            motorParam1.HomeDirection = true;
            motorParam1.HomeException = ProVLib.HOMEEXP.Default;
            motorParam1.HomeMode = ProVLib.HOMEMODE.LIMITSNR;
            motorParam1.HomePos = 100;
            motorParam1.IDZ = ((short)(0));
            motorParam1.InitSpeed = 100;
            motorParam1.InPosOn = false;
            motorParam1.InposRange = 50;
            motorParam1.IOPort = "000";
            motorParam1.IsAlarmReseted = false;
            motorParam1.IsBusy = false;
            motorParam1.IsELSensorB = true;
            motorParam1.IsSensorB = true;
            motorParam1.IsUseSoftLimit = false;
            motorParam1.JogHighSpeed = 30000;
            motorParam1.JogLowSpeed = 1000;
            motorParam1.LimitX = 0;
            motorParam1.LimitZ = 0;
            motorParam1.MNETSpeed = ProVLib.EMNETSPEED.MNET10M;
            motorParam1.MotionCard = ProVLib.EMOTIONCARD.MCMNET;
            motorParam1.MotorType = ProVLib.MOTORTYPE.NORMAL;
            motorParam1.ObjType = 0;
            motorParam1.Owner = null;
            motorParam1.PitchCOMEnable = false;
            motorParam1.PulseCtrlMode = ProVLib.EPULSEMODE.CWCCW_2;
            motorParam1.ScanByKernal = false;
            motorParam1.SCurveAccRatio = 50;
            motorParam1.SCurveDecRatio = 50;
            motorParam1.SerialPortName = "COM1";
            motorParam1.ServoAlarmOn = false;
            motorParam1.ServoOnPolarity = ProVLib.SVONPOLARITY.ACTIVELOW;
            motorParam1.SlaveIOPort = null;
            motorParam1.SoftLimitN = -9999999;
            motorParam1.SoftLimitP = 9999999;
            motorParam1.Speed = 50000;
            motorParam1.SpeedPattern = ProVLib.MOVINGPATTERN.T_Curve;
            motorParam1.StopDeceleration = 100000000;
            motorParam1.TRGSRC = ProVLib.ETRIGGERSRC.TRGENC;
            motorParam1.TriggerChannel = ProVLib.ETriggerChannel.CH_1;
            motorParam1.TriggerPolarity = ProVLib.ETriggerLogic.ActiveLow;
            motorParam1.UpZ = 0;
            motorParam1.ZPhaseLogic = ProVLib.ZPHASELOGIC.FALLINGEDGE;
            this.motor1.MotorParameter = motorParam1;
            this.motor1.MoverSize = ((uint)(0u));
            this.motor1.MsgID = 0;
            this.motor1.Name = "motor1";
            this.motor1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.motor1.PitchCOMEnable = false;
            this.motor1.PriorityHigh = ((uint)(0u));
            this.motor1.PriorityLow = ((uint)(0u));
            this.motor1.PulseCtrlMode = ProVLib.EPULSEMODE.CWCCW_2;
            this.motor1.RelCurrentPos = 0;
            this.motor1.RelTargetPos = 0;
            this.motor1.Running = false;
            this.motor1.SafeDistance = ((uint)(0u));
            this.motor1.ScanByKernal = false;
            this.motor1.SCurveAccRatio = 50;
            this.motor1.SCurveDecRatio = 50;
            this.motor1.SerialPortName = "COM1";
            this.motor1.ServoAlarmOn = false;
            this.motor1.ServoOnPolarity = ProVLib.SVONPOLARITY.ACTIVELOW;
            this.motor1.Size = new System.Drawing.Size(200, 30);
            this.motor1.SlaveIOPort = null;
            this.motor1.SoftLimitN = -9999999;
            this.motor1.SoftLimitP = 9999999;
            this.motor1.Speed = 50000;
            this.motor1.Text = "motor1";
            this.motor1.TRGSRC = ProVLib.ETRIGGERSRC.TRGENC;
            this.motor1.TriggerChannel = ProVLib.ETriggerChannel.CH_1;
            this.motor1.TriggerPolarity = ProVLib.ETriggerLogic.ActiveLow;
            this.motor1.UpZ = 0;
            this.motor1.ZPhaseLogic = ProVLib.ZPHASELOGIC.FALLINGEDGE;
            // 
            // ib_Safety_Gate
            // 
            this.ib_Safety_Gate.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Safety_Gate.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.ib_Safety_Gate.DesignTimeParent = null;
            this.ib_Safety_Gate.ErrID = 0;
            this.ib_Safety_Gate.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Safety_Gate.InAlarm = false;
            this.ib_Safety_Gate.IOPort = "010A";
            this.ib_Safety_Gate.IOType = ProVLib.EIOType.IODMCNET;
            this.ib_Safety_Gate.Location = new System.Drawing.Point(243, 283);
            this.ib_Safety_Gate.LockUI = false;
            this.ib_Safety_Gate.Message = null;
            this.ib_Safety_Gate.MsgID = 0;
            this.ib_Safety_Gate.Name = "ib_Safety_Gate";
            this.ib_Safety_Gate.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Safety_Gate.Running = false;
            this.ib_Safety_Gate.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Safety_Gate.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Safety_Gate.Simu_OutPort1 = null;
            this.ib_Safety_Gate.Simu_OutPort2 = null;
            this.ib_Safety_Gate.Simu_RandomNum = 2;
            this.ib_Safety_Gate.Simu_RandomTime = 100;
            this.ib_Safety_Gate.Simu_ReflectDelayTm = 100;
            this.ib_Safety_Gate.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Safety_Gate.Simu_Reverse = false;
            this.ib_Safety_Gate.Size = new System.Drawing.Size(200, 30);
            this.ib_Safety_Gate.Text = "Safety Gate";
            // 
            // ib_KeySwitch
            // 
            this.ib_KeySwitch.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_KeySwitch.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.ib_KeySwitch.DesignTimeParent = null;
            this.ib_KeySwitch.ErrID = 0;
            this.ib_KeySwitch.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_KeySwitch.InAlarm = false;
            this.ib_KeySwitch.IOPort = "0105";
            this.ib_KeySwitch.IOType = ProVLib.EIOType.IODMCNET;
            this.ib_KeySwitch.Location = new System.Drawing.Point(243, 315);
            this.ib_KeySwitch.LockUI = false;
            this.ib_KeySwitch.Message = null;
            this.ib_KeySwitch.MsgID = 0;
            this.ib_KeySwitch.Name = "ib_KeySwitch";
            this.ib_KeySwitch.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_KeySwitch.Running = false;
            this.ib_KeySwitch.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_KeySwitch.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_KeySwitch.Simu_OutPort1 = null;
            this.ib_KeySwitch.Simu_OutPort2 = null;
            this.ib_KeySwitch.Simu_RandomNum = 2;
            this.ib_KeySwitch.Simu_RandomTime = 100;
            this.ib_KeySwitch.Simu_ReflectDelayTm = 100;
            this.ib_KeySwitch.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_KeySwitch.Simu_Reverse = false;
            this.ib_KeySwitch.Size = new System.Drawing.Size(200, 30);
            this.ib_KeySwitch.Text = "Key Switch";
            // 
            // MAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 651);
            this.Name = "MAA";
            this.Text = "MAA";
            this.tabMain.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpFlow.ResumeLayout(false);
            this.TabFlow.ResumeLayout(false);
            this.tpCheck.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private ProVLib.InBit EMGA2;
        private ProVLib.InBit EMGA1;
        private System.Windows.Forms.GroupBox groupBox5;
        private ProVLib.InBit SafeDoor8;
        private ProVLib.InBit SafeDoor7;
        private ProVLib.InBit SafeDoor6;
        private ProVLib.InBit SafeDoor5;
        private ProVLib.InBit SafeDoor4;
        private ProVLib.InBit SafeDoor3;
        private ProVLib.InBit SafeDoor2;
        private ProVLib.InBit SafeDoor1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ProVLib.InBit AirSensor;
        private System.Windows.Forms.GroupBox groupBox3;
        public ProVLib.OutBit Music4;
        public ProVLib.OutBit Music3;
        public ProVLib.OutBit Music2;
        public ProVLib.OutBit Music1;
        private System.Windows.Forms.GroupBox groupBox2;
        public ProVLib.OutBit RedLight;
        public ProVLib.OutBit YellowLight;
        public ProVLib.OutBit GreenLight;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProVLib.OutBit OB_AlarmResetButton;
        private ProVLib.OutBit OB_StopButton;
        private ProVLib.OutBit OB_StartButton;
        private ProVLib.InBit IB_StartButton;
        private ProVLib.InBit IB_StopButton;
        private ProVLib.InBit IB_AlarmResetButton;
        private ProVLib.InBit EMGA4;
        private ProVLib.InBit EMGA3;
        public ProVLib.OutBit BlueLight;
        private System.Windows.Forms.GroupBox groupBox7;
        private ProVLib.Motor motor1;
        private System.Windows.Forms.Button button1;
        private ProVLib.InBit ib_Safety_Gate;
        private ProVLib.InBit ib_KeySwitch;
    }
}