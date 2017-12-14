namespace AgOpenGPS
{
    partial class FormABLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABLine));
            this.lblABHeading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFixHeading = new System.Windows.Forms.Label();
            this.lblKeepGoing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBasedOnPass = new System.Windows.Forms.NumericUpDown();
            this.nudTramRepeats = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDnABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnUpABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.btnBPoint = new System.Windows.Forms.Button();
            this.btnAPoint = new System.Windows.Forms.Button();
            this.btnABLineOk = new System.Windows.Forms.Button();
            this.btnLoadPrevious = new System.Windows.Forms.Button();
            this.btnAddToFile = new System.Windows.Forms.Button();
            this.tboxHeading = new System.Windows.Forms.TextBox();
            this.btnDnABHeading = new System.Windows.Forms.Button();
            this.btnUpABHeading = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblABHeading
            // 
            this.lblABHeading.AutoSize = true;
            this.lblABHeading.BackColor = System.Drawing.SystemColors.Control;
            this.lblABHeading.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABHeading.Location = new System.Drawing.Point(12, 219);
            this.lblABHeading.Name = "lblABHeading";
            this.lblABHeading.Size = new System.Drawing.Size(83, 33);
            this.lblABHeading.TabIndex = 63;
            this.lblABHeading.Text = "000.0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFixHeading
            // 
            this.lblFixHeading.AutoSize = true;
            this.lblFixHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixHeading.Location = new System.Drawing.Point(165, 223);
            this.lblFixHeading.Name = "lblFixHeading";
            this.lblFixHeading.Size = new System.Drawing.Size(25, 25);
            this.lblFixHeading.TabIndex = 64;
            this.lblFixHeading.Text = "0";
            // 
            // lblKeepGoing
            // 
            this.lblKeepGoing.AutoSize = true;
            this.lblKeepGoing.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeepGoing.Location = new System.Drawing.Point(271, 208);
            this.lblKeepGoing.Name = "lblKeepGoing";
            this.lblKeepGoing.Size = new System.Drawing.Size(22, 25);
            this.lblKeepGoing.TabIndex = 74;
            this.lblKeepGoing.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Repeats Every";
            // 
            // nudBasedOnPass
            // 
            this.nudBasedOnPass.BackColor = System.Drawing.Color.MediumOrchid;
            this.nudBasedOnPass.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBasedOnPass.Location = new System.Drawing.Point(27, 135);
            this.nudBasedOnPass.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBasedOnPass.Name = "nudBasedOnPass";
            this.nudBasedOnPass.Size = new System.Drawing.Size(98, 46);
            this.nudBasedOnPass.TabIndex = 77;
            this.nudBasedOnPass.ValueChanged += new System.EventHandler(this.nudBasedOnPass_ValueChanged);
            // 
            // nudTramRepeats
            // 
            this.nudTramRepeats.BackColor = System.Drawing.Color.Lime;
            this.nudTramRepeats.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTramRepeats.Location = new System.Drawing.Point(27, 51);
            this.nudTramRepeats.Name = "nudTramRepeats";
            this.nudTramRepeats.Size = new System.Drawing.Size(98, 46);
            this.nudTramRepeats.TabIndex = 75;
            this.nudTramRepeats.ValueChanged += new System.EventHandler(this.nudTramRepeats_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Starting at Pass#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudTramRepeats);
            this.groupBox1.Controls.Add(this.nudBasedOnPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(225, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 199);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tramline ";
            // 
            // btnDnABHeadingBy1
            // 
            this.btnDnABHeadingBy1.Enabled = false;
            this.btnDnABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeadingBy1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDnABHeadingBy1.Image = ((System.Drawing.Image)(resources.GetObject("btnDnABHeadingBy1.Image")));
            this.btnDnABHeadingBy1.Location = new System.Drawing.Point(6, 136);
            this.btnDnABHeadingBy1.Name = "btnDnABHeadingBy1";
            this.btnDnABHeadingBy1.Size = new System.Drawing.Size(74, 69);
            this.btnDnABHeadingBy1.TabIndex = 73;
            this.btnDnABHeadingBy1.Text = "1";
            this.btnDnABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnDnABHeadingBy1.Click += new System.EventHandler(this.btnDnABHeadingBy1_Click);
            // 
            // btnUpABHeadingBy1
            // 
            this.btnUpABHeadingBy1.Enabled = false;
            this.btnUpABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeadingBy1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpABHeadingBy1.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnUpABHeadingBy1.Location = new System.Drawing.Point(6, 6);
            this.btnUpABHeadingBy1.Name = "btnUpABHeadingBy1";
            this.btnUpABHeadingBy1.Size = new System.Drawing.Size(74, 69);
            this.btnUpABHeadingBy1.TabIndex = 72;
            this.btnUpABHeadingBy1.Text = "1";
            this.btnUpABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnUpABHeadingBy1.Click += new System.EventHandler(this.btnUpABHeadingBy1_Click);
            // 
            // btnDeleteAB
            // 
            this.btnDeleteAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAB.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnDeleteAB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAB.Location = new System.Drawing.Point(169, 390);
            this.btnDeleteAB.Name = "btnDeleteAB";
            this.btnDeleteAB.Size = new System.Drawing.Size(90, 87);
            this.btnDeleteAB.TabIndex = 0;
            this.btnDeleteAB.Text = "Delete";
            this.btnDeleteAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAB.Click += new System.EventHandler(this.btnDeleteAB_Click);
            // 
            // btnBPoint
            // 
            this.btnBPoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBPoint.Image = global::AgOpenGPS.Properties.Resources.LetterBBlue;
            this.btnBPoint.Location = new System.Drawing.Point(153, 256);
            this.btnBPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBPoint.Name = "btnBPoint";
            this.btnBPoint.Size = new System.Drawing.Size(90, 87);
            this.btnBPoint.TabIndex = 58;
            this.btnBPoint.UseVisualStyleBackColor = true;
            this.btnBPoint.Click += new System.EventHandler(this.btnBPoint_Click);
            // 
            // btnAPoint
            // 
            this.btnAPoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPoint.Image = global::AgOpenGPS.Properties.Resources.LetterABlue;
            this.btnAPoint.Location = new System.Drawing.Point(6, 256);
            this.btnAPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAPoint.Name = "btnAPoint";
            this.btnAPoint.Size = new System.Drawing.Size(90, 87);
            this.btnAPoint.TabIndex = 57;
            this.btnAPoint.UseVisualStyleBackColor = true;
            this.btnAPoint.Click += new System.EventHandler(this.btnAPoint_Click);
            // 
            // btnABLineOk
            // 
            this.btnABLineOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnABLineOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABLineOk.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnABLineOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnABLineOk.Location = new System.Drawing.Point(276, 390);
            this.btnABLineOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnABLineOk.Name = "btnABLineOk";
            this.btnABLineOk.Size = new System.Drawing.Size(116, 87);
            this.btnABLineOk.TabIndex = 62;
            this.btnABLineOk.Text = "Save";
            this.btnABLineOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnABLineOk.UseVisualStyleBackColor = true;
            this.btnABLineOk.Click += new System.EventHandler(this.btnABLineOk_Click);
            // 
            // btnLoadPrevious
            // 
            this.btnLoadPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPrevious.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrevious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPrevious.Image = global::AgOpenGPS.Properties.Resources.FileOpen;
            this.btnLoadPrevious.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadPrevious.Location = new System.Drawing.Point(12, 390);
            this.btnLoadPrevious.Name = "btnLoadPrevious";
            this.btnLoadPrevious.Size = new System.Drawing.Size(90, 87);
            this.btnLoadPrevious.TabIndex = 81;
            this.btnLoadPrevious.Text = "Lines";
            this.btnLoadPrevious.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadPrevious.Click += new System.EventHandler(this.btnLoadPrevious_Click);
            // 
            // btnAddToFile
            // 
            this.btnAddToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToFile.Image = global::AgOpenGPS.Properties.Resources.FileNew;
            this.btnAddToFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddToFile.Location = new System.Drawing.Point(302, 256);
            this.btnAddToFile.Name = "btnAddToFile";
            this.btnAddToFile.Size = new System.Drawing.Size(90, 87);
            this.btnAddToFile.TabIndex = 82;
            this.btnAddToFile.Text = "Add";
            this.btnAddToFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToFile.Click += new System.EventHandler(this.btnAddToFile_Click);
            // 
            // tboxHeading
            // 
            this.tboxHeading.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHeading.Location = new System.Drawing.Point(26, 85);
            this.tboxHeading.MaxLength = 10;
            this.tboxHeading.Name = "tboxHeading";
            this.tboxHeading.Size = new System.Drawing.Size(129, 40);
            this.tboxHeading.TabIndex = 83;
            this.tboxHeading.Text = "0.0";
            this.tboxHeading.TextChanged += new System.EventHandler(this.tboxHeading_TextChanged);
            // 
            // btnDnABHeading
            // 
            this.btnDnABHeading.Enabled = false;
            this.btnDnABHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDnABHeading.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnDnABHeading.Location = new System.Drawing.Point(104, 136);
            this.btnDnABHeading.Name = "btnDnABHeading";
            this.btnDnABHeading.Size = new System.Drawing.Size(74, 69);
            this.btnDnABHeading.TabIndex = 70;
            this.btnDnABHeading.Text = "10";
            this.btnDnABHeading.UseVisualStyleBackColor = true;
            this.btnDnABHeading.Click += new System.EventHandler(this.btnDownABHeading_Click);
            // 
            // btnUpABHeading
            // 
            this.btnUpABHeading.Enabled = false;
            this.btnUpABHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpABHeading.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnUpABHeading.Location = new System.Drawing.Point(104, 6);
            this.btnUpABHeading.Name = "btnUpABHeading";
            this.btnUpABHeading.Size = new System.Drawing.Size(74, 69);
            this.btnUpABHeading.TabIndex = 69;
            this.btnUpABHeading.Text = "10";
            this.btnUpABHeading.UseVisualStyleBackColor = true;
            this.btnUpABHeading.Click += new System.EventHandler(this.btnUpABHeading_Click);
            // 
            // FormABLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(406, 489);
            this.ControlBox = false;
            this.Controls.Add(this.tboxHeading);
            this.Controls.Add(this.btnAddToFile);
            this.Controls.Add(this.btnLoadPrevious);
            this.Controls.Add(this.lblKeepGoing);
            this.Controls.Add(this.btnDnABHeadingBy1);
            this.Controls.Add(this.btnUpABHeadingBy1);
            this.Controls.Add(this.btnDnABHeading);
            this.Controls.Add(this.btnUpABHeading);
            this.Controls.Add(this.lblFixHeading);
            this.Controls.Add(this.lblABHeading);
            this.Controls.Add(this.btnDeleteAB);
            this.Controls.Add(this.btnBPoint);
            this.Controls.Add(this.btnAPoint);
            this.Controls.Add(this.btnABLineOk);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormABLine";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AB Line";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormABLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Button btnBPoint;
        private System.Windows.Forms.Button btnAPoint;
        private System.Windows.Forms.Button btnABLineOk;
        private System.Windows.Forms.Label lblABHeading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFixHeading;
        private System.Windows.Forms.Button btnDnABHeadingBy1;
        private System.Windows.Forms.Button btnUpABHeadingBy1;
        private System.Windows.Forms.Label lblKeepGoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBasedOnPass;
        private System.Windows.Forms.NumericUpDown nudTramRepeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadPrevious;
        private System.Windows.Forms.Button btnAddToFile;
        private System.Windows.Forms.TextBox tboxHeading;
        private System.Windows.Forms.Button btnDnABHeading;
        private System.Windows.Forms.Button btnUpABHeading;
    }
}