namespace SerialPortTools
{
    partial class ThresholdValue
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
            this.components = new System.ComponentModel.Container();
            this.pnlValueTitle = new System.Windows.Forms.Panel();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lbValueTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.lbShow = new System.Windows.Forms.Label();
            this.pnlValueSetting = new System.Windows.Forms.Panel();
            this.lbBackColor = new System.Windows.Forms.Label();
            this.lbFontColor = new System.Windows.Forms.Label();
            this.pnlValueTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlValue.SuspendLayout();
            this.pnlValueSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlValueTitle
            // 
            this.pnlValueTitle.Controls.Add(this.nudValue);
            this.pnlValueTitle.Controls.Add(this.lbValueTitle);
            this.pnlValueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValueTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlValueTitle.Name = "pnlValueTitle";
            this.pnlValueTitle.Padding = new System.Windows.Forms.Padding(5);
            this.pnlValueTitle.Size = new System.Drawing.Size(100, 36);
            this.pnlValueTitle.TabIndex = 4;
            // 
            // nudValue
            // 
            this.nudValue.BackColor = System.Drawing.SystemColors.Control;
            this.nudValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValue.Location = new System.Drawing.Point(43, 5);
            this.nudValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(52, 26);
            this.nudValue.TabIndex = 2;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // lbValueTitle
            // 
            this.lbValueTitle.AutoEllipsis = true;
            this.lbValueTitle.ContextMenuStrip = this.contextMenuStrip1;
            this.lbValueTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbValueTitle.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbValueTitle.Location = new System.Drawing.Point(5, 5);
            this.lbValueTitle.Name = "lbValueTitle";
            this.lbValueTitle.Size = new System.Drawing.Size(38, 26);
            this.lbValueTitle.TabIndex = 0;
            this.lbValueTitle.Text = "Value";
            this.lbValueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 26);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(157, 22);
            this.tsmDelete.Text = "Delete This(&D)";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.lbShow);
            this.pnlValue.Controls.Add(this.pnlValueSetting);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValue.Location = new System.Drawing.Point(0, 36);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnlValue.Size = new System.Drawing.Size(100, 45);
            this.pnlValue.TabIndex = 6;
            // 
            // lbShow
            // 
            this.lbShow.AutoEllipsis = true;
            this.lbShow.BackColor = System.Drawing.Color.White;
            this.lbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShow.ContextMenuStrip = this.contextMenuStrip1;
            this.lbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbShow.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbShow.Location = new System.Drawing.Point(5, 0);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(70, 40);
            this.lbShow.TabIndex = 2;
            this.lbShow.Text = "#Value";
            this.lbShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlValueSetting
            // 
            this.pnlValueSetting.Controls.Add(this.lbBackColor);
            this.pnlValueSetting.Controls.Add(this.lbFontColor);
            this.pnlValueSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlValueSetting.Location = new System.Drawing.Point(75, 0);
            this.pnlValueSetting.Name = "pnlValueSetting";
            this.pnlValueSetting.Size = new System.Drawing.Size(20, 40);
            this.pnlValueSetting.TabIndex = 1;
            // 
            // lbBackColor
            // 
            this.lbBackColor.AutoEllipsis = true;
            this.lbBackColor.BackColor = System.Drawing.Color.White;
            this.lbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBackColor.ContextMenuStrip = this.contextMenuStrip1;
            this.lbBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBackColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBackColor.Location = new System.Drawing.Point(0, 20);
            this.lbBackColor.Name = "lbBackColor";
            this.lbBackColor.Size = new System.Drawing.Size(20, 20);
            this.lbBackColor.TabIndex = 4;
            this.lbBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBackColor.Click += new System.EventHandler(this.lbColor_Click);
            // 
            // lbFontColor
            // 
            this.lbFontColor.AutoEllipsis = true;
            this.lbFontColor.BackColor = System.Drawing.Color.Black;
            this.lbFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFontColor.ContextMenuStrip = this.contextMenuStrip1;
            this.lbFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFontColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFontColor.Location = new System.Drawing.Point(0, 0);
            this.lbFontColor.Name = "lbFontColor";
            this.lbFontColor.Size = new System.Drawing.Size(20, 20);
            this.lbFontColor.TabIndex = 3;
            this.lbFontColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFontColor.Click += new System.EventHandler(this.lbColor_Click);
            // 
            // ThresholdValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlValue);
            this.Controls.Add(this.pnlValueTitle);
            this.Name = "ThresholdValue";
            this.Size = new System.Drawing.Size(100, 81);
            this.pnlValueTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlValue.ResumeLayout(false);
            this.pnlValueSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlValueTitle;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lbValueTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Panel pnlValueSetting;
        private System.Windows.Forms.Label lbBackColor;
        private System.Windows.Forms.Label lbFontColor;
    }
}
