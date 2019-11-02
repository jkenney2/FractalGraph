using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphicsBox
{
    public class GraphBox : PictureBox
    {
        protected Bitmap _bitmap;
        protected Matrix _matrix;
        private bool _graphBoxDisposed = false;

        public GraphBox(int width, int height)
        {
           this.Initialize(width,height);
        }

        protected void Initialize(int width, int height)
        {
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.BorderStyle = BorderStyle.Fixed3D;
            _bitmap = new Bitmap(width, height);
            this.Image = _bitmap;
            _matrix = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f);
        }

        public Graphics BitmapGraphics
        {
            get
            {
                Graphics bmg = Graphics.FromImage(this._bitmap);
                bmg.Transform = this._matrix;
                return bmg;
            }
        }

        public void NewBitmap(Int32 width, Int32 height, bool CopyOld, Int32 xcopy, Int32 ycopy)
        {
            Bitmap newBitmap = new Bitmap(width, height);
            if (CopyOld)
            {
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.DrawImage(this._bitmap, xcopy, ycopy);
                }
            }
            this._bitmap.Dispose();
            this._bitmap = newBitmap;
            this.Image = this._bitmap;
        }

        public Bitmap GetBitmap(Point position, Size size)
        {
            Bitmap bm = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.DrawImage(_bitmap, 0, 0, new Rectangle(position, size), GraphicsUnit.Pixel);
            }
            return bm;
        }

        public void SetImage(Image img, Point position)
        {
            using (Graphics g = Graphics.FromImage(_bitmap))
            {
                g.DrawImage(img, position);
            }
        }

        public float ScaleX
        {
            get { return this._matrix.Elements[0]; }
            set
            {
                float[] e = (float[])_matrix.Elements.Clone();
                _matrix.Dispose();
                this._matrix = new Matrix(value, e[1], e[2], e[3], e[4], e[5]);
            }
        }

        public float ScaleY
        {
            get { return this._matrix.Elements[3]; }
            set
            {
                float[] e = (float[])_matrix.Elements.Clone();
                _matrix.Dispose();
                this._matrix = new Matrix(e[0], e[1], e[2], value, e[4], e[5]);
            }
        }

        public float OffsetX
        {
            get { return this._matrix.Elements[4]; }
            set
            {
                float[] e = (float[])_matrix.Elements.Clone();
                _matrix.Dispose();
                this._matrix = new Matrix(e[0], e[1], e[2], e[3], value, e[5]);
            }
        }

        public float OffsetY
        {
            get { return this._matrix.Elements[5]; }
            set
            {
                float[] e = (float[])_matrix.Elements.Clone();
                _matrix.Dispose();
                this._matrix = new Matrix(e[0], e[1], e[2], e[3], e[4], value);
            }
        }

        public PointF WorldFromPage(Point pPage)
        {
            Matrix mInv = this._matrix.Clone();
            mInv.Invert();
            PointF pTemp = new PointF((float)pPage.X * mInv.Elements[0] + (float)pPage.Y * mInv.Elements[2] + mInv.Elements[4],
                                (float)pPage.X * mInv.Elements[1] + (float)pPage.Y * mInv.Elements[3] + mInv.Elements[5]);
            mInv.Dispose();
            return pTemp;
        }

        public Point PageFromWorld(PointF pWorld)
        {
            return new Point((int)(pWorld.X * _matrix.Elements[0] + pWorld.Y * _matrix.Elements[2] + _matrix.Elements[4]),
                             (int)(pWorld.X * _matrix.Elements[1] + pWorld.Y * _matrix.Elements[3] + _matrix.Elements[5]));
        }

        public void SetPixel(int x, int y, Color c)
        {
            this._bitmap.SetPixel(x, y, c);
        }

        public Color GetPixel(int x, int y)
        {
            return this._bitmap.GetPixel(x, y);
        }

        protected override void Dispose(bool disposing)
        {
            if (!this._graphBoxDisposed)
            {
                if (disposing)
                {
                    _bitmap.Dispose();
                    _matrix.Dispose();
                }
                base.Dispose(disposing);
                this._graphBoxDisposed = true;
            }
        }

    }
}