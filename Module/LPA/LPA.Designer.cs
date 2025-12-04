namespace LPA
{
    partial class LPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LPA));
            ProVLib.MotorParam motorParam2 = new ProVLib.MotorParam();
            this.tpLock_Unlock = new System.Windows.Forms.TabPage();
            this.FC_Auto_Unlock_Next_1 = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_ClampZUp = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_ClampYRelease = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_ClampZDown = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_Done = new ProVLib.FlowChart();
            this.FC_Auto_Unlock_Next_2 = new ProVLib.FlowChart();
            this.FC_Auto_Lock_Next_1 = new ProVLib.FlowChart();
            this.FC_Auto_Lock_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_Lock_ClampZUp = new ProVLib.FlowChart();
            this.FC_Auto_Lock_ClampYClamp = new ProVLib.FlowChart();
            this.FC_Auto_Lock_ClampZDown = new ProVLib.FlowChart();
            this.FC_Auto_Lock_Down = new ProVLib.FlowChart();
            this.FC_Auto_Lock_Next_2 = new ProVLib.FlowChart();
            this.FC_UNLOCK_START = new ProVLib.FlowChart();
            this.FC_LOCK_START = new ProVLib.FlowChart();
            this.tpOpen_Close = new System.Windows.Forms.TabPage();
            this.FC_SCAN_NEXT_2 = new ProVLib.FlowChart();
            this.FC_SCAN_NEXT_1 = new ProVLib.FlowChart();
            this.FC_SCAN_ListAddPos = new ProVLib.FlowChart();
            this.FC_SCAN_IsScanFlagDoit = new ProVLib.FlowChart();
            this.FC_SCAN_START = new ProVLib.FlowChart();
            this.FC_Auto_Open_CalculationResult = new ProVLib.FlowChart();
            this.FC_Auto_Open_Next_4 = new ProVLib.FlowChart();
            this.FC_Auto_Open_Next_3 = new ProVLib.FlowChart();
            this.FC_Auto_Open_Next_2 = new ProVLib.FlowChart();
            this.FC_Auto_Open_Next_1 = new ProVLib.FlowChart();
            this.FC_Auto_Open_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_Open_CheckType = new ProVLib.FlowChart();
            this.FC_Auto_Open_CheckNoCover = new ProVLib.FlowChart();
            this.FC_Auto_Open_LatchKeyOff = new ProVLib.FlowChart();
            this.FC_Auto_Open_TableForward = new ProVLib.FlowChart();
            this.FC_Auto_Open_VaccumOn = new ProVLib.FlowChart();
            this.FC_Auto_Open_CoverDetect = new ProVLib.FlowChart();
            this.FC_Auto_Open_LatchKeyOn = new ProVLib.FlowChart();
            this.FC_Auto_Open_DoorYPush = new ProVLib.FlowChart();
            this.FC_Auto_Open_FristConvexDetect = new ProVLib.FlowChart();
            this.FC_Auto_Open_MoveZtoFirstPos = new ProVLib.FlowChart();
            this.FC_Auto_Open_MappingCylinderOn = new ProVLib.FlowChart();
            this.FC_Auto_Open_MoveZtoSecondPos = new ProVLib.FlowChart();
            this.FC_Auto_Open_MappingCylinderOff = new ProVLib.FlowChart();
            this.FC_Auto_Open_MoveZtoWaitingPos = new ProVLib.FlowChart();
            this.FC_Auto_Open_DoorZDown = new ProVLib.FlowChart();
            this.FC_Auto_Open_ConvexCyOn = new ProVLib.FlowChart();
            this.FC_Auto_Open_2ndConvexDetect = new ProVLib.FlowChart();
            this.FC_Auto_Open_ConvexCyOff = new ProVLib.FlowChart();
            this.FC_Auto_Open_Done = new ProVLib.FlowChart();
            this.FC_Convex_Cylinder_Next = new ProVLib.FlowChart();
            this.FC_Convex_Cylinder_WaitCmd = new ProVLib.FlowChart();
            this.flowChart1 = new ProVLib.FlowChart();
            this.flowChart2 = new ProVLib.FlowChart();
            this.flowChart3 = new ProVLib.FlowChart();
            this.FC_Convex_Cylinder_Done = new ProVLib.FlowChart();
            this.FC_Convex_Cylinder_START = new ProVLib.FlowChart();
            this.button2 = new System.Windows.Forms.Button();
            this.FC_Auto_Close_DestoryOff = new ProVLib.FlowChart();
            this.FC_Auto_Close_Done = new ProVLib.FlowChart();
            this.FC_Auto_Close_Next_2 = new ProVLib.FlowChart();
            this.FC_Auto_Close_Next_1 = new ProVLib.FlowChart();
            this.FC_Auto_Close_WaitCmd = new ProVLib.FlowChart();
            this.FC_Auto_Close_ConvexCyOff = new ProVLib.FlowChart();
            this.FC_Auto_Close_DoorYPush = new ProVLib.FlowChart();
            this.FC_Auto_Close_VaccumOn = new ProVLib.FlowChart();
            this.FC_Auto_Close_CoverDetect = new ProVLib.FlowChart();
            this.FC_Auto_Close_CheckHasFoup = new ProVLib.FlowChart();
            this.FC_Auto_Close_CheckPlacement = new ProVLib.FlowChart();
            this.FC_Auto_Close_DoorZUp = new ProVLib.FlowChart();
            this.FC_Auto_Close_DoorYPull = new ProVLib.FlowChart();
            this.FC_Auto_Close_2ndVaccumOff = new ProVLib.FlowChart();
            this.FC_Auto_Close_LatchKeyOff = new ProVLib.FlowChart();
            this.FC_Auto_Close_DestoryOn = new ProVLib.FlowChart();
            this.FC_Auto_Close_TablePull = new ProVLib.FlowChart();
            this.FC_Auto_Close_VaccumOff = new ProVLib.FlowChart();
            this.FC_CLOSE_START = new ProVLib.FlowChart();
            this.FC_OPEN_START = new ProVLib.FlowChart();
            this.FC_Home_LockDone = new ProVLib.FlowChart();
            this.FC_Home_DoClose = new ProVLib.FlowChart();
            this.FC_Home_CloseDone = new ProVLib.FlowChart();
            this.FC_Home_DoUnlock = new ProVLib.FlowChart();
            this.FC_Home_UnlockDone = new ProVLib.FlowChart();
            this.FC_Home_Done = new ProVLib.FlowChart();
            this.FC_Home_DoLock = new ProVLib.FlowChart();
            this.FC_Home_CheckHasCassette = new ProVLib.FlowChart();
            this.FC_Home_WaitCmd = new ProVLib.FlowChart();
            this.FC_HOME_START = new ProVLib.FlowChart();
            this.tpInputID = new System.Windows.Forms.TabPage();
            this.FC_InputID_DoInputID = new ProVLib.FlowChart();
            this.FC_InputID_Done = new ProVLib.FlowChart();
            this.FC_InputID_Next_2 = new ProVLib.FlowChart();
            this.FC_InputID_Next_1 = new ProVLib.FlowChart();
            this.FC_InputID_WaitCmd = new ProVLib.FlowChart();
            this.FC_INPUTID_START = new ProVLib.FlowChart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dFieldEdit31 = new KCSDK.DFieldEdit();
            this.dFieldEdit1 = new KCSDK.DFieldEdit();
            this.dFieldEdit3 = new KCSDK.DFieldEdit();
            this.dFieldEdit2 = new KCSDK.DFieldEdit();
            this.dFieldEdit4 = new KCSDK.DFieldEdit();
            this.dFieldEdit5 = new KCSDK.DFieldEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.ib_InfoPad_LeftTop = new ProVLib.InBit();
            this.ib_InfoPad_LeftDown = new ProVLib.InBit();
            this.ib_InfoPad_RightDown = new ProVLib.InBit();
            this.ib_InfoPad_RightTop = new ProVLib.InBit();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ib_Table_Out = new ProVLib.InBit();
            this.ib_Table_Back = new ProVLib.InBit();
            this.ob_Table_Out = new ProVLib.OutBit();
            this.ob_Table_Back = new ProVLib.OutBit();
            this.btn_Table_SW = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ib_ClampY_Clamp = new ProVLib.InBit();
            this.ib_ClampY_Release = new ProVLib.InBit();
            this.ob_ClampY_Clamp = new ProVLib.OutBit();
            this.ob_ClampY_Release = new ProVLib.OutBit();
            this.btn_ClampY_SW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ib_ClampZ_Up = new ProVLib.InBit();
            this.ib_ClampZ_Down = new ProVLib.InBit();
            this.ob_ClampZ_Up = new ProVLib.OutBit();
            this.ob_ClampZ_Down = new ProVLib.OutBit();
            this.btn_ClampZ_SW = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.ib_PlaceDetect_Left = new ProVLib.InBit();
            this.ib_PlaceDetect_Right = new ProVLib.InBit();
            this.ib_PlaceDetect_Down = new ProVLib.InBit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.ib_Inch8CstClamp_On = new ProVLib.InBit();
            this.ib_Inch8CstClamp_Off = new ProVLib.InBit();
            this.ob_Inch8CstClamp_Lock = new ProVLib.OutBit();
            this.ob_Inch8CstClamp_Unlock = new ProVLib.OutBit();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.ib_8Inch = new ProVLib.InBit();
            this.ib_8Inch_2 = new ProVLib.InBit();
            this.ib_Cassette = new ProVLib.InBit();
            this.ib_Foup = new ProVLib.InBit();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.ib_ManualButton = new ProVLib.InBit();
            this.ob_ManualButton_Light = new ProVLib.OutBit();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.ib_VaccumDetect = new ProVLib.InBit();
            this.ob_Vaccum = new ProVLib.OutBit();
            this.ob_Destory = new ProVLib.OutBit();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ib_DoorY_Out = new ProVLib.InBit();
            this.ib_DoorY_Back = new ProVLib.InBit();
            this.ob_DoorY_Out = new ProVLib.OutBit();
            this.ob_DoorY_Back = new ProVLib.OutBit();
            this.btn_DoorY_SW = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MT_DoorZ = new ProVLib.Motor();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.IB_MappingCY_On = new ProVLib.InBit();
            this.IB_MappingCY_Off = new ProVLib.InBit();
            this.OB_MappingCY_Push = new ProVLib.OutBit();
            this.OB_MappingCY_Pull = new ProVLib.OutBit();
            this.button4 = new System.Windows.Forms.Button();
            this.IB_Wafer_Mapping_Sensor = new ProVLib.InBit();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.ob_Alarm_Light = new ProVLib.OutBit();
            this.ob_Load_Light = new ProVLib.OutBit();
            this.ob_Unload_Light = new ProVLib.OutBit();
            this.ob_Placement_Light = new ProVLib.OutBit();
            this.ob_Manual_Light = new ProVLib.OutBit();
            this.ob_Auto_Light = new ProVLib.OutBit();
            this.ob_Presense_Light = new ProVLib.OutBit();
            this.ob_Reserve_Light = new ProVLib.OutBit();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.ib_Convex_Out = new ProVLib.InBit();
            this.ib_Convex_Back = new ProVLib.InBit();
            this.ob_Convex_Out = new ProVLib.OutBit();
            this.ob_Convex_Back = new ProVLib.OutBit();
            this.btn_Convex_SW = new System.Windows.Forms.Button();
            this.ib_ConvexDetect = new ProVLib.InBit();
            this.ib_ArmDetect = new ProVLib.InBit();
            this.ib_CoverDetect = new ProVLib.InBit();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.ib_Latch_Lock = new ProVLib.InBit();
            this.ib_Latch_Unlock = new ProVLib.InBit();
            this.ob_Latch_Lock = new ProVLib.OutBit();
            this.ob_Latch_Unlock = new ProVLib.OutBit();
            this.btn_Latch_SW = new System.Windows.Forms.Button();
            this.dPosEdit13 = new KCSDK.DPosEdit();
            this.dPosEdit4 = new KCSDK.DPosEdit();
            this.dPosEdit3 = new KCSDK.DPosEdit();
            this.dPosEdit1 = new KCSDK.DPosEdit();
            this.dPosEdit2 = new KCSDK.DPosEdit();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dFieldEdit22 = new KCSDK.DFieldEdit();
            this.dFieldEdit10 = new KCSDK.DFieldEdit();
            this.dFieldEdit11 = new KCSDK.DFieldEdit();
            this.dRadioGroupBox3 = new KCSDK.DRadioGroupBox();
            this.tabMain.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tpPosition.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.tpFlow.SuspendLayout();
            this.tpSuperSetting.SuspendLayout();
            this.TabFlow.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpCheck.SuspendLayout();
            this.tpLock_Unlock.SuspendLayout();
            this.tpOpen_Close.SuspendLayout();
            this.tpInputID.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(1370, 750);
            // 
            // tpControl
            // 
            this.tpControl.Controls.Add(this.tabControl1);
            this.tpControl.Size = new System.Drawing.Size(1362, 682);
            // 
            // tpPosition
            // 
            this.tpPosition.Controls.Add(this.dPosEdit13);
            this.tpPosition.Controls.Add(this.dPosEdit4);
            this.tpPosition.Controls.Add(this.dPosEdit3);
            this.tpPosition.Controls.Add(this.dPosEdit1);
            this.tpPosition.Controls.Add(this.dPosEdit2);
            this.tpPosition.Controls.SetChildIndex(this.dPosEdit2, 0);
            this.tpPosition.Controls.SetChildIndex(this.dPosEdit1, 0);
            this.tpPosition.Controls.SetChildIndex(this.dPosEdit3, 0);
            this.tpPosition.Controls.SetChildIndex(this.dPosEdit4, 0);
            this.tpPosition.Controls.SetChildIndex(this.dPosEdit13, 0);
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.flowLayoutPanel2);
            this.tpSetting.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            // 
            // tpFlow
            // 
            this.tpFlow.Size = new System.Drawing.Size(1362, 682);
            // 
            // tpSuperSetting
            // 
            this.tpSuperSetting.Controls.Add(this.dRadioGroupBox3);
            this.tpSuperSetting.Controls.Add(this.groupBox7);
            this.tpSuperSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpSuperSetting.Size = new System.Drawing.Size(1362, 682);
            this.tpSuperSetting.Controls.SetChildIndex(this.groupBox7, 0);
            this.tpSuperSetting.Controls.SetChildIndex(this.dRadioGroupBox3, 0);
            // 
            // TabFlow
            // 
            this.TabFlow.Controls.Add(this.tpLock_Unlock);
            this.TabFlow.Controls.Add(this.tpOpen_Close);
            this.TabFlow.Controls.Add(this.tpInputID);
            this.TabFlow.Size = new System.Drawing.Size(1358, 678);
            this.TabFlow.Controls.SetChildIndex(this.tpAuto, 0);
            this.TabFlow.Controls.SetChildIndex(this.tpCheck, 0);
            this.TabFlow.Controls.SetChildIndex(this.tpInputID, 0);
            this.TabFlow.Controls.SetChildIndex(this.tpOpen_Close, 0);
            this.TabFlow.Controls.SetChildIndex(this.tpLock_Unlock, 0);
            this.TabFlow.Controls.SetChildIndex(this.tpHome, 0);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.FC_Home_LockDone);
            this.tpHome.Controls.Add(this.FC_Home_DoLock);
            this.tpHome.Controls.Add(this.FC_Home_CheckHasCassette);
            this.tpHome.Controls.Add(this.FC_Home_DoUnlock);
            this.tpHome.Controls.Add(this.FC_Home_CloseDone);
            this.tpHome.Controls.Add(this.FC_Home_DoClose);
            this.tpHome.Controls.Add(this.FC_Home_UnlockDone);
            this.tpHome.Controls.Add(this.FC_Home_Done);
            this.tpHome.Controls.Add(this.FC_Home_WaitCmd);
            this.tpHome.Controls.Add(this.FC_HOME_START);
            this.tpHome.Size = new System.Drawing.Size(1350, 636);
            // 
            // tpLock_Unlock
            // 
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_Next_1);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_Next_2);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_Done);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_ClampZDown);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_ClampYRelease);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_ClampZUp);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_Next_1);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_Next_2);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_Down);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_ClampZDown);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_ClampYClamp);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_ClampZUp);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Unlock_WaitCmd);
            this.tpLock_Unlock.Controls.Add(this.FC_Auto_Lock_WaitCmd);
            this.tpLock_Unlock.Controls.Add(this.FC_UNLOCK_START);
            this.tpLock_Unlock.Controls.Add(this.FC_LOCK_START);
            this.tpLock_Unlock.Location = new System.Drawing.Point(4, 38);
            this.tpLock_Unlock.Name = "tpLock_Unlock";
            this.tpLock_Unlock.Size = new System.Drawing.Size(948, 496);
            this.tpLock_Unlock.TabIndex = 2;
            this.tpLock_Unlock.Text = "Lock/Unlock";
            this.tpLock_Unlock.UseVisualStyleBackColor = true;
            // 
            // FC_Auto_Unlock_Next_1
            // 
            this.FC_Auto_Unlock_Next_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_Next_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_Next_1.CASE1 = null;
            this.FC_Auto_Unlock_Next_1.CASE2 = null;
            this.FC_Auto_Unlock_Next_1.CASE3 = null;
            this.FC_Auto_Unlock_Next_1.CASE4 = null;
            this.FC_Auto_Unlock_Next_1.ContinueRun = false;
            this.FC_Auto_Unlock_Next_1.DesignTimeParent = null;
            this.FC_Auto_Unlock_Next_1.EndFC = null;
            this.FC_Auto_Unlock_Next_1.ErrID = 0;
            this.FC_Auto_Unlock_Next_1.InAlarm = false;
            this.FC_Auto_Unlock_Next_1.IsFlowHead = false;
            this.FC_Auto_Unlock_Next_1.Location = new System.Drawing.Point(654, 68);
            this.FC_Auto_Unlock_Next_1.LockUI = false;
            this.FC_Auto_Unlock_Next_1.Message = null;
            this.FC_Auto_Unlock_Next_1.MsgID = 0;
            this.FC_Auto_Unlock_Next_1.Name = "FC_Auto_Unlock_Next_1";
            this.FC_Auto_Unlock_Next_1.NEXT = this.FC_Auto_Unlock_WaitCmd;
            this.FC_Auto_Unlock_Next_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_Next_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_Next_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_Next_1.OverTimeSpec = 100;
            this.FC_Auto_Unlock_Next_1.Running = false;
            this.FC_Auto_Unlock_Next_1.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Unlock_Next_1.SlowRunCycle = -1;
            this.FC_Auto_Unlock_Next_1.StartFC = null;
            this.FC_Auto_Unlock_Next_1.Text = "N";
            this.FC_Auto_Unlock_Next_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_Next_1_Run);
            // 
            // FC_Auto_Unlock_WaitCmd
            // 
            this.FC_Auto_Unlock_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_WaitCmd.CASE1 = null;
            this.FC_Auto_Unlock_WaitCmd.CASE2 = null;
            this.FC_Auto_Unlock_WaitCmd.CASE3 = null;
            this.FC_Auto_Unlock_WaitCmd.CASE4 = null;
            this.FC_Auto_Unlock_WaitCmd.ContinueRun = false;
            this.FC_Auto_Unlock_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_Unlock_WaitCmd.EndFC = null;
            this.FC_Auto_Unlock_WaitCmd.ErrID = 0;
            this.FC_Auto_Unlock_WaitCmd.InAlarm = false;
            this.FC_Auto_Unlock_WaitCmd.IsFlowHead = false;
            this.FC_Auto_Unlock_WaitCmd.Location = new System.Drawing.Point(426, 68);
            this.FC_Auto_Unlock_WaitCmd.LockUI = false;
            this.FC_Auto_Unlock_WaitCmd.Message = null;
            this.FC_Auto_Unlock_WaitCmd.MsgID = 0;
            this.FC_Auto_Unlock_WaitCmd.Name = "FC_Auto_Unlock_WaitCmd";
            this.FC_Auto_Unlock_WaitCmd.NEXT = this.FC_Auto_Unlock_ClampZUp;
            this.FC_Auto_Unlock_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_Unlock_WaitCmd.Running = false;
            this.FC_Auto_Unlock_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Unlock_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_Unlock_WaitCmd.StartFC = null;
            this.FC_Auto_Unlock_WaitCmd.Text = "Wait Command";
            this.FC_Auto_Unlock_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_WaitCmd_Run);
            // 
            // FC_Auto_Unlock_ClampZUp
            // 
            this.FC_Auto_Unlock_ClampZUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_ClampZUp.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_ClampZUp.CASE1 = null;
            this.FC_Auto_Unlock_ClampZUp.CASE2 = null;
            this.FC_Auto_Unlock_ClampZUp.CASE3 = null;
            this.FC_Auto_Unlock_ClampZUp.CASE4 = null;
            this.FC_Auto_Unlock_ClampZUp.ContinueRun = false;
            this.FC_Auto_Unlock_ClampZUp.DesignTimeParent = null;
            this.FC_Auto_Unlock_ClampZUp.EndFC = null;
            this.FC_Auto_Unlock_ClampZUp.ErrID = 0;
            this.FC_Auto_Unlock_ClampZUp.InAlarm = false;
            this.FC_Auto_Unlock_ClampZUp.IsFlowHead = false;
            this.FC_Auto_Unlock_ClampZUp.Location = new System.Drawing.Point(426, 106);
            this.FC_Auto_Unlock_ClampZUp.LockUI = false;
            this.FC_Auto_Unlock_ClampZUp.Message = null;
            this.FC_Auto_Unlock_ClampZUp.MsgID = 0;
            this.FC_Auto_Unlock_ClampZUp.Name = "FC_Auto_Unlock_ClampZUp";
            this.FC_Auto_Unlock_ClampZUp.NEXT = this.FC_Auto_Unlock_ClampYRelease;
            this.FC_Auto_Unlock_ClampZUp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_ClampZUp.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_ClampZUp.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_ClampZUp.OverTimeSpec = 100;
            this.FC_Auto_Unlock_ClampZUp.Running = false;
            this.FC_Auto_Unlock_ClampZUp.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Unlock_ClampZUp.SlowRunCycle = -1;
            this.FC_Auto_Unlock_ClampZUp.StartFC = null;
            this.FC_Auto_Unlock_ClampZUp.Text = "Clamp Z Up";
            this.FC_Auto_Unlock_ClampZUp.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_ClampZUp_Run);
            // 
            // FC_Auto_Unlock_ClampYRelease
            // 
            this.FC_Auto_Unlock_ClampYRelease.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_ClampYRelease.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_ClampYRelease.CASE1 = null;
            this.FC_Auto_Unlock_ClampYRelease.CASE2 = null;
            this.FC_Auto_Unlock_ClampYRelease.CASE3 = null;
            this.FC_Auto_Unlock_ClampYRelease.CASE4 = null;
            this.FC_Auto_Unlock_ClampYRelease.ContinueRun = false;
            this.FC_Auto_Unlock_ClampYRelease.DesignTimeParent = null;
            this.FC_Auto_Unlock_ClampYRelease.EndFC = null;
            this.FC_Auto_Unlock_ClampYRelease.ErrID = 0;
            this.FC_Auto_Unlock_ClampYRelease.InAlarm = false;
            this.FC_Auto_Unlock_ClampYRelease.IsFlowHead = false;
            this.FC_Auto_Unlock_ClampYRelease.Location = new System.Drawing.Point(426, 144);
            this.FC_Auto_Unlock_ClampYRelease.LockUI = false;
            this.FC_Auto_Unlock_ClampYRelease.Message = null;
            this.FC_Auto_Unlock_ClampYRelease.MsgID = 0;
            this.FC_Auto_Unlock_ClampYRelease.Name = "FC_Auto_Unlock_ClampYRelease";
            this.FC_Auto_Unlock_ClampYRelease.NEXT = this.FC_Auto_Unlock_ClampZDown;
            this.FC_Auto_Unlock_ClampYRelease.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_ClampYRelease.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_ClampYRelease.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_ClampYRelease.OverTimeSpec = 100;
            this.FC_Auto_Unlock_ClampYRelease.Running = false;
            this.FC_Auto_Unlock_ClampYRelease.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Unlock_ClampYRelease.SlowRunCycle = -1;
            this.FC_Auto_Unlock_ClampYRelease.StartFC = null;
            this.FC_Auto_Unlock_ClampYRelease.Text = "Clamp Y Release";
            this.FC_Auto_Unlock_ClampYRelease.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_ClampYRelease_Run);
            // 
            // FC_Auto_Unlock_ClampZDown
            // 
            this.FC_Auto_Unlock_ClampZDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_ClampZDown.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_ClampZDown.CASE1 = null;
            this.FC_Auto_Unlock_ClampZDown.CASE2 = null;
            this.FC_Auto_Unlock_ClampZDown.CASE3 = null;
            this.FC_Auto_Unlock_ClampZDown.CASE4 = null;
            this.FC_Auto_Unlock_ClampZDown.ContinueRun = false;
            this.FC_Auto_Unlock_ClampZDown.DesignTimeParent = null;
            this.FC_Auto_Unlock_ClampZDown.EndFC = null;
            this.FC_Auto_Unlock_ClampZDown.ErrID = 0;
            this.FC_Auto_Unlock_ClampZDown.InAlarm = false;
            this.FC_Auto_Unlock_ClampZDown.IsFlowHead = false;
            this.FC_Auto_Unlock_ClampZDown.Location = new System.Drawing.Point(426, 182);
            this.FC_Auto_Unlock_ClampZDown.LockUI = false;
            this.FC_Auto_Unlock_ClampZDown.Message = null;
            this.FC_Auto_Unlock_ClampZDown.MsgID = 0;
            this.FC_Auto_Unlock_ClampZDown.Name = "FC_Auto_Unlock_ClampZDown";
            this.FC_Auto_Unlock_ClampZDown.NEXT = this.FC_Auto_Unlock_Done;
            this.FC_Auto_Unlock_ClampZDown.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_ClampZDown.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_ClampZDown.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_ClampZDown.OverTimeSpec = 100;
            this.FC_Auto_Unlock_ClampZDown.Running = false;
            this.FC_Auto_Unlock_ClampZDown.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Unlock_ClampZDown.SlowRunCycle = -1;
            this.FC_Auto_Unlock_ClampZDown.StartFC = null;
            this.FC_Auto_Unlock_ClampZDown.Text = "Clamp Z Down";
            this.FC_Auto_Unlock_ClampZDown.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_ClampZDown_Run);
            // 
            // FC_Auto_Unlock_Done
            // 
            this.FC_Auto_Unlock_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_Done.CASE1 = null;
            this.FC_Auto_Unlock_Done.CASE2 = null;
            this.FC_Auto_Unlock_Done.CASE3 = null;
            this.FC_Auto_Unlock_Done.CASE4 = null;
            this.FC_Auto_Unlock_Done.ContinueRun = false;
            this.FC_Auto_Unlock_Done.DesignTimeParent = null;
            this.FC_Auto_Unlock_Done.EndFC = null;
            this.FC_Auto_Unlock_Done.ErrID = 0;
            this.FC_Auto_Unlock_Done.InAlarm = false;
            this.FC_Auto_Unlock_Done.IsFlowHead = false;
            this.FC_Auto_Unlock_Done.Location = new System.Drawing.Point(426, 220);
            this.FC_Auto_Unlock_Done.LockUI = false;
            this.FC_Auto_Unlock_Done.Message = null;
            this.FC_Auto_Unlock_Done.MsgID = 0;
            this.FC_Auto_Unlock_Done.Name = "FC_Auto_Unlock_Done";
            this.FC_Auto_Unlock_Done.NEXT = this.FC_Auto_Unlock_Next_2;
            this.FC_Auto_Unlock_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_Done.OverTimeSpec = 100;
            this.FC_Auto_Unlock_Done.Running = false;
            this.FC_Auto_Unlock_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Unlock_Done.SlowRunCycle = -1;
            this.FC_Auto_Unlock_Done.StartFC = null;
            this.FC_Auto_Unlock_Done.Text = "Done";
            this.FC_Auto_Unlock_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_Done_Run);
            // 
            // FC_Auto_Unlock_Next_2
            // 
            this.FC_Auto_Unlock_Next_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Unlock_Next_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Unlock_Next_2.CASE1 = null;
            this.FC_Auto_Unlock_Next_2.CASE2 = null;
            this.FC_Auto_Unlock_Next_2.CASE3 = null;
            this.FC_Auto_Unlock_Next_2.CASE4 = null;
            this.FC_Auto_Unlock_Next_2.ContinueRun = false;
            this.FC_Auto_Unlock_Next_2.DesignTimeParent = null;
            this.FC_Auto_Unlock_Next_2.EndFC = null;
            this.FC_Auto_Unlock_Next_2.ErrID = 0;
            this.FC_Auto_Unlock_Next_2.InAlarm = false;
            this.FC_Auto_Unlock_Next_2.IsFlowHead = false;
            this.FC_Auto_Unlock_Next_2.Location = new System.Drawing.Point(654, 220);
            this.FC_Auto_Unlock_Next_2.LockUI = false;
            this.FC_Auto_Unlock_Next_2.Message = null;
            this.FC_Auto_Unlock_Next_2.MsgID = 0;
            this.FC_Auto_Unlock_Next_2.Name = "FC_Auto_Unlock_Next_2";
            this.FC_Auto_Unlock_Next_2.NEXT = this.FC_Auto_Unlock_Next_1;
            this.FC_Auto_Unlock_Next_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Unlock_Next_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Unlock_Next_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Unlock_Next_2.OverTimeSpec = 100;
            this.FC_Auto_Unlock_Next_2.Running = false;
            this.FC_Auto_Unlock_Next_2.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Unlock_Next_2.SlowRunCycle = -1;
            this.FC_Auto_Unlock_Next_2.StartFC = null;
            this.FC_Auto_Unlock_Next_2.Text = "N";
            this.FC_Auto_Unlock_Next_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Unlock_Next_2_Run);
            // 
            // FC_Auto_Lock_Next_1
            // 
            this.FC_Auto_Lock_Next_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_Next_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_Next_1.CASE1 = null;
            this.FC_Auto_Lock_Next_1.CASE2 = null;
            this.FC_Auto_Lock_Next_1.CASE3 = null;
            this.FC_Auto_Lock_Next_1.CASE4 = null;
            this.FC_Auto_Lock_Next_1.ContinueRun = false;
            this.FC_Auto_Lock_Next_1.DesignTimeParent = null;
            this.FC_Auto_Lock_Next_1.EndFC = null;
            this.FC_Auto_Lock_Next_1.ErrID = 0;
            this.FC_Auto_Lock_Next_1.InAlarm = false;
            this.FC_Auto_Lock_Next_1.IsFlowHead = false;
            this.FC_Auto_Lock_Next_1.Location = new System.Drawing.Point(254, 68);
            this.FC_Auto_Lock_Next_1.LockUI = false;
            this.FC_Auto_Lock_Next_1.Message = null;
            this.FC_Auto_Lock_Next_1.MsgID = 0;
            this.FC_Auto_Lock_Next_1.Name = "FC_Auto_Lock_Next_1";
            this.FC_Auto_Lock_Next_1.NEXT = this.FC_Auto_Lock_WaitCmd;
            this.FC_Auto_Lock_Next_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_Next_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_Next_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_Next_1.OverTimeSpec = 100;
            this.FC_Auto_Lock_Next_1.Running = false;
            this.FC_Auto_Lock_Next_1.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Lock_Next_1.SlowRunCycle = -1;
            this.FC_Auto_Lock_Next_1.StartFC = null;
            this.FC_Auto_Lock_Next_1.Text = "N";
            this.FC_Auto_Lock_Next_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_Next_1_Run);
            // 
            // FC_Auto_Lock_WaitCmd
            // 
            this.FC_Auto_Lock_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_WaitCmd.CASE1 = null;
            this.FC_Auto_Lock_WaitCmd.CASE2 = null;
            this.FC_Auto_Lock_WaitCmd.CASE3 = null;
            this.FC_Auto_Lock_WaitCmd.CASE4 = null;
            this.FC_Auto_Lock_WaitCmd.ContinueRun = false;
            this.FC_Auto_Lock_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_Lock_WaitCmd.EndFC = null;
            this.FC_Auto_Lock_WaitCmd.ErrID = 0;
            this.FC_Auto_Lock_WaitCmd.InAlarm = false;
            this.FC_Auto_Lock_WaitCmd.IsFlowHead = false;
            this.FC_Auto_Lock_WaitCmd.Location = new System.Drawing.Point(37, 68);
            this.FC_Auto_Lock_WaitCmd.LockUI = false;
            this.FC_Auto_Lock_WaitCmd.Message = null;
            this.FC_Auto_Lock_WaitCmd.MsgID = 0;
            this.FC_Auto_Lock_WaitCmd.Name = "FC_Auto_Lock_WaitCmd";
            this.FC_Auto_Lock_WaitCmd.NEXT = this.FC_Auto_Lock_ClampZUp;
            this.FC_Auto_Lock_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_Lock_WaitCmd.Running = false;
            this.FC_Auto_Lock_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Lock_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_Lock_WaitCmd.StartFC = null;
            this.FC_Auto_Lock_WaitCmd.Text = "Wait Command";
            this.FC_Auto_Lock_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_WaitCmd_Run);
            // 
            // FC_Auto_Lock_ClampZUp
            // 
            this.FC_Auto_Lock_ClampZUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_ClampZUp.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_ClampZUp.CASE1 = null;
            this.FC_Auto_Lock_ClampZUp.CASE2 = null;
            this.FC_Auto_Lock_ClampZUp.CASE3 = null;
            this.FC_Auto_Lock_ClampZUp.CASE4 = null;
            this.FC_Auto_Lock_ClampZUp.ContinueRun = false;
            this.FC_Auto_Lock_ClampZUp.DesignTimeParent = null;
            this.FC_Auto_Lock_ClampZUp.EndFC = null;
            this.FC_Auto_Lock_ClampZUp.ErrID = 0;
            this.FC_Auto_Lock_ClampZUp.InAlarm = false;
            this.FC_Auto_Lock_ClampZUp.IsFlowHead = false;
            this.FC_Auto_Lock_ClampZUp.Location = new System.Drawing.Point(37, 106);
            this.FC_Auto_Lock_ClampZUp.LockUI = false;
            this.FC_Auto_Lock_ClampZUp.Message = null;
            this.FC_Auto_Lock_ClampZUp.MsgID = 0;
            this.FC_Auto_Lock_ClampZUp.Name = "FC_Auto_Lock_ClampZUp";
            this.FC_Auto_Lock_ClampZUp.NEXT = this.FC_Auto_Lock_ClampYClamp;
            this.FC_Auto_Lock_ClampZUp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_ClampZUp.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_ClampZUp.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_ClampZUp.OverTimeSpec = 100;
            this.FC_Auto_Lock_ClampZUp.Running = false;
            this.FC_Auto_Lock_ClampZUp.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Lock_ClampZUp.SlowRunCycle = -1;
            this.FC_Auto_Lock_ClampZUp.StartFC = null;
            this.FC_Auto_Lock_ClampZUp.Text = "Clamp Z Up";
            this.FC_Auto_Lock_ClampZUp.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_ClampZUp_Run);
            // 
            // FC_Auto_Lock_ClampYClamp
            // 
            this.FC_Auto_Lock_ClampYClamp.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_ClampYClamp.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_ClampYClamp.CASE1 = null;
            this.FC_Auto_Lock_ClampYClamp.CASE2 = null;
            this.FC_Auto_Lock_ClampYClamp.CASE3 = null;
            this.FC_Auto_Lock_ClampYClamp.CASE4 = null;
            this.FC_Auto_Lock_ClampYClamp.ContinueRun = false;
            this.FC_Auto_Lock_ClampYClamp.DesignTimeParent = null;
            this.FC_Auto_Lock_ClampYClamp.EndFC = null;
            this.FC_Auto_Lock_ClampYClamp.ErrID = 0;
            this.FC_Auto_Lock_ClampYClamp.InAlarm = false;
            this.FC_Auto_Lock_ClampYClamp.IsFlowHead = false;
            this.FC_Auto_Lock_ClampYClamp.Location = new System.Drawing.Point(37, 144);
            this.FC_Auto_Lock_ClampYClamp.LockUI = false;
            this.FC_Auto_Lock_ClampYClamp.Message = null;
            this.FC_Auto_Lock_ClampYClamp.MsgID = 0;
            this.FC_Auto_Lock_ClampYClamp.Name = "FC_Auto_Lock_ClampYClamp";
            this.FC_Auto_Lock_ClampYClamp.NEXT = this.FC_Auto_Lock_ClampZDown;
            this.FC_Auto_Lock_ClampYClamp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_ClampYClamp.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_ClampYClamp.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_ClampYClamp.OverTimeSpec = 100;
            this.FC_Auto_Lock_ClampYClamp.Running = false;
            this.FC_Auto_Lock_ClampYClamp.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Lock_ClampYClamp.SlowRunCycle = -1;
            this.FC_Auto_Lock_ClampYClamp.StartFC = null;
            this.FC_Auto_Lock_ClampYClamp.Text = "Clamp Y Clamp";
            this.FC_Auto_Lock_ClampYClamp.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_ClampYClamp_Run);
            // 
            // FC_Auto_Lock_ClampZDown
            // 
            this.FC_Auto_Lock_ClampZDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_ClampZDown.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_ClampZDown.CASE1 = null;
            this.FC_Auto_Lock_ClampZDown.CASE2 = null;
            this.FC_Auto_Lock_ClampZDown.CASE3 = null;
            this.FC_Auto_Lock_ClampZDown.CASE4 = null;
            this.FC_Auto_Lock_ClampZDown.ContinueRun = false;
            this.FC_Auto_Lock_ClampZDown.DesignTimeParent = null;
            this.FC_Auto_Lock_ClampZDown.EndFC = null;
            this.FC_Auto_Lock_ClampZDown.ErrID = 0;
            this.FC_Auto_Lock_ClampZDown.InAlarm = false;
            this.FC_Auto_Lock_ClampZDown.IsFlowHead = false;
            this.FC_Auto_Lock_ClampZDown.Location = new System.Drawing.Point(37, 182);
            this.FC_Auto_Lock_ClampZDown.LockUI = false;
            this.FC_Auto_Lock_ClampZDown.Message = null;
            this.FC_Auto_Lock_ClampZDown.MsgID = 0;
            this.FC_Auto_Lock_ClampZDown.Name = "FC_Auto_Lock_ClampZDown";
            this.FC_Auto_Lock_ClampZDown.NEXT = this.FC_Auto_Lock_Down;
            this.FC_Auto_Lock_ClampZDown.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_ClampZDown.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_ClampZDown.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_ClampZDown.OverTimeSpec = 100;
            this.FC_Auto_Lock_ClampZDown.Running = false;
            this.FC_Auto_Lock_ClampZDown.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Lock_ClampZDown.SlowRunCycle = -1;
            this.FC_Auto_Lock_ClampZDown.StartFC = null;
            this.FC_Auto_Lock_ClampZDown.Text = "Clamp Z Down";
            this.FC_Auto_Lock_ClampZDown.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_ClampZDown_Run);
            // 
            // FC_Auto_Lock_Down
            // 
            this.FC_Auto_Lock_Down.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_Down.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_Down.CASE1 = null;
            this.FC_Auto_Lock_Down.CASE2 = null;
            this.FC_Auto_Lock_Down.CASE3 = null;
            this.FC_Auto_Lock_Down.CASE4 = null;
            this.FC_Auto_Lock_Down.ContinueRun = false;
            this.FC_Auto_Lock_Down.DesignTimeParent = null;
            this.FC_Auto_Lock_Down.EndFC = null;
            this.FC_Auto_Lock_Down.ErrID = 0;
            this.FC_Auto_Lock_Down.InAlarm = false;
            this.FC_Auto_Lock_Down.IsFlowHead = false;
            this.FC_Auto_Lock_Down.Location = new System.Drawing.Point(37, 220);
            this.FC_Auto_Lock_Down.LockUI = false;
            this.FC_Auto_Lock_Down.Message = null;
            this.FC_Auto_Lock_Down.MsgID = 0;
            this.FC_Auto_Lock_Down.Name = "FC_Auto_Lock_Down";
            this.FC_Auto_Lock_Down.NEXT = this.FC_Auto_Lock_Next_2;
            this.FC_Auto_Lock_Down.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_Down.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_Down.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_Down.OverTimeSpec = 100;
            this.FC_Auto_Lock_Down.Running = false;
            this.FC_Auto_Lock_Down.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Lock_Down.SlowRunCycle = -1;
            this.FC_Auto_Lock_Down.StartFC = null;
            this.FC_Auto_Lock_Down.Text = "Done";
            this.FC_Auto_Lock_Down.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_Down_Run);
            // 
            // FC_Auto_Lock_Next_2
            // 
            this.FC_Auto_Lock_Next_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Lock_Next_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Lock_Next_2.CASE1 = null;
            this.FC_Auto_Lock_Next_2.CASE2 = null;
            this.FC_Auto_Lock_Next_2.CASE3 = null;
            this.FC_Auto_Lock_Next_2.CASE4 = null;
            this.FC_Auto_Lock_Next_2.ContinueRun = false;
            this.FC_Auto_Lock_Next_2.DesignTimeParent = null;
            this.FC_Auto_Lock_Next_2.EndFC = null;
            this.FC_Auto_Lock_Next_2.ErrID = 0;
            this.FC_Auto_Lock_Next_2.InAlarm = false;
            this.FC_Auto_Lock_Next_2.IsFlowHead = false;
            this.FC_Auto_Lock_Next_2.Location = new System.Drawing.Point(254, 220);
            this.FC_Auto_Lock_Next_2.LockUI = false;
            this.FC_Auto_Lock_Next_2.Message = null;
            this.FC_Auto_Lock_Next_2.MsgID = 0;
            this.FC_Auto_Lock_Next_2.Name = "FC_Auto_Lock_Next_2";
            this.FC_Auto_Lock_Next_2.NEXT = this.FC_Auto_Lock_Next_1;
            this.FC_Auto_Lock_Next_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Lock_Next_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Lock_Next_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Lock_Next_2.OverTimeSpec = 100;
            this.FC_Auto_Lock_Next_2.Running = false;
            this.FC_Auto_Lock_Next_2.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Lock_Next_2.SlowRunCycle = -1;
            this.FC_Auto_Lock_Next_2.StartFC = null;
            this.FC_Auto_Lock_Next_2.Text = "N";
            this.FC_Auto_Lock_Next_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Lock_Next_2_Run);
            // 
            // FC_UNLOCK_START
            // 
            this.FC_UNLOCK_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_UNLOCK_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_UNLOCK_START.CASE1 = null;
            this.FC_UNLOCK_START.CASE2 = null;
            this.FC_UNLOCK_START.CASE3 = null;
            this.FC_UNLOCK_START.CASE4 = null;
            this.FC_UNLOCK_START.ContinueRun = false;
            this.FC_UNLOCK_START.DesignTimeParent = null;
            this.FC_UNLOCK_START.EndFC = null;
            this.FC_UNLOCK_START.ErrID = 0;
            this.FC_UNLOCK_START.InAlarm = false;
            this.FC_UNLOCK_START.IsFlowHead = false;
            this.FC_UNLOCK_START.Location = new System.Drawing.Point(426, 30);
            this.FC_UNLOCK_START.LockUI = false;
            this.FC_UNLOCK_START.Message = null;
            this.FC_UNLOCK_START.MsgID = 0;
            this.FC_UNLOCK_START.Name = "FC_UNLOCK_START";
            this.FC_UNLOCK_START.NEXT = this.FC_Auto_Unlock_WaitCmd;
            this.FC_UNLOCK_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_UNLOCK_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_UNLOCK_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_UNLOCK_START.OverTimeSpec = 100;
            this.FC_UNLOCK_START.Running = false;
            this.FC_UNLOCK_START.Size = new System.Drawing.Size(200, 30);
            this.FC_UNLOCK_START.SlowRunCycle = -1;
            this.FC_UNLOCK_START.StartFC = null;
            this.FC_UNLOCK_START.Text = "Unlock Action Main";
            this.FC_UNLOCK_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_UNLOCK_START_Run);
            // 
            // FC_LOCK_START
            // 
            this.FC_LOCK_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_LOCK_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_LOCK_START.CASE1 = null;
            this.FC_LOCK_START.CASE2 = null;
            this.FC_LOCK_START.CASE3 = null;
            this.FC_LOCK_START.CASE4 = null;
            this.FC_LOCK_START.ContinueRun = false;
            this.FC_LOCK_START.DesignTimeParent = null;
            this.FC_LOCK_START.EndFC = null;
            this.FC_LOCK_START.ErrID = 0;
            this.FC_LOCK_START.InAlarm = false;
            this.FC_LOCK_START.IsFlowHead = false;
            this.FC_LOCK_START.Location = new System.Drawing.Point(37, 30);
            this.FC_LOCK_START.LockUI = false;
            this.FC_LOCK_START.Message = null;
            this.FC_LOCK_START.MsgID = 0;
            this.FC_LOCK_START.Name = "FC_LOCK_START";
            this.FC_LOCK_START.NEXT = this.FC_Auto_Lock_WaitCmd;
            this.FC_LOCK_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_LOCK_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_LOCK_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_LOCK_START.OverTimeSpec = 100;
            this.FC_LOCK_START.Running = false;
            this.FC_LOCK_START.Size = new System.Drawing.Size(200, 30);
            this.FC_LOCK_START.SlowRunCycle = -1;
            this.FC_LOCK_START.StartFC = null;
            this.FC_LOCK_START.Text = "Lock Action Main";
            this.FC_LOCK_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_LOCK_START_Run);
            // 
            // tpOpen_Close
            // 
            this.tpOpen_Close.Controls.Add(this.FC_SCAN_NEXT_2);
            this.tpOpen_Close.Controls.Add(this.FC_SCAN_NEXT_1);
            this.tpOpen_Close.Controls.Add(this.FC_SCAN_ListAddPos);
            this.tpOpen_Close.Controls.Add(this.FC_SCAN_IsScanFlagDoit);
            this.tpOpen_Close.Controls.Add(this.FC_SCAN_START);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_CalculationResult);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_Next_3);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_Next_4);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_MoveZtoWaitingPos);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_MappingCylinderOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_MoveZtoSecondPos);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_MappingCylinderOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_MoveZtoFirstPos);
            this.tpOpen_Close.Controls.Add(this.FC_Convex_Cylinder_Next);
            this.tpOpen_Close.Controls.Add(this.FC_Convex_Cylinder_Done);
            this.tpOpen_Close.Controls.Add(this.FC_Convex_Cylinder_WaitCmd);
            this.tpOpen_Close.Controls.Add(this.FC_Convex_Cylinder_START);
            this.tpOpen_Close.Controls.Add(this.button2);
            this.tpOpen_Close.Controls.Add(this.flowChart3);
            this.tpOpen_Close.Controls.Add(this.flowChart2);
            this.tpOpen_Close.Controls.Add(this.flowChart1);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_DestoryOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_DestoryOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_CheckPlacement);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_2ndVaccumOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_LatchKeyOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_DoorYPull);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_DoorYPush);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_VaccumOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_VaccumOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_CheckHasFoup);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_DoorZUp);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_Next_1);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_Next_2);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_Done);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_ConvexCyOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_TablePull);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_CoverDetect);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Close_WaitCmd);
            this.tpOpen_Close.Controls.Add(this.FC_CLOSE_START);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_FristConvexDetect);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_LatchKeyOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_Next_1);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_Next_2);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_Done);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_ConvexCyOff);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_2ndConvexDetect);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_ConvexCyOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_DoorZDown);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_LatchKeyOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_VaccumOn);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_CoverDetect);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_TableForward);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_DoorYPush);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_CheckType);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_CheckNoCover);
            this.tpOpen_Close.Controls.Add(this.FC_Auto_Open_WaitCmd);
            this.tpOpen_Close.Controls.Add(this.FC_OPEN_START);
            this.tpOpen_Close.Location = new System.Drawing.Point(4, 38);
            this.tpOpen_Close.Name = "tpOpen_Close";
            this.tpOpen_Close.Size = new System.Drawing.Size(1350, 636);
            this.tpOpen_Close.TabIndex = 3;
            this.tpOpen_Close.Text = "Open/Close";
            this.tpOpen_Close.UseVisualStyleBackColor = true;
            // 
            // FC_SCAN_NEXT_2
            // 
            this.FC_SCAN_NEXT_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_SCAN_NEXT_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_SCAN_NEXT_2.CASE1 = null;
            this.FC_SCAN_NEXT_2.CASE2 = null;
            this.FC_SCAN_NEXT_2.CASE3 = null;
            this.FC_SCAN_NEXT_2.CASE4 = null;
            this.FC_SCAN_NEXT_2.ContinueRun = false;
            this.FC_SCAN_NEXT_2.DesignTimeParent = null;
            this.FC_SCAN_NEXT_2.EndFC = null;
            this.FC_SCAN_NEXT_2.ErrID = 0;
            this.FC_SCAN_NEXT_2.InAlarm = false;
            this.FC_SCAN_NEXT_2.IsFlowHead = false;
            this.FC_SCAN_NEXT_2.Location = new System.Drawing.Point(1289, 335);
            this.FC_SCAN_NEXT_2.LockUI = false;
            this.FC_SCAN_NEXT_2.Message = null;
            this.FC_SCAN_NEXT_2.MsgID = 0;
            this.FC_SCAN_NEXT_2.Name = "FC_SCAN_NEXT_2";
            this.FC_SCAN_NEXT_2.NEXT = this.FC_SCAN_IsScanFlagDoit;
            this.FC_SCAN_NEXT_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_SCAN_NEXT_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_SCAN_NEXT_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_SCAN_NEXT_2.OverTimeSpec = 100;
            this.FC_SCAN_NEXT_2.Running = false;
            this.FC_SCAN_NEXT_2.Size = new System.Drawing.Size(30, 30);
            this.FC_SCAN_NEXT_2.SlowRunCycle = -1;
            this.FC_SCAN_NEXT_2.StartFC = null;
            this.FC_SCAN_NEXT_2.Text = "N";
            this.FC_SCAN_NEXT_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_SCAN_NEXT_2_Run);
            // 
            // FC_SCAN_NEXT_1
            // 
            this.FC_SCAN_NEXT_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_SCAN_NEXT_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_SCAN_NEXT_1.CASE1 = null;
            this.FC_SCAN_NEXT_1.CASE2 = null;
            this.FC_SCAN_NEXT_1.CASE3 = null;
            this.FC_SCAN_NEXT_1.CASE4 = null;
            this.FC_SCAN_NEXT_1.ContinueRun = false;
            this.FC_SCAN_NEXT_1.DesignTimeParent = null;
            this.FC_SCAN_NEXT_1.EndFC = null;
            this.FC_SCAN_NEXT_1.ErrID = 0;
            this.FC_SCAN_NEXT_1.InAlarm = false;
            this.FC_SCAN_NEXT_1.IsFlowHead = false;
            this.FC_SCAN_NEXT_1.Location = new System.Drawing.Point(1289, 373);
            this.FC_SCAN_NEXT_1.LockUI = false;
            this.FC_SCAN_NEXT_1.Message = null;
            this.FC_SCAN_NEXT_1.MsgID = 0;
            this.FC_SCAN_NEXT_1.Name = "FC_SCAN_NEXT_1";
            this.FC_SCAN_NEXT_1.NEXT = this.FC_SCAN_NEXT_2;
            this.FC_SCAN_NEXT_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_SCAN_NEXT_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_SCAN_NEXT_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_SCAN_NEXT_1.OverTimeSpec = 100;
            this.FC_SCAN_NEXT_1.Running = false;
            this.FC_SCAN_NEXT_1.Size = new System.Drawing.Size(30, 30);
            this.FC_SCAN_NEXT_1.SlowRunCycle = -1;
            this.FC_SCAN_NEXT_1.StartFC = null;
            this.FC_SCAN_NEXT_1.Text = "N";
            this.FC_SCAN_NEXT_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_SCAN_NEXT_1_Run);
            // 
            // FC_SCAN_ListAddPos
            // 
            this.FC_SCAN_ListAddPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_SCAN_ListAddPos.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_SCAN_ListAddPos.CASE1 = null;
            this.FC_SCAN_ListAddPos.CASE2 = null;
            this.FC_SCAN_ListAddPos.CASE3 = null;
            this.FC_SCAN_ListAddPos.CASE4 = null;
            this.FC_SCAN_ListAddPos.ContinueRun = false;
            this.FC_SCAN_ListAddPos.DesignTimeParent = null;
            this.FC_SCAN_ListAddPos.EndFC = null;
            this.FC_SCAN_ListAddPos.ErrID = 0;
            this.FC_SCAN_ListAddPos.InAlarm = false;
            this.FC_SCAN_ListAddPos.IsFlowHead = false;
            this.FC_SCAN_ListAddPos.Location = new System.Drawing.Point(1052, 373);
            this.FC_SCAN_ListAddPos.LockUI = false;
            this.FC_SCAN_ListAddPos.Message = null;
            this.FC_SCAN_ListAddPos.MsgID = 0;
            this.FC_SCAN_ListAddPos.Name = "FC_SCAN_ListAddPos";
            this.FC_SCAN_ListAddPos.NEXT = this.FC_SCAN_NEXT_1;
            this.FC_SCAN_ListAddPos.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_SCAN_ListAddPos.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_SCAN_ListAddPos.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_SCAN_ListAddPos.OverTimeSpec = 100;
            this.FC_SCAN_ListAddPos.Running = false;
            this.FC_SCAN_ListAddPos.Size = new System.Drawing.Size(200, 30);
            this.FC_SCAN_ListAddPos.SlowRunCycle = -1;
            this.FC_SCAN_ListAddPos.StartFC = null;
            this.FC_SCAN_ListAddPos.Text = "List Add Pos";
            this.FC_SCAN_ListAddPos.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_SCAN_ListAddPos_Run);
            // 
            // FC_SCAN_IsScanFlagDoit
            // 
            this.FC_SCAN_IsScanFlagDoit.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_SCAN_IsScanFlagDoit.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_SCAN_IsScanFlagDoit.CASE1 = null;
            this.FC_SCAN_IsScanFlagDoit.CASE2 = null;
            this.FC_SCAN_IsScanFlagDoit.CASE3 = null;
            this.FC_SCAN_IsScanFlagDoit.CASE4 = null;
            this.FC_SCAN_IsScanFlagDoit.ContinueRun = false;
            this.FC_SCAN_IsScanFlagDoit.DesignTimeParent = null;
            this.FC_SCAN_IsScanFlagDoit.EndFC = null;
            this.FC_SCAN_IsScanFlagDoit.ErrID = 0;
            this.FC_SCAN_IsScanFlagDoit.InAlarm = false;
            this.FC_SCAN_IsScanFlagDoit.IsFlowHead = false;
            this.FC_SCAN_IsScanFlagDoit.Location = new System.Drawing.Point(1052, 335);
            this.FC_SCAN_IsScanFlagDoit.LockUI = false;
            this.FC_SCAN_IsScanFlagDoit.Message = null;
            this.FC_SCAN_IsScanFlagDoit.MsgID = 0;
            this.FC_SCAN_IsScanFlagDoit.Name = "FC_SCAN_IsScanFlagDoit";
            this.FC_SCAN_IsScanFlagDoit.NEXT = this.FC_SCAN_ListAddPos;
            this.FC_SCAN_IsScanFlagDoit.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_SCAN_IsScanFlagDoit.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_SCAN_IsScanFlagDoit.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_SCAN_IsScanFlagDoit.OverTimeSpec = 100;
            this.FC_SCAN_IsScanFlagDoit.Running = false;
            this.FC_SCAN_IsScanFlagDoit.Size = new System.Drawing.Size(200, 30);
            this.FC_SCAN_IsScanFlagDoit.SlowRunCycle = -1;
            this.FC_SCAN_IsScanFlagDoit.StartFC = null;
            this.FC_SCAN_IsScanFlagDoit.Text = "Is ScanFlag DoIt";
            this.FC_SCAN_IsScanFlagDoit.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_SCAN_IsScanFlagDoit_Run);
            // 
            // FC_SCAN_START
            // 
            this.FC_SCAN_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_SCAN_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_SCAN_START.CASE1 = null;
            this.FC_SCAN_START.CASE2 = null;
            this.FC_SCAN_START.CASE3 = null;
            this.FC_SCAN_START.CASE4 = null;
            this.FC_SCAN_START.ContinueRun = false;
            this.FC_SCAN_START.DesignTimeParent = null;
            this.FC_SCAN_START.EndFC = null;
            this.FC_SCAN_START.ErrID = 0;
            this.FC_SCAN_START.InAlarm = false;
            this.FC_SCAN_START.IsFlowHead = false;
            this.FC_SCAN_START.Location = new System.Drawing.Point(1052, 297);
            this.FC_SCAN_START.LockUI = false;
            this.FC_SCAN_START.Message = null;
            this.FC_SCAN_START.MsgID = 0;
            this.FC_SCAN_START.Name = "FC_SCAN_START";
            this.FC_SCAN_START.NEXT = this.FC_SCAN_IsScanFlagDoit;
            this.FC_SCAN_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_SCAN_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_SCAN_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_SCAN_START.OverTimeSpec = 100;
            this.FC_SCAN_START.Running = false;
            this.FC_SCAN_START.Size = new System.Drawing.Size(200, 30);
            this.FC_SCAN_START.SlowRunCycle = -1;
            this.FC_SCAN_START.StartFC = null;
            this.FC_SCAN_START.Text = "Start Scan Action ";
            this.FC_SCAN_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_SCAN_START_Run);
            // 
            // FC_Auto_Open_CalculationResult
            // 
            this.FC_Auto_Open_CalculationResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_CalculationResult.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_CalculationResult.CASE1 = null;
            this.FC_Auto_Open_CalculationResult.CASE2 = null;
            this.FC_Auto_Open_CalculationResult.CASE3 = null;
            this.FC_Auto_Open_CalculationResult.CASE4 = null;
            this.FC_Auto_Open_CalculationResult.ContinueRun = false;
            this.FC_Auto_Open_CalculationResult.DesignTimeParent = null;
            this.FC_Auto_Open_CalculationResult.EndFC = null;
            this.FC_Auto_Open_CalculationResult.ErrID = 0;
            this.FC_Auto_Open_CalculationResult.InAlarm = false;
            this.FC_Auto_Open_CalculationResult.IsFlowHead = false;
            this.FC_Auto_Open_CalculationResult.Location = new System.Drawing.Point(281, 601);
            this.FC_Auto_Open_CalculationResult.LockUI = false;
            this.FC_Auto_Open_CalculationResult.Message = null;
            this.FC_Auto_Open_CalculationResult.MsgID = 0;
            this.FC_Auto_Open_CalculationResult.Name = "FC_Auto_Open_CalculationResult";
            this.FC_Auto_Open_CalculationResult.NEXT = this.FC_Auto_Open_Next_4;
            this.FC_Auto_Open_CalculationResult.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_CalculationResult.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_CalculationResult.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_CalculationResult.OverTimeSpec = 100;
            this.FC_Auto_Open_CalculationResult.Running = false;
            this.FC_Auto_Open_CalculationResult.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_CalculationResult.SlowRunCycle = -1;
            this.FC_Auto_Open_CalculationResult.StartFC = null;
            this.FC_Auto_Open_CalculationResult.Text = "Calculation Result";
            this.FC_Auto_Open_CalculationResult.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_CalculationResult_Run);
            // 
            // FC_Auto_Open_Next_4
            // 
            this.FC_Auto_Open_Next_4.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_Next_4.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_Next_4.CASE1 = null;
            this.FC_Auto_Open_Next_4.CASE2 = null;
            this.FC_Auto_Open_Next_4.CASE3 = null;
            this.FC_Auto_Open_Next_4.CASE4 = null;
            this.FC_Auto_Open_Next_4.ContinueRun = false;
            this.FC_Auto_Open_Next_4.DesignTimeParent = null;
            this.FC_Auto_Open_Next_4.EndFC = null;
            this.FC_Auto_Open_Next_4.ErrID = 0;
            this.FC_Auto_Open_Next_4.InAlarm = false;
            this.FC_Auto_Open_Next_4.IsFlowHead = false;
            this.FC_Auto_Open_Next_4.Location = new System.Drawing.Point(500, 601);
            this.FC_Auto_Open_Next_4.LockUI = false;
            this.FC_Auto_Open_Next_4.Message = null;
            this.FC_Auto_Open_Next_4.MsgID = 0;
            this.FC_Auto_Open_Next_4.Name = "FC_Auto_Open_Next_4";
            this.FC_Auto_Open_Next_4.NEXT = this.FC_Auto_Open_Next_3;
            this.FC_Auto_Open_Next_4.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_Next_4.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_Next_4.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_Next_4.OverTimeSpec = 100;
            this.FC_Auto_Open_Next_4.Running = false;
            this.FC_Auto_Open_Next_4.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Open_Next_4.SlowRunCycle = -1;
            this.FC_Auto_Open_Next_4.StartFC = null;
            this.FC_Auto_Open_Next_4.Text = "N";
            this.FC_Auto_Open_Next_4.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_Next_4_Run);
            // 
            // FC_Auto_Open_Next_3
            // 
            this.FC_Auto_Open_Next_3.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_Next_3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_Next_3.CASE1 = null;
            this.FC_Auto_Open_Next_3.CASE2 = null;
            this.FC_Auto_Open_Next_3.CASE3 = null;
            this.FC_Auto_Open_Next_3.CASE4 = null;
            this.FC_Auto_Open_Next_3.ContinueRun = false;
            this.FC_Auto_Open_Next_3.DesignTimeParent = null;
            this.FC_Auto_Open_Next_3.EndFC = null;
            this.FC_Auto_Open_Next_3.ErrID = 0;
            this.FC_Auto_Open_Next_3.InAlarm = false;
            this.FC_Auto_Open_Next_3.IsFlowHead = false;
            this.FC_Auto_Open_Next_3.Location = new System.Drawing.Point(500, 221);
            this.FC_Auto_Open_Next_3.LockUI = false;
            this.FC_Auto_Open_Next_3.Message = null;
            this.FC_Auto_Open_Next_3.MsgID = 0;
            this.FC_Auto_Open_Next_3.Name = "FC_Auto_Open_Next_3";
            this.FC_Auto_Open_Next_3.NEXT = this.FC_Auto_Open_Next_2;
            this.FC_Auto_Open_Next_3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_Next_3.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_Next_3.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_Next_3.OverTimeSpec = 100;
            this.FC_Auto_Open_Next_3.Running = false;
            this.FC_Auto_Open_Next_3.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Open_Next_3.SlowRunCycle = -1;
            this.FC_Auto_Open_Next_3.StartFC = null;
            this.FC_Auto_Open_Next_3.Text = "N";
            this.FC_Auto_Open_Next_3.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_Next_3_Run);
            // 
            // FC_Auto_Open_Next_2
            // 
            this.FC_Auto_Open_Next_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_Next_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_Next_2.CASE1 = null;
            this.FC_Auto_Open_Next_2.CASE2 = null;
            this.FC_Auto_Open_Next_2.CASE3 = null;
            this.FC_Auto_Open_Next_2.CASE4 = null;
            this.FC_Auto_Open_Next_2.ContinueRun = false;
            this.FC_Auto_Open_Next_2.DesignTimeParent = null;
            this.FC_Auto_Open_Next_2.EndFC = null;
            this.FC_Auto_Open_Next_2.ErrID = 0;
            this.FC_Auto_Open_Next_2.InAlarm = false;
            this.FC_Auto_Open_Next_2.IsFlowHead = false;
            this.FC_Auto_Open_Next_2.Location = new System.Drawing.Point(366, 221);
            this.FC_Auto_Open_Next_2.LockUI = false;
            this.FC_Auto_Open_Next_2.Message = null;
            this.FC_Auto_Open_Next_2.MsgID = 0;
            this.FC_Auto_Open_Next_2.Name = "FC_Auto_Open_Next_2";
            this.FC_Auto_Open_Next_2.NEXT = this.FC_Auto_Open_Next_1;
            this.FC_Auto_Open_Next_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_Next_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_Next_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_Next_2.OverTimeSpec = 100;
            this.FC_Auto_Open_Next_2.Running = false;
            this.FC_Auto_Open_Next_2.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Open_Next_2.SlowRunCycle = -1;
            this.FC_Auto_Open_Next_2.StartFC = null;
            this.FC_Auto_Open_Next_2.Text = "N";
            this.FC_Auto_Open_Next_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_Next_2_Run);
            // 
            // FC_Auto_Open_Next_1
            // 
            this.FC_Auto_Open_Next_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_Next_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_Next_1.CASE1 = null;
            this.FC_Auto_Open_Next_1.CASE2 = null;
            this.FC_Auto_Open_Next_1.CASE3 = null;
            this.FC_Auto_Open_Next_1.CASE4 = null;
            this.FC_Auto_Open_Next_1.ContinueRun = false;
            this.FC_Auto_Open_Next_1.DesignTimeParent = null;
            this.FC_Auto_Open_Next_1.EndFC = null;
            this.FC_Auto_Open_Next_1.ErrID = 0;
            this.FC_Auto_Open_Next_1.InAlarm = false;
            this.FC_Auto_Open_Next_1.IsFlowHead = false;
            this.FC_Auto_Open_Next_1.Location = new System.Drawing.Point(366, 69);
            this.FC_Auto_Open_Next_1.LockUI = false;
            this.FC_Auto_Open_Next_1.Message = null;
            this.FC_Auto_Open_Next_1.MsgID = 0;
            this.FC_Auto_Open_Next_1.Name = "FC_Auto_Open_Next_1";
            this.FC_Auto_Open_Next_1.NEXT = this.FC_Auto_Open_WaitCmd;
            this.FC_Auto_Open_Next_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_Next_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_Next_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_Next_1.OverTimeSpec = 100;
            this.FC_Auto_Open_Next_1.Running = false;
            this.FC_Auto_Open_Next_1.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Open_Next_1.SlowRunCycle = -1;
            this.FC_Auto_Open_Next_1.StartFC = null;
            this.FC_Auto_Open_Next_1.Text = "N";
            this.FC_Auto_Open_Next_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_Next_1_Run);
            // 
            // FC_Auto_Open_WaitCmd
            // 
            this.FC_Auto_Open_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_WaitCmd.CASE1 = null;
            this.FC_Auto_Open_WaitCmd.CASE2 = null;
            this.FC_Auto_Open_WaitCmd.CASE3 = null;
            this.FC_Auto_Open_WaitCmd.CASE4 = null;
            this.FC_Auto_Open_WaitCmd.ContinueRun = false;
            this.FC_Auto_Open_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_Open_WaitCmd.EndFC = null;
            this.FC_Auto_Open_WaitCmd.ErrID = 0;
            this.FC_Auto_Open_WaitCmd.InAlarm = false;
            this.FC_Auto_Open_WaitCmd.IsFlowHead = false;
            this.FC_Auto_Open_WaitCmd.Location = new System.Drawing.Point(75, 69);
            this.FC_Auto_Open_WaitCmd.LockUI = false;
            this.FC_Auto_Open_WaitCmd.Message = null;
            this.FC_Auto_Open_WaitCmd.MsgID = 0;
            this.FC_Auto_Open_WaitCmd.Name = "FC_Auto_Open_WaitCmd";
            this.FC_Auto_Open_WaitCmd.NEXT = this.FC_Auto_Open_CheckType;
            this.FC_Auto_Open_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_Open_WaitCmd.Running = false;
            this.FC_Auto_Open_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_Open_WaitCmd.StartFC = null;
            this.FC_Auto_Open_WaitCmd.Text = "Wait command";
            this.FC_Auto_Open_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_WaitCmd_Run);
            // 
            // FC_Auto_Open_CheckType
            // 
            this.FC_Auto_Open_CheckType.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_CheckType.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_CheckType.CASE1 = null;
            this.FC_Auto_Open_CheckType.CASE2 = null;
            this.FC_Auto_Open_CheckType.CASE3 = null;
            this.FC_Auto_Open_CheckType.CASE4 = null;
            this.FC_Auto_Open_CheckType.ContinueRun = false;
            this.FC_Auto_Open_CheckType.DesignTimeParent = null;
            this.FC_Auto_Open_CheckType.EndFC = null;
            this.FC_Auto_Open_CheckType.ErrID = 0;
            this.FC_Auto_Open_CheckType.InAlarm = false;
            this.FC_Auto_Open_CheckType.IsFlowHead = false;
            this.FC_Auto_Open_CheckType.Location = new System.Drawing.Point(75, 107);
            this.FC_Auto_Open_CheckType.LockUI = false;
            this.FC_Auto_Open_CheckType.Message = null;
            this.FC_Auto_Open_CheckType.MsgID = 0;
            this.FC_Auto_Open_CheckType.Name = "FC_Auto_Open_CheckType";
            this.FC_Auto_Open_CheckType.NEXT = this.FC_Auto_Open_CheckNoCover;
            this.FC_Auto_Open_CheckType.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_CheckType.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_CheckType.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_CheckType.OverTimeSpec = 100;
            this.FC_Auto_Open_CheckType.Running = false;
            this.FC_Auto_Open_CheckType.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_CheckType.SlowRunCycle = -1;
            this.FC_Auto_Open_CheckType.StartFC = null;
            this.FC_Auto_Open_CheckType.Text = "Check type";
            this.FC_Auto_Open_CheckType.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_CheckType_Run);
            // 
            // FC_Auto_Open_CheckNoCover
            // 
            this.FC_Auto_Open_CheckNoCover.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_CheckNoCover.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_CheckNoCover.CASE1 = null;
            this.FC_Auto_Open_CheckNoCover.CASE2 = null;
            this.FC_Auto_Open_CheckNoCover.CASE3 = null;
            this.FC_Auto_Open_CheckNoCover.CASE4 = null;
            this.FC_Auto_Open_CheckNoCover.ContinueRun = false;
            this.FC_Auto_Open_CheckNoCover.DesignTimeParent = null;
            this.FC_Auto_Open_CheckNoCover.EndFC = null;
            this.FC_Auto_Open_CheckNoCover.ErrID = 0;
            this.FC_Auto_Open_CheckNoCover.InAlarm = false;
            this.FC_Auto_Open_CheckNoCover.IsFlowHead = false;
            this.FC_Auto_Open_CheckNoCover.Location = new System.Drawing.Point(75, 145);
            this.FC_Auto_Open_CheckNoCover.LockUI = false;
            this.FC_Auto_Open_CheckNoCover.Message = null;
            this.FC_Auto_Open_CheckNoCover.MsgID = 0;
            this.FC_Auto_Open_CheckNoCover.Name = "FC_Auto_Open_CheckNoCover";
            this.FC_Auto_Open_CheckNoCover.NEXT = this.FC_Auto_Open_LatchKeyOff;
            this.FC_Auto_Open_CheckNoCover.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_CheckNoCover.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_CheckNoCover.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_CheckNoCover.OverTimeSpec = 100;
            this.FC_Auto_Open_CheckNoCover.Running = false;
            this.FC_Auto_Open_CheckNoCover.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_CheckNoCover.SlowRunCycle = -1;
            this.FC_Auto_Open_CheckNoCover.StartFC = null;
            this.FC_Auto_Open_CheckNoCover.Text = "Check no Cover";
            this.FC_Auto_Open_CheckNoCover.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_CheckNoCover_Run);
            // 
            // FC_Auto_Open_LatchKeyOff
            // 
            this.FC_Auto_Open_LatchKeyOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_LatchKeyOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_LatchKeyOff.CASE1 = null;
            this.FC_Auto_Open_LatchKeyOff.CASE2 = null;
            this.FC_Auto_Open_LatchKeyOff.CASE3 = null;
            this.FC_Auto_Open_LatchKeyOff.CASE4 = null;
            this.FC_Auto_Open_LatchKeyOff.ContinueRun = false;
            this.FC_Auto_Open_LatchKeyOff.DesignTimeParent = null;
            this.FC_Auto_Open_LatchKeyOff.EndFC = null;
            this.FC_Auto_Open_LatchKeyOff.ErrID = 0;
            this.FC_Auto_Open_LatchKeyOff.InAlarm = false;
            this.FC_Auto_Open_LatchKeyOff.IsFlowHead = false;
            this.FC_Auto_Open_LatchKeyOff.Location = new System.Drawing.Point(75, 183);
            this.FC_Auto_Open_LatchKeyOff.LockUI = false;
            this.FC_Auto_Open_LatchKeyOff.Message = null;
            this.FC_Auto_Open_LatchKeyOff.MsgID = 0;
            this.FC_Auto_Open_LatchKeyOff.Name = "FC_Auto_Open_LatchKeyOff";
            this.FC_Auto_Open_LatchKeyOff.NEXT = this.FC_Auto_Open_TableForward;
            this.FC_Auto_Open_LatchKeyOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_LatchKeyOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_LatchKeyOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_LatchKeyOff.OverTimeSpec = 100;
            this.FC_Auto_Open_LatchKeyOff.Running = false;
            this.FC_Auto_Open_LatchKeyOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_LatchKeyOff.SlowRunCycle = -1;
            this.FC_Auto_Open_LatchKeyOff.StartFC = null;
            this.FC_Auto_Open_LatchKeyOff.Text = "Latch key Off";
            this.FC_Auto_Open_LatchKeyOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_LatchKeyOff_Run);
            // 
            // FC_Auto_Open_TableForward
            // 
            this.FC_Auto_Open_TableForward.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_TableForward.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_TableForward.CASE1 = null;
            this.FC_Auto_Open_TableForward.CASE2 = null;
            this.FC_Auto_Open_TableForward.CASE3 = null;
            this.FC_Auto_Open_TableForward.CASE4 = null;
            this.FC_Auto_Open_TableForward.ContinueRun = false;
            this.FC_Auto_Open_TableForward.DesignTimeParent = null;
            this.FC_Auto_Open_TableForward.EndFC = null;
            this.FC_Auto_Open_TableForward.ErrID = 0;
            this.FC_Auto_Open_TableForward.InAlarm = false;
            this.FC_Auto_Open_TableForward.IsFlowHead = false;
            this.FC_Auto_Open_TableForward.Location = new System.Drawing.Point(75, 221);
            this.FC_Auto_Open_TableForward.LockUI = false;
            this.FC_Auto_Open_TableForward.Message = null;
            this.FC_Auto_Open_TableForward.MsgID = 0;
            this.FC_Auto_Open_TableForward.Name = "FC_Auto_Open_TableForward";
            this.FC_Auto_Open_TableForward.NEXT = this.FC_Auto_Open_VaccumOn;
            this.FC_Auto_Open_TableForward.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_TableForward.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_TableForward.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_TableForward.OverTimeSpec = 100;
            this.FC_Auto_Open_TableForward.Running = false;
            this.FC_Auto_Open_TableForward.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_TableForward.SlowRunCycle = -1;
            this.FC_Auto_Open_TableForward.StartFC = null;
            this.FC_Auto_Open_TableForward.Text = "Table forward";
            this.FC_Auto_Open_TableForward.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_TableForward_Run);
            // 
            // FC_Auto_Open_VaccumOn
            // 
            this.FC_Auto_Open_VaccumOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_VaccumOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_VaccumOn.CASE1 = null;
            this.FC_Auto_Open_VaccumOn.CASE2 = null;
            this.FC_Auto_Open_VaccumOn.CASE3 = null;
            this.FC_Auto_Open_VaccumOn.CASE4 = null;
            this.FC_Auto_Open_VaccumOn.ContinueRun = false;
            this.FC_Auto_Open_VaccumOn.DesignTimeParent = null;
            this.FC_Auto_Open_VaccumOn.EndFC = null;
            this.FC_Auto_Open_VaccumOn.ErrID = 0;
            this.FC_Auto_Open_VaccumOn.InAlarm = false;
            this.FC_Auto_Open_VaccumOn.IsFlowHead = false;
            this.FC_Auto_Open_VaccumOn.Location = new System.Drawing.Point(75, 259);
            this.FC_Auto_Open_VaccumOn.LockUI = false;
            this.FC_Auto_Open_VaccumOn.Message = null;
            this.FC_Auto_Open_VaccumOn.MsgID = 0;
            this.FC_Auto_Open_VaccumOn.Name = "FC_Auto_Open_VaccumOn";
            this.FC_Auto_Open_VaccumOn.NEXT = this.FC_Auto_Open_CoverDetect;
            this.FC_Auto_Open_VaccumOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_VaccumOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_VaccumOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_VaccumOn.OverTimeSpec = 100;
            this.FC_Auto_Open_VaccumOn.Running = false;
            this.FC_Auto_Open_VaccumOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_VaccumOn.SlowRunCycle = -1;
            this.FC_Auto_Open_VaccumOn.StartFC = null;
            this.FC_Auto_Open_VaccumOn.Text = "Vaccum On";
            this.FC_Auto_Open_VaccumOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_VaccumOn_Run);
            // 
            // FC_Auto_Open_CoverDetect
            // 
            this.FC_Auto_Open_CoverDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_CoverDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_CoverDetect.CASE1 = null;
            this.FC_Auto_Open_CoverDetect.CASE2 = null;
            this.FC_Auto_Open_CoverDetect.CASE3 = null;
            this.FC_Auto_Open_CoverDetect.CASE4 = null;
            this.FC_Auto_Open_CoverDetect.ContinueRun = false;
            this.FC_Auto_Open_CoverDetect.DesignTimeParent = null;
            this.FC_Auto_Open_CoverDetect.EndFC = null;
            this.FC_Auto_Open_CoverDetect.ErrID = 0;
            this.FC_Auto_Open_CoverDetect.InAlarm = false;
            this.FC_Auto_Open_CoverDetect.IsFlowHead = false;
            this.FC_Auto_Open_CoverDetect.Location = new System.Drawing.Point(75, 297);
            this.FC_Auto_Open_CoverDetect.LockUI = false;
            this.FC_Auto_Open_CoverDetect.Message = null;
            this.FC_Auto_Open_CoverDetect.MsgID = 0;
            this.FC_Auto_Open_CoverDetect.Name = "FC_Auto_Open_CoverDetect";
            this.FC_Auto_Open_CoverDetect.NEXT = this.FC_Auto_Open_LatchKeyOn;
            this.FC_Auto_Open_CoverDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_CoverDetect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_CoverDetect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_CoverDetect.OverTimeSpec = 100;
            this.FC_Auto_Open_CoverDetect.Running = false;
            this.FC_Auto_Open_CoverDetect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_CoverDetect.SlowRunCycle = -1;
            this.FC_Auto_Open_CoverDetect.StartFC = null;
            this.FC_Auto_Open_CoverDetect.Text = "Cover Detect";
            this.FC_Auto_Open_CoverDetect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_CoverDetect_Run);
            // 
            // FC_Auto_Open_LatchKeyOn
            // 
            this.FC_Auto_Open_LatchKeyOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_LatchKeyOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_LatchKeyOn.CASE1 = null;
            this.FC_Auto_Open_LatchKeyOn.CASE2 = null;
            this.FC_Auto_Open_LatchKeyOn.CASE3 = null;
            this.FC_Auto_Open_LatchKeyOn.CASE4 = null;
            this.FC_Auto_Open_LatchKeyOn.ContinueRun = false;
            this.FC_Auto_Open_LatchKeyOn.DesignTimeParent = null;
            this.FC_Auto_Open_LatchKeyOn.EndFC = null;
            this.FC_Auto_Open_LatchKeyOn.ErrID = 0;
            this.FC_Auto_Open_LatchKeyOn.InAlarm = false;
            this.FC_Auto_Open_LatchKeyOn.IsFlowHead = false;
            this.FC_Auto_Open_LatchKeyOn.Location = new System.Drawing.Point(75, 335);
            this.FC_Auto_Open_LatchKeyOn.LockUI = false;
            this.FC_Auto_Open_LatchKeyOn.Message = null;
            this.FC_Auto_Open_LatchKeyOn.MsgID = 0;
            this.FC_Auto_Open_LatchKeyOn.Name = "FC_Auto_Open_LatchKeyOn";
            this.FC_Auto_Open_LatchKeyOn.NEXT = this.FC_Auto_Open_DoorYPush;
            this.FC_Auto_Open_LatchKeyOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_LatchKeyOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_LatchKeyOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_LatchKeyOn.OverTimeSpec = 100;
            this.FC_Auto_Open_LatchKeyOn.Running = false;
            this.FC_Auto_Open_LatchKeyOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_LatchKeyOn.SlowRunCycle = -1;
            this.FC_Auto_Open_LatchKeyOn.StartFC = null;
            this.FC_Auto_Open_LatchKeyOn.Text = "Latch key On";
            this.FC_Auto_Open_LatchKeyOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_LatchKeyOn_Run);
            // 
            // FC_Auto_Open_DoorYPush
            // 
            this.FC_Auto_Open_DoorYPush.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_DoorYPush.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_DoorYPush.CASE1 = null;
            this.FC_Auto_Open_DoorYPush.CASE2 = null;
            this.FC_Auto_Open_DoorYPush.CASE3 = null;
            this.FC_Auto_Open_DoorYPush.CASE4 = null;
            this.FC_Auto_Open_DoorYPush.ContinueRun = false;
            this.FC_Auto_Open_DoorYPush.DesignTimeParent = null;
            this.FC_Auto_Open_DoorYPush.EndFC = null;
            this.FC_Auto_Open_DoorYPush.ErrID = 0;
            this.FC_Auto_Open_DoorYPush.InAlarm = false;
            this.FC_Auto_Open_DoorYPush.IsFlowHead = false;
            this.FC_Auto_Open_DoorYPush.Location = new System.Drawing.Point(75, 373);
            this.FC_Auto_Open_DoorYPush.LockUI = false;
            this.FC_Auto_Open_DoorYPush.Message = null;
            this.FC_Auto_Open_DoorYPush.MsgID = 0;
            this.FC_Auto_Open_DoorYPush.Name = "FC_Auto_Open_DoorYPush";
            this.FC_Auto_Open_DoorYPush.NEXT = this.FC_Auto_Open_FristConvexDetect;
            this.FC_Auto_Open_DoorYPush.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_DoorYPush.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_DoorYPush.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_DoorYPush.OverTimeSpec = 100;
            this.FC_Auto_Open_DoorYPush.Running = false;
            this.FC_Auto_Open_DoorYPush.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_DoorYPush.SlowRunCycle = -1;
            this.FC_Auto_Open_DoorYPush.StartFC = null;
            this.FC_Auto_Open_DoorYPush.Text = "Door Y Push";
            this.FC_Auto_Open_DoorYPush.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_DoorYPush_Run);
            // 
            // FC_Auto_Open_FristConvexDetect
            // 
            this.FC_Auto_Open_FristConvexDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_FristConvexDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_FristConvexDetect.CASE1 = this.FC_Auto_Open_MoveZtoFirstPos;
            this.FC_Auto_Open_FristConvexDetect.CASE2 = null;
            this.FC_Auto_Open_FristConvexDetect.CASE3 = null;
            this.FC_Auto_Open_FristConvexDetect.CASE4 = null;
            this.FC_Auto_Open_FristConvexDetect.ContinueRun = false;
            this.FC_Auto_Open_FristConvexDetect.DesignTimeParent = null;
            this.FC_Auto_Open_FristConvexDetect.EndFC = null;
            this.FC_Auto_Open_FristConvexDetect.ErrID = 0;
            this.FC_Auto_Open_FristConvexDetect.InAlarm = false;
            this.FC_Auto_Open_FristConvexDetect.IsFlowHead = false;
            this.FC_Auto_Open_FristConvexDetect.Location = new System.Drawing.Point(75, 411);
            this.FC_Auto_Open_FristConvexDetect.LockUI = false;
            this.FC_Auto_Open_FristConvexDetect.Message = null;
            this.FC_Auto_Open_FristConvexDetect.MsgID = 0;
            this.FC_Auto_Open_FristConvexDetect.Name = "FC_Auto_Open_FristConvexDetect";
            this.FC_Auto_Open_FristConvexDetect.NEXT = this.FC_Auto_Open_DoorZDown;
            this.FC_Auto_Open_FristConvexDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_FristConvexDetect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_FristConvexDetect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_FristConvexDetect.OverTimeSpec = 100;
            this.FC_Auto_Open_FristConvexDetect.Running = false;
            this.FC_Auto_Open_FristConvexDetect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_FristConvexDetect.SlowRunCycle = -1;
            this.FC_Auto_Open_FristConvexDetect.StartFC = null;
            this.FC_Auto_Open_FristConvexDetect.Text = "First Convex Detect";
            this.FC_Auto_Open_FristConvexDetect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_FristConvexDetect_Run);
            // 
            // FC_Auto_Open_MoveZtoFirstPos
            // 
            this.FC_Auto_Open_MoveZtoFirstPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_MoveZtoFirstPos.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_MoveZtoFirstPos.CASE1 = null;
            this.FC_Auto_Open_MoveZtoFirstPos.CASE2 = null;
            this.FC_Auto_Open_MoveZtoFirstPos.CASE3 = null;
            this.FC_Auto_Open_MoveZtoFirstPos.CASE4 = null;
            this.FC_Auto_Open_MoveZtoFirstPos.ContinueRun = false;
            this.FC_Auto_Open_MoveZtoFirstPos.DesignTimeParent = null;
            this.FC_Auto_Open_MoveZtoFirstPos.EndFC = null;
            this.FC_Auto_Open_MoveZtoFirstPos.ErrID = 0;
            this.FC_Auto_Open_MoveZtoFirstPos.InAlarm = false;
            this.FC_Auto_Open_MoveZtoFirstPos.IsFlowHead = false;
            this.FC_Auto_Open_MoveZtoFirstPos.Location = new System.Drawing.Point(75, 449);
            this.FC_Auto_Open_MoveZtoFirstPos.LockUI = false;
            this.FC_Auto_Open_MoveZtoFirstPos.Message = null;
            this.FC_Auto_Open_MoveZtoFirstPos.MsgID = 0;
            this.FC_Auto_Open_MoveZtoFirstPos.Name = "FC_Auto_Open_MoveZtoFirstPos";
            this.FC_Auto_Open_MoveZtoFirstPos.NEXT = this.FC_Auto_Open_MappingCylinderOn;
            this.FC_Auto_Open_MoveZtoFirstPos.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_MoveZtoFirstPos.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_MoveZtoFirstPos.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_MoveZtoFirstPos.OverTimeSpec = 100;
            this.FC_Auto_Open_MoveZtoFirstPos.Running = false;
            this.FC_Auto_Open_MoveZtoFirstPos.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_MoveZtoFirstPos.SlowRunCycle = -1;
            this.FC_Auto_Open_MoveZtoFirstPos.StartFC = null;
            this.FC_Auto_Open_MoveZtoFirstPos.Text = "Move Z to First Pos";
            this.FC_Auto_Open_MoveZtoFirstPos.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_MoveZtoFirstPos_Run);
            // 
            // FC_Auto_Open_MappingCylinderOn
            // 
            this.FC_Auto_Open_MappingCylinderOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_MappingCylinderOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_MappingCylinderOn.CASE1 = null;
            this.FC_Auto_Open_MappingCylinderOn.CASE2 = null;
            this.FC_Auto_Open_MappingCylinderOn.CASE3 = null;
            this.FC_Auto_Open_MappingCylinderOn.CASE4 = null;
            this.FC_Auto_Open_MappingCylinderOn.ContinueRun = false;
            this.FC_Auto_Open_MappingCylinderOn.DesignTimeParent = null;
            this.FC_Auto_Open_MappingCylinderOn.EndFC = null;
            this.FC_Auto_Open_MappingCylinderOn.ErrID = 0;
            this.FC_Auto_Open_MappingCylinderOn.InAlarm = false;
            this.FC_Auto_Open_MappingCylinderOn.IsFlowHead = false;
            this.FC_Auto_Open_MappingCylinderOn.Location = new System.Drawing.Point(75, 487);
            this.FC_Auto_Open_MappingCylinderOn.LockUI = false;
            this.FC_Auto_Open_MappingCylinderOn.Message = null;
            this.FC_Auto_Open_MappingCylinderOn.MsgID = 0;
            this.FC_Auto_Open_MappingCylinderOn.Name = "FC_Auto_Open_MappingCylinderOn";
            this.FC_Auto_Open_MappingCylinderOn.NEXT = this.FC_Auto_Open_MoveZtoSecondPos;
            this.FC_Auto_Open_MappingCylinderOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_MappingCylinderOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_MappingCylinderOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_MappingCylinderOn.OverTimeSpec = 100;
            this.FC_Auto_Open_MappingCylinderOn.Running = false;
            this.FC_Auto_Open_MappingCylinderOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_MappingCylinderOn.SlowRunCycle = -1;
            this.FC_Auto_Open_MappingCylinderOn.StartFC = null;
            this.FC_Auto_Open_MappingCylinderOn.Text = "Mapping Cylinder On";
            this.FC_Auto_Open_MappingCylinderOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_MappingCylinderOn_Run);
            // 
            // FC_Auto_Open_MoveZtoSecondPos
            // 
            this.FC_Auto_Open_MoveZtoSecondPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_MoveZtoSecondPos.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_MoveZtoSecondPos.CASE1 = null;
            this.FC_Auto_Open_MoveZtoSecondPos.CASE2 = null;
            this.FC_Auto_Open_MoveZtoSecondPos.CASE3 = null;
            this.FC_Auto_Open_MoveZtoSecondPos.CASE4 = null;
            this.FC_Auto_Open_MoveZtoSecondPos.ContinueRun = false;
            this.FC_Auto_Open_MoveZtoSecondPos.DesignTimeParent = null;
            this.FC_Auto_Open_MoveZtoSecondPos.EndFC = null;
            this.FC_Auto_Open_MoveZtoSecondPos.ErrID = 0;
            this.FC_Auto_Open_MoveZtoSecondPos.InAlarm = false;
            this.FC_Auto_Open_MoveZtoSecondPos.IsFlowHead = false;
            this.FC_Auto_Open_MoveZtoSecondPos.Location = new System.Drawing.Point(75, 525);
            this.FC_Auto_Open_MoveZtoSecondPos.LockUI = false;
            this.FC_Auto_Open_MoveZtoSecondPos.Message = null;
            this.FC_Auto_Open_MoveZtoSecondPos.MsgID = 0;
            this.FC_Auto_Open_MoveZtoSecondPos.Name = "FC_Auto_Open_MoveZtoSecondPos";
            this.FC_Auto_Open_MoveZtoSecondPos.NEXT = this.FC_Auto_Open_MappingCylinderOff;
            this.FC_Auto_Open_MoveZtoSecondPos.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_MoveZtoSecondPos.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_MoveZtoSecondPos.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_MoveZtoSecondPos.OverTimeSpec = 100;
            this.FC_Auto_Open_MoveZtoSecondPos.Running = false;
            this.FC_Auto_Open_MoveZtoSecondPos.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_MoveZtoSecondPos.SlowRunCycle = -1;
            this.FC_Auto_Open_MoveZtoSecondPos.StartFC = null;
            this.FC_Auto_Open_MoveZtoSecondPos.Text = "Move Z to Second Pos";
            this.FC_Auto_Open_MoveZtoSecondPos.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_MoveZtoSecondPos_Run);
            // 
            // FC_Auto_Open_MappingCylinderOff
            // 
            this.FC_Auto_Open_MappingCylinderOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_MappingCylinderOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_MappingCylinderOff.CASE1 = null;
            this.FC_Auto_Open_MappingCylinderOff.CASE2 = null;
            this.FC_Auto_Open_MappingCylinderOff.CASE3 = null;
            this.FC_Auto_Open_MappingCylinderOff.CASE4 = null;
            this.FC_Auto_Open_MappingCylinderOff.ContinueRun = false;
            this.FC_Auto_Open_MappingCylinderOff.DesignTimeParent = null;
            this.FC_Auto_Open_MappingCylinderOff.EndFC = null;
            this.FC_Auto_Open_MappingCylinderOff.ErrID = 0;
            this.FC_Auto_Open_MappingCylinderOff.InAlarm = false;
            this.FC_Auto_Open_MappingCylinderOff.IsFlowHead = false;
            this.FC_Auto_Open_MappingCylinderOff.Location = new System.Drawing.Point(75, 563);
            this.FC_Auto_Open_MappingCylinderOff.LockUI = false;
            this.FC_Auto_Open_MappingCylinderOff.Message = null;
            this.FC_Auto_Open_MappingCylinderOff.MsgID = 0;
            this.FC_Auto_Open_MappingCylinderOff.Name = "FC_Auto_Open_MappingCylinderOff";
            this.FC_Auto_Open_MappingCylinderOff.NEXT = this.FC_Auto_Open_MoveZtoWaitingPos;
            this.FC_Auto_Open_MappingCylinderOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_MappingCylinderOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_MappingCylinderOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_MappingCylinderOff.OverTimeSpec = 100;
            this.FC_Auto_Open_MappingCylinderOff.Running = false;
            this.FC_Auto_Open_MappingCylinderOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_MappingCylinderOff.SlowRunCycle = -1;
            this.FC_Auto_Open_MappingCylinderOff.StartFC = null;
            this.FC_Auto_Open_MappingCylinderOff.Text = "Mapping Cylinder Off";
            this.FC_Auto_Open_MappingCylinderOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_MappingCylinderOff_Run);
            // 
            // FC_Auto_Open_MoveZtoWaitingPos
            // 
            this.FC_Auto_Open_MoveZtoWaitingPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_MoveZtoWaitingPos.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_MoveZtoWaitingPos.CASE1 = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.CASE2 = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.CASE3 = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.CASE4 = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.ContinueRun = false;
            this.FC_Auto_Open_MoveZtoWaitingPos.DesignTimeParent = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.EndFC = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.ErrID = 0;
            this.FC_Auto_Open_MoveZtoWaitingPos.InAlarm = false;
            this.FC_Auto_Open_MoveZtoWaitingPos.IsFlowHead = false;
            this.FC_Auto_Open_MoveZtoWaitingPos.Location = new System.Drawing.Point(75, 601);
            this.FC_Auto_Open_MoveZtoWaitingPos.LockUI = false;
            this.FC_Auto_Open_MoveZtoWaitingPos.Message = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.MsgID = 0;
            this.FC_Auto_Open_MoveZtoWaitingPos.Name = "FC_Auto_Open_MoveZtoWaitingPos";
            this.FC_Auto_Open_MoveZtoWaitingPos.NEXT = this.FC_Auto_Open_CalculationResult;
            this.FC_Auto_Open_MoveZtoWaitingPos.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_MoveZtoWaitingPos.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_MoveZtoWaitingPos.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_MoveZtoWaitingPos.OverTimeSpec = 100;
            this.FC_Auto_Open_MoveZtoWaitingPos.Running = false;
            this.FC_Auto_Open_MoveZtoWaitingPos.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_MoveZtoWaitingPos.SlowRunCycle = -1;
            this.FC_Auto_Open_MoveZtoWaitingPos.StartFC = null;
            this.FC_Auto_Open_MoveZtoWaitingPos.Text = "Move Z to Waiting Pos";
            this.FC_Auto_Open_MoveZtoWaitingPos.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_MoveZtoWaitingPos_Run);
            // 
            // FC_Auto_Open_DoorZDown
            // 
            this.FC_Auto_Open_DoorZDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_DoorZDown.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_DoorZDown.CASE1 = null;
            this.FC_Auto_Open_DoorZDown.CASE2 = null;
            this.FC_Auto_Open_DoorZDown.CASE3 = null;
            this.FC_Auto_Open_DoorZDown.CASE4 = null;
            this.FC_Auto_Open_DoorZDown.ContinueRun = false;
            this.FC_Auto_Open_DoorZDown.DesignTimeParent = null;
            this.FC_Auto_Open_DoorZDown.EndFC = null;
            this.FC_Auto_Open_DoorZDown.ErrID = 0;
            this.FC_Auto_Open_DoorZDown.InAlarm = false;
            this.FC_Auto_Open_DoorZDown.IsFlowHead = false;
            this.FC_Auto_Open_DoorZDown.Location = new System.Drawing.Point(281, 411);
            this.FC_Auto_Open_DoorZDown.LockUI = false;
            this.FC_Auto_Open_DoorZDown.Message = null;
            this.FC_Auto_Open_DoorZDown.MsgID = 0;
            this.FC_Auto_Open_DoorZDown.Name = "FC_Auto_Open_DoorZDown";
            this.FC_Auto_Open_DoorZDown.NEXT = this.FC_Auto_Open_ConvexCyOn;
            this.FC_Auto_Open_DoorZDown.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_DoorZDown.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_DoorZDown.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_DoorZDown.OverTimeSpec = 100;
            this.FC_Auto_Open_DoorZDown.Running = false;
            this.FC_Auto_Open_DoorZDown.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_DoorZDown.SlowRunCycle = -1;
            this.FC_Auto_Open_DoorZDown.StartFC = null;
            this.FC_Auto_Open_DoorZDown.Text = "Door Z Down";
            this.FC_Auto_Open_DoorZDown.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_DoorZDown_Run);
            // 
            // FC_Auto_Open_ConvexCyOn
            // 
            this.FC_Auto_Open_ConvexCyOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_ConvexCyOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_ConvexCyOn.CASE1 = null;
            this.FC_Auto_Open_ConvexCyOn.CASE2 = null;
            this.FC_Auto_Open_ConvexCyOn.CASE3 = null;
            this.FC_Auto_Open_ConvexCyOn.CASE4 = null;
            this.FC_Auto_Open_ConvexCyOn.ContinueRun = false;
            this.FC_Auto_Open_ConvexCyOn.DesignTimeParent = null;
            this.FC_Auto_Open_ConvexCyOn.EndFC = null;
            this.FC_Auto_Open_ConvexCyOn.ErrID = 0;
            this.FC_Auto_Open_ConvexCyOn.InAlarm = false;
            this.FC_Auto_Open_ConvexCyOn.IsFlowHead = false;
            this.FC_Auto_Open_ConvexCyOn.Location = new System.Drawing.Point(281, 373);
            this.FC_Auto_Open_ConvexCyOn.LockUI = false;
            this.FC_Auto_Open_ConvexCyOn.Message = null;
            this.FC_Auto_Open_ConvexCyOn.MsgID = 0;
            this.FC_Auto_Open_ConvexCyOn.Name = "FC_Auto_Open_ConvexCyOn";
            this.FC_Auto_Open_ConvexCyOn.NEXT = this.FC_Auto_Open_2ndConvexDetect;
            this.FC_Auto_Open_ConvexCyOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_ConvexCyOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_ConvexCyOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_ConvexCyOn.OverTimeSpec = 100;
            this.FC_Auto_Open_ConvexCyOn.Running = false;
            this.FC_Auto_Open_ConvexCyOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_ConvexCyOn.SlowRunCycle = -1;
            this.FC_Auto_Open_ConvexCyOn.StartFC = null;
            this.FC_Auto_Open_ConvexCyOn.Text = "Convex Cylinder On";
            this.FC_Auto_Open_ConvexCyOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_ConvexCyOn_Run);
            // 
            // FC_Auto_Open_2ndConvexDetect
            // 
            this.FC_Auto_Open_2ndConvexDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_2ndConvexDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_2ndConvexDetect.CASE1 = null;
            this.FC_Auto_Open_2ndConvexDetect.CASE2 = null;
            this.FC_Auto_Open_2ndConvexDetect.CASE3 = null;
            this.FC_Auto_Open_2ndConvexDetect.CASE4 = null;
            this.FC_Auto_Open_2ndConvexDetect.ContinueRun = false;
            this.FC_Auto_Open_2ndConvexDetect.DesignTimeParent = null;
            this.FC_Auto_Open_2ndConvexDetect.EndFC = null;
            this.FC_Auto_Open_2ndConvexDetect.ErrID = 0;
            this.FC_Auto_Open_2ndConvexDetect.InAlarm = false;
            this.FC_Auto_Open_2ndConvexDetect.IsFlowHead = false;
            this.FC_Auto_Open_2ndConvexDetect.Location = new System.Drawing.Point(281, 335);
            this.FC_Auto_Open_2ndConvexDetect.LockUI = false;
            this.FC_Auto_Open_2ndConvexDetect.Message = null;
            this.FC_Auto_Open_2ndConvexDetect.MsgID = 0;
            this.FC_Auto_Open_2ndConvexDetect.Name = "FC_Auto_Open_2ndConvexDetect";
            this.FC_Auto_Open_2ndConvexDetect.NEXT = this.FC_Auto_Open_ConvexCyOff;
            this.FC_Auto_Open_2ndConvexDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_2ndConvexDetect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_2ndConvexDetect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_2ndConvexDetect.OverTimeSpec = 100;
            this.FC_Auto_Open_2ndConvexDetect.Running = false;
            this.FC_Auto_Open_2ndConvexDetect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_2ndConvexDetect.SlowRunCycle = -1;
            this.FC_Auto_Open_2ndConvexDetect.StartFC = null;
            this.FC_Auto_Open_2ndConvexDetect.Text = "Second Convex Detect";
            this.FC_Auto_Open_2ndConvexDetect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_2ndConvexDetect_Run);
            // 
            // FC_Auto_Open_ConvexCyOff
            // 
            this.FC_Auto_Open_ConvexCyOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_ConvexCyOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_ConvexCyOff.CASE1 = null;
            this.FC_Auto_Open_ConvexCyOff.CASE2 = null;
            this.FC_Auto_Open_ConvexCyOff.CASE3 = null;
            this.FC_Auto_Open_ConvexCyOff.CASE4 = null;
            this.FC_Auto_Open_ConvexCyOff.ContinueRun = false;
            this.FC_Auto_Open_ConvexCyOff.DesignTimeParent = null;
            this.FC_Auto_Open_ConvexCyOff.EndFC = null;
            this.FC_Auto_Open_ConvexCyOff.ErrID = 0;
            this.FC_Auto_Open_ConvexCyOff.InAlarm = false;
            this.FC_Auto_Open_ConvexCyOff.IsFlowHead = false;
            this.FC_Auto_Open_ConvexCyOff.Location = new System.Drawing.Point(281, 297);
            this.FC_Auto_Open_ConvexCyOff.LockUI = false;
            this.FC_Auto_Open_ConvexCyOff.Message = null;
            this.FC_Auto_Open_ConvexCyOff.MsgID = 0;
            this.FC_Auto_Open_ConvexCyOff.Name = "FC_Auto_Open_ConvexCyOff";
            this.FC_Auto_Open_ConvexCyOff.NEXT = this.FC_Auto_Open_Done;
            this.FC_Auto_Open_ConvexCyOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_ConvexCyOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_ConvexCyOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_ConvexCyOff.OverTimeSpec = 100;
            this.FC_Auto_Open_ConvexCyOff.Running = false;
            this.FC_Auto_Open_ConvexCyOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_ConvexCyOff.SlowRunCycle = -1;
            this.FC_Auto_Open_ConvexCyOff.StartFC = null;
            this.FC_Auto_Open_ConvexCyOff.Text = "Convex Cylinder Off";
            this.FC_Auto_Open_ConvexCyOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_ConvexCyOff_Run);
            // 
            // FC_Auto_Open_Done
            // 
            this.FC_Auto_Open_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Open_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Open_Done.CASE1 = null;
            this.FC_Auto_Open_Done.CASE2 = null;
            this.FC_Auto_Open_Done.CASE3 = null;
            this.FC_Auto_Open_Done.CASE4 = null;
            this.FC_Auto_Open_Done.ContinueRun = false;
            this.FC_Auto_Open_Done.DesignTimeParent = null;
            this.FC_Auto_Open_Done.EndFC = null;
            this.FC_Auto_Open_Done.ErrID = 0;
            this.FC_Auto_Open_Done.InAlarm = false;
            this.FC_Auto_Open_Done.IsFlowHead = false;
            this.FC_Auto_Open_Done.Location = new System.Drawing.Point(281, 259);
            this.FC_Auto_Open_Done.LockUI = false;
            this.FC_Auto_Open_Done.Message = null;
            this.FC_Auto_Open_Done.MsgID = 0;
            this.FC_Auto_Open_Done.Name = "FC_Auto_Open_Done";
            this.FC_Auto_Open_Done.NEXT = this.FC_Auto_Open_Next_2;
            this.FC_Auto_Open_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Open_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Open_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Open_Done.OverTimeSpec = 100;
            this.FC_Auto_Open_Done.Running = false;
            this.FC_Auto_Open_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Open_Done.SlowRunCycle = -1;
            this.FC_Auto_Open_Done.StartFC = null;
            this.FC_Auto_Open_Done.Text = "Done";
            this.FC_Auto_Open_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Open_Done_Run);
            // 
            // FC_Convex_Cylinder_Next
            // 
            this.FC_Convex_Cylinder_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Convex_Cylinder_Next.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Convex_Cylinder_Next.CASE1 = null;
            this.FC_Convex_Cylinder_Next.CASE2 = null;
            this.FC_Convex_Cylinder_Next.CASE3 = null;
            this.FC_Convex_Cylinder_Next.CASE4 = null;
            this.FC_Convex_Cylinder_Next.ContinueRun = false;
            this.FC_Convex_Cylinder_Next.DesignTimeParent = null;
            this.FC_Convex_Cylinder_Next.EndFC = null;
            this.FC_Convex_Cylinder_Next.ErrID = 0;
            this.FC_Convex_Cylinder_Next.InAlarm = false;
            this.FC_Convex_Cylinder_Next.IsFlowHead = false;
            this.FC_Convex_Cylinder_Next.Location = new System.Drawing.Point(1289, 221);
            this.FC_Convex_Cylinder_Next.LockUI = false;
            this.FC_Convex_Cylinder_Next.Message = null;
            this.FC_Convex_Cylinder_Next.MsgID = 0;
            this.FC_Convex_Cylinder_Next.Name = "FC_Convex_Cylinder_Next";
            this.FC_Convex_Cylinder_Next.NEXT = this.FC_Convex_Cylinder_WaitCmd;
            this.FC_Convex_Cylinder_Next.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Convex_Cylinder_Next.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Convex_Cylinder_Next.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Convex_Cylinder_Next.OverTimeSpec = 100;
            this.FC_Convex_Cylinder_Next.Running = false;
            this.FC_Convex_Cylinder_Next.Size = new System.Drawing.Size(30, 30);
            this.FC_Convex_Cylinder_Next.SlowRunCycle = -1;
            this.FC_Convex_Cylinder_Next.StartFC = null;
            this.FC_Convex_Cylinder_Next.Text = "N";
            this.FC_Convex_Cylinder_Next.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Convex_Cylinder_Next_Run);
            // 
            // FC_Convex_Cylinder_WaitCmd
            // 
            this.FC_Convex_Cylinder_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Convex_Cylinder_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Convex_Cylinder_WaitCmd.CASE1 = null;
            this.FC_Convex_Cylinder_WaitCmd.CASE2 = null;
            this.FC_Convex_Cylinder_WaitCmd.CASE3 = null;
            this.FC_Convex_Cylinder_WaitCmd.CASE4 = null;
            this.FC_Convex_Cylinder_WaitCmd.ContinueRun = false;
            this.FC_Convex_Cylinder_WaitCmd.DesignTimeParent = null;
            this.FC_Convex_Cylinder_WaitCmd.EndFC = null;
            this.FC_Convex_Cylinder_WaitCmd.ErrID = 0;
            this.FC_Convex_Cylinder_WaitCmd.InAlarm = false;
            this.FC_Convex_Cylinder_WaitCmd.IsFlowHead = false;
            this.FC_Convex_Cylinder_WaitCmd.Location = new System.Drawing.Point(1052, 69);
            this.FC_Convex_Cylinder_WaitCmd.LockUI = false;
            this.FC_Convex_Cylinder_WaitCmd.Message = null;
            this.FC_Convex_Cylinder_WaitCmd.MsgID = 0;
            this.FC_Convex_Cylinder_WaitCmd.Name = "FC_Convex_Cylinder_WaitCmd";
            this.FC_Convex_Cylinder_WaitCmd.NEXT = this.flowChart1;
            this.FC_Convex_Cylinder_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Convex_Cylinder_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Convex_Cylinder_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Convex_Cylinder_WaitCmd.OverTimeSpec = 100;
            this.FC_Convex_Cylinder_WaitCmd.Running = false;
            this.FC_Convex_Cylinder_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Convex_Cylinder_WaitCmd.SlowRunCycle = -1;
            this.FC_Convex_Cylinder_WaitCmd.StartFC = null;
            this.FC_Convex_Cylinder_WaitCmd.Text = "Wait Command";
            this.FC_Convex_Cylinder_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Convex_Cylinder_WaitCmd_Run);
            // 
            // flowChart1
            // 
            this.flowChart1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart1.CASE1 = null;
            this.flowChart1.CASE2 = null;
            this.flowChart1.CASE3 = null;
            this.flowChart1.CASE4 = null;
            this.flowChart1.ContinueRun = false;
            this.flowChart1.DesignTimeParent = null;
            this.flowChart1.EndFC = null;
            this.flowChart1.ErrID = 0;
            this.flowChart1.InAlarm = false;
            this.flowChart1.IsFlowHead = false;
            this.flowChart1.Location = new System.Drawing.Point(1052, 107);
            this.flowChart1.LockUI = false;
            this.flowChart1.Message = null;
            this.flowChart1.MsgID = 0;
            this.flowChart1.Name = "flowChart1";
            this.flowChart1.NEXT = this.flowChart2;
            this.flowChart1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart1.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart1.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart1.OverTimeSpec = 100;
            this.flowChart1.Running = false;
            this.flowChart1.Size = new System.Drawing.Size(200, 30);
            this.flowChart1.SlowRunCycle = -1;
            this.flowChart1.StartFC = null;
            this.flowChart1.Text = "Convex Cylinder On";
            this.flowChart1.Run += new ProVLib.FlowChart.RunEventHandler(this.flowChart1_Run);
            // 
            // flowChart2
            // 
            this.flowChart2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart2.CASE1 = null;
            this.flowChart2.CASE2 = null;
            this.flowChart2.CASE3 = null;
            this.flowChart2.CASE4 = null;
            this.flowChart2.ContinueRun = false;
            this.flowChart2.DesignTimeParent = null;
            this.flowChart2.EndFC = null;
            this.flowChart2.ErrID = 0;
            this.flowChart2.InAlarm = false;
            this.flowChart2.IsFlowHead = false;
            this.flowChart2.Location = new System.Drawing.Point(1052, 145);
            this.flowChart2.LockUI = false;
            this.flowChart2.Message = null;
            this.flowChart2.MsgID = 0;
            this.flowChart2.Name = "flowChart2";
            this.flowChart2.NEXT = this.flowChart3;
            this.flowChart2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart2.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart2.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart2.OverTimeSpec = 100;
            this.flowChart2.Running = false;
            this.flowChart2.Size = new System.Drawing.Size(200, 30);
            this.flowChart2.SlowRunCycle = -1;
            this.flowChart2.StartFC = null;
            this.flowChart2.Text = "Second Convex Detect";
            this.flowChart2.Run += new ProVLib.FlowChart.RunEventHandler(this.flowChart2_Run);
            // 
            // flowChart3
            // 
            this.flowChart3.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowChart3.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.flowChart3.CASE1 = null;
            this.flowChart3.CASE2 = null;
            this.flowChart3.CASE3 = null;
            this.flowChart3.CASE4 = null;
            this.flowChart3.ContinueRun = false;
            this.flowChart3.DesignTimeParent = null;
            this.flowChart3.EndFC = null;
            this.flowChart3.ErrID = 0;
            this.flowChart3.InAlarm = false;
            this.flowChart3.IsFlowHead = false;
            this.flowChart3.Location = new System.Drawing.Point(1052, 183);
            this.flowChart3.LockUI = false;
            this.flowChart3.Message = null;
            this.flowChart3.MsgID = 0;
            this.flowChart3.Name = "flowChart3";
            this.flowChart3.NEXT = this.FC_Convex_Cylinder_Done;
            this.flowChart3.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.flowChart3.OrgLocation = new System.Drawing.Point(0, 0);
            this.flowChart3.OrgSize = new System.Drawing.Size(0, 0);
            this.flowChart3.OverTimeSpec = 100;
            this.flowChart3.Running = false;
            this.flowChart3.Size = new System.Drawing.Size(200, 30);
            this.flowChart3.SlowRunCycle = -1;
            this.flowChart3.StartFC = null;
            this.flowChart3.Text = "Convex Cylinder Off";
            this.flowChart3.Run += new ProVLib.FlowChart.RunEventHandler(this.flowChart3_Run);
            // 
            // FC_Convex_Cylinder_Done
            // 
            this.FC_Convex_Cylinder_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Convex_Cylinder_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Convex_Cylinder_Done.CASE1 = null;
            this.FC_Convex_Cylinder_Done.CASE2 = null;
            this.FC_Convex_Cylinder_Done.CASE3 = null;
            this.FC_Convex_Cylinder_Done.CASE4 = null;
            this.FC_Convex_Cylinder_Done.ContinueRun = false;
            this.FC_Convex_Cylinder_Done.DesignTimeParent = null;
            this.FC_Convex_Cylinder_Done.EndFC = null;
            this.FC_Convex_Cylinder_Done.ErrID = 0;
            this.FC_Convex_Cylinder_Done.InAlarm = false;
            this.FC_Convex_Cylinder_Done.IsFlowHead = false;
            this.FC_Convex_Cylinder_Done.Location = new System.Drawing.Point(1052, 221);
            this.FC_Convex_Cylinder_Done.LockUI = false;
            this.FC_Convex_Cylinder_Done.Message = null;
            this.FC_Convex_Cylinder_Done.MsgID = 0;
            this.FC_Convex_Cylinder_Done.Name = "FC_Convex_Cylinder_Done";
            this.FC_Convex_Cylinder_Done.NEXT = this.FC_Convex_Cylinder_Next;
            this.FC_Convex_Cylinder_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Convex_Cylinder_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Convex_Cylinder_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Convex_Cylinder_Done.OverTimeSpec = 100;
            this.FC_Convex_Cylinder_Done.Running = false;
            this.FC_Convex_Cylinder_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Convex_Cylinder_Done.SlowRunCycle = -1;
            this.FC_Convex_Cylinder_Done.StartFC = null;
            this.FC_Convex_Cylinder_Done.Text = "Done";
            this.FC_Convex_Cylinder_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Convex_Cylinder_Done_Run);
            // 
            // FC_Convex_Cylinder_START
            // 
            this.FC_Convex_Cylinder_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Convex_Cylinder_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Convex_Cylinder_START.CASE1 = null;
            this.FC_Convex_Cylinder_START.CASE2 = null;
            this.FC_Convex_Cylinder_START.CASE3 = null;
            this.FC_Convex_Cylinder_START.CASE4 = null;
            this.FC_Convex_Cylinder_START.ContinueRun = false;
            this.FC_Convex_Cylinder_START.DesignTimeParent = null;
            this.FC_Convex_Cylinder_START.EndFC = null;
            this.FC_Convex_Cylinder_START.ErrID = 0;
            this.FC_Convex_Cylinder_START.InAlarm = false;
            this.FC_Convex_Cylinder_START.IsFlowHead = false;
            this.FC_Convex_Cylinder_START.Location = new System.Drawing.Point(1052, 31);
            this.FC_Convex_Cylinder_START.LockUI = false;
            this.FC_Convex_Cylinder_START.Message = null;
            this.FC_Convex_Cylinder_START.MsgID = 0;
            this.FC_Convex_Cylinder_START.Name = "FC_Convex_Cylinder_START";
            this.FC_Convex_Cylinder_START.NEXT = this.FC_Convex_Cylinder_WaitCmd;
            this.FC_Convex_Cylinder_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Convex_Cylinder_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Convex_Cylinder_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Convex_Cylinder_START.OverTimeSpec = 100;
            this.FC_Convex_Cylinder_START.Running = false;
            this.FC_Convex_Cylinder_START.Size = new System.Drawing.Size(200, 30);
            this.FC_Convex_Cylinder_START.SlowRunCycle = -1;
            this.FC_Convex_Cylinder_START.StartFC = null;
            this.FC_Convex_Cylinder_START.Text = "Convex Cylinder Main";
            this.FC_Convex_Cylinder_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Convex_Cylinder_START_Run);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 49);
            this.button2.TabIndex = 43;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FC_Auto_Close_DestoryOff
            // 
            this.FC_Auto_Close_DestoryOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_DestoryOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_DestoryOff.CASE1 = null;
            this.FC_Auto_Close_DestoryOff.CASE2 = null;
            this.FC_Auto_Close_DestoryOff.CASE3 = null;
            this.FC_Auto_Close_DestoryOff.CASE4 = null;
            this.FC_Auto_Close_DestoryOff.ContinueRun = false;
            this.FC_Auto_Close_DestoryOff.DesignTimeParent = null;
            this.FC_Auto_Close_DestoryOff.EndFC = null;
            this.FC_Auto_Close_DestoryOff.ErrID = 0;
            this.FC_Auto_Close_DestoryOff.InAlarm = false;
            this.FC_Auto_Close_DestoryOff.IsFlowHead = false;
            this.FC_Auto_Close_DestoryOff.Location = new System.Drawing.Point(539, 525);
            this.FC_Auto_Close_DestoryOff.LockUI = false;
            this.FC_Auto_Close_DestoryOff.Message = null;
            this.FC_Auto_Close_DestoryOff.MsgID = 0;
            this.FC_Auto_Close_DestoryOff.Name = "FC_Auto_Close_DestoryOff";
            this.FC_Auto_Close_DestoryOff.NEXT = this.FC_Auto_Close_Done;
            this.FC_Auto_Close_DestoryOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_DestoryOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_DestoryOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_DestoryOff.OverTimeSpec = 100;
            this.FC_Auto_Close_DestoryOff.Running = false;
            this.FC_Auto_Close_DestoryOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_DestoryOff.SlowRunCycle = -1;
            this.FC_Auto_Close_DestoryOff.StartFC = null;
            this.FC_Auto_Close_DestoryOff.Text = "Destory Off";
            this.FC_Auto_Close_DestoryOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_DestoryOff_Run);
            // 
            // FC_Auto_Close_Done
            // 
            this.FC_Auto_Close_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_Done.CASE1 = null;
            this.FC_Auto_Close_Done.CASE2 = null;
            this.FC_Auto_Close_Done.CASE3 = null;
            this.FC_Auto_Close_Done.CASE4 = null;
            this.FC_Auto_Close_Done.ContinueRun = false;
            this.FC_Auto_Close_Done.DesignTimeParent = null;
            this.FC_Auto_Close_Done.EndFC = null;
            this.FC_Auto_Close_Done.ErrID = 0;
            this.FC_Auto_Close_Done.InAlarm = false;
            this.FC_Auto_Close_Done.IsFlowHead = false;
            this.FC_Auto_Close_Done.Location = new System.Drawing.Point(782, 525);
            this.FC_Auto_Close_Done.LockUI = false;
            this.FC_Auto_Close_Done.Message = null;
            this.FC_Auto_Close_Done.MsgID = 0;
            this.FC_Auto_Close_Done.Name = "FC_Auto_Close_Done";
            this.FC_Auto_Close_Done.NEXT = this.FC_Auto_Close_Next_2;
            this.FC_Auto_Close_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_Done.OverTimeSpec = 100;
            this.FC_Auto_Close_Done.Running = false;
            this.FC_Auto_Close_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_Done.SlowRunCycle = -1;
            this.FC_Auto_Close_Done.StartFC = null;
            this.FC_Auto_Close_Done.Text = "Done";
            this.FC_Auto_Close_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_Done_Run);
            // 
            // FC_Auto_Close_Next_2
            // 
            this.FC_Auto_Close_Next_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_Next_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_Next_2.CASE1 = null;
            this.FC_Auto_Close_Next_2.CASE2 = null;
            this.FC_Auto_Close_Next_2.CASE3 = null;
            this.FC_Auto_Close_Next_2.CASE4 = null;
            this.FC_Auto_Close_Next_2.ContinueRun = false;
            this.FC_Auto_Close_Next_2.DesignTimeParent = null;
            this.FC_Auto_Close_Next_2.EndFC = null;
            this.FC_Auto_Close_Next_2.ErrID = 0;
            this.FC_Auto_Close_Next_2.InAlarm = false;
            this.FC_Auto_Close_Next_2.IsFlowHead = false;
            this.FC_Auto_Close_Next_2.Location = new System.Drawing.Point(990, 525);
            this.FC_Auto_Close_Next_2.LockUI = false;
            this.FC_Auto_Close_Next_2.Message = null;
            this.FC_Auto_Close_Next_2.MsgID = 0;
            this.FC_Auto_Close_Next_2.Name = "FC_Auto_Close_Next_2";
            this.FC_Auto_Close_Next_2.NEXT = this.FC_Auto_Close_Next_1;
            this.FC_Auto_Close_Next_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_Next_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_Next_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_Next_2.OverTimeSpec = 100;
            this.FC_Auto_Close_Next_2.Running = false;
            this.FC_Auto_Close_Next_2.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Close_Next_2.SlowRunCycle = -1;
            this.FC_Auto_Close_Next_2.StartFC = null;
            this.FC_Auto_Close_Next_2.Text = "N";
            this.FC_Auto_Close_Next_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_Next_2_Run);
            // 
            // FC_Auto_Close_Next_1
            // 
            this.FC_Auto_Close_Next_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_Next_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_Next_1.CASE1 = null;
            this.FC_Auto_Close_Next_1.CASE2 = null;
            this.FC_Auto_Close_Next_1.CASE3 = null;
            this.FC_Auto_Close_Next_1.CASE4 = null;
            this.FC_Auto_Close_Next_1.ContinueRun = false;
            this.FC_Auto_Close_Next_1.DesignTimeParent = null;
            this.FC_Auto_Close_Next_1.EndFC = null;
            this.FC_Auto_Close_Next_1.ErrID = 0;
            this.FC_Auto_Close_Next_1.InAlarm = false;
            this.FC_Auto_Close_Next_1.IsFlowHead = false;
            this.FC_Auto_Close_Next_1.Location = new System.Drawing.Point(990, 69);
            this.FC_Auto_Close_Next_1.LockUI = false;
            this.FC_Auto_Close_Next_1.Message = null;
            this.FC_Auto_Close_Next_1.MsgID = 0;
            this.FC_Auto_Close_Next_1.Name = "FC_Auto_Close_Next_1";
            this.FC_Auto_Close_Next_1.NEXT = this.FC_Auto_Close_WaitCmd;
            this.FC_Auto_Close_Next_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_Next_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_Next_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_Next_1.OverTimeSpec = 100;
            this.FC_Auto_Close_Next_1.Running = false;
            this.FC_Auto_Close_Next_1.Size = new System.Drawing.Size(30, 30);
            this.FC_Auto_Close_Next_1.SlowRunCycle = -1;
            this.FC_Auto_Close_Next_1.StartFC = null;
            this.FC_Auto_Close_Next_1.Text = "N";
            this.FC_Auto_Close_Next_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_Next_1_Run);
            // 
            // FC_Auto_Close_WaitCmd
            // 
            this.FC_Auto_Close_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_WaitCmd.CASE1 = null;
            this.FC_Auto_Close_WaitCmd.CASE2 = null;
            this.FC_Auto_Close_WaitCmd.CASE3 = null;
            this.FC_Auto_Close_WaitCmd.CASE4 = null;
            this.FC_Auto_Close_WaitCmd.ContinueRun = false;
            this.FC_Auto_Close_WaitCmd.DesignTimeParent = null;
            this.FC_Auto_Close_WaitCmd.EndFC = null;
            this.FC_Auto_Close_WaitCmd.ErrID = 0;
            this.FC_Auto_Close_WaitCmd.InAlarm = false;
            this.FC_Auto_Close_WaitCmd.IsFlowHead = false;
            this.FC_Auto_Close_WaitCmd.Location = new System.Drawing.Point(539, 69);
            this.FC_Auto_Close_WaitCmd.LockUI = false;
            this.FC_Auto_Close_WaitCmd.Message = null;
            this.FC_Auto_Close_WaitCmd.MsgID = 0;
            this.FC_Auto_Close_WaitCmd.Name = "FC_Auto_Close_WaitCmd";
            this.FC_Auto_Close_WaitCmd.NEXT = this.FC_Auto_Close_ConvexCyOff;
            this.FC_Auto_Close_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_WaitCmd.OverTimeSpec = 100;
            this.FC_Auto_Close_WaitCmd.Running = false;
            this.FC_Auto_Close_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_WaitCmd.SlowRunCycle = -1;
            this.FC_Auto_Close_WaitCmd.StartFC = null;
            this.FC_Auto_Close_WaitCmd.Text = "Wait Command";
            this.FC_Auto_Close_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_WaitCmd_Run);
            // 
            // FC_Auto_Close_ConvexCyOff
            // 
            this.FC_Auto_Close_ConvexCyOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_ConvexCyOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_ConvexCyOff.CASE1 = null;
            this.FC_Auto_Close_ConvexCyOff.CASE2 = null;
            this.FC_Auto_Close_ConvexCyOff.CASE3 = null;
            this.FC_Auto_Close_ConvexCyOff.CASE4 = null;
            this.FC_Auto_Close_ConvexCyOff.ContinueRun = false;
            this.FC_Auto_Close_ConvexCyOff.DesignTimeParent = null;
            this.FC_Auto_Close_ConvexCyOff.EndFC = null;
            this.FC_Auto_Close_ConvexCyOff.ErrID = 0;
            this.FC_Auto_Close_ConvexCyOff.InAlarm = false;
            this.FC_Auto_Close_ConvexCyOff.IsFlowHead = false;
            this.FC_Auto_Close_ConvexCyOff.Location = new System.Drawing.Point(539, 107);
            this.FC_Auto_Close_ConvexCyOff.LockUI = false;
            this.FC_Auto_Close_ConvexCyOff.Message = null;
            this.FC_Auto_Close_ConvexCyOff.MsgID = 0;
            this.FC_Auto_Close_ConvexCyOff.Name = "FC_Auto_Close_ConvexCyOff";
            this.FC_Auto_Close_ConvexCyOff.NEXT = this.FC_Auto_Close_DoorYPush;
            this.FC_Auto_Close_ConvexCyOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_ConvexCyOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_ConvexCyOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_ConvexCyOff.OverTimeSpec = 100;
            this.FC_Auto_Close_ConvexCyOff.Running = false;
            this.FC_Auto_Close_ConvexCyOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_ConvexCyOff.SlowRunCycle = -1;
            this.FC_Auto_Close_ConvexCyOff.StartFC = null;
            this.FC_Auto_Close_ConvexCyOff.Text = "Convex Cylinder Off";
            this.FC_Auto_Close_ConvexCyOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_ConvexCyOff_Run);
            // 
            // FC_Auto_Close_DoorYPush
            // 
            this.FC_Auto_Close_DoorYPush.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_DoorYPush.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_DoorYPush.CASE1 = null;
            this.FC_Auto_Close_DoorYPush.CASE2 = null;
            this.FC_Auto_Close_DoorYPush.CASE3 = null;
            this.FC_Auto_Close_DoorYPush.CASE4 = null;
            this.FC_Auto_Close_DoorYPush.ContinueRun = false;
            this.FC_Auto_Close_DoorYPush.DesignTimeParent = null;
            this.FC_Auto_Close_DoorYPush.EndFC = null;
            this.FC_Auto_Close_DoorYPush.ErrID = 0;
            this.FC_Auto_Close_DoorYPush.InAlarm = false;
            this.FC_Auto_Close_DoorYPush.IsFlowHead = false;
            this.FC_Auto_Close_DoorYPush.Location = new System.Drawing.Point(539, 145);
            this.FC_Auto_Close_DoorYPush.LockUI = false;
            this.FC_Auto_Close_DoorYPush.Message = null;
            this.FC_Auto_Close_DoorYPush.MsgID = 0;
            this.FC_Auto_Close_DoorYPush.Name = "FC_Auto_Close_DoorYPush";
            this.FC_Auto_Close_DoorYPush.NEXT = this.FC_Auto_Close_VaccumOn;
            this.FC_Auto_Close_DoorYPush.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_DoorYPush.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_DoorYPush.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_DoorYPush.OverTimeSpec = 100;
            this.FC_Auto_Close_DoorYPush.Running = false;
            this.FC_Auto_Close_DoorYPush.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_DoorYPush.SlowRunCycle = -1;
            this.FC_Auto_Close_DoorYPush.StartFC = null;
            this.FC_Auto_Close_DoorYPush.Text = "Door Y Push";
            this.FC_Auto_Close_DoorYPush.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_DoorYPush_Run);
            // 
            // FC_Auto_Close_VaccumOn
            // 
            this.FC_Auto_Close_VaccumOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_VaccumOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_VaccumOn.CASE1 = null;
            this.FC_Auto_Close_VaccumOn.CASE2 = null;
            this.FC_Auto_Close_VaccumOn.CASE3 = null;
            this.FC_Auto_Close_VaccumOn.CASE4 = null;
            this.FC_Auto_Close_VaccumOn.ContinueRun = false;
            this.FC_Auto_Close_VaccumOn.DesignTimeParent = null;
            this.FC_Auto_Close_VaccumOn.EndFC = null;
            this.FC_Auto_Close_VaccumOn.ErrID = 0;
            this.FC_Auto_Close_VaccumOn.InAlarm = false;
            this.FC_Auto_Close_VaccumOn.IsFlowHead = false;
            this.FC_Auto_Close_VaccumOn.Location = new System.Drawing.Point(539, 183);
            this.FC_Auto_Close_VaccumOn.LockUI = false;
            this.FC_Auto_Close_VaccumOn.Message = null;
            this.FC_Auto_Close_VaccumOn.MsgID = 0;
            this.FC_Auto_Close_VaccumOn.Name = "FC_Auto_Close_VaccumOn";
            this.FC_Auto_Close_VaccumOn.NEXT = this.FC_Auto_Close_CoverDetect;
            this.FC_Auto_Close_VaccumOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_VaccumOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_VaccumOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_VaccumOn.OverTimeSpec = 100;
            this.FC_Auto_Close_VaccumOn.Running = false;
            this.FC_Auto_Close_VaccumOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_VaccumOn.SlowRunCycle = -1;
            this.FC_Auto_Close_VaccumOn.StartFC = null;
            this.FC_Auto_Close_VaccumOn.Text = "Vaccum On";
            this.FC_Auto_Close_VaccumOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_VaccumOn_Run);
            // 
            // FC_Auto_Close_CoverDetect
            // 
            this.FC_Auto_Close_CoverDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_CoverDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_CoverDetect.CASE1 = this.FC_Auto_Close_CheckHasFoup;
            this.FC_Auto_Close_CoverDetect.CASE2 = null;
            this.FC_Auto_Close_CoverDetect.CASE3 = null;
            this.FC_Auto_Close_CoverDetect.CASE4 = null;
            this.FC_Auto_Close_CoverDetect.ContinueRun = false;
            this.FC_Auto_Close_CoverDetect.DesignTimeParent = null;
            this.FC_Auto_Close_CoverDetect.EndFC = null;
            this.FC_Auto_Close_CoverDetect.ErrID = 0;
            this.FC_Auto_Close_CoverDetect.InAlarm = false;
            this.FC_Auto_Close_CoverDetect.IsFlowHead = false;
            this.FC_Auto_Close_CoverDetect.Location = new System.Drawing.Point(539, 221);
            this.FC_Auto_Close_CoverDetect.LockUI = false;
            this.FC_Auto_Close_CoverDetect.Message = null;
            this.FC_Auto_Close_CoverDetect.MsgID = 0;
            this.FC_Auto_Close_CoverDetect.Name = "FC_Auto_Close_CoverDetect";
            this.FC_Auto_Close_CoverDetect.NEXT = this.FC_Auto_Close_VaccumOff;
            this.FC_Auto_Close_CoverDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_CoverDetect.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_CoverDetect.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_CoverDetect.OverTimeSpec = 100;
            this.FC_Auto_Close_CoverDetect.Running = false;
            this.FC_Auto_Close_CoverDetect.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_CoverDetect.SlowRunCycle = -1;
            this.FC_Auto_Close_CoverDetect.StartFC = null;
            this.FC_Auto_Close_CoverDetect.Text = "Cover Detect";
            this.FC_Auto_Close_CoverDetect.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_CoverDetect_Run);
            // 
            // FC_Auto_Close_CheckHasFoup
            // 
            this.FC_Auto_Close_CheckHasFoup.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_CheckHasFoup.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_CheckHasFoup.CASE1 = null;
            this.FC_Auto_Close_CheckHasFoup.CASE2 = null;
            this.FC_Auto_Close_CheckHasFoup.CASE3 = null;
            this.FC_Auto_Close_CheckHasFoup.CASE4 = null;
            this.FC_Auto_Close_CheckHasFoup.ContinueRun = false;
            this.FC_Auto_Close_CheckHasFoup.DesignTimeParent = null;
            this.FC_Auto_Close_CheckHasFoup.EndFC = null;
            this.FC_Auto_Close_CheckHasFoup.ErrID = 0;
            this.FC_Auto_Close_CheckHasFoup.InAlarm = false;
            this.FC_Auto_Close_CheckHasFoup.IsFlowHead = false;
            this.FC_Auto_Close_CheckHasFoup.Location = new System.Drawing.Point(782, 221);
            this.FC_Auto_Close_CheckHasFoup.LockUI = false;
            this.FC_Auto_Close_CheckHasFoup.Message = null;
            this.FC_Auto_Close_CheckHasFoup.MsgID = 0;
            this.FC_Auto_Close_CheckHasFoup.Name = "FC_Auto_Close_CheckHasFoup";
            this.FC_Auto_Close_CheckHasFoup.NEXT = this.FC_Auto_Close_CheckPlacement;
            this.FC_Auto_Close_CheckHasFoup.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_CheckHasFoup.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_CheckHasFoup.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_CheckHasFoup.OverTimeSpec = 100;
            this.FC_Auto_Close_CheckHasFoup.Running = false;
            this.FC_Auto_Close_CheckHasFoup.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_CheckHasFoup.SlowRunCycle = -1;
            this.FC_Auto_Close_CheckHasFoup.StartFC = null;
            this.FC_Auto_Close_CheckHasFoup.Text = "Check Has Foup";
            this.FC_Auto_Close_CheckHasFoup.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_CheckHasFoup_Run);
            // 
            // FC_Auto_Close_CheckPlacement
            // 
            this.FC_Auto_Close_CheckPlacement.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_CheckPlacement.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_CheckPlacement.CASE1 = null;
            this.FC_Auto_Close_CheckPlacement.CASE2 = null;
            this.FC_Auto_Close_CheckPlacement.CASE3 = null;
            this.FC_Auto_Close_CheckPlacement.CASE4 = null;
            this.FC_Auto_Close_CheckPlacement.ContinueRun = false;
            this.FC_Auto_Close_CheckPlacement.DesignTimeParent = null;
            this.FC_Auto_Close_CheckPlacement.EndFC = null;
            this.FC_Auto_Close_CheckPlacement.ErrID = 0;
            this.FC_Auto_Close_CheckPlacement.InAlarm = false;
            this.FC_Auto_Close_CheckPlacement.IsFlowHead = false;
            this.FC_Auto_Close_CheckPlacement.Location = new System.Drawing.Point(782, 297);
            this.FC_Auto_Close_CheckPlacement.LockUI = false;
            this.FC_Auto_Close_CheckPlacement.Message = null;
            this.FC_Auto_Close_CheckPlacement.MsgID = 0;
            this.FC_Auto_Close_CheckPlacement.Name = "FC_Auto_Close_CheckPlacement";
            this.FC_Auto_Close_CheckPlacement.NEXT = this.FC_Auto_Close_DoorZUp;
            this.FC_Auto_Close_CheckPlacement.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_CheckPlacement.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_CheckPlacement.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_CheckPlacement.OverTimeSpec = 100;
            this.FC_Auto_Close_CheckPlacement.Running = false;
            this.FC_Auto_Close_CheckPlacement.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_CheckPlacement.SlowRunCycle = -1;
            this.FC_Auto_Close_CheckPlacement.StartFC = null;
            this.FC_Auto_Close_CheckPlacement.Text = "Check Placement";
            this.FC_Auto_Close_CheckPlacement.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_CheckPlacement_Run);
            // 
            // FC_Auto_Close_DoorZUp
            // 
            this.FC_Auto_Close_DoorZUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_DoorZUp.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_DoorZUp.CASE1 = null;
            this.FC_Auto_Close_DoorZUp.CASE2 = null;
            this.FC_Auto_Close_DoorZUp.CASE3 = null;
            this.FC_Auto_Close_DoorZUp.CASE4 = null;
            this.FC_Auto_Close_DoorZUp.ContinueRun = false;
            this.FC_Auto_Close_DoorZUp.DesignTimeParent = null;
            this.FC_Auto_Close_DoorZUp.EndFC = null;
            this.FC_Auto_Close_DoorZUp.ErrID = 0;
            this.FC_Auto_Close_DoorZUp.InAlarm = false;
            this.FC_Auto_Close_DoorZUp.IsFlowHead = false;
            this.FC_Auto_Close_DoorZUp.Location = new System.Drawing.Point(539, 297);
            this.FC_Auto_Close_DoorZUp.LockUI = false;
            this.FC_Auto_Close_DoorZUp.Message = null;
            this.FC_Auto_Close_DoorZUp.MsgID = 0;
            this.FC_Auto_Close_DoorZUp.Name = "FC_Auto_Close_DoorZUp";
            this.FC_Auto_Close_DoorZUp.NEXT = this.FC_Auto_Close_DoorYPull;
            this.FC_Auto_Close_DoorZUp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_DoorZUp.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_DoorZUp.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_DoorZUp.OverTimeSpec = 100;
            this.FC_Auto_Close_DoorZUp.Running = false;
            this.FC_Auto_Close_DoorZUp.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_DoorZUp.SlowRunCycle = -1;
            this.FC_Auto_Close_DoorZUp.StartFC = null;
            this.FC_Auto_Close_DoorZUp.Text = "Door Z Up";
            this.FC_Auto_Close_DoorZUp.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_DoorZUp_Run);
            // 
            // FC_Auto_Close_DoorYPull
            // 
            this.FC_Auto_Close_DoorYPull.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_DoorYPull.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_DoorYPull.CASE1 = null;
            this.FC_Auto_Close_DoorYPull.CASE2 = null;
            this.FC_Auto_Close_DoorYPull.CASE3 = null;
            this.FC_Auto_Close_DoorYPull.CASE4 = null;
            this.FC_Auto_Close_DoorYPull.ContinueRun = false;
            this.FC_Auto_Close_DoorYPull.DesignTimeParent = null;
            this.FC_Auto_Close_DoorYPull.EndFC = null;
            this.FC_Auto_Close_DoorYPull.ErrID = 0;
            this.FC_Auto_Close_DoorYPull.InAlarm = false;
            this.FC_Auto_Close_DoorYPull.IsFlowHead = false;
            this.FC_Auto_Close_DoorYPull.Location = new System.Drawing.Point(539, 335);
            this.FC_Auto_Close_DoorYPull.LockUI = false;
            this.FC_Auto_Close_DoorYPull.Message = null;
            this.FC_Auto_Close_DoorYPull.MsgID = 0;
            this.FC_Auto_Close_DoorYPull.Name = "FC_Auto_Close_DoorYPull";
            this.FC_Auto_Close_DoorYPull.NEXT = this.FC_Auto_Close_2ndVaccumOff;
            this.FC_Auto_Close_DoorYPull.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_DoorYPull.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_DoorYPull.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_DoorYPull.OverTimeSpec = 100;
            this.FC_Auto_Close_DoorYPull.Running = false;
            this.FC_Auto_Close_DoorYPull.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_DoorYPull.SlowRunCycle = -1;
            this.FC_Auto_Close_DoorYPull.StartFC = null;
            this.FC_Auto_Close_DoorYPull.Text = "Door Y Pull";
            this.FC_Auto_Close_DoorYPull.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_DoorYPull_Run);
            // 
            // FC_Auto_Close_2ndVaccumOff
            // 
            this.FC_Auto_Close_2ndVaccumOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_2ndVaccumOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_2ndVaccumOff.CASE1 = null;
            this.FC_Auto_Close_2ndVaccumOff.CASE2 = null;
            this.FC_Auto_Close_2ndVaccumOff.CASE3 = null;
            this.FC_Auto_Close_2ndVaccumOff.CASE4 = null;
            this.FC_Auto_Close_2ndVaccumOff.ContinueRun = false;
            this.FC_Auto_Close_2ndVaccumOff.DesignTimeParent = null;
            this.FC_Auto_Close_2ndVaccumOff.EndFC = null;
            this.FC_Auto_Close_2ndVaccumOff.ErrID = 0;
            this.FC_Auto_Close_2ndVaccumOff.InAlarm = false;
            this.FC_Auto_Close_2ndVaccumOff.IsFlowHead = false;
            this.FC_Auto_Close_2ndVaccumOff.Location = new System.Drawing.Point(539, 373);
            this.FC_Auto_Close_2ndVaccumOff.LockUI = false;
            this.FC_Auto_Close_2ndVaccumOff.Message = null;
            this.FC_Auto_Close_2ndVaccumOff.MsgID = 0;
            this.FC_Auto_Close_2ndVaccumOff.Name = "FC_Auto_Close_2ndVaccumOff";
            this.FC_Auto_Close_2ndVaccumOff.NEXT = this.FC_Auto_Close_LatchKeyOff;
            this.FC_Auto_Close_2ndVaccumOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_2ndVaccumOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_2ndVaccumOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_2ndVaccumOff.OverTimeSpec = 100;
            this.FC_Auto_Close_2ndVaccumOff.Running = false;
            this.FC_Auto_Close_2ndVaccumOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_2ndVaccumOff.SlowRunCycle = -1;
            this.FC_Auto_Close_2ndVaccumOff.StartFC = null;
            this.FC_Auto_Close_2ndVaccumOff.Text = "Vaccum Off";
            this.FC_Auto_Close_2ndVaccumOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_2ndVaccumOff_Run);
            // 
            // FC_Auto_Close_LatchKeyOff
            // 
            this.FC_Auto_Close_LatchKeyOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_LatchKeyOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_LatchKeyOff.CASE1 = null;
            this.FC_Auto_Close_LatchKeyOff.CASE2 = null;
            this.FC_Auto_Close_LatchKeyOff.CASE3 = null;
            this.FC_Auto_Close_LatchKeyOff.CASE4 = null;
            this.FC_Auto_Close_LatchKeyOff.ContinueRun = false;
            this.FC_Auto_Close_LatchKeyOff.DesignTimeParent = null;
            this.FC_Auto_Close_LatchKeyOff.EndFC = null;
            this.FC_Auto_Close_LatchKeyOff.ErrID = 0;
            this.FC_Auto_Close_LatchKeyOff.InAlarm = false;
            this.FC_Auto_Close_LatchKeyOff.IsFlowHead = false;
            this.FC_Auto_Close_LatchKeyOff.Location = new System.Drawing.Point(539, 411);
            this.FC_Auto_Close_LatchKeyOff.LockUI = false;
            this.FC_Auto_Close_LatchKeyOff.Message = null;
            this.FC_Auto_Close_LatchKeyOff.MsgID = 0;
            this.FC_Auto_Close_LatchKeyOff.Name = "FC_Auto_Close_LatchKeyOff";
            this.FC_Auto_Close_LatchKeyOff.NEXT = this.FC_Auto_Close_DestoryOn;
            this.FC_Auto_Close_LatchKeyOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_LatchKeyOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_LatchKeyOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_LatchKeyOff.OverTimeSpec = 100;
            this.FC_Auto_Close_LatchKeyOff.Running = false;
            this.FC_Auto_Close_LatchKeyOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_LatchKeyOff.SlowRunCycle = -1;
            this.FC_Auto_Close_LatchKeyOff.StartFC = null;
            this.FC_Auto_Close_LatchKeyOff.Text = "Latch key Off";
            this.FC_Auto_Close_LatchKeyOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_LatchKeyOff_Run);
            // 
            // FC_Auto_Close_DestoryOn
            // 
            this.FC_Auto_Close_DestoryOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_DestoryOn.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_DestoryOn.CASE1 = null;
            this.FC_Auto_Close_DestoryOn.CASE2 = null;
            this.FC_Auto_Close_DestoryOn.CASE3 = null;
            this.FC_Auto_Close_DestoryOn.CASE4 = null;
            this.FC_Auto_Close_DestoryOn.ContinueRun = false;
            this.FC_Auto_Close_DestoryOn.DesignTimeParent = null;
            this.FC_Auto_Close_DestoryOn.EndFC = null;
            this.FC_Auto_Close_DestoryOn.ErrID = 0;
            this.FC_Auto_Close_DestoryOn.InAlarm = false;
            this.FC_Auto_Close_DestoryOn.IsFlowHead = false;
            this.FC_Auto_Close_DestoryOn.Location = new System.Drawing.Point(539, 449);
            this.FC_Auto_Close_DestoryOn.LockUI = false;
            this.FC_Auto_Close_DestoryOn.Message = null;
            this.FC_Auto_Close_DestoryOn.MsgID = 0;
            this.FC_Auto_Close_DestoryOn.Name = "FC_Auto_Close_DestoryOn";
            this.FC_Auto_Close_DestoryOn.NEXT = this.FC_Auto_Close_TablePull;
            this.FC_Auto_Close_DestoryOn.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_DestoryOn.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_DestoryOn.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_DestoryOn.OverTimeSpec = 100;
            this.FC_Auto_Close_DestoryOn.Running = false;
            this.FC_Auto_Close_DestoryOn.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_DestoryOn.SlowRunCycle = -1;
            this.FC_Auto_Close_DestoryOn.StartFC = null;
            this.FC_Auto_Close_DestoryOn.Text = "Destory On";
            this.FC_Auto_Close_DestoryOn.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_DestoryOn_Run);
            // 
            // FC_Auto_Close_TablePull
            // 
            this.FC_Auto_Close_TablePull.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_TablePull.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_TablePull.CASE1 = null;
            this.FC_Auto_Close_TablePull.CASE2 = null;
            this.FC_Auto_Close_TablePull.CASE3 = null;
            this.FC_Auto_Close_TablePull.CASE4 = null;
            this.FC_Auto_Close_TablePull.ContinueRun = false;
            this.FC_Auto_Close_TablePull.DesignTimeParent = null;
            this.FC_Auto_Close_TablePull.EndFC = null;
            this.FC_Auto_Close_TablePull.ErrID = 0;
            this.FC_Auto_Close_TablePull.InAlarm = false;
            this.FC_Auto_Close_TablePull.IsFlowHead = false;
            this.FC_Auto_Close_TablePull.Location = new System.Drawing.Point(539, 487);
            this.FC_Auto_Close_TablePull.LockUI = false;
            this.FC_Auto_Close_TablePull.Message = null;
            this.FC_Auto_Close_TablePull.MsgID = 0;
            this.FC_Auto_Close_TablePull.Name = "FC_Auto_Close_TablePull";
            this.FC_Auto_Close_TablePull.NEXT = this.FC_Auto_Close_DestoryOff;
            this.FC_Auto_Close_TablePull.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_TablePull.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_TablePull.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_TablePull.OverTimeSpec = 100;
            this.FC_Auto_Close_TablePull.Running = false;
            this.FC_Auto_Close_TablePull.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_TablePull.SlowRunCycle = -1;
            this.FC_Auto_Close_TablePull.StartFC = null;
            this.FC_Auto_Close_TablePull.Text = "Table Pull";
            this.FC_Auto_Close_TablePull.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_TablePull_Run);
            // 
            // FC_Auto_Close_VaccumOff
            // 
            this.FC_Auto_Close_VaccumOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Auto_Close_VaccumOff.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Auto_Close_VaccumOff.CASE1 = null;
            this.FC_Auto_Close_VaccumOff.CASE2 = null;
            this.FC_Auto_Close_VaccumOff.CASE3 = null;
            this.FC_Auto_Close_VaccumOff.CASE4 = null;
            this.FC_Auto_Close_VaccumOff.ContinueRun = false;
            this.FC_Auto_Close_VaccumOff.DesignTimeParent = null;
            this.FC_Auto_Close_VaccumOff.EndFC = null;
            this.FC_Auto_Close_VaccumOff.ErrID = 0;
            this.FC_Auto_Close_VaccumOff.InAlarm = false;
            this.FC_Auto_Close_VaccumOff.IsFlowHead = false;
            this.FC_Auto_Close_VaccumOff.Location = new System.Drawing.Point(539, 259);
            this.FC_Auto_Close_VaccumOff.LockUI = false;
            this.FC_Auto_Close_VaccumOff.Message = null;
            this.FC_Auto_Close_VaccumOff.MsgID = 0;
            this.FC_Auto_Close_VaccumOff.Name = "FC_Auto_Close_VaccumOff";
            this.FC_Auto_Close_VaccumOff.NEXT = this.FC_Auto_Close_DoorZUp;
            this.FC_Auto_Close_VaccumOff.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Auto_Close_VaccumOff.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Auto_Close_VaccumOff.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Auto_Close_VaccumOff.OverTimeSpec = 100;
            this.FC_Auto_Close_VaccumOff.Running = false;
            this.FC_Auto_Close_VaccumOff.Size = new System.Drawing.Size(200, 30);
            this.FC_Auto_Close_VaccumOff.SlowRunCycle = -1;
            this.FC_Auto_Close_VaccumOff.StartFC = null;
            this.FC_Auto_Close_VaccumOff.Text = "Vaccum Off";
            this.FC_Auto_Close_VaccumOff.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Auto_Close_VaccumOff_Run);
            // 
            // FC_CLOSE_START
            // 
            this.FC_CLOSE_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_CLOSE_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_CLOSE_START.CASE1 = null;
            this.FC_CLOSE_START.CASE2 = null;
            this.FC_CLOSE_START.CASE3 = null;
            this.FC_CLOSE_START.CASE4 = null;
            this.FC_CLOSE_START.ContinueRun = false;
            this.FC_CLOSE_START.DesignTimeParent = null;
            this.FC_CLOSE_START.EndFC = null;
            this.FC_CLOSE_START.ErrID = 0;
            this.FC_CLOSE_START.InAlarm = false;
            this.FC_CLOSE_START.IsFlowHead = false;
            this.FC_CLOSE_START.Location = new System.Drawing.Point(539, 31);
            this.FC_CLOSE_START.LockUI = false;
            this.FC_CLOSE_START.Message = null;
            this.FC_CLOSE_START.MsgID = 0;
            this.FC_CLOSE_START.Name = "FC_CLOSE_START";
            this.FC_CLOSE_START.NEXT = this.FC_Auto_Close_WaitCmd;
            this.FC_CLOSE_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_CLOSE_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_CLOSE_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_CLOSE_START.OverTimeSpec = 100;
            this.FC_CLOSE_START.Running = false;
            this.FC_CLOSE_START.Size = new System.Drawing.Size(200, 30);
            this.FC_CLOSE_START.SlowRunCycle = -1;
            this.FC_CLOSE_START.StartFC = null;
            this.FC_CLOSE_START.Text = "Close Action Main";
            this.FC_CLOSE_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_CLOSE_START_Run);
            // 
            // FC_OPEN_START
            // 
            this.FC_OPEN_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_OPEN_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_OPEN_START.CASE1 = null;
            this.FC_OPEN_START.CASE2 = null;
            this.FC_OPEN_START.CASE3 = null;
            this.FC_OPEN_START.CASE4 = null;
            this.FC_OPEN_START.ContinueRun = false;
            this.FC_OPEN_START.DesignTimeParent = null;
            this.FC_OPEN_START.EndFC = null;
            this.FC_OPEN_START.ErrID = 0;
            this.FC_OPEN_START.InAlarm = false;
            this.FC_OPEN_START.IsFlowHead = false;
            this.FC_OPEN_START.Location = new System.Drawing.Point(75, 31);
            this.FC_OPEN_START.LockUI = false;
            this.FC_OPEN_START.Message = null;
            this.FC_OPEN_START.MsgID = 0;
            this.FC_OPEN_START.Name = "FC_OPEN_START";
            this.FC_OPEN_START.NEXT = this.FC_Auto_Open_WaitCmd;
            this.FC_OPEN_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_OPEN_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_OPEN_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_OPEN_START.OverTimeSpec = 100;
            this.FC_OPEN_START.Running = false;
            this.FC_OPEN_START.Size = new System.Drawing.Size(200, 30);
            this.FC_OPEN_START.SlowRunCycle = -1;
            this.FC_OPEN_START.StartFC = null;
            this.FC_OPEN_START.Text = "Open Action Main";
            this.FC_OPEN_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_OPEN_START_Run);
            // 
            // FC_Home_LockDone
            // 
            this.FC_Home_LockDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_LockDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_LockDone.CASE1 = null;
            this.FC_Home_LockDone.CASE2 = null;
            this.FC_Home_LockDone.CASE3 = null;
            this.FC_Home_LockDone.CASE4 = null;
            this.FC_Home_LockDone.ContinueRun = false;
            this.FC_Home_LockDone.DesignTimeParent = null;
            this.FC_Home_LockDone.EndFC = null;
            this.FC_Home_LockDone.ErrID = 0;
            this.FC_Home_LockDone.InAlarm = false;
            this.FC_Home_LockDone.IsFlowHead = false;
            this.FC_Home_LockDone.Location = new System.Drawing.Point(295, 146);
            this.FC_Home_LockDone.LockUI = false;
            this.FC_Home_LockDone.Message = null;
            this.FC_Home_LockDone.MsgID = 0;
            this.FC_Home_LockDone.Name = "FC_Home_LockDone";
            this.FC_Home_LockDone.NEXT = this.FC_Home_DoClose;
            this.FC_Home_LockDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_LockDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_LockDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_LockDone.OverTimeSpec = 100;
            this.FC_Home_LockDone.Running = false;
            this.FC_Home_LockDone.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_LockDone.SlowRunCycle = -1;
            this.FC_Home_LockDone.StartFC = null;
            this.FC_Home_LockDone.Text = "Lock Done";
            this.FC_Home_LockDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_LockDone_Run);
            // 
            // FC_Home_DoClose
            // 
            this.FC_Home_DoClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoClose.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoClose.CASE1 = null;
            this.FC_Home_DoClose.CASE2 = null;
            this.FC_Home_DoClose.CASE3 = null;
            this.FC_Home_DoClose.CASE4 = null;
            this.FC_Home_DoClose.ContinueRun = false;
            this.FC_Home_DoClose.DesignTimeParent = null;
            this.FC_Home_DoClose.EndFC = null;
            this.FC_Home_DoClose.ErrID = 0;
            this.FC_Home_DoClose.InAlarm = false;
            this.FC_Home_DoClose.IsFlowHead = false;
            this.FC_Home_DoClose.Location = new System.Drawing.Point(73, 146);
            this.FC_Home_DoClose.LockUI = false;
            this.FC_Home_DoClose.Message = null;
            this.FC_Home_DoClose.MsgID = 0;
            this.FC_Home_DoClose.Name = "FC_Home_DoClose";
            this.FC_Home_DoClose.NEXT = this.FC_Home_CloseDone;
            this.FC_Home_DoClose.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoClose.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoClose.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoClose.OverTimeSpec = 100;
            this.FC_Home_DoClose.Running = false;
            this.FC_Home_DoClose.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_DoClose.SlowRunCycle = -1;
            this.FC_Home_DoClose.StartFC = null;
            this.FC_Home_DoClose.Text = "Do Close";
            this.FC_Home_DoClose.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoClose_Run);
            // 
            // FC_Home_CloseDone
            // 
            this.FC_Home_CloseDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CloseDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CloseDone.CASE1 = null;
            this.FC_Home_CloseDone.CASE2 = null;
            this.FC_Home_CloseDone.CASE3 = null;
            this.FC_Home_CloseDone.CASE4 = null;
            this.FC_Home_CloseDone.ContinueRun = false;
            this.FC_Home_CloseDone.DesignTimeParent = null;
            this.FC_Home_CloseDone.EndFC = null;
            this.FC_Home_CloseDone.ErrID = 0;
            this.FC_Home_CloseDone.InAlarm = false;
            this.FC_Home_CloseDone.IsFlowHead = false;
            this.FC_Home_CloseDone.Location = new System.Drawing.Point(73, 184);
            this.FC_Home_CloseDone.LockUI = false;
            this.FC_Home_CloseDone.Message = null;
            this.FC_Home_CloseDone.MsgID = 0;
            this.FC_Home_CloseDone.Name = "FC_Home_CloseDone";
            this.FC_Home_CloseDone.NEXT = this.FC_Home_DoUnlock;
            this.FC_Home_CloseDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CloseDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CloseDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CloseDone.OverTimeSpec = 100;
            this.FC_Home_CloseDone.Running = false;
            this.FC_Home_CloseDone.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_CloseDone.SlowRunCycle = -1;
            this.FC_Home_CloseDone.StartFC = null;
            this.FC_Home_CloseDone.Text = "Close Done";
            this.FC_Home_CloseDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CloseDone_Run);
            // 
            // FC_Home_DoUnlock
            // 
            this.FC_Home_DoUnlock.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoUnlock.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoUnlock.CASE1 = null;
            this.FC_Home_DoUnlock.CASE2 = null;
            this.FC_Home_DoUnlock.CASE3 = null;
            this.FC_Home_DoUnlock.CASE4 = null;
            this.FC_Home_DoUnlock.ContinueRun = false;
            this.FC_Home_DoUnlock.DesignTimeParent = null;
            this.FC_Home_DoUnlock.EndFC = null;
            this.FC_Home_DoUnlock.ErrID = 0;
            this.FC_Home_DoUnlock.InAlarm = false;
            this.FC_Home_DoUnlock.IsFlowHead = false;
            this.FC_Home_DoUnlock.Location = new System.Drawing.Point(73, 222);
            this.FC_Home_DoUnlock.LockUI = false;
            this.FC_Home_DoUnlock.Message = null;
            this.FC_Home_DoUnlock.MsgID = 0;
            this.FC_Home_DoUnlock.Name = "FC_Home_DoUnlock";
            this.FC_Home_DoUnlock.NEXT = this.FC_Home_UnlockDone;
            this.FC_Home_DoUnlock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoUnlock.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoUnlock.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoUnlock.OverTimeSpec = 100;
            this.FC_Home_DoUnlock.Running = false;
            this.FC_Home_DoUnlock.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_DoUnlock.SlowRunCycle = -1;
            this.FC_Home_DoUnlock.StartFC = null;
            this.FC_Home_DoUnlock.Text = "Do Unlock";
            this.FC_Home_DoUnlock.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoUnlock_Run);
            // 
            // FC_Home_UnlockDone
            // 
            this.FC_Home_UnlockDone.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_UnlockDone.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_UnlockDone.CASE1 = null;
            this.FC_Home_UnlockDone.CASE2 = null;
            this.FC_Home_UnlockDone.CASE3 = null;
            this.FC_Home_UnlockDone.CASE4 = null;
            this.FC_Home_UnlockDone.ContinueRun = false;
            this.FC_Home_UnlockDone.DesignTimeParent = null;
            this.FC_Home_UnlockDone.EndFC = null;
            this.FC_Home_UnlockDone.ErrID = 0;
            this.FC_Home_UnlockDone.InAlarm = false;
            this.FC_Home_UnlockDone.IsFlowHead = false;
            this.FC_Home_UnlockDone.Location = new System.Drawing.Point(73, 260);
            this.FC_Home_UnlockDone.LockUI = false;
            this.FC_Home_UnlockDone.Message = null;
            this.FC_Home_UnlockDone.MsgID = 0;
            this.FC_Home_UnlockDone.Name = "FC_Home_UnlockDone";
            this.FC_Home_UnlockDone.NEXT = this.FC_Home_Done;
            this.FC_Home_UnlockDone.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_UnlockDone.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_UnlockDone.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_UnlockDone.OverTimeSpec = 100;
            this.FC_Home_UnlockDone.Running = false;
            this.FC_Home_UnlockDone.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_UnlockDone.SlowRunCycle = -1;
            this.FC_Home_UnlockDone.StartFC = null;
            this.FC_Home_UnlockDone.Text = "Unlock Done";
            this.FC_Home_UnlockDone.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_UnlockDone_Run);
            // 
            // FC_Home_Done
            // 
            this.FC_Home_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_Done.CASE1 = null;
            this.FC_Home_Done.CASE2 = null;
            this.FC_Home_Done.CASE3 = null;
            this.FC_Home_Done.CASE4 = null;
            this.FC_Home_Done.ContinueRun = false;
            this.FC_Home_Done.DesignTimeParent = null;
            this.FC_Home_Done.EndFC = null;
            this.FC_Home_Done.ErrID = 0;
            this.FC_Home_Done.InAlarm = false;
            this.FC_Home_Done.IsFlowHead = false;
            this.FC_Home_Done.Location = new System.Drawing.Point(73, 298);
            this.FC_Home_Done.LockUI = false;
            this.FC_Home_Done.Message = null;
            this.FC_Home_Done.MsgID = 0;
            this.FC_Home_Done.Name = "FC_Home_Done";
            this.FC_Home_Done.NEXT = this.FC_Auto_Close_DoorYPush;
            this.FC_Home_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_Done.OverTimeSpec = 100;
            this.FC_Home_Done.Running = false;
            this.FC_Home_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_Done.SlowRunCycle = -1;
            this.FC_Home_Done.StartFC = null;
            this.FC_Home_Done.Text = "Done";
            this.FC_Home_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_Done_Run);
            // 
            // FC_Home_DoLock
            // 
            this.FC_Home_DoLock.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_DoLock.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_DoLock.CASE1 = null;
            this.FC_Home_DoLock.CASE2 = null;
            this.FC_Home_DoLock.CASE3 = null;
            this.FC_Home_DoLock.CASE4 = null;
            this.FC_Home_DoLock.ContinueRun = false;
            this.FC_Home_DoLock.DesignTimeParent = null;
            this.FC_Home_DoLock.EndFC = null;
            this.FC_Home_DoLock.ErrID = 0;
            this.FC_Home_DoLock.InAlarm = false;
            this.FC_Home_DoLock.IsFlowHead = false;
            this.FC_Home_DoLock.Location = new System.Drawing.Point(295, 108);
            this.FC_Home_DoLock.LockUI = false;
            this.FC_Home_DoLock.Message = null;
            this.FC_Home_DoLock.MsgID = 0;
            this.FC_Home_DoLock.Name = "FC_Home_DoLock";
            this.FC_Home_DoLock.NEXT = this.FC_Home_LockDone;
            this.FC_Home_DoLock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_DoLock.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_DoLock.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_DoLock.OverTimeSpec = 100;
            this.FC_Home_DoLock.Running = false;
            this.FC_Home_DoLock.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_DoLock.SlowRunCycle = -1;
            this.FC_Home_DoLock.StartFC = null;
            this.FC_Home_DoLock.Text = "Do Lock";
            this.FC_Home_DoLock.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_DoLock_Run);
            // 
            // FC_Home_CheckHasCassette
            // 
            this.FC_Home_CheckHasCassette.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_CheckHasCassette.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_CheckHasCassette.CASE1 = this.FC_Home_DoLock;
            this.FC_Home_CheckHasCassette.CASE2 = null;
            this.FC_Home_CheckHasCassette.CASE3 = null;
            this.FC_Home_CheckHasCassette.CASE4 = null;
            this.FC_Home_CheckHasCassette.ContinueRun = false;
            this.FC_Home_CheckHasCassette.DesignTimeParent = null;
            this.FC_Home_CheckHasCassette.EndFC = null;
            this.FC_Home_CheckHasCassette.ErrID = 0;
            this.FC_Home_CheckHasCassette.InAlarm = false;
            this.FC_Home_CheckHasCassette.IsFlowHead = false;
            this.FC_Home_CheckHasCassette.Location = new System.Drawing.Point(73, 108);
            this.FC_Home_CheckHasCassette.LockUI = false;
            this.FC_Home_CheckHasCassette.Message = null;
            this.FC_Home_CheckHasCassette.MsgID = 0;
            this.FC_Home_CheckHasCassette.Name = "FC_Home_CheckHasCassette";
            this.FC_Home_CheckHasCassette.NEXT = this.FC_Home_DoClose;
            this.FC_Home_CheckHasCassette.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_CheckHasCassette.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_CheckHasCassette.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_CheckHasCassette.OverTimeSpec = 100;
            this.FC_Home_CheckHasCassette.Running = false;
            this.FC_Home_CheckHasCassette.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_CheckHasCassette.SlowRunCycle = -1;
            this.FC_Home_CheckHasCassette.StartFC = null;
            this.FC_Home_CheckHasCassette.Text = "Check Has Cassette";
            this.FC_Home_CheckHasCassette.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_CheckHasCassette_Run);
            // 
            // FC_Home_WaitCmd
            // 
            this.FC_Home_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_Home_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_Home_WaitCmd.CASE1 = null;
            this.FC_Home_WaitCmd.CASE2 = null;
            this.FC_Home_WaitCmd.CASE3 = null;
            this.FC_Home_WaitCmd.CASE4 = null;
            this.FC_Home_WaitCmd.ContinueRun = false;
            this.FC_Home_WaitCmd.DesignTimeParent = null;
            this.FC_Home_WaitCmd.EndFC = null;
            this.FC_Home_WaitCmd.ErrID = 0;
            this.FC_Home_WaitCmd.InAlarm = false;
            this.FC_Home_WaitCmd.IsFlowHead = false;
            this.FC_Home_WaitCmd.Location = new System.Drawing.Point(73, 70);
            this.FC_Home_WaitCmd.LockUI = false;
            this.FC_Home_WaitCmd.Message = null;
            this.FC_Home_WaitCmd.MsgID = 0;
            this.FC_Home_WaitCmd.Name = "FC_Home_WaitCmd";
            this.FC_Home_WaitCmd.NEXT = this.FC_Home_CheckHasCassette;
            this.FC_Home_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_Home_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_Home_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_Home_WaitCmd.OverTimeSpec = 100;
            this.FC_Home_WaitCmd.Running = false;
            this.FC_Home_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_Home_WaitCmd.SlowRunCycle = -1;
            this.FC_Home_WaitCmd.StartFC = null;
            this.FC_Home_WaitCmd.Text = "Wait Command";
            this.FC_Home_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_Home_WaitCmd_Run);
            // 
            // FC_HOME_START
            // 
            this.FC_HOME_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_HOME_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_HOME_START.CASE1 = null;
            this.FC_HOME_START.CASE2 = null;
            this.FC_HOME_START.CASE3 = null;
            this.FC_HOME_START.CASE4 = null;
            this.FC_HOME_START.ContinueRun = false;
            this.FC_HOME_START.DesignTimeParent = null;
            this.FC_HOME_START.EndFC = null;
            this.FC_HOME_START.ErrID = 0;
            this.FC_HOME_START.InAlarm = false;
            this.FC_HOME_START.IsFlowHead = false;
            this.FC_HOME_START.Location = new System.Drawing.Point(73, 32);
            this.FC_HOME_START.LockUI = false;
            this.FC_HOME_START.Message = null;
            this.FC_HOME_START.MsgID = 0;
            this.FC_HOME_START.Name = "FC_HOME_START";
            this.FC_HOME_START.NEXT = this.FC_Home_WaitCmd;
            this.FC_HOME_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_HOME_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_HOME_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_HOME_START.OverTimeSpec = 100;
            this.FC_HOME_START.Running = false;
            this.FC_HOME_START.Size = new System.Drawing.Size(200, 30);
            this.FC_HOME_START.SlowRunCycle = -1;
            this.FC_HOME_START.StartFC = null;
            this.FC_HOME_START.Text = "Initial Action Start";
            this.FC_HOME_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_HOME_START_Run);
            // 
            // tpInputID
            // 
            this.tpInputID.Controls.Add(this.FC_InputID_DoInputID);
            this.tpInputID.Controls.Add(this.FC_InputID_Next_1);
            this.tpInputID.Controls.Add(this.FC_InputID_Next_2);
            this.tpInputID.Controls.Add(this.FC_InputID_Done);
            this.tpInputID.Controls.Add(this.FC_InputID_WaitCmd);
            this.tpInputID.Controls.Add(this.FC_INPUTID_START);
            this.tpInputID.Location = new System.Drawing.Point(4, 38);
            this.tpInputID.Name = "tpInputID";
            this.tpInputID.Size = new System.Drawing.Size(948, 496);
            this.tpInputID.TabIndex = 4;
            this.tpInputID.Text = "InputID";
            this.tpInputID.UseVisualStyleBackColor = true;
            // 
            // FC_InputID_DoInputID
            // 
            this.FC_InputID_DoInputID.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_InputID_DoInputID.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_InputID_DoInputID.CASE1 = null;
            this.FC_InputID_DoInputID.CASE2 = null;
            this.FC_InputID_DoInputID.CASE3 = null;
            this.FC_InputID_DoInputID.CASE4 = null;
            this.FC_InputID_DoInputID.ContinueRun = false;
            this.FC_InputID_DoInputID.DesignTimeParent = null;
            this.FC_InputID_DoInputID.EndFC = null;
            this.FC_InputID_DoInputID.ErrID = 0;
            this.FC_InputID_DoInputID.InAlarm = false;
            this.FC_InputID_DoInputID.IsFlowHead = false;
            this.FC_InputID_DoInputID.Location = new System.Drawing.Point(347, 182);
            this.FC_InputID_DoInputID.LockUI = false;
            this.FC_InputID_DoInputID.Message = null;
            this.FC_InputID_DoInputID.MsgID = 0;
            this.FC_InputID_DoInputID.Name = "FC_InputID_DoInputID";
            this.FC_InputID_DoInputID.NEXT = this.FC_InputID_Done;
            this.FC_InputID_DoInputID.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_InputID_DoInputID.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_InputID_DoInputID.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_InputID_DoInputID.OverTimeSpec = 100;
            this.FC_InputID_DoInputID.Running = false;
            this.FC_InputID_DoInputID.Size = new System.Drawing.Size(200, 30);
            this.FC_InputID_DoInputID.SlowRunCycle = -1;
            this.FC_InputID_DoInputID.StartFC = null;
            this.FC_InputID_DoInputID.Text = "Do InputID";
            this.FC_InputID_DoInputID.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_InputID_DoInputID_Run);
            // 
            // FC_InputID_Done
            // 
            this.FC_InputID_Done.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_InputID_Done.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_InputID_Done.CASE1 = null;
            this.FC_InputID_Done.CASE2 = null;
            this.FC_InputID_Done.CASE3 = null;
            this.FC_InputID_Done.CASE4 = null;
            this.FC_InputID_Done.ContinueRun = false;
            this.FC_InputID_Done.DesignTimeParent = null;
            this.FC_InputID_Done.EndFC = null;
            this.FC_InputID_Done.ErrID = 0;
            this.FC_InputID_Done.InAlarm = false;
            this.FC_InputID_Done.IsFlowHead = false;
            this.FC_InputID_Done.Location = new System.Drawing.Point(347, 220);
            this.FC_InputID_Done.LockUI = false;
            this.FC_InputID_Done.Message = null;
            this.FC_InputID_Done.MsgID = 0;
            this.FC_InputID_Done.Name = "FC_InputID_Done";
            this.FC_InputID_Done.NEXT = this.FC_InputID_Next_2;
            this.FC_InputID_Done.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_InputID_Done.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_InputID_Done.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_InputID_Done.OverTimeSpec = 100;
            this.FC_InputID_Done.Running = false;
            this.FC_InputID_Done.Size = new System.Drawing.Size(200, 30);
            this.FC_InputID_Done.SlowRunCycle = -1;
            this.FC_InputID_Done.StartFC = null;
            this.FC_InputID_Done.Text = "Done";
            this.FC_InputID_Done.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_InputID_Done_Run);
            // 
            // FC_InputID_Next_2
            // 
            this.FC_InputID_Next_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_InputID_Next_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_InputID_Next_2.CASE1 = null;
            this.FC_InputID_Next_2.CASE2 = null;
            this.FC_InputID_Next_2.CASE3 = null;
            this.FC_InputID_Next_2.CASE4 = null;
            this.FC_InputID_Next_2.ContinueRun = false;
            this.FC_InputID_Next_2.DesignTimeParent = null;
            this.FC_InputID_Next_2.EndFC = null;
            this.FC_InputID_Next_2.ErrID = 0;
            this.FC_InputID_Next_2.InAlarm = false;
            this.FC_InputID_Next_2.IsFlowHead = false;
            this.FC_InputID_Next_2.Location = new System.Drawing.Point(588, 220);
            this.FC_InputID_Next_2.LockUI = false;
            this.FC_InputID_Next_2.Message = null;
            this.FC_InputID_Next_2.MsgID = 0;
            this.FC_InputID_Next_2.Name = "FC_InputID_Next_2";
            this.FC_InputID_Next_2.NEXT = this.FC_InputID_Next_1;
            this.FC_InputID_Next_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_InputID_Next_2.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_InputID_Next_2.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_InputID_Next_2.OverTimeSpec = 100;
            this.FC_InputID_Next_2.Running = false;
            this.FC_InputID_Next_2.Size = new System.Drawing.Size(30, 30);
            this.FC_InputID_Next_2.SlowRunCycle = -1;
            this.FC_InputID_Next_2.StartFC = null;
            this.FC_InputID_Next_2.Text = "N";
            this.FC_InputID_Next_2.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_InputID_Next_2_Run);
            // 
            // FC_InputID_Next_1
            // 
            this.FC_InputID_Next_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_InputID_Next_1.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_InputID_Next_1.CASE1 = null;
            this.FC_InputID_Next_1.CASE2 = null;
            this.FC_InputID_Next_1.CASE3 = null;
            this.FC_InputID_Next_1.CASE4 = null;
            this.FC_InputID_Next_1.ContinueRun = false;
            this.FC_InputID_Next_1.DesignTimeParent = null;
            this.FC_InputID_Next_1.EndFC = null;
            this.FC_InputID_Next_1.ErrID = 0;
            this.FC_InputID_Next_1.InAlarm = false;
            this.FC_InputID_Next_1.IsFlowHead = false;
            this.FC_InputID_Next_1.Location = new System.Drawing.Point(588, 144);
            this.FC_InputID_Next_1.LockUI = false;
            this.FC_InputID_Next_1.Message = null;
            this.FC_InputID_Next_1.MsgID = 0;
            this.FC_InputID_Next_1.Name = "FC_InputID_Next_1";
            this.FC_InputID_Next_1.NEXT = this.FC_InputID_WaitCmd;
            this.FC_InputID_Next_1.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_InputID_Next_1.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_InputID_Next_1.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_InputID_Next_1.OverTimeSpec = 100;
            this.FC_InputID_Next_1.Running = false;
            this.FC_InputID_Next_1.Size = new System.Drawing.Size(30, 30);
            this.FC_InputID_Next_1.SlowRunCycle = -1;
            this.FC_InputID_Next_1.StartFC = null;
            this.FC_InputID_Next_1.Text = "N";
            this.FC_InputID_Next_1.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_InputID_Next_1_Run);
            // 
            // FC_InputID_WaitCmd
            // 
            this.FC_InputID_WaitCmd.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_InputID_WaitCmd.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_InputID_WaitCmd.CASE1 = null;
            this.FC_InputID_WaitCmd.CASE2 = null;
            this.FC_InputID_WaitCmd.CASE3 = null;
            this.FC_InputID_WaitCmd.CASE4 = null;
            this.FC_InputID_WaitCmd.ContinueRun = false;
            this.FC_InputID_WaitCmd.DesignTimeParent = null;
            this.FC_InputID_WaitCmd.EndFC = null;
            this.FC_InputID_WaitCmd.ErrID = 0;
            this.FC_InputID_WaitCmd.InAlarm = false;
            this.FC_InputID_WaitCmd.IsFlowHead = false;
            this.FC_InputID_WaitCmd.Location = new System.Drawing.Point(347, 144);
            this.FC_InputID_WaitCmd.LockUI = false;
            this.FC_InputID_WaitCmd.Message = null;
            this.FC_InputID_WaitCmd.MsgID = 0;
            this.FC_InputID_WaitCmd.Name = "FC_InputID_WaitCmd";
            this.FC_InputID_WaitCmd.NEXT = this.FC_InputID_DoInputID;
            this.FC_InputID_WaitCmd.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_InputID_WaitCmd.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_InputID_WaitCmd.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_InputID_WaitCmd.OverTimeSpec = 100;
            this.FC_InputID_WaitCmd.Running = false;
            this.FC_InputID_WaitCmd.Size = new System.Drawing.Size(200, 30);
            this.FC_InputID_WaitCmd.SlowRunCycle = -1;
            this.FC_InputID_WaitCmd.StartFC = null;
            this.FC_InputID_WaitCmd.Text = "Wait Command";
            this.FC_InputID_WaitCmd.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_InputID_WaitCmd_Run);
            // 
            // FC_INPUTID_START
            // 
            this.FC_INPUTID_START.BackColor = System.Drawing.Color.RoyalBlue;
            this.FC_INPUTID_START.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.FC_INPUTID_START.CASE1 = null;
            this.FC_INPUTID_START.CASE2 = null;
            this.FC_INPUTID_START.CASE3 = null;
            this.FC_INPUTID_START.CASE4 = null;
            this.FC_INPUTID_START.ContinueRun = false;
            this.FC_INPUTID_START.DesignTimeParent = null;
            this.FC_INPUTID_START.EndFC = null;
            this.FC_INPUTID_START.ErrID = 0;
            this.FC_INPUTID_START.InAlarm = false;
            this.FC_INPUTID_START.IsFlowHead = false;
            this.FC_INPUTID_START.Location = new System.Drawing.Point(347, 106);
            this.FC_INPUTID_START.LockUI = false;
            this.FC_INPUTID_START.Message = null;
            this.FC_INPUTID_START.MsgID = 0;
            this.FC_INPUTID_START.Name = "FC_INPUTID_START";
            this.FC_INPUTID_START.NEXT = this.FC_InputID_WaitCmd;
            this.FC_INPUTID_START.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.FC_INPUTID_START.OrgLocation = new System.Drawing.Point(0, 0);
            this.FC_INPUTID_START.OrgSize = new System.Drawing.Size(0, 0);
            this.FC_INPUTID_START.OverTimeSpec = 100;
            this.FC_INPUTID_START.Running = false;
            this.FC_INPUTID_START.Size = new System.Drawing.Size(200, 30);
            this.FC_INPUTID_START.SlowRunCycle = -1;
            this.FC_INPUTID_START.StartFC = null;
            this.FC_INPUTID_START.Text = "InputID Action Main";
            this.FC_INPUTID_START.Run += new ProVLib.FlowChart.RunEventHandler(this.FC_INPUTID_START_Run);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit31);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit1);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit3);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit2);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit4);
            this.flowLayoutPanel2.Controls.Add(this.dFieldEdit5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(447, 209);
            this.flowLayoutPanel2.TabIndex = 32;
            // 
            // dFieldEdit31
            // 
            this.dFieldEdit31.AutoFocus = false;
            this.dFieldEdit31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit31.Caption = "Cylinder Delay Time";
            this.dFieldEdit31.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit31.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.DataName = "CylinderActionDelayTime";
            this.dFieldEdit31.DataSource = this.SetDS;
            this.dFieldEdit31.DefaultValue = null;
            this.dFieldEdit31.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit31.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.EditWidth = 100;
            this.dFieldEdit31.FieldValue = "";
            this.dFieldEdit31.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit31.IsModified = false;
            this.dFieldEdit31.Location = new System.Drawing.Point(0, 0);
            this.dFieldEdit31.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit31.MaxValue = 100000D;
            this.dFieldEdit31.MinValue = 1D;
            this.dFieldEdit31.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit31.Name = "dFieldEdit31";
            this.dFieldEdit31.NoChangeInAuto = false;
            this.dFieldEdit31.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit31.StepValue = 0D;
            this.dFieldEdit31.TabIndex = 31;
            this.dFieldEdit31.Unit = "ms";
            this.dFieldEdit31.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit31.UnitWidth = 50;
            this.dFieldEdit31.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit1
            // 
            this.dFieldEdit1.AutoFocus = false;
            this.dFieldEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit1.Caption = "Cylinder Timeout";
            this.dFieldEdit1.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit1.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.DataName = "CylinderActionTimeout";
            this.dFieldEdit1.DataSource = this.SetDS;
            this.dFieldEdit1.DefaultValue = null;
            this.dFieldEdit1.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit1.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.EditWidth = 100;
            this.dFieldEdit1.FieldValue = "";
            this.dFieldEdit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit1.IsModified = false;
            this.dFieldEdit1.Location = new System.Drawing.Point(0, 29);
            this.dFieldEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit1.MaxValue = 100000D;
            this.dFieldEdit1.MinValue = 1D;
            this.dFieldEdit1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit1.Name = "dFieldEdit1";
            this.dFieldEdit1.NoChangeInAuto = false;
            this.dFieldEdit1.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit1.StepValue = 0D;
            this.dFieldEdit1.TabIndex = 32;
            this.dFieldEdit1.Unit = "ms";
            this.dFieldEdit1.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit1.UnitWidth = 50;
            this.dFieldEdit1.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit3
            // 
            this.dFieldEdit3.AutoFocus = false;
            this.dFieldEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit3.Caption = "Door Z Delay Time";
            this.dFieldEdit3.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit3.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.DataName = "CylinderDoorZActionDelayTime";
            this.dFieldEdit3.DataSource = this.SetDS;
            this.dFieldEdit3.DefaultValue = null;
            this.dFieldEdit3.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit3.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.EditWidth = 100;
            this.dFieldEdit3.FieldValue = "";
            this.dFieldEdit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit3.IsModified = false;
            this.dFieldEdit3.Location = new System.Drawing.Point(0, 58);
            this.dFieldEdit3.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit3.MaxValue = 100000D;
            this.dFieldEdit3.MinValue = 1D;
            this.dFieldEdit3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit3.Name = "dFieldEdit3";
            this.dFieldEdit3.NoChangeInAuto = false;
            this.dFieldEdit3.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit3.StepValue = 0D;
            this.dFieldEdit3.TabIndex = 34;
            this.dFieldEdit3.Unit = "ms";
            this.dFieldEdit3.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit3.UnitWidth = 50;
            this.dFieldEdit3.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit2
            // 
            this.dFieldEdit2.AutoFocus = false;
            this.dFieldEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit2.Caption = "Door Z Timeout";
            this.dFieldEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.DataName = "CylinderDoorZActionTimeout";
            this.dFieldEdit2.DataSource = this.SetDS;
            this.dFieldEdit2.DefaultValue = null;
            this.dFieldEdit2.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.EditWidth = 100;
            this.dFieldEdit2.FieldValue = "";
            this.dFieldEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit2.IsModified = false;
            this.dFieldEdit2.Location = new System.Drawing.Point(0, 87);
            this.dFieldEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit2.MaxValue = 100000D;
            this.dFieldEdit2.MinValue = 1D;
            this.dFieldEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit2.Name = "dFieldEdit2";
            this.dFieldEdit2.NoChangeInAuto = false;
            this.dFieldEdit2.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit2.StepValue = 0D;
            this.dFieldEdit2.TabIndex = 33;
            this.dFieldEdit2.Unit = "ms";
            this.dFieldEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit2.UnitWidth = 50;
            this.dFieldEdit2.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit4
            // 
            this.dFieldEdit4.AutoFocus = false;
            this.dFieldEdit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit4.Caption = "Vaccum Delay Time";
            this.dFieldEdit4.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit4.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.DataName = "VacuumActionDelayTime";
            this.dFieldEdit4.DataSource = this.SetDS;
            this.dFieldEdit4.DefaultValue = null;
            this.dFieldEdit4.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit4.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.EditWidth = 100;
            this.dFieldEdit4.FieldValue = "";
            this.dFieldEdit4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit4.IsModified = false;
            this.dFieldEdit4.Location = new System.Drawing.Point(0, 116);
            this.dFieldEdit4.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit4.MaxValue = 100000D;
            this.dFieldEdit4.MinValue = 1D;
            this.dFieldEdit4.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit4.Name = "dFieldEdit4";
            this.dFieldEdit4.NoChangeInAuto = false;
            this.dFieldEdit4.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit4.StepValue = 0D;
            this.dFieldEdit4.TabIndex = 36;
            this.dFieldEdit4.Unit = "ms";
            this.dFieldEdit4.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit4.UnitWidth = 50;
            this.dFieldEdit4.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit5
            // 
            this.dFieldEdit5.AutoFocus = false;
            this.dFieldEdit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit5.Caption = "Vaccum Timeout";
            this.dFieldEdit5.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit5.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit5.DataName = "VacuumActionTimeout";
            this.dFieldEdit5.DataSource = this.SetDS;
            this.dFieldEdit5.DefaultValue = null;
            this.dFieldEdit5.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit5.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit5.EditWidth = 100;
            this.dFieldEdit5.FieldValue = "";
            this.dFieldEdit5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit5.IsModified = false;
            this.dFieldEdit5.Location = new System.Drawing.Point(0, 145);
            this.dFieldEdit5.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit5.MaxValue = 100000D;
            this.dFieldEdit5.MinValue = 1D;
            this.dFieldEdit5.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit5.Name = "dFieldEdit5";
            this.dFieldEdit5.NoChangeInAuto = false;
            this.dFieldEdit5.Size = new System.Drawing.Size(400, 29);
            this.dFieldEdit5.StepValue = 0D;
            this.dFieldEdit5.TabIndex = 35;
            this.dFieldEdit5.Unit = "ms";
            this.dFieldEdit5.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit5.UnitWidth = 50;
            this.dFieldEdit5.ValueType = KCSDK.ValueDataType.Int;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1358, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel14);
            this.tabPage1.Controls.Add(this.flowLayoutPanel4);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1350, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label16);
            this.flowLayoutPanel14.Controls.Add(this.ib_InfoPad_LeftTop);
            this.flowLayoutPanel14.Controls.Add(this.ib_InfoPad_LeftDown);
            this.flowLayoutPanel14.Controls.Add(this.ib_InfoPad_RightDown);
            this.flowLayoutPanel14.Controls.Add(this.ib_InfoPad_RightTop);
            this.flowLayoutPanel14.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(465, 60);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(217, 182);
            this.flowLayoutPanel14.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkGray;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = "Info Pad";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_InfoPad_LeftTop
            // 
            this.ib_InfoPad_LeftTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_InfoPad_LeftTop.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_InfoPad_LeftTop.DesignTimeParent = null;
            this.ib_InfoPad_LeftTop.ErrID = 0;
            this.ib_InfoPad_LeftTop.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_InfoPad_LeftTop.InAlarm = false;
            this.ib_InfoPad_LeftTop.IOPort = "";
            this.ib_InfoPad_LeftTop.IOType = ProVLib.EIOType.IOHSL;
            this.ib_InfoPad_LeftTop.Location = new System.Drawing.Point(3, 28);
            this.ib_InfoPad_LeftTop.LockUI = false;
            this.ib_InfoPad_LeftTop.Message = null;
            this.ib_InfoPad_LeftTop.MsgID = 0;
            this.ib_InfoPad_LeftTop.Name = "ib_InfoPad_LeftTop";
            this.ib_InfoPad_LeftTop.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_InfoPad_LeftTop.Running = false;
            this.ib_InfoPad_LeftTop.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_InfoPad_LeftTop.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_InfoPad_LeftTop.Simu_OutPort1 = null;
            this.ib_InfoPad_LeftTop.Simu_OutPort2 = null;
            this.ib_InfoPad_LeftTop.Simu_RandomNum = 2;
            this.ib_InfoPad_LeftTop.Simu_RandomTime = 100;
            this.ib_InfoPad_LeftTop.Simu_ReflectDelayTm = 100;
            this.ib_InfoPad_LeftTop.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_InfoPad_LeftTop.Simu_Reverse = false;
            this.ib_InfoPad_LeftTop.Size = new System.Drawing.Size(211, 30);
            this.ib_InfoPad_LeftTop.Text = "Left Top";
            // 
            // ib_InfoPad_LeftDown
            // 
            this.ib_InfoPad_LeftDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_InfoPad_LeftDown.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_InfoPad_LeftDown.DesignTimeParent = null;
            this.ib_InfoPad_LeftDown.ErrID = 0;
            this.ib_InfoPad_LeftDown.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_InfoPad_LeftDown.InAlarm = false;
            this.ib_InfoPad_LeftDown.IOPort = "";
            this.ib_InfoPad_LeftDown.IOType = ProVLib.EIOType.IOHSL;
            this.ib_InfoPad_LeftDown.Location = new System.Drawing.Point(3, 66);
            this.ib_InfoPad_LeftDown.LockUI = false;
            this.ib_InfoPad_LeftDown.Message = null;
            this.ib_InfoPad_LeftDown.MsgID = 0;
            this.ib_InfoPad_LeftDown.Name = "ib_InfoPad_LeftDown";
            this.ib_InfoPad_LeftDown.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_InfoPad_LeftDown.Running = false;
            this.ib_InfoPad_LeftDown.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_InfoPad_LeftDown.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_InfoPad_LeftDown.Simu_OutPort1 = null;
            this.ib_InfoPad_LeftDown.Simu_OutPort2 = null;
            this.ib_InfoPad_LeftDown.Simu_RandomNum = 2;
            this.ib_InfoPad_LeftDown.Simu_RandomTime = 100;
            this.ib_InfoPad_LeftDown.Simu_ReflectDelayTm = 100;
            this.ib_InfoPad_LeftDown.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_InfoPad_LeftDown.Simu_Reverse = false;
            this.ib_InfoPad_LeftDown.Size = new System.Drawing.Size(211, 30);
            this.ib_InfoPad_LeftDown.Text = "Left Down";
            // 
            // ib_InfoPad_RightDown
            // 
            this.ib_InfoPad_RightDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_InfoPad_RightDown.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_InfoPad_RightDown.DesignTimeParent = null;
            this.ib_InfoPad_RightDown.ErrID = 0;
            this.ib_InfoPad_RightDown.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_InfoPad_RightDown.InAlarm = false;
            this.ib_InfoPad_RightDown.IOPort = "";
            this.ib_InfoPad_RightDown.IOType = ProVLib.EIOType.IOHSL;
            this.ib_InfoPad_RightDown.Location = new System.Drawing.Point(3, 104);
            this.ib_InfoPad_RightDown.LockUI = false;
            this.ib_InfoPad_RightDown.Message = null;
            this.ib_InfoPad_RightDown.MsgID = 0;
            this.ib_InfoPad_RightDown.Name = "ib_InfoPad_RightDown";
            this.ib_InfoPad_RightDown.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_InfoPad_RightDown.Running = false;
            this.ib_InfoPad_RightDown.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_InfoPad_RightDown.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_InfoPad_RightDown.Simu_OutPort1 = null;
            this.ib_InfoPad_RightDown.Simu_OutPort2 = null;
            this.ib_InfoPad_RightDown.Simu_RandomNum = 2;
            this.ib_InfoPad_RightDown.Simu_RandomTime = 100;
            this.ib_InfoPad_RightDown.Simu_ReflectDelayTm = 100;
            this.ib_InfoPad_RightDown.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_InfoPad_RightDown.Simu_Reverse = false;
            this.ib_InfoPad_RightDown.Size = new System.Drawing.Size(211, 30);
            this.ib_InfoPad_RightDown.Text = "Right Down";
            // 
            // ib_InfoPad_RightTop
            // 
            this.ib_InfoPad_RightTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_InfoPad_RightTop.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_InfoPad_RightTop.DesignTimeParent = null;
            this.ib_InfoPad_RightTop.ErrID = 0;
            this.ib_InfoPad_RightTop.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_InfoPad_RightTop.InAlarm = false;
            this.ib_InfoPad_RightTop.IOPort = "";
            this.ib_InfoPad_RightTop.IOType = ProVLib.EIOType.IOHSL;
            this.ib_InfoPad_RightTop.Location = new System.Drawing.Point(3, 142);
            this.ib_InfoPad_RightTop.LockUI = false;
            this.ib_InfoPad_RightTop.Message = null;
            this.ib_InfoPad_RightTop.MsgID = 0;
            this.ib_InfoPad_RightTop.Name = "ib_InfoPad_RightTop";
            this.ib_InfoPad_RightTop.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_InfoPad_RightTop.Running = false;
            this.ib_InfoPad_RightTop.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_InfoPad_RightTop.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_InfoPad_RightTop.Simu_OutPort1 = null;
            this.ib_InfoPad_RightTop.Simu_OutPort2 = null;
            this.ib_InfoPad_RightTop.Simu_RandomNum = 2;
            this.ib_InfoPad_RightTop.Simu_RandomTime = 100;
            this.ib_InfoPad_RightTop.Simu_ReflectDelayTm = 100;
            this.ib_InfoPad_RightTop.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_InfoPad_RightTop.Simu_Reverse = false;
            this.ib_InfoPad_RightTop.Size = new System.Drawing.Size(211, 30);
            this.ib_InfoPad_RightTop.Text = "Right Top";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.ib_Table_Out);
            this.flowLayoutPanel4.Controls.Add(this.ib_Table_Back);
            this.flowLayoutPanel4.Controls.Add(this.ob_Table_Out);
            this.flowLayoutPanel4.Controls.Add(this.ob_Table_Back);
            this.flowLayoutPanel4.Controls.Add(this.btn_Table_SW);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(19, 277);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(217, 240);
            this.flowLayoutPanel4.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Table(2)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_Table_Out
            // 
            this.ib_Table_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Table_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Table_Out.DesignTimeParent = null;
            this.ib_Table_Out.ErrID = 0;
            this.ib_Table_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Table_Out.InAlarm = false;
            this.ib_Table_Out.IOPort = "0310";
            this.ib_Table_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Table_Out.Location = new System.Drawing.Point(3, 28);
            this.ib_Table_Out.LockUI = false;
            this.ib_Table_Out.Message = null;
            this.ib_Table_Out.MsgID = 0;
            this.ib_Table_Out.Name = "ib_Table_Out";
            this.ib_Table_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Table_Out.Running = false;
            this.ib_Table_Out.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Table_Out.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Table_Out.Simu_OutPort1 = null;
            this.ib_Table_Out.Simu_OutPort2 = null;
            this.ib_Table_Out.Simu_RandomNum = 2;
            this.ib_Table_Out.Simu_RandomTime = 100;
            this.ib_Table_Out.Simu_ReflectDelayTm = 100;
            this.ib_Table_Out.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Table_Out.Simu_Reverse = false;
            this.ib_Table_Out.Size = new System.Drawing.Size(211, 30);
            this.ib_Table_Out.Text = "On";
            // 
            // ib_Table_Back
            // 
            this.ib_Table_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Table_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Table_Back.DesignTimeParent = null;
            this.ib_Table_Back.ErrID = 0;
            this.ib_Table_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Table_Back.InAlarm = false;
            this.ib_Table_Back.IOPort = "0311";
            this.ib_Table_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Table_Back.Location = new System.Drawing.Point(3, 66);
            this.ib_Table_Back.LockUI = false;
            this.ib_Table_Back.Message = null;
            this.ib_Table_Back.MsgID = 0;
            this.ib_Table_Back.Name = "ib_Table_Back";
            this.ib_Table_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Table_Back.Running = false;
            this.ib_Table_Back.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Table_Back.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Table_Back.Simu_OutPort1 = null;
            this.ib_Table_Back.Simu_OutPort2 = null;
            this.ib_Table_Back.Simu_RandomNum = 2;
            this.ib_Table_Back.Simu_RandomTime = 100;
            this.ib_Table_Back.Simu_ReflectDelayTm = 100;
            this.ib_Table_Back.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Table_Back.Simu_Reverse = false;
            this.ib_Table_Back.Size = new System.Drawing.Size(211, 30);
            this.ib_Table_Back.Text = "Off";
            // 
            // ob_Table_Out
            // 
            this.ob_Table_Out.ActionCount = 0;
            this.ob_Table_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Table_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Table_Out.DesignTimeParent = null;
            this.ob_Table_Out.ErrID = 0;
            this.ob_Table_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Table_Out.InAlarm = false;
            this.ob_Table_Out.IOPort = "2300";
            this.ob_Table_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Table_Out.IsUseActionCount = false;
            this.ob_Table_Out.Location = new System.Drawing.Point(3, 104);
            this.ob_Table_Out.LockUI = false;
            this.ob_Table_Out.Message = null;
            this.ob_Table_Out.MsgID = 0;
            this.ob_Table_Out.Name = "ob_Table_Out";
            this.ob_Table_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Table_Out.RetryCount = 10;
            this.ob_Table_Out.Running = false;
            this.ob_Table_Out.Size = new System.Drawing.Size(211, 30);
            this.ob_Table_Out.Text = "Push";
            this.ob_Table_Out.Value = false;
            // 
            // ob_Table_Back
            // 
            this.ob_Table_Back.ActionCount = 0;
            this.ob_Table_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Table_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Table_Back.DesignTimeParent = null;
            this.ob_Table_Back.ErrID = 0;
            this.ob_Table_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Table_Back.InAlarm = false;
            this.ob_Table_Back.IOPort = "2301";
            this.ob_Table_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Table_Back.IsUseActionCount = false;
            this.ob_Table_Back.Location = new System.Drawing.Point(3, 142);
            this.ob_Table_Back.LockUI = false;
            this.ob_Table_Back.Message = null;
            this.ob_Table_Back.MsgID = 0;
            this.ob_Table_Back.Name = "ob_Table_Back";
            this.ob_Table_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Table_Back.RetryCount = 10;
            this.ob_Table_Back.Running = false;
            this.ob_Table_Back.Size = new System.Drawing.Size(211, 30);
            this.ob_Table_Back.Text = "Pull";
            this.ob_Table_Back.Value = false;
            // 
            // btn_Table_SW
            // 
            this.btn_Table_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_Table_SW.Location = new System.Drawing.Point(3, 179);
            this.btn_Table_SW.Name = "btn_Table_SW";
            this.btn_Table_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_Table_SW.TabIndex = 39;
            this.btn_Table_SW.Tag = "Table";
            this.btn_Table_SW.Text = "Switch";
            this.btn_Table_SW.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 56);
            this.label14.TabIndex = 34;
            this.label14.Text = "FLP(晶舟盒模組)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LPA.Properties.Resources.FLP2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(688, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.ib_ClampY_Clamp);
            this.flowLayoutPanel3.Controls.Add(this.ib_ClampY_Release);
            this.flowLayoutPanel3.Controls.Add(this.ob_ClampY_Clamp);
            this.flowLayoutPanel3.Controls.Add(this.ob_ClampY_Release);
            this.flowLayoutPanel3.Controls.Add(this.btn_ClampY_SW);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.ib_ClampZ_Up);
            this.flowLayoutPanel3.Controls.Add(this.ib_ClampZ_Down);
            this.flowLayoutPanel3.Controls.Add(this.ob_ClampZ_Up);
            this.flowLayoutPanel3.Controls.Add(this.ob_ClampZ_Down);
            this.flowLayoutPanel3.Controls.Add(this.btn_ClampZ_SW);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(242, 60);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(217, 472);
            this.flowLayoutPanel3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clamp Y-Axis(9)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_ClampY_Clamp
            // 
            this.ib_ClampY_Clamp.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ClampY_Clamp.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ClampY_Clamp.DesignTimeParent = null;
            this.ib_ClampY_Clamp.ErrID = 0;
            this.ib_ClampY_Clamp.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ClampY_Clamp.InAlarm = false;
            this.ib_ClampY_Clamp.IOPort = "030A";
            this.ib_ClampY_Clamp.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ClampY_Clamp.Location = new System.Drawing.Point(3, 28);
            this.ib_ClampY_Clamp.LockUI = false;
            this.ib_ClampY_Clamp.Message = null;
            this.ib_ClampY_Clamp.MsgID = 0;
            this.ib_ClampY_Clamp.Name = "ib_ClampY_Clamp";
            this.ib_ClampY_Clamp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ClampY_Clamp.Running = false;
            this.ib_ClampY_Clamp.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ClampY_Clamp.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ClampY_Clamp.Simu_OutPort1 = null;
            this.ib_ClampY_Clamp.Simu_OutPort2 = null;
            this.ib_ClampY_Clamp.Simu_RandomNum = 2;
            this.ib_ClampY_Clamp.Simu_RandomTime = 100;
            this.ib_ClampY_Clamp.Simu_ReflectDelayTm = 100;
            this.ib_ClampY_Clamp.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ClampY_Clamp.Simu_Reverse = false;
            this.ib_ClampY_Clamp.Size = new System.Drawing.Size(211, 30);
            this.ib_ClampY_Clamp.Text = "Clamp On";
            // 
            // ib_ClampY_Release
            // 
            this.ib_ClampY_Release.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ClampY_Release.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ClampY_Release.DesignTimeParent = null;
            this.ib_ClampY_Release.ErrID = 0;
            this.ib_ClampY_Release.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ClampY_Release.InAlarm = false;
            this.ib_ClampY_Release.IOPort = "030B";
            this.ib_ClampY_Release.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ClampY_Release.Location = new System.Drawing.Point(3, 66);
            this.ib_ClampY_Release.LockUI = false;
            this.ib_ClampY_Release.Message = null;
            this.ib_ClampY_Release.MsgID = 0;
            this.ib_ClampY_Release.Name = "ib_ClampY_Release";
            this.ib_ClampY_Release.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ClampY_Release.Running = false;
            this.ib_ClampY_Release.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ClampY_Release.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ClampY_Release.Simu_OutPort1 = null;
            this.ib_ClampY_Release.Simu_OutPort2 = null;
            this.ib_ClampY_Release.Simu_RandomNum = 2;
            this.ib_ClampY_Release.Simu_RandomTime = 100;
            this.ib_ClampY_Release.Simu_ReflectDelayTm = 100;
            this.ib_ClampY_Release.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ClampY_Release.Simu_Reverse = false;
            this.ib_ClampY_Release.Size = new System.Drawing.Size(211, 30);
            this.ib_ClampY_Release.Text = "Clamp Off";
            // 
            // ob_ClampY_Clamp
            // 
            this.ob_ClampY_Clamp.ActionCount = 0;
            this.ob_ClampY_Clamp.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_ClampY_Clamp.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_ClampY_Clamp.DesignTimeParent = null;
            this.ob_ClampY_Clamp.ErrID = 0;
            this.ob_ClampY_Clamp.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_ClampY_Clamp.InAlarm = false;
            this.ob_ClampY_Clamp.IOPort = "2304";
            this.ob_ClampY_Clamp.IOType = ProVLib.EIOType.IOHSL;
            this.ob_ClampY_Clamp.IsUseActionCount = false;
            this.ob_ClampY_Clamp.Location = new System.Drawing.Point(3, 104);
            this.ob_ClampY_Clamp.LockUI = false;
            this.ob_ClampY_Clamp.Message = null;
            this.ob_ClampY_Clamp.MsgID = 0;
            this.ob_ClampY_Clamp.Name = "ob_ClampY_Clamp";
            this.ob_ClampY_Clamp.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_ClampY_Clamp.RetryCount = 10;
            this.ob_ClampY_Clamp.Running = false;
            this.ob_ClampY_Clamp.Size = new System.Drawing.Size(211, 30);
            this.ob_ClampY_Clamp.Text = "Clamp";
            this.ob_ClampY_Clamp.Value = false;
            this.ob_ClampY_Clamp.IsSafeToAction += new ProVLib.OutBit.SafeActionEventHandler(this.ob_ClampY_Clamp_IsSafeToAction);
            // 
            // ob_ClampY_Release
            // 
            this.ob_ClampY_Release.ActionCount = 0;
            this.ob_ClampY_Release.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_ClampY_Release.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_ClampY_Release.DesignTimeParent = null;
            this.ob_ClampY_Release.ErrID = 0;
            this.ob_ClampY_Release.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_ClampY_Release.InAlarm = false;
            this.ob_ClampY_Release.IOPort = "2305";
            this.ob_ClampY_Release.IOType = ProVLib.EIOType.IOHSL;
            this.ob_ClampY_Release.IsUseActionCount = false;
            this.ob_ClampY_Release.Location = new System.Drawing.Point(3, 142);
            this.ob_ClampY_Release.LockUI = false;
            this.ob_ClampY_Release.Message = null;
            this.ob_ClampY_Release.MsgID = 0;
            this.ob_ClampY_Release.Name = "ob_ClampY_Release";
            this.ob_ClampY_Release.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_ClampY_Release.RetryCount = 10;
            this.ob_ClampY_Release.Running = false;
            this.ob_ClampY_Release.Size = new System.Drawing.Size(211, 30);
            this.ob_ClampY_Release.Text = "Release";
            this.ob_ClampY_Release.Value = false;
            this.ob_ClampY_Release.IsSafeToAction += new ProVLib.OutBit.SafeActionEventHandler(this.ob_ClampY_Release_IsSafeToAction);
            // 
            // btn_ClampY_SW
            // 
            this.btn_ClampY_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_ClampY_SW.Location = new System.Drawing.Point(3, 179);
            this.btn_ClampY_SW.Name = "btn_ClampY_SW";
            this.btn_ClampY_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_ClampY_SW.TabIndex = 39;
            this.btn_ClampY_SW.Tag = "ClampY";
            this.btn_ClampY_SW.Text = "Switch";
            this.btn_ClampY_SW.UseVisualStyleBackColor = false;
            this.btn_ClampY_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clamp Z-Axis(8)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_ClampZ_Up
            // 
            this.ib_ClampZ_Up.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ClampZ_Up.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ClampZ_Up.DesignTimeParent = null;
            this.ib_ClampZ_Up.ErrID = 0;
            this.ib_ClampZ_Up.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ClampZ_Up.InAlarm = false;
            this.ib_ClampZ_Up.IOPort = "0308";
            this.ib_ClampZ_Up.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ClampZ_Up.Location = new System.Drawing.Point(3, 245);
            this.ib_ClampZ_Up.LockUI = false;
            this.ib_ClampZ_Up.Message = null;
            this.ib_ClampZ_Up.MsgID = 0;
            this.ib_ClampZ_Up.Name = "ib_ClampZ_Up";
            this.ib_ClampZ_Up.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ClampZ_Up.Running = false;
            this.ib_ClampZ_Up.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ClampZ_Up.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ClampZ_Up.Simu_OutPort1 = null;
            this.ib_ClampZ_Up.Simu_OutPort2 = null;
            this.ib_ClampZ_Up.Simu_RandomNum = 2;
            this.ib_ClampZ_Up.Simu_RandomTime = 100;
            this.ib_ClampZ_Up.Simu_ReflectDelayTm = 100;
            this.ib_ClampZ_Up.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ClampZ_Up.Simu_Reverse = false;
            this.ib_ClampZ_Up.Size = new System.Drawing.Size(211, 30);
            this.ib_ClampZ_Up.Text = "Up";
            // 
            // ib_ClampZ_Down
            // 
            this.ib_ClampZ_Down.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ClampZ_Down.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ClampZ_Down.DesignTimeParent = null;
            this.ib_ClampZ_Down.ErrID = 0;
            this.ib_ClampZ_Down.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ClampZ_Down.InAlarm = false;
            this.ib_ClampZ_Down.IOPort = "0309";
            this.ib_ClampZ_Down.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ClampZ_Down.Location = new System.Drawing.Point(3, 283);
            this.ib_ClampZ_Down.LockUI = false;
            this.ib_ClampZ_Down.Message = null;
            this.ib_ClampZ_Down.MsgID = 0;
            this.ib_ClampZ_Down.Name = "ib_ClampZ_Down";
            this.ib_ClampZ_Down.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ClampZ_Down.Running = false;
            this.ib_ClampZ_Down.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ClampZ_Down.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ClampZ_Down.Simu_OutPort1 = null;
            this.ib_ClampZ_Down.Simu_OutPort2 = null;
            this.ib_ClampZ_Down.Simu_RandomNum = 2;
            this.ib_ClampZ_Down.Simu_RandomTime = 100;
            this.ib_ClampZ_Down.Simu_ReflectDelayTm = 100;
            this.ib_ClampZ_Down.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ClampZ_Down.Simu_Reverse = false;
            this.ib_ClampZ_Down.Size = new System.Drawing.Size(211, 30);
            this.ib_ClampZ_Down.Text = "Down";
            // 
            // ob_ClampZ_Up
            // 
            this.ob_ClampZ_Up.ActionCount = 0;
            this.ob_ClampZ_Up.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_ClampZ_Up.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_ClampZ_Up.DesignTimeParent = null;
            this.ob_ClampZ_Up.ErrID = 0;
            this.ob_ClampZ_Up.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_ClampZ_Up.InAlarm = false;
            this.ob_ClampZ_Up.IOPort = "2306";
            this.ob_ClampZ_Up.IOType = ProVLib.EIOType.IOHSL;
            this.ob_ClampZ_Up.IsUseActionCount = false;
            this.ob_ClampZ_Up.Location = new System.Drawing.Point(3, 321);
            this.ob_ClampZ_Up.LockUI = false;
            this.ob_ClampZ_Up.Message = null;
            this.ob_ClampZ_Up.MsgID = 0;
            this.ob_ClampZ_Up.Name = "ob_ClampZ_Up";
            this.ob_ClampZ_Up.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_ClampZ_Up.RetryCount = 10;
            this.ob_ClampZ_Up.Running = false;
            this.ob_ClampZ_Up.Size = new System.Drawing.Size(211, 30);
            this.ob_ClampZ_Up.Text = "Up";
            this.ob_ClampZ_Up.Value = false;
            // 
            // ob_ClampZ_Down
            // 
            this.ob_ClampZ_Down.ActionCount = 0;
            this.ob_ClampZ_Down.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_ClampZ_Down.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_ClampZ_Down.DesignTimeParent = null;
            this.ob_ClampZ_Down.ErrID = 0;
            this.ob_ClampZ_Down.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_ClampZ_Down.InAlarm = false;
            this.ob_ClampZ_Down.IOPort = "2307";
            this.ob_ClampZ_Down.IOType = ProVLib.EIOType.IOHSL;
            this.ob_ClampZ_Down.IsUseActionCount = false;
            this.ob_ClampZ_Down.Location = new System.Drawing.Point(3, 359);
            this.ob_ClampZ_Down.LockUI = false;
            this.ob_ClampZ_Down.Message = null;
            this.ob_ClampZ_Down.MsgID = 0;
            this.ob_ClampZ_Down.Name = "ob_ClampZ_Down";
            this.ob_ClampZ_Down.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_ClampZ_Down.RetryCount = 10;
            this.ob_ClampZ_Down.Running = false;
            this.ob_ClampZ_Down.Size = new System.Drawing.Size(211, 30);
            this.ob_ClampZ_Down.Text = "Down";
            this.ob_ClampZ_Down.Value = false;
            // 
            // btn_ClampZ_SW
            // 
            this.btn_ClampZ_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_ClampZ_SW.Location = new System.Drawing.Point(3, 396);
            this.btn_ClampZ_SW.Name = "btn_ClampZ_SW";
            this.btn_ClampZ_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_ClampZ_SW.TabIndex = 38;
            this.btn_ClampZ_SW.Tag = "ClampZ";
            this.btn_ClampZ_SW.Text = "Switch";
            this.btn_ClampZ_SW.UseVisualStyleBackColor = false;
            this.btn_ClampZ_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.ib_PlaceDetect_Left);
            this.flowLayoutPanel1.Controls.Add(this.ib_PlaceDetect_Right);
            this.flowLayoutPanel1.Controls.Add(this.ib_PlaceDetect_Down);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 211);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Place Detect(7)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_PlaceDetect_Left
            // 
            this.ib_PlaceDetect_Left.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_PlaceDetect_Left.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_PlaceDetect_Left.DesignTimeParent = null;
            this.ib_PlaceDetect_Left.ErrID = 0;
            this.ib_PlaceDetect_Left.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_PlaceDetect_Left.InAlarm = false;
            this.ib_PlaceDetect_Left.IOPort = "0300";
            this.ib_PlaceDetect_Left.IOType = ProVLib.EIOType.IOHSL;
            this.ib_PlaceDetect_Left.Location = new System.Drawing.Point(3, 28);
            this.ib_PlaceDetect_Left.LockUI = false;
            this.ib_PlaceDetect_Left.Message = null;
            this.ib_PlaceDetect_Left.MsgID = 0;
            this.ib_PlaceDetect_Left.Name = "ib_PlaceDetect_Left";
            this.ib_PlaceDetect_Left.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_PlaceDetect_Left.Running = false;
            this.ib_PlaceDetect_Left.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_PlaceDetect_Left.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_PlaceDetect_Left.Simu_OutPort1 = null;
            this.ib_PlaceDetect_Left.Simu_OutPort2 = null;
            this.ib_PlaceDetect_Left.Simu_RandomNum = 2;
            this.ib_PlaceDetect_Left.Simu_RandomTime = 100;
            this.ib_PlaceDetect_Left.Simu_ReflectDelayTm = 100;
            this.ib_PlaceDetect_Left.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_PlaceDetect_Left.Simu_Reverse = false;
            this.ib_PlaceDetect_Left.Size = new System.Drawing.Size(211, 30);
            this.ib_PlaceDetect_Left.Text = "Left";
            // 
            // ib_PlaceDetect_Right
            // 
            this.ib_PlaceDetect_Right.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_PlaceDetect_Right.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_PlaceDetect_Right.DesignTimeParent = null;
            this.ib_PlaceDetect_Right.ErrID = 0;
            this.ib_PlaceDetect_Right.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_PlaceDetect_Right.InAlarm = false;
            this.ib_PlaceDetect_Right.IOPort = "0301";
            this.ib_PlaceDetect_Right.IOType = ProVLib.EIOType.IOHSL;
            this.ib_PlaceDetect_Right.Location = new System.Drawing.Point(3, 66);
            this.ib_PlaceDetect_Right.LockUI = false;
            this.ib_PlaceDetect_Right.Message = null;
            this.ib_PlaceDetect_Right.MsgID = 0;
            this.ib_PlaceDetect_Right.Name = "ib_PlaceDetect_Right";
            this.ib_PlaceDetect_Right.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_PlaceDetect_Right.Running = false;
            this.ib_PlaceDetect_Right.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_PlaceDetect_Right.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_PlaceDetect_Right.Simu_OutPort1 = null;
            this.ib_PlaceDetect_Right.Simu_OutPort2 = null;
            this.ib_PlaceDetect_Right.Simu_RandomNum = 2;
            this.ib_PlaceDetect_Right.Simu_RandomTime = 100;
            this.ib_PlaceDetect_Right.Simu_ReflectDelayTm = 100;
            this.ib_PlaceDetect_Right.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_PlaceDetect_Right.Simu_Reverse = false;
            this.ib_PlaceDetect_Right.Size = new System.Drawing.Size(211, 30);
            this.ib_PlaceDetect_Right.Text = "Right";
            // 
            // ib_PlaceDetect_Down
            // 
            this.ib_PlaceDetect_Down.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_PlaceDetect_Down.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_PlaceDetect_Down.DesignTimeParent = null;
            this.ib_PlaceDetect_Down.ErrID = 0;
            this.ib_PlaceDetect_Down.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_PlaceDetect_Down.InAlarm = false;
            this.ib_PlaceDetect_Down.IOPort = "0302";
            this.ib_PlaceDetect_Down.IOType = ProVLib.EIOType.IOHSL;
            this.ib_PlaceDetect_Down.Location = new System.Drawing.Point(3, 104);
            this.ib_PlaceDetect_Down.LockUI = false;
            this.ib_PlaceDetect_Down.Message = null;
            this.ib_PlaceDetect_Down.MsgID = 0;
            this.ib_PlaceDetect_Down.Name = "ib_PlaceDetect_Down";
            this.ib_PlaceDetect_Down.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_PlaceDetect_Down.Running = false;
            this.ib_PlaceDetect_Down.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_PlaceDetect_Down.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_PlaceDetect_Down.Simu_OutPort1 = null;
            this.ib_PlaceDetect_Down.Simu_OutPort2 = null;
            this.ib_PlaceDetect_Down.Simu_RandomNum = 2;
            this.ib_PlaceDetect_Down.Simu_RandomTime = 100;
            this.ib_PlaceDetect_Down.Simu_ReflectDelayTm = 100;
            this.ib_PlaceDetect_Down.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_PlaceDetect_Down.Simu_Reverse = false;
            this.ib_PlaceDetect_Down.Size = new System.Drawing.Size(211, 30);
            this.ib_PlaceDetect_Down.Text = "Down";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.flowLayoutPanel10);
            this.tabPage2.Controls.Add(this.flowLayoutPanel9);
            this.tabPage2.Controls.Add(this.flowLayoutPanel11);
            this.tabPage2.Controls.Add(this.flowLayoutPanel8);
            this.tabPage2.Controls.Add(this.flowLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Door";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LPA.Properties.Resources.FLP1;
            this.pictureBox2.Location = new System.Drawing.Point(786, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 493);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label13);
            this.flowLayoutPanel10.Controls.Add(this.ib_Inch8CstClamp_On);
            this.flowLayoutPanel10.Controls.Add(this.ib_Inch8CstClamp_Off);
            this.flowLayoutPanel10.Controls.Add(this.ob_Inch8CstClamp_Lock);
            this.flowLayoutPanel10.Controls.Add(this.ob_Inch8CstClamp_Unlock);
            this.flowLayoutPanel10.Controls.Add(this.button1);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(452, 252);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(217, 241);
            this.flowLayoutPanel10.TabIndex = 49;
            this.flowLayoutPanel10.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "8Inch Cst Clamp";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_Inch8CstClamp_On
            // 
            this.ib_Inch8CstClamp_On.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Inch8CstClamp_On.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Inch8CstClamp_On.DesignTimeParent = null;
            this.ib_Inch8CstClamp_On.ErrID = 0;
            this.ib_Inch8CstClamp_On.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Inch8CstClamp_On.InAlarm = false;
            this.ib_Inch8CstClamp_On.IOPort = "";
            this.ib_Inch8CstClamp_On.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Inch8CstClamp_On.Location = new System.Drawing.Point(3, 28);
            this.ib_Inch8CstClamp_On.LockUI = false;
            this.ib_Inch8CstClamp_On.Message = null;
            this.ib_Inch8CstClamp_On.MsgID = 0;
            this.ib_Inch8CstClamp_On.Name = "ib_Inch8CstClamp_On";
            this.ib_Inch8CstClamp_On.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Inch8CstClamp_On.Running = false;
            this.ib_Inch8CstClamp_On.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Inch8CstClamp_On.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Inch8CstClamp_On.Simu_OutPort1 = null;
            this.ib_Inch8CstClamp_On.Simu_OutPort2 = null;
            this.ib_Inch8CstClamp_On.Simu_RandomNum = 2;
            this.ib_Inch8CstClamp_On.Simu_RandomTime = 100;
            this.ib_Inch8CstClamp_On.Simu_ReflectDelayTm = 100;
            this.ib_Inch8CstClamp_On.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Inch8CstClamp_On.Simu_Reverse = false;
            this.ib_Inch8CstClamp_On.Size = new System.Drawing.Size(211, 30);
            this.ib_Inch8CstClamp_On.Text = "On";
            // 
            // ib_Inch8CstClamp_Off
            // 
            this.ib_Inch8CstClamp_Off.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Inch8CstClamp_Off.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Inch8CstClamp_Off.DesignTimeParent = null;
            this.ib_Inch8CstClamp_Off.ErrID = 0;
            this.ib_Inch8CstClamp_Off.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Inch8CstClamp_Off.InAlarm = false;
            this.ib_Inch8CstClamp_Off.IOPort = "";
            this.ib_Inch8CstClamp_Off.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Inch8CstClamp_Off.Location = new System.Drawing.Point(3, 66);
            this.ib_Inch8CstClamp_Off.LockUI = false;
            this.ib_Inch8CstClamp_Off.Message = null;
            this.ib_Inch8CstClamp_Off.MsgID = 0;
            this.ib_Inch8CstClamp_Off.Name = "ib_Inch8CstClamp_Off";
            this.ib_Inch8CstClamp_Off.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Inch8CstClamp_Off.Running = false;
            this.ib_Inch8CstClamp_Off.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Inch8CstClamp_Off.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Inch8CstClamp_Off.Simu_OutPort1 = null;
            this.ib_Inch8CstClamp_Off.Simu_OutPort2 = null;
            this.ib_Inch8CstClamp_Off.Simu_RandomNum = 2;
            this.ib_Inch8CstClamp_Off.Simu_RandomTime = 100;
            this.ib_Inch8CstClamp_Off.Simu_ReflectDelayTm = 100;
            this.ib_Inch8CstClamp_Off.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Inch8CstClamp_Off.Simu_Reverse = false;
            this.ib_Inch8CstClamp_Off.Size = new System.Drawing.Size(211, 30);
            this.ib_Inch8CstClamp_Off.Text = "Off";
            // 
            // ob_Inch8CstClamp_Lock
            // 
            this.ob_Inch8CstClamp_Lock.ActionCount = 0;
            this.ob_Inch8CstClamp_Lock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Inch8CstClamp_Lock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Inch8CstClamp_Lock.DesignTimeParent = null;
            this.ob_Inch8CstClamp_Lock.ErrID = 0;
            this.ob_Inch8CstClamp_Lock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Inch8CstClamp_Lock.InAlarm = false;
            this.ob_Inch8CstClamp_Lock.IOPort = "";
            this.ob_Inch8CstClamp_Lock.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Inch8CstClamp_Lock.IsUseActionCount = false;
            this.ob_Inch8CstClamp_Lock.Location = new System.Drawing.Point(3, 104);
            this.ob_Inch8CstClamp_Lock.LockUI = false;
            this.ob_Inch8CstClamp_Lock.Message = null;
            this.ob_Inch8CstClamp_Lock.MsgID = 0;
            this.ob_Inch8CstClamp_Lock.Name = "ob_Inch8CstClamp_Lock";
            this.ob_Inch8CstClamp_Lock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Inch8CstClamp_Lock.RetryCount = 10;
            this.ob_Inch8CstClamp_Lock.Running = false;
            this.ob_Inch8CstClamp_Lock.Size = new System.Drawing.Size(211, 30);
            this.ob_Inch8CstClamp_Lock.Text = "Lock";
            this.ob_Inch8CstClamp_Lock.Value = false;
            // 
            // ob_Inch8CstClamp_Unlock
            // 
            this.ob_Inch8CstClamp_Unlock.ActionCount = 0;
            this.ob_Inch8CstClamp_Unlock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Inch8CstClamp_Unlock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Inch8CstClamp_Unlock.DesignTimeParent = null;
            this.ob_Inch8CstClamp_Unlock.ErrID = 0;
            this.ob_Inch8CstClamp_Unlock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Inch8CstClamp_Unlock.InAlarm = false;
            this.ob_Inch8CstClamp_Unlock.IOPort = "";
            this.ob_Inch8CstClamp_Unlock.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Inch8CstClamp_Unlock.IsUseActionCount = false;
            this.ob_Inch8CstClamp_Unlock.Location = new System.Drawing.Point(3, 142);
            this.ob_Inch8CstClamp_Unlock.LockUI = false;
            this.ob_Inch8CstClamp_Unlock.Message = null;
            this.ob_Inch8CstClamp_Unlock.MsgID = 0;
            this.ob_Inch8CstClamp_Unlock.Name = "ob_Inch8CstClamp_Unlock";
            this.ob_Inch8CstClamp_Unlock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Inch8CstClamp_Unlock.RetryCount = 10;
            this.ob_Inch8CstClamp_Unlock.Running = false;
            this.ob_Inch8CstClamp_Unlock.Size = new System.Drawing.Size(211, 30);
            this.ob_Inch8CstClamp_Unlock.Text = "Unlock";
            this.ob_Inch8CstClamp_Unlock.Value = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(3, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 35);
            this.button1.TabIndex = 39;
            this.button1.Tag = "Inch8CstClamp";
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label8);
            this.flowLayoutPanel9.Controls.Add(this.ib_8Inch);
            this.flowLayoutPanel9.Controls.Add(this.ib_8Inch_2);
            this.flowLayoutPanel9.Controls.Add(this.ib_Cassette);
            this.flowLayoutPanel9.Controls.Add(this.ib_Foup);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(452, 6);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(217, 225);
            this.flowLayoutPanel9.TabIndex = 48;
            this.flowLayoutPanel9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Inch Detect";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_8Inch
            // 
            this.ib_8Inch.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_8Inch.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_8Inch.DesignTimeParent = null;
            this.ib_8Inch.ErrID = 0;
            this.ib_8Inch.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_8Inch.InAlarm = false;
            this.ib_8Inch.IOPort = "";
            this.ib_8Inch.IOType = ProVLib.EIOType.IOHSL;
            this.ib_8Inch.Location = new System.Drawing.Point(3, 28);
            this.ib_8Inch.LockUI = false;
            this.ib_8Inch.Message = null;
            this.ib_8Inch.MsgID = 0;
            this.ib_8Inch.Name = "ib_8Inch";
            this.ib_8Inch.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_8Inch.Running = false;
            this.ib_8Inch.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_8Inch.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_8Inch.Simu_OutPort1 = null;
            this.ib_8Inch.Simu_OutPort2 = null;
            this.ib_8Inch.Simu_RandomNum = 2;
            this.ib_8Inch.Simu_RandomTime = 100;
            this.ib_8Inch.Simu_ReflectDelayTm = 100;
            this.ib_8Inch.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_8Inch.Simu_Reverse = false;
            this.ib_8Inch.Size = new System.Drawing.Size(211, 30);
            this.ib_8Inch.Text = "8 Inch";
            // 
            // ib_8Inch_2
            // 
            this.ib_8Inch_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_8Inch_2.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_8Inch_2.DesignTimeParent = null;
            this.ib_8Inch_2.ErrID = 0;
            this.ib_8Inch_2.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_8Inch_2.InAlarm = false;
            this.ib_8Inch_2.IOPort = "";
            this.ib_8Inch_2.IOType = ProVLib.EIOType.IOHSL;
            this.ib_8Inch_2.Location = new System.Drawing.Point(3, 66);
            this.ib_8Inch_2.LockUI = false;
            this.ib_8Inch_2.Message = null;
            this.ib_8Inch_2.MsgID = 0;
            this.ib_8Inch_2.Name = "ib_8Inch_2";
            this.ib_8Inch_2.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_8Inch_2.Running = false;
            this.ib_8Inch_2.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_8Inch_2.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_8Inch_2.Simu_OutPort1 = null;
            this.ib_8Inch_2.Simu_OutPort2 = null;
            this.ib_8Inch_2.Simu_RandomNum = 2;
            this.ib_8Inch_2.Simu_RandomTime = 100;
            this.ib_8Inch_2.Simu_ReflectDelayTm = 100;
            this.ib_8Inch_2.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_8Inch_2.Simu_Reverse = false;
            this.ib_8Inch_2.Size = new System.Drawing.Size(211, 30);
            this.ib_8Inch_2.Text = "8 Inch(2)";
            // 
            // ib_Cassette
            // 
            this.ib_Cassette.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Cassette.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Cassette.DesignTimeParent = null;
            this.ib_Cassette.ErrID = 0;
            this.ib_Cassette.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Cassette.InAlarm = false;
            this.ib_Cassette.IOPort = "";
            this.ib_Cassette.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Cassette.Location = new System.Drawing.Point(3, 104);
            this.ib_Cassette.LockUI = false;
            this.ib_Cassette.Message = null;
            this.ib_Cassette.MsgID = 0;
            this.ib_Cassette.Name = "ib_Cassette";
            this.ib_Cassette.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Cassette.Running = false;
            this.ib_Cassette.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Cassette.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Cassette.Simu_OutPort1 = null;
            this.ib_Cassette.Simu_OutPort2 = null;
            this.ib_Cassette.Simu_RandomNum = 2;
            this.ib_Cassette.Simu_RandomTime = 100;
            this.ib_Cassette.Simu_ReflectDelayTm = 100;
            this.ib_Cassette.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Cassette.Simu_Reverse = false;
            this.ib_Cassette.Size = new System.Drawing.Size(211, 30);
            this.ib_Cassette.Text = "Cassette";
            // 
            // ib_Foup
            // 
            this.ib_Foup.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Foup.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Foup.DesignTimeParent = null;
            this.ib_Foup.ErrID = 0;
            this.ib_Foup.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Foup.InAlarm = false;
            this.ib_Foup.IOPort = "";
            this.ib_Foup.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Foup.Location = new System.Drawing.Point(3, 142);
            this.ib_Foup.LockUI = false;
            this.ib_Foup.Message = null;
            this.ib_Foup.MsgID = 0;
            this.ib_Foup.Name = "ib_Foup";
            this.ib_Foup.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Foup.Running = false;
            this.ib_Foup.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Foup.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Foup.Simu_OutPort1 = null;
            this.ib_Foup.Simu_OutPort2 = null;
            this.ib_Foup.Simu_RandomNum = 2;
            this.ib_Foup.Simu_RandomTime = 100;
            this.ib_Foup.Simu_ReflectDelayTm = 100;
            this.ib_Foup.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Foup.Simu_Reverse = false;
            this.ib_Foup.Size = new System.Drawing.Size(211, 30);
            this.ib_Foup.Text = "Foup";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.label11);
            this.flowLayoutPanel11.Controls.Add(this.ib_ManualButton);
            this.flowLayoutPanel11.Controls.Add(this.ob_ManualButton_Light);
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(6, 176);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(217, 143);
            this.flowLayoutPanel11.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hand Off(1)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_ManualButton
            // 
            this.ib_ManualButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ManualButton.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ManualButton.DesignTimeParent = null;
            this.ib_ManualButton.ErrID = 0;
            this.ib_ManualButton.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ManualButton.InAlarm = false;
            this.ib_ManualButton.IOPort = "0314";
            this.ib_ManualButton.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ManualButton.Location = new System.Drawing.Point(3, 28);
            this.ib_ManualButton.LockUI = false;
            this.ib_ManualButton.Message = null;
            this.ib_ManualButton.MsgID = 0;
            this.ib_ManualButton.Name = "ib_ManualButton";
            this.ib_ManualButton.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ManualButton.Running = false;
            this.ib_ManualButton.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ManualButton.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ManualButton.Simu_OutPort1 = null;
            this.ib_ManualButton.Simu_OutPort2 = null;
            this.ib_ManualButton.Simu_RandomNum = 2;
            this.ib_ManualButton.Simu_RandomTime = 100;
            this.ib_ManualButton.Simu_ReflectDelayTm = 100;
            this.ib_ManualButton.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ManualButton.Simu_Reverse = false;
            this.ib_ManualButton.Size = new System.Drawing.Size(211, 30);
            this.ib_ManualButton.Text = "Hand Off";
            // 
            // ob_ManualButton_Light
            // 
            this.ob_ManualButton_Light.ActionCount = 0;
            this.ob_ManualButton_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_ManualButton_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_ManualButton_Light.DesignTimeParent = null;
            this.ob_ManualButton_Light.ErrID = 0;
            this.ob_ManualButton_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_ManualButton_Light.InAlarm = false;
            this.ob_ManualButton_Light.IOPort = "";
            this.ob_ManualButton_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_ManualButton_Light.IsUseActionCount = false;
            this.ob_ManualButton_Light.Location = new System.Drawing.Point(3, 66);
            this.ob_ManualButton_Light.LockUI = false;
            this.ob_ManualButton_Light.Message = null;
            this.ob_ManualButton_Light.MsgID = 0;
            this.ob_ManualButton_Light.Name = "ob_ManualButton_Light";
            this.ob_ManualButton_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_ManualButton_Light.RetryCount = 10;
            this.ob_ManualButton_Light.Running = false;
            this.ob_ManualButton_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_ManualButton_Light.Text = "Light";
            this.ob_ManualButton_Light.Value = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label9);
            this.flowLayoutPanel8.Controls.Add(this.ib_VaccumDetect);
            this.flowLayoutPanel8.Controls.Add(this.ob_Vaccum);
            this.flowLayoutPanel8.Controls.Add(this.ob_Destory);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(217, 163);
            this.flowLayoutPanel8.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vaccum(6)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_VaccumDetect
            // 
            this.ib_VaccumDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_VaccumDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_VaccumDetect.DesignTimeParent = null;
            this.ib_VaccumDetect.ErrID = 0;
            this.ib_VaccumDetect.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_VaccumDetect.InAlarm = false;
            this.ib_VaccumDetect.IOPort = "031E";
            this.ib_VaccumDetect.IOType = ProVLib.EIOType.IOHSL;
            this.ib_VaccumDetect.Location = new System.Drawing.Point(3, 28);
            this.ib_VaccumDetect.LockUI = false;
            this.ib_VaccumDetect.Message = null;
            this.ib_VaccumDetect.MsgID = 0;
            this.ib_VaccumDetect.Name = "ib_VaccumDetect";
            this.ib_VaccumDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_VaccumDetect.Running = false;
            this.ib_VaccumDetect.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_VaccumDetect.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_VaccumDetect.Simu_OutPort1 = null;
            this.ib_VaccumDetect.Simu_OutPort2 = null;
            this.ib_VaccumDetect.Simu_RandomNum = 2;
            this.ib_VaccumDetect.Simu_RandomTime = 100;
            this.ib_VaccumDetect.Simu_ReflectDelayTm = 100;
            this.ib_VaccumDetect.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_VaccumDetect.Simu_Reverse = false;
            this.ib_VaccumDetect.Size = new System.Drawing.Size(211, 30);
            this.ib_VaccumDetect.Text = "Vacuum Detect";
            // 
            // ob_Vaccum
            // 
            this.ob_Vaccum.ActionCount = 0;
            this.ob_Vaccum.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Vaccum.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Vaccum.DesignTimeParent = null;
            this.ob_Vaccum.ErrID = 0;
            this.ob_Vaccum.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Vaccum.InAlarm = false;
            this.ob_Vaccum.IOPort = "2310";
            this.ob_Vaccum.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Vaccum.IsUseActionCount = false;
            this.ob_Vaccum.Location = new System.Drawing.Point(3, 66);
            this.ob_Vaccum.LockUI = false;
            this.ob_Vaccum.Message = null;
            this.ob_Vaccum.MsgID = 0;
            this.ob_Vaccum.Name = "ob_Vaccum";
            this.ob_Vaccum.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Vaccum.RetryCount = 10;
            this.ob_Vaccum.Running = false;
            this.ob_Vaccum.Size = new System.Drawing.Size(211, 30);
            this.ob_Vaccum.Text = "Vaccum";
            this.ob_Vaccum.Value = false;
            // 
            // ob_Destory
            // 
            this.ob_Destory.ActionCount = 0;
            this.ob_Destory.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Destory.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Destory.DesignTimeParent = null;
            this.ob_Destory.ErrID = 0;
            this.ob_Destory.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Destory.InAlarm = false;
            this.ob_Destory.IOPort = "2311";
            this.ob_Destory.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Destory.IsUseActionCount = false;
            this.ob_Destory.Location = new System.Drawing.Point(3, 104);
            this.ob_Destory.LockUI = false;
            this.ob_Destory.Message = null;
            this.ob_Destory.MsgID = 0;
            this.ob_Destory.Name = "ob_Destory";
            this.ob_Destory.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Destory.RetryCount = 10;
            this.ob_Destory.Running = false;
            this.ob_Destory.Size = new System.Drawing.Size(211, 30);
            this.ob_Destory.Text = "Destory";
            this.ob_Destory.Value = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.ib_DoorY_Out);
            this.flowLayoutPanel5.Controls.Add(this.ib_DoorY_Back);
            this.flowLayoutPanel5.Controls.Add(this.ob_DoorY_Out);
            this.flowLayoutPanel5.Controls.Add(this.ob_DoorY_Back);
            this.flowLayoutPanel5.Controls.Add(this.btn_DoorY_SW);
            this.flowLayoutPanel5.Controls.Add(this.label10);
            this.flowLayoutPanel5.Controls.Add(this.MT_DoorZ);
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(229, 6);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(217, 521);
            this.flowLayoutPanel5.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Door Y-Axis(5)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_DoorY_Out
            // 
            this.ib_DoorY_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_DoorY_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_DoorY_Out.DesignTimeParent = null;
            this.ib_DoorY_Out.ErrID = 0;
            this.ib_DoorY_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_DoorY_Out.InAlarm = false;
            this.ib_DoorY_Out.IOPort = "031C";
            this.ib_DoorY_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ib_DoorY_Out.Location = new System.Drawing.Point(3, 28);
            this.ib_DoorY_Out.LockUI = false;
            this.ib_DoorY_Out.Message = null;
            this.ib_DoorY_Out.MsgID = 0;
            this.ib_DoorY_Out.Name = "ib_DoorY_Out";
            this.ib_DoorY_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_DoorY_Out.Running = false;
            this.ib_DoorY_Out.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_DoorY_Out.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_DoorY_Out.Simu_OutPort1 = null;
            this.ib_DoorY_Out.Simu_OutPort2 = null;
            this.ib_DoorY_Out.Simu_RandomNum = 2;
            this.ib_DoorY_Out.Simu_RandomTime = 100;
            this.ib_DoorY_Out.Simu_ReflectDelayTm = 100;
            this.ib_DoorY_Out.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_DoorY_Out.Simu_Reverse = false;
            this.ib_DoorY_Out.Size = new System.Drawing.Size(211, 30);
            this.ib_DoorY_Out.Text = "On";
            // 
            // ib_DoorY_Back
            // 
            this.ib_DoorY_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_DoorY_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_DoorY_Back.DesignTimeParent = null;
            this.ib_DoorY_Back.ErrID = 0;
            this.ib_DoorY_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_DoorY_Back.InAlarm = false;
            this.ib_DoorY_Back.IOPort = "031D";
            this.ib_DoorY_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ib_DoorY_Back.Location = new System.Drawing.Point(3, 66);
            this.ib_DoorY_Back.LockUI = false;
            this.ib_DoorY_Back.Message = null;
            this.ib_DoorY_Back.MsgID = 0;
            this.ib_DoorY_Back.Name = "ib_DoorY_Back";
            this.ib_DoorY_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_DoorY_Back.Running = false;
            this.ib_DoorY_Back.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_DoorY_Back.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_DoorY_Back.Simu_OutPort1 = null;
            this.ib_DoorY_Back.Simu_OutPort2 = null;
            this.ib_DoorY_Back.Simu_RandomNum = 2;
            this.ib_DoorY_Back.Simu_RandomTime = 100;
            this.ib_DoorY_Back.Simu_ReflectDelayTm = 100;
            this.ib_DoorY_Back.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_DoorY_Back.Simu_Reverse = false;
            this.ib_DoorY_Back.Size = new System.Drawing.Size(211, 30);
            this.ib_DoorY_Back.Text = "Off";
            // 
            // ob_DoorY_Out
            // 
            this.ob_DoorY_Out.ActionCount = 0;
            this.ob_DoorY_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_DoorY_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_DoorY_Out.DesignTimeParent = null;
            this.ob_DoorY_Out.ErrID = 0;
            this.ob_DoorY_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_DoorY_Out.InAlarm = false;
            this.ob_DoorY_Out.IOPort = "230C";
            this.ob_DoorY_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ob_DoorY_Out.IsUseActionCount = false;
            this.ob_DoorY_Out.Location = new System.Drawing.Point(3, 104);
            this.ob_DoorY_Out.LockUI = false;
            this.ob_DoorY_Out.Message = null;
            this.ob_DoorY_Out.MsgID = 0;
            this.ob_DoorY_Out.Name = "ob_DoorY_Out";
            this.ob_DoorY_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_DoorY_Out.RetryCount = 10;
            this.ob_DoorY_Out.Running = false;
            this.ob_DoorY_Out.Size = new System.Drawing.Size(211, 30);
            this.ob_DoorY_Out.Text = "Push";
            this.ob_DoorY_Out.Value = false;
            // 
            // ob_DoorY_Back
            // 
            this.ob_DoorY_Back.ActionCount = 0;
            this.ob_DoorY_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_DoorY_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_DoorY_Back.DesignTimeParent = null;
            this.ob_DoorY_Back.ErrID = 0;
            this.ob_DoorY_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_DoorY_Back.InAlarm = false;
            this.ob_DoorY_Back.IOPort = "230D";
            this.ob_DoorY_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ob_DoorY_Back.IsUseActionCount = false;
            this.ob_DoorY_Back.Location = new System.Drawing.Point(3, 142);
            this.ob_DoorY_Back.LockUI = false;
            this.ob_DoorY_Back.Message = null;
            this.ob_DoorY_Back.MsgID = 0;
            this.ob_DoorY_Back.Name = "ob_DoorY_Back";
            this.ob_DoorY_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_DoorY_Back.RetryCount = 10;
            this.ob_DoorY_Back.Running = false;
            this.ob_DoorY_Back.Size = new System.Drawing.Size(211, 30);
            this.ob_DoorY_Back.Text = "Pull";
            this.ob_DoorY_Back.Value = false;
            this.ob_DoorY_Back.IsSafeToAction += new ProVLib.OutBit.SafeActionEventHandler(this.ob_DoorY_Back_IsSafeToAction);
            // 
            // btn_DoorY_SW
            // 
            this.btn_DoorY_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_DoorY_SW.Location = new System.Drawing.Point(3, 179);
            this.btn_DoorY_SW.Name = "btn_DoorY_SW";
            this.btn_DoorY_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_DoorY_SW.TabIndex = 39;
            this.btn_DoorY_SW.Tag = "DoorY";
            this.btn_DoorY_SW.Text = "Switch";
            this.btn_DoorY_SW.UseVisualStyleBackColor = false;
            this.btn_DoorY_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(3, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Door Z-Axis(4)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MT_DoorZ
            // 
            this.MT_DoorZ.Acceleration = 300000;
            this.MT_DoorZ.AcceptDiffRange = ((uint)(0u));
            this.MT_DoorZ.AddressID = 0;
            this.MT_DoorZ.AlarmPolarity = ProVLib.ALMPOLARITY.ACTIVELOW;
            this.MT_DoorZ.AxisDir = ProVLib.AxisDIRType.AXIS_Z;
            this.MT_DoorZ.AxisIndex = 0;
            this.MT_DoorZ.BackColor = System.Drawing.Color.RoyalBlue;
            this.MT_DoorZ.BasePulseCount = 0;
            this.MT_DoorZ.CaptionFont = new System.Drawing.Font("微軟正黑體", 10F);
            this.MT_DoorZ.CMPSRC = ProVLib.ECMPSRC.CMPSRC_None;
            this.MT_DoorZ.D2 = ((byte)(0));
            this.MT_DoorZ.D4 = ((byte)(0));
            this.MT_DoorZ.Deceleration = 300000;
            this.MT_DoorZ.DelayTime = 0D;
            this.MT_DoorZ.DesignTimeParent = null;
            this.MT_DoorZ.Direction = true;
            this.MT_DoorZ.DownZ1 = 0;
            this.MT_DoorZ.DownZ2 = 0;
            this.MT_DoorZ.DownZ3 = 0;
            this.MT_DoorZ.EncGearRatio = 1D;
            this.MT_DoorZ.EndX = 0;
            this.MT_DoorZ.ErrID = 0;
            this.MT_DoorZ.ExtraMotor = null;
            this.MT_DoorZ.Function = ProVLib.ExtraFunction.None;
            this.MT_DoorZ.GearRatio = 1D;
            this.MT_DoorZ.GroupNo = ((short)(0));
            this.MT_DoorZ.HomeBeforeGoto = false;
            this.MT_DoorZ.HomeDirection = true;
            this.MT_DoorZ.HomeMode = ProVLib.HOMEMODE.LIMITSNR;
            this.MT_DoorZ.HomeOK = false;
            this.MT_DoorZ.HomePos = 100;
            this.MT_DoorZ.InAlarm = false;
            this.MT_DoorZ.InitialPosition = 0;
            this.MT_DoorZ.InitSpeed = 100;
            this.MT_DoorZ.InPosOn = false;
            this.MT_DoorZ.InposRange = 50;
            this.MT_DoorZ.IOPort = "000";
            this.MT_DoorZ.IsAlarmReseted = false;
            this.MT_DoorZ.IsELSensorB = true;
            this.MT_DoorZ.IsSensorB = true;
            this.MT_DoorZ.IsUseMileage = false;
            this.MT_DoorZ.IsUseSoftLimit = false;
            this.MT_DoorZ.JogHighSpeed = 30000;
            this.MT_DoorZ.JogLowSpeed = 1000;
            this.MT_DoorZ.LimitX = 0;
            this.MT_DoorZ.LimitZ = 0;
            this.MT_DoorZ.LineID = ((uint)(0u));
            this.MT_DoorZ.Location = new System.Drawing.Point(3, 245);
            this.MT_DoorZ.LockUI = false;
            this.MT_DoorZ.Message = null;
            this.MT_DoorZ.Mileage = 0F;
            this.MT_DoorZ.MNETSpeed = ProVLib.EMNETSPEED.MNET10M;
            motorParam2.Acceleration = 300000;
            motorParam2.AddressID = 0;
            motorParam2.AlarmPolarity = ProVLib.ALMPOLARITY.ACTIVELOW;
            motorParam2.AxisDIR = ProVLib.AxisDIRType.AXIS_Z;
            motorParam2.AxisIndex = 0;
            motorParam2.BasePulseCount = 0;
            motorParam2.CMPSRC = ProVLib.ECMPSRC.CMPSRC_None;
            motorParam2.CommandPos = 0;
            motorParam2.Deceleration = 300000;
            motorParam2.DelayT = 0D;
            motorParam2.Direction = true;
            motorParam2.DownZ1 = 0;
            motorParam2.DownZ2 = 0;
            motorParam2.DownZ3 = 0;
            motorParam2.EncGearRatio = 1D;
            motorParam2.EncoderPos = 0;
            motorParam2.EndX = 0;
            motorParam2.ExtraMotor = null;
            motorParam2.Function = ProVLib.ExtraFunction.None;
            motorParam2.GearRatio = 1D;
            motorParam2.GroupNo = ((short)(0));
            motorParam2.HomeBeforeGoto = false;
            motorParam2.HomeDirection = true;
            motorParam2.HomeException = ProVLib.HOMEEXP.Default;
            motorParam2.HomeMode = ProVLib.HOMEMODE.LIMITSNR;
            motorParam2.HomePos = 100;
            motorParam2.IDZ = ((short)(0));
            motorParam2.InitSpeed = 100;
            motorParam2.InPosOn = false;
            motorParam2.InposRange = 50;
            motorParam2.IOPort = "000";
            motorParam2.IsAlarmReseted = false;
            motorParam2.IsBusy = false;
            motorParam2.IsELSensorB = true;
            motorParam2.IsSensorB = true;
            motorParam2.IsUseSoftLimit = false;
            motorParam2.JogHighSpeed = 30000;
            motorParam2.JogLowSpeed = 1000;
            motorParam2.LimitX = 0;
            motorParam2.LimitZ = 0;
            motorParam2.MNETSpeed = ProVLib.EMNETSPEED.MNET10M;
            motorParam2.MotionCard = ProVLib.EMOTIONCARD.MCMNET;
            motorParam2.MotorType = ProVLib.MOTORTYPE.NORMAL;
            motorParam2.ObjType = 0;
            motorParam2.Owner = null;
            motorParam2.PitchCOMEnable = false;
            motorParam2.PulseCtrlMode = ProVLib.EPULSEMODE.CWCCW_2;
            motorParam2.ScanByKernal = false;
            motorParam2.SCurveAccRatio = 50;
            motorParam2.SCurveDecRatio = 50;
            motorParam2.SerialPortName = "COM1";
            motorParam2.ServoAlarmOn = false;
            motorParam2.ServoOnPolarity = ProVLib.SVONPOLARITY.ACTIVELOW;
            motorParam2.SlaveIOPort = null;
            motorParam2.SoftLimitN = -9999999;
            motorParam2.SoftLimitP = 9999999;
            motorParam2.Speed = 50000;
            motorParam2.SpeedPattern = ProVLib.MOVINGPATTERN.T_Curve;
            motorParam2.StopDeceleration = 100000000;
            motorParam2.TRGSRC = ProVLib.ETRIGGERSRC.TRGENC;
            motorParam2.TriggerChannel = ProVLib.ETriggerChannel.CH_1;
            motorParam2.TriggerPolarity = ProVLib.ETriggerLogic.ActiveLow;
            motorParam2.UpZ = 0;
            motorParam2.ZPhaseLogic = ProVLib.ZPHASELOGIC.FALLINGEDGE;
            this.MT_DoorZ.MotorParameter = motorParam2;
            this.MT_DoorZ.MoverSize = ((uint)(0u));
            this.MT_DoorZ.MsgID = 0;
            this.MT_DoorZ.Name = "MT_DoorZ";
            this.MT_DoorZ.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.MT_DoorZ.PitchCOMEnable = false;
            this.MT_DoorZ.PriorityHigh = ((uint)(0u));
            this.MT_DoorZ.PriorityLow = ((uint)(0u));
            this.MT_DoorZ.PulseCtrlMode = ProVLib.EPULSEMODE.CWCCW_2;
            this.MT_DoorZ.RelCurrentPos = 0;
            this.MT_DoorZ.RelTargetPos = 0;
            this.MT_DoorZ.Running = false;
            this.MT_DoorZ.SafeDistance = ((uint)(0u));
            this.MT_DoorZ.ScanByKernal = false;
            this.MT_DoorZ.SCurveAccRatio = 50;
            this.MT_DoorZ.SCurveDecRatio = 50;
            this.MT_DoorZ.SerialPortName = "COM1";
            this.MT_DoorZ.ServoAlarmOn = false;
            this.MT_DoorZ.ServoOnPolarity = ProVLib.SVONPOLARITY.ACTIVELOW;
            this.MT_DoorZ.Size = new System.Drawing.Size(211, 30);
            this.MT_DoorZ.SlaveIOPort = null;
            this.MT_DoorZ.SoftLimitN = -9999999;
            this.MT_DoorZ.SoftLimitP = 9999999;
            this.MT_DoorZ.Speed = 50000;
            this.MT_DoorZ.Text = "Door Z";
            this.MT_DoorZ.TRGSRC = ProVLib.ETRIGGERSRC.TRGENC;
            this.MT_DoorZ.TriggerChannel = ProVLib.ETriggerChannel.CH_1;
            this.MT_DoorZ.TriggerPolarity = ProVLib.ETriggerLogic.ActiveLow;
            this.MT_DoorZ.UpZ = 0;
            this.MT_DoorZ.ZPhaseLogic = ProVLib.ZPHASELOGIC.FALLINGEDGE;
            this.MT_DoorZ.IsSafeToRun += new ProVLib.Motor.SafeRunEventHandler(this.MT_DoorZ_IsSafeToRun);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(3, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 35);
            this.button3.TabIndex = 45;
            this.button3.Tag = "DoorZ";
            this.button3.Text = "Motor Ctrl";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel13);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.flowLayoutPanel12);
            this.tabPage3.Controls.Add(this.flowLayoutPanel7);
            this.tabPage3.Controls.Add(this.flowLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(948, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.label15);
            this.flowLayoutPanel13.Controls.Add(this.IB_MappingCY_On);
            this.flowLayoutPanel13.Controls.Add(this.IB_MappingCY_Off);
            this.flowLayoutPanel13.Controls.Add(this.OB_MappingCY_Push);
            this.flowLayoutPanel13.Controls.Add(this.OB_MappingCY_Pull);
            this.flowLayoutPanel13.Controls.Add(this.button4);
            this.flowLayoutPanel13.Controls.Add(this.IB_Wafer_Mapping_Sensor);
            this.flowLayoutPanel13.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel13.Location = new System.Drawing.Point(6, 262);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(217, 264);
            this.flowLayoutPanel13.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkGray;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "Mapping";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IB_MappingCY_On
            // 
            this.IB_MappingCY_On.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_MappingCY_On.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IB_MappingCY_On.DesignTimeParent = null;
            this.IB_MappingCY_On.ErrID = 0;
            this.IB_MappingCY_On.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_MappingCY_On.InAlarm = false;
            this.IB_MappingCY_On.IOPort = "";
            this.IB_MappingCY_On.IOType = ProVLib.EIOType.IOHSL;
            this.IB_MappingCY_On.Location = new System.Drawing.Point(3, 28);
            this.IB_MappingCY_On.LockUI = false;
            this.IB_MappingCY_On.Message = null;
            this.IB_MappingCY_On.MsgID = 0;
            this.IB_MappingCY_On.Name = "IB_MappingCY_On";
            this.IB_MappingCY_On.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_MappingCY_On.Running = false;
            this.IB_MappingCY_On.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.IB_MappingCY_On.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.IB_MappingCY_On.Simu_OutPort1 = null;
            this.IB_MappingCY_On.Simu_OutPort2 = null;
            this.IB_MappingCY_On.Simu_RandomNum = 2;
            this.IB_MappingCY_On.Simu_RandomTime = 100;
            this.IB_MappingCY_On.Simu_ReflectDelayTm = 100;
            this.IB_MappingCY_On.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_MappingCY_On.Simu_Reverse = false;
            this.IB_MappingCY_On.Size = new System.Drawing.Size(211, 30);
            this.IB_MappingCY_On.Text = "On";
            // 
            // IB_MappingCY_Off
            // 
            this.IB_MappingCY_Off.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_MappingCY_Off.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IB_MappingCY_Off.DesignTimeParent = null;
            this.IB_MappingCY_Off.ErrID = 0;
            this.IB_MappingCY_Off.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_MappingCY_Off.InAlarm = false;
            this.IB_MappingCY_Off.IOPort = "";
            this.IB_MappingCY_Off.IOType = ProVLib.EIOType.IOHSL;
            this.IB_MappingCY_Off.Location = new System.Drawing.Point(3, 66);
            this.IB_MappingCY_Off.LockUI = false;
            this.IB_MappingCY_Off.Message = null;
            this.IB_MappingCY_Off.MsgID = 0;
            this.IB_MappingCY_Off.Name = "IB_MappingCY_Off";
            this.IB_MappingCY_Off.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_MappingCY_Off.Running = false;
            this.IB_MappingCY_Off.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.IB_MappingCY_Off.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.IB_MappingCY_Off.Simu_OutPort1 = null;
            this.IB_MappingCY_Off.Simu_OutPort2 = null;
            this.IB_MappingCY_Off.Simu_RandomNum = 2;
            this.IB_MappingCY_Off.Simu_RandomTime = 100;
            this.IB_MappingCY_Off.Simu_ReflectDelayTm = 100;
            this.IB_MappingCY_Off.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_MappingCY_Off.Simu_Reverse = false;
            this.IB_MappingCY_Off.Size = new System.Drawing.Size(211, 30);
            this.IB_MappingCY_Off.Text = "Off";
            // 
            // OB_MappingCY_Push
            // 
            this.OB_MappingCY_Push.ActionCount = 0;
            this.OB_MappingCY_Push.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_MappingCY_Push.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OB_MappingCY_Push.DesignTimeParent = null;
            this.OB_MappingCY_Push.ErrID = 0;
            this.OB_MappingCY_Push.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_MappingCY_Push.InAlarm = false;
            this.OB_MappingCY_Push.IOPort = "230E";
            this.OB_MappingCY_Push.IOType = ProVLib.EIOType.IOHSL;
            this.OB_MappingCY_Push.IsUseActionCount = false;
            this.OB_MappingCY_Push.Location = new System.Drawing.Point(3, 104);
            this.OB_MappingCY_Push.LockUI = false;
            this.OB_MappingCY_Push.Message = null;
            this.OB_MappingCY_Push.MsgID = 0;
            this.OB_MappingCY_Push.Name = "OB_MappingCY_Push";
            this.OB_MappingCY_Push.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_MappingCY_Push.RetryCount = 10;
            this.OB_MappingCY_Push.Running = false;
            this.OB_MappingCY_Push.Size = new System.Drawing.Size(211, 30);
            this.OB_MappingCY_Push.Text = "Cylinder On";
            this.OB_MappingCY_Push.Value = false;
            this.OB_MappingCY_Push.IsSafeToAction += new ProVLib.OutBit.SafeActionEventHandler(this.OB_MappingCY_Push_IsSafeToAction);
            // 
            // OB_MappingCY_Pull
            // 
            this.OB_MappingCY_Pull.ActionCount = 0;
            this.OB_MappingCY_Pull.BackColor = System.Drawing.Color.RoyalBlue;
            this.OB_MappingCY_Pull.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OB_MappingCY_Pull.DesignTimeParent = null;
            this.OB_MappingCY_Pull.ErrID = 0;
            this.OB_MappingCY_Pull.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.OB_MappingCY_Pull.InAlarm = false;
            this.OB_MappingCY_Pull.IOPort = "230F";
            this.OB_MappingCY_Pull.IOType = ProVLib.EIOType.IOHSL;
            this.OB_MappingCY_Pull.IsUseActionCount = false;
            this.OB_MappingCY_Pull.Location = new System.Drawing.Point(3, 142);
            this.OB_MappingCY_Pull.LockUI = false;
            this.OB_MappingCY_Pull.Message = null;
            this.OB_MappingCY_Pull.MsgID = 0;
            this.OB_MappingCY_Pull.Name = "OB_MappingCY_Pull";
            this.OB_MappingCY_Pull.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.OB_MappingCY_Pull.RetryCount = 10;
            this.OB_MappingCY_Pull.Running = false;
            this.OB_MappingCY_Pull.Size = new System.Drawing.Size(211, 30);
            this.OB_MappingCY_Pull.Text = "Cylinder Off";
            this.OB_MappingCY_Pull.Value = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(3, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 35);
            this.button4.TabIndex = 39;
            this.button4.Tag = "Latch";
            this.button4.Text = "Switch";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // IB_Wafer_Mapping_Sensor
            // 
            this.IB_Wafer_Mapping_Sensor.BackColor = System.Drawing.Color.RoyalBlue;
            this.IB_Wafer_Mapping_Sensor.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IB_Wafer_Mapping_Sensor.DesignTimeParent = null;
            this.IB_Wafer_Mapping_Sensor.ErrID = 0;
            this.IB_Wafer_Mapping_Sensor.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.IB_Wafer_Mapping_Sensor.InAlarm = false;
            this.IB_Wafer_Mapping_Sensor.IOPort = "";
            this.IB_Wafer_Mapping_Sensor.IOType = ProVLib.EIOType.IOHSL;
            this.IB_Wafer_Mapping_Sensor.Location = new System.Drawing.Point(3, 221);
            this.IB_Wafer_Mapping_Sensor.LockUI = false;
            this.IB_Wafer_Mapping_Sensor.Message = null;
            this.IB_Wafer_Mapping_Sensor.MsgID = 0;
            this.IB_Wafer_Mapping_Sensor.Name = "IB_Wafer_Mapping_Sensor";
            this.IB_Wafer_Mapping_Sensor.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.IB_Wafer_Mapping_Sensor.Running = false;
            this.IB_Wafer_Mapping_Sensor.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.IB_Wafer_Mapping_Sensor.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.IB_Wafer_Mapping_Sensor.Simu_OutPort1 = null;
            this.IB_Wafer_Mapping_Sensor.Simu_OutPort2 = null;
            this.IB_Wafer_Mapping_Sensor.Simu_RandomNum = 2;
            this.IB_Wafer_Mapping_Sensor.Simu_RandomTime = 100;
            this.IB_Wafer_Mapping_Sensor.Simu_ReflectDelayTm = 100;
            this.IB_Wafer_Mapping_Sensor.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.IB_Wafer_Mapping_Sensor.Simu_Reverse = false;
            this.IB_Wafer_Mapping_Sensor.Size = new System.Drawing.Size(211, 30);
            this.IB_Wafer_Mapping_Sensor.Text = "Mapping Value";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LPA.Properties.Resources.FLP3;
            this.pictureBox3.Location = new System.Drawing.Point(737, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(426, 410);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.label12);
            this.flowLayoutPanel12.Controls.Add(this.ob_Alarm_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Load_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Unload_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Placement_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Manual_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Auto_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Presense_Light);
            this.flowLayoutPanel12.Controls.Add(this.ob_Reserve_Light);
            this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(452, 6);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(217, 344);
            this.flowLayoutPanel12.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGray;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Indicator Light";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ob_Alarm_Light
            // 
            this.ob_Alarm_Light.ActionCount = 0;
            this.ob_Alarm_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Alarm_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Alarm_Light.DesignTimeParent = null;
            this.ob_Alarm_Light.ErrID = 0;
            this.ob_Alarm_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Alarm_Light.InAlarm = false;
            this.ob_Alarm_Light.IOPort = "231F";
            this.ob_Alarm_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Alarm_Light.IsUseActionCount = false;
            this.ob_Alarm_Light.Location = new System.Drawing.Point(3, 28);
            this.ob_Alarm_Light.LockUI = false;
            this.ob_Alarm_Light.Message = null;
            this.ob_Alarm_Light.MsgID = 0;
            this.ob_Alarm_Light.Name = "ob_Alarm_Light";
            this.ob_Alarm_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Alarm_Light.RetryCount = 10;
            this.ob_Alarm_Light.Running = false;
            this.ob_Alarm_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Alarm_Light.Text = "Alarm";
            this.ob_Alarm_Light.Value = false;
            // 
            // ob_Load_Light
            // 
            this.ob_Load_Light.ActionCount = 0;
            this.ob_Load_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Load_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Load_Light.DesignTimeParent = null;
            this.ob_Load_Light.ErrID = 0;
            this.ob_Load_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Load_Light.InAlarm = false;
            this.ob_Load_Light.IOPort = "2318";
            this.ob_Load_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Load_Light.IsUseActionCount = false;
            this.ob_Load_Light.Location = new System.Drawing.Point(3, 66);
            this.ob_Load_Light.LockUI = false;
            this.ob_Load_Light.Message = null;
            this.ob_Load_Light.MsgID = 0;
            this.ob_Load_Light.Name = "ob_Load_Light";
            this.ob_Load_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Load_Light.RetryCount = 10;
            this.ob_Load_Light.Running = false;
            this.ob_Load_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Load_Light.Text = "Load";
            this.ob_Load_Light.Value = false;
            // 
            // ob_Unload_Light
            // 
            this.ob_Unload_Light.ActionCount = 0;
            this.ob_Unload_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Unload_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Unload_Light.DesignTimeParent = null;
            this.ob_Unload_Light.ErrID = 0;
            this.ob_Unload_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Unload_Light.InAlarm = false;
            this.ob_Unload_Light.IOPort = "2319";
            this.ob_Unload_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Unload_Light.IsUseActionCount = false;
            this.ob_Unload_Light.Location = new System.Drawing.Point(3, 104);
            this.ob_Unload_Light.LockUI = false;
            this.ob_Unload_Light.Message = null;
            this.ob_Unload_Light.MsgID = 0;
            this.ob_Unload_Light.Name = "ob_Unload_Light";
            this.ob_Unload_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Unload_Light.RetryCount = 10;
            this.ob_Unload_Light.Running = false;
            this.ob_Unload_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Unload_Light.Text = "Unload";
            this.ob_Unload_Light.Value = false;
            // 
            // ob_Placement_Light
            // 
            this.ob_Placement_Light.ActionCount = 0;
            this.ob_Placement_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Placement_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Placement_Light.DesignTimeParent = null;
            this.ob_Placement_Light.ErrID = 0;
            this.ob_Placement_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Placement_Light.InAlarm = false;
            this.ob_Placement_Light.IOPort = "231C";
            this.ob_Placement_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Placement_Light.IsUseActionCount = false;
            this.ob_Placement_Light.Location = new System.Drawing.Point(3, 142);
            this.ob_Placement_Light.LockUI = false;
            this.ob_Placement_Light.Message = null;
            this.ob_Placement_Light.MsgID = 0;
            this.ob_Placement_Light.Name = "ob_Placement_Light";
            this.ob_Placement_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Placement_Light.RetryCount = 10;
            this.ob_Placement_Light.Running = false;
            this.ob_Placement_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Placement_Light.Text = "Placement";
            this.ob_Placement_Light.Value = false;
            // 
            // ob_Manual_Light
            // 
            this.ob_Manual_Light.ActionCount = 0;
            this.ob_Manual_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Manual_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Manual_Light.DesignTimeParent = null;
            this.ob_Manual_Light.ErrID = 0;
            this.ob_Manual_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Manual_Light.InAlarm = false;
            this.ob_Manual_Light.IOPort = "231A";
            this.ob_Manual_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Manual_Light.IsUseActionCount = false;
            this.ob_Manual_Light.Location = new System.Drawing.Point(3, 180);
            this.ob_Manual_Light.LockUI = false;
            this.ob_Manual_Light.Message = null;
            this.ob_Manual_Light.MsgID = 0;
            this.ob_Manual_Light.Name = "ob_Manual_Light";
            this.ob_Manual_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Manual_Light.RetryCount = 10;
            this.ob_Manual_Light.Running = false;
            this.ob_Manual_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Manual_Light.Text = "Manual";
            this.ob_Manual_Light.Value = false;
            // 
            // ob_Auto_Light
            // 
            this.ob_Auto_Light.ActionCount = 0;
            this.ob_Auto_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Auto_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Auto_Light.DesignTimeParent = null;
            this.ob_Auto_Light.ErrID = 0;
            this.ob_Auto_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Auto_Light.InAlarm = false;
            this.ob_Auto_Light.IOPort = "231D";
            this.ob_Auto_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Auto_Light.IsUseActionCount = false;
            this.ob_Auto_Light.Location = new System.Drawing.Point(3, 218);
            this.ob_Auto_Light.LockUI = false;
            this.ob_Auto_Light.Message = null;
            this.ob_Auto_Light.MsgID = 0;
            this.ob_Auto_Light.Name = "ob_Auto_Light";
            this.ob_Auto_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Auto_Light.RetryCount = 10;
            this.ob_Auto_Light.Running = false;
            this.ob_Auto_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Auto_Light.Text = "Auto";
            this.ob_Auto_Light.Value = false;
            // 
            // ob_Presense_Light
            // 
            this.ob_Presense_Light.ActionCount = 0;
            this.ob_Presense_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Presense_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Presense_Light.DesignTimeParent = null;
            this.ob_Presense_Light.ErrID = 0;
            this.ob_Presense_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Presense_Light.InAlarm = false;
            this.ob_Presense_Light.IOPort = "231B";
            this.ob_Presense_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Presense_Light.IsUseActionCount = false;
            this.ob_Presense_Light.Location = new System.Drawing.Point(3, 256);
            this.ob_Presense_Light.LockUI = false;
            this.ob_Presense_Light.Message = null;
            this.ob_Presense_Light.MsgID = 0;
            this.ob_Presense_Light.Name = "ob_Presense_Light";
            this.ob_Presense_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Presense_Light.RetryCount = 10;
            this.ob_Presense_Light.Running = false;
            this.ob_Presense_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Presense_Light.Text = "Presense";
            this.ob_Presense_Light.Value = false;
            // 
            // ob_Reserve_Light
            // 
            this.ob_Reserve_Light.ActionCount = 0;
            this.ob_Reserve_Light.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Reserve_Light.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Reserve_Light.DesignTimeParent = null;
            this.ob_Reserve_Light.ErrID = 0;
            this.ob_Reserve_Light.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Reserve_Light.InAlarm = false;
            this.ob_Reserve_Light.IOPort = "231E";
            this.ob_Reserve_Light.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Reserve_Light.IsUseActionCount = false;
            this.ob_Reserve_Light.Location = new System.Drawing.Point(3, 294);
            this.ob_Reserve_Light.LockUI = false;
            this.ob_Reserve_Light.Message = null;
            this.ob_Reserve_Light.MsgID = 0;
            this.ob_Reserve_Light.Name = "ob_Reserve_Light";
            this.ob_Reserve_Light.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Reserve_Light.RetryCount = 10;
            this.ob_Reserve_Light.Running = false;
            this.ob_Reserve_Light.Size = new System.Drawing.Size(211, 30);
            this.ob_Reserve_Light.Text = "Reserve";
            this.ob_Reserve_Light.Value = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label7);
            this.flowLayoutPanel7.Controls.Add(this.ib_Convex_Out);
            this.flowLayoutPanel7.Controls.Add(this.ib_Convex_Back);
            this.flowLayoutPanel7.Controls.Add(this.ob_Convex_Out);
            this.flowLayoutPanel7.Controls.Add(this.ob_Convex_Back);
            this.flowLayoutPanel7.Controls.Add(this.btn_Convex_SW);
            this.flowLayoutPanel7.Controls.Add(this.ib_ConvexDetect);
            this.flowLayoutPanel7.Controls.Add(this.ib_ArmDetect);
            this.flowLayoutPanel7.Controls.Add(this.ib_CoverDetect);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(229, 6);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(217, 344);
            this.flowLayoutPanel7.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Convex(10)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_Convex_Out
            // 
            this.ib_Convex_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Convex_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Convex_Out.DesignTimeParent = null;
            this.ib_Convex_Out.ErrID = 0;
            this.ib_Convex_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Convex_Out.InAlarm = false;
            this.ib_Convex_Out.IOPort = "0315";
            this.ib_Convex_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Convex_Out.Location = new System.Drawing.Point(3, 28);
            this.ib_Convex_Out.LockUI = false;
            this.ib_Convex_Out.Message = null;
            this.ib_Convex_Out.MsgID = 0;
            this.ib_Convex_Out.Name = "ib_Convex_Out";
            this.ib_Convex_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Convex_Out.Running = false;
            this.ib_Convex_Out.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Convex_Out.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Convex_Out.Simu_OutPort1 = null;
            this.ib_Convex_Out.Simu_OutPort2 = null;
            this.ib_Convex_Out.Simu_RandomNum = 2;
            this.ib_Convex_Out.Simu_RandomTime = 100;
            this.ib_Convex_Out.Simu_ReflectDelayTm = 100;
            this.ib_Convex_Out.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Convex_Out.Simu_Reverse = false;
            this.ib_Convex_Out.Size = new System.Drawing.Size(211, 30);
            this.ib_Convex_Out.Text = "On";
            // 
            // ib_Convex_Back
            // 
            this.ib_Convex_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Convex_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Convex_Back.DesignTimeParent = null;
            this.ib_Convex_Back.ErrID = 0;
            this.ib_Convex_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Convex_Back.InAlarm = false;
            this.ib_Convex_Back.IOPort = "0316";
            this.ib_Convex_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Convex_Back.Location = new System.Drawing.Point(3, 66);
            this.ib_Convex_Back.LockUI = false;
            this.ib_Convex_Back.Message = null;
            this.ib_Convex_Back.MsgID = 0;
            this.ib_Convex_Back.Name = "ib_Convex_Back";
            this.ib_Convex_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Convex_Back.Running = false;
            this.ib_Convex_Back.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Convex_Back.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Convex_Back.Simu_OutPort1 = null;
            this.ib_Convex_Back.Simu_OutPort2 = null;
            this.ib_Convex_Back.Simu_RandomNum = 2;
            this.ib_Convex_Back.Simu_RandomTime = 100;
            this.ib_Convex_Back.Simu_ReflectDelayTm = 100;
            this.ib_Convex_Back.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Convex_Back.Simu_Reverse = false;
            this.ib_Convex_Back.Size = new System.Drawing.Size(211, 30);
            this.ib_Convex_Back.Text = "Pull";
            // 
            // ob_Convex_Out
            // 
            this.ob_Convex_Out.ActionCount = 0;
            this.ob_Convex_Out.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Convex_Out.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Convex_Out.DesignTimeParent = null;
            this.ob_Convex_Out.ErrID = 0;
            this.ob_Convex_Out.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Convex_Out.InAlarm = false;
            this.ob_Convex_Out.IOPort = "2308";
            this.ob_Convex_Out.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Convex_Out.IsUseActionCount = false;
            this.ob_Convex_Out.Location = new System.Drawing.Point(3, 104);
            this.ob_Convex_Out.LockUI = false;
            this.ob_Convex_Out.Message = null;
            this.ob_Convex_Out.MsgID = 0;
            this.ob_Convex_Out.Name = "ob_Convex_Out";
            this.ob_Convex_Out.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Convex_Out.RetryCount = 10;
            this.ob_Convex_Out.Running = false;
            this.ob_Convex_Out.Size = new System.Drawing.Size(211, 30);
            this.ob_Convex_Out.Text = "Push";
            this.ob_Convex_Out.Value = false;
            this.ob_Convex_Out.IsSafeToAction += new ProVLib.OutBit.SafeActionEventHandler(this.ob_Convex_Out_IsSafeToAction);
            // 
            // ob_Convex_Back
            // 
            this.ob_Convex_Back.ActionCount = 0;
            this.ob_Convex_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Convex_Back.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Convex_Back.DesignTimeParent = null;
            this.ob_Convex_Back.ErrID = 0;
            this.ob_Convex_Back.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Convex_Back.InAlarm = false;
            this.ob_Convex_Back.IOPort = "2309";
            this.ob_Convex_Back.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Convex_Back.IsUseActionCount = false;
            this.ob_Convex_Back.Location = new System.Drawing.Point(3, 142);
            this.ob_Convex_Back.LockUI = false;
            this.ob_Convex_Back.Message = null;
            this.ob_Convex_Back.MsgID = 0;
            this.ob_Convex_Back.Name = "ob_Convex_Back";
            this.ob_Convex_Back.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Convex_Back.RetryCount = 10;
            this.ob_Convex_Back.Running = false;
            this.ob_Convex_Back.Size = new System.Drawing.Size(211, 30);
            this.ob_Convex_Back.Text = "Pull";
            this.ob_Convex_Back.Value = false;
            // 
            // btn_Convex_SW
            // 
            this.btn_Convex_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_Convex_SW.Location = new System.Drawing.Point(3, 179);
            this.btn_Convex_SW.Name = "btn_Convex_SW";
            this.btn_Convex_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_Convex_SW.TabIndex = 39;
            this.btn_Convex_SW.Tag = "Convex";
            this.btn_Convex_SW.Text = "Switch";
            this.btn_Convex_SW.UseVisualStyleBackColor = false;
            this.btn_Convex_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // ib_ConvexDetect
            // 
            this.ib_ConvexDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ConvexDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ConvexDetect.DesignTimeParent = null;
            this.ib_ConvexDetect.ErrID = 0;
            this.ib_ConvexDetect.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ConvexDetect.InAlarm = false;
            this.ib_ConvexDetect.IOPort = "0317";
            this.ib_ConvexDetect.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ConvexDetect.Location = new System.Drawing.Point(3, 221);
            this.ib_ConvexDetect.LockUI = false;
            this.ib_ConvexDetect.Message = null;
            this.ib_ConvexDetect.MsgID = 0;
            this.ib_ConvexDetect.Name = "ib_ConvexDetect";
            this.ib_ConvexDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ConvexDetect.Running = false;
            this.ib_ConvexDetect.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ConvexDetect.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ConvexDetect.Simu_OutPort1 = null;
            this.ib_ConvexDetect.Simu_OutPort2 = null;
            this.ib_ConvexDetect.Simu_RandomNum = 2;
            this.ib_ConvexDetect.Simu_RandomTime = 100;
            this.ib_ConvexDetect.Simu_ReflectDelayTm = 100;
            this.ib_ConvexDetect.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ConvexDetect.Simu_Reverse = false;
            this.ib_ConvexDetect.Size = new System.Drawing.Size(211, 30);
            this.ib_ConvexDetect.Text = "Convex Detect(11)";
            // 
            // ib_ArmDetect
            // 
            this.ib_ArmDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_ArmDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_ArmDetect.DesignTimeParent = null;
            this.ib_ArmDetect.ErrID = 0;
            this.ib_ArmDetect.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_ArmDetect.InAlarm = false;
            this.ib_ArmDetect.IOPort = "";
            this.ib_ArmDetect.IOType = ProVLib.EIOType.IOHSL;
            this.ib_ArmDetect.Location = new System.Drawing.Point(3, 259);
            this.ib_ArmDetect.LockUI = false;
            this.ib_ArmDetect.Message = null;
            this.ib_ArmDetect.MsgID = 0;
            this.ib_ArmDetect.Name = "ib_ArmDetect";
            this.ib_ArmDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_ArmDetect.Running = false;
            this.ib_ArmDetect.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_ArmDetect.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_ArmDetect.Simu_OutPort1 = null;
            this.ib_ArmDetect.Simu_OutPort2 = null;
            this.ib_ArmDetect.Simu_RandomNum = 2;
            this.ib_ArmDetect.Simu_RandomTime = 100;
            this.ib_ArmDetect.Simu_ReflectDelayTm = 100;
            this.ib_ArmDetect.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_ArmDetect.Simu_Reverse = false;
            this.ib_ArmDetect.Size = new System.Drawing.Size(211, 30);
            this.ib_ArmDetect.Text = "Arm Detect(3)";
            // 
            // ib_CoverDetect
            // 
            this.ib_CoverDetect.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_CoverDetect.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_CoverDetect.DesignTimeParent = null;
            this.ib_CoverDetect.ErrID = 0;
            this.ib_CoverDetect.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_CoverDetect.InAlarm = false;
            this.ib_CoverDetect.IOPort = "030E";
            this.ib_CoverDetect.IOType = ProVLib.EIOType.IOHSL;
            this.ib_CoverDetect.Location = new System.Drawing.Point(3, 297);
            this.ib_CoverDetect.LockUI = false;
            this.ib_CoverDetect.Message = null;
            this.ib_CoverDetect.MsgID = 0;
            this.ib_CoverDetect.Name = "ib_CoverDetect";
            this.ib_CoverDetect.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_CoverDetect.Running = false;
            this.ib_CoverDetect.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_CoverDetect.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_CoverDetect.Simu_OutPort1 = null;
            this.ib_CoverDetect.Simu_OutPort2 = null;
            this.ib_CoverDetect.Simu_RandomNum = 2;
            this.ib_CoverDetect.Simu_RandomTime = 100;
            this.ib_CoverDetect.Simu_ReflectDelayTm = 100;
            this.ib_CoverDetect.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_CoverDetect.Simu_Reverse = false;
            this.ib_CoverDetect.Size = new System.Drawing.Size(211, 30);
            this.ib_CoverDetect.Text = "Cover Detect(13)";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.ib_Latch_Lock);
            this.flowLayoutPanel6.Controls.Add(this.ib_Latch_Unlock);
            this.flowLayoutPanel6.Controls.Add(this.ob_Latch_Lock);
            this.flowLayoutPanel6.Controls.Add(this.ob_Latch_Unlock);
            this.flowLayoutPanel6.Controls.Add(this.btn_Latch_SW);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(217, 251);
            this.flowLayoutPanel6.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Latch Key(12)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ib_Latch_Lock
            // 
            this.ib_Latch_Lock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Latch_Lock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Latch_Lock.DesignTimeParent = null;
            this.ib_Latch_Lock.ErrID = 0;
            this.ib_Latch_Lock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Latch_Lock.InAlarm = false;
            this.ib_Latch_Lock.IOPort = "";
            this.ib_Latch_Lock.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Latch_Lock.Location = new System.Drawing.Point(3, 28);
            this.ib_Latch_Lock.LockUI = false;
            this.ib_Latch_Lock.Message = null;
            this.ib_Latch_Lock.MsgID = 0;
            this.ib_Latch_Lock.Name = "ib_Latch_Lock";
            this.ib_Latch_Lock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Latch_Lock.Running = false;
            this.ib_Latch_Lock.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Latch_Lock.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Latch_Lock.Simu_OutPort1 = null;
            this.ib_Latch_Lock.Simu_OutPort2 = null;
            this.ib_Latch_Lock.Simu_RandomNum = 2;
            this.ib_Latch_Lock.Simu_RandomTime = 100;
            this.ib_Latch_Lock.Simu_ReflectDelayTm = 100;
            this.ib_Latch_Lock.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Latch_Lock.Simu_Reverse = false;
            this.ib_Latch_Lock.Size = new System.Drawing.Size(211, 30);
            this.ib_Latch_Lock.Text = "On";
            // 
            // ib_Latch_Unlock
            // 
            this.ib_Latch_Unlock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ib_Latch_Unlock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ib_Latch_Unlock.DesignTimeParent = null;
            this.ib_Latch_Unlock.ErrID = 0;
            this.ib_Latch_Unlock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ib_Latch_Unlock.InAlarm = false;
            this.ib_Latch_Unlock.IOPort = "";
            this.ib_Latch_Unlock.IOType = ProVLib.EIOType.IOHSL;
            this.ib_Latch_Unlock.Location = new System.Drawing.Point(3, 66);
            this.ib_Latch_Unlock.LockUI = false;
            this.ib_Latch_Unlock.Message = null;
            this.ib_Latch_Unlock.MsgID = 0;
            this.ib_Latch_Unlock.Name = "ib_Latch_Unlock";
            this.ib_Latch_Unlock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ib_Latch_Unlock.Running = false;
            this.ib_Latch_Unlock.Simu_Mode = ProVLib.SIMULATION_MODE.S_RANDOM;
            this.ib_Latch_Unlock.Simu_OnOffCondition = ProVLib.SIMULATION_ONOFFCONDITION.SRR_KEEP;
            this.ib_Latch_Unlock.Simu_OutPort1 = null;
            this.ib_Latch_Unlock.Simu_OutPort2 = null;
            this.ib_Latch_Unlock.Simu_RandomNum = 2;
            this.ib_Latch_Unlock.Simu_RandomTime = 100;
            this.ib_Latch_Unlock.Simu_ReflectDelayTm = 100;
            this.ib_Latch_Unlock.Simu_ReflectRule = ProVLib.SIMULATION_REFLECTRULE.SRR_ON_OFF;
            this.ib_Latch_Unlock.Simu_Reverse = false;
            this.ib_Latch_Unlock.Size = new System.Drawing.Size(211, 30);
            this.ib_Latch_Unlock.Text = "Off";
            // 
            // ob_Latch_Lock
            // 
            this.ob_Latch_Lock.ActionCount = 0;
            this.ob_Latch_Lock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Latch_Lock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Latch_Lock.DesignTimeParent = null;
            this.ob_Latch_Lock.ErrID = 0;
            this.ob_Latch_Lock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Latch_Lock.InAlarm = false;
            this.ob_Latch_Lock.IOPort = "230E";
            this.ob_Latch_Lock.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Latch_Lock.IsUseActionCount = false;
            this.ob_Latch_Lock.Location = new System.Drawing.Point(3, 104);
            this.ob_Latch_Lock.LockUI = false;
            this.ob_Latch_Lock.Message = null;
            this.ob_Latch_Lock.MsgID = 0;
            this.ob_Latch_Lock.Name = "ob_Latch_Lock";
            this.ob_Latch_Lock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Latch_Lock.RetryCount = 10;
            this.ob_Latch_Lock.Running = false;
            this.ob_Latch_Lock.Size = new System.Drawing.Size(211, 30);
            this.ob_Latch_Lock.Text = "Foup Lock";
            this.ob_Latch_Lock.Value = false;
            // 
            // ob_Latch_Unlock
            // 
            this.ob_Latch_Unlock.ActionCount = 0;
            this.ob_Latch_Unlock.BackColor = System.Drawing.Color.RoyalBlue;
            this.ob_Latch_Unlock.CaptionFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ob_Latch_Unlock.DesignTimeParent = null;
            this.ob_Latch_Unlock.ErrID = 0;
            this.ob_Latch_Unlock.HSLSpeed = ProVLib.EHSLSPEED.HSL6M;
            this.ob_Latch_Unlock.InAlarm = false;
            this.ob_Latch_Unlock.IOPort = "230F";
            this.ob_Latch_Unlock.IOType = ProVLib.EIOType.IOHSL;
            this.ob_Latch_Unlock.IsUseActionCount = false;
            this.ob_Latch_Unlock.Location = new System.Drawing.Point(3, 142);
            this.ob_Latch_Unlock.LockUI = false;
            this.ob_Latch_Unlock.Message = null;
            this.ob_Latch_Unlock.MsgID = 0;
            this.ob_Latch_Unlock.Name = "ob_Latch_Unlock";
            this.ob_Latch_Unlock.ObjType = ProVLib.EObjType.VOID_TYPE;
            this.ob_Latch_Unlock.RetryCount = 10;
            this.ob_Latch_Unlock.Running = false;
            this.ob_Latch_Unlock.Size = new System.Drawing.Size(211, 30);
            this.ob_Latch_Unlock.Text = "Foup Unlock";
            this.ob_Latch_Unlock.Value = false;
            // 
            // btn_Latch_SW
            // 
            this.btn_Latch_SW.BackColor = System.Drawing.Color.LightGray;
            this.btn_Latch_SW.Location = new System.Drawing.Point(3, 179);
            this.btn_Latch_SW.Name = "btn_Latch_SW";
            this.btn_Latch_SW.Size = new System.Drawing.Size(211, 35);
            this.btn_Latch_SW.TabIndex = 39;
            this.btn_Latch_SW.Tag = "Latch";
            this.btn_Latch_SW.Text = "Switch";
            this.btn_Latch_SW.UseVisualStyleBackColor = false;
            this.btn_Latch_SW.Click += new System.EventHandler(this.Cylider_Switch_Click);
            // 
            // dPosEdit13
            // 
            this.dPosEdit13.AutoFocus = false;
            this.dPosEdit13.Caption = "Wafer First Pos";
            this.dPosEdit13.CaptionColor = System.Drawing.Color.Black;
            this.dPosEdit13.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit13.DataName = "WaferFirstTheoreticalPos";
            this.dPosEdit13.DataSource = this.SetDS;
            this.dPosEdit13.DefaultValue = null;
            this.dPosEdit13.EditColor = System.Drawing.Color.Black;
            this.dPosEdit13.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit13.EditWidth = 100;
            this.dPosEdit13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dPosEdit13.IsModified = false;
            this.dPosEdit13.Location = new System.Drawing.Point(3, 181);
            this.dPosEdit13.Margin = new System.Windows.Forms.Padding(0);
            this.dPosEdit13.MaxValue = 9999999D;
            this.dPosEdit13.MinValue = -9999999D;
            this.dPosEdit13.ModifiedColor = System.Drawing.Color.Aqua;
            this.dPosEdit13.MotorP = null;
            this.dPosEdit13.Name = "dPosEdit13";
            this.dPosEdit13.NoChangeInAuto = false;
            this.dPosEdit13.PosValue = "";
            this.dPosEdit13.Size = new System.Drawing.Size(300, 30);
            this.dPosEdit13.StepValue = 0D;
            this.dPosEdit13.TabIndex = 9;
            this.dPosEdit13.Unit = "um";
            this.dPosEdit13.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit13.UnitWidth = 40;
            this.dPosEdit13.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dPosEdit4
            // 
            this.dPosEdit4.AutoFocus = false;
            this.dPosEdit4.Caption = "Wait Pos";
            this.dPosEdit4.CaptionColor = System.Drawing.Color.Black;
            this.dPosEdit4.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit4.DataName = "MotorZ_WaitPos";
            this.dPosEdit4.DataSource = this.SetDS;
            this.dPosEdit4.DefaultValue = null;
            this.dPosEdit4.EditColor = System.Drawing.Color.Black;
            this.dPosEdit4.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit4.EditWidth = 100;
            this.dPosEdit4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dPosEdit4.IsModified = false;
            this.dPosEdit4.Location = new System.Drawing.Point(3, 151);
            this.dPosEdit4.Margin = new System.Windows.Forms.Padding(0);
            this.dPosEdit4.MaxValue = 9999999D;
            this.dPosEdit4.MinValue = -9999999D;
            this.dPosEdit4.ModifiedColor = System.Drawing.Color.Aqua;
            this.dPosEdit4.MotorP = null;
            this.dPosEdit4.Name = "dPosEdit4";
            this.dPosEdit4.NoChangeInAuto = false;
            this.dPosEdit4.PosValue = "";
            this.dPosEdit4.Size = new System.Drawing.Size(300, 30);
            this.dPosEdit4.StepValue = 0D;
            this.dPosEdit4.TabIndex = 8;
            this.dPosEdit4.Unit = "um";
            this.dPosEdit4.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit4.UnitWidth = 40;
            this.dPosEdit4.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dPosEdit3
            // 
            this.dPosEdit3.AutoFocus = false;
            this.dPosEdit3.Caption = "Scan Second Pos";
            this.dPosEdit3.CaptionColor = System.Drawing.Color.Black;
            this.dPosEdit3.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit3.DataName = "ScanSecondPos";
            this.dPosEdit3.DataSource = this.SetDS;
            this.dPosEdit3.DefaultValue = null;
            this.dPosEdit3.EditColor = System.Drawing.Color.Black;
            this.dPosEdit3.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit3.EditWidth = 100;
            this.dPosEdit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dPosEdit3.IsModified = false;
            this.dPosEdit3.Location = new System.Drawing.Point(3, 121);
            this.dPosEdit3.Margin = new System.Windows.Forms.Padding(0);
            this.dPosEdit3.MaxValue = 9999999D;
            this.dPosEdit3.MinValue = -9999999D;
            this.dPosEdit3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dPosEdit3.MotorP = null;
            this.dPosEdit3.Name = "dPosEdit3";
            this.dPosEdit3.NoChangeInAuto = false;
            this.dPosEdit3.PosValue = "";
            this.dPosEdit3.Size = new System.Drawing.Size(300, 30);
            this.dPosEdit3.StepValue = 0D;
            this.dPosEdit3.TabIndex = 7;
            this.dPosEdit3.Unit = "um";
            this.dPosEdit3.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit3.UnitWidth = 40;
            this.dPosEdit3.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dPosEdit1
            // 
            this.dPosEdit1.AutoFocus = false;
            this.dPosEdit1.Caption = "Open Pos";
            this.dPosEdit1.CaptionColor = System.Drawing.Color.Black;
            this.dPosEdit1.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit1.DataName = "OpenPos";
            this.dPosEdit1.DataSource = this.SetDS;
            this.dPosEdit1.DefaultValue = null;
            this.dPosEdit1.EditColor = System.Drawing.Color.Black;
            this.dPosEdit1.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit1.EditWidth = 100;
            this.dPosEdit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dPosEdit1.IsModified = false;
            this.dPosEdit1.Location = new System.Drawing.Point(3, 61);
            this.dPosEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.dPosEdit1.MaxValue = 9999999D;
            this.dPosEdit1.MinValue = -9999999D;
            this.dPosEdit1.ModifiedColor = System.Drawing.Color.Aqua;
            this.dPosEdit1.MotorP = null;
            this.dPosEdit1.Name = "dPosEdit1";
            this.dPosEdit1.NoChangeInAuto = false;
            this.dPosEdit1.PosValue = "";
            this.dPosEdit1.Size = new System.Drawing.Size(300, 30);
            this.dPosEdit1.StepValue = 0D;
            this.dPosEdit1.TabIndex = 5;
            this.dPosEdit1.Unit = "um";
            this.dPosEdit1.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit1.UnitWidth = 40;
            this.dPosEdit1.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dPosEdit2
            // 
            this.dPosEdit2.AutoFocus = false;
            this.dPosEdit2.Caption = "Scan Frist Pos";
            this.dPosEdit2.CaptionColor = System.Drawing.Color.Black;
            this.dPosEdit2.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit2.DataName = "ScanFristPos";
            this.dPosEdit2.DataSource = this.SetDS;
            this.dPosEdit2.DefaultValue = null;
            this.dPosEdit2.EditColor = System.Drawing.Color.Black;
            this.dPosEdit2.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit2.EditWidth = 100;
            this.dPosEdit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dPosEdit2.IsModified = false;
            this.dPosEdit2.Location = new System.Drawing.Point(3, 91);
            this.dPosEdit2.Margin = new System.Windows.Forms.Padding(0);
            this.dPosEdit2.MaxValue = 9999999D;
            this.dPosEdit2.MinValue = -9999999D;
            this.dPosEdit2.ModifiedColor = System.Drawing.Color.Aqua;
            this.dPosEdit2.MotorP = null;
            this.dPosEdit2.Name = "dPosEdit2";
            this.dPosEdit2.NoChangeInAuto = false;
            this.dPosEdit2.PosValue = "";
            this.dPosEdit2.Size = new System.Drawing.Size(300, 30);
            this.dPosEdit2.StepValue = 0D;
            this.dPosEdit2.TabIndex = 6;
            this.dPosEdit2.Unit = "um";
            this.dPosEdit2.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dPosEdit2.UnitWidth = 40;
            this.dPosEdit2.ValueType = KCSDK.ValueDataType.Int;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dFieldEdit22);
            this.groupBox7.Controls.Add(this.dFieldEdit10);
            this.groupBox7.Controls.Add(this.dFieldEdit11);
            this.groupBox7.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox7.Location = new System.Drawing.Point(6, 64);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(481, 141);
            this.groupBox7.TabIndex = 52;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Motor Z Speed";
            // 
            // dFieldEdit22
            // 
            this.dFieldEdit22.AutoFocus = false;
            this.dFieldEdit22.Caption = "Scan Speed";
            this.dFieldEdit22.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit22.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit22.DataName = "MT_DOOR_Z_SCAN_RATE";
            this.dFieldEdit22.DataSource = this.SetDS;
            this.dFieldEdit22.DefaultValue = null;
            this.dFieldEdit22.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit22.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit22.EditWidth = 150;
            this.dFieldEdit22.FieldValue = "";
            this.dFieldEdit22.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit22.IsModified = false;
            this.dFieldEdit22.Location = new System.Drawing.Point(3, 83);
            this.dFieldEdit22.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit22.MaxValue = 100D;
            this.dFieldEdit22.MinValue = 1D;
            this.dFieldEdit22.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit22.Name = "dFieldEdit22";
            this.dFieldEdit22.NoChangeInAuto = false;
            this.dFieldEdit22.Size = new System.Drawing.Size(389, 30);
            this.dFieldEdit22.StepValue = 0D;
            this.dFieldEdit22.TabIndex = 4;
            this.dFieldEdit22.Unit = "%";
            this.dFieldEdit22.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit22.UnitWidth = 40;
            this.dFieldEdit22.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit10
            // 
            this.dFieldEdit10.AutoFocus = false;
            this.dFieldEdit10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dFieldEdit10.Caption = "Door Z Acc/Dec =";
            this.dFieldEdit10.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit10.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit10.DataName = "MT_DOOR_Z_ACC_MULTIPLE";
            this.dFieldEdit10.DataSource = this.SetDS;
            this.dFieldEdit10.DefaultValue = null;
            this.dFieldEdit10.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit10.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit10.EditWidth = 100;
            this.dFieldEdit10.FieldValue = "";
            this.dFieldEdit10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit10.IsModified = false;
            this.dFieldEdit10.Location = new System.Drawing.Point(3, 54);
            this.dFieldEdit10.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit10.MaxValue = 20D;
            this.dFieldEdit10.MinValue = 1D;
            this.dFieldEdit10.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit10.Name = "dFieldEdit10";
            this.dFieldEdit10.NoChangeInAuto = false;
            this.dFieldEdit10.Size = new System.Drawing.Size(450, 29);
            this.dFieldEdit10.StepValue = 0D;
            this.dFieldEdit10.TabIndex = 3;
            this.dFieldEdit10.Unit = "times of speed";
            this.dFieldEdit10.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit10.UnitWidth = 150;
            this.dFieldEdit10.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dFieldEdit11
            // 
            this.dFieldEdit11.AutoFocus = false;
            this.dFieldEdit11.Caption = "Door Z Speed =";
            this.dFieldEdit11.CaptionColor = System.Drawing.Color.Black;
            this.dFieldEdit11.CaptionFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit11.DataName = "MT_DOOR_Z_SPEED";
            this.dFieldEdit11.DataSource = this.SetDS;
            this.dFieldEdit11.DefaultValue = null;
            this.dFieldEdit11.EditColor = System.Drawing.Color.Black;
            this.dFieldEdit11.EditFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit11.EditWidth = 100;
            this.dFieldEdit11.FieldValue = "";
            this.dFieldEdit11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dFieldEdit11.IsModified = false;
            this.dFieldEdit11.Location = new System.Drawing.Point(3, 25);
            this.dFieldEdit11.Margin = new System.Windows.Forms.Padding(0);
            this.dFieldEdit11.MaxValue = 2000000D;
            this.dFieldEdit11.MinValue = 10000D;
            this.dFieldEdit11.ModifiedColor = System.Drawing.Color.Aqua;
            this.dFieldEdit11.Name = "dFieldEdit11";
            this.dFieldEdit11.NoChangeInAuto = false;
            this.dFieldEdit11.Size = new System.Drawing.Size(359, 29);
            this.dFieldEdit11.StepValue = 0D;
            this.dFieldEdit11.TabIndex = 2;
            this.dFieldEdit11.Unit = "um/s";
            this.dFieldEdit11.UnitFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.dFieldEdit11.UnitWidth = 60;
            this.dFieldEdit11.ValueType = KCSDK.ValueDataType.Int;
            // 
            // dRadioGroupBox3
            // 
            this.dRadioGroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.dRadioGroupBox3.ColCount = 1;
            this.dRadioGroupBox3.DataName = "Foup_WaferType";
            this.dRadioGroupBox3.DataSource = this.SetDS;
            this.dRadioGroupBox3.DefaultValue = 0;
            this.dRadioGroupBox3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.dRadioGroupBox3.IsModified = false;
            this.dRadioGroupBox3.ItemFont = new System.Drawing.Font("微軟正黑體", 12F);
            this.dRadioGroupBox3.ItemHeight = 30;
            this.dRadioGroupBox3.ItemLeft = 10;
            this.dRadioGroupBox3.ItemTop = 30;
            this.dRadioGroupBox3.ItemWidth = 100;
            this.dRadioGroupBox3.Location = new System.Drawing.Point(493, 64);
            this.dRadioGroupBox3.ModifiedColor = System.Drawing.Color.Aqua;
            this.dRadioGroupBox3.Name = "dRadioGroupBox3";
            this.dRadioGroupBox3.NoChangeInAuto = false;
            this.dRadioGroupBox3.RadioItems = ((System.Collections.Generic.List<string>)(resources.GetObject("dRadioGroupBox3.RadioItems")));
            this.dRadioGroupBox3.Size = new System.Drawing.Size(196, 91);
            this.dRadioGroupBox3.TabIndex = 62;
            this.dRadioGroupBox3.TabStop = false;
            this.dRadioGroupBox3.Text = "Wafer Type";
            // 
            // LPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Name = "LPA";
            this.Text = "FLP";
            this.tabMain.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpPosition.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpFlow.ResumeLayout(false);
            this.tpSuperSetting.ResumeLayout(false);
            this.TabFlow.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpCheck.ResumeLayout(false);
            this.tpLock_Unlock.ResumeLayout(false);
            this.tpOpen_Close.ResumeLayout(false);
            this.tpInputID.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpLock_Unlock;
        private System.Windows.Forms.TabPage tpOpen_Close;
        private ProVLib.FlowChart FC_Auto_Unlock_Next_1;
        private ProVLib.FlowChart FC_Auto_Unlock_WaitCmd;
        private ProVLib.FlowChart FC_Auto_Unlock_ClampZUp;
        private ProVLib.FlowChart FC_Auto_Unlock_ClampYRelease;
        private ProVLib.FlowChart FC_Auto_Unlock_ClampZDown;
        private ProVLib.FlowChart FC_Auto_Unlock_Done;
        private ProVLib.FlowChart FC_Auto_Unlock_Next_2;
        private ProVLib.FlowChart FC_Auto_Lock_Next_1;
        private ProVLib.FlowChart FC_Auto_Lock_WaitCmd;
        private ProVLib.FlowChart FC_Auto_Lock_ClampZUp;
        private ProVLib.FlowChart FC_Auto_Lock_ClampYClamp;
        private ProVLib.FlowChart FC_Auto_Lock_ClampZDown;
        private ProVLib.FlowChart FC_Auto_Lock_Down;
        private ProVLib.FlowChart FC_Auto_Lock_Next_2;
        private ProVLib.FlowChart FC_UNLOCK_START;
        private ProVLib.FlowChart FC_LOCK_START;
        private ProVLib.FlowChart FC_Auto_Open_FristConvexDetect;
        private ProVLib.FlowChart FC_Auto_Open_DoorZDown;
        private ProVLib.FlowChart FC_Auto_Open_ConvexCyOn;
        private ProVLib.FlowChart FC_Auto_Open_2ndConvexDetect;
        private ProVLib.FlowChart FC_Auto_Open_ConvexCyOff;
        private ProVLib.FlowChart FC_Auto_Open_Done;
        private ProVLib.FlowChart FC_Auto_Open_Next_2;
        private ProVLib.FlowChart FC_Auto_Open_Next_1;
        private ProVLib.FlowChart FC_Auto_Open_WaitCmd;
        private ProVLib.FlowChart FC_Auto_Open_CheckType;
        private ProVLib.FlowChart FC_Auto_Open_CheckNoCover;
        private ProVLib.FlowChart FC_Auto_Open_LatchKeyOff;
        private ProVLib.FlowChart FC_Auto_Open_TableForward;
        private ProVLib.FlowChart FC_Auto_Open_VaccumOn;
        private ProVLib.FlowChart FC_Auto_Open_CoverDetect;
        private ProVLib.FlowChart FC_Auto_Open_LatchKeyOn;
        private ProVLib.FlowChart FC_Auto_Open_DoorYPush;
        private ProVLib.FlowChart FC_OPEN_START;
        private ProVLib.FlowChart FC_Auto_Close_CheckPlacement;
        private ProVLib.FlowChart FC_Auto_Close_DoorZUp;
        private ProVLib.FlowChart FC_Auto_Close_DoorYPull;
        private ProVLib.FlowChart FC_Auto_Close_2ndVaccumOff;
        private ProVLib.FlowChart FC_Auto_Close_LatchKeyOff;
        private ProVLib.FlowChart FC_Auto_Close_TablePull;
        private ProVLib.FlowChart FC_Auto_Close_Done;
        private ProVLib.FlowChart FC_Auto_Close_Next_2;
        private ProVLib.FlowChart FC_Auto_Close_Next_1;
        private ProVLib.FlowChart FC_Auto_Close_WaitCmd;
        private ProVLib.FlowChart FC_Auto_Close_ConvexCyOff;
        private ProVLib.FlowChart FC_Auto_Close_DoorYPush;
        private ProVLib.FlowChart FC_Auto_Close_VaccumOn;
        private ProVLib.FlowChart FC_Auto_Close_CoverDetect;
        private ProVLib.FlowChart FC_Auto_Close_CheckHasFoup;
        private ProVLib.FlowChart FC_Auto_Close_VaccumOff;
        private ProVLib.FlowChart FC_CLOSE_START;
        private ProVLib.FlowChart FC_Home_LockDone;
        private ProVLib.FlowChart FC_Home_DoClose;
        private ProVLib.FlowChart FC_Home_CloseDone;
        private ProVLib.FlowChart FC_Home_DoUnlock;
        private ProVLib.FlowChart FC_Home_UnlockDone;
        private ProVLib.FlowChart FC_Home_Done;
        private ProVLib.FlowChart FC_Home_DoLock;
        private ProVLib.FlowChart FC_Home_CheckHasCassette;
        private ProVLib.FlowChart FC_Home_WaitCmd;
        private ProVLib.FlowChart FC_HOME_START;
        private System.Windows.Forms.TabPage tpInputID;
        private ProVLib.FlowChart FC_InputID_Done;
        private ProVLib.FlowChart FC_InputID_WaitCmd;
        private ProVLib.FlowChart FC_INPUTID_START;
        private ProVLib.FlowChart FC_InputID_Next_1;
        private ProVLib.FlowChart FC_InputID_Next_2;
        private ProVLib.FlowChart FC_InputID_DoInputID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private KCSDK.DFieldEdit dFieldEdit31;
        private KCSDK.DFieldEdit dFieldEdit1;
        private KCSDK.DFieldEdit dFieldEdit3;
        private KCSDK.DFieldEdit dFieldEdit2;
        private KCSDK.DFieldEdit dFieldEdit4;
        private KCSDK.DFieldEdit dFieldEdit5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private ProVLib.InBit ib_ClampY_Clamp;
        private ProVLib.InBit ib_ClampY_Release;
        private ProVLib.OutBit ob_ClampY_Clamp;
        private ProVLib.OutBit ob_ClampY_Release;
        private System.Windows.Forms.Button btn_ClampY_SW;
        private System.Windows.Forms.Label label1;
        private ProVLib.InBit ib_ClampZ_Up;
        private ProVLib.InBit ib_ClampZ_Down;
        private ProVLib.OutBit ob_ClampZ_Up;
        private ProVLib.OutBit ob_ClampZ_Down;
        private System.Windows.Forms.Button btn_ClampZ_SW;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private ProVLib.InBit ib_PlaceDetect_Left;
        private ProVLib.InBit ib_PlaceDetect_Right;
        private ProVLib.InBit ib_PlaceDetect_Down;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label13;
        private ProVLib.InBit ib_Inch8CstClamp_On;
        private ProVLib.InBit ib_Inch8CstClamp_Off;
        private ProVLib.OutBit ob_Inch8CstClamp_Lock;
        private ProVLib.OutBit ob_Inch8CstClamp_Unlock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label8;
        private ProVLib.InBit ib_8Inch;
        private ProVLib.InBit ib_8Inch_2;
        private ProVLib.InBit ib_Cassette;
        private ProVLib.InBit ib_Foup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label label11;
        private ProVLib.InBit ib_ManualButton;
        private ProVLib.OutBit ob_ManualButton_Light;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label9;
        private ProVLib.InBit ib_VaccumDetect;
        private ProVLib.OutBit ob_Vaccum;
        private ProVLib.OutBit ob_Destory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private ProVLib.InBit ib_DoorY_Out;
        private ProVLib.InBit ib_DoorY_Back;
        private ProVLib.OutBit ob_DoorY_Out;
        private ProVLib.OutBit ob_DoorY_Back;
        private System.Windows.Forms.Button btn_DoorY_SW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label label12;
        private ProVLib.OutBit ob_Alarm_Light;
        private ProVLib.OutBit ob_Load_Light;
        private ProVLib.OutBit ob_Unload_Light;
        private ProVLib.OutBit ob_Placement_Light;
        private ProVLib.OutBit ob_Manual_Light;
        private ProVLib.OutBit ob_Auto_Light;
        private ProVLib.OutBit ob_Presense_Light;
        private ProVLib.OutBit ob_Reserve_Light;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private ProVLib.InBit ib_Convex_Out;
        private ProVLib.InBit ib_Convex_Back;
        private ProVLib.OutBit ob_Convex_Out;
        private ProVLib.OutBit ob_Convex_Back;
        private System.Windows.Forms.Button btn_Convex_SW;
        private ProVLib.InBit ib_ConvexDetect;
        private ProVLib.InBit ib_ArmDetect;
        private ProVLib.InBit ib_CoverDetect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private ProVLib.InBit ib_Latch_Lock;
        private ProVLib.InBit ib_Latch_Unlock;
        private ProVLib.OutBit ob_Latch_Lock;
        private ProVLib.OutBit ob_Latch_Unlock;
        private System.Windows.Forms.Button btn_Latch_SW;
        private ProVLib.FlowChart FC_Auto_Close_DestoryOff;
        private ProVLib.FlowChart FC_Auto_Close_DestoryOn;
        private ProVLib.FlowChart flowChart3;
        private ProVLib.FlowChart flowChart1;
        private ProVLib.FlowChart flowChart2;
        private System.Windows.Forms.Button button2;
        private ProVLib.FlowChart FC_Convex_Cylinder_Done;
        private ProVLib.FlowChart FC_Convex_Cylinder_WaitCmd;
        private ProVLib.FlowChart FC_Convex_Cylinder_START;
        private ProVLib.FlowChart FC_Convex_Cylinder_Next;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label16;
        private ProVLib.InBit ib_InfoPad_LeftTop;
        private ProVLib.InBit ib_InfoPad_LeftDown;
        private ProVLib.InBit ib_InfoPad_RightDown;
        private ProVLib.InBit ib_InfoPad_RightTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private ProVLib.InBit ib_Table_Out;
        private ProVLib.InBit ib_Table_Back;
        private ProVLib.OutBit ob_Table_Out;
        private ProVLib.OutBit ob_Table_Back;
        private System.Windows.Forms.Button btn_Table_SW;
        private ProVLib.Motor MT_DoorZ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.Label label15;
        private ProVLib.InBit IB_MappingCY_On;
        private ProVLib.InBit IB_MappingCY_Off;
        private ProVLib.OutBit OB_MappingCY_Push;
        private ProVLib.OutBit OB_MappingCY_Pull;
        private System.Windows.Forms.Button button4;
        private ProVLib.InBit IB_Wafer_Mapping_Sensor;
        private KCSDK.DPosEdit dPosEdit13;
        private KCSDK.DPosEdit dPosEdit4;
        private KCSDK.DPosEdit dPosEdit3;
        private KCSDK.DPosEdit dPosEdit1;
        private KCSDK.DPosEdit dPosEdit2;
        private System.Windows.Forms.GroupBox groupBox7;
        private KCSDK.DFieldEdit dFieldEdit22;
        private KCSDK.DFieldEdit dFieldEdit10;
        private KCSDK.DFieldEdit dFieldEdit11;
        private ProVLib.FlowChart FC_Auto_Open_MoveZtoWaitingPos;
        private ProVLib.FlowChart FC_Auto_Open_MappingCylinderOff;
        private ProVLib.FlowChart FC_Auto_Open_MoveZtoSecondPos;
        private ProVLib.FlowChart FC_Auto_Open_MappingCylinderOn;
        private ProVLib.FlowChart FC_Auto_Open_MoveZtoFirstPos;
        private ProVLib.FlowChart FC_Auto_Open_Next_3;
        private ProVLib.FlowChart FC_Auto_Open_Next_4;
        private ProVLib.FlowChart FC_Auto_Open_CalculationResult;
        private ProVLib.FlowChart FC_SCAN_NEXT_2;
        private ProVLib.FlowChart FC_SCAN_NEXT_1;
        private ProVLib.FlowChart FC_SCAN_ListAddPos;
        private ProVLib.FlowChart FC_SCAN_IsScanFlagDoit;
        private ProVLib.FlowChart FC_SCAN_START;
        private KCSDK.DRadioGroupBox dRadioGroupBox3;


    }
}