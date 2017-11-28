namespace SteerSim
{
    partial class FormSteerSim
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNMEA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHz = new System.Windows.Forms.NumericUpDown();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAltitude = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkGGA = new System.Windows.Forms.CheckBox();
            this.chkVTG = new System.Windows.Forms.CheckBox();
            this.chkRMC = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbarSteerAngle = new System.Windows.Forms.TrackBar();
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.btnTbarReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudSteerSimPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudAgOpenPort = new System.Windows.Forms.NumericUpDown();
            this.tboxAgOpenIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveRestart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteerSimPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgOpenPort)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNMEA
            // 
            this.txtNMEA.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMEA.Location = new System.Drawing.Point(5, 9);
            this.txtNMEA.Multiline = true;
            this.txtNMEA.Name = "txtNMEA";
            this.txtNMEA.Size = new System.Drawing.Size(452, 59);
            this.txtNMEA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "M/sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hz";
            // 
            // nudHz
            // 
            this.nudHz.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHz.Location = new System.Drawing.Point(128, 240);
            this.nudHz.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudHz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHz.Name = "nudHz";
            this.nudHz.Size = new System.Drawing.Size(60, 40);
            this.nudHz.TabIndex = 4;
            this.nudHz.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHz.ValueChanged += new System.EventHandler(this.nudHz_ValueChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(366, 74);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(66, 36);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "180";
            // 
            // tbarStepDistance
            // 
            this.tbarStepDistance.LargeChange = 10;
            this.tbarStepDistance.Location = new System.Drawing.Point(6, 96);
            this.tbarStepDistance.Maximum = 100;
            this.tbarStepDistance.Name = "tbarStepDistance";
            this.tbarStepDistance.Size = new System.Drawing.Size(367, 45);
            this.tbarStepDistance.TabIndex = 18;
            this.tbarStepDistance.TickFrequency = 10;
            this.tbarStepDistance.Value = 20;
            this.tbarStepDistance.Scroll += new System.EventHandler(this.tbarStepDistance_Scroll);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.Location = new System.Drawing.Point(112, 71);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(20, 24);
            this.lblStep.TabIndex = 19;
            this.lblStep.Text = "1";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(279, 71);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(20, 24);
            this.lblSpeed.TabIndex = 54;
            this.lblSpeed.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "kmh";
            // 
            // nudAltitude
            // 
            this.nudAltitude.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAltitude.Location = new System.Drawing.Point(242, 240);
            this.nudAltitude.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAltitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltitude.Name = "nudAltitude";
            this.nudAltitude.Size = new System.Drawing.Size(94, 40);
            this.nudAltitude.TabIndex = 56;
            this.nudAltitude.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAltitude.ValueChanged += new System.EventHandler(this.nudAltitude_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Altitude";
            // 
            // chkGGA
            // 
            this.chkGGA.AutoSize = true;
            this.chkGGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGGA.Location = new System.Drawing.Point(24, 217);
            this.chkGGA.Name = "chkGGA";
            this.chkGGA.Size = new System.Drawing.Size(65, 24);
            this.chkGGA.TabIndex = 58;
            this.chkGGA.Text = "GGA";
            this.chkGGA.UseVisualStyleBackColor = true;
            // 
            // chkVTG
            // 
            this.chkVTG.AutoSize = true;
            this.chkVTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVTG.Location = new System.Drawing.Point(24, 246);
            this.chkVTG.Name = "chkVTG";
            this.chkVTG.Size = new System.Drawing.Size(61, 24);
            this.chkVTG.TabIndex = 59;
            this.chkVTG.Text = "VTG";
            this.chkVTG.UseVisualStyleBackColor = true;
            // 
            // chkRMC
            // 
            this.chkRMC.AutoSize = true;
            this.chkRMC.Checked = true;
            this.chkRMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRMC.Location = new System.Drawing.Point(24, 275);
            this.chkRMC.Name = "chkRMC";
            this.chkRMC.Size = new System.Drawing.Size(64, 24);
            this.chkRMC.TabIndex = 60;
            this.chkRMC.Text = "RMC";
            this.chkRMC.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(372, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 63;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbarSteerAngle
            // 
            this.tbarSteerAngle.LargeChange = 10;
            this.tbarSteerAngle.Location = new System.Drawing.Point(10, 143);
            this.tbarSteerAngle.Maximum = 300;
            this.tbarSteerAngle.Minimum = -300;
            this.tbarSteerAngle.Name = "tbarSteerAngle";
            this.tbarSteerAngle.RightToLeftLayout = true;
            this.tbarSteerAngle.Size = new System.Drawing.Size(363, 45);
            this.tbarSteerAngle.TabIndex = 75;
            this.tbarSteerAngle.TickFrequency = 30;
            this.tbarSteerAngle.Scroll += new System.EventHandler(this.tbarSteerAngle_Scroll);
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.AutoSize = true;
            this.lblSteerAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAngle.Location = new System.Drawing.Point(177, 113);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(32, 36);
            this.lblSteerAngle.TabIndex = 76;
            this.lblSteerAngle.Text = "0";
            // 
            // btnTbarReset
            // 
            this.btnTbarReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbarReset.Location = new System.Drawing.Point(374, 122);
            this.btnTbarReset.Name = "btnTbarReset";
            this.btnTbarReset.Size = new System.Drawing.Size(69, 32);
            this.btnTbarReset.TabIndex = 77;
            this.btnTbarReset.Text = ">0<";
            this.btnTbarReset.UseVisualStyleBackColor = true;
            this.btnTbarReset.Click += new System.EventHandler(this.btnTbarReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Steer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "|";
            // 
            // rtxtStatus
            // 
            this.rtxtStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStatus.Location = new System.Drawing.Point(20, 189);
            this.rtxtStatus.Multiline = true;
            this.rtxtStatus.Name = "rtxtStatus";
            this.rtxtStatus.Size = new System.Drawing.Size(155, 18);
            this.rtxtStatus.TabIndex = 82;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 173);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 83;
            this.lblStatus.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 86;
            this.label9.Text = "Port";
            // 
            // nudSteerSimPort
            // 
            this.nudSteerSimPort.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSteerSimPort.Location = new System.Drawing.Point(51, 340);
            this.nudSteerSimPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSteerSimPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudSteerSimPort.Name = "nudSteerSimPort";
            this.nudSteerSimPort.Size = new System.Drawing.Size(96, 32);
            this.nudSteerSimPort.TabIndex = 85;
            this.nudSteerSimPort.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(175, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 90;
            this.label11.Text = "Port";
            // 
            // nudAgOpenPort
            // 
            this.nudAgOpenPort.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAgOpenPort.Location = new System.Drawing.Point(211, 391);
            this.nudAgOpenPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAgOpenPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudAgOpenPort.Name = "nudAgOpenPort";
            this.nudAgOpenPort.Size = new System.Drawing.Size(96, 32);
            this.nudAgOpenPort.TabIndex = 89;
            this.nudAgOpenPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // tboxAgOpenIP
            // 
            this.tboxAgOpenIP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAgOpenIP.Location = new System.Drawing.Point(211, 342);
            this.tboxAgOpenIP.Name = "tboxAgOpenIP";
            this.tboxAgOpenIP.Size = new System.Drawing.Size(137, 32);
            this.tboxAgOpenIP.TabIndex = 88;
            this.tboxAgOpenIP.Text = "192.168.1.255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "SteerSim Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(199, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 93;
            this.label12.Text = "AgOpenGPS ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 32);
            this.label13.TabIndex = 94;
            this.label13.Text = "*** Must match Port\r\n        in AgOpenGPS";
            // 
            // btnSaveRestart
            // 
            this.btnSaveRestart.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRestart.Location = new System.Drawing.Point(372, 388);
            this.btnSaveRestart.Name = "btnSaveRestart";
            this.btnSaveRestart.Size = new System.Drawing.Size(75, 36);
            this.btnSaveRestart.TabIndex = 95;
            this.btnSaveRestart.Text = "Save & Exit";
            this.btnSaveRestart.UseVisualStyleBackColor = true;
            this.btnSaveRestart.Click += new System.EventHandler(this.btnSaveRestart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 32);
            this.label7.TabIndex = 96;
            this.label7.Text = "Save the values \r\n   and restart ->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(244, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 97;
            this.label14.Text = "More Below";
            // 
            // FormSteerSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 226);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaveRestart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudAgOpenPort);
            this.Controls.Add(this.tboxAgOpenIP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudSteerSimPort);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtxtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTbarReset);
            this.Controls.Add(this.tbarSteerAngle);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.nudHz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkRMC);
            this.Controls.Add(this.chkVTG);
            this.Controls.Add(this.chkGGA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAltitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNMEA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSteerAngle);
            this.Controls.Add(this.tbarStepDistance);
            this.MaximizeBox = false;
            this.Name = "FormSteerSim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPS Simulator Send 9999 Recv 8888";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSim_FormClosing);
            this.Load += new System.EventHandler(this.FormSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteerSimPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgOpenPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNMEA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHz;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAltitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGGA;
        private System.Windows.Forms.CheckBox chkVTG;
        private System.Windows.Forms.CheckBox chkRMC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar tbarSteerAngle;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Button btnTbarReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rtxtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudSteerSimPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudAgOpenPort;
        private System.Windows.Forms.TextBox tboxAgOpenIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveRestart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
    }
}

