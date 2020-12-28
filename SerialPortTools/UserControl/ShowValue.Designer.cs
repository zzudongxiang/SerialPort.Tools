namespace SerialPortTools
{
    partial class ShowValue
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Location = new System.Drawing.Point(4, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(108, 14);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            this.lbTitle.TextChanged += new System.EventHandler(this.lbTitle_TextChanged);
            // 
            // lbValue
            // 
            this.lbValue.BackColor = System.Drawing.Color.White;
            this.lbValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbValue.Font = new System.Drawing.Font("宋体", 19F);
            this.lbValue.Location = new System.Drawing.Point(1, 23);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(118, 36);
            this.lbValue.TabIndex = 3;
            this.lbValue.Text = "+200.000";
            this.lbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbValue.Click += new System.EventHandler(this.lbValue_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(1, 1);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Size = new System.Drawing.Size(118, 22);
            this.pnlTitle.TabIndex = 4;
            // 
            // ShowValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.pnlTitle);
            this.Name = "ShowValue";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(120, 60);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lbTitle;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Panel pnlTitle;
    }
}
