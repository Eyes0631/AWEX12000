namespace AWEX12000
{
    partial class PackageF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageF));
            this.dRadioGroupBox2 = new KCSDK.DRadioGroupBox(this.components);
            this.dFieldEdit2 = new KCSDK.DFieldEdit();
            this.dFieldEdit3 = new KCSDK.DFieldEdit();
            this.drgb_UseAlignerOCR = new KCSDK.DRadioGroupBox(this.components);
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PackageContainer)).BeginInit();
            this.PackageContainer.Panel1.SuspendLayout();
            this.PackageContainer.Panel2.SuspendLayout();
            this.PackageContainer.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.imgList.Images.SetKeyName(9, "closebtn.png");
            // 
            // PackageContainer
            // 
            this.PackageContainer.Size = new System.Drawing.Size(1240, 743);
            this.PackageContainer.SplitterDistance = 278;
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(956, 58);
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.drgb_UseAlignerOCR);
            this.pnlControl.Controls.Add(this.textBox8);
            this.pnlControl.Controls.Add(this.dRadioGroupBox2);
            this.pnlControl.Controls.Add(this.dFieldEdit2);
            this.pnlControl.Controls.Add(this.dFieldEdit3);
            this.pnlControl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnlControl.Size = new System.Drawing.Size(956, 683);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(276, 97);
            // 
            // dRadioGroupBox2
            // 
            this.dRadioGroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.dRadioGroupBox2.ColCount = 1;
            this.dRadioGroupBox2.DataName = "_WaferThickness";
            this.dRadioGroupBox2.DataSource = this.PreloadPackageDS;
            this.dRadioGroupBox2.DefaultValue = 0;
            this.dRadioGroupBox2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.dRadioGroupBox2.IsModified = false;
            this.dRadioGroupBox2.ItemFont = new System.Drawing.Font("微軟正黑體", 12F);
            this.dRadioGroupBox2.ItemHeight = 30;
            this.dRadioGroupBox2.ItemLeft = 10;
            this.dRadioGroupBox2.ItemTop = 30;
            this.dRadioGroupBox2.ItemWidth = 100;
            this.dRadioGroupBox2.Location = new System.Drawing.Point(16, 82);
            this.dRadioGroupBox2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dRadioGroupBox2.Name = "dRadioGroupBox2";
            this.dRadioGroupBox2.NoChangeInAuto = false;
            this.dRadioGroupBox2.RadioItems = ((System.Collections.Generic.List<string>)(resources.GetObject("dRadioGroupBox2.RadioItems")));
            this.dRadioGroupBox2.Size = new System.Drawing.Size(300, 100);
            this.dRadioGroupBox2.TabIndex = 64;
            this.dRadioGroupBox2.TabStop = false;
            this.dRadioGroupBox2.Text = "Wafer Thickness";
            // 
            // dFieldEdit2
            // 
            this.dFieldEdit2.AutoFocus = false;
            this.dFieldEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit2.Caption = "OCR Align Angle";
            this.dFieldEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.DataName = "P_i_OCR_Angle";
            this.dFieldEdit2.DataSource = this.PreloadPackageDS;
            this.dFieldEdit2.DefaultValue = null;
            this.dFieldEdit2.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.EditWidth = 80;
            this.dFieldEdit2.FieldValue = "";
            this.dFieldEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.IsModified = false;
            this.dFieldEdit2.Location = new System.Drawing.Point(16, 10);
            this.dFieldEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit2.MaxValue = 360D;
            this.dFieldEdit2.MinValue = 0D;
            this.dFieldEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit2.Name = "dFieldEdit2";
            this.dFieldEdit2.NoChangeInAuto = false;
            this.dFieldEdit2.Size = new System.Drawing.Size(300, 29);
            this.dFieldEdit2.StepValue = 0D;
            this.dFieldEdit2.TabIndex = 63;
            this.dFieldEdit2.Unit = "deg";
            this.dFieldEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.UnitWidth = 60;
            this.dFieldEdit2.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit3
            // 
            this.dFieldEdit3.AutoFocus = false;
            this.dFieldEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit3.Caption = "LP Out Angle";
            this.dFieldEdit3.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit3.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.DataName = "P_i_LP_Angle";
            this.dFieldEdit3.DataSource = this.PreloadPackageDS;
            this.dFieldEdit3.DefaultValue = null;
            this.dFieldEdit3.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit3.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.EditWidth = 80;
            this.dFieldEdit3.FieldValue = "";
            this.dFieldEdit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit3.IsModified = false;
            this.dFieldEdit3.Location = new System.Drawing.Point(16, 39);
            this.dFieldEdit3.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit3.MaxValue = 360D;
            this.dFieldEdit3.MinValue = 0D;
            this.dFieldEdit3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit3.Name = "dFieldEdit3";
            this.dFieldEdit3.NoChangeInAuto = false;
            this.dFieldEdit3.Size = new System.Drawing.Size(300, 29);
            this.dFieldEdit3.StepValue = 0D;
            this.dFieldEdit3.TabIndex = 62;
            this.dFieldEdit3.Unit = "deg";
            this.dFieldEdit3.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.UnitWidth = 60;
            this.dFieldEdit3.ValueType = KCSDK.ValueDataType.Int;
            this.dFieldEdit3.Visible = false;
            // 
            // drgb_UseAlignerOCR
            // 
            this.drgb_UseAlignerOCR.BackColor = System.Drawing.SystemColors.Control;
            this.drgb_UseAlignerOCR.ColCount = 1;
            this.drgb_UseAlignerOCR.DataName = "UseAlignerOCR";
            this.drgb_UseAlignerOCR.DataSource = this.PreloadPackageDS;
            this.drgb_UseAlignerOCR.DefaultValue = 0;
            this.drgb_UseAlignerOCR.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.drgb_UseAlignerOCR.IsModified = false;
            this.drgb_UseAlignerOCR.ItemFont = new System.Drawing.Font("微軟正黑體", 12F);
            this.drgb_UseAlignerOCR.ItemHeight = 30;
            this.drgb_UseAlignerOCR.ItemLeft = 10;
            this.drgb_UseAlignerOCR.ItemTop = 30;
            this.drgb_UseAlignerOCR.ItemWidth = 100;
            this.drgb_UseAlignerOCR.Location = new System.Drawing.Point(322, 41);
            this.drgb_UseAlignerOCR.ModifiedColor = System.Drawing.Color.Aqua;
            this.drgb_UseAlignerOCR.Name = "drgb_UseAlignerOCR";
            this.drgb_UseAlignerOCR.NoChangeInAuto = false;
            this.drgb_UseAlignerOCR.RadioItems = ((System.Collections.Generic.List<string>)(resources.GetObject("drgb_UseAlignerOCR.RadioItems")));
            this.drgb_UseAlignerOCR.Size = new System.Drawing.Size(102, 141);
            this.drgb_UseAlignerOCR.TabIndex = 66;
            this.drgb_UseAlignerOCR.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.DimGray;
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(322, 10);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(102, 29);
            this.textBox8.TabIndex = 65;
            this.textBox8.Text = "Alinger OCR";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PackageF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 743);
            this.Name = "PackageF";
            this.PackageContainer.Panel1.ResumeLayout(false);
            this.PackageContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PackageContainer)).EndInit();
            this.PackageContainer.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KCSDK.DRadioGroupBox dRadioGroupBox2;
        private KCSDK.DFieldEdit dFieldEdit2;
        private KCSDK.DFieldEdit dFieldEdit3;
        private KCSDK.DRadioGroupBox drgb_UseAlignerOCR;
        private System.Windows.Forms.TextBox textBox8;



    }
}