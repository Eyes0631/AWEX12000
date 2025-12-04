namespace CommonObj
{
    partial class Camera
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
            if ( disposing && ( components != null ) )
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
            this.Ccd_SECSEgnine = new ProVTool.ProVSECSEngine();
            this.proVClientSocketEx1 = new ProVSocketLib.ProVClientSocketEx();
            this.proVClientSocketEx2 = new ProVSocketLib.ProVClientSocketEx();
            this.Ccd_ClientSocket = new ProVSocketLib.ProVClientSocketEx();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ccd_SECSEgnine
            // 
            this.Ccd_SECSEgnine.ConnectMode = ProVTool.CONNECTMODE.ACTIVE;
            this.Ccd_SECSEgnine.ConsumeTime = ((long)(0));
            this.Ccd_SECSEgnine.DeviceID = ((ushort)(0));
            this.Ccd_SECSEgnine.EncodingCode = ProVTool.eEncodingCode.Chinese_Big5;
            this.Ccd_SECSEgnine.Interval = ((uint)(10u));
            this.Ccd_SECSEgnine.IP = "127.0.0.1";
            this.Ccd_SECSEgnine.LinkTestPeroid = ((long)(60));
            this.Ccd_SECSEgnine.Location = new System.Drawing.Point(4, 4);
            this.Ccd_SECSEgnine.Name = "Ccd_SECSEgnine";
            this.Ccd_SECSEgnine.Port = ((ushort)(5000));
            this.Ccd_SECSEgnine.Size = new System.Drawing.Size(200, 30);
            this.Ccd_SECSEgnine.SpoolActive = false;
            this.Ccd_SECSEgnine.T3 = ((long)(45));
            this.Ccd_SECSEgnine.T5 = ((long)(5));
            this.Ccd_SECSEgnine.T6 = ((long)(5));
            this.Ccd_SECSEgnine.T7 = ((long)(5));
            this.Ccd_SECSEgnine.T8 = ((long)(3));
            this.Ccd_SECSEgnine.Text = "ProV_CCD SECSEgnine";
            this.Ccd_SECSEgnine.OnReadEvent += new ProVTool.OnReadDelegate(this.CcdSocket_OnReadEvent);
            // 
            // proVClientSocketEx1
            // 
            this.proVClientSocketEx1.CaptionFont = new System.Drawing.Font("微軟正黑體", 8F);
            this.proVClientSocketEx1.IP = null;
            this.proVClientSocketEx1.IsConnected = false;
            this.proVClientSocketEx1.Location = new System.Drawing.Point(0, 0);
            this.proVClientSocketEx1.MessageBufferSize = 8192;
            this.proVClientSocketEx1.Name = "proVClientSocketEx1";
            this.proVClientSocketEx1.Port = 0;
            this.proVClientSocketEx1.ReConnectAttempt = 0;
            this.proVClientSocketEx1.Size = new System.Drawing.Size(200, 30);
            // 
            // proVClientSocketEx2
            // 
            this.proVClientSocketEx2.CaptionFont = new System.Drawing.Font("微軟正黑體", 8F);
            this.proVClientSocketEx2.IP = null;
            this.proVClientSocketEx2.IsConnected = false;
            this.proVClientSocketEx2.Location = new System.Drawing.Point(0, 0);
            this.proVClientSocketEx2.MessageBufferSize = 8192;
            this.proVClientSocketEx2.Name = "proVClientSocketEx2";
            this.proVClientSocketEx2.Port = 0;
            this.proVClientSocketEx2.ReConnectAttempt = 0;
            this.proVClientSocketEx2.Size = new System.Drawing.Size(200, 30);
            // 
            // Ccd_ClientSocket
            // 
            this.Ccd_ClientSocket.CaptionFont = new System.Drawing.Font("微軟正黑體", 8F);
            this.Ccd_ClientSocket.IP = null;
            this.Ccd_ClientSocket.IsConnected = false;
            this.Ccd_ClientSocket.Location = new System.Drawing.Point(3, 42);
            this.Ccd_ClientSocket.MessageBufferSize = 8192;
            this.Ccd_ClientSocket.Name = "Ccd_ClientSocket";
            this.Ccd_ClientSocket.Port = 0;
            this.Ccd_ClientSocket.ReConnectAttempt = 0;
            this.Ccd_ClientSocket.Size = new System.Drawing.Size(200, 30);
            this.Ccd_ClientSocket.Text = "ProV_CCD Socket";
            this.Ccd_ClientSocket.OnRead += new ProVSocketLib.ProVClientSocketEx.SocketReadNotifyHandler(this.ClientScoket_OnRead);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Ccd_SECSEgnine);
            this.flowLayoutPanel1.Controls.Add(this.Ccd_ClientSocket);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 79);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Camera
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Camera";
            this.Size = new System.Drawing.Size(223, 85);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProVTool.ProVSECSEngine Ccd_SECSEgnine;
        private ProVSocketLib.ProVClientSocketEx proVClientSocketEx1;
        private ProVSocketLib.ProVClientSocketEx proVClientSocketEx2;
        private ProVSocketLib.ProVClientSocketEx Ccd_ClientSocket;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
