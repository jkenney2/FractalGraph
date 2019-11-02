namespace FractalGraphCs
{
    partial class MainFractalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFractalForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSize160 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSize320 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSize480 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSize640 = new System.Windows.Forms.ToolStripMenuItem();
            this.maxIterToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMaxiter40 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMaxiter80 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMaxiter160 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMaxiter320 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blowoutToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripBlowout10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBlowout50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBlowout100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBlowout200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.currentParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbxFunction = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.maxIterToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.blowoutToolStripMenuItem,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.selectToolStripButton,
            this.zoomToolStripButton,
            this.panToolStripButton,
            this.toolStripSeparator2,
            this.tbxFunction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBitmapToolStripMenuItem,
            this.colorSetupToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveBitmapToolStripMenuItem
            // 
            this.saveBitmapToolStripMenuItem.Name = "saveBitmapToolStripMenuItem";
            this.saveBitmapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveBitmapToolStripMenuItem.Text = "Save Bitmap";
            this.saveBitmapToolStripMenuItem.Click += new System.EventHandler(this.saveBitmapToolStripMenuItem_Click);
            // 
            // colorSetupToolStripMenuItem
            // 
            this.colorSetupToolStripMenuItem.Name = "colorSetupToolStripMenuItem";
            this.colorSetupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorSetupToolStripMenuItem.Text = "Color Setup";
            this.colorSetupToolStripMenuItem.Click += new System.EventHandler(this.colorSetupToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSize160,
            this.toolStripSize320,
            this.toolStripSize480,
            this.toolStripSize640});
            this.sizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sizeToolStripMenuItem.Image")));
            this.sizeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.ToolTipText = "Select Image Size";
            this.sizeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.sizeToolStripMenuItem_DropDownOpening);
            // 
            // toolStripSize160
            // 
            this.toolStripSize160.Name = "toolStripSize160";
            this.toolStripSize160.Size = new System.Drawing.Size(92, 22);
            this.toolStripSize160.Text = "160";
            this.toolStripSize160.Click += new System.EventHandler(this.toolStripSize160_Click);
            // 
            // toolStripSize320
            // 
            this.toolStripSize320.Checked = true;
            this.toolStripSize320.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSize320.Name = "toolStripSize320";
            this.toolStripSize320.Size = new System.Drawing.Size(92, 22);
            this.toolStripSize320.Text = "320";
            this.toolStripSize320.Click += new System.EventHandler(this.toolStripSize320_Click);
            // 
            // toolStripSize480
            // 
            this.toolStripSize480.Name = "toolStripSize480";
            this.toolStripSize480.Size = new System.Drawing.Size(92, 22);
            this.toolStripSize480.Text = "480";
            this.toolStripSize480.Click += new System.EventHandler(this.toolStripSize480_Click);
            // 
            // toolStripSize640
            // 
            this.toolStripSize640.Name = "toolStripSize640";
            this.toolStripSize640.Size = new System.Drawing.Size(92, 22);
            this.toolStripSize640.Text = "640";
            this.toolStripSize640.Click += new System.EventHandler(this.toolStripSize640_Click);
            // 
            // maxIterToolStripMenuItem
            // 
            this.maxIterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.maxIterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMaxiter40,
            this.toolStripMaxiter80,
            this.toolStripMaxiter160,
            this.toolStripMaxiter320});
            this.maxIterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maxIterToolStripMenuItem.Image")));
            this.maxIterToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maxIterToolStripMenuItem.Name = "maxIterToolStripMenuItem";
            this.maxIterToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.maxIterToolStripMenuItem.Text = "MaxIter";
            this.maxIterToolStripMenuItem.ToolTipText = "Select Maximum Iterations";
            this.maxIterToolStripMenuItem.DropDownOpening += new System.EventHandler(this.maxIterToolStripMenuItem_DropDownOpening);
            // 
            // toolStripMaxiter40
            // 
            this.toolStripMaxiter40.Name = "toolStripMaxiter40";
            this.toolStripMaxiter40.Size = new System.Drawing.Size(92, 22);
            this.toolStripMaxiter40.Text = "40";
            this.toolStripMaxiter40.Click += new System.EventHandler(this.toolStripMaxiter40_Click);
            // 
            // toolStripMaxiter80
            // 
            this.toolStripMaxiter80.Name = "toolStripMaxiter80";
            this.toolStripMaxiter80.Size = new System.Drawing.Size(92, 22);
            this.toolStripMaxiter80.Text = "80";
            this.toolStripMaxiter80.Click += new System.EventHandler(this.toolStripMaxiter80_Click);
            // 
            // toolStripMaxiter160
            // 
            this.toolStripMaxiter160.Name = "toolStripMaxiter160";
            this.toolStripMaxiter160.Size = new System.Drawing.Size(92, 22);
            this.toolStripMaxiter160.Text = "160";
            this.toolStripMaxiter160.Click += new System.EventHandler(this.toolStripMaxiter160_Click);
            // 
            // toolStripMaxiter320
            // 
            this.toolStripMaxiter320.Name = "toolStripMaxiter320";
            this.toolStripMaxiter320.Size = new System.Drawing.Size(92, 22);
            this.toolStripMaxiter320.Text = "320";
            this.toolStripMaxiter320.Click += new System.EventHandler(this.toolStripMaxiter320_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.panToolStripMenuItem});
            this.modeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modeToolStripMenuItem.Image")));
            this.modeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            this.modeToolStripMenuItem.ToolTipText = "Select Mode";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Checked = true;
            this.selectToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.panToolStripMenuItem.Text = "Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // blowoutToolStripMenuItem
            // 
            this.blowoutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blowoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBlowout10,
            this.toolStripBlowout50,
            this.toolStripBlowout100,
            this.toolStripBlowout200});
            this.blowoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blowoutToolStripMenuItem.Image")));
            this.blowoutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blowoutToolStripMenuItem.Name = "blowoutToolStripMenuItem";
            this.blowoutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.blowoutToolStripMenuItem.Text = "Blowout";
            // 
            // toolStripBlowout10
            // 
            this.toolStripBlowout10.Checked = true;
            this.toolStripBlowout10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripBlowout10.Name = "toolStripBlowout10";
            this.toolStripBlowout10.Size = new System.Drawing.Size(92, 22);
            this.toolStripBlowout10.Text = "10";
            this.toolStripBlowout10.Click += new System.EventHandler(this.toolStripBlowout10_Click);
            // 
            // toolStripBlowout50
            // 
            this.toolStripBlowout50.Name = "toolStripBlowout50";
            this.toolStripBlowout50.Size = new System.Drawing.Size(92, 22);
            this.toolStripBlowout50.Text = "50";
            this.toolStripBlowout50.Click += new System.EventHandler(this.toolStripBlowout50_Click);
            // 
            // toolStripBlowout100
            // 
            this.toolStripBlowout100.Name = "toolStripBlowout100";
            this.toolStripBlowout100.Size = new System.Drawing.Size(92, 22);
            this.toolStripBlowout100.Text = "100";
            this.toolStripBlowout100.Click += new System.EventHandler(this.toolStripBlowout100_Click);
            // 
            // toolStripBlowout200
            // 
            this.toolStripBlowout200.Name = "toolStripBlowout200";
            this.toolStripBlowout200.Size = new System.Drawing.Size(92, 22);
            this.toolStripBlowout200.Text = "200";
            this.toolStripBlowout200.Click += new System.EventHandler(this.toolStripBlowout200_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentParametersToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButton1.Text = "View";
            // 
            // currentParametersToolStripMenuItem
            // 
            this.currentParametersToolStripMenuItem.Name = "currentParametersToolStripMenuItem";
            this.currentParametersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.currentParametersToolStripMenuItem.Text = "Current Parameters";
            this.currentParametersToolStripMenuItem.Click += new System.EventHandler(this.currentParametersToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // selectToolStripButton
            // 
            this.selectToolStripButton.Checked = true;
            this.selectToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("selectToolStripButton.Image")));
            this.selectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectToolStripButton.Name = "selectToolStripButton";
            this.selectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.selectToolStripButton.Text = "Select Mode";
            this.selectToolStripButton.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // zoomToolStripButton
            // 
            this.zoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomToolStripButton.Image")));
            this.zoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomToolStripButton.Name = "zoomToolStripButton";
            this.zoomToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomToolStripButton.Text = "Zoom Mode";
            this.zoomToolStripButton.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // panToolStripButton
            // 
            this.panToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.panToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("panToolStripButton.Image")));
            this.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.panToolStripButton.Name = "panToolStripButton";
            this.panToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.panToolStripButton.Text = "Pan Mode";
            this.panToolStripButton.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectContextMenuItem,
            this.zoomContextMenuItem,
            this.panContextMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 70);
            // 
            // selectContextMenuItem
            // 
            this.selectContextMenuItem.Checked = true;
            this.selectContextMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectContextMenuItem.Name = "selectContextMenuItem";
            this.selectContextMenuItem.Size = new System.Drawing.Size(103, 22);
            this.selectContextMenuItem.Text = "Select";
            this.selectContextMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // zoomContextMenuItem
            // 
            this.zoomContextMenuItem.Name = "zoomContextMenuItem";
            this.zoomContextMenuItem.Size = new System.Drawing.Size(103, 22);
            this.zoomContextMenuItem.Text = "Zoom";
            this.zoomContextMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // panContextMenuItem
            // 
            this.panContextMenuItem.Name = "panContextMenuItem";
            this.panContextMenuItem.Size = new System.Drawing.Size(103, 22);
            this.panContextMenuItem.Text = "Pan";
            this.panContextMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbxFunction
            // 
            this.tbxFunction.Name = "tbxFunction";
            this.tbxFunction.Size = new System.Drawing.Size(100, 25);
            this.tbxFunction.Text = "z*z+b";
            this.tbxFunction.DoubleClick += new System.EventHandler(this.tbxFunction_DoubleClick);
            this.tbxFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFunction_KeyPress);
            // 
            // MainFractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(613, 323);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainFractalForm";
            this.Text = "Fractal Generator";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripSize160;
        private System.Windows.Forms.ToolStripMenuItem toolStripSize320;
        private System.Windows.Forms.ToolStripMenuItem toolStripSize480;
        private System.Windows.Forms.ToolStripDropDownButton maxIterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMaxiter40;
        private System.Windows.Forms.ToolStripMenuItem toolStripMaxiter80;
        private System.Windows.Forms.ToolStripMenuItem toolStripMaxiter160;
        private System.Windows.Forms.ToolStripMenuItem toolStripMaxiter320;
        private System.Windows.Forms.ToolStripDropDownButton modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton blowoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBlowout10;
        private System.Windows.Forms.ToolStripMenuItem toolStripBlowout50;
        private System.Windows.Forms.ToolStripMenuItem toolStripBlowout100;
        private System.Windows.Forms.ToolStripMenuItem toolStripBlowout200;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton selectToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomToolStripButton;
        private System.Windows.Forms.ToolStripButton panToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem colorSetupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSize640;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem currentParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tbxFunction;





    }
}

