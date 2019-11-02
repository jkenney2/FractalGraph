using System;
using System.Drawing;
using CshComplex;
using GraphicsBox;
using System.Threading;
using System.Drawing.Printing;
using System.Windows.Forms;
using ComplexExpressionCs;

namespace FractalGraphCs
{
    public delegate Color ColorMapDelegate(int count, int maxiter);
    public enum FractalType { Mandelbrot, Julia };

    public class FractBox : GraphBox
    {
        protected static Func<Complex, Complex, Complex> _fracFunc;
        protected static int _maxIter;
        protected static double _blowout;
        protected FractalType _fractalType;
        protected ColorMapDelegate _colorMap;
        private bool _fractBoxDisposed = false;

        static FractBox()
        {
            _maxIter = 40;
            _blowout = 10;
            FracFunc = (Complex z, Complex b) => { return z * z + b; };
        }

        public FractBox(Int32 fractwidth, Int32 fractheight, FractalType fracType) :
            base(fractwidth, fractheight)
        {
            _fractalType = fracType;
            InitTransform(fractwidth, fractheight);
            if (_fractalType == FractalType.Mandelbrot) ColorMap = this.ColorMapMandelbrot;
            else ColorMap = this.ColorMapJulia;
        }

        public void InitTransform(Int32 fractwidth, Int32 fractheight)
        {
            this.ScaleX = (float)fractwidth / 2.0f;
            this.ScaleY = -(float)fractheight / 2.0f;
            this.OffsetX = (float)fractwidth / 2.0f;
            this.OffsetY = (float)fractheight / 2.0f;
        }

        public void FillFractal(Rectangle rect, Complex b)
        {
            int top = rect.Top < 0 ? 0 : rect.Top;
            int bottom = rect.Bottom > this._bitmap.Size.Height ? this._bitmap.Size.Height : rect.Bottom;
            int left = rect.Left < 0 ? 0 : rect.Left;
            int right = rect.Right > this._bitmap.Size.Width ? this._bitmap.Size.Width : rect.Right;
            for (int j = top; j < bottom; j++)
                for (int i = left; i < right; i++)
                {
                    PointF pxy = WorldFromPage(new Point(i, j));
                    Complex btemp = _fractalType == FractalType.Julia ? b : new Complex(pxy);
                    Complex z = _fractalType == FractalType.Julia ? new Complex(pxy) : new Complex(0, 0);
                    _bitmap.SetPixel(i, j, GetFractalColor(z, btemp));
                }
        }

        public void DragFractal(int dx, int dy, Complex b)
        {
            this.OffsetX += dx;
            this.OffsetY += dy;
            Rectangle rect1, rect2;
            Bitmap tempBitmap = null;
            try
            {
                tempBitmap = (Bitmap)(_bitmap.Clone());
                using (Graphics g = Graphics.FromImage(_bitmap))
                {
                    g.DrawImage(tempBitmap, dx, dy);
                }
                if (dx > 0)
                {
                    rect1 = new Rectangle(0, 0, dx, _bitmap.Height);
                    if (dy > 0) rect2 = new Rectangle(dx, 0, _bitmap.Width - dx, dy);
                    else rect2 = new Rectangle(dx, _bitmap.Height + dy, _bitmap.Width - dx, -dy);
                }
                else
                {
                    rect1 = new Rectangle(_bitmap.Width + dx, 0, -dx, _bitmap.Height);
                    if (dy > 0) rect2 = new Rectangle(0, 0, _bitmap.Width + dx, dy);
                    else rect2 = new Rectangle(0, _bitmap.Height + dy, _bitmap.Width + dx, -dy);
                }
                FillFractal(rect1, b);
                FillFractal(rect2, b);
            }
            finally
            {
                if (tempBitmap != null) tempBitmap.Dispose();
            }
        }

        protected Color GetFractalColor(Complex z, Complex b)
        {
            Complex ztemp = z;
            int count = 0;
            do
            {
                ztemp = _fracFunc(ztemp, b);
                count += 1;
            } while (count < _maxIter && (ztemp.Real * ztemp.Real + ztemp.Imag * ztemp.Imag) < _blowout);
            return _colorMap(count, _maxIter);
        }

        public static Func<Complex, Complex, Complex> FracFunc
        {
            get
            {
                return _fracFunc;
            }
            set
            {
                _fracFunc = value;
            }
        }

        protected Color ColorMapMandelbrot(int count, int maxiter)
        {
            if (count >= maxiter) return Color.Black; else return Color.Gray;
        }

        protected Color ColorMapJulia(int count, int maxiter)
        {
            if (count >= maxiter) return Color.Black; else return Color.Gray;
        }



        public static int MaxIter
        {
            get { return _maxIter; }
            set
            {
                if (value <= 40) _maxIter = 40;
                else if (value < 320) _maxIter = value;
                else _maxIter = 320;
            }
        }

        public static double Blowout
        {
            get { return _blowout; }
            set
            {
                if (value <= 10) _blowout = 10;
                else if (value < 1000) _blowout = value;
                else _blowout = 1000;
            }
        }

        public ColorMapDelegate ColorMap
        {
            set
            {
                this._colorMap = value;
            }
        }

        public void SaveBitmap(string filename)
        {
            try
            {
                _bitmap.Save(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the bitmap: " + ex.ToString());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!this._fractBoxDisposed)
            {
                base.Dispose(disposing);
                this._fractBoxDisposed = true;
            }
        }

        public void PrintFractal(PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_bitmap,e.MarginBounds.X, e.MarginBounds.Y);
        }

    }
}