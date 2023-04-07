namespace NE_PAM
{
	partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatusContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.btnStopMonitor = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.btnhide = new System.Windows.Forms.Button();
            this.timerActiveCheck = new System.Windows.Forms.Timer(this.components);
            this.timerINIT = new System.Windows.Forms.Timer(this.components);
            this.lblMpOrgImageTitle = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.timerActiveBody1 = new System.Windows.Forms.Timer(this.components);
            this.timerActiveBody2 = new System.Windows.Forms.Timer(this.components);
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.txtCode4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnBrowse3 = new System.Windows.Forms.Button();
            this.btnBrowse4 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStop4 = new System.Windows.Forms.Button();
            this.btnStart4 = new System.Windows.Forms.Button();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMinimize = new System.Windows.Forms.CheckBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkTrayStart = new System.Windows.Forms.CheckBox();
            this.btnStop5 = new System.Windows.Forms.Button();
            this.btnStart5 = new System.Windows.Forms.Button();
            this.btnBrowse5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode5 = new System.Windows.Forms.TextBox();
            this.txtPath5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType1 = new System.Windows.Forms.ComboBox();
            this.cmbType2 = new System.Windows.Forms.ComboBox();
            this.cmbType3 = new System.Windows.Forms.ComboBox();
            this.cmbType4 = new System.Windows.Forms.ComboBox();
            this.cmbType5 = new System.Windows.Forms.ComboBox();
            this.btnDel5 = new System.Windows.Forms.Button();
            this.btnDel4 = new System.Windows.Forms.Button();
            this.btnDel3 = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.cmbRestart1 = new System.Windows.Forms.ComboBox();
            this.cmbRestart2 = new System.Windows.Forms.ComboBox();
            this.cmbRestart3 = new System.Windows.Forms.ComboBox();
            this.cmbRestart4 = new System.Windows.Forms.ComboBox();
            this.cmbRestart5 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.iconContext;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Program monitoring";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // iconContext
            // 
            this.iconContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.iconContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.mnuStart,
            this.mnuStop,
            this.mnuExit});
            this.iconContext.Name = "iconContext";
            this.iconContext.Size = new System.Drawing.Size(193, 132);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(192, 32);
            this.mnuStart.Text = "Start monitor";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(192, 32);
            this.mnuStop.Text = "Stop monitor";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(192, 32);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblStatusContext
            // 
            this.lblStatusContext.Name = "lblStatusContext";
            this.lblStatusContext.Size = new System.Drawing.Size(134, 22);
            this.lblStatusContext.Text = "Status";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMonitor.ForeColor = System.Drawing.Color.Blue;
            this.btnStartMonitor.Location = new System.Drawing.Point(386, 43);
            this.btnStartMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(103, 33);
            this.btnStartMonitor.TabIndex = 1;
            this.btnStartMonitor.Text = "모니터링시작";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // btnStopMonitor
            // 
            this.btnStopMonitor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMonitor.ForeColor = System.Drawing.Color.Red;
            this.btnStopMonitor.Location = new System.Drawing.Point(495, 43);
            this.btnStopMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopMonitor.Name = "btnStopMonitor";
            this.btnStopMonitor.Size = new System.Drawing.Size(103, 33);
            this.btnStopMonitor.TabIndex = 2;
            this.btnStopMonitor.Text = "모니터링종료";
            this.btnStopMonitor.UseVisualStyleBackColor = true;
            this.btnStopMonitor.Click += new System.EventHandler(this.btnStopMonitor_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath1.Location = new System.Drawing.Point(31, 88);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(196, 31);
            this.txtPath1.TabIndex = 3;
            this.txtPath1.TextChanged += new System.EventHandler(this.txtPath1_TextChanged);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBrowse1.Location = new System.Drawing.Point(228, 87);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse1.TabIndex = 5;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkOnTop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnTop.ForeColor = System.Drawing.Color.Black;
            this.chkOnTop.Location = new System.Drawing.Point(110, 8);
            this.chkOnTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(92, 29);
            this.chkOnTop.TabIndex = 7;
            this.chkOnTop.Text = "항상위";
            this.chkOnTop.UseVisualStyleBackColor = false;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // btnhide
            // 
            this.btnhide.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnhide.Location = new System.Drawing.Point(455, 3);
            this.btnhide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(68, 26);
            this.btnhide.TabIndex = 1;
            this.btnhide.Text = "화면감춤";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // timerActiveCheck
            // 
            this.timerActiveCheck.Interval = 5000;
            this.timerActiveCheck.Tick += new System.EventHandler(this.timerActiveCheck_Tick);
            // 
            // timerINIT
            // 
            this.timerINIT.Interval = 1000;
            this.timerINIT.Tick += new System.EventHandler(this.timerINIT_Tick);
            // 
            // lblMpOrgImageTitle
            // 
            this.lblMpOrgImageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMpOrgImageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.lblMpOrgImageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMpOrgImageTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMpOrgImageTitle.ForeColor = System.Drawing.Color.White;
            this.lblMpOrgImageTitle.Location = new System.Drawing.Point(-2, -1);
            this.lblMpOrgImageTitle.Name = "lblMpOrgImageTitle";
            this.lblMpOrgImageTitle.Size = new System.Drawing.Size(607, 29);
            this.lblMpOrgImageTitle.TabIndex = 242;
            this.lblMpOrgImageTitle.Text = "프로그램 실행상태 모니터링";
            this.lblMpOrgImageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerStatus.BackColor = System.Drawing.Color.White;
            this.lblServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServerStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(-2, 234);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(607, 30);
            this.lblServerStatus.TabIndex = 243;
            this.lblServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // cmbInterval
            // 
            this.cmbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "10",
            "30",
            "60",
            "90",
            "120",
            "180"});
            this.cmbInterval.Location = new System.Drawing.Point(60, 4);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(41, 33);
            this.cmbInterval.TabIndex = 0;
            this.cmbInterval.SelectedIndexChanged += new System.EventHandler(this.cmbInterval_SelectedIndexChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblInterval.Location = new System.Drawing.Point(11, 10);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(71, 23);
            this.lblInterval.TabIndex = 245;
            this.lblInterval.Text = "간격(초)";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerActiveBody1
            // 
            this.timerActiveBody1.Interval = 1000;
            this.timerActiveBody1.Tick += new System.EventHandler(this.timerActiveBody1_Tick);
            // 
            // timerActiveBody2
            // 
            this.timerActiveBody2.Interval = 1000;
            this.timerActiveBody2.Tick += new System.EventHandler(this.timerActiveBody2_Tick);
            // 
            // txtPath2
            // 
            this.txtPath2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath2.Location = new System.Drawing.Point(31, 115);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(196, 31);
            this.txtPath2.TabIndex = 8;
            this.txtPath2.TextChanged += new System.EventHandler(this.txtPath2_TextChanged);
            // 
            // txtPath3
            // 
            this.txtPath3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath3.Location = new System.Drawing.Point(31, 142);
            this.txtPath3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(196, 31);
            this.txtPath3.TabIndex = 13;
            this.txtPath3.TextChanged += new System.EventHandler(this.txtPath3_TextChanged);
            // 
            // txtPath4
            // 
            this.txtPath4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath4.Location = new System.Drawing.Point(31, 169);
            this.txtPath4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.Size = new System.Drawing.Size(196, 31);
            this.txtPath4.TabIndex = 18;
            this.txtPath4.TextChanged += new System.EventHandler(this.txtPath4_TextChanged);
            // 
            // txtCode1
            // 
            this.txtCode1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode1.Location = new System.Drawing.Point(253, 88);
            this.txtCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(56, 31);
            this.txtCode1.TabIndex = 4;
            this.txtCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode1.TextChanged += new System.EventHandler(this.txtCode1_TextChanged);
            // 
            // txtCode2
            // 
            this.txtCode2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode2.Location = new System.Drawing.Point(253, 115);
            this.txtCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(56, 31);
            this.txtCode2.TabIndex = 9;
            this.txtCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode2.TextChanged += new System.EventHandler(this.txtCode2_TextChanged);
            // 
            // txtCode3
            // 
            this.txtCode3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode3.Location = new System.Drawing.Point(253, 142);
            this.txtCode3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(56, 31);
            this.txtCode3.TabIndex = 14;
            this.txtCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode3.TextChanged += new System.EventHandler(this.txtCode3_TextChanged);
            // 
            // txtCode4
            // 
            this.txtCode4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode4.Location = new System.Drawing.Point(253, 169);
            this.txtCode4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.Size = new System.Drawing.Size(56, 31);
            this.txtCode4.TabIndex = 19;
            this.txtCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode4.TextChanged += new System.EventHandler(this.txtCode4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(13, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 255;
            this.label5.Text = "1.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(13, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 23);
            this.label8.TabIndex = 257;
            this.label8.Text = "4.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(13, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 258;
            this.label9.Text = "3.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBrowse2.Location = new System.Drawing.Point(228, 114);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse2.TabIndex = 10;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnBrowse3
            // 
            this.btnBrowse3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBrowse3.Location = new System.Drawing.Point(228, 141);
            this.btnBrowse3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse3.Name = "btnBrowse3";
            this.btnBrowse3.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse3.TabIndex = 15;
            this.btnBrowse3.Text = "...";
            this.btnBrowse3.UseVisualStyleBackColor = true;
            this.btnBrowse3.Click += new System.EventHandler(this.btnBrowse3_Click);
            // 
            // btnBrowse4
            // 
            this.btnBrowse4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBrowse4.Location = new System.Drawing.Point(228, 168);
            this.btnBrowse4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse4.Name = "btnBrowse4";
            this.btnBrowse4.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse4.TabIndex = 20;
            this.btnBrowse4.Text = "...";
            this.btnBrowse4.UseVisualStyleBackColor = true;
            this.btnBrowse4.Click += new System.EventHandler(this.btnBrowse4_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop1.Location = new System.Drawing.Point(555, 87);
            this.btnStop1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(24, 24);
            this.btnStop1.TabIndex = 7;
            this.btnStop1.Text = "■";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop2.Location = new System.Drawing.Point(555, 114);
            this.btnStop2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(24, 24);
            this.btnStop2.TabIndex = 12;
            this.btnStop2.Text = "■";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart2.Location = new System.Drawing.Point(531, 114);
            this.btnStart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(24, 24);
            this.btnStart2.TabIndex = 11;
            this.btnStart2.Text = "▶";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop3.Location = new System.Drawing.Point(555, 141);
            this.btnStop3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(24, 24);
            this.btnStop3.TabIndex = 17;
            this.btnStop3.Text = "■";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart3.Location = new System.Drawing.Point(531, 141);
            this.btnStart3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(24, 24);
            this.btnStart3.TabIndex = 16;
            this.btnStart3.Text = "▶";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStop4
            // 
            this.btnStop4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop4.Location = new System.Drawing.Point(555, 168);
            this.btnStop4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop4.Name = "btnStop4";
            this.btnStop4.Size = new System.Drawing.Size(24, 24);
            this.btnStop4.TabIndex = 22;
            this.btnStop4.Text = "■";
            this.btnStop4.UseVisualStyleBackColor = true;
            this.btnStop4.Click += new System.EventHandler(this.btnStop4_Click);
            // 
            // btnStart4
            // 
            this.btnStart4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart4.Location = new System.Drawing.Point(531, 168);
            this.btnStart4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart4.Name = "btnStart4";
            this.btnStart4.Size = new System.Drawing.Size(24, 24);
            this.btnStart4.TabIndex = 21;
            this.btnStart4.Text = "▶";
            this.btnStart4.UseVisualStyleBackColor = true;
            this.btnStart4.Click += new System.EventHandler(this.btnStart4_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart1.Location = new System.Drawing.Point(531, 87);
            this.btnStart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(24, 24);
            this.btnStart1.TabIndex = 6;
            this.btnStart1.Text = "▶";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.chkMinimize);
            this.panel1.Controls.Add(this.chkAutoStart);
            this.panel1.Controls.Add(this.chkTrayStart);
            this.panel1.Controls.Add(this.cmbInterval);
            this.panel1.Controls.Add(this.btnhide);
            this.panel1.Controls.Add(this.lblInterval);
            this.panel1.Controls.Add(this.chkOnTop);
            this.panel1.Location = new System.Drawing.Point(-2, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 33);
            this.panel1.TabIndex = 270;
            // 
            // chkMinimize
            // 
            this.chkMinimize.AutoSize = true;
            this.chkMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkMinimize.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMinimize.ForeColor = System.Drawing.Color.Black;
            this.chkMinimize.Location = new System.Drawing.Point(344, 8);
            this.chkMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMinimize.Name = "chkMinimize";
            this.chkMinimize.Size = new System.Drawing.Size(109, 29);
            this.chkMinimize.TabIndex = 287;
            this.chkMinimize.Text = "Mini시작";
            this.chkMinimize.UseVisualStyleBackColor = false;
            this.chkMinimize.CheckedChanged += new System.EventHandler(this.chkMinimize_CheckedChanged);
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkAutoStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoStart.ForeColor = System.Drawing.Color.Black;
            this.chkAutoStart.Location = new System.Drawing.Point(270, 8);
            this.chkAutoStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(110, 29);
            this.chkAutoStart.TabIndex = 247;
            this.chkAutoStart.Text = "자동시작";
            this.chkAutoStart.UseVisualStyleBackColor = false;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // chkTrayStart
            // 
            this.chkTrayStart.AutoSize = true;
            this.chkTrayStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkTrayStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrayStart.ForeColor = System.Drawing.Color.Black;
            this.chkTrayStart.Location = new System.Drawing.Point(178, 8);
            this.chkTrayStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTrayStart.Name = "chkTrayStart";
            this.chkTrayStart.Size = new System.Drawing.Size(128, 29);
            this.chkTrayStart.TabIndex = 246;
            this.chkTrayStart.Text = "트레이시작";
            this.chkTrayStart.UseVisualStyleBackColor = false;
            this.chkTrayStart.CheckedChanged += new System.EventHandler(this.chkTrayStart_CheckedChanged);
            // 
            // btnStop5
            // 
            this.btnStop5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop5.Location = new System.Drawing.Point(555, 195);
            this.btnStop5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop5.Name = "btnStop5";
            this.btnStop5.Size = new System.Drawing.Size(24, 24);
            this.btnStop5.TabIndex = 27;
            this.btnStop5.Text = "■";
            this.btnStop5.UseVisualStyleBackColor = true;
            this.btnStop5.Click += new System.EventHandler(this.btnStop5_Click);
            // 
            // btnStart5
            // 
            this.btnStart5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart5.Location = new System.Drawing.Point(531, 195);
            this.btnStart5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart5.Name = "btnStart5";
            this.btnStart5.Size = new System.Drawing.Size(24, 24);
            this.btnStart5.TabIndex = 26;
            this.btnStart5.Text = "▶";
            this.btnStart5.UseVisualStyleBackColor = true;
            this.btnStart5.Click += new System.EventHandler(this.btnStart5_Click);
            // 
            // btnBrowse5
            // 
            this.btnBrowse5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBrowse5.Location = new System.Drawing.Point(228, 195);
            this.btnBrowse5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse5.Name = "btnBrowse5";
            this.btnBrowse5.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse5.TabIndex = 25;
            this.btnBrowse5.Text = "...";
            this.btnBrowse5.UseVisualStyleBackColor = true;
            this.btnBrowse5.Click += new System.EventHandler(this.btnBrowse5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(13, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 273;
            this.label10.Text = "5.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode5
            // 
            this.txtCode5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode5.Location = new System.Drawing.Point(253, 196);
            this.txtCode5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode5.Name = "txtCode5";
            this.txtCode5.Size = new System.Drawing.Size(56, 31);
            this.txtCode5.TabIndex = 24;
            this.txtCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode5.TextChanged += new System.EventHandler(this.txtCode5_TextChanged);
            // 
            // txtPath5
            // 
            this.txtPath5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath5.Location = new System.Drawing.Point(31, 196);
            this.txtPath5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath5.Name = "txtPath5";
            this.txtPath5.Size = new System.Drawing.Size(196, 31);
            this.txtPath5.TabIndex = 23;
            this.txtPath5.TextChanged += new System.EventHandler(this.txtPath5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 256;
            this.label6.Text = "2.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbType1
            // 
            this.cmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType1.FormattingEnabled = true;
            this.cmbType1.Items.AddRange(new object[] {
            "",
            "FILE",
            "PROCESS"});
            this.cmbType1.Location = new System.Drawing.Point(311, 87);
            this.cmbType1.Name = "cmbType1";
            this.cmbType1.Size = new System.Drawing.Size(80, 33);
            this.cmbType1.TabIndex = 280;
            this.cmbType1.SelectedIndexChanged += new System.EventHandler(this.cmbType1_SelectedIndexChanged);
            // 
            // cmbType2
            // 
            this.cmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Items.AddRange(new object[] {
            "",
            "FILE",
            "PROCESS"});
            this.cmbType2.Location = new System.Drawing.Point(311, 115);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(80, 33);
            this.cmbType2.TabIndex = 281;
            this.cmbType2.SelectedIndexChanged += new System.EventHandler(this.cmbType2_SelectedIndexChanged);
            // 
            // cmbType3
            // 
            this.cmbType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType3.FormattingEnabled = true;
            this.cmbType3.Items.AddRange(new object[] {
            "",
            "FILE",
            "PROCESS"});
            this.cmbType3.Location = new System.Drawing.Point(311, 142);
            this.cmbType3.Name = "cmbType3";
            this.cmbType3.Size = new System.Drawing.Size(80, 33);
            this.cmbType3.TabIndex = 282;
            this.cmbType3.SelectedIndexChanged += new System.EventHandler(this.cmbType3_SelectedIndexChanged);
            // 
            // cmbType4
            // 
            this.cmbType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType4.FormattingEnabled = true;
            this.cmbType4.Items.AddRange(new object[] {
            "",
            "FILE",
            "PROCESS"});
            this.cmbType4.Location = new System.Drawing.Point(311, 169);
            this.cmbType4.Name = "cmbType4";
            this.cmbType4.Size = new System.Drawing.Size(80, 33);
            this.cmbType4.TabIndex = 283;
            this.cmbType4.SelectedIndexChanged += new System.EventHandler(this.cmbType4_SelectedIndexChanged);
            // 
            // cmbType5
            // 
            this.cmbType5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType5.FormattingEnabled = true;
            this.cmbType5.Items.AddRange(new object[] {
            "",
            "FILE",
            "PROCESS"});
            this.cmbType5.Location = new System.Drawing.Point(311, 196);
            this.cmbType5.Name = "cmbType5";
            this.cmbType5.Size = new System.Drawing.Size(80, 33);
            this.cmbType5.TabIndex = 284;
            this.cmbType5.SelectedIndexChanged += new System.EventHandler(this.cmbType5_SelectedIndexChanged);
            // 
            // btnDel5
            // 
            this.btnDel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel5.ForeColor = System.Drawing.Color.Red;
            this.btnDel5.Location = new System.Drawing.Point(579, 195);
            this.btnDel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel5.Name = "btnDel5";
            this.btnDel5.Size = new System.Drawing.Size(21, 24);
            this.btnDel5.TabIndex = 290;
            this.btnDel5.Text = "x";
            this.btnDel5.UseVisualStyleBackColor = true;
            this.btnDel5.Click += new System.EventHandler(this.btnDel5_Click);
            // 
            // btnDel4
            // 
            this.btnDel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel4.ForeColor = System.Drawing.Color.Red;
            this.btnDel4.Location = new System.Drawing.Point(579, 168);
            this.btnDel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel4.Name = "btnDel4";
            this.btnDel4.Size = new System.Drawing.Size(21, 24);
            this.btnDel4.TabIndex = 289;
            this.btnDel4.Text = "x";
            this.btnDel4.UseVisualStyleBackColor = true;
            this.btnDel4.Click += new System.EventHandler(this.btnDel4_Click);
            // 
            // btnDel3
            // 
            this.btnDel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel3.ForeColor = System.Drawing.Color.Red;
            this.btnDel3.Location = new System.Drawing.Point(579, 141);
            this.btnDel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel3.Name = "btnDel3";
            this.btnDel3.Size = new System.Drawing.Size(21, 24);
            this.btnDel3.TabIndex = 288;
            this.btnDel3.Text = "x";
            this.btnDel3.UseVisualStyleBackColor = true;
            this.btnDel3.Click += new System.EventHandler(this.btnDel3_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel2.ForeColor = System.Drawing.Color.Red;
            this.btnDel2.Location = new System.Drawing.Point(579, 114);
            this.btnDel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(21, 24);
            this.btnDel2.TabIndex = 287;
            this.btnDel2.Text = "x";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel1.ForeColor = System.Drawing.Color.Red;
            this.btnDel1.Location = new System.Drawing.Point(579, 87);
            this.btnDel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(21, 24);
            this.btnDel1.TabIndex = 286;
            this.btnDel1.Text = "x";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // cmbRestart1
            // 
            this.cmbRestart1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestart1.FormattingEnabled = true;
            this.cmbRestart1.Items.AddRange(new object[] {
            "",
            "안함",
            "1일",
            "2일",
            "3일",
            "4일",
            "5일",
            "6일",
            "7일",
            "8일",
            "9일",
            "10일"});
            this.cmbRestart1.Location = new System.Drawing.Point(393, 87);
            this.cmbRestart1.Name = "cmbRestart1";
            this.cmbRestart1.Size = new System.Drawing.Size(52, 33);
            this.cmbRestart1.TabIndex = 291;
            this.cmbRestart1.SelectedIndexChanged += new System.EventHandler(this.cmbRestart1_SelectedIndexChanged);
            // 
            // cmbRestart2
            // 
            this.cmbRestart2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestart2.FormattingEnabled = true;
            this.cmbRestart2.Items.AddRange(new object[] {
            "",
            "안함",
            "1일",
            "2일",
            "3일",
            "4일",
            "5일",
            "6일",
            "7일",
            "8일",
            "9일",
            "10일"});
            this.cmbRestart2.Location = new System.Drawing.Point(393, 115);
            this.cmbRestart2.Name = "cmbRestart2";
            this.cmbRestart2.Size = new System.Drawing.Size(52, 33);
            this.cmbRestart2.TabIndex = 293;
            this.cmbRestart2.SelectedIndexChanged += new System.EventHandler(this.cmbRestart2_SelectedIndexChanged);
            // 
            // cmbRestart3
            // 
            this.cmbRestart3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestart3.FormattingEnabled = true;
            this.cmbRestart3.Items.AddRange(new object[] {
            "",
            "안함",
            "1일",
            "2일",
            "3일",
            "4일",
            "5일",
            "6일",
            "7일",
            "8일",
            "9일",
            "10일"});
            this.cmbRestart3.Location = new System.Drawing.Point(393, 142);
            this.cmbRestart3.Name = "cmbRestart3";
            this.cmbRestart3.Size = new System.Drawing.Size(52, 33);
            this.cmbRestart3.TabIndex = 294;
            this.cmbRestart3.SelectedIndexChanged += new System.EventHandler(this.cmbRestart3_SelectedIndexChanged);
            // 
            // cmbRestart4
            // 
            this.cmbRestart4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestart4.FormattingEnabled = true;
            this.cmbRestart4.Items.AddRange(new object[] {
            "",
            "안함",
            "1일",
            "2일",
            "3일",
            "4일",
            "5일",
            "6일",
            "7일",
            "8일",
            "9일",
            "10일"});
            this.cmbRestart4.Location = new System.Drawing.Point(393, 169);
            this.cmbRestart4.Name = "cmbRestart4";
            this.cmbRestart4.Size = new System.Drawing.Size(52, 33);
            this.cmbRestart4.TabIndex = 295;
            this.cmbRestart4.SelectedIndexChanged += new System.EventHandler(this.cmbRestart4_SelectedIndexChanged);
            // 
            // cmbRestart5
            // 
            this.cmbRestart5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRestart5.FormattingEnabled = true;
            this.cmbRestart5.Items.AddRange(new object[] {
            "",
            "안함",
            "1일",
            "2일",
            "3일",
            "4일",
            "5일",
            "6일",
            "7일",
            "8일",
            "9일",
            "10일"});
            this.cmbRestart5.Location = new System.Drawing.Point(393, 196);
            this.cmbRestart5.Name = "cmbRestart5";
            this.cmbRestart5.Size = new System.Drawing.Size(52, 33);
            this.cmbRestart5.TabIndex = 296;
            this.cmbRestart5.SelectedIndexChanged += new System.EventHandler(this.cmbRestart5_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH시 mm분";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 31);
            this.dateTimePicker1.TabIndex = 297;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH시 mm분";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(448, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(81, 31);
            this.dateTimePicker2.TabIndex = 298;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH시 mm분";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(448, 143);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(81, 31);
            this.dateTimePicker3.TabIndex = 299;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH시 mm분";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(448, 169);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(81, 31);
            this.dateTimePicker4.TabIndex = 300;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH시 mm분";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(448, 197);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.ShowUpDown = true;
            this.dateTimePicker5.Size = new System.Drawing.Size(81, 31);
            this.dateTimePicker5.TabIndex = 301;
            this.dateTimePicker5.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(603, 297);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbRestart5);
            this.Controls.Add(this.cmbRestart4);
            this.Controls.Add(this.cmbRestart3);
            this.Controls.Add(this.cmbRestart2);
            this.Controls.Add(this.cmbRestart1);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnDel5);
            this.Controls.Add(this.btnDel4);
            this.Controls.Add(this.btnDel3);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnStopMonitor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnStop5);
            this.Controls.Add(this.cmbType5);
            this.Controls.Add(this.cmbType4);
            this.Controls.Add(this.cmbType3);
            this.Controls.Add(this.cmbType2);
            this.Controls.Add(this.cmbType1);
            this.Controls.Add(this.btnStart5);
            this.Controls.Add(this.txtCode5);
            this.Controls.Add(this.btnBrowse5);
            this.Controls.Add(this.txtPath5);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStop4);
            this.Controls.Add(this.btnBrowse4);
            this.Controls.Add(this.btnStart4);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBrowse3);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPath3);
            this.Controls.Add(this.txtPath4);
            this.Controls.Add(this.txtCode4);
            this.Controls.Add(this.txtCode3);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.txtCode1);
            this.Controls.Add(this.lblMpOrgImageTitle);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.btnStartMonitor);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnBrowse1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONITORING V1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.iconContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button btnStartMonitor;
		private System.Windows.Forms.Button btnStopMonitor;
		private System.Windows.Forms.TextBox txtPath1;
		private System.Windows.Forms.Button btnBrowse1;
		private System.Windows.Forms.ContextMenuStrip iconContext;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuStart;
		private System.Windows.Forms.ToolStripMenuItem mnuStop;
		private System.Windows.Forms.ToolStripMenuItem lblStatusContext;
		private System.Windows.Forms.CheckBox chkOnTop;
		private System.Windows.Forms.Button btnhide;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.Timer timerActiveCheck;
		private System.Windows.Forms.Timer timerINIT;
		private System.Windows.Forms.Label lblServerStatus;
		private System.Windows.Forms.Label lblMpOrgImageTitle;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.ComboBox cmbInterval;
		private System.Windows.Forms.Timer timerActiveBody1;
		private System.Windows.Forms.Timer timerActiveBody2;
		private System.Windows.Forms.TextBox txtPath2;
		private System.Windows.Forms.TextBox txtPath3;
		private System.Windows.Forms.TextBox txtPath4;
		private System.Windows.Forms.TextBox txtCode1;
		private System.Windows.Forms.TextBox txtCode2;
		private System.Windows.Forms.TextBox txtCode3;
		private System.Windows.Forms.TextBox txtCode4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnBrowse2;
		private System.Windows.Forms.Button btnBrowse3;
		private System.Windows.Forms.Button btnBrowse4;
		private System.Windows.Forms.Button btnStop1;
		private System.Windows.Forms.Button btnStop2;
		private System.Windows.Forms.Button btnStart2;
		private System.Windows.Forms.Button btnStop3;
		private System.Windows.Forms.Button btnStart3;
		private System.Windows.Forms.Button btnStop4;
		private System.Windows.Forms.Button btnStart4;
		private System.Windows.Forms.Button btnStart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStop5;
		private System.Windows.Forms.Button btnStart5;
		private System.Windows.Forms.Button btnBrowse5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCode5;
		private System.Windows.Forms.TextBox txtPath5;
		private System.Windows.Forms.CheckBox chkTrayStart;
		private System.Windows.Forms.CheckBox chkAutoStart;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbType1;
		private System.Windows.Forms.ComboBox cmbType2;
		private System.Windows.Forms.ComboBox cmbType3;
		private System.Windows.Forms.ComboBox cmbType4;
		private System.Windows.Forms.ComboBox cmbType5;
		private System.Windows.Forms.Button btnDel5;
		private System.Windows.Forms.Button btnDel4;
		private System.Windows.Forms.Button btnDel3;
		private System.Windows.Forms.Button btnDel2;
		private System.Windows.Forms.Button btnDel1;
		private System.Windows.Forms.CheckBox chkMinimize;
		private System.Windows.Forms.ComboBox cmbRestart1;
		private System.Windows.Forms.ComboBox cmbRestart2;
		private System.Windows.Forms.ComboBox cmbRestart3;
		private System.Windows.Forms.ComboBox cmbRestart4;
		private System.Windows.Forms.ComboBox cmbRestart5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Timer timer1;
    }
}

