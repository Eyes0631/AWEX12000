namespace AWEX12000
{
    partial class OptionF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionF));
            this.label2 = new System.Windows.Forms.Label();
            this.dComboBox1 = new KCSDK.DComboBox();
            this.dCheckBox1 = new KCSDK.DCheckBox(this.components);
            this.dFieldEdit2 = new KCSDK.DFieldEdit();
            this.dCheckBox2 = new KCSDK.DCheckBox(this.components);
            this.dFieldEdit1 = new KCSDK.DFieldEdit();
            this.dRadioGroupBox3 = new KCSDK.DRadioGroupBox(this.components);
            this.dRadioGroupBox1 = new KCSDK.DRadioGroupBox(this.components);
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
            // btnClose
            // 
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(353, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "通訊功能";
            // 
            // dComboBox1
            // 
            this.dComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.dComboBox1.DataName = "CommProtocol";
            this.dComboBox1.DataSource = this.OptionDS;
            this.dComboBox1.DefaultValue = 0;
            this.dComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dComboBox1.ForeColor = System.Drawing.Color.Red;
            this.dComboBox1.FormattingEnabled = true;
            this.dComboBox1.IsModified = false;
            this.dComboBox1.Items.AddRange(new object[] {
            "None",
            "SECS"});
            this.dComboBox1.Location = new System.Drawing.Point(432, 74);
            this.dComboBox1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dComboBox1.Name = "dComboBox1";
            this.dComboBox1.NoChangeInAuto = true;
            this.dComboBox1.Size = new System.Drawing.Size(141, 28);
            this.dComboBox1.TabIndex = 10;
            // 
            // dCheckBox1
            // 
            this.dCheckBox1.AutoSize = true;
            this.dCheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox1.DataName = "DryRun";
            this.dCheckBox1.DataSource = this.OptionDS;
            this.dCheckBox1.DefaultValue = false;
            this.dCheckBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dCheckBox1.IsModified = false;
            this.dCheckBox1.Location = new System.Drawing.Point(24, 138);
            this.dCheckBox1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox1.Name = "dCheckBox1";
            this.dCheckBox1.NoChangeInAuto = true;
            this.dCheckBox1.Size = new System.Drawing.Size(92, 24);
            this.dCheckBox1.TabIndex = 6;
            this.dCheckBox1.Text = "空跑測試";
            this.dCheckBox1.UseVisualStyleBackColor = true;
            // 
            // dFieldEdit2
            // 
            this.dFieldEdit2.AutoFocus = false;
            this.dFieldEdit2.Caption = "機台速率";
            this.dFieldEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.DataName = "機台速率";
            this.dFieldEdit2.DataSource = this.OptionDS;
            this.dFieldEdit2.DefaultValue = null;
            this.dFieldEdit2.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.EditWidth = 100;
            this.dFieldEdit2.FieldValue = "0";
            this.dFieldEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.IsModified = false;
            this.dFieldEdit2.Location = new System.Drawing.Point(24, 77);
            this.dFieldEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit2.MaxValue = 100D;
            this.dFieldEdit2.MinValue = 10D;
            this.dFieldEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit2.Name = "dFieldEdit2";
            this.dFieldEdit2.NoChangeInAuto = false;
            this.dFieldEdit2.Size = new System.Drawing.Size(326, 29);
            this.dFieldEdit2.StepValue = 0D;
            this.dFieldEdit2.TabIndex = 7;
            this.dFieldEdit2.Unit = "%";
            this.dFieldEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.UnitWidth = 60;
            this.dFieldEdit2.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dCheckBox2
            // 
            this.dCheckBox2.AutoSize = true;
            this.dCheckBox2.BackColor = System.Drawing.SystemColors.Control;
            this.dCheckBox2.DataName = "bNoneStopTest";
            this.dCheckBox2.DataSource = this.OptionDS;
            this.dCheckBox2.DefaultValue = false;
            this.dCheckBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dCheckBox2.IsModified = false;
            this.dCheckBox2.Location = new System.Drawing.Point(122, 138);
            this.dCheckBox2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dCheckBox2.Name = "dCheckBox2";
            this.dCheckBox2.NoChangeInAuto = true;
            this.dCheckBox2.Size = new System.Drawing.Size(144, 24);
            this.dCheckBox2.TabIndex = 13;
            this.dCheckBox2.Text = "None Stop Test";
            this.dCheckBox2.UseVisualStyleBackColor = true;
            // 
            // dFieldEdit1
            // 
            this.dFieldEdit1.AutoFocus = false;
            this.dFieldEdit1.Caption = "自動登出時間";
            this.dFieldEdit1.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit1.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit1.DataName = "iAutoLogoutTime_Min";
            this.dFieldEdit1.DataSource = this.OptionDS;
            this.dFieldEdit1.DefaultValue = "1";
            this.dFieldEdit1.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit1.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.EditWidth = 100;
            this.dFieldEdit1.FieldValue = "0";
            this.dFieldEdit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit1.IsModified = false;
            this.dFieldEdit1.Location = new System.Drawing.Point(24, 106);
            this.dFieldEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit1.MaxValue = 100000D;
            this.dFieldEdit1.MinValue = 1D;
            this.dFieldEdit1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit1.Name = "dFieldEdit1";
            this.dFieldEdit1.NoChangeInAuto = false;
            this.dFieldEdit1.Size = new System.Drawing.Size(326, 29);
            this.dFieldEdit1.StepValue = 0D;
            this.dFieldEdit1.TabIndex = 65;
            this.dFieldEdit1.Unit = "min";
            this.dFieldEdit1.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.UnitWidth = 60;
            this.dFieldEdit1.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dRadioGroupBox3
            // 
            this.dRadioGroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.dRadioGroupBox3.ColCount = 1;
            this.dRadioGroupBox3.DataName = "LeftArmMode";
            this.dRadioGroupBox3.DataSource = this.OptionDS;
            this.dRadioGroupBox3.DefaultValue = 0;
            this.dRadioGroupBox3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.dRadioGroupBox3.IsModified = false;
            this.dRadioGroupBox3.ItemFont = new System.Drawing.Font("微軟正黑體", 12F);
            this.dRadioGroupBox3.ItemHeight = 30;
            this.dRadioGroupBox3.ItemLeft = 10;
            this.dRadioGroupBox3.ItemTop = 30;
            this.dRadioGroupBox3.ItemWidth = 100;
            this.dRadioGroupBox3.Location = new System.Drawing.Point(24, 168);
            this.dRadioGroupBox3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dRadioGroupBox3.Name = "dRadioGroupBox3";
            this.dRadioGroupBox3.NoChangeInAuto = true;
            this.dRadioGroupBox3.RadioItems = ((System.Collections.Generic.List<string>)(resources.GetObject("dRadioGroupBox3.RadioItems")));
            this.dRadioGroupBox3.Size = new System.Drawing.Size(200, 118);
            this.dRadioGroupBox3.TabIndex = 67;
            this.dRadioGroupBox3.TabStop = false;
            this.dRadioGroupBox3.Text = "左站手臂模式";
            // 
            // dRadioGroupBox1
            // 
            this.dRadioGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.dRadioGroupBox1.ColCount = 1;
            this.dRadioGroupBox1.DataName = "RightArmMode";
            this.dRadioGroupBox1.DataSource = this.OptionDS;
            this.dRadioGroupBox1.DefaultValue = 0;
            this.dRadioGroupBox1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.dRadioGroupBox1.IsModified = false;
            this.dRadioGroupBox1.ItemFont = new System.Drawing.Font("微軟正黑體", 12F);
            this.dRadioGroupBox1.ItemHeight = 30;
            this.dRadioGroupBox1.ItemLeft = 10;
            this.dRadioGroupBox1.ItemTop = 30;
            this.dRadioGroupBox1.ItemWidth = 100;
            this.dRadioGroupBox1.Location = new System.Drawing.Point(230, 168);
            this.dRadioGroupBox1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dRadioGroupBox1.Name = "dRadioGroupBox1";
            this.dRadioGroupBox1.NoChangeInAuto = true;
            this.dRadioGroupBox1.RadioItems = ((System.Collections.Generic.List<string>)(resources.GetObject("dRadioGroupBox1.RadioItems")));
            this.dRadioGroupBox1.Size = new System.Drawing.Size(200, 118);
            this.dRadioGroupBox1.TabIndex = 68;
            this.dRadioGroupBox1.TabStop = false;
            this.dRadioGroupBox1.Text = "左站手臂模式";
            // 
            // OptionF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1229, 730);
            this.Controls.Add(this.dRadioGroupBox1);
            this.Controls.Add(this.dRadioGroupBox3);
            this.Controls.Add(this.dFieldEdit1);
            this.Controls.Add(this.dCheckBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dComboBox1);
            this.Controls.Add(this.dCheckBox1);
            this.Controls.Add(this.dFieldEdit2);
            this.Name = "OptionF";
            this.Controls.SetChildIndex(this.dFieldEdit2, 0);
            this.Controls.SetChildIndex(this.dCheckBox1, 0);
            this.Controls.SetChildIndex(this.dComboBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dCheckBox2, 0);
            this.Controls.SetChildIndex(this.dFieldEdit1, 0);
            this.Controls.SetChildIndex(this.dRadioGroupBox3, 0);
            this.Controls.SetChildIndex(this.dRadioGroupBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KCSDK.DCheckBox dCheckBox1;
        private KCSDK.DFieldEdit dFieldEdit2;
        private System.Windows.Forms.Label label2;
        private KCSDK.DComboBox dComboBox1;
        private KCSDK.DCheckBox dCheckBox2;
        private KCSDK.DFieldEdit dFieldEdit1;
        private KCSDK.DRadioGroupBox dRadioGroupBox3;
        private KCSDK.DRadioGroupBox dRadioGroupBox1;
    }
}