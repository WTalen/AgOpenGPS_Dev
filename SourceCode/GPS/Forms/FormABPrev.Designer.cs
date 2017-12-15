namespace AgOpenGPS
{
    partial class FormABPrev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABPrev));
            this.listboxLines = new System.Windows.Forms.ListBox();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnUseSelected = new System.Windows.Forms.Button();
            this.btnAddManualInput = new System.Windows.Forms.Button();
            this.tboxEasting = new System.Windows.Forms.TextBox();
            this.tboxNorthing = new System.Windows.Forms.TextBox();
            this.tboxHeading = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lvLines = new System.Windows.Forms.ListView();
            this.chField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAngle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteListviewItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBPoint = new System.Windows.Forms.Button();
            this.btnAPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDnABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnUpABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnDnABHeading = new System.Windows.Forms.Button();
            this.btnUpABHeading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxLines
            // 
            this.listboxLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxLines.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxLines.FormattingEnabled = true;
            this.listboxLines.ItemHeight = 39;
            this.listboxLines.Location = new System.Drawing.Point(578, 269);
            this.listboxLines.Name = "listboxLines";
            this.listboxLines.Size = new System.Drawing.Size(509, 82);
            this.listboxLines.TabIndex = 0;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(968, 22);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(118, 93);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnUseSelected
            // 
            this.btnUseSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseSelected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseSelected.Location = new System.Drawing.Point(968, 128);
            this.btnUseSelected.Name = "btnUseSelected";
            this.btnUseSelected.Size = new System.Drawing.Size(118, 93);
            this.btnUseSelected.TabIndex = 3;
            this.btnUseSelected.Text = "Use Selected";
            this.btnUseSelected.UseVisualStyleBackColor = true;
            this.btnUseSelected.Click += new System.EventHandler(this.btnUseSelected_Click);
            // 
            // btnAddManualInput
            // 
            this.btnAddManualInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddManualInput.Location = new System.Drawing.Point(808, 40);
            this.btnAddManualInput.Name = "btnAddManualInput";
            this.btnAddManualInput.Size = new System.Drawing.Size(105, 61);
            this.btnAddManualInput.TabIndex = 4;
            this.btnAddManualInput.Text = "Add to List";
            this.btnAddManualInput.UseVisualStyleBackColor = true;
            this.btnAddManualInput.Click += new System.EventHandler(this.btnAddManualInput_Click);
            // 
            // tboxEasting
            // 
            this.tboxEasting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxEasting.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEasting.Location = new System.Drawing.Point(659, 165);
            this.tboxEasting.MaxLength = 10;
            this.tboxEasting.Name = "tboxEasting";
            this.tboxEasting.Size = new System.Drawing.Size(105, 40);
            this.tboxEasting.TabIndex = 5;
            this.tboxEasting.Text = "0.0";
            this.tboxEasting.TextChanged += new System.EventHandler(this.tboxEasting_TextChanged);
            // 
            // tboxNorthing
            // 
            this.tboxNorthing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxNorthing.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNorthing.Location = new System.Drawing.Point(792, 165);
            this.tboxNorthing.MaxLength = 10;
            this.tboxNorthing.Name = "tboxNorthing";
            this.tboxNorthing.Size = new System.Drawing.Size(105, 40);
            this.tboxNorthing.TabIndex = 6;
            this.tboxNorthing.Text = "0.0";
            this.tboxNorthing.TextChanged += new System.EventHandler(this.tboxNorthing_TextChanged);
            // 
            // tboxHeading
            // 
            this.tboxHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxHeading.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHeading.Location = new System.Drawing.Point(629, 61);
            this.tboxHeading.MaxLength = 10;
            this.tboxHeading.Name = "tboxHeading";
            this.tboxHeading.Size = new System.Drawing.Size(135, 40);
            this.tboxHeading.TabIndex = 7;
            this.tboxHeading.Text = "0.0";
            this.tboxHeading.TextChanged += new System.EventHandler(this.tboxHeading_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Easting";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Heading";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(788, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Northing";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(942, 581);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 86);
            this.btnOk.TabIndex = 63;
            this.btnOk.Text = "Save";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lvLines
            // 
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chField,
            this.chAngle});
            this.lvLines.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLines.FullRowSelect = true;
            this.lvLines.GridLines = true;
            this.lvLines.HideSelection = false;
            this.lvLines.Location = new System.Drawing.Point(12, 14);
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Size = new System.Drawing.Size(403, 207);
            this.lvLines.TabIndex = 64;
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Details;
            // 
            // chField
            // 
            this.chField.Text = "Field";
            this.chField.Width = 200;
            // 
            // chAngle
            // 
            this.chAngle.Text = "Angle";
            this.chAngle.Width = 150;
            // 
            // btnDeleteListviewItem
            // 
            this.btnDeleteListviewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteListviewItem.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteListviewItem.Location = new System.Drawing.Point(429, 14);
            this.btnDeleteListviewItem.Name = "btnDeleteListviewItem";
            this.btnDeleteListviewItem.Size = new System.Drawing.Size(99, 87);
            this.btnDeleteListviewItem.TabIndex = 65;
            this.btnDeleteListviewItem.Text = "Delete Selected";
            this.btnDeleteListviewItem.UseVisualStyleBackColor = true;
            this.btnDeleteListviewItem.Click += new System.EventHandler(this.btnDeleteListviewItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 87);
            this.button1.TabIndex = 66;
            this.button1.Text = "Use Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBPoint
            // 
            this.btnBPoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBPoint.Image = global::AgOpenGPS.Properties.Resources.LetterBBlue;
            this.btnBPoint.Location = new System.Drawing.Point(161, 246);
            this.btnBPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBPoint.Name = "btnBPoint";
            this.btnBPoint.Size = new System.Drawing.Size(99, 87);
            this.btnBPoint.TabIndex = 68;
            this.btnBPoint.UseVisualStyleBackColor = true;
            // 
            // btnAPoint
            // 
            this.btnAPoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPoint.Image = global::AgOpenGPS.Properties.Resources.LetterABlue;
            this.btnAPoint.Location = new System.Drawing.Point(14, 246);
            this.btnAPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAPoint.Name = "btnAPoint";
            this.btnAPoint.Size = new System.Drawing.Size(90, 87);
            this.btnAPoint.TabIndex = 67;
            this.btnAPoint.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 444);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 40);
            this.textBox1.TabIndex = 88;
            this.textBox1.Text = "0.0";
            // 
            // btnDnABHeadingBy1
            // 
            this.btnDnABHeadingBy1.Enabled = false;
            this.btnDnABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeadingBy1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDnABHeadingBy1.Image = ((System.Drawing.Image)(resources.GetObject("btnDnABHeadingBy1.Image")));
            this.btnDnABHeadingBy1.Location = new System.Drawing.Point(14, 495);
            this.btnDnABHeadingBy1.Name = "btnDnABHeadingBy1";
            this.btnDnABHeadingBy1.Size = new System.Drawing.Size(74, 69);
            this.btnDnABHeadingBy1.TabIndex = 87;
            this.btnDnABHeadingBy1.Text = "1";
            this.btnDnABHeadingBy1.UseVisualStyleBackColor = true;
            // 
            // btnUpABHeadingBy1
            // 
            this.btnUpABHeadingBy1.Enabled = false;
            this.btnUpABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeadingBy1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpABHeadingBy1.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnUpABHeadingBy1.Location = new System.Drawing.Point(14, 365);
            this.btnUpABHeadingBy1.Name = "btnUpABHeadingBy1";
            this.btnUpABHeadingBy1.Size = new System.Drawing.Size(74, 69);
            this.btnUpABHeadingBy1.TabIndex = 86;
            this.btnUpABHeadingBy1.Text = "1";
            this.btnUpABHeadingBy1.UseVisualStyleBackColor = true;
            // 
            // btnDnABHeading
            // 
            this.btnDnABHeading.Enabled = false;
            this.btnDnABHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDnABHeading.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnDnABHeading.Location = new System.Drawing.Point(112, 495);
            this.btnDnABHeading.Name = "btnDnABHeading";
            this.btnDnABHeading.Size = new System.Drawing.Size(74, 69);
            this.btnDnABHeading.TabIndex = 85;
            this.btnDnABHeading.Text = "10";
            this.btnDnABHeading.UseVisualStyleBackColor = true;
            // 
            // btnUpABHeading
            // 
            this.btnUpABHeading.Enabled = false;
            this.btnUpABHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpABHeading.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnUpABHeading.Location = new System.Drawing.Point(112, 365);
            this.btnUpABHeading.Name = "btnUpABHeading";
            this.btnUpABHeading.Size = new System.Drawing.Size(74, 69);
            this.btnUpABHeading.TabIndex = 84;
            this.btnUpABHeading.Text = "10";
            this.btnUpABHeading.UseVisualStyleBackColor = true;
            // 
            // FormABPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1099, 703);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDnABHeadingBy1);
            this.Controls.Add(this.btnUpABHeadingBy1);
            this.Controls.Add(this.btnDnABHeading);
            this.Controls.Add(this.btnUpABHeading);
            this.Controls.Add(this.btnBPoint);
            this.Controls.Add(this.btnAPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteListviewItem);
            this.Controls.Add(this.lvLines);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxHeading);
            this.Controls.Add(this.tboxNorthing);
            this.Controls.Add(this.tboxEasting);
            this.Controls.Add(this.btnAddManualInput);
            this.Controls.Add(this.btnUseSelected);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.listboxLines);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "FormABPrev";
            this.Text = "AB Lines";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormABPrev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxLines;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnUseSelected;
        private System.Windows.Forms.Button btnAddManualInput;
        private System.Windows.Forms.TextBox tboxEasting;
        private System.Windows.Forms.TextBox tboxNorthing;
        private System.Windows.Forms.TextBox tboxHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chField;
        private System.Windows.Forms.ColumnHeader chAngle;
        private System.Windows.Forms.Button btnDeleteListviewItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBPoint;
        private System.Windows.Forms.Button btnAPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDnABHeadingBy1;
        private System.Windows.Forms.Button btnUpABHeadingBy1;
        private System.Windows.Forms.Button btnDnABHeading;
        private System.Windows.Forms.Button btnUpABHeading;
    }
}