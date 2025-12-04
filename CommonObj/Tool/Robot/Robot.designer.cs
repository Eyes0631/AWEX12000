namespace RobotControl
{
    partial class RobotControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotControl));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.ledGreen = new KCSDK.ThreeColorLight();
            this.txtCommandLabel = new System.Windows.Forms.TextBox();
            this.lst_Command = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lst_Station = new System.Windows.Forms.ListBox();
            this.nu_parameter_1 = new System.Windows.Forms.NumericUpDown();
            this.tbx_parameter_1 = new System.Windows.Forms.TextBox();
            this.nu_parameter_2 = new System.Windows.Forms.NumericUpDown();
            this.tbx_parameter_2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbx_ErrorCode = new System.Windows.Forms.TextBox();
            this.bt_Command = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.led_Status = new KCSDK.ThreeColorLight();
            this.btn_AlarmReset = new System.Windows.Forms.Button();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbx_StationName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbx_IP = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbx_Port = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbx_DataBit = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tbx_StopBit = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tbx_Parity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_StationList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbx_parameter_3 = new System.Windows.Forms.TextBox();
            this.nu_parameter_3 = new System.Windows.Forms.NumericUpDown();
            this.tbx_parameter_4 = new System.Windows.Forms.TextBox();
            this.nu_parameter_4 = new System.Windows.Forms.NumericUpDown();
            this.tbx_parameter_5 = new System.Windows.Forms.TextBox();
            this.nu_parameter_5 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_2)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flp_StationList.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_5)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 424);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(1198, 224);
            this.listBox1.TabIndex = 11;
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.BackColor = System.Drawing.Color.Black;
            this.bt_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_disconnect.ForeColor = System.Drawing.Color.Yellow;
            this.bt_disconnect.Location = new System.Drawing.Point(3, 90);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(187, 86);
            this.bt_disconnect.TabIndex = 12;
            this.bt_disconnect.Text = "Disconnect";
            this.bt_disconnect.UseVisualStyleBackColor = false;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.BackColor = System.Drawing.Color.Black;
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.ForeColor = System.Drawing.Color.Yellow;
            this.bt_connect.Location = new System.Drawing.Point(3, 3);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(187, 81);
            this.bt_connect.TabIndex = 13;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = false;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // ledGreen
            // 
            this.ledGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ledGreen.BackgroundImage")));
            this.ledGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ledGreen.Location = new System.Drawing.Point(148, 179);
            this.ledGreen.Name = "ledGreen";
            this.ledGreen.Size = new System.Drawing.Size(40, 40);
            this.ledGreen.TabIndex = 35;
            this.ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            // 
            // txtCommandLabel
            // 
            this.txtCommandLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandLabel.ForeColor = System.Drawing.Color.Lime;
            this.txtCommandLabel.Location = new System.Drawing.Point(2, 2);
            this.txtCommandLabel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommandLabel.Name = "txtCommandLabel";
            this.txtCommandLabel.ReadOnly = true;
            this.txtCommandLabel.Size = new System.Drawing.Size(213, 31);
            this.txtCommandLabel.TabIndex = 37;
            this.txtCommandLabel.Text = "Command List";
            this.txtCommandLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst_Command
            // 
            this.lst_Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Command.FormattingEnabled = true;
            this.lst_Command.ItemHeight = 25;
            this.lst_Command.Location = new System.Drawing.Point(2, 37);
            this.lst_Command.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Command.Name = "lst_Command";
            this.lst_Command.Size = new System.Drawing.Size(213, 379);
            this.lst_Command.TabIndex = 36;
            this.lst_Command.SelectedIndexChanged += new System.EventHandler(this.lst_Command_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 31);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "Station List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst_Station
            // 
            this.lst_Station.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Station.FormattingEnabled = true;
            this.lst_Station.ItemHeight = 25;
            this.lst_Station.Location = new System.Drawing.Point(2, 37);
            this.lst_Station.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Station.Name = "lst_Station";
            this.lst_Station.Size = new System.Drawing.Size(315, 377);
            this.lst_Station.TabIndex = 38;
            // 
            // nu_parameter_1
            // 
            this.nu_parameter_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_parameter_1.Location = new System.Drawing.Point(2, 102);
            this.nu_parameter_1.Margin = new System.Windows.Forms.Padding(2);
            this.nu_parameter_1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nu_parameter_1.Name = "nu_parameter_1";
            this.nu_parameter_1.Size = new System.Drawing.Size(240, 31);
            this.nu_parameter_1.TabIndex = 43;
            this.nu_parameter_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_parameter_1
            // 
            this.tbx_parameter_1.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_parameter_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameter_1.ForeColor = System.Drawing.Color.Lime;
            this.tbx_parameter_1.Location = new System.Drawing.Point(2, 72);
            this.tbx_parameter_1.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_parameter_1.Name = "tbx_parameter_1";
            this.tbx_parameter_1.ReadOnly = true;
            this.tbx_parameter_1.Size = new System.Drawing.Size(240, 26);
            this.tbx_parameter_1.TabIndex = 42;
            this.tbx_parameter_1.Text = "parameter_1";
            this.tbx_parameter_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nu_parameter_2
            // 
            this.nu_parameter_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_parameter_2.Location = new System.Drawing.Point(2, 167);
            this.nu_parameter_2.Margin = new System.Windows.Forms.Padding(2);
            this.nu_parameter_2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nu_parameter_2.Name = "nu_parameter_2";
            this.nu_parameter_2.Size = new System.Drawing.Size(240, 31);
            this.nu_parameter_2.TabIndex = 74;
            this.nu_parameter_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_parameter_2
            // 
            this.tbx_parameter_2.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_parameter_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameter_2.ForeColor = System.Drawing.Color.Lime;
            this.tbx_parameter_2.Location = new System.Drawing.Point(2, 137);
            this.tbx_parameter_2.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_parameter_2.Name = "tbx_parameter_2";
            this.tbx_parameter_2.ReadOnly = true;
            this.tbx_parameter_2.Size = new System.Drawing.Size(240, 26);
            this.tbx_parameter_2.TabIndex = 73;
            this.tbx_parameter_2.Text = "parameter_2";
            this.tbx_parameter_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(2, 261);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(188, 31);
            this.textBox4.TabIndex = 75;
            this.textBox4.Text = "Error Code";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_ErrorCode
            // 
            this.tbx_ErrorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ErrorCode.Location = new System.Drawing.Point(2, 296);
            this.tbx_ErrorCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_ErrorCode.Name = "tbx_ErrorCode";
            this.tbx_ErrorCode.ReadOnly = true;
            this.tbx_ErrorCode.Size = new System.Drawing.Size(188, 31);
            this.tbx_ErrorCode.TabIndex = 76;
            // 
            // bt_Command
            // 
            this.bt_Command.BackColor = System.Drawing.Color.Black;
            this.bt_Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Command.ForeColor = System.Drawing.Color.Yellow;
            this.bt_Command.Location = new System.Drawing.Point(2, 2);
            this.bt_Command.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Command.Name = "bt_Command";
            this.bt_Command.Size = new System.Drawing.Size(240, 66);
            this.bt_Command.TabIndex = 77;
            this.bt_Command.Text = "Command Send";
            this.bt_Command.UseVisualStyleBackColor = false;
            this.bt_Command.Click += new System.EventHandler(this.bt_Command_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(2, 221);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(144, 31);
            this.textBox3.TabIndex = 82;
            this.textBox3.Text = "Status";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(2, 181);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(144, 31);
            this.textBox2.TabIndex = 81;
            this.textBox2.Text = "Connect";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // led_Status
            // 
            this.led_Status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("led_Status.BackgroundImage")));
            this.led_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.led_Status.Location = new System.Drawing.Point(148, 219);
            this.led_Status.Name = "led_Status";
            this.led_Status.Size = new System.Drawing.Size(40, 40);
            this.led_Status.TabIndex = 80;
            this.led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            // 
            // btn_AlarmReset
            // 
            this.btn_AlarmReset.BackColor = System.Drawing.Color.Black;
            this.btn_AlarmReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlarmReset.ForeColor = System.Drawing.Color.Yellow;
            this.btn_AlarmReset.Location = new System.Drawing.Point(2, 331);
            this.btn_AlarmReset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AlarmReset.Name = "btn_AlarmReset";
            this.btn_AlarmReset.Size = new System.Drawing.Size(187, 86);
            this.btn_AlarmReset.TabIndex = 79;
            this.btn_AlarmReset.Text = "Alarm Reset";
            this.btn_AlarmReset.UseVisualStyleBackColor = false;
            this.btn_AlarmReset.Click += new System.EventHandler(this.btn_AlarmReset_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.textBox6);
            this.flowLayoutPanel8.Controls.Add(this.tbx_StationName);
            this.flowLayoutPanel8.Controls.Add(this.textBox5);
            this.flowLayoutPanel8.Controls.Add(this.tbx_IP);
            this.flowLayoutPanel8.Controls.Add(this.textBox7);
            this.flowLayoutPanel8.Controls.Add(this.tbx_Port);
            this.flowLayoutPanel8.Controls.Add(this.textBox8);
            this.flowLayoutPanel8.Controls.Add(this.tbx_DataBit);
            this.flowLayoutPanel8.Controls.Add(this.textBox10);
            this.flowLayoutPanel8.Controls.Add(this.tbx_StopBit);
            this.flowLayoutPanel8.Controls.Add(this.textBox12);
            this.flowLayoutPanel8.Controls.Add(this.tbx_Parity);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(817, 2);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(158, 437);
            this.flowLayoutPanel8.TabIndex = 78;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Lime;
            this.textBox6.Location = new System.Drawing.Point(2, 2);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(151, 31);
            this.textBox6.TabIndex = 80;
            this.textBox6.Text = "Name";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_StationName
            // 
            this.tbx_StationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_StationName.Location = new System.Drawing.Point(2, 37);
            this.tbx_StationName.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_StationName.Name = "tbx_StationName";
            this.tbx_StationName.ReadOnly = true;
            this.tbx_StationName.Size = new System.Drawing.Size(148, 31);
            this.tbx_StationName.TabIndex = 81;
            this.tbx_StationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Lime;
            this.textBox5.Location = new System.Drawing.Point(2, 72);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(151, 31);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "IP";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_IP
            // 
            this.tbx_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_IP.Location = new System.Drawing.Point(2, 107);
            this.tbx_IP.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.ReadOnly = true;
            this.tbx_IP.Size = new System.Drawing.Size(148, 31);
            this.tbx_IP.TabIndex = 77;
            this.tbx_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Lime;
            this.textBox7.Location = new System.Drawing.Point(2, 142);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(151, 31);
            this.textBox7.TabIndex = 78;
            this.textBox7.Text = "Port";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Port
            // 
            this.tbx_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Port.Location = new System.Drawing.Point(2, 177);
            this.tbx_Port.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Port.Name = "tbx_Port";
            this.tbx_Port.ReadOnly = true;
            this.tbx_Port.Size = new System.Drawing.Size(148, 31);
            this.tbx_Port.TabIndex = 79;
            this.tbx_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Lime;
            this.textBox8.Location = new System.Drawing.Point(2, 212);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(151, 31);
            this.textBox8.TabIndex = 82;
            this.textBox8.Text = "Data Bit";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_DataBit
            // 
            this.tbx_DataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_DataBit.Location = new System.Drawing.Point(2, 247);
            this.tbx_DataBit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_DataBit.Name = "tbx_DataBit";
            this.tbx_DataBit.ReadOnly = true;
            this.tbx_DataBit.Size = new System.Drawing.Size(148, 31);
            this.tbx_DataBit.TabIndex = 83;
            this.tbx_DataBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Lime;
            this.textBox10.Location = new System.Drawing.Point(2, 282);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(151, 31);
            this.textBox10.TabIndex = 84;
            this.textBox10.Text = "Stop Bit";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_StopBit
            // 
            this.tbx_StopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_StopBit.Location = new System.Drawing.Point(2, 317);
            this.tbx_StopBit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_StopBit.Name = "tbx_StopBit";
            this.tbx_StopBit.ReadOnly = true;
            this.tbx_StopBit.Size = new System.Drawing.Size(148, 31);
            this.tbx_StopBit.TabIndex = 85;
            this.tbx_StopBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Lime;
            this.textBox12.Location = new System.Drawing.Point(2, 352);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(151, 31);
            this.textBox12.TabIndex = 86;
            this.textBox12.Text = "Parity";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Parity
            // 
            this.tbx_Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Parity.Location = new System.Drawing.Point(2, 387);
            this.tbx_Parity.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Parity.Name = "tbx_Parity";
            this.tbx_Parity.ReadOnly = true;
            this.tbx_Parity.Size = new System.Drawing.Size(148, 31);
            this.tbx_Parity.TabIndex = 87;
            this.tbx_Parity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtCommandLabel);
            this.flowLayoutPanel1.Controls.Add(this.lst_Command);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 437);
            this.flowLayoutPanel1.TabIndex = 81;
            // 
            // flp_StationList
            // 
            this.flp_StationList.Controls.Add(this.textBox1);
            this.flp_StationList.Controls.Add(this.lst_Station);
            this.flp_StationList.Location = new System.Drawing.Point(231, 2);
            this.flp_StationList.Margin = new System.Windows.Forms.Padding(2);
            this.flp_StationList.Name = "flp_StationList";
            this.flp_StationList.Size = new System.Drawing.Size(329, 437);
            this.flp_StationList.TabIndex = 82;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.bt_connect);
            this.flowLayoutPanel3.Controls.Add(this.bt_disconnect);
            this.flowLayoutPanel3.Controls.Add(this.textBox2);
            this.flowLayoutPanel3.Controls.Add(this.ledGreen);
            this.flowLayoutPanel3.Controls.Add(this.textBox3);
            this.flowLayoutPanel3.Controls.Add(this.led_Status);
            this.flowLayoutPanel3.Controls.Add(this.textBox4);
            this.flowLayoutPanel3.Controls.Add(this.tbx_ErrorCode);
            this.flowLayoutPanel3.Controls.Add(this.btn_AlarmReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(979, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(205, 437);
            this.flowLayoutPanel3.TabIndex = 83;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.bt_Command);
            this.flowLayoutPanel6.Controls.Add(this.tbx_parameter_1);
            this.flowLayoutPanel6.Controls.Add(this.nu_parameter_1);
            this.flowLayoutPanel6.Controls.Add(this.tbx_parameter_2);
            this.flowLayoutPanel6.Controls.Add(this.nu_parameter_2);
            this.flowLayoutPanel6.Controls.Add(this.tbx_parameter_3);
            this.flowLayoutPanel6.Controls.Add(this.nu_parameter_3);
            this.flowLayoutPanel6.Controls.Add(this.tbx_parameter_4);
            this.flowLayoutPanel6.Controls.Add(this.nu_parameter_4);
            this.flowLayoutPanel6.Controls.Add(this.tbx_parameter_5);
            this.flowLayoutPanel6.Controls.Add(this.nu_parameter_5);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(564, 2);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(249, 437);
            this.flowLayoutPanel6.TabIndex = 84;
            // 
            // tbx_parameter_3
            // 
            this.tbx_parameter_3.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_parameter_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameter_3.ForeColor = System.Drawing.Color.Lime;
            this.tbx_parameter_3.Location = new System.Drawing.Point(2, 202);
            this.tbx_parameter_3.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_parameter_3.Name = "tbx_parameter_3";
            this.tbx_parameter_3.ReadOnly = true;
            this.tbx_parameter_3.Size = new System.Drawing.Size(240, 26);
            this.tbx_parameter_3.TabIndex = 75;
            this.tbx_parameter_3.Text = "parameter_3";
            this.tbx_parameter_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nu_parameter_3
            // 
            this.nu_parameter_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_parameter_3.Location = new System.Drawing.Point(2, 232);
            this.nu_parameter_3.Margin = new System.Windows.Forms.Padding(2);
            this.nu_parameter_3.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nu_parameter_3.Name = "nu_parameter_3";
            this.nu_parameter_3.Size = new System.Drawing.Size(240, 31);
            this.nu_parameter_3.TabIndex = 76;
            this.nu_parameter_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_parameter_4
            // 
            this.tbx_parameter_4.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_parameter_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameter_4.ForeColor = System.Drawing.Color.Lime;
            this.tbx_parameter_4.Location = new System.Drawing.Point(2, 267);
            this.tbx_parameter_4.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_parameter_4.Name = "tbx_parameter_4";
            this.tbx_parameter_4.ReadOnly = true;
            this.tbx_parameter_4.Size = new System.Drawing.Size(240, 26);
            this.tbx_parameter_4.TabIndex = 77;
            this.tbx_parameter_4.Text = "parameter_4";
            this.tbx_parameter_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nu_parameter_4
            // 
            this.nu_parameter_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_parameter_4.Location = new System.Drawing.Point(2, 297);
            this.nu_parameter_4.Margin = new System.Windows.Forms.Padding(2);
            this.nu_parameter_4.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nu_parameter_4.Name = "nu_parameter_4";
            this.nu_parameter_4.Size = new System.Drawing.Size(240, 31);
            this.nu_parameter_4.TabIndex = 78;
            this.nu_parameter_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_parameter_5
            // 
            this.tbx_parameter_5.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_parameter_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameter_5.ForeColor = System.Drawing.Color.Lime;
            this.tbx_parameter_5.Location = new System.Drawing.Point(2, 332);
            this.tbx_parameter_5.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_parameter_5.Name = "tbx_parameter_5";
            this.tbx_parameter_5.ReadOnly = true;
            this.tbx_parameter_5.Size = new System.Drawing.Size(240, 26);
            this.tbx_parameter_5.TabIndex = 79;
            this.tbx_parameter_5.Text = "parameter_5";
            this.tbx_parameter_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nu_parameter_5
            // 
            this.nu_parameter_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_parameter_5.Location = new System.Drawing.Point(2, 362);
            this.nu_parameter_5.Margin = new System.Windows.Forms.Padding(2);
            this.nu_parameter_5.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nu_parameter_5.Name = "nu_parameter_5";
            this.nu_parameter_5.Size = new System.Drawing.Size(240, 31);
            this.nu_parameter_5.TabIndex = 80;
            this.nu_parameter_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Controls.Add(this.flp_StationList);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1198, 424);
            this.flowLayoutPanel4.TabIndex = 84;
            // 
            // RobotControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(1500, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "RobotControl";
            this.Size = new System.Drawing.Size(1198, 648);
            this.Load += new System.EventHandler(this.RobotControl_Load);
            this.Resize += new System.EventHandler(this.RobotControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_2)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flp_StationList.ResumeLayout(false);
            this.flp_StationList.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_parameter_5)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_disconnect;
        private System.Windows.Forms.Button bt_connect;
        private KCSDK.ThreeColorLight ledGreen;
        private System.Windows.Forms.TextBox txtCommandLabel;
        private System.Windows.Forms.ListBox lst_Command;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lst_Station;
        private System.Windows.Forms.NumericUpDown nu_parameter_1;
        private System.Windows.Forms.TextBox tbx_parameter_1;
        private System.Windows.Forms.NumericUpDown nu_parameter_2;
        private System.Windows.Forms.TextBox tbx_parameter_2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbx_ErrorCode;
        private System.Windows.Forms.Button bt_Command;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flp_StationList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbx_IP;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbx_Port;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbx_StationName;
        private System.Windows.Forms.TextBox tbx_parameter_3;
        private System.Windows.Forms.NumericUpDown nu_parameter_3;
        private System.Windows.Forms.TextBox tbx_parameter_4;
        private System.Windows.Forms.NumericUpDown nu_parameter_4;
        private System.Windows.Forms.TextBox tbx_parameter_5;
        private System.Windows.Forms.NumericUpDown nu_parameter_5;
        private System.Windows.Forms.Button btn_AlarmReset;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private KCSDK.ThreeColorLight led_Status;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbx_DataBit;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tbx_StopBit;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox tbx_Parity;
    }
}
