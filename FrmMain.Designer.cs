namespace ONVIFCelestialTracker
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanForCamerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.groupCelestials = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbSaturn = new System.Windows.Forms.RadioButton();
            this.rbJupiter = new System.Windows.Forms.RadioButton();
            this.rbMercury = new System.Windows.Forms.RadioButton();
            this.rbMars = new System.Windows.Forms.RadioButton();
            this.rbVenus = new System.Windows.Forms.RadioButton();
            this.rbMoon = new System.Windows.Forms.RadioButton();
            this.rbSun = new System.Windows.Forms.RadioButton();
            this.groupCamera = new System.Windows.Forms.GroupBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.lbAddresses = new System.Windows.Forms.ListBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.btnSaveCamera = new System.Windows.Forms.Button();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.timerCameraCheck = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupCelestials.SuspendLayout();
            this.groupCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 573);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanForCamerasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // scanForCamerasToolStripMenuItem
            // 
            this.scanForCamerasToolStripMenuItem.Name = "scanForCamerasToolStripMenuItem";
            this.scanForCamerasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scanForCamerasToolStripMenuItem.Text = "&Scan For Cameras";
            this.scanForCamerasToolStripMenuItem.Click += new System.EventHandler(this.scanForCamerasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupCelestials);
            this.splitContainer1.Panel2.Controls.Add(this.groupCamera);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 549);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeMain
            // 
            this.treeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMain.Location = new System.Drawing.Point(0, 0);
            this.treeMain.Name = "treeMain";
            this.treeMain.Size = new System.Drawing.Size(389, 549);
            this.treeMain.TabIndex = 0;
            // 
            // groupCelestials
            // 
            this.groupCelestials.Controls.Add(this.rbNone);
            this.groupCelestials.Controls.Add(this.rbSaturn);
            this.groupCelestials.Controls.Add(this.rbJupiter);
            this.groupCelestials.Controls.Add(this.rbMercury);
            this.groupCelestials.Controls.Add(this.rbMars);
            this.groupCelestials.Controls.Add(this.rbVenus);
            this.groupCelestials.Controls.Add(this.rbMoon);
            this.groupCelestials.Controls.Add(this.rbSun);
            this.groupCelestials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCelestials.Location = new System.Drawing.Point(0, 298);
            this.groupCelestials.Name = "groupCelestials";
            this.groupCelestials.Size = new System.Drawing.Size(645, 251);
            this.groupCelestials.TabIndex = 14;
            this.groupCelestials.TabStop = false;
            this.groupCelestials.Text = "Celestials";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(173, 19);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(54, 19);
            this.rbNone.TabIndex = 7;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbSaturn
            // 
            this.rbSaturn.Location = new System.Drawing.Point(6, 172);
            this.rbSaturn.Name = "rbSaturn";
            this.rbSaturn.Size = new System.Drawing.Size(639, 19);
            this.rbSaturn.TabIndex = 6;
            this.rbSaturn.TabStop = true;
            this.rbSaturn.Text = "Saturn";
            this.rbSaturn.UseVisualStyleBackColor = true;
            // 
            // rbJupiter
            // 
            this.rbJupiter.Location = new System.Drawing.Point(6, 147);
            this.rbJupiter.Name = "rbJupiter";
            this.rbJupiter.Size = new System.Drawing.Size(639, 19);
            this.rbJupiter.TabIndex = 5;
            this.rbJupiter.TabStop = true;
            this.rbJupiter.Text = "Jupiter";
            this.rbJupiter.UseVisualStyleBackColor = true;
            // 
            // rbMercury
            // 
            this.rbMercury.Location = new System.Drawing.Point(6, 122);
            this.rbMercury.Name = "rbMercury";
            this.rbMercury.Size = new System.Drawing.Size(639, 19);
            this.rbMercury.TabIndex = 4;
            this.rbMercury.TabStop = true;
            this.rbMercury.Text = "Mercury";
            this.rbMercury.UseVisualStyleBackColor = true;
            // 
            // rbMars
            // 
            this.rbMars.Location = new System.Drawing.Point(6, 97);
            this.rbMars.Name = "rbMars";
            this.rbMars.Size = new System.Drawing.Size(639, 19);
            this.rbMars.TabIndex = 3;
            this.rbMars.TabStop = true;
            this.rbMars.Text = "Mars";
            this.rbMars.UseVisualStyleBackColor = true;
            // 
            // rbVenus
            // 
            this.rbVenus.Location = new System.Drawing.Point(6, 72);
            this.rbVenus.Name = "rbVenus";
            this.rbVenus.Size = new System.Drawing.Size(639, 19);
            this.rbVenus.TabIndex = 2;
            this.rbVenus.TabStop = true;
            this.rbVenus.Text = "Venus";
            this.rbVenus.UseVisualStyleBackColor = true;
            // 
            // rbMoon
            // 
            this.rbMoon.Location = new System.Drawing.Point(6, 47);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.Size = new System.Drawing.Size(639, 19);
            this.rbMoon.TabIndex = 1;
            this.rbMoon.TabStop = true;
            this.rbMoon.Text = "Moon";
            this.rbMoon.UseVisualStyleBackColor = true;
            // 
            // rbSun
            // 
            this.rbSun.Location = new System.Drawing.Point(6, 22);
            this.rbSun.Name = "rbSun";
            this.rbSun.Size = new System.Drawing.Size(639, 19);
            this.rbSun.TabIndex = 0;
            this.rbSun.TabStop = true;
            this.rbSun.Text = "Sun";
            this.rbSun.UseVisualStyleBackColor = true;
            // 
            // groupCamera
            // 
            this.groupCamera.AutoSize = true;
            this.groupCamera.Controls.Add(this.lblHeading);
            this.groupCamera.Controls.Add(this.txtHeading);
            this.groupCamera.Controls.Add(this.lbAddresses);
            this.groupCamera.Controls.Add(this.lblAltitude);
            this.groupCamera.Controls.Add(this.txtAltitude);
            this.groupCamera.Controls.Add(this.btnSaveCamera);
            this.groupCamera.Controls.Add(this.lblLongitude);
            this.groupCamera.Controls.Add(this.txtLongitude);
            this.groupCamera.Controls.Add(this.lblLatitude);
            this.groupCamera.Controls.Add(this.txtLatitude);
            this.groupCamera.Controls.Add(this.lblPassword);
            this.groupCamera.Controls.Add(this.txtPassword);
            this.groupCamera.Controls.Add(this.lblUsername);
            this.groupCamera.Controls.Add(this.txtUserName);
            this.groupCamera.Controls.Add(this.lblName);
            this.groupCamera.Controls.Add(this.txtName);
            this.groupCamera.Controls.Add(this.lblIPAddress);
            this.groupCamera.Controls.Add(this.txtIPAddress);
            this.groupCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCamera.Location = new System.Drawing.Point(0, 0);
            this.groupCamera.Name = "groupCamera";
            this.groupCamera.Size = new System.Drawing.Size(645, 292);
            this.groupCamera.TabIndex = 0;
            this.groupCamera.TabStop = false;
            this.groupCamera.Text = "Camera";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(15, 221);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(92, 15);
            this.lblHeading.TabIndex = 17;
            this.lblHeading.Text = "Heading (0-359)";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(114, 218);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(239, 23);
            this.txtHeading.TabIndex = 16;
            // 
            // lbAddresses
            // 
            this.lbAddresses.FormattingEnabled = true;
            this.lbAddresses.ItemHeight = 15;
            this.lbAddresses.Location = new System.Drawing.Point(359, 14);
            this.lbAddresses.Name = "lbAddresses";
            this.lbAddresses.Size = new System.Drawing.Size(274, 199);
            this.lbAddresses.TabIndex = 15;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(11, 194);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(96, 15);
            this.lblAltitude.TabIndex = 14;
            this.lblAltitude.Text = "Altitude (meters)";
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(114, 191);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(239, 23);
            this.txtAltitude.TabIndex = 13;
            // 
            // btnSaveCamera
            // 
            this.btnSaveCamera.Location = new System.Drawing.Point(114, 247);
            this.btnSaveCamera.Name = "btnSaveCamera";
            this.btnSaveCamera.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCamera.TabIndex = 12;
            this.btnSaveCamera.Text = "Save";
            this.btnSaveCamera.UseVisualStyleBackColor = true;
            this.btnSaveCamera.Click += new System.EventHandler(this.btnSaveCamera_Click);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(46, 164);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(61, 15);
            this.lblLongitude.TabIndex = 11;
            this.lblLongitude.Text = "Longitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(114, 161);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(239, 23);
            this.txtLongitude.TabIndex = 10;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(57, 135);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(50, 15);
            this.lblLatitude.TabIndex = 9;
            this.lblLatitude.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(114, 132);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(239, 23);
            this.txtLatitude.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(239, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(42, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 15);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(114, 74);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(239, 23);
            this.txtUserName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(45, 19);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(62, 15);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(114, 16);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(239, 23);
            this.txtIPAddress.TabIndex = 0;
            // 
            // timerCameraCheck
            // 
            this.timerCameraCheck.Enabled = true;
            this.timerCameraCheck.Interval = 300000;
            this.timerCameraCheck.Tick += new System.EventHandler(this.timerCameraCheck_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 595);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "ONVIF Celestial Tracker";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupCelestials.ResumeLayout(false);
            this.groupCelestials.PerformLayout();
            this.groupCamera.ResumeLayout(false);
            this.groupCamera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private SplitContainer splitContainer1;
        private TreeView treeMain;
        private ToolStripMenuItem scanForCamerasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private GroupBox groupCamera;
        private Label lblIPAddress;
        private TextBox txtIPAddress;
        private Label lblName;
        private TextBox txtName;
        private Label lblUsername;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblLongitude;
        private TextBox txtLongitude;
        private Label lblLatitude;
        private TextBox txtLatitude;
        private Button btnSaveCamera;
        private GroupBox groupCelestials;
        private RadioButton rbVenus;
        private RadioButton rbMoon;
        private RadioButton rbSun;
        private RadioButton rbMars;
        private RadioButton rbMercury;
        private RadioButton rbSaturn;
        private RadioButton rbJupiter;
        private Label lblAltitude;
        private TextBox txtAltitude;
        private ListBox lbAddresses;
        private RadioButton rbNone;
        private System.Windows.Forms.Timer timerCameraCheck;
        private Label lblHeading;
        private TextBox txtHeading;
        private ToolStripStatusLabel lblStatus;
    }
}