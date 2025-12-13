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
        private void checkBoxPlatformLanding_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlatformLanding.Checked)
                checkBoxNoBunnyHop.Checked = false;
        }

        private void checkBoxNoBunnyHop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoBunnyHop.Checked)
                checkBoxPlatformLanding.Checked = false;
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
                // New calculation thread start...

                textBoxStartY.Enabled = false;
                textBoxTargetYLeft.Enabled = false;
                textBoxTargetYRight.Enabled = false;
                radioButtonLimitSolid.Enabled = false;
                radioButtonLimitDeadly.Enabled = false;
                integerTextBoxHeightLimit.Enabled = false;
                buttonYAlignSearch.Enabled = false;
                radioButtonStrategyEasiest.Enabled = false;
                radioButtonStrategyFastest.Enabled = false;
                checkBoxCactus.Enabled = false;
                checkBoxJumpCancel.Enabled = false;
                checkBoxPlatformLanding.Enabled = false;
                checkBoxSingleJumpOnly.Enabled = false;
                checkBoxNoBunnyHop.Enabled = false;

                buttonYAlignSearch.Enabled = false;
                buttonYAlignCancel.Enabled = true;
                buttonYAlignCancel.Visible = true;
            }
        }

        private void buttonYAlignCancel_Click(object sender, EventArgs e)
        {
            // Cancel calculation thread...
            textBoxStartY.Enabled = true;
            textBoxTargetYLeft.Enabled = true;
            textBoxTargetYRight.Enabled = true;
            radioButtonLimitSolid.Enabled = true;
            radioButtonLimitDeadly.Enabled = true;
            integerTextBoxHeightLimit.Enabled = true;
            buttonYAlignSearch.Enabled = true;
            radioButtonStrategyEasiest.Enabled = true;
            radioButtonStrategyFastest.Enabled = true;
            checkBoxCactus.Enabled = true;
            checkBoxJumpCancel.Enabled = true;
            checkBoxPlatformLanding.Enabled = true;
            checkBoxSingleJumpOnly.Enabled = true;
            checkBoxNoBunnyHop.Enabled = true;

            buttonYAlignSearch.Enabled = true;
            buttonYAlignCancel.Enabled = false;
            buttonYAlignCancel.Visible = false;
        }

        private void richTextBoxResult_MouseDown(object sender, MouseEventArgs e)
        {
            ((RichTextBox)sender).Parent.Focus();
        }
    }
}
