using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    public class IntegerTextBox : TextBox
    {
        public IntegerTextBox()
        {
            this.Validated += IntegerTextBox_Validated;
            this.TextChanged += IntegerTextBox_TextChanged;
        }

        private void IntegerTextBox_Validated(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(this.Text, out value))
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.Text = (Math.Round(value)).ToString();
                if (Math.Round(value) < 21)
                    this.ForeColor = Color.Red;
                else
                    this.ForeColor = Color.Black;
            }
        }

        private void IntegerTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }
}
