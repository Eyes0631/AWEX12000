namespace OCRControl
{
    partial class OCRControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRControl));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.txtCommandLabel = new System.Windows.Forms.TextBox();
            this.lst_Command = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbx_ErrorCode = new System.Windows.Forms.TextBox();
            this.bt_Command = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbx_OCR_Result = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.ledGreen = new KCSDK.ThreeColorLight();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_CommandDescribe = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(0, 407);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(898, 191);
            this.listBox1.TabIndex = 11;
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(11, 209);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(144, 40);
            this.bt_disconnect.TabIndex = 12;
            this.bt_disconnect.Text = "Disconnect";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(11, 170);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(144, 40);
            this.bt_connect.TabIndex = 13;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // txtCommandLabel
            // 
            this.txtCommandLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandLabel.ForeColor = System.Drawing.Color.Lime;
            this.txtCommandLabel.Location = new System.Drawing.Point(2, 2);
            this.txtCommandLabel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommandLabel.Name = "txtCommandLabel";
            this.txtCommandLabel.ReadOnly = true;
            this.txtCommandLabel.Size = new System.Drawing.Size(144, 26);
            this.txtCommandLabel.TabIndex = 37;
            this.txtCommandLabel.Text = "Command List";
            this.txtCommandLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst_Command
            // 
            this.lst_Command.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lst_Command.FormattingEnabled = true;
            this.lst_Command.ItemHeight = 17;
            this.lst_Command.Location = new System.Drawing.Point(2, 32);
            this.lst_Command.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Command.Name = "lst_Command";
            this.lst_Command.Size = new System.Drawing.Size(144, 310);
            this.lst_Command.TabIndex = 36;
            this.lst_Command.SelectedIndexChanged += new System.EventHandler(this.lst_Command_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(11, 106);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 75;
            this.textBox4.Text = "Error Code";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_ErrorCode
            // 
            this.tbx_ErrorCode.Location = new System.Drawing.Point(11, 139);
            this.tbx_ErrorCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_ErrorCode.Name = "tbx_ErrorCode";
            this.tbx_ErrorCode.ReadOnly = true;
            this.tbx_ErrorCode.Size = new System.Drawing.Size(148, 22);
            this.tbx_ErrorCode.TabIndex = 76;
            // 
            // bt_Command
            // 
            this.bt_Command.Location = new System.Drawing.Point(11, 249);
            this.bt_Command.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Command.Name = "bt_Command";
            this.bt_Command.Size = new System.Drawing.Size(144, 40);
            this.bt_Command.TabIndex = 77;
            this.bt_Command.Text = "Command";
            this.bt_Command.UseVisualStyleBackColor = true;
            this.bt_Command.Click += new System.EventHandler(this.bt_Command_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.tbx_OCR_Result);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.led_Status);
            this.panel2.Controls.Add(this.btn_AlarmReset);
            this.panel2.Controls.Add(this.flowLayoutPanel8);
            this.panel2.Controls.Add(this.ledGreen);
            this.panel2.Controls.Add(this.bt_connect);
            this.panel2.Controls.Add(this.bt_disconnect);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.tbx_ErrorCode);
            this.panel2.Controls.Add(this.bt_Command);
            this.panel2.Location = new System.Drawing.Point(299, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 361);
            this.panel2.TabIndex = 80;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(214, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "Result";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_OCR_Result
            // 
            this.tbx_OCR_Result.Location = new System.Drawing.Point(214, 91);
            this.tbx_OCR_Result.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_OCR_Result.Name = "tbx_OCR_Result";
            this.tbx_OCR_Result.ReadOnly = true;
            this.tbx_OCR_Result.Size = new System.Drawing.Size(221, 22);
            this.tbx_OCR_Result.TabIndex = 85;
            this.tbx_OCR_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(164, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(11, 59);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(119, 26);
            this.textBox3.TabIndex = 82;
            this.textBox3.Text = "Status";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(11, 19);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 26);
            this.textBox2.TabIndex = 81;
            this.textBox2.Text = "Connect";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // led_Status
            // 
            this.led_Status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("led_Status.BackgroundImage")));
            this.led_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.led_Status.Location = new System.Drawing.Point(142, 54);
            this.led_Status.Name = "led_Status";
            this.led_Status.Size = new System.Drawing.Size(40, 40);
            this.led_Status.TabIndex = 80;
            this.led_Status.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            // 
            // btn_AlarmReset
            // 
            this.btn_AlarmReset.Location = new System.Drawing.Point(11, 289);
            this.btn_AlarmReset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AlarmReset.Name = "btn_AlarmReset";
            this.btn_AlarmReset.Size = new System.Drawing.Size(144, 40);
            this.btn_AlarmReset.TabIndex = 79;
            this.btn_AlarmReset.Text = "Alarm Reset";
            this.btn_AlarmReset.UseVisualStyleBackColor = true;
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
            this.flowLayoutPanel8.Location = new System.Drawing.Point(437, 3);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(158, 357);
            this.flowLayoutPanel8.TabIndex = 78;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Lime;
            this.textBox6.Location = new System.Drawing.Point(2, 2);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(151, 26);
            this.textBox6.TabIndex = 80;
            this.textBox6.Text = "Name";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_StationName
            // 
            this.tbx_StationName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_StationName.Location = new System.Drawing.Point(2, 32);
            this.tbx_StationName.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_StationName.Name = "tbx_StationName";
            this.tbx_StationName.ReadOnly = true;
            this.tbx_StationName.Size = new System.Drawing.Size(148, 22);
            this.tbx_StationName.TabIndex = 81;
            this.tbx_StationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Lime;
            this.textBox5.Location = new System.Drawing.Point(2, 58);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(151, 26);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "IP";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_IP
            // 
            this.tbx_IP.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_IP.Location = new System.Drawing.Point(2, 88);
            this.tbx_IP.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.ReadOnly = true;
            this.tbx_IP.Size = new System.Drawing.Size(148, 22);
            this.tbx_IP.TabIndex = 77;
            this.tbx_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Lime;
            this.textBox7.Location = new System.Drawing.Point(2, 114);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(151, 26);
            this.textBox7.TabIndex = 78;
            this.textBox7.Text = "Port";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Port
            // 
            this.tbx_Port.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Port.Location = new System.Drawing.Point(2, 144);
            this.tbx_Port.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Port.Name = "tbx_Port";
            this.tbx_Port.ReadOnly = true;
            this.tbx_Port.Size = new System.Drawing.Size(148, 22);
            this.tbx_Port.TabIndex = 79;
            this.tbx_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Lime;
            this.textBox8.Location = new System.Drawing.Point(2, 170);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(151, 26);
            this.textBox8.TabIndex = 82;
            this.textBox8.Text = "Data Bit";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_DataBit
            // 
            this.tbx_DataBit.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_DataBit.Location = new System.Drawing.Point(2, 200);
            this.tbx_DataBit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_DataBit.Name = "tbx_DataBit";
            this.tbx_DataBit.ReadOnly = true;
            this.tbx_DataBit.Size = new System.Drawing.Size(148, 22);
            this.tbx_DataBit.TabIndex = 83;
            this.tbx_DataBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Lime;
            this.textBox10.Location = new System.Drawing.Point(2, 226);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(151, 26);
            this.textBox10.TabIndex = 84;
            this.textBox10.Text = "Stop Bit";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_StopBit
            // 
            this.tbx_StopBit.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_StopBit.Location = new System.Drawing.Point(2, 256);
            this.tbx_StopBit.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_StopBit.Name = "tbx_StopBit";
            this.tbx_StopBit.ReadOnly = true;
            this.tbx_StopBit.Size = new System.Drawing.Size(148, 22);
            this.tbx_StopBit.TabIndex = 85;
            this.tbx_StopBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Lime;
            this.textBox12.Location = new System.Drawing.Point(2, 282);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(151, 29);
            this.textBox12.TabIndex = 86;
            this.textBox12.Text = "Parity";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Parity
            // 
            this.tbx_Parity.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Parity.Location = new System.Drawing.Point(2, 315);
            this.tbx_Parity.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Parity.Name = "tbx_Parity";
            this.tbx_Parity.ReadOnly = true;
            this.tbx_Parity.Size = new System.Drawing.Size(148, 22);
            this.tbx_Parity.TabIndex = 87;
            this.tbx_Parity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ledGreen
            // 
            this.ledGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ledGreen.BackgroundImage")));
            this.ledGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ledGreen.Location = new System.Drawing.Point(142, 14);
            this.ledGreen.Name = "ledGreen";
            this.ledGreen.Size = new System.Drawing.Size(40, 40);
            this.ledGreen.TabIndex = 35;
            this.ledGreen.Value = KCSDK.ThreeColorLight.ColorLightType.GrayLight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtCommandLabel);
            this.flowLayoutPanel1.Controls.Add(this.lst_Command);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 361);
            this.flowLayoutPanel1.TabIndex = 81;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(156, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(139, 344);
            this.flowLayoutPanel3.TabIndex = 83;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(136, 358);
            this.flowLayoutPanel6.TabIndex = 84;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Controls.Add(this.panel2);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(898, 407);
            this.flowLayoutPanel4.TabIndex = 84;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label1);
            this.flowLayoutPanel7.Controls.Add(this.lb_CommandDescribe);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(2, 367);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(881, 35);
            this.flowLayoutPanel7.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Command說明:";
            // 
            // lb_CommandDescribe
            // 
            this.lb_CommandDescribe.AutoSize = true;
            this.lb_CommandDescribe.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CommandDescribe.Location = new System.Drawing.Point(115, 0);
            this.lb_CommandDescribe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CommandDescribe.Name = "lb_CommandDescribe";
            this.lb_CommandDescribe.Size = new System.Drawing.Size(40, 16);
            this.lb_CommandDescribe.TabIndex = 79;
            this.lb_CommandDescribe.Text = "說明";
            // 
            // OCRControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "OCRControl";
            this.Size = new System.Drawing.Size(898, 598);
            this.Load += new System.EventHandler(this.RobotControl_Load);
            this.Resize += new System.EventHandler(this.RobotControl_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_disconnect;
        private System.Windows.Forms.Button bt_connect;
        private KCSDK.ThreeColorLight ledGreen;
        private System.Windows.Forms.TextBox txtCommandLabel;
        private System.Windows.Forms.ListBox lst_Command;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbx_ErrorCode;
        private System.Windows.Forms.Button bt_Command;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label lb_CommandDescribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbx_IP;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbx_Port;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbx_StationName;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_OCR_Result;
    }
}
