namespace SerialPortTools
{
    partial class ChartSetting
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
            this.cbxShow = new System.Windows.Forms.CheckBox();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.trbSize = new System.Windows.Forms.TrackBar();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbSelect = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnlSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSize)).BeginInit();
            this.pnlName.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxShow
            // 
            this.cbxShow.AutoCheck = false;
            this.cbxShow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxShow.Location = new System.Drawing.Point(2, 2);
            this.cbxShow.Name = "cbxShow";
            this.cbxShow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.cbxShow.Size = new System.Drawing.Size(144, 20);
            this.cbxShow.TabIndex = 0;
            this.cbxShow.Text = "×  Null";
            this.cbxShow.UseVisualStyleBackColor = true;
            this.cbxShow.CheckedChanged += new System.EventHandler(this.cbxShow_CheckedChanged);
            this.cbxShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbxShow_MouseDown);
            this.cbxShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbxShow_MouseMove);
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.trbSize);
            this.pnlSize.Controls.Add(this.lbSize);
            this.pnlSize.Controls.Add(this.lbSelect);
            this.pnlSize.Controls.Add(this.lbColor);
            this.pnlSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSize.Location = new System.Drawing.Point(2, 47);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Padding = new System.Windows.Forms.Padding(0, 2, 5, 3);
            this.pnlSize.Size = new System.Drawing.Size(144, 25);
            this.pnlSize.TabIndex = 10;
            // 
            // trbSize
            // 
            this.trbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbSize.LargeChange = 1;
            this.trbSize.Location = new System.Drawing.Point(60, 2);
            this.trbSize.Maximum = 8;
            this.trbSize.Minimum = 1;
            this.trbSize.Name = "trbSize";
            this.trbSize.Size = new System.Drawing.Size(68, 20);
            this.trbSize.TabIndex = 9;
            this.trbSize.Value = 1;
            this.trbSize.Scroll += new System.EventHandler(this.trbSize_Scroll);
            // 
            // lbSize
            // 
            this.lbSize.AutoEllipsis = true;
            this.lbSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSize.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSize.Location = new System.Drawing.Point(128, 2);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(11, 20);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "1";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSelect
            // 
            this.lbSelect.AutoEllipsis = true;
            this.lbSelect.BackColor = System.Drawing.Color.Red;
            this.lbSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSelect.Location = new System.Drawing.Point(40, 2);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(20, 20);
            this.lbSelect.TabIndex = 3;
            this.lbSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSelect.Click += new System.EventHandler(this.lbSelect_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoEllipsis = true;
            this.lbColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbColor.Location = new System.Drawing.Point(0, 2);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(40, 20);
            this.lbColor.TabIndex = 0;
            this.lbColor.Text = "Color";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.cbxName);
            this.pnlName.Controls.Add(this.lbName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(2, 22);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlName.Size = new System.Drawing.Size(144, 25);
            this.pnlName.TabIndex = 9;
            // 
            // cbxName
            // 
            this.cbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(40, 2);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(104, 20);
            this.cbxName.TabIndex = 1;
            this.cbxName.SelectedIndexChanged += new System.EventHandler(this.cbxName_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoEllipsis = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Location = new System.Drawing.Point(0, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChartSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlSize);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.cbxShow);
            this.Name = "ChartSetting";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(148, 73);
            this.Load += new System.EventHandler(this.ChartSetting_Load);
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSize)).EndInit();
            this.pnlName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxShow;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.TrackBar trbSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Label lbName;
    }
}
