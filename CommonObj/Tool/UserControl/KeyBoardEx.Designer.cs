namespace CommonObj
{
    partial class KeyBoardEx
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
            this.btn_MyKeyboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MyKeyboard
            // 
            this.btn_MyKeyboard.BackColor = System.Drawing.Color.White;
            this.btn_MyKeyboard.BackgroundImage = global::CommonObj.Properties.Resources.keyboard;
            this.btn_MyKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MyKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MyKeyboard.Location = new System.Drawing.Point(0, 0);
            this.btn_MyKeyboard.Name = "btn_MyKeyboard";
            this.btn_MyKeyboard.Size = new System.Drawing.Size(36, 37);
            this.btn_MyKeyboard.TabIndex = 39;
            this.btn_MyKeyboard.UseVisualStyleBackColor = false;
            this.btn_MyKeyboard.Click += new System.EventHandler(this.btn_MyKeyboard_Click);
            // 
            // KeyBoardEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_MyKeyboard);
            this.Name = "KeyBoardEx";
            this.Size = new System.Drawing.Size(36, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MyKeyboard;
    }
}
