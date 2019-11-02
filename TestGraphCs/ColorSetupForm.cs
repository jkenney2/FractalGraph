using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FractalGraphCs
{
    public partial class ColorSetupForm : Form
    {
        private FractColorSetupValues _fractColorSetupValues;

        public ColorSetupForm(FractColorSetupValues fractalColorSetupValues)
        {
            _fractColorSetupValues = fractalColorSetupValues;
            InitializeComponent();
            if (_fractColorSetupValues.MapType == ColorMapType.VariableHue)
            {
                this.rbtVariableHue.Checked = true;
            }
            else if (_fractColorSetupValues.MapType == ColorMapType.VariableSat)
            {
                this.rbtVariableSat.Checked = true;
            }
            else
            {
                this.rbtVariableVal.Checked = true;
            }

            this.cbxReverseColors.Checked = this._fractColorSetupValues.ReverseColors;
            this.cbxBlackFill.Checked = this._fractColorSetupValues.BlackFill;
            this.tbMinHue.Value = (int)(100.0 * this._fractColorSetupValues.MinHue);
            this.tbMaxHue.Value = (int)(100.0 * this._fractColorSetupValues.MaxHue);
            this.tbMinSat.Value = (int)(100.0 * this._fractColorSetupValues.MinSat);
            this.tbMaxSat.Value = (int)(100.0 * this._fractColorSetupValues.MaxSat);
            this.tbMinVal.Value = (int)(100.0 * this._fractColorSetupValues.MinVal);
            this.tbMaxVal.Value = (int)(100.0 * this._fractColorSetupValues.MaxVal);

            SetupControls();
        }

        private void SetupControls()
        {
            this.pbxMaxHue.Visible = this.rbtVariableHue.Checked;
            this.tbMaxHue.Visible = this.rbtVariableHue.Checked;
            this.pbxMaxSat.Visible = this.rbtVariableSat.Checked;
            this.tbMaxSat.Visible = this.rbtVariableSat.Checked;
            this.pbxMaxVal.Visible = this.rbtVariableVal.Checked;
            this.tbMaxVal.Visible = this.rbtVariableVal.Checked;
        }

        private void rbtVariableHue_Click(object sender, EventArgs e)
        {
            SetupControls();
        }

        private void rbtVariableSat_Click(object sender, EventArgs e)
        {
            SetupControls();
        }

        private void rbtVariableVal_Click(object sender, EventArgs e)
        {
            SetupControls();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtVariableHue.Checked) this._fractColorSetupValues.MapType = ColorMapType.VariableHue;
            else if (rbtVariableSat.Checked) this._fractColorSetupValues.MapType = ColorMapType.VariableSat;
            else this._fractColorSetupValues.MapType = ColorMapType.VariableValue;

            this._fractColorSetupValues.MinHue = (double)tbMinHue.Value / 100.0;
            this._fractColorSetupValues.MaxHue = (double)tbMaxHue.Value / 100.0;
            this._fractColorSetupValues.MinSat = (double)tbMinSat.Value / 100.0;
            this._fractColorSetupValues.MaxSat = (double)tbMaxSat.Value / 100.0;
            this._fractColorSetupValues.MinVal = (double)tbMinVal.Value / 100.0;
            this._fractColorSetupValues.MaxVal = (double)tbMaxVal.Value / 100.0;
            this._fractColorSetupValues.ReverseColors = cbxReverseColors.Checked;
            this._fractColorSetupValues.BlackFill = cbxBlackFill.Checked;

            this.Tag = this._fractColorSetupValues;

            this.DialogResult = DialogResult.OK;
        }
    }
}
