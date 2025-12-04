namespace AWEX12000
{
    partial class InitialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.lbMachineState = new System.Windows.Forms.Label();
            this.picMachine = new System.Windows.Forms.PictureBox();
            this.lbTray = new KCSDK.LEDLabel();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "cancel.png";
            this.btnCancel.ImageList = this.imglist;
            this.btnCancel.Location = new System.Drawing.Point(834, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 84);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取  消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.White;
            this.imglist.Images.SetKeyName(0, "cancel.png");
            // 
            // lbMachineState
            // 
            this.lbMachineState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbMachineState.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMachineState.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMachineState.ForeColor = System.Drawing.Color.Black;
            this.lbMachineState.Location = new System.Drawing.Point(0, 0);
            this.lbMachineState.Name = "lbMachineState";
            this.lbMachineState.Size = new System.Drawing.Size(1121, 86);
            this.lbMachineState.TabIndex = 6;
            this.lbMachineState.Text = "機台初始化中";
            this.lbMachineState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMachine
            // 
            this.picMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMachine.BackgroundImage")));
            this.picMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMachine.Location = new System.Drawing.Point(0, 86);
            this.picMachine.Name = "picMachine";
            this.picMachine.Size = new System.Drawing.Size(1121, 638);
            this.picMachine.TabIndex = 8;
            this.picMachine.TabStop = false;
            // 
            // lbTray
            // 
            this.lbTray.BackColor = System.Drawing.Color.Black;
            this.lbTray.Caption = "TRAY 模組";
            this.lbTray.CaptionFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTray.CpationColor = System.Drawing.Color.Yellow;
            this.lbTray.Location = new System.Drawing.Point(356, 111);
            this.lbTray.Name = "lbTray";
            this.lbTray.Size = new System.Drawing.Size(170, 40);
            this.lbTray.TabIndex = 9;
            this.lbTray.Value = false;
            // 
            // tmRefresh
            // 
            this.tmRefresh.Interval = 40;
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // InitialForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1121, 724);
            this.Controls.Add(this.lbTray);
            this.Controls.Add(this.picMachine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbMachineState);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InitialForm";
            this.Text = "初始化";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMachineState;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.PictureBox picMachine;
        private System.Windows.Forms.Button btnCancel;
        private KCSDK.LEDLabel lbTray;
        private System.Windows.Forms.Timer tmRefresh;
    }
}