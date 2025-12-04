namespace CommonObj.Tool.Modbus.EPSON
{
    partial class EP7800_UserControl
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Now_Pressure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Max_Pressure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Min_Pressure = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Cycle = new System.Windows.Forms.Button();
            this.btn_Writte = new System.Windows.Forms.Button();
            this.cbx_Command = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(12, 56);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 35);
            this.btnDisconnect.TabIndex = 16;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(494, 257);
            this.textBox1.TabIndex = 17;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(12, 162);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(100, 35);
            this.btn_Read.TabIndex = 18;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "目前壓力值";
            // 
            // tbx_Now_Pressure
            // 
            this.tbx_Now_Pressure.Location = new System.Drawing.Point(286, 19);
            this.tbx_Now_Pressure.Name = "tbx_Now_Pressure";
            this.tbx_Now_Pressure.ReadOnly = true;
            this.tbx_Now_Pressure.Size = new System.Drawing.Size(100, 33);
            this.tbx_Now_Pressure.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "最大壓力值";
            // 
            // tbx_Max_Pressure
            // 
            this.tbx_Max_Pressure.Location = new System.Drawing.Point(286, 64);
            this.tbx_Max_Pressure.Name = "tbx_Max_Pressure";
            this.tbx_Max_Pressure.ReadOnly = true;
            this.tbx_Max_Pressure.Size = new System.Drawing.Size(100, 33);
            this.tbx_Max_Pressure.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "最小壓力值";
            // 
            // tbx_Min_Pressure
            // 
            this.tbx_Min_Pressure.Location = new System.Drawing.Point(286, 110);
            this.tbx_Min_Pressure.Name = "tbx_Min_Pressure";
            this.tbx_Min_Pressure.ReadOnly = true;
            this.tbx_Min_Pressure.Size = new System.Drawing.Size(100, 33);
            this.tbx_Min_Pressure.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Cycle
            // 
            this.btn_Cycle.Location = new System.Drawing.Point(429, 17);
            this.btn_Cycle.Name = "btn_Cycle";
            this.btn_Cycle.Size = new System.Drawing.Size(100, 35);
            this.btn_Cycle.TabIndex = 26;
            this.btn_Cycle.Text = "循環";
            this.btn_Cycle.UseVisualStyleBackColor = true;
            this.btn_Cycle.Click += new System.EventHandler(this.btn_Cycle_Click);
            // 
            // btn_Writte
            // 
            this.btn_Writte.Location = new System.Drawing.Point(12, 212);
            this.btn_Writte.Name = "btn_Writte";
            this.btn_Writte.Size = new System.Drawing.Size(100, 35);
            this.btn_Writte.TabIndex = 27;
            this.btn_Writte.Text = "Writte";
            this.btn_Writte.UseVisualStyleBackColor = true;
            this.btn_Writte.Click += new System.EventHandler(this.btn_Writte_Click);
            // 
            // cbx_Command
            // 
            this.cbx_Command.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Command.FormattingEnabled = true;
            this.cbx_Command.Location = new System.Drawing.Point(134, 166);
            this.cbx_Command.Name = "cbx_Command";
            this.cbx_Command.Size = new System.Drawing.Size(176, 29);
            this.cbx_Command.TabIndex = 28;
            // 
            // EP7800_UserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbx_Command);
            this.Controls.Add(this.btn_Writte);
            this.Controls.Add(this.btn_Cycle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Min_Pressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Max_Pressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Now_Pressure);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EP7800_UserControl";
            this.Size = new System.Drawing.Size(1070, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Now_Pressure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Max_Pressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Min_Pressure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Cycle;
        private System.Windows.Forms.Button btn_Writte;
        private System.Windows.Forms.ComboBox cbx_Command;

    }
}
