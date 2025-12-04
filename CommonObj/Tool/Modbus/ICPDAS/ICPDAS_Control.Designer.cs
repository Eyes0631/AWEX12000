namespace CommonObj.ModbusTCP
{
    partial class ICPDAS_Control
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
            this.tbx_AO_0_Set = new System.Windows.Forms.TextBox();
            this.tbx_AO_1_Set = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AO_SetValue = new System.Windows.Forms.Button();
            this.numericUpDown_AO = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbx_Mode = new System.Windows.Forms.ComboBox();
            this.cbx_Channels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AO_SetMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AO)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_AO_0_Set
            // 
            this.tbx_AO_0_Set.Location = new System.Drawing.Point(386, 12);
            this.tbx_AO_0_Set.Name = "tbx_AO_0_Set";
            this.tbx_AO_0_Set.ReadOnly = true;
            this.tbx_AO_0_Set.Size = new System.Drawing.Size(100, 33);
            this.tbx_AO_0_Set.TabIndex = 0;
            // 
            // tbx_AO_1_Set
            // 
            this.tbx_AO_1_Set.Location = new System.Drawing.Point(386, 47);
            this.tbx_AO_1_Set.Name = "tbx_AO_1_Set";
            this.tbx_AO_1_Set.ReadOnly = true;
            this.tbx_AO_1_Set.Size = new System.Drawing.Size(100, 33);
            this.tbx_AO_1_Set.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "AO_0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "AO_1";
            // 
            // btn_AO_SetValue
            // 
            this.btn_AO_SetValue.Location = new System.Drawing.Point(184, 91);
            this.btn_AO_SetValue.Name = "btn_AO_SetValue";
            this.btn_AO_SetValue.Size = new System.Drawing.Size(100, 33);
            this.btn_AO_SetValue.TabIndex = 8;
            this.btn_AO_SetValue.Text = "Set";
            this.btn_AO_SetValue.UseVisualStyleBackColor = true;
            this.btn_AO_SetValue.Click += new System.EventHandler(this.btn_AO_SetValue_Click);
            // 
            // numericUpDown_AO
            // 
            this.numericUpDown_AO.Location = new System.Drawing.Point(104, 91);
            this.numericUpDown_AO.Name = "numericUpDown_AO";
            this.numericUpDown_AO.Size = new System.Drawing.Size(74, 33);
            this.numericUpDown_AO.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(494, 257);
            this.textBox1.TabIndex = 12;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(122, 10);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 35);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbx_Mode
            // 
            this.cbx_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Mode.FormattingEnabled = true;
            this.cbx_Mode.Items.AddRange(new object[] {
            "0~20 mA",
            "4~20 mA",
            "0~10 V"});
            this.cbx_Mode.Location = new System.Drawing.Point(104, 131);
            this.cbx_Mode.Name = "cbx_Mode";
            this.cbx_Mode.Size = new System.Drawing.Size(74, 29);
            this.cbx_Mode.TabIndex = 15;
            // 
            // cbx_Channels
            // 
            this.cbx_Channels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Channels.FormattingEnabled = true;
            this.cbx_Channels.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbx_Channels.Location = new System.Drawing.Point(104, 56);
            this.cbx_Channels.Name = "cbx_Channels";
            this.cbx_Channels.Size = new System.Drawing.Size(74, 29);
            this.cbx_Channels.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Channels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mode";
            // 
            // btn_AO_SetMode
            // 
            this.btn_AO_SetMode.Location = new System.Drawing.Point(184, 130);
            this.btn_AO_SetMode.Name = "btn_AO_SetMode";
            this.btn_AO_SetMode.Size = new System.Drawing.Size(100, 30);
            this.btn_AO_SetMode.TabIndex = 20;
            this.btn_AO_SetMode.Text = "Set";
            this.btn_AO_SetMode.UseVisualStyleBackColor = true;
            this.btn_AO_SetMode.Click += new System.EventHandler(this.btn_AO_SetMode_Click);
            // 
            // ICPDAS_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_AO_SetMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Channels);
            this.Controls.Add(this.cbx_Mode);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown_AO);
            this.Controls.Add(this.btn_AO_SetValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_AO_1_Set);
            this.Controls.Add(this.tbx_AO_0_Set);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "ICPDAS_Control";
            this.Size = new System.Drawing.Size(531, 461);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_AO_0_Set;
        private System.Windows.Forms.TextBox tbx_AO_1_Set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AO_SetValue;
        private System.Windows.Forms.NumericUpDown numericUpDown_AO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbx_Mode;
        private System.Windows.Forms.ComboBox cbx_Channels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AO_SetMode;
    }
}
