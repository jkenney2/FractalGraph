using System;
using System.Windows.Forms;
using System.Drawing;

namespace FractalGraphCs
{
    public enum ColorMapType { VariableHue, VariableSat, VariableValue };

    public struct FractColorSetupValues
    {
        public ColorMapType MapType;
        public double MinHue, MaxHue, MinSat, MaxSat, MinVal, MaxVal;
        public bool ReverseColors;
        public bool BlackFill;

        public FractColorSetupValues(ColorMapType mt, double minHue, double maxHue,
                                    double minSat, double maxSat, double minVal, double maxVal,
                                    bool reverseColors, bool blackFill)
        {
            MapType = mt;
            MinHue = minHue;
            MaxHue = maxHue;
            MinSat = minSat;
            MaxSat = maxSat;
            MinVal = minVal;
            MaxVal = maxVal;
            ReverseColors = reverseColors;
            BlackFill = blackFill;
        }
    }

    public class FractColor
    {
        FractColorSetupValues _fractColorSetupValues;

        public FractColor(FractColorSetupValues fractColorSetupValues)
        {
            _fractColorSetupValues = fractColorSetupValues;
        }

        public Color ColorMap(int count, int maxiter)
        {
            if (this._fractColorSetupValues.BlackFill && count>=maxiter) return Color.Black;
            double var1 = (double)count / (double)maxiter;
            if (this._fractColorSetupValues.ReverseColors) var1 = 1.0 - var1;
            double tempMaxHue = this._fractColorSetupValues.MaxHue;
            if (tempMaxHue <= this._fractColorSetupValues.MinHue) tempMaxHue += 1.0;
            double tempMaxSat = this._fractColorSetupValues.MaxSat;
            if (tempMaxSat <= this._fractColorSetupValues.MinSat) tempMaxSat += 1.0;
            double tempMaxVal = this._fractColorSetupValues.MaxVal;
            if (tempMaxVal <= this._fractColorSetupValues.MinVal) tempMaxVal += 1.0;

            if (this._fractColorSetupValues.MapType == ColorMapType.VariableHue)
            {
                double hue = this._fractColorSetupValues.MinHue + var1 * (tempMaxHue - this._fractColorSetupValues.MinHue);
                if (hue > 1.0) hue -= 1.0;
                return ColorFromHSV(hue, this._fractColorSetupValues.MinSat, this._fractColorSetupValues.MinVal);
            }
            else if (this._fractColorSetupValues.MapType == ColorMapType.VariableSat)
            {
                double sat = this._fractColorSetupValues.MinSat + var1 * (tempMaxSat - this._fractColorSetupValues.MinSat);
                if (sat > 1.0) sat -= 1.0;
                return ColorFromHSV(this._fractColorSetupValues.MinHue, sat, this._fractColorSetupValues.MinVal);
            }
            else
            {
                double val = this._fractColorSetupValues.MinVal + var1 * (tempMaxVal - this._fractColorSetupValues.MinVal);
                if (val > 1.0) val -= 1.0;
                return ColorFromHSV(this._fractColorSetupValues.MinHue, this._fractColorSetupValues.MinSat, val);
            }
        }

        public void SetupFractColor()
        {
            ColorSetupForm frmColorSetup = new ColorSetupForm(_fractColorSetupValues);
            DialogResult result = frmColorSetup.ShowDialog();
            if (result == DialogResult.OK) _fractColorSetupValues = (FractColorSetupValues)frmColorSetup.Tag;
            if (frmColorSetup != null) frmColorSetup.Dispose();
        }

        
        public Color ColorFromHSV(double H, double S, double V)
        {
            int R, G, B;
            double var_r, var_g, var_b;

            if ( S == 0 )                       //HSV from 0 to 1
            {
               R = (int)(V * 255.0);
               G = (int)(V * 255.0);
               B = (int)(V * 255.0);
            }
            else
            {
               double var_h = H * 6;
               if ( var_h == 6 ) var_h = 0;      //H must be < 1
               int var_i = (int)var_h;
               double var_1 = V * ( 1 - S );
               double var_2 = V * ( 1 - S * ( var_h - var_i ) );
               double var_3 = V * ( 1 - S * ( 1 - ( var_h - var_i ) ) );

               if      ( var_i == 0 ) { var_r = V     ; var_g = var_3 ; var_b = var_1; }
               else if ( var_i == 1 ) { var_r = var_2 ; var_g = V     ; var_b = var_1; }
               else if ( var_i == 2 ) { var_r = var_1 ; var_g = V     ; var_b = var_3; }
               else if ( var_i == 3 ) { var_r = var_1 ; var_g = var_2 ; var_b = V ;    }
               else if ( var_i == 4 ) { var_r = var_3 ; var_g = var_1 ; var_b = V ;    }
               else                   { var_r = V     ; var_g = var_1 ; var_b = var_2; }

               R = (int)(var_r * 255.0);                  //RGB results from 0 to 255
               G = (int)(var_g * 255.0);
               B = (int)(var_b * 255.0);
            }

            return Color.FromArgb(R, G, B);

        }
    }
}