namespace AgOpenGPS
{
    partial class FormGPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGPS));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.contextMenuStripOpenGL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFlagToolOpenGLContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.googleEarthOpenGLContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDistanceOffABLine = new System.Windows.Forms.TextBox();
            this.openGLControlBack = new SharpGL.OpenGLControl();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.fieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUnitsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.imperialToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.bigAltitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideGuideLines = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logNMEAMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pursuitLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.simulatorOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleEarthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrWatchdog = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripHz = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHideTabs = new System.Windows.Forms.ToolStripDropDownButton();
            this.stripDistance = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownBtnFuncs = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripBoundary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripHeadland = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripResetTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAreaUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripUDPConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripUSBPortsConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripVehicleConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripAutoSteerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripYouTurnConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSequenceBinary = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripAreaRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripEqWidth = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripPortGPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripOnlineGPS = new System.Windows.Forms.ToolStripProgressBar();
            this.stripPortArduino = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripOnlineArduino = new System.Windows.Forms.ToolStripProgressBar();
            this.stripPortAutoSteer = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripOnlineAutoSteer = new System.Windows.Forms.ToolStripProgressBar();
            this.lblNorthing = new System.Windows.Forms.Label();
            this.lblEasting = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.contextMenuStripFlag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFlagRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagGrn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagYel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAreaSide = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxSentence = new System.Windows.Forms.TextBox();
            this.lblZone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccumulatedVolume = new System.Windows.Forms.Label();
            this.lblRateAppliedActual = new System.Windows.Forms.Label();
            this.lblSpeedUnits = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openGLControlZoom = new SharpGL.OpenGLControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFieldWidthNorthSouth = new System.Windows.Forms.Label();
            this.lblFieldWidthEastWest = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataPage = new System.Windows.Forms.TabPage();
            this.lblBigElevation = new System.Windows.Forms.Label();
            this.lblSats = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblFixQuality = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHeadlandDistanceFromTool = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHeadlandDistanceAway = new System.Windows.Forms.Label();
            this.lblBoundaryArea = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblGPSHeading = new System.Windows.Forms.Label();
            this.lblGyroHeading = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zoomPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZooom = new System.Windows.Forms.Label();
            this.ratePage3 = new System.Windows.Forms.TabPage();
            this.btnRateConfig = new System.Windows.Forms.Button();
            this.btnRateDn = new ProXoft.WinForms.RepeatButton();
            this.btnRateUp = new ProXoft.WinForms.RepeatButton();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnRate2Select = new System.Windows.Forms.Button();
            this.btnRate1Select = new System.Windows.Forms.Button();
            this.configPage1 = new System.Windows.Forms.TabPage();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAutoYouTurn = new System.Windows.Forms.Button();
            this.btnAutoSteerConfig = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnFileExplorer = new System.Windows.Forms.Button();
            this.btnUdpSettings = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.btnGPSData = new System.Windows.Forms.Button();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.lblPureSteerAngle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.tbarSteerAngle = new System.Windows.Forms.TrackBar();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.btnResetSteerAngle = new System.Windows.Forms.Button();
            this.btnResetSim = new System.Windows.Forms.Button();
            this.timerSim = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSimControls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeftYouTurn = new System.Windows.Forms.Button();
            this.btnTiltDown = new ProXoft.WinForms.RepeatButton();
            this.btnTiltUp = new ProXoft.WinForms.RepeatButton();
            this.btnZoomIn = new ProXoft.WinForms.RepeatButton();
            this.btnZoomOut = new ProXoft.WinForms.RepeatButton();
            this.btnSwapDirection = new System.Windows.Forms.Button();
            this.btnEnableAutoYouTurn = new System.Windows.Forms.Button();
            this.btnSectionOffAutoOn = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnAutoSteer = new System.Windows.Forms.Button();
            this.btnRightYouTurn = new System.Windows.Forms.Button();
            this.btnContour = new System.Windows.Forms.Button();
            this.btnManualOffOn = new System.Windows.Forms.Button();
            this.btnABLine = new System.Windows.Forms.Button();
            this.btnSection8Man = new System.Windows.Forms.Button();
            this.btnSection7Man = new System.Windows.Forms.Button();
            this.btnSection6Man = new System.Windows.Forms.Button();
            this.btnSection5Man = new System.Windows.Forms.Button();
            this.btnSection4Man = new System.Windows.Forms.Button();
            this.btnSection3Man = new System.Windows.Forms.Button();
            this.btnSection2Man = new System.Windows.Forms.Button();
            this.btnSection1Man = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.contextMenuStripOpenGL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripFlag.SuspendLayout();
            this.contextMenuArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlZoom)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DataPage.SuspendLayout();
            this.zoomPage2.SuspendLayout();
            this.ratePage3.SuspendLayout();
            this.configPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            this.panelSimControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControl.ContextMenuStrip = this.contextMenuStripOpenGL;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGLControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl.FrameRate = 5;
            this.openGLControl.Location = new System.Drawing.Point(1, 37);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControl.Size = new System.Drawing.Size(703, 630);
            this.openGLControl.TabIndex = 6;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            // 
            // contextMenuStripOpenGL
            // 
            this.contextMenuStripOpenGL.AutoSize = false;
            this.contextMenuStripOpenGL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFlagToolOpenGLContextMenu,
            this.toolStripSeparator5,
            this.googleEarthOpenGLContextMenu});
            this.contextMenuStripOpenGL.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripOpenGL.Name = "contextMenuStripOpenGL";
            this.contextMenuStripOpenGL.Size = new System.Drawing.Size(72, 160);
            this.contextMenuStripOpenGL.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripOpenGL_Opening);
            // 
            // deleteFlagToolOpenGLContextMenu
            // 
            this.deleteFlagToolOpenGLContextMenu.AutoSize = false;
            this.deleteFlagToolOpenGLContextMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteFlagToolOpenGLContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteFlagToolOpenGLContextMenu.Image")));
            this.deleteFlagToolOpenGLContextMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteFlagToolOpenGLContextMenu.Name = "deleteFlagToolOpenGLContextMenu";
            this.deleteFlagToolOpenGLContextMenu.Size = new System.Drawing.Size(70, 70);
            this.deleteFlagToolOpenGLContextMenu.Text = ".";
            this.deleteFlagToolOpenGLContextMenu.Click += new System.EventHandler(this.deleteFlagToolOpenGLContextMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(68, 6);
            // 
            // googleEarthOpenGLContextMenu
            // 
            this.googleEarthOpenGLContextMenu.AutoSize = false;
            this.googleEarthOpenGLContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("googleEarthOpenGLContextMenu.Image")));
            this.googleEarthOpenGLContextMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.googleEarthOpenGLContextMenu.Name = "googleEarthOpenGLContextMenu";
            this.googleEarthOpenGLContextMenu.Size = new System.Drawing.Size(70, 70);
            this.googleEarthOpenGLContextMenu.Text = ".";
            this.googleEarthOpenGLContextMenu.Click += new System.EventHandler(this.googleEarthOpenGLContextMenu_Click);
            // 
            // txtDistanceOffABLine
            // 
            this.txtDistanceOffABLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDistanceOffABLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDistanceOffABLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistanceOffABLine.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceOffABLine.ForeColor = System.Drawing.Color.Green;
            this.txtDistanceOffABLine.Location = new System.Drawing.Point(300, 0);
            this.txtDistanceOffABLine.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txtDistanceOffABLine.Name = "txtDistanceOffABLine";
            this.txtDistanceOffABLine.ReadOnly = true;
            this.txtDistanceOffABLine.Size = new System.Drawing.Size(110, 36);
            this.txtDistanceOffABLine.TabIndex = 7;
            this.txtDistanceOffABLine.Text = "00000";
            this.txtDistanceOffABLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openGLControlBack
            // 
            this.openGLControlBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControlBack.DrawFPS = false;
            this.openGLControlBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControlBack.FrameRate = 1;
            this.openGLControlBack.Location = new System.Drawing.Point(6, 34);
            this.openGLControlBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.openGLControlBack.Name = "openGLControlBack";
            this.openGLControlBack.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlBack.RenderContextType = SharpGL.RenderContextType.HiddenWindow;
            this.openGLControlBack.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControlBack.Size = new System.Drawing.Size(400, 400);
            this.openGLControlBack.TabIndex = 91;
            this.openGLControlBack.Visible = false;
            this.openGLControlBack.OpenGLInitialized += new System.EventHandler(this.openGLControlBack_OpenGLInitialized);
            this.openGLControlBack.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlBack_OpenGLDraw);
            this.openGLControlBack.Resized += new System.EventHandler(this.openGLControlBack_Resized);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadVehicleToolStripMenuItem,
            this.saveVehicleToolStripMenuItem,
            this.toolStripSeparator8,
            this.fieldToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 37);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadVehicleToolStripMenuItem
            // 
            this.loadVehicleToolStripMenuItem.Name = "loadVehicleToolStripMenuItem";
            this.loadVehicleToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.loadVehicleToolStripMenuItem.Text = "Load Vehicle";
            this.loadVehicleToolStripMenuItem.Click += new System.EventHandler(this.loadVehicleToolStripMenuItem_Click);
            // 
            // saveVehicleToolStripMenuItem
            // 
            this.saveVehicleToolStripMenuItem.Name = "saveVehicleToolStripMenuItem";
            this.saveVehicleToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.saveVehicleToolStripMenuItem.Text = "Save Vehicle";
            this.saveVehicleToolStripMenuItem.Click += new System.EventHandler(this.saveVehicleToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(255, 6);
            // 
            // fieldToolStripMenuItem
            // 
            this.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem";
            this.fieldToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.fieldToolStripMenuItem.Text = "Start Field";
            this.fieldToolStripMenuItem.Click += new System.EventHandler(this.fieldToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.resetALLToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.toolStripUnitsMenu,
            this.bigAltitudeToolStripMenuItem,
            this.sideGuideLines,
            this.gridToolStripMenuItem,
            this.lightbarToolStripMenuItem,
            this.logNMEAMenuItem,
            this.polygonsToolStripMenuItem,
            this.pursuitLineToolStripMenuItem,
            this.skyToolStripMenu,
            this.toolStripSeparator6,
            this.simulatorOnToolStripMenuItem,
            this.toolStripSeparator7});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 37);
            this.settingsToolStripMenuItem.Text = "Display";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // resetALLToolStripMenuItem
            // 
            this.resetALLToolStripMenuItem.Name = "resetALLToolStripMenuItem";
            this.resetALLToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.resetALLToolStripMenuItem.Text = "Reset ALL";
            this.resetALLToolStripMenuItem.Click += new System.EventHandler(this.resetALLToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(260, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectionToolStripMenuItem,
            this.fieldToolStripMenuItem1});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(187, 40);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click);
            // 
            // fieldToolStripMenuItem1
            // 
            this.fieldToolStripMenuItem1.Name = "fieldToolStripMenuItem1";
            this.fieldToolStripMenuItem1.Size = new System.Drawing.Size(187, 40);
            this.fieldToolStripMenuItem1.Text = "Field";
            this.fieldToolStripMenuItem1.Click += new System.EventHandler(this.fieldToolStripMenuItem1_Click);
            // 
            // toolStripUnitsMenu
            // 
            this.toolStripUnitsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricToolStrip,
            this.imperialToolStrip});
            this.toolStripUnitsMenu.Name = "toolStripUnitsMenu";
            this.toolStripUnitsMenu.Size = new System.Drawing.Size(263, 40);
            this.toolStripUnitsMenu.Text = "Units";
            // 
            // metricToolStrip
            // 
            this.metricToolStrip.CheckOnClick = true;
            this.metricToolStrip.Name = "metricToolStrip";
            this.metricToolStrip.Size = new System.Drawing.Size(200, 40);
            this.metricToolStrip.Text = "Metric";
            this.metricToolStrip.Click += new System.EventHandler(this.metricToolStrip_Click);
            // 
            // imperialToolStrip
            // 
            this.imperialToolStrip.CheckOnClick = true;
            this.imperialToolStrip.Name = "imperialToolStrip";
            this.imperialToolStrip.Size = new System.Drawing.Size(200, 40);
            this.imperialToolStrip.Text = "Imperial";
            this.imperialToolStrip.Click += new System.EventHandler(this.imperialToolStrip_Click);
            // 
            // bigAltitudeToolStripMenuItem
            // 
            this.bigAltitudeToolStripMenuItem.Checked = true;
            this.bigAltitudeToolStripMenuItem.CheckOnClick = true;
            this.bigAltitudeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bigAltitudeToolStripMenuItem.Name = "bigAltitudeToolStripMenuItem";
            this.bigAltitudeToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.bigAltitudeToolStripMenuItem.Text = "Big Elevation";
            this.bigAltitudeToolStripMenuItem.Click += new System.EventHandler(this.bigAltitudeToolStripMenuItem_Click);
            // 
            // sideGuideLines
            // 
            this.sideGuideLines.Checked = true;
            this.sideGuideLines.CheckOnClick = true;
            this.sideGuideLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sideGuideLines.Name = "sideGuideLines";
            this.sideGuideLines.Size = new System.Drawing.Size(263, 40);
            this.sideGuideLines.Text = "Extra Guides";
            this.sideGuideLines.Click += new System.EventHandler(this.sideGuideLines_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.gridToolStripMenuItem.Text = "Grid On";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // lightbarToolStripMenuItem
            // 
            this.lightbarToolStripMenuItem.Name = "lightbarToolStripMenuItem";
            this.lightbarToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.lightbarToolStripMenuItem.Text = "Lightbar On";
            this.lightbarToolStripMenuItem.Click += new System.EventHandler(this.lightbarToolStripMenuItem_Click);
            // 
            // logNMEAMenuItem
            // 
            this.logNMEAMenuItem.Name = "logNMEAMenuItem";
            this.logNMEAMenuItem.Size = new System.Drawing.Size(263, 40);
            this.logNMEAMenuItem.Text = "Log NMEA";
            this.logNMEAMenuItem.Click += new System.EventHandler(this.logNMEAMenuItem_Click);
            // 
            // polygonsToolStripMenuItem
            // 
            this.polygonsToolStripMenuItem.Checked = true;
            this.polygonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.polygonsToolStripMenuItem.Name = "polygonsToolStripMenuItem";
            this.polygonsToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.polygonsToolStripMenuItem.Text = "Polygons On";
            this.polygonsToolStripMenuItem.Click += new System.EventHandler(this.polygonsToolStripMenuItem_Click);
            // 
            // pursuitLineToolStripMenuItem
            // 
            this.pursuitLineToolStripMenuItem.Checked = true;
            this.pursuitLineToolStripMenuItem.CheckOnClick = true;
            this.pursuitLineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pursuitLineToolStripMenuItem.Name = "pursuitLineToolStripMenuItem";
            this.pursuitLineToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.pursuitLineToolStripMenuItem.Text = "Pursuit Line";
            this.pursuitLineToolStripMenuItem.Click += new System.EventHandler(this.pursuitLineToolStripMenuItem_Click);
            // 
            // skyToolStripMenu
            // 
            this.skyToolStripMenu.Checked = true;
            this.skyToolStripMenu.CheckOnClick = true;
            this.skyToolStripMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skyToolStripMenu.Name = "skyToolStripMenu";
            this.skyToolStripMenu.Size = new System.Drawing.Size(263, 40);
            this.skyToolStripMenu.Text = "Sky On";
            this.skyToolStripMenu.Click += new System.EventHandler(this.skyToolStripMenu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(260, 6);
            // 
            // simulatorOnToolStripMenuItem
            // 
            this.simulatorOnToolStripMenuItem.Checked = true;
            this.simulatorOnToolStripMenuItem.CheckOnClick = true;
            this.simulatorOnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simulatorOnToolStripMenuItem.Name = "simulatorOnToolStripMenuItem";
            this.simulatorOnToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.simulatorOnToolStripMenuItem.Text = "Simulator On";
            this.simulatorOnToolStripMenuItem.Click += new System.EventHandler(this.simulatorOnToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(260, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1120, 37);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem,
            this.webCamToolStripMenuItem,
            this.fieldViewerToolStripMenuItem,
            this.googleEarthToolStripMenuItem,
            this.gPSDataToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(93, 37);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.explorerToolStripMenuItem.Text = "Windows Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.webCamToolStripMenuItem.Text = "Web Cam";
            this.webCamToolStripMenuItem.Click += new System.EventHandler(this.webCamToolStripMenuItem_Click_1);
            // 
            // fieldViewerToolStripMenuItem
            // 
            this.fieldViewerToolStripMenuItem.Name = "fieldViewerToolStripMenuItem";
            this.fieldViewerToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.fieldViewerToolStripMenuItem.Text = "Field Viewer";
            this.fieldViewerToolStripMenuItem.Click += new System.EventHandler(this.fieldViewerToolStripMenuItem_Click);
            // 
            // googleEarthToolStripMenuItem
            // 
            this.googleEarthToolStripMenuItem.Name = "googleEarthToolStripMenuItem";
            this.googleEarthToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.googleEarthToolStripMenuItem.Text = "Google Earth - Flags";
            this.googleEarthToolStripMenuItem.Click += new System.EventHandler(this.googleEarthToolStripMenuItem_Click);
            // 
            // gPSDataToolStripMenuItem1
            // 
            this.gPSDataToolStripMenuItem1.Name = "gPSDataToolStripMenuItem1";
            this.gPSDataToolStripMenuItem1.Size = new System.Drawing.Size(360, 40);
            this.gPSDataToolStripMenuItem1.Text = "GPS Data";
            this.gPSDataToolStripMenuItem1.Click += new System.EventHandler(this.gPSDataToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuHelpAbout,
            this.helpToolStripMenuHelpHelp});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(360, 40);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuHelpAbout
            // 
            this.aboutToolStripMenuHelpAbout.Name = "aboutToolStripMenuHelpAbout";
            this.aboutToolStripMenuHelpAbout.Size = new System.Drawing.Size(168, 40);
            this.aboutToolStripMenuHelpAbout.Text = "About";
            this.aboutToolStripMenuHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuHelpAbout_Click);
            // 
            // helpToolStripMenuHelpHelp
            // 
            this.helpToolStripMenuHelpHelp.Name = "helpToolStripMenuHelpHelp";
            this.helpToolStripMenuHelpHelp.Size = new System.Drawing.Size(168, 40);
            this.helpToolStripMenuHelpHelp.Text = "Help";
            this.helpToolStripMenuHelpHelp.Click += new System.EventHandler(this.helpToolStripMenuHelpHelp_Click);
            // 
            // tmrWatchdog
            // 
            this.tmrWatchdog.Interval = 50;
            this.tmrWatchdog.Tick += new System.EventHandler(this.tmrWatchdog_tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripHz,
            this.btnHideTabs,
            this.stripDistance,
            this.toolStripDropDownBtnFuncs,
            this.stripAreaUser,
            this.toolStripDropDownButton2,
            this.stripSequenceBinary,
            this.stripAreaRate,
            this.stripEqWidth,
            this.stripPortGPS,
            this.stripOnlineGPS,
            this.stripPortArduino,
            this.stripOnlineArduino,
            this.stripPortAutoSteer,
            this.stripOnlineAutoSteer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1120, 41);
            this.statusStrip1.TabIndex = 95;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripHz
            // 
            this.stripHz.AutoSize = false;
            this.stripHz.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripHz.Margin = new System.Windows.Forms.Padding(0);
            this.stripHz.Name = "stripHz";
            this.stripHz.Size = new System.Drawing.Size(72, 41);
            this.stripHz.Text = "Hz";
            this.stripHz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHideTabs
            // 
            this.btnHideTabs.AutoSize = false;
            this.btnHideTabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHideTabs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHideTabs.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideTabs.Image = ((System.Drawing.Image)(resources.GetObject("btnHideTabs.Image")));
            this.btnHideTabs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHideTabs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHideTabs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHideTabs.Name = "btnHideTabs";
            this.btnHideTabs.ShowDropDownArrow = false;
            this.btnHideTabs.Size = new System.Drawing.Size(64, 39);
            this.btnHideTabs.Text = "Config";
            this.btnHideTabs.Click += new System.EventHandler(this.btnHideTabs_Click);
            // 
            // stripDistance
            // 
            this.stripDistance.AutoSize = false;
            this.stripDistance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripDistance.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripDistance.Name = "stripDistance";
            this.stripDistance.Size = new System.Drawing.Size(102, 41);
            this.stripDistance.Text = "8888 ft";
            // 
            // toolStripDropDownBtnFuncs
            // 
            this.toolStripDropDownBtnFuncs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownBtnFuncs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownBtnFuncs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripField,
            this.toolstripBoundary,
            this.toolstripHeadland,
            this.toolstripResetTrip});
            this.toolStripDropDownBtnFuncs.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownBtnFuncs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnFuncs.Image")));
            this.toolStripDropDownBtnFuncs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDropDownBtnFuncs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownBtnFuncs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnFuncs.Name = "toolStripDropDownBtnFuncs";
            this.toolStripDropDownBtnFuncs.ShowDropDownArrow = false;
            this.toolStripDropDownBtnFuncs.Size = new System.Drawing.Size(82, 39);
            // 
            // toolstripField
            // 
            this.toolstripField.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripField.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripField.Image = ((System.Drawing.Image)(resources.GetObject("toolstripField.Image")));
            this.toolstripField.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripField.Name = "toolstripField";
            this.toolstripField.Size = new System.Drawing.Size(263, 70);
            this.toolstripField.Text = "Field";
            this.toolstripField.Click += new System.EventHandler(this.toolstripField_Click);
            // 
            // toolstripBoundary
            // 
            this.toolstripBoundary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripBoundary.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripBoundary.Image = ((System.Drawing.Image)(resources.GetObject("toolstripBoundary.Image")));
            this.toolstripBoundary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripBoundary.Name = "toolstripBoundary";
            this.toolstripBoundary.Size = new System.Drawing.Size(263, 70);
            this.toolstripBoundary.Text = "Boundary";
            this.toolstripBoundary.Click += new System.EventHandler(this.toolstripBoundary_Click);
            // 
            // toolstripHeadland
            // 
            this.toolstripHeadland.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripHeadland.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripHeadland.Image = ((System.Drawing.Image)(resources.GetObject("toolstripHeadland.Image")));
            this.toolstripHeadland.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripHeadland.Name = "toolstripHeadland";
            this.toolstripHeadland.Size = new System.Drawing.Size(263, 70);
            this.toolstripHeadland.Text = "Headland";
            this.toolstripHeadland.Click += new System.EventHandler(this.toolstripHeadland_Click);
            // 
            // toolstripResetTrip
            // 
            this.toolstripResetTrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripResetTrip.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripResetTrip.Image = ((System.Drawing.Image)(resources.GetObject("toolstripResetTrip.Image")));
            this.toolstripResetTrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripResetTrip.Name = "toolstripResetTrip";
            this.toolstripResetTrip.Size = new System.Drawing.Size(263, 70);
            this.toolstripResetTrip.Text = ">0< Trip";
            this.toolstripResetTrip.Click += new System.EventHandler(this.toolstripResetTrip_Click_1);
            // 
            // stripAreaUser
            // 
            this.stripAreaUser.AutoSize = false;
            this.stripAreaUser.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripAreaUser.Margin = new System.Windows.Forms.Padding(0);
            this.stripAreaUser.Name = "stripAreaUser";
            this.stripAreaUser.Size = new System.Drawing.Size(120, 41);
            this.stripAreaUser.Text = "126.9";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripUDPConfig,
            this.toolstripUSBPortsConfig,
            this.toolstripVehicleConfig,
            this.toolstripAutoSteerConfig,
            this.toolstripYouTurnConfig});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(82, 39);
            this.toolStripDropDownButton2.Text = "Config";
            // 
            // toolstripUDPConfig
            // 
            this.toolstripUDPConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripUDPConfig.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripUDPConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripUDPConfig.Image")));
            this.toolstripUDPConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripUDPConfig.Name = "toolstripUDPConfig";
            this.toolstripUDPConfig.Size = new System.Drawing.Size(292, 86);
            this.toolstripUDPConfig.Text = "UDP";
            this.toolstripUDPConfig.Click += new System.EventHandler(this.toolstripUDPConfig_Click);
            // 
            // toolstripUSBPortsConfig
            // 
            this.toolstripUSBPortsConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripUSBPortsConfig.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripUSBPortsConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripUSBPortsConfig.Image")));
            this.toolstripUSBPortsConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripUSBPortsConfig.Name = "toolstripUSBPortsConfig";
            this.toolstripUSBPortsConfig.Size = new System.Drawing.Size(292, 86);
            this.toolstripUSBPortsConfig.Text = "Ports";
            this.toolstripUSBPortsConfig.Click += new System.EventHandler(this.toolstripUSBPortsConfig_Click);
            // 
            // toolstripVehicleConfig
            // 
            this.toolstripVehicleConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripVehicleConfig.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripVehicleConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripVehicleConfig.Image")));
            this.toolstripVehicleConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripVehicleConfig.Name = "toolstripVehicleConfig";
            this.toolstripVehicleConfig.Size = new System.Drawing.Size(292, 86);
            this.toolstripVehicleConfig.Text = "Vehicle";
            this.toolstripVehicleConfig.Click += new System.EventHandler(this.toolstripVehicleConfig_Click);
            // 
            // toolstripAutoSteerConfig
            // 
            this.toolstripAutoSteerConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripAutoSteerConfig.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripAutoSteerConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripAutoSteerConfig.Image")));
            this.toolstripAutoSteerConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolstripAutoSteerConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripAutoSteerConfig.Name = "toolstripAutoSteerConfig";
            this.toolstripAutoSteerConfig.Size = new System.Drawing.Size(292, 86);
            this.toolstripAutoSteerConfig.Text = "Auto Steer";
            this.toolstripAutoSteerConfig.Click += new System.EventHandler(this.toolstripAutoSteerConfig_Click);
            // 
            // toolstripYouTurnConfig
            // 
            this.toolstripYouTurnConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripYouTurnConfig.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripYouTurnConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripYouTurnConfig.Image")));
            this.toolstripYouTurnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripYouTurnConfig.Name = "toolstripYouTurnConfig";
            this.toolstripYouTurnConfig.Size = new System.Drawing.Size(292, 86);
            this.toolstripYouTurnConfig.Text = "U Turn";
            this.toolstripYouTurnConfig.Click += new System.EventHandler(this.toolstripYouTurnConfig_Click);
            // 
            // stripSequenceBinary
            // 
            this.stripSequenceBinary.AutoSize = false;
            this.stripSequenceBinary.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripSequenceBinary.Margin = new System.Windows.Forms.Padding(0);
            this.stripSequenceBinary.Name = "stripSequenceBinary";
            this.stripSequenceBinary.Size = new System.Drawing.Size(102, 41);
            this.stripSequenceBinary.Text = "Seq Bin";
            this.stripSequenceBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stripSequenceBinary.ToolTipText = "Area Per Hour";
            // 
            // stripAreaRate
            // 
            this.stripAreaRate.AutoSize = false;
            this.stripAreaRate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripAreaRate.Margin = new System.Windows.Forms.Padding(0);
            this.stripAreaRate.Name = "stripAreaRate";
            this.stripAreaRate.Size = new System.Drawing.Size(102, 41);
            this.stripAreaRate.Text = "Ac/Hr";
            this.stripAreaRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stripAreaRate.ToolTipText = "Area Per Hour";
            // 
            // stripEqWidth
            // 
            this.stripEqWidth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stripEqWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stripEqWidth.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripEqWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripEqWidth.Margin = new System.Windows.Forms.Padding(0);
            this.stripEqWidth.Name = "stripEqWidth";
            this.stripEqWidth.Size = new System.Drawing.Size(263, 41);
            this.stripEqWidth.Spring = true;
            this.stripEqWidth.Text = "Width";
            // 
            // stripPortGPS
            // 
            this.stripPortGPS.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.stripPortGPS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripPortGPS.ForeColor = System.Drawing.Color.Red;
            this.stripPortGPS.Name = "stripPortGPS";
            this.stripPortGPS.Size = new System.Drawing.Size(22, 36);
            this.stripPortGPS.Text = "* *";
            // 
            // stripOnlineGPS
            // 
            this.stripOnlineGPS.AutoSize = false;
            this.stripOnlineGPS.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.stripOnlineGPS.Name = "stripOnlineGPS";
            this.stripOnlineGPS.Size = new System.Drawing.Size(16, 35);
            this.stripOnlineGPS.Value = 1;
            // 
            // stripPortArduino
            // 
            this.stripPortArduino.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripPortArduino.ForeColor = System.Drawing.Color.Red;
            this.stripPortArduino.Name = "stripPortArduino";
            this.stripPortArduino.Size = new System.Drawing.Size(22, 36);
            this.stripPortArduino.Text = "* *";
            // 
            // stripOnlineArduino
            // 
            this.stripOnlineArduino.AutoToolTip = true;
            this.stripOnlineArduino.ForeColor = System.Drawing.Color.Chartreuse;
            this.stripOnlineArduino.Name = "stripOnlineArduino";
            this.stripOnlineArduino.Size = new System.Drawing.Size(16, 35);
            this.stripOnlineArduino.ToolTipText = "Arduino";
            this.stripOnlineArduino.Value = 1;
            // 
            // stripPortAutoSteer
            // 
            this.stripPortAutoSteer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripPortAutoSteer.ForeColor = System.Drawing.Color.Red;
            this.stripPortAutoSteer.Name = "stripPortAutoSteer";
            this.stripPortAutoSteer.Size = new System.Drawing.Size(22, 36);
            this.stripPortAutoSteer.Text = "* *";
            // 
            // stripOnlineAutoSteer
            // 
            this.stripOnlineAutoSteer.AutoToolTip = true;
            this.stripOnlineAutoSteer.ForeColor = System.Drawing.Color.Chartreuse;
            this.stripOnlineAutoSteer.Name = "stripOnlineAutoSteer";
            this.stripOnlineAutoSteer.Size = new System.Drawing.Size(16, 35);
            this.stripOnlineAutoSteer.ToolTipText = "Arduino";
            this.stripOnlineAutoSteer.Value = 1;
            // 
            // lblNorthing
            // 
            this.lblNorthing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNorthing.AutoSize = true;
            this.lblNorthing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNorthing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorthing.Location = new System.Drawing.Point(269, 32);
            this.lblNorthing.Name = "lblNorthing";
            this.lblNorthing.Size = new System.Drawing.Size(59, 19);
            this.lblNorthing.TabIndex = 110;
            this.lblNorthing.Text = "label1";
            this.lblNorthing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEasting
            // 
            this.lblEasting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEasting.AutoSize = true;
            this.lblEasting.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEasting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasting.Location = new System.Drawing.Point(269, 7);
            this.lblEasting.Name = "lblEasting";
            this.lblEasting.Size = new System.Drawing.Size(59, 19);
            this.lblEasting.TabIndex = 111;
            this.lblEasting.Text = "label2";
            this.lblEasting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(712, -5);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(87, 41);
            this.lblSpeed.TabIndex = 116;
            this.lblSpeed.Text = "88.8";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStripFlag
            // 
            this.contextMenuStripFlag.AutoSize = false;
            this.contextMenuStripFlag.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contextMenuStripFlag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFlagRed,
            this.toolStripMenuFlagGrn,
            this.toolStripMenuFlagYel,
            this.toolStripSeparator3,
            this.toolStripMenuFlagDelete,
            this.toolStripSeparator4,
            this.toolStripMenuFlagDeleteAll});
            this.contextMenuStripFlag.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripFlag.Name = "contextMenuStripFlag";
            this.contextMenuStripFlag.Size = new System.Drawing.Size(72, 400);
            this.contextMenuStripFlag.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripFlag_Opening);
            // 
            // toolStripMenuItemFlagRed
            // 
            this.toolStripMenuItemFlagRed.AutoSize = false;
            this.toolStripMenuItemFlagRed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItemFlagRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemFlagRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFlagRed.Image")));
            this.toolStripMenuItemFlagRed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFlagRed.Name = "toolStripMenuItemFlagRed";
            this.toolStripMenuItemFlagRed.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuItemFlagRed.Text = ".";
            this.toolStripMenuItemFlagRed.Click += new System.EventHandler(this.toolStripMenuItemFlagRed_Click);
            // 
            // toolStripMenuFlagGrn
            // 
            this.toolStripMenuFlagGrn.AutoSize = false;
            this.toolStripMenuFlagGrn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagGrn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagGrn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagGrn.Image")));
            this.toolStripMenuFlagGrn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagGrn.Name = "toolStripMenuFlagGrn";
            this.toolStripMenuFlagGrn.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagGrn.Text = ".";
            this.toolStripMenuFlagGrn.Click += new System.EventHandler(this.toolStripMenuGrn_Click);
            // 
            // toolStripMenuFlagYel
            // 
            this.toolStripMenuFlagYel.AutoSize = false;
            this.toolStripMenuFlagYel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagYel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagYel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagYel.Image")));
            this.toolStripMenuFlagYel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagYel.Name = "toolStripMenuFlagYel";
            this.toolStripMenuFlagYel.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagYel.Text = ".";
            this.toolStripMenuFlagYel.Click += new System.EventHandler(this.toolStripMenuYel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(68, 20);
            // 
            // toolStripMenuFlagDelete
            // 
            this.toolStripMenuFlagDelete.AutoSize = false;
            this.toolStripMenuFlagDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagDelete.Image")));
            this.toolStripMenuFlagDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagDelete.Name = "toolStripMenuFlagDelete";
            this.toolStripMenuFlagDelete.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagDelete.Text = ".";
            this.toolStripMenuFlagDelete.Click += new System.EventHandler(this.toolStripMenuFlagDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(68, 20);
            // 
            // toolStripMenuFlagDeleteAll
            // 
            this.toolStripMenuFlagDeleteAll.AutoSize = false;
            this.toolStripMenuFlagDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagDeleteAll.Image")));
            this.toolStripMenuFlagDeleteAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagDeleteAll.Name = "toolStripMenuFlagDeleteAll";
            this.toolStripMenuFlagDeleteAll.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagDeleteAll.Text = "toolStripMenuFlagDeleteAll";
            this.toolStripMenuFlagDeleteAll.Click += new System.EventHandler(this.toolStripMenuFlagDeleteAll_Click);
            // 
            // contextMenuArea
            // 
            this.contextMenuArea.AutoSize = false;
            this.contextMenuArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAreaSide});
            this.contextMenuArea.Name = "contextMenuArea";
            this.contextMenuArea.Size = new System.Drawing.Size(70, 80);
            // 
            // toolStripMenuAreaSide
            // 
            this.toolStripMenuAreaSide.AutoSize = false;
            this.toolStripMenuAreaSide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuAreaSide.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuAreaSide.Image")));
            this.toolStripMenuAreaSide.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuAreaSide.Name = "toolStripMenuAreaSide";
            this.toolStripMenuAreaSide.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuAreaSide.Text = ".";
            this.toolStripMenuAreaSide.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuAreaSide.Click += new System.EventHandler(this.toolStripMenuAreaSide_Click);
            // 
            // tboxSentence
            // 
            this.tboxSentence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSentence.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tboxSentence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSentence.Location = new System.Drawing.Point(3, 4);
            this.tboxSentence.Multiline = true;
            this.tboxSentence.Name = "tboxSentence";
            this.tboxSentence.ReadOnly = true;
            this.tboxSentence.Size = new System.Drawing.Size(263, 49);
            this.tboxSentence.TabIndex = 134;
            // 
            // lblZone
            // 
            this.lblZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZone.AutoSize = true;
            this.lblZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblZone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(375, 33);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(29, 19);
            this.lblZone.TabIndex = 135;
            this.lblZone.Text = "Zn";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 147;
            this.label2.Text = "Volume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 146;
            this.label1.Text = "Rate Actual";
            // 
            // lblAccumulatedVolume
            // 
            this.lblAccumulatedVolume.AutoSize = true;
            this.lblAccumulatedVolume.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAccumulatedVolume.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumulatedVolume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccumulatedVolume.Location = new System.Drawing.Point(20, 55);
            this.lblAccumulatedVolume.Name = "lblAccumulatedVolume";
            this.lblAccumulatedVolume.Size = new System.Drawing.Size(29, 39);
            this.lblAccumulatedVolume.TabIndex = 144;
            this.lblAccumulatedVolume.Text = "-";
            // 
            // lblRateAppliedActual
            // 
            this.lblRateAppliedActual.AutoSize = true;
            this.lblRateAppliedActual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRateAppliedActual.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateAppliedActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRateAppliedActual.Location = new System.Drawing.Point(13, 126);
            this.lblRateAppliedActual.Name = "lblRateAppliedActual";
            this.lblRateAppliedActual.Size = new System.Drawing.Size(42, 58);
            this.lblRateAppliedActual.TabIndex = 145;
            this.lblRateAppliedActual.Text = "-";
            // 
            // lblSpeedUnits
            // 
            this.lblSpeedUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedUnits.AutoSize = true;
            this.lblSpeedUnits.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSpeedUnits.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedUnits.Location = new System.Drawing.Point(795, 14);
            this.lblSpeedUnits.Name = "lblSpeedUnits";
            this.lblSpeedUnits.Size = new System.Drawing.Size(38, 17);
            this.lblSpeedUnits.TabIndex = 139;
            this.lblSpeedUnits.Text = "kmh";
            this.lblSpeedUnits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(867, -5);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(130, 40);
            this.lblHeading.TabIndex = 117;
            this.lblHeading.Text = "359.8.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SettingsGear64.png");
            this.imageList1.Images.SetKeyName(1, "Satellite64.png");
            this.imageList1.Images.SetKeyName(2, "Rate64.png");
            this.imageList1.Images.SetKeyName(3, "FieldView.png");
            // 
            // openGLControlZoom
            // 
            this.openGLControlZoom.DrawFPS = false;
            this.openGLControlZoom.Location = new System.Drawing.Point(3, 3);
            this.openGLControlZoom.Name = "openGLControlZoom";
            this.openGLControlZoom.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlZoom.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControlZoom.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControlZoom.Size = new System.Drawing.Size(400, 400);
            this.openGLControlZoom.TabIndex = 0;
            this.openGLControlZoom.OpenGLInitialized += new System.EventHandler(this.openGLControlZoom_OpenGLInitialized);
            this.openGLControlZoom.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlZoom_OpenGLDraw);
            this.openGLControlZoom.Resized += new System.EventHandler(this.openGLControlZoom_Resized);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 153;
            this.label5.Text = "E/W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(135, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 152;
            this.label4.Text = "N/S";
            // 
            // lblFieldWidthNorthSouth
            // 
            this.lblFieldWidthNorthSouth.AutoSize = true;
            this.lblFieldWidthNorthSouth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFieldWidthNorthSouth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldWidthNorthSouth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFieldWidthNorthSouth.Location = new System.Drawing.Point(177, 406);
            this.lblFieldWidthNorthSouth.Name = "lblFieldWidthNorthSouth";
            this.lblFieldWidthNorthSouth.Size = new System.Drawing.Size(46, 23);
            this.lblFieldWidthNorthSouth.TabIndex = 151;
            this.lblFieldWidthNorthSouth.Text = "0.00";
            // 
            // lblFieldWidthEastWest
            // 
            this.lblFieldWidthEastWest.AutoSize = true;
            this.lblFieldWidthEastWest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFieldWidthEastWest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldWidthEastWest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFieldWidthEastWest.Location = new System.Drawing.Point(51, 406);
            this.lblFieldWidthEastWest.Name = "lblFieldWidthEastWest";
            this.lblFieldWidthEastWest.Size = new System.Drawing.Size(46, 23);
            this.lblFieldWidthEastWest.TabIndex = 150;
            this.lblFieldWidthEastWest.Text = "0.00";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.DataPage);
            this.tabControl1.Controls.Add(this.zoomPage2);
            this.tabControl1.Controls.Add(this.ratePage3);
            this.tabControl1.Controls.Add(this.configPage1);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(98, 68);
            this.tabControl1.Location = new System.Drawing.Point(704, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 510);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 150;
            // 
            // DataPage
            // 
            this.DataPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DataPage.Controls.Add(this.lblBigElevation);
            this.DataPage.Controls.Add(this.lblSats);
            this.DataPage.Controls.Add(this.label17);
            this.DataPage.Controls.Add(this.lblFixQuality);
            this.DataPage.Controls.Add(this.label16);
            this.DataPage.Controls.Add(this.lblAltitude);
            this.DataPage.Controls.Add(this.label19);
            this.DataPage.Controls.Add(this.label18);
            this.DataPage.Controls.Add(this.lblLongitude);
            this.DataPage.Controls.Add(this.lblLatitude);
            this.DataPage.Controls.Add(this.label15);
            this.DataPage.Controls.Add(this.label14);
            this.DataPage.Controls.Add(this.lblHeadlandDistanceFromTool);
            this.DataPage.Controls.Add(this.label7);
            this.DataPage.Controls.Add(this.lblHeadlandDistanceAway);
            this.DataPage.Controls.Add(this.lblBoundaryArea);
            this.DataPage.Controls.Add(this.lblRoll);
            this.DataPage.Controls.Add(this.lblGPSHeading);
            this.DataPage.Controls.Add(this.lblGyroHeading);
            this.DataPage.Controls.Add(this.tboxSentence);
            this.DataPage.Controls.Add(this.label10);
            this.DataPage.Controls.Add(this.label9);
            this.DataPage.Controls.Add(this.label8);
            this.DataPage.Controls.Add(this.lblEasting);
            this.DataPage.Controls.Add(this.lblNorthing);
            this.DataPage.Controls.Add(this.lblZone);
            this.DataPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DataPage.ImageIndex = 1;
            this.DataPage.Location = new System.Drawing.Point(4, 72);
            this.DataPage.Name = "DataPage";
            this.DataPage.Size = new System.Drawing.Size(406, 434);
            this.DataPage.TabIndex = 3;
            // 
            // lblBigElevation
            // 
            this.lblBigElevation.AutoSize = true;
            this.lblBigElevation.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigElevation.Location = new System.Drawing.Point(14, 345);
            this.lblBigElevation.Name = "lblBigElevation";
            this.lblBigElevation.Size = new System.Drawing.Size(192, 77);
            this.lblBigElevation.TabIndex = 184;
            this.lblBigElevation.Text = "356m";
            this.lblBigElevation.Visible = false;
            // 
            // lblSats
            // 
            this.lblSats.AutoSize = true;
            this.lblSats.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSats.Location = new System.Drawing.Point(375, 7);
            this.lblSats.Name = "lblSats";
            this.lblSats.Size = new System.Drawing.Size(19, 19);
            this.lblSats.TabIndex = 183;
            this.lblSats.Text = "S";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 23);
            this.label17.TabIndex = 182;
            this.label17.Text = "Fix:";
            // 
            // lblFixQuality
            // 
            this.lblFixQuality.AutoSize = true;
            this.lblFixQuality.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixQuality.Location = new System.Drawing.Point(278, 97);
            this.lblFixQuality.Name = "lblFixQuality";
            this.lblFixQuality.Size = new System.Drawing.Size(46, 23);
            this.lblFixQuality.TabIndex = 181;
            this.lblFixQuality.Text = "PPS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(230, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 23);
            this.label16.TabIndex = 180;
            this.label16.Text = "Elev:";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.Location = new System.Drawing.Point(278, 67);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(64, 23);
            this.lblAltitude.TabIndex = 179;
            this.lblAltitude.Text = "356m";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(28, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 23);
            this.label19.TabIndex = 178;
            this.label19.Text = "Lat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 23);
            this.label18.TabIndex = 177;
            this.label18.Text = "Long:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(67, 97);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(124, 23);
            this.lblLongitude.TabIndex = 176;
            this.lblLongitude.Text = "111.253475";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(67, 67);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(112, 23);
            this.lblLatitude.TabIndex = 175;
            this.lblLatitude.Text = "53.234455";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(225, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 174;
            this.label15.Text = "Pivot:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(229, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 23);
            this.label14.TabIndex = 173;
            this.label14.Text = "Tool:";
            // 
            // lblHeadlandDistanceFromTool
            // 
            this.lblHeadlandDistanceFromTool.AutoSize = true;
            this.lblHeadlandDistanceFromTool.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadlandDistanceFromTool.Location = new System.Drawing.Point(276, 203);
            this.lblHeadlandDistanceFromTool.Name = "lblHeadlandDistanceFromTool";
            this.lblHeadlandDistanceFromTool.Size = new System.Drawing.Size(34, 23);
            this.lblHeadlandDistanceFromTool.TabIndex = 172;
            this.lblHeadlandDistanceFromTool.Text = "55";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 169;
            this.label7.Text = "Boundary:";
            // 
            // lblHeadlandDistanceAway
            // 
            this.lblHeadlandDistanceAway.AutoSize = true;
            this.lblHeadlandDistanceAway.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadlandDistanceAway.Location = new System.Drawing.Point(276, 174);
            this.lblHeadlandDistanceAway.Name = "lblHeadlandDistanceAway";
            this.lblHeadlandDistanceAway.Size = new System.Drawing.Size(34, 23);
            this.lblHeadlandDistanceAway.TabIndex = 168;
            this.lblHeadlandDistanceAway.Text = "45";
            // 
            // lblBoundaryArea
            // 
            this.lblBoundaryArea.AutoSize = true;
            this.lblBoundaryArea.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoundaryArea.Location = new System.Drawing.Point(276, 145);
            this.lblBoundaryArea.Name = "lblBoundaryArea";
            this.lblBoundaryArea.Size = new System.Drawing.Size(34, 23);
            this.lblBoundaryArea.TabIndex = 166;
            this.lblBoundaryArea.Text = "46";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(69, 203);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(40, 23);
            this.lblRoll.TabIndex = 138;
            this.lblRoll.Text = "1.2";
            // 
            // lblGPSHeading
            // 
            this.lblGPSHeading.AutoSize = true;
            this.lblGPSHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSHeading.Location = new System.Drawing.Point(69, 174);
            this.lblGPSHeading.Name = "lblGPSHeading";
            this.lblGPSHeading.Size = new System.Drawing.Size(52, 23);
            this.lblGPSHeading.TabIndex = 136;
            this.lblGPSHeading.Text = "99.3";
            // 
            // lblGyroHeading
            // 
            this.lblGyroHeading.AutoSize = true;
            this.lblGyroHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGyroHeading.Location = new System.Drawing.Point(69, 145);
            this.lblGyroHeading.Name = "lblGyroHeading";
            this.lblGyroHeading.Size = new System.Drawing.Size(52, 23);
            this.lblGyroHeading.TabIndex = 135;
            this.lblGyroHeading.Text = "22.6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Roll:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Gyro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "GPS:";
            // 
            // zoomPage2
            // 
            this.zoomPage2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.zoomPage2.Controls.Add(this.openGLControlZoom);
            this.zoomPage2.Controls.Add(this.label6);
            this.zoomPage2.Controls.Add(this.lblZooom);
            this.zoomPage2.Controls.Add(this.label5);
            this.zoomPage2.Controls.Add(this.label4);
            this.zoomPage2.Controls.Add(this.lblFieldWidthEastWest);
            this.zoomPage2.Controls.Add(this.lblFieldWidthNorthSouth);
            this.zoomPage2.ImageIndex = 3;
            this.zoomPage2.Location = new System.Drawing.Point(4, 72);
            this.zoomPage2.Name = "zoomPage2";
            this.zoomPage2.Padding = new System.Windows.Forms.Padding(3);
            this.zoomPage2.Size = new System.Drawing.Size(406, 434);
            this.zoomPage2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(285, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 155;
            this.label6.Text = "Z";
            // 
            // lblZooom
            // 
            this.lblZooom.AutoSize = true;
            this.lblZooom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblZooom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZooom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblZooom.Location = new System.Drawing.Point(303, 406);
            this.lblZooom.Name = "lblZooom";
            this.lblZooom.Size = new System.Drawing.Size(46, 23);
            this.lblZooom.TabIndex = 154;
            this.lblZooom.Text = "0.00";
            // 
            // ratePage3
            // 
            this.ratePage3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ratePage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ratePage3.Controls.Add(this.btnRateConfig);
            this.ratePage3.Controls.Add(this.btnRateDn);
            this.ratePage3.Controls.Add(this.label2);
            this.ratePage3.Controls.Add(this.label1);
            this.ratePage3.Controls.Add(this.lblRateAppliedActual);
            this.ratePage3.Controls.Add(this.lblAccumulatedVolume);
            this.ratePage3.Controls.Add(this.btnRateUp);
            this.ratePage3.Controls.Add(this.btnRate);
            this.ratePage3.Controls.Add(this.btnRate2Select);
            this.ratePage3.Controls.Add(this.btnRate1Select);
            this.ratePage3.ImageIndex = 2;
            this.ratePage3.Location = new System.Drawing.Point(4, 72);
            this.ratePage3.Name = "ratePage3";
            this.ratePage3.Size = new System.Drawing.Size(406, 434);
            this.ratePage3.TabIndex = 2;
            // 
            // btnRateConfig
            // 
            this.btnRateConfig.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRateConfig.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateConfig.Image = global::AgOpenGPS.Properties.Resources.Settings48;
            this.btnRateConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRateConfig.Location = new System.Drawing.Point(307, 44);
            this.btnRateConfig.Name = "btnRateConfig";
            this.btnRateConfig.Size = new System.Drawing.Size(84, 94);
            this.btnRateConfig.TabIndex = 176;
            this.btnRateConfig.Text = "Config";
            this.btnRateConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRateConfig.UseVisualStyleBackColor = false;
            this.btnRateConfig.Click += new System.EventHandler(this.btnRateConfig_Click);
            // 
            // btnRateDn
            // 
            this.btnRateDn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRateDn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateDn.Image = ((System.Drawing.Image)(resources.GetObject("btnRateDn.Image")));
            this.btnRateDn.Location = new System.Drawing.Point(307, 321);
            this.btnRateDn.Name = "btnRateDn";
            this.btnRateDn.Size = new System.Drawing.Size(73, 80);
            this.btnRateDn.TabIndex = 148;
            this.btnRateDn.UseVisualStyleBackColor = true;
            this.btnRateDn.Visible = false;
            this.btnRateDn.Click += new System.EventHandler(this.btnRateDn_Click);
            // 
            // btnRateUp
            // 
            this.btnRateUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRateUp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateUp.Image = ((System.Drawing.Image)(resources.GetObject("btnRateUp.Image")));
            this.btnRateUp.Location = new System.Drawing.Point(307, 215);
            this.btnRateUp.Name = "btnRateUp";
            this.btnRateUp.Size = new System.Drawing.Size(73, 80);
            this.btnRateUp.TabIndex = 149;
            this.btnRateUp.UseVisualStyleBackColor = true;
            this.btnRateUp.Visible = false;
            this.btnRateUp.Click += new System.EventHandler(this.btnRateUp_Click);
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRate.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnRate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.Image = ((System.Drawing.Image)(resources.GetObject("btnRate.Image")));
            this.btnRate.Location = new System.Drawing.Point(147, 40);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(107, 98);
            this.btnRate.TabIndex = 143;
            this.btnRate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnRate2Select
            // 
            this.btnRate2Select.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRate2Select.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate2Select.Image = ((System.Drawing.Image)(resources.GetObject("btnRate2Select.Image")));
            this.btnRate2Select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRate2Select.Location = new System.Drawing.Point(148, 254);
            this.btnRate2Select.Name = "btnRate2Select";
            this.btnRate2Select.Size = new System.Drawing.Size(107, 96);
            this.btnRate2Select.TabIndex = 146;
            this.btnRate2Select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRate2Select.UseVisualStyleBackColor = false;
            this.btnRate2Select.Visible = false;
            this.btnRate2Select.Click += new System.EventHandler(this.btnRate2Select_Click);
            // 
            // btnRate1Select
            // 
            this.btnRate1Select.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRate1Select.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate1Select.Image = ((System.Drawing.Image)(resources.GetObject("btnRate1Select.Image")));
            this.btnRate1Select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRate1Select.Location = new System.Drawing.Point(18, 253);
            this.btnRate1Select.Name = "btnRate1Select";
            this.btnRate1Select.Size = new System.Drawing.Size(107, 96);
            this.btnRate1Select.TabIndex = 145;
            this.btnRate1Select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRate1Select.UseVisualStyleBackColor = false;
            this.btnRate1Select.Visible = false;
            this.btnRate1Select.Click += new System.EventHandler(this.btnRate1Select_Click);
            // 
            // configPage1
            // 
            this.configPage1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.configPage1.Controls.Add(this.btnSettings);
            this.configPage1.Controls.Add(this.btnAutoYouTurn);
            this.configPage1.Controls.Add(this.btnAutoSteerConfig);
            this.configPage1.Controls.Add(this.btnUnits);
            this.configPage1.Controls.Add(this.btnFileExplorer);
            this.configPage1.Controls.Add(this.btnUdpSettings);
            this.configPage1.Controls.Add(this.btnComm);
            this.configPage1.Controls.Add(this.btnGPSData);
            this.configPage1.Controls.Add(this.btnPerimeter);
            this.configPage1.ImageIndex = 0;
            this.configPage1.Location = new System.Drawing.Point(4, 72);
            this.configPage1.Name = "configPage1";
            this.configPage1.Padding = new System.Windows.Forms.Padding(3);
            this.configPage1.Size = new System.Drawing.Size(406, 434);
            this.configPage1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSettings.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(295, 282);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 91);
            this.btnSettings.TabIndex = 135;
            this.btnSettings.Text = "Config";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnAutoYouTurn
            // 
            this.btnAutoYouTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoYouTurn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutoYouTurn.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnAutoYouTurn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoYouTurn.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoYouTurn.Image")));
            this.btnAutoYouTurn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAutoYouTurn.Location = new System.Drawing.Point(157, 282);
            this.btnAutoYouTurn.Name = "btnAutoYouTurn";
            this.btnAutoYouTurn.Size = new System.Drawing.Size(100, 91);
            this.btnAutoYouTurn.TabIndex = 142;
            this.btnAutoYouTurn.Text = "Config";
            this.btnAutoYouTurn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutoYouTurn.UseVisualStyleBackColor = false;
            this.btnAutoYouTurn.Click += new System.EventHandler(this.btnAutoYouTurn_Click);
            // 
            // btnAutoSteerConfig
            // 
            this.btnAutoSteerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoSteerConfig.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAutoSteerConfig.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAutoSteerConfig.FlatAppearance.BorderSize = 2;
            this.btnAutoSteerConfig.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoSteerConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoSteerConfig.Image")));
            this.btnAutoSteerConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAutoSteerConfig.Location = new System.Drawing.Point(19, 282);
            this.btnAutoSteerConfig.Name = "btnAutoSteerConfig";
            this.btnAutoSteerConfig.Size = new System.Drawing.Size(100, 91);
            this.btnAutoSteerConfig.TabIndex = 139;
            this.btnAutoSteerConfig.Text = "Config";
            this.btnAutoSteerConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutoSteerConfig.UseVisualStyleBackColor = false;
            this.btnAutoSteerConfig.Click += new System.EventHandler(this.btnAutoSteerConfig_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUnits.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnUnits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.Image = ((System.Drawing.Image)(resources.GetObject("btnUnits.Image")));
            this.btnUnits.Location = new System.Drawing.Point(157, 16);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(100, 100);
            this.btnUnits.TabIndex = 142;
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnits.UseVisualStyleBackColor = false;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFileExplorer.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnFileExplorer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileExplorer.Image = ((System.Drawing.Image)(resources.GetObject("btnFileExplorer.Image")));
            this.btnFileExplorer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFileExplorer.Location = new System.Drawing.Point(19, 16);
            this.btnFileExplorer.Name = "btnFileExplorer";
            this.btnFileExplorer.Size = new System.Drawing.Size(100, 100);
            this.btnFileExplorer.TabIndex = 141;
            this.btnFileExplorer.Text = "Files";
            this.btnFileExplorer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFileExplorer.UseVisualStyleBackColor = false;
            this.btnFileExplorer.Click += new System.EventHandler(this.btnFileExplorer_Click);
            // 
            // btnUdpSettings
            // 
            this.btnUdpSettings.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUdpSettings.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnUdpSettings.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUdpSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnUdpSettings.Image")));
            this.btnUdpSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUdpSettings.Location = new System.Drawing.Point(19, 146);
            this.btnUdpSettings.Name = "btnUdpSettings";
            this.btnUdpSettings.Size = new System.Drawing.Size(100, 100);
            this.btnUdpSettings.TabIndex = 140;
            this.btnUdpSettings.Text = "UDP";
            this.btnUdpSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUdpSettings.UseVisualStyleBackColor = false;
            this.btnUdpSettings.Click += new System.EventHandler(this.btnUDPSettings_Click);
            // 
            // btnComm
            // 
            this.btnComm.BackColor = System.Drawing.Color.AliceBlue;
            this.btnComm.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnComm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComm.Image = ((System.Drawing.Image)(resources.GetObject("btnComm.Image")));
            this.btnComm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComm.Location = new System.Drawing.Point(295, 146);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(100, 100);
            this.btnComm.TabIndex = 136;
            this.btnComm.Text = "Ports";
            this.btnComm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComm.UseVisualStyleBackColor = false;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // btnGPSData
            // 
            this.btnGPSData.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGPSData.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnGPSData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPSData.Image = ((System.Drawing.Image)(resources.GetObject("btnGPSData.Image")));
            this.btnGPSData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGPSData.Location = new System.Drawing.Point(295, 16);
            this.btnGPSData.Name = "btnGPSData";
            this.btnGPSData.Size = new System.Drawing.Size(100, 100);
            this.btnGPSData.TabIndex = 138;
            this.btnGPSData.Text = "GPS";
            this.btnGPSData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGPSData.UseVisualStyleBackColor = false;
            this.btnGPSData.Click += new System.EventHandler(this.btnGPSData_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPerimeter.ContextMenuStrip = this.contextMenuArea;
            this.btnPerimeter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeter.Image = ((System.Drawing.Image)(resources.GetObject("btnPerimeter.Image")));
            this.btnPerimeter.Location = new System.Drawing.Point(153, 146);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(115, 100);
            this.btnPerimeter.TabIndex = 108;
            this.btnPerimeter.Text = "000.00";
            this.btnPerimeter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerimeter.UseVisualStyleBackColor = false;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // lblPureSteerAngle
            // 
            this.lblPureSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPureSteerAngle.AutoSize = true;
            this.lblPureSteerAngle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPureSteerAngle.Location = new System.Drawing.Point(1008, -4);
            this.lblPureSteerAngle.Name = "lblPureSteerAngle";
            this.lblPureSteerAngle.Size = new System.Drawing.Size(107, 39);
            this.lblPureSteerAngle.TabIndex = 137;
            this.lblPureSteerAngle.Text = "88.88";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(368, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 171;
            this.label12.Text = "H J K";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 170;
            this.label11.Text = "B N M";
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSteerAngle.AutoSize = true;
            this.lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.Location = new System.Drawing.Point(86, 32);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(19, 19);
            this.lblSteerAngle.TabIndex = 163;
            this.lblSteerAngle.Text = "0";
            // 
            // tbarSteerAngle
            // 
            this.tbarSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarSteerAngle.LargeChange = 10;
            this.tbarSteerAngle.Location = new System.Drawing.Point(4, 6);
            this.tbarSteerAngle.Maximum = 300;
            this.tbarSteerAngle.Minimum = -300;
            this.tbarSteerAngle.Name = "tbarSteerAngle";
            this.tbarSteerAngle.RightToLeftLayout = true;
            this.tbarSteerAngle.Size = new System.Drawing.Size(181, 45);
            this.tbarSteerAngle.TabIndex = 161;
            this.tbarSteerAngle.TickFrequency = 30;
            this.tbarSteerAngle.Scroll += new System.EventHandler(this.tbarSteerAngle_Scroll);
            // 
            // tbarStepDistance
            // 
            this.tbarStepDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarStepDistance.LargeChange = 10;
            this.tbarStepDistance.Location = new System.Drawing.Point(308, 9);
            this.tbarStepDistance.Maximum = 300;
            this.tbarStepDistance.Name = "tbarStepDistance";
            this.tbarStepDistance.Size = new System.Drawing.Size(95, 45);
            this.tbarStepDistance.TabIndex = 160;
            this.tbarStepDistance.TickFrequency = 10;
            this.tbarStepDistance.Value = 20;
            this.tbarStepDistance.Scroll += new System.EventHandler(this.tbarStepDistance_Scroll);
            // 
            // btnResetSteerAngle
            // 
            this.btnResetSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSteerAngle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetSteerAngle.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnResetSteerAngle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSteerAngle.Location = new System.Drawing.Point(183, 9);
            this.btnResetSteerAngle.Name = "btnResetSteerAngle";
            this.btnResetSteerAngle.Size = new System.Drawing.Size(52, 40);
            this.btnResetSteerAngle.TabIndex = 162;
            this.btnResetSteerAngle.Text = ">0<";
            this.btnResetSteerAngle.UseVisualStyleBackColor = false;
            this.btnResetSteerAngle.Click += new System.EventHandler(this.btnResetSteerAngle_Click);
            // 
            // btnResetSim
            // 
            this.btnResetSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResetSim.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnResetSim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSim.Location = new System.Drawing.Point(253, 9);
            this.btnResetSim.Name = "btnResetSim";
            this.btnResetSim.Size = new System.Drawing.Size(52, 40);
            this.btnResetSim.TabIndex = 164;
            this.btnResetSim.Text = "Reset";
            this.btnResetSim.UseVisualStyleBackColor = false;
            this.btnResetSim.Click += new System.EventHandler(this.btnResetSim_Click);
            // 
            // timerSim
            // 
            this.timerSim.Enabled = true;
            this.timerSim.Interval = 200;
            this.timerSim.Tick += new System.EventHandler(this.timerSim_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(334, 62);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // panelSimControls
            // 
            this.panelSimControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSimControls.Controls.Add(this.label3);
            this.panelSimControls.Controls.Add(this.btnResetSteerAngle);
            this.panelSimControls.Controls.Add(this.btnResetSim);
            this.panelSimControls.Controls.Add(this.lblSteerAngle);
            this.panelSimControls.Controls.Add(this.label11);
            this.panelSimControls.Controls.Add(this.label12);
            this.panelSimControls.Controls.Add(this.tbarSteerAngle);
            this.panelSimControls.Controls.Add(this.tbarStepDistance);
            this.panelSimControls.Location = new System.Drawing.Point(707, 554);
            this.panelSimControls.Name = "panelSimControls";
            this.panelSimControls.Size = new System.Drawing.Size(407, 60);
            this.panelSimControls.TabIndex = 172;
            this.panelSimControls.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 172;
            this.label3.Text = "L";
            // 
            // btnLeftYouTurn
            // 
            this.btnLeftYouTurn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLeftYouTurn.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnLeftYouTurn.Enabled = false;
            this.btnLeftYouTurn.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftYouTurn.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftYouTurn.Image")));
            this.btnLeftYouTurn.Location = new System.Drawing.Point(164, 119);
            this.btnLeftYouTurn.Name = "btnLeftYouTurn";
            this.btnLeftYouTurn.Size = new System.Drawing.Size(64, 64);
            this.btnLeftYouTurn.TabIndex = 143;
            this.btnLeftYouTurn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeftYouTurn.UseVisualStyleBackColor = false;
            this.btnLeftYouTurn.Click += new System.EventHandler(this.btnLeftYouTurn_Click);
            // 
            // btnTiltDown
            // 
            this.btnTiltDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiltDown.BackColor = System.Drawing.Color.Lavender;
            this.btnTiltDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiltDown.BackgroundImage")));
            this.btnTiltDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiltDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiltDown.Location = new System.Drawing.Point(805, 614);
            this.btnTiltDown.Name = "btnTiltDown";
            this.btnTiltDown.Size = new System.Drawing.Size(85, 52);
            this.btnTiltDown.TabIndex = 122;
            this.btnTiltDown.UseVisualStyleBackColor = false;
            this.btnTiltDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTiltDown_MouseDown);
            // 
            // btnTiltUp
            // 
            this.btnTiltUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiltUp.BackColor = System.Drawing.Color.Lavender;
            this.btnTiltUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiltUp.BackgroundImage")));
            this.btnTiltUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiltUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiltUp.Location = new System.Drawing.Point(708, 614);
            this.btnTiltUp.Name = "btnTiltUp";
            this.btnTiltUp.Size = new System.Drawing.Size(85, 52);
            this.btnTiltUp.TabIndex = 123;
            this.btnTiltUp.UseVisualStyleBackColor = false;
            this.btnTiltUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTiltUp_MouseDown);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackColor = System.Drawing.Color.Lavender;
            this.btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.BackgroundImage")));
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(922, 614);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(85, 52);
            this.btnZoomIn.TabIndex = 120;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackColor = System.Drawing.Color.Lavender;
            this.btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.BackgroundImage")));
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(1030, 614);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(85, 52);
            this.btnZoomOut.TabIndex = 119;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            // 
            // btnSwapDirection
            // 
            this.btnSwapDirection.BackColor = System.Drawing.Color.Lavender;
            this.btnSwapDirection.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnSwapDirection.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapDirection.Image = ((System.Drawing.Image)(resources.GetObject("btnSwapDirection.Image")));
            this.btnSwapDirection.Location = new System.Drawing.Point(5, 171);
            this.btnSwapDirection.Name = "btnSwapDirection";
            this.btnSwapDirection.Size = new System.Drawing.Size(96, 80);
            this.btnSwapDirection.TabIndex = 153;
            this.btnSwapDirection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSwapDirection.UseVisualStyleBackColor = false;
            this.btnSwapDirection.Click += new System.EventHandler(this.btnSwapDirection_Click);
            // 
            // btnEnableAutoYouTurn
            // 
            this.btnEnableAutoYouTurn.BackColor = System.Drawing.Color.Lavender;
            this.btnEnableAutoYouTurn.Enabled = false;
            this.btnEnableAutoYouTurn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableAutoYouTurn.Image = ((System.Drawing.Image)(resources.GetObject("btnEnableAutoYouTurn.Image")));
            this.btnEnableAutoYouTurn.Location = new System.Drawing.Point(5, 363);
            this.btnEnableAutoYouTurn.Name = "btnEnableAutoYouTurn";
            this.btnEnableAutoYouTurn.Size = new System.Drawing.Size(96, 96);
            this.btnEnableAutoYouTurn.TabIndex = 132;
            this.btnEnableAutoYouTurn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnableAutoYouTurn.UseVisualStyleBackColor = false;
            this.btnEnableAutoYouTurn.Click += new System.EventHandler(this.btnEnableAutoYouTurn_Click);
            // 
            // btnSectionOffAutoOn
            // 
            this.btnSectionOffAutoOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSectionOffAutoOn.BackColor = System.Drawing.Color.Lavender;
            this.btnSectionOffAutoOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSectionOffAutoOn.Enabled = false;
            this.btnSectionOffAutoOn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionOffAutoOn.Image = ((System.Drawing.Image)(resources.GetObject("btnSectionOffAutoOn.Image")));
            this.btnSectionOffAutoOn.Location = new System.Drawing.Point(589, 455);
            this.btnSectionOffAutoOn.Name = "btnSectionOffAutoOn";
            this.btnSectionOffAutoOn.Size = new System.Drawing.Size(109, 113);
            this.btnSectionOffAutoOn.TabIndex = 152;
            this.btnSectionOffAutoOn.Text = "888.8";
            this.btnSectionOffAutoOn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSectionOffAutoOn.UseVisualStyleBackColor = false;
            this.btnSectionOffAutoOn.Click += new System.EventHandler(this.btnSectionOffAutoOn_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.BackColor = System.Drawing.Color.Lavender;
            this.btnFlag.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnFlag.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlag.Image = ((System.Drawing.Image)(resources.GetObject("btnFlag.Image")));
            this.btnFlag.Location = new System.Drawing.Point(5, 259);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(96, 96);
            this.btnFlag.TabIndex = 121;
            this.btnFlag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlag.UseVisualStyleBackColor = false;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.Lavender;
            this.btnSnap.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnSnap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnap.Image = ((System.Drawing.Image)(resources.GetObject("btnSnap.Image")));
            this.btnSnap.Location = new System.Drawing.Point(5, 83);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(96, 80);
            this.btnSnap.TabIndex = 132;
            this.btnSnap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // btnAutoSteer
            // 
            this.btnAutoSteer.BackColor = System.Drawing.Color.Lavender;
            this.btnAutoSteer.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnAutoSteer.Enabled = false;
            this.btnAutoSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoSteer.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoSteer.Image")));
            this.btnAutoSteer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAutoSteer.Location = new System.Drawing.Point(5, 467);
            this.btnAutoSteer.Name = "btnAutoSteer";
            this.btnAutoSteer.Size = new System.Drawing.Size(96, 96);
            this.btnAutoSteer.TabIndex = 128;
            this.btnAutoSteer.Text = "x";
            this.btnAutoSteer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAutoSteer.UseVisualStyleBackColor = false;
            this.btnAutoSteer.Click += new System.EventHandler(this.btnAutoSteer_Click);
            // 
            // btnRightYouTurn
            // 
            this.btnRightYouTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightYouTurn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRightYouTurn.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnRightYouTurn.Enabled = false;
            this.btnRightYouTurn.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightYouTurn.Image = ((System.Drawing.Image)(resources.GetObject("btnRightYouTurn.Image")));
            this.btnRightYouTurn.Location = new System.Drawing.Point(473, 119);
            this.btnRightYouTurn.Name = "btnRightYouTurn";
            this.btnRightYouTurn.Size = new System.Drawing.Size(64, 64);
            this.btnRightYouTurn.TabIndex = 142;
            this.btnRightYouTurn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRightYouTurn.UseVisualStyleBackColor = false;
            this.btnRightYouTurn.Click += new System.EventHandler(this.btnRightYouTurn_Click);
            // 
            // btnContour
            // 
            this.btnContour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContour.BackColor = System.Drawing.Color.Lavender;
            this.btnContour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContour.Enabled = false;
            this.btnContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContour.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContour.Image = ((System.Drawing.Image)(resources.GetObject("btnContour.Image")));
            this.btnContour.Location = new System.Drawing.Point(597, 207);
            this.btnContour.Name = "btnContour";
            this.btnContour.Size = new System.Drawing.Size(100, 100);
            this.btnContour.TabIndex = 105;
            this.btnContour.Text = "Contour";
            this.btnContour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContour.UseVisualStyleBackColor = false;
            this.btnContour.Click += new System.EventHandler(this.btnContour_Click);
            // 
            // btnManualOffOn
            // 
            this.btnManualOffOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManualOffOn.BackColor = System.Drawing.Color.Lavender;
            this.btnManualOffOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManualOffOn.Enabled = false;
            this.btnManualOffOn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnManualOffOn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualOffOn.Image = ((System.Drawing.Image)(resources.GetObject("btnManualOffOn.Image")));
            this.btnManualOffOn.Location = new System.Drawing.Point(597, 331);
            this.btnManualOffOn.Name = "btnManualOffOn";
            this.btnManualOffOn.Size = new System.Drawing.Size(100, 100);
            this.btnManualOffOn.TabIndex = 98;
            this.btnManualOffOn.UseVisualStyleBackColor = false;
            this.btnManualOffOn.Click += new System.EventHandler(this.btnManualOffOn_Click);
            // 
            // btnABLine
            // 
            this.btnABLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnABLine.BackColor = System.Drawing.Color.Lavender;
            this.btnABLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnABLine.Enabled = false;
            this.btnABLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABLine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABLine.Image = ((System.Drawing.Image)(resources.GetObject("btnABLine.Image")));
            this.btnABLine.Location = new System.Drawing.Point(597, 83);
            this.btnABLine.Name = "btnABLine";
            this.btnABLine.Size = new System.Drawing.Size(100, 100);
            this.btnABLine.TabIndex = 0;
            this.btnABLine.Text = "0";
            this.btnABLine.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnABLine.UseVisualStyleBackColor = false;
            this.btnABLine.Click += new System.EventHandler(this.btnABLine_Click);
            // 
            // btnSection8Man
            // 
            this.btnSection8Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection8Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection8Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection8Man.Enabled = false;
            this.btnSection8Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection8Man.FlatAppearance.BorderSize = 0;
            this.btnSection8Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection8Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection8Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection8Man.Image")));
            this.btnSection8Man.Location = new System.Drawing.Point(159, 377);
            this.btnSection8Man.Name = "btnSection8Man";
            this.btnSection8Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection8Man.TabIndex = 125;
            this.btnSection8Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection8Man.UseVisualStyleBackColor = false;
            this.btnSection8Man.Click += new System.EventHandler(this.btnSection8Man_Click);
            // 
            // btnSection7Man
            // 
            this.btnSection7Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection7Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection7Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection7Man.Enabled = false;
            this.btnSection7Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection7Man.FlatAppearance.BorderSize = 0;
            this.btnSection7Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection7Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection7Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection7Man.Image")));
            this.btnSection7Man.Location = new System.Drawing.Point(149, 365);
            this.btnSection7Man.Name = "btnSection7Man";
            this.btnSection7Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection7Man.TabIndex = 126;
            this.btnSection7Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection7Man.UseVisualStyleBackColor = false;
            this.btnSection7Man.Click += new System.EventHandler(this.btnSection7Man_Click);
            // 
            // btnSection6Man
            // 
            this.btnSection6Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection6Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection6Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection6Man.Enabled = false;
            this.btnSection6Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection6Man.FlatAppearance.BorderSize = 0;
            this.btnSection6Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection6Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection6Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection6Man.Image")));
            this.btnSection6Man.Location = new System.Drawing.Point(139, 352);
            this.btnSection6Man.Name = "btnSection6Man";
            this.btnSection6Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection6Man.TabIndex = 127;
            this.btnSection6Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection6Man.UseVisualStyleBackColor = false;
            this.btnSection6Man.Click += new System.EventHandler(this.btnSection6Man_Click);
            // 
            // btnSection5Man
            // 
            this.btnSection5Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection5Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection5Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection5Man.Enabled = false;
            this.btnSection5Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection5Man.FlatAppearance.BorderSize = 0;
            this.btnSection5Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection5Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection5Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection5Man.Image")));
            this.btnSection5Man.Location = new System.Drawing.Point(130, 339);
            this.btnSection5Man.Name = "btnSection5Man";
            this.btnSection5Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection5Man.TabIndex = 103;
            this.btnSection5Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection5Man.UseVisualStyleBackColor = false;
            this.btnSection5Man.Click += new System.EventHandler(this.btnSection5Man_Click);
            // 
            // btnSection4Man
            // 
            this.btnSection4Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection4Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection4Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection4Man.Enabled = false;
            this.btnSection4Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection4Man.FlatAppearance.BorderSize = 0;
            this.btnSection4Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection4Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection4Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection4Man.Image")));
            this.btnSection4Man.Location = new System.Drawing.Point(159, 284);
            this.btnSection4Man.Name = "btnSection4Man";
            this.btnSection4Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection4Man.TabIndex = 102;
            this.btnSection4Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection4Man.UseVisualStyleBackColor = false;
            this.btnSection4Man.Click += new System.EventHandler(this.btnSection4Man_Click);
            // 
            // btnSection3Man
            // 
            this.btnSection3Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection3Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection3Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection3Man.Enabled = false;
            this.btnSection3Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection3Man.FlatAppearance.BorderSize = 0;
            this.btnSection3Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection3Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection3Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection3Man.Image")));
            this.btnSection3Man.Location = new System.Drawing.Point(149, 271);
            this.btnSection3Man.Name = "btnSection3Man";
            this.btnSection3Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection3Man.TabIndex = 101;
            this.btnSection3Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection3Man.UseVisualStyleBackColor = false;
            this.btnSection3Man.Click += new System.EventHandler(this.btnSection3Man_Click);
            // 
            // btnSection2Man
            // 
            this.btnSection2Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection2Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection2Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection2Man.Enabled = false;
            this.btnSection2Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection2Man.FlatAppearance.BorderSize = 0;
            this.btnSection2Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection2Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection2Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection2Man.Image")));
            this.btnSection2Man.Location = new System.Drawing.Point(140, 258);
            this.btnSection2Man.Name = "btnSection2Man";
            this.btnSection2Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection2Man.TabIndex = 100;
            this.btnSection2Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection2Man.UseVisualStyleBackColor = false;
            this.btnSection2Man.Click += new System.EventHandler(this.btnSection2Man_Click);
            // 
            // btnSection1Man
            // 
            this.btnSection1Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSection1Man.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSection1Man.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSection1Man.Enabled = false;
            this.btnSection1Man.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSection1Man.FlatAppearance.BorderSize = 0;
            this.btnSection1Man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection1Man.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection1Man.Image = ((System.Drawing.Image)(resources.GetObject("btnSection1Man.Image")));
            this.btnSection1Man.Location = new System.Drawing.Point(129, 245);
            this.btnSection1Man.Name = "btnSection1Man";
            this.btnSection1Man.Size = new System.Drawing.Size(69, 53);
            this.btnSection1Man.TabIndex = 99;
            this.btnSection1Man.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSection1Man.UseVisualStyleBackColor = false;
            this.btnSection1Man.Click += new System.EventHandler(this.btnSection1Man_Click);
            // 
            // FormGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1120, 708);
            this.Controls.Add(this.btnLeftYouTurn);
            this.Controls.Add(this.btnTiltDown);
            this.Controls.Add(this.btnTiltUp);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSwapDirection);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnEnableAutoYouTurn);
            this.Controls.Add(this.lblPureSteerAngle);
            this.Controls.Add(this.btnSectionOffAutoOn);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.btnAutoSteer);
            this.Controls.Add(this.btnRightYouTurn);
            this.Controls.Add(this.btnContour);
            this.Controls.Add(this.btnManualOffOn);
            this.Controls.Add(this.btnABLine);
            this.Controls.Add(this.lblSpeedUnits);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtDistanceOffABLine);
            this.Controls.Add(this.btnSection8Man);
            this.Controls.Add(this.btnSection7Man);
            this.Controls.Add(this.btnSection6Man);
            this.Controls.Add(this.btnSection5Man);
            this.Controls.Add(this.btnSection4Man);
            this.Controls.Add(this.btnSection3Man);
            this.Controls.Add(this.btnSection2Man);
            this.Controls.Add(this.btnSection1Man);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.openGLControlBack);
            this.Controls.Add(this.panelSimControls);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(520, 600);
            this.Name = "FormGPS";
            this.Text = "AgOpenGPS - Cuz Retail Sucks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGPS_FormClosing);
            this.Load += new System.EventHandler(this.FormGPS_Load);
            this.Resize += new System.EventHandler(this.FormGPS_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.contextMenuStripOpenGL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripFlag.ResumeLayout(false);
            this.contextMenuArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlZoom)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DataPage.ResumeLayout(false);
            this.DataPage.PerformLayout();
            this.zoomPage2.ResumeLayout(false);
            this.zoomPage2.PerformLayout();
            this.ratePage3.ResumeLayout(false);
            this.ratePage3.PerformLayout();
            this.configPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            this.panelSimControls.ResumeLayout(false);
            this.panelSimControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button btnABLine;
        private System.Windows.Forms.TextBox txtDistanceOffABLine;
        private SharpGL.OpenGLControl openGLControlBack;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer tmrWatchdog;
        private System.Windows.Forms.ToolStripMenuItem polygonsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripDistance;
        private System.Windows.Forms.ToolStripStatusLabel stripPortGPS;
        private System.Windows.Forms.ToolStripStatusLabel stripAreaRate;
        private System.Windows.Forms.ToolStripStatusLabel stripPortArduino;
        private System.Windows.Forms.ToolStripMenuItem resetALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVehicleToolStripMenuItem;
        private System.Windows.Forms.Button btnManualOffOn;
        private System.Windows.Forms.Button btnSection1Man;
        private System.Windows.Forms.Button btnSection2Man;
        private System.Windows.Forms.Button btnSection3Man;
        private System.Windows.Forms.Button btnSection4Man;
        private System.Windows.Forms.Button btnSection5Man;
        private System.Windows.Forms.Button btnContour;
        private System.Windows.Forms.ToolStripStatusLabel stripHz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldViewerToolStripMenuItem;
        private System.Windows.Forms.Label lblNorthing;
        private System.Windows.Forms.Label lblEasting;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ToolStripMenuItem googleEarthToolStripMenuItem;
        private ProXoft.WinForms.RepeatButton btnZoomOut;
        private ProXoft.WinForms.RepeatButton btnZoomIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlag;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFlagRed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagGrn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagYel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private ProXoft.WinForms.RepeatButton btnTiltUp;
        private ProXoft.WinForms.RepeatButton btnTiltDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagDeleteAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOpenGL;
        private System.Windows.Forms.ToolStripMenuItem deleteFlagToolOpenGLContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem googleEarthOpenGLContextMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuArea;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAreaSide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem gPSDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar stripOnlineGPS;
        private System.Windows.Forms.ToolStripProgressBar stripOnlineArduino;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem1;
        private System.Windows.Forms.Button btnSection8Man;
        private System.Windows.Forms.Button btnSection7Man;
        private System.Windows.Forms.Button btnSection6Man;
        private System.Windows.Forms.ToolStripStatusLabel stripPortAutoSteer;
        private System.Windows.Forms.ToolStripProgressBar stripOnlineAutoSteer;
        private System.Windows.Forms.ToolStripMenuItem logNMEAMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripUnitsMenu;
        private System.Windows.Forms.ToolStripMenuItem metricToolStrip;
        private System.Windows.Forms.ToolStripMenuItem imperialToolStrip;
        private System.Windows.Forms.ToolStripMenuItem skyToolStripMenu;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.TextBox tboxSentence;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Button btnAutoSteerConfig;
        private System.Windows.Forms.Button btnGPSData;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFileExplorer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuHelpHelp;
        private System.Windows.Forms.Label lblSpeedUnits;
        private System.Windows.Forms.ToolStripMenuItem sideGuideLines;
        private System.Windows.Forms.ToolStripMenuItem pursuitLineToolStripMenuItem;
        private System.Windows.Forms.Button btnRightYouTurn;
        private System.Windows.Forms.Button btnLeftYouTurn;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnRate1Select;
        private System.Windows.Forms.Button btnRate2Select;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblAccumulatedVolume;
        private System.Windows.Forms.Label lblRateAppliedActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoSteer;
        private System.Windows.Forms.Button btnAutoYouTurn;
        private System.Windows.Forms.Button btnFlag;
        private ProXoft.WinForms.RepeatButton btnRateDn;
        private ProXoft.WinForms.RepeatButton btnRateUp;
        private SharpGL.OpenGLControl openGLControlZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFieldWidthNorthSouth;
        private System.Windows.Forms.Label lblFieldWidthEastWest;
        private System.Windows.Forms.Button btnUdpSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage configPage1;
        private System.Windows.Forms.TabPage zoomPage2;
        private System.Windows.Forms.TabPage ratePage3;
        private System.Windows.Forms.TabPage DataPage;
        private System.Windows.Forms.Button btnEnableAutoYouTurn;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZooom;
        private System.Windows.Forms.Timer timerSim;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.TrackBar tbarSteerAngle;
        private System.Windows.Forms.Button btnResetSteerAngle;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Button btnResetSim;
        private System.Windows.Forms.ToolStripMenuItem simulatorOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnFuncs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblPureSteerAngle;
        private System.Windows.Forms.Label lblGPSHeading;
        private System.Windows.Forms.Label lblGyroHeading;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolstripUSBPortsConfig;
        private System.Windows.Forms.ToolStripMenuItem toolstripVehicleConfig;
        private System.Windows.Forms.ToolStripMenuItem toolstripAutoSteerConfig;
        private System.Windows.Forms.ToolStripMenuItem toolstripYouTurnConfig;
        private System.Windows.Forms.ToolStripMenuItem toolstripResetTrip;
        private System.Windows.Forms.ToolStripMenuItem toolstripField;
        private System.Windows.Forms.ToolStripMenuItem toolstripBoundary;
        private System.Windows.Forms.ToolStripMenuItem toolstripHeadland;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnSwapDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHeadlandDistanceAway;
        private System.Windows.Forms.Label lblBoundaryArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHeadlandDistanceFromTool;
        private System.Windows.Forms.ToolStripMenuItem toolstripUDPConfig;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblSats;
        private System.Windows.Forms.Panel panelSimControls;
        private System.Windows.Forms.ToolStripDropDownButton btnHideTabs;
        public System.Windows.Forms.Button btnSectionOffAutoOn;
        private System.Windows.Forms.ToolStripStatusLabel stripAreaUser;
        private System.Windows.Forms.ToolStripStatusLabel stripEqWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel stripSequenceBinary;
        private System.Windows.Forms.ToolStripMenuItem bigAltitudeToolStripMenuItem;
        private System.Windows.Forms.Label lblBigElevation;
        private System.Windows.Forms.Button btnRateConfig;
    }
}

