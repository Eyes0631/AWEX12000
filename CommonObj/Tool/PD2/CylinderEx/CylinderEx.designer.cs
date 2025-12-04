namespace CommonObj
{
    partial class CylinderEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CylinderEx));
            this.ledLabel_Off = new KCSDK.LEDLabel();
            this.ledLabel_On = new KCSDK.LEDLabel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Cycle = new System.Windows.Forms.Button();
            this.btnSW = new System.Windows.Forms.Button();
            this.lb_CyName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_CycleTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ActionTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledLabel_Off
            // 
            this.ledLabel_Off.Caption = "Off";
            this.ledLabel_Off.CaptionFont = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ledLabel_Off.CpationColor = System.Drawing.Color.Black;
            this.ledLabel_Off.Location = new System.Drawing.Point(13, 25);
            this.ledLabel_Off.Name = "ledLabel_Off";
            this.ledLabel_Off.Size = new System.Drawing.Size(133, 30);
            this.ledLabel_Off.TabIndex = 67;
            this.ledLabel_Off.Value = false;
            // 
            // ledLabel_On
            // 
            this.ledLabel_On.Caption = "On";
            this.ledLabel_On.CaptionFont = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ledLabel_On.CpationColor = System.Drawing.Color.Black;
            this.ledLabel_On.Location = new System.Drawing.Point(13, 0);
            this.ledLabel_On.Name = "ledLabel_On";
            this.ledLabel_On.Size = new System.Drawing.Size(133, 30);
            this.ledLabel_On.TabIndex = 68;
            this.ledLabel_On.Value = false;
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BackgroundImage = global::CommonObj.Properties.Resources.settings;
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Setting.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Location = new System.Drawing.Point(119, 57);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(27, 25);
            this.btn_Setting.TabIndex = 70;
            this.btn_Setting.TabStop = false;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Cycle
            // 
            this.btn_Cycle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cycle.BackgroundImage")));
            this.btn_Cycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cycle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Cycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cycle.Location = new System.Drawing.Point(80, 57);
            this.btn_Cycle.Name = "btn_Cycle";
            this.btn_Cycle.Size = new System.Drawing.Size(27, 25);
            this.btn_Cycle.TabIndex = 69;
            this.btn_Cycle.TabStop = false;
            this.btn_Cycle.UseVisualStyleBackColor = false;
            this.btn_Cycle.Click += new System.EventHandler(this.btn_Cycle_Click);
            // 
            // btnSW
            // 
            this.btnSW.BackColor = System.Drawing.Color.Transparent;
            this.btnSW.BackgroundImage = global::CommonObj.Properties.Resources.toggle_off;
            this.btnSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSW.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSW.Location = new System.Drawing.Point(19, 57);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(49, 25);
            this.btnSW.TabIndex = 0;
            this.btnSW.TabStop = false;
            this.btnSW.UseVisualStyleBackColor = false;
            this.btnSW.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // lb_CyName
            // 
            this.lb_CyName.BackColor = System.Drawing.Color.Black;
            this.lb_CyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CyName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CyName.ForeColor = System.Drawing.Color.Yellow;
            this.lb_CyName.Location = new System.Drawing.Point(3, 0);
            this.lb_CyName.Name = "lb_CyName";
            this.lb_CyName.Size = new System.Drawing.Size(163, 21);
            this.lb_CyName.TabIndex = 71;
            this.lb_CyName.Text = "Cylinder Name";
            this.lb_CyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ledLabel_Off);
            this.panel1.Controls.Add(this.btnSW);
            this.panel1.Controls.Add(this.btn_Cycle);
            this.panel1.Controls.Add(this.ledLabel_On);
            this.panel1.Controls.Add(this.btn_Setting);
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 84);
            this.panel1.TabIndex = 79;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_CyName);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 220);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbx_CycleTime);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_ActionTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 62);
            this.panel2.TabIndex = 80;
            // 
            // tbx_CycleTime
            // 
            this.tbx_CycleTime.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_CycleTime.Location = new System.Drawing.Point(53, 31);
            this.tbx_CycleTime.Name = "tbx_CycleTime";
            this.tbx_CycleTime.Size = new System.Drawing.Size(59, 25);
            this.tbx_CycleTime.TabIndex = 84;
            this.tbx_CycleTime.Text = "1000";
            this.tbx_CycleTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_CycleTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(118, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 19);
            this.label6.TabIndex = 83;
            this.label6.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(118, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 82;
            this.label5.Text = "ms";
            // 
            // lb_ActionTime
            // 
            this.lb_ActionTime.AutoSize = true;
            this.lb_ActionTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_ActionTime.Location = new System.Drawing.Point(53, 3);
            this.lb_ActionTime.Name = "lb_ActionTime";
            this.lb_ActionTime.Size = new System.Drawing.Size(45, 19);
            this.lb_ActionTime.TabIndex = 81;
            this.lb_ActionTime.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "AT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "DT:";
            // 
            // CylinderEx
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CylinderEx";
            this.Size = new System.Drawing.Size(169, 220);
            this.Load += new System.EventHandler(this.CylinderEx_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CylinderEx_Paint);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSW;
        private KCSDK.LEDLabel ledLabel_Off;
        private KCSDK.LEDLabel ledLabel_On;
        private System.Windows.Forms.Button btn_Cycle;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Label lb_CyName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_CycleTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ActionTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
