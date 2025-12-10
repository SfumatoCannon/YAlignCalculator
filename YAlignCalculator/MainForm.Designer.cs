namespace YAlignCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageYAlignAdjust = new System.Windows.Forms.TabPage();
            this.yAlignAdjustControl1 = new YAlignCalculator.YAlignAdjustControl();
            this.tabPageYStringCalc = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageYAlignAdjust.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYAlignAdjust);
            this.tabControl1.Controls.Add(this.tabPageYStringCalc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageYAlignAdjust
            // 
            this.tabPageYAlignAdjust.Controls.Add(this.yAlignAdjustControl1);
            this.tabPageYAlignAdjust.Location = new System.Drawing.Point(4, 28);
            this.tabPageYAlignAdjust.Name = "tabPageYAlignAdjust";
            this.tabPageYAlignAdjust.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYAlignAdjust.Size = new System.Drawing.Size(1017, 595);
            this.tabPageYAlignAdjust.TabIndex = 0;
            this.tabPageYAlignAdjust.Text = "YA Adjust";
            this.tabPageYAlignAdjust.UseVisualStyleBackColor = true;
            // 
            // yAlignAdjustControl1
            // 
            this.yAlignAdjustControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yAlignAdjustControl1.Location = new System.Drawing.Point(3, 3);
            this.yAlignAdjustControl1.Name = "yAlignAdjustControl1";
            this.yAlignAdjustControl1.Padding = new System.Windows.Forms.Padding(20);
            this.yAlignAdjustControl1.Size = new System.Drawing.Size(1011, 589);
            this.yAlignAdjustControl1.TabIndex = 0;
            // 
            // tabPageYStringCalc
            // 
            this.tabPageYStringCalc.Location = new System.Drawing.Point(4, 28);
            this.tabPageYStringCalc.Name = "tabPageYStringCalc";
            this.tabPageYStringCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYStringCalc.Size = new System.Drawing.Size(1017, 595);
            this.tabPageYStringCalc.TabIndex = 1;
            this.tabPageYStringCalc.Text = "YString Calc";
            this.tabPageYStringCalc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "YAlignCalculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPageYAlignAdjust.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageYAlignAdjust;
        private System.Windows.Forms.TabPage tabPageYStringCalc;
        private YAlignAdjustControl yAlignAdjustControl1;
    }
}

