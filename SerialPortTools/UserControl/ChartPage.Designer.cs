namespace SerialPortTools
{
    partial class ChartPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lbsplit = new System.Windows.Forms.Label();
            this.ChartShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmsSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft.SuspendLayout();
            this.cmsAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartShow)).BeginInit();
            this.cmsSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlList);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(175, 267);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.ContextMenuStrip = this.cmsAdd;
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(175, 267);
            this.pnlList.TabIndex = 4;
            // 
            // cmsAdd
            // 
            this.cmsAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAToolStripMenuItem});
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(147, 26);
            // 
            // addNewAToolStripMenuItem
            // 
            this.addNewAToolStripMenuItem.Name = "addNewAToolStripMenuItem";
            this.addNewAToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNewAToolStripMenuItem.Text = "Add New(&A)";
            this.addNewAToolStripMenuItem.Click += new System.EventHandler(this.addNewAToolStripMenuItem_Click);
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 1000;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // lbsplit
            // 
            this.lbsplit.AutoEllipsis = true;
            this.lbsplit.BackColor = System.Drawing.Color.Black;
            this.lbsplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbsplit.Location = new System.Drawing.Point(175, 0);
            this.lbsplit.Name = "lbsplit";
            this.lbsplit.Size = new System.Drawing.Size(1, 267);
            this.lbsplit.TabIndex = 1;
            this.lbsplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChartShow
            // 
            this.ChartShow.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.ChartShow.ChartAreas.Add(chartArea1);
            this.ChartShow.ContextMenuStrip = this.cmsSave;
            this.ChartShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartShow.Location = new System.Drawing.Point(176, 0);
            this.ChartShow.Name = "ChartShow";
            this.ChartShow.Size = new System.Drawing.Size(496, 267);
            this.ChartShow.TabIndex = 3;
            this.ChartShow.Text = "chart1";
            // 
            // cmsSave
            // 
            this.cmsSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageSToolStripMenuItem});
            this.cmsSave.Name = "cmsSave";
            this.cmsSave.Size = new System.Drawing.Size(160, 48);
            // 
            // saveImageSToolStripMenuItem
            // 
            this.saveImageSToolStripMenuItem.Name = "saveImageSToolStripMenuItem";
            this.saveImageSToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveImageSToolStripMenuItem.Text = "Save Image(&S)";
            this.saveImageSToolStripMenuItem.Click += new System.EventHandler(this.saveImageSToolStripMenuItem_Click);
            // 
            // ChartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChartShow);
            this.Controls.Add(this.lbsplit);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ChartPage";
            this.Size = new System.Drawing.Size(672, 267);
            this.pnlLeft.ResumeLayout(false);
            this.cmsAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartShow)).EndInit();
            this.cmsSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ContextMenuStrip cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem addNewAToolStripMenuItem;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.FlowLayoutPanel pnlList;
        private System.Windows.Forms.Label lbsplit;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartShow;
        private System.Windows.Forms.ContextMenuStrip cmsSave;
        private System.Windows.Forms.ToolStripMenuItem saveImageSToolStripMenuItem;
    }
}
