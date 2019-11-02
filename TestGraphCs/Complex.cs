using System;
using System.Drawing;

namespace CshComplex
{

    public struct Complex
    {
        public double Real, Imag;

        public Complex(double zx, double zy)
        {
            Real = zx;
            Imag = zy;
        }

        public Complex(PointF pz)
        {
            Real = pz.X;
            Imag = pz.Y;
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Real + z2.Real, z1.Imag + z2.Imag);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.Real - z2.Real, z1.Imag - z2.Imag);
        }

        public static Complex operator -(Complex z)
        {
            return new Complex(-z.Real, -z.Imag);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(z1.Real * z2.Real - z1.Imag * z2.Imag, z1.Real * z2.Imag + z1.Imag * z2.Real);
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            double z2MagSqr = z2.Real * z2.Real + z2.Imag * z2.Imag;
            return new Complex((z1.Real * z2.Real + z1.Imag * z2.Imag) / z2MagSqr, (z1.Imag * z2.Real - z1.Real * z2.Imag) / z2MagSqr);
        }

        public static Complex Exp(Complex z)
        {
            double temp = Math.Exp(z.Real);
            return new Complex(temp * Math.Cos(z.Imag), temp * Math.Sin(z.Imag));
        }

        public static Complex Log(Complex z)
        {
            return new Complex(0.5 * Math.Log(z.Real * z.Real + z.Imag * z.Imag), Math.Atan2(z.Imag, z.Real));
        }

        public static Complex Sin(Complex z)
        {
            return new Complex(Math.Sin(z.Real) * Math.Cosh(z.Imag), Math.Cos(z.Real) * Math.Sinh(z.Imag));
        }

        public static Complex Cos(Complex z)
        {
            return new Complex(Math.Cos(z.Real) * Math.Cosh(z.Imag), -Math.Sin(z.Real) * Math.Sinh(z.Imag));
        }

        public static Complex Pow(Complex z1, Complex z2)
        {
            double R = Math.Sqrt(z1.Real * z1.Real + z1.Imag * z1.Imag);
            if (R == 0.0) return new Complex(0.0, 0.0);
            double theta = Math.Atan2(z1.Imag, z1.Real);
            double logR = Math.Log(R);
            double tempAngle = z2.Imag * logR + z2.Real * theta;
            double temp = Math.Exp(z2.Real * logR - z2.Imag * theta);
            return new Complex(temp * Math.Cos(tempAngle), temp * Math.Sin(tempAngle));
        }

        public override string ToString()
        {
            return "[" + Real.ToString() + "," + Imag.ToString() + "]";
        }

    }

}