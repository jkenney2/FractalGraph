namespace FractalGraphCs
{
    partial class ColorSetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSetupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblColorMode = new System.Windows.Forms.Label();
            this.rbtVariableVal = new System.Windows.Forms.RadioButton();
            this.rbtVariableSat = new System.Windows.Forms.RadioButton();
            this.rbtVariableHue = new System.Windows.Forms.RadioButton();
            this.pbxMinHue = new System.Windows.Forms.PictureBox();
            this.pbxMaxHue = new System.Windows.Forms.PictureBox();
            this.pbxMinSat = new System.Windows.Forms.PictureBox();
            this.pbxMaxSat = new System.Windows.Forms.PictureBox();
            this.pbxMinVal = new System.Windows.Forms.PictureBox();
            this.pbxMaxVal = new System.Windows.Forms.PictureBox();
            this.tbMinHue = new System.Windows.Forms.TrackBar();
            this.tbMaxHue = new System.Windows.Forms.TrackBar();
            this.tbMinSat = new System.Windows.Forms.TrackBar();
            this.tbMaxSat = new System.Windows.Forms.TrackBar();
            this.tbMinVal = new System.Windows.Forms.TrackBar();
            this.tbMaxVal = new System.Windows.Forms.TrackBar();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxReverseColors = new System.Windows.Forms.CheckBox();
            this.cbxBlackFill = new System.Windows.Forms.CheckBox();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblColorMode);
            this.panel1.Controls.Add(this.rbtVariableVal);
            this.panel1.Controls.Add(this.rbtVariableSat);
            this.panel1.Controls.Add(this.rbtVariableHue);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 257);
            this.panel1.TabIndex = 0;
            // 
            // lblColorMode
            // 
            this.lblColorMode.AutoSize = true;
            this.lblColorMode.Location = new System.Drawing.Point(33, 17);
            this.lblColorMode.Name = "lblColorMode";
            this.lblColorMode.Size = new System.Drawing.Size(61, 13);
            this.lblColorMode.TabIndex = 3;
            this.lblColorMode.Text = "Color Mode";
            // 
            // rbtVariableVal
            // 
            this.rbtVariableVal.AutoSize = true;
            this.rbtVariableVal.Location = new System.Drawing.Point(17, 229);
            this.rbtVariableVal.Name = "rbtVariableVal";
            this.rbtVariableVal.Size = new System.Drawing.Size(93, 17);
            this.rbtVariableVal.TabIndex = 2;
            this.rbtVariableVal.Text = "Variable Value";
            this.rbtVariableVal.UseVisualStyleBackColor = true;
            this.rbtVariableVal.Click += new System.EventHandler(this.rbtVariableVal_Click);
            // 
            // rbtVariableSat
            // 
            this.rbtVariableSat.AutoSize = true;
            this.rbtVariableSat.Location = new System.Drawing.Point(17, 150);
            this.rbtVariableSat.Name = "rbtVariableSat";
            this.rbtVariableSat.Size = new System.Drawing.Size(114, 17);
            this.rbtVariableSat.TabIndex = 1;
            this.rbtVariableSat.Text = "Variable Saturation";
            this.rbtVariableSat.UseVisualStyleBackColor = true;
            this.rbtVariableSat.Click += new System.EventHandler(this.rbtVariableSat_Click);
            // 
            // rbtVariableHue
            // 
            this.rbtVariableHue.AutoSize = true;
            this.rbtVariableHue.Location = new System.Drawing.Point(24, 66);
            this.rbtVariableHue.Name = "rbtVariableHue";
            this.rbtVariableHue.Size = new System.Drawing.Size(86, 17);
            this.rbtVariableHue.TabIndex = 0;
            this.rbtVariableHue.Text = "Variable Hue";
            this.rbtVariableHue.UseVisualStyleBackColor = true;
            this.rbtVariableHue.Click += new System.EventHandler(this.rbtVariableHue_Click);
            // 
            // pbxMinHue
            // 
            this.pbxMinHue.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinHue.Image")));
            this.pbxMinHue.Location = new System.Drawing.Point(190, 117);
            this.pbxMinHue.Name = "pbxMinHue";
            this.pbxMinHue.Size = new System.Drawing.Size(120, 15);
            this.pbxMinHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinHue.TabIndex = 1;
            this.pbxMinHue.TabStop = false;
            // 
            // pbxMaxHue
            // 
            this.pbxMaxHue.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaxHue.Image")));
            this.pbxMaxHue.Location = new System.Drawing.Point(382, 117);
            this.pbxMaxHue.Name = "pbxMaxHue";
            this.pbxMaxHue.Size = new System.Drawing.Size(120, 15);
            this.pbxMaxHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaxHue.TabIndex = 2;
            this.pbxMaxHue.TabStop = false;
            // 
            // pbxMinSat
            // 
            this.pbxMinSat.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinSat.Image")));
            this.pbxMinSat.Location = new System.Drawing.Point(190, 192);
            this.pbxMinSat.Name = "pbxMinSat";
            this.pbxMinSat.Size = new System.Drawing.Size(120, 15);
            this.pbxMinSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinSat.TabIndex = 3;
            this.pbxMinSat.TabStop = false;
            // 
            // pbxMaxSat
            // 
            this.pbxMaxSat.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaxSat.Image")));
            this.pbxMaxSat.Location = new System.Drawing.Point(382, 192);
            this.pbxMaxSat.Name = "pbxMaxSat";
            this.pbxMaxSat.Size = new System.Drawing.Size(120, 15);
            this.pbxMaxSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaxSat.TabIndex = 4;
            this.pbxMaxSat.TabStop = false;
            // 
            // pbxMinVal
            // 
            this.pbxMinVal.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinVal.Image")));
            this.pbxMinVal.Location = new System.Drawing.Point(190, 271);
            this.pbxMinVal.Name = "pbxMinVal";
            this.pbxMinVal.Size = new System.Drawing.Size(120, 15);
            this.pbxMinVal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinVal.TabIndex = 5;
            this.pbxMinVal.TabStop = false;
            // 
            // pbxMaxVal
            // 
            this.pbxMaxVal.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaxVal.Image")));
            this.pbxMaxVal.Location = new System.Drawing.Point(382, 271);
            this.pbxMaxVal.Name = "pbxMaxVal";
            this.pbxMaxVal.Size = new System.Drawing.Size(120, 15);
            this.pbxMaxVal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaxVal.TabIndex = 6;
            this.pbxMaxVal.TabStop = false;
            // 
            // tbMinHue
            // 
            this.tbMinHue.Location = new System.Drawing.Point(177, 90);
            this.tbMinHue.Maximum = 100;
            this.tbMinHue.Name = "tbMinHue";
            this.tbMinHue.Size = new System.Drawing.Size(145, 42);
            this.tbMinHue.TabIndex = 7;
            this.tbMinHue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMaxHue
            // 
            this.tbMaxHue.Location = new System.Drawing.Point(369, 90);
            this.tbMaxHue.Maximum = 100;
            this.tbMaxHue.Name = "tbMaxHue";
            this.tbMaxHue.Size = new System.Drawing.Size(145, 42);
            this.tbMaxHue.TabIndex = 8;
            this.tbMaxHue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMinSat
            // 
            this.tbMinSat.Location = new System.Drawing.Point(177, 165);
            this.tbMinSat.Maximum = 100;
            this.tbMinSat.Name = "tbMinSat";
            this.tbMinSat.Size = new System.Drawing.Size(145, 42);
            this.tbMinSat.TabIndex = 9;
            this.tbMinSat.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMaxSat
            // 
            this.tbMaxSat.Location = new System.Drawing.Point(369, 166);
            this.tbMaxSat.Maximum = 100;
            this.tbMaxSat.Name = "tbMaxSat";
            this.tbMaxSat.Size = new System.Drawing.Size(145, 42);
            this.tbMaxSat.TabIndex = 10;
            this.tbMaxSat.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMinVal
            // 
            this.tbMinVal.Location = new System.Drawing.Point(177, 244);
            this.tbMinVal.Maximum = 100;
            this.tbMinVal.Name = "tbMinVal";
            this.tbMinVal.Size = new System.Drawing.Size(145, 42);
            this.tbMinVal.TabIndex = 11;
            this.tbMinVal.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMaxVal
            // 
            this.tbMaxVal.Location = new System.Drawing.Point(369, 244);
            this.tbMaxVal.Maximum = 100;
            this.tbMaxVal.Name = "tbMaxVal";
            this.tbMaxVal.Size = new System.Drawing.Size(145, 42);
            this.tbMaxVal.TabIndex = 12;
            this.tbMaxVal.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(187, 40);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(108, 13);
            this.lblMinValue.TabIndex = 13;
            this.lblMinValue.Text = "Fixed/Minimum Value";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(396, 40);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(81, 13);
            this.lblMaxValue.TabIndex = 14;
            this.lblMaxValue.Text = "Maximum Value";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(330, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(439, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxReverseColors
            // 
            this.cbxReverseColors.AutoSize = true;
            this.cbxReverseColors.Location = new System.Drawing.Point(29, 326);
            this.cbxReverseColors.Name = "cbxReverseColors";
            this.cbxReverseColors.Size = new System.Drawing.Size(98, 17);
            this.cbxReverseColors.TabIndex = 17;
            this.cbxReverseColors.Text = "Reverse Colors";
            this.cbxReverseColors.UseVisualStyleBackColor = true;
            // 
            // cbxBlackFill
            // 
            this.cbxBlackFill.AutoSize = true;
            this.cbxBlackFill.Location = new System.Drawing.Point(190, 326);
            this.cbxBlackFill.Name = "cbxBlackFill";
            this.cbxBlackFill.Size = new System.Drawing.Size(68, 17);
            this.cbxBlackFill.TabIndex = 18;
            this.cbxBlackFill.Text = "Black Fill";
            this.cbxBlackFill.UseVisualStyleBackColor = true;
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Location = new System.Drawing.Point(328, 107);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(27, 13);
            this.lblHue.TabIndex = 19;
            this.lblHue.Text = "Hue";
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Location = new System.Drawing.Point(328, 175);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(23, 13);
            this.lblSat.TabIndex = 20;
            this.lblSat.Text = "Sat";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(328, 260);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 21;
            this.lblValue.Text = "Value";
            // 
            // ColorSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 361);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblHue);
            this.Controls.Add(this.cbxBlackFill);
            this.Controls.Add(this.cbxReverseColors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.pbxMaxVal);
            this.Controls.Add(this.pbxMinVal);
            this.Controls.Add(this.pbxMaxSat);
            this.Controls.Add(this.pbxMinSat);
            this.Controls.Add(this.pbxMaxHue);
            this.Controls.Add(this.pbxMinHue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbMinHue);
            this.Controls.Add(this.tbMaxHue);
            this.Controls.Add(this.tbMinSat);
            this.Controls.Add(this.tbMaxSat);
            this.Controls.Add(this.tbMinVal);
            this.Controls.Add(this.tbMaxVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSetupForm";
            this.Text = "ColorSetupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtVariableVal;
        private System.Windows.Forms.RadioButton rbtVariableSat;
        private System.Windows.Forms.RadioButton rbtVariableHue;
        private System.Windows.Forms.Label lblColorMode;
        private System.Windows.Forms.PictureBox pbxMinHue;
        private System.Windows.Forms.PictureBox pbxMaxHue;
        private System.Windows.Forms.PictureBox pbxMinSat;
        private System.Windows.Forms.PictureBox pbxMaxSat;
        private System.Windows.Forms.PictureBox pbxMinVal;
        private System.Windows.Forms.PictureBox pbxMaxVal;
        private System.Windows.Forms.TrackBar tbMinHue;
        private System.Windows.Forms.TrackBar tbMaxHue;
        private System.Windows.Forms.TrackBar tbMinSat;
        private System.Windows.Forms.TrackBar tbMaxSat;
        private System.Windows.Forms.TrackBar tbMinVal;
        private System.Windows.Forms.TrackBar tbMaxVal;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxReverseColors;
        private System.Windows.Forms.CheckBox cbxBlackFill;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblValue;

    }
}