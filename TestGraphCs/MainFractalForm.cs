using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphicsBox;
using CshComplex;
using ComplexExpressionCs;

namespace FractalGraphCs
{
    public partial class MainFractalForm : Form
    {
        private FractBox frmMandelbrot;
        private FractBox frmJulia;
        private FractColor fractColor;

        enum MouseMode { Select, Zoom, Pan };
        MouseMode _mouseMode = MouseMode.Select;
        Complex _bWorld;
        Point _bPage;
        Bitmap _crosshair;
        Bitmap _crosshairReplace;
        bool _movingMandelbrot;
        bool _movingJulia;
        Point _beginMove;
        readonly Cursor _curZoom;
        readonly Cursor _curPan;
        int _bitmapSize;
        string _funcText = "z*z+b";


        public MainFractalForm()
        {
            _bitmapSize = 320;
            
            InitializeComponent();
            this.SuspendLayout();
            frmMandelbrot = new FractBox(_bitmapSize+1, _bitmapSize+1, FractalType.Mandelbrot);
            frmJulia = new FractBox(_bitmapSize+1, _bitmapSize+1, FractalType.Julia);
            this.Controls.Add(frmMandelbrot);
            this.Controls.Add(frmJulia);
            frmMandelbrot.Top = this.toolStrip1.Height;
            frmMandelbrot.Left = 0;
            frmJulia.Top = this.toolStrip1.Height;
            frmJulia.Left = frmMandelbrot.Width;
            frmMandelbrot.MouseClick += new MouseEventHandler(frmMandelbrot_MouseClick);
            frmJulia.MouseClick += new MouseEventHandler(frmJulia_MouseClick);
            frmMandelbrot.MouseDown += new MouseEventHandler(frmMandelbrot_MouseDown);
            frmMandelbrot.MouseMove += new MouseEventHandler(frmMandelbrot_MouseMove);
            frmMandelbrot.MouseUp += new MouseEventHandler(frmMandelbrot_MouseUp);
            frmJulia.MouseDown += new MouseEventHandler(frmJulia_MouseDown);
            frmJulia.MouseMove += new MouseEventHandler(frmJulia_MouseMove);
            frmJulia.MouseUp += new MouseEventHandler(frmJulia_MouseUp);
            frmMandelbrot.ContextMenuStrip = this.contextMenuStrip1;
            frmJulia.ContextMenuStrip = this.contextMenuStrip1;
            this.ResumeLayout(false);
            this.PerformLayout();

            _bPage = new Point(frmMandelbrot.ClientSize.Width / 2, frmMandelbrot.ClientSize.Height / 2);
            _bWorld = new Complex(frmMandelbrot.WorldFromPage(_bPage));
            _crosshair = FractalGraphCs.Properties.Resources.Crosshair;
            _crosshairReplace = new Bitmap(9, 9);
            _movingMandelbrot = false;
            _movingJulia = false;

            _curZoom = new Cursor(GetType(), "Cursor1.cur");
            _curPan = new Cursor(GetType(), "Cursor2.cur");

            fractColor = new FractColor(new FractColorSetupValues(ColorMapType.VariableHue,0.0,1.0,1.0,1.0,1.0,1.0,false,true));
            frmJulia.ColorMap = fractColor.ColorMap;

        }

        void frmJulia_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan && _movingJulia == true)
            {
                int dx = e.X - _beginMove.X;
                int dy = e.Y - _beginMove.Y;
                frmJulia.DragFractal(dx, dy, _bWorld);
                frmJulia.Refresh();
                _beginMove.X = e.X;
                _beginMove.Y = e.Y;
            }
        }

        void frmJulia_MouseDown(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan)
            {
                _movingJulia = true;
                _beginMove = e.Location;
            }
        }

        void frmJulia_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan) _movingMandelbrot = _movingJulia = false;
        }

        void frmMandelbrot_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan) _movingMandelbrot = _movingJulia = false;
        }

        void frmMandelbrot_MouseDown(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan)
            {
                _movingMandelbrot = true;
                _beginMove = e.Location;
            }

        }

        void frmMandelbrot_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Pan && _movingMandelbrot == true)
            {
                int dx = e.X - _beginMove.X;
                int dy = e.Y - _beginMove.Y;
                frmMandelbrot.DragFractal(dx, dy, new Complex(0, 0));
                frmMandelbrot.Refresh();
                _bPage.X += dx;
                _bPage.Y += dy;
                _beginMove.X = e.X;
                _beginMove.Y = e.Y;
            }
        }

        void frmJulia_MouseClick(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Zoom && e.Button==MouseButtons.Left)
            {
                float zoomfactor = Control.ModifierKeys==Keys.Alt? 0.5f : 2.0f;
                frmJulia.ScaleX *= zoomfactor;
                frmJulia.ScaleY *= zoomfactor;
                frmJulia.OffsetX = e.X + zoomfactor * (frmJulia.OffsetX - e.X);
                frmJulia.OffsetY = e.Y + zoomfactor * (frmJulia.OffsetY - e.Y);
                frmJulia.FillFractal(frmJulia.ClientRectangle, _bWorld);
                frmJulia.Refresh();
                return;
            }
        }

        void frmMandelbrot_MouseClick(object sender, MouseEventArgs e)
        {
            if (_mouseMode == MouseMode.Select && e.Button == MouseButtons.Left)
            {
                frmMandelbrot.SetImage(_crosshairReplace, new Point(_bPage.X-4,_bPage.Y-4));
                _bPage = e.Location;
                _crosshairReplace.Dispose();
                _crosshairReplace = frmMandelbrot.GetBitmap(new Point(_bPage.X - 4, _bPage.Y - 4), new Size(9, 9));
                frmMandelbrot.SetImage(_crosshair, new Point(_bPage.X - 4, _bPage.Y - 4));
                _bWorld = new Complex(frmMandelbrot.WorldFromPage(_bPage));
                frmMandelbrot.Refresh();
                frmJulia.FillFractal(frmJulia.ClientRectangle, _bWorld);
                frmJulia.Refresh();
                return;
            }
            
            if (_mouseMode == MouseMode.Zoom && e.Button==MouseButtons.Left)
            {
                float zoomfactor = Control.ModifierKeys == Keys.Alt ? 0.5f : 2.0f;
                frmMandelbrot.ScaleX *= zoomfactor;
                frmMandelbrot.ScaleY *= zoomfactor;
                frmMandelbrot.OffsetX = e.X + zoomfactor * (frmMandelbrot.OffsetX - e.X);
                frmMandelbrot.OffsetY = e.Y + zoomfactor * (frmMandelbrot.OffsetY - e.Y);
                _bPage = frmMandelbrot.PageFromWorld(new PointF((float)_bWorld.Real, (float)_bWorld.Imag));
                frmMandelbrot.FillFractal(frmMandelbrot.ClientRectangle, new Complex(0, 0));
                _crosshairReplace.Dispose();
                _crosshairReplace = frmMandelbrot.GetBitmap(new Point(_bPage.X - 4, _bPage.Y - 4), new Size(9, 9));
                frmMandelbrot.SetImage(_crosshair, new Point(_bPage.X - 4, _bPage.Y - 4));
                frmMandelbrot.Refresh();
                return;
            }
        }

        private void DrawFractals()
        {
            frmMandelbrot.FillFractal(frmMandelbrot.ClientRectangle, new Complex(0, 0));
            _bPage = frmMandelbrot.PageFromWorld(new PointF((float)_bWorld.Real, (float)_bWorld.Imag));
            _crosshairReplace.Dispose();
            _crosshairReplace = frmMandelbrot.GetBitmap(new Point(_bPage.X - 4, _bPage.Y - 4), new Size(9, 9));
            frmMandelbrot.SetImage(_crosshair, new Point(_bPage.X - 4, _bPage.Y - 4));
            frmMandelbrot.Refresh();
            frmJulia.FillFractal(frmJulia.ClientRectangle, _bWorld);
            frmJulia.Refresh();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawFractals();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMouseMode(MouseMode.Select);
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMouseMode(MouseMode.Zoom);
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMouseMode(MouseMode.Pan);
        }

        private void SetMouseMode(MouseMode mode)
        {
            _mouseMode = mode;
            if (mode == MouseMode.Select) frmJulia.Cursor = frmMandelbrot.Cursor = Cursors.Arrow;
            else if (mode == MouseMode.Zoom) frmJulia.Cursor = frmMandelbrot.Cursor = _curZoom;
            else frmJulia.Cursor = frmMandelbrot.Cursor = _curPan;
            selectToolStripMenuItem.Checked = selectToolStripButton.Checked = selectContextMenuItem.Checked = (_mouseMode == MouseMode.Select);
            zoomToolStripMenuItem.Checked = zoomToolStripButton.Checked = zoomContextMenuItem.Checked = (_mouseMode == MouseMode.Zoom);
            panToolStripMenuItem.Checked = panToolStripButton.Checked = panContextMenuItem.Checked = (_mouseMode == MouseMode.Pan);
        }

        private void toolStripSize320_Click(object sender, EventArgs e)
        {
            if (_bitmapSize != 320) ResizeFractals(320);
        }

        private void toolStripSize160_Click(object sender, EventArgs e)
        {
            if (_bitmapSize != 160) ResizeFractals(160);
        }

        private void toolStripSize480_Click(object sender, EventArgs e)
        {
            if (_bitmapSize != 480) ResizeFractals(480);
        }

        private void toolStripSize640_Click(object sender, EventArgs e)
        {
            if (_bitmapSize != 640) ResizeFractals(640);
        }


        private void ResizeFractals(int bitmapSize)
        {
            this.SuspendLayout();
            frmJulia.NewBitmap(bitmapSize + 1, bitmapSize + 1, false, 0, 0);
            frmMandelbrot.NewBitmap(bitmapSize + 1, bitmapSize+1, false, 0,0);
            frmJulia.Left = frmMandelbrot.Width;
            this.ResumeLayout();
            this.PerformLayout();
            frmJulia.ScaleX *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmJulia.ScaleY *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmJulia.OffsetX *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmJulia.OffsetY *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmMandelbrot.ScaleX *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmMandelbrot.ScaleY *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmMandelbrot.OffsetX *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            frmMandelbrot.OffsetY *= ((float)(bitmapSize+1))/(float)(_bitmapSize+1);
            _bitmapSize = bitmapSize;
            DrawFractals();
            
        }

        private void sizeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            toolStripSize160.Checked = _bitmapSize == 160;
            toolStripSize320.Checked = _bitmapSize == 320;
            toolStripSize480.Checked = _bitmapSize == 480;
        }

        private void toolStripMaxiter320_Click(object sender, EventArgs e)
        {
            if (FractBox.MaxIter != 320) ResetMaxiter(320);
        }

        private void toolStripMaxiter160_Click(object sender, EventArgs e)
        {
            if (FractBox.MaxIter != 160) ResetMaxiter(160);
        }

        private void toolStripMaxiter80_Click(object sender, EventArgs e)
        {
            if (FractBox.MaxIter != 80) ResetMaxiter(80);
        }

        private void toolStripMaxiter40_Click(object sender, EventArgs e)
        {
            if (FractBox.MaxIter != 40) ResetMaxiter(40);
        }

        private void ResetMaxiter(int maxIter)
        {
            FractBox.MaxIter = maxIter;
            DrawFractals();
        }

        private void maxIterToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            toolStripMaxiter40.Checked = FractBox.MaxIter == 40;
            toolStripMaxiter80.Checked = FractBox.MaxIter == 80;
            toolStripMaxiter160.Checked = FractBox.MaxIter == 160;
            toolStripMaxiter320.Checked = FractBox.MaxIter == 320;
        }


        private void toolStripBlowout10_Click(object sender, EventArgs e)
        {
            if (FractBox.Blowout < 9.99 || FractBox.Blowout > 10.01) SetBlowout(10.0);
        }

        private void toolStripBlowout50_Click(object sender, EventArgs e)
        {
            if (FractBox.Blowout < 49.99 || FractBox.Blowout > 50.01) SetBlowout(50.0);
        }

        private void toolStripBlowout100_Click(object sender, EventArgs e)
        {
            if (FractBox.Blowout < 99.99 || FractBox.Blowout > 100.01) SetBlowout(100.0);
        }

        private void toolStripBlowout200_Click(object sender, EventArgs e)
        {
            if (FractBox.Blowout < 199.99 || FractBox.Blowout > 200.01) SetBlowout(200.0);
        }

        private void SetBlowout(double b)
        {
            FractBox.Blowout = b;
            toolStripBlowout10.Checked = (b > 9.99 && b < 10.01);
            toolStripBlowout50.Checked = (b > 49.99 && b < 50.01);
            toolStripBlowout100.Checked = (b > 99.99 && b < 100.01);
            toolStripBlowout200.Checked = (b > 199.99 && b < 201.01);
            DrawFractals();
        }

        private void saveBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Files (*.BMP)|*.BMP";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName)) MessageBox.Show("File overwrite not allowed.");
                else frmJulia.SaveBitmap(sfd.FileName);
            }
            sfd.Dispose();
        }

        private void colorSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fractColor.SetupFractColor();
            frmJulia.FillFractal(frmJulia.ClientRectangle, _bWorld);
            frmJulia.Refresh();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem with printing: " + ex.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            frmJulia.PrintFractal(e);
        }

        private void tbxFunction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) return;
            if (tbxFunction.Text.Replace(" ", "") == _funcText) return;

            if (tbxFunction.Text.Replace(" ", "") == "z*z+b")
            {
                FractBox.FracFunc = (Complex z, Complex b) => z * z + b;
                _funcText = "z*z+b";
                ResetFractals();
                return;
            }

            Func<Complex, Complex, Complex> oldFunc = FractBox.FracFunc;

            try
            {
                ComplexExpressionParser ex = new ComplexExpressionParser(tbxFunction.Text, "z", "b");
                FractBox.FracFunc = (Complex z, Complex b) => ex.runnable(new Complex[] { z, b });
                ResetFractals();
                _funcText = tbxFunction.Text.Replace(" ", "");
                return;
            }
            catch (Exception except)
            {
                MessageBox.Show("Error using the entered function: " + except.Message);
                FractBox.FracFunc = oldFunc;
                tbxFunction.Text = _funcText;
            }
        }

        private void ResetFractals()
        {
            frmMandelbrot.InitTransform(frmMandelbrot.ClientSize.Width, frmMandelbrot.ClientSize.Height);
            frmJulia.InitTransform(frmJulia.ClientSize.Width, frmJulia.ClientSize.Height);
            _bPage = new Point(frmMandelbrot.ClientSize.Width / 2, frmMandelbrot.ClientSize.Height / 2);
            _bWorld = new Complex(frmMandelbrot.WorldFromPage(_bPage));
            DrawFractals();
        }

        private void tbxFunction_DoubleClick(object sender, EventArgs e)
        {
            FractBox.FracFunc = (Complex z, Complex b) => z * z + b;
            _funcText = "z*z+b";
            tbxFunction.Text = "z * z + b";
            ResetFractals();
        }

        private void currentParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointF bMandelbrotCenter = frmMandelbrot.WorldFromPage(new Point(frmMandelbrot.ClientSize.Width / 2, frmMandelbrot.ClientSize.Height / 2));
            PointF zJuliaCenter = frmJulia.WorldFromPage(new Point(frmJulia.ClientSize.Width / 2, frmJulia.ClientSize.Height / 2));
            float zoomMandelbrot = 2.0f * frmMandelbrot.ScaleX /(float)frmMandelbrot.ClientSize.Width;
            float zoomJulia = 2.0f * frmJulia.ScaleX / (float)frmJulia.ClientSize.Width;
            MessageBox.Show("Current Parameters:\n"
                + "Selected b value: " + _bWorld.ToString() + "\n"
                + "Center of Mandelbrot image at b = " + bMandelbrotCenter.ToString() + "\n"
                + "Mandelbrot Image Zoom factor = " + zoomMandelbrot.ToString() + "\n"
                + "Center of Julia image at z = " + zJuliaCenter.ToString() + "\n"
                + "Julia Image Zoom Factor = " + zoomJulia.ToString());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FractalGraphCs v1.0.0, James Kenney");
        }



    }
}
