using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YAlignCalculator
{
    public class FloatStepperTextBox : TextBox
    {
        public FloatStepperTextBox()
        {
            this.PreviewKeyDown += FloatStepperTextBox_PreviewKeyDown;
            this.KeyDown += FloatStepperTextBox_KeyDown;
            this.Validated += FloatStepperTextBox_Validated;
            this.TextChanged += FloatStepperTextBox_TextChanged;
        }

        private void FloatStepperTextBox_Validated(object sender, EventArgs e)
        {
            float value;
            if (!float.TryParse(this.Text, out value))
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.ForeColor = Color.Black;
                this.Text = ((double)value).ToString("R");
            }
        }

        private void FloatStepperTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                float value;
                if (float.TryParse(this.Text, out value))
                {
                    FloatNumberControl floatNumberControl = new FloatNumberControl();
                    if (e.KeyCode == Keys.Up)
                    {
                        value = floatNumberControl.FloatNext(value);
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        value = floatNumberControl.FloatPrev(value);
                    }
                    this.Text = ((double)value).ToString("R");
                    e.Handled = true;
                }
            }
        }

        private void FloatStepperTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void FloatStepperTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }
}
