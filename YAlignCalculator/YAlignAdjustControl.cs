using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YAlignCalculator
{
    public partial class YAlignAdjustControl : UserControl
    {
        private int illegalCount = 0;

        public YAlignAdjustControl()
        {
            InitializeComponent();
            textBoxStartY.Text = ((double)407.4f).ToString("R");
            textBoxTargetYLeft.Text = ((double)407.1f).ToString("R");
            textBoxTargetYRight.Text = ((double)407.2f).ToString("R");
        }

        private void radioButtonLimitSolid_Click(object sender, EventArgs e)
        {
            radioButtonLimitSolid.Checked = !radioButtonLimitSolid.Checked;
            if (radioButtonLimitSolid.Checked)
                radioButtonLimitDeadly.Checked = false;
            if (!radioButtonLimitSolid.Checked && !radioButtonLimitDeadly.Checked)
            {
                integerTextBoxHeightLimit.ForeColor = Color.Black;
                integerTextBoxHeightLimit.Text = "";
                integerTextBoxHeightLimit.Enabled = false;
            }
            else
            {
                integerTextBoxHeightLimit.Enabled = true;
            }
        }

        private void radioButtonLimitDeadly_Click(object sender, EventArgs e)
        {
            radioButtonLimitDeadly.Checked = !radioButtonLimitDeadly.Checked;
            if (radioButtonLimitDeadly.Checked)
                radioButtonLimitSolid.Checked = false;
            if (!radioButtonLimitSolid.Checked && !radioButtonLimitDeadly.Checked)
            {
                integerTextBoxHeightLimit.ForeColor = Color.Black;
                integerTextBoxHeightLimit.Text = "";
                integerTextBoxHeightLimit.Enabled = false;
            }
            else
            {
                integerTextBoxHeightLimit.Enabled = true;
            }
        }

        private void buttonYAlignSearch_Click(object sender, EventArgs e)
        {
            if (textBoxStartY.ForeColor == Color.Red)
            {
                System.Media.SystemSounds.Exclamation.Play();
                textBoxStartY.Focus();
            }
            else if (textBoxTargetYLeft.ForeColor == Color.Red)
            {
                System.Media.SystemSounds.Exclamation.Play();
                textBoxTargetYLeft.Focus();
            }
            else if (textBoxTargetYRight.ForeColor == Color.Red)
            {
                System.Media.SystemSounds.Exclamation.Play();
                textBoxTargetYRight.Focus();
            }
            else if (integerTextBoxHeightLimit.ForeColor == Color.Red)
            {
                System.Media.SystemSounds.Exclamation.Play();
                integerTextBoxHeightLimit.Focus();
            }
            else
            {
                textBoxStartY.Enabled = false;
                textBoxTargetYLeft.Enabled = false;
                textBoxTargetYRight.Enabled = false;
                radioButtonLimitSolid.Enabled = false;
                radioButtonLimitDeadly.Enabled = false;
                integerTextBoxHeightLimit.Enabled = false;
                buttonYAlignSearch.Enabled = false;
                buttonYAlignCancel.Enabled = true;
                buttonYAlignCancel.Visible = true;
            }
        }

        private void checkBoxPlatformLanding_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlatformLanding.Checked)
                checkBoxNoBH.Checked = false;
        }

        private void checkBoxNoBH_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoBH.Checked)
                checkBoxPlatformLanding.Checked = false;
        }
    }
}
