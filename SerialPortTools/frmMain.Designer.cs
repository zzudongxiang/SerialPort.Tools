namespace SerialPortTools
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmOperate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefreshSerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExportData = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPortName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBaudRate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDataBits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStopBits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmParity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReceiveData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSystemLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmWhatsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRxCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.spLeft = new System.Windows.Forms.Splitter();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.spDown = new System.Windows.Forms.Splitter();
            this.lbShowTitle = new System.Windows.Forms.Label();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsAddThreshold = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDefaultValue = new System.Windows.Forms.Panel();
            this.lbDefaultShow = new System.Windows.Forms.Label();
            this.pnlDefaultValueSetting = new System.Windows.Forms.Panel();
            this.lbBackColor = new System.Windows.Forms.Label();
            this.lbFontColor = new System.Windows.Forms.Label();
            this.bgwRefreshSerialPort = new System.ComponentModel.BackgroundWorker();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.cmsAddThreshold.SuspendLayout();
            this.pnlDefaultValue.SuspendLayout();
            this.pnlDefaultValueSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOperate,
            this.tsmPortName,
            this.tsmBaudRate,
            this.tsmDataBits,
            this.tsmStopBits,
            this.tsmParity,
            this.tsmHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(840, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmOperate
            // 
            this.tsmOperate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRefreshSerialPort,
            this.tss3,
            this.tsmConnect,
            this.tsmDisConnect,
            this.tss5,
            this.tsmAddNew,
            this.tss2,
            this.tsmExportData,
            this.tss1,
            this.tsmExit});
            this.tsmOperate.Name = "tsmOperate";
            this.tsmOperate.Size = new System.Drawing.Size(86, 21);
            this.tsmOperate.Text = "Operate(&O)";
            // 
            // tsmRefreshSerialPort
            // 
            this.tsmRefreshSerialPort.Name = "tsmRefreshSerialPort";
            this.tsmRefreshSerialPort.Size = new System.Drawing.Size(196, 22);
            this.tsmRefreshSerialPort.Text = "Refresh SerialPort(&R)";
            this.tsmRefreshSerialPort.Click += new System.EventHandler(this.tsmRefreshSerialPort_Click);
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmConnect
            // 
            this.tsmConnect.Name = "tsmConnect";
            this.tsmConnect.Size = new System.Drawing.Size(196, 22);
            this.tsmConnect.Text = "Connect(&C)";
            this.tsmConnect.Click += new System.EventHandler(this.tsmConnect_Click);
            // 
            // tsmDisConnect
            // 
            this.tsmDisConnect.Name = "tsmDisConnect";
            this.tsmDisConnect.Size = new System.Drawing.Size(196, 22);
            this.tsmDisConnect.Text = "Disconnect(&D)";
            this.tsmDisConnect.Click += new System.EventHandler(this.tsmDisConnect_Click);
            // 
            // tss5
            // 
            this.tss5.Name = "tss5";
            this.tss5.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmAddNew
            // 
            this.tsmAddNew.Name = "tsmAddNew";
            this.tsmAddNew.Size = new System.Drawing.Size(196, 22);
            this.tsmAddNew.Text = "Add New Chart(&A)";
            this.tsmAddNew.Click += new System.EventHandler(this.tsmAddChart_Click);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmExportData
            // 
            this.tsmExportData.Name = "tsmExportData";
            this.tsmExportData.Size = new System.Drawing.Size(196, 22);
            this.tsmExportData.Text = "Export Data(&E)";
            this.tsmExportData.Click += new System.EventHandler(this.tsmExportData_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(196, 22);
            this.tsmExit.Text = "Exit(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmPortName
            // 
            this.tsmPortName.Name = "tsmPortName";
            this.tsmPortName.Size = new System.Drawing.Size(97, 21);
            this.tsmPortName.Tag = "PortName(&N)";
            this.tsmPortName.Text = "PortName(&N)";
            // 
            // tsmBaudRate
            // 
            this.tsmBaudRate.Name = "tsmBaudRate";
            this.tsmBaudRate.Size = new System.Drawing.Size(92, 21);
            this.tsmBaudRate.Tag = "BaudRate(&B)";
            this.tsmBaudRate.Text = "BaudRate(&B)";
            // 
            // tsmDataBits
            // 
            this.tsmDataBits.Name = "tsmDataBits";
            this.tsmDataBits.Size = new System.Drawing.Size(85, 21);
            this.tsmDataBits.Tag = "DataBits(&D)";
            this.tsmDataBits.Text = "DataBits(&D)";
            // 
            // tsmStopBits
            // 
            this.tsmStopBits.Name = "tsmStopBits";
            this.tsmStopBits.Size = new System.Drawing.Size(83, 21);
            this.tsmStopBits.Tag = "StopBits(&S)";
            this.tsmStopBits.Text = "StopBits(&S)";
            // 
            // tsmParity
            // 
            this.tsmParity.Name = "tsmParity";
            this.tsmParity.Size = new System.Drawing.Size(67, 21);
            this.tsmParity.Tag = "Parity(&P)";
            this.tsmParity.Text = "Parity(&P)";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReceiveData,
            this.tsmSystemLogs,
            this.tss4,
            this.tsmWhatsNew,
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(64, 21);
            this.tsmHelp.Text = "Help(&H)";
            // 
            // tsmReceiveData
            // 
            this.tsmReceiveData.Name = "tsmReceiveData";
            this.tsmReceiveData.Size = new System.Drawing.Size(163, 22);
            this.tsmReceiveData.Text = "ReceiveData(&R)";
            this.tsmReceiveData.Click += new System.EventHandler(this.tsmReceiveData_Click);
            // 
            // tsmSystemLogs
            // 
            this.tsmSystemLogs.Name = "tsmSystemLogs";
            this.tsmSystemLogs.Size = new System.Drawing.Size(163, 22);
            this.tsmSystemLogs.Text = "SystemLogs(&I)";
            this.tsmSystemLogs.Click += new System.EventHandler(this.tsmSystemLogs_Click);
            // 
            // tss4
            // 
            this.tss4.Name = "tss4";
            this.tss4.Size = new System.Drawing.Size(160, 6);
            // 
            // tsmWhatsNew
            // 
            this.tsmWhatsNew.Name = "tsmWhatsNew";
            this.tsmWhatsNew.Size = new System.Drawing.Size(163, 22);
            this.tsmWhatsNew.Text = "What‘s New(&S)";
            this.tsmWhatsNew.Click += new System.EventHandler(this.tsmWhatsNew_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(163, 22);
            this.tsmAbout.Text = "About(&A)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslRxCount,
            this.tsslDataCount});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 548);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(840, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(44, 17);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "Ready";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslRxCount
            // 
            this.tsslRxCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsslRxCount.AutoSize = false;
            this.tsslRxCount.Name = "tsslRxCount";
            this.tsslRxCount.Size = new System.Drawing.Size(120, 17);
            this.tsslRxCount.Text = "RxCount: 0";
            this.tsslRxCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslDataCount
            // 
            this.tsslDataCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsslDataCount.AutoSize = false;
            this.tsslDataCount.Name = "tsslDataCount";
            this.tsslDataCount.Size = new System.Drawing.Size(120, 17);
            this.tsslDataCount.Text = "DataCount: 0";
            this.tsslDataCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.lbTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLeft.Size = new System.Drawing.Size(200, 523);
            this.pnlLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 54);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(190, 464);
            this.panel1.TabIndex = 12;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(5, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(190, 49);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Device List";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spLeft
            // 
            this.spLeft.Location = new System.Drawing.Point(200, 25);
            this.spLeft.Name = "spLeft";
            this.spLeft.Size = new System.Drawing.Size(3, 523);
            this.spLeft.TabIndex = 4;
            this.spLeft.TabStop = false;
            // 
            // tabChart
            // 
            this.tabChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabChart.HotTrack = true;
            this.tabChart.Location = new System.Drawing.Point(203, 334);
            this.tabChart.MinimumSize = new System.Drawing.Size(0, 180);
            this.tabChart.Multiline = true;
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(637, 214);
            this.tabChart.TabIndex = 5;
            this.tabChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabChart_MouseDown);
            this.tabChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabChart_MouseMove);
            // 
            // spDown
            // 
            this.spDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spDown.Location = new System.Drawing.Point(203, 331);
            this.spDown.Name = "spDown";
            this.spDown.Size = new System.Drawing.Size(637, 3);
            this.spDown.TabIndex = 6;
            this.spDown.TabStop = false;
            // 
            // lbShowTitle
            // 
            this.lbShowTitle.AutoEllipsis = true;
            this.lbShowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbShowTitle.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTitle.Location = new System.Drawing.Point(203, 25);
            this.lbShowTitle.Name = "lbShowTitle";
            this.lbShowTitle.Size = new System.Drawing.Size(637, 49);
            this.lbShowTitle.TabIndex = 13;
            this.lbShowTitle.Text = "Real-time Data Display";
            this.lbShowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(203, 74);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(527, 257);
            this.flpMain.TabIndex = 16;
            // 
            // pnlConfig
            // 
            this.pnlConfig.AutoScroll = true;
            this.pnlConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.ContextMenuStrip = this.cmsAddThreshold;
            this.pnlConfig.Controls.Add(this.label1);
            this.pnlConfig.Controls.Add(this.pnlDefaultValue);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfig.Location = new System.Drawing.Point(730, 74);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(110, 257);
            this.pnlConfig.TabIndex = 15;
            // 
            // cmsAddThreshold
            // 
            this.cmsAddThreshold.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd});
            this.cmsAddThreshold.Name = "cmsAddThreshold";
            this.cmsAddThreshold.Size = new System.Drawing.Size(147, 26);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(146, 22);
            this.tsmAdd.Text = "Add New(&A)";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDefaultValue
            // 
            this.pnlDefaultValue.ContextMenuStrip = this.cmsAddThreshold;
            this.pnlDefaultValue.Controls.Add(this.lbDefaultShow);
            this.pnlDefaultValue.Controls.Add(this.pnlDefaultValueSetting);
            this.pnlDefaultValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDefaultValue.Location = new System.Drawing.Point(3, 26);
            this.pnlDefaultValue.Name = "pnlDefaultValue";
            this.pnlDefaultValue.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDefaultValue.Size = new System.Drawing.Size(100, 50);
            this.pnlDefaultValue.TabIndex = 6;
            // 
            // lbDefaultShow
            // 
            this.lbDefaultShow.AutoEllipsis = true;
            this.lbDefaultShow.BackColor = System.Drawing.Color.White;
            this.lbDefaultShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefaultShow.ContextMenuStrip = this.cmsAddThreshold;
            this.lbDefaultShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDefaultShow.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbDefaultShow.Location = new System.Drawing.Point(5, 5);
            this.lbDefaultShow.Name = "lbDefaultShow";
            this.lbDefaultShow.Size = new System.Drawing.Size(70, 40);
            this.lbDefaultShow.TabIndex = 2;
            this.lbDefaultShow.Text = "#Value";
            this.lbDefaultShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDefaultValueSetting
            // 
            this.pnlDefaultValueSetting.Controls.Add(this.lbBackColor);
            this.pnlDefaultValueSetting.Controls.Add(this.lbFontColor);
            this.pnlDefaultValueSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDefaultValueSetting.Location = new System.Drawing.Point(75, 5);
            this.pnlDefaultValueSetting.Name = "pnlDefaultValueSetting";
            this.pnlDefaultValueSetting.Size = new System.Drawing.Size(20, 40);
            this.pnlDefaultValueSetting.TabIndex = 1;
            // 
            // lbBackColor
            // 
            this.lbBackColor.AutoEllipsis = true;
            this.lbBackColor.BackColor = System.Drawing.Color.White;
            this.lbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.lbFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFontColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFontColor.Location = new System.Drawing.Point(0, 0);
            this.lbFontColor.Name = "lbFontColor";
            this.lbFontColor.Size = new System.Drawing.Size(20, 20);
            this.lbFontColor.TabIndex = 3;
            this.lbFontColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFontColor.Click += new System.EventHandler(this.lbColor_Click);
            // 
            // bgwRefreshSerialPort
            // 
            this.bgwRefreshSerialPort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRefreshSerialPort_DoWork);
            this.bgwRefreshSerialPort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRefreshSerialPort_RunWorkerCompleted);
            // 
            // serialPort
            // 
            this.serialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort_ErrorReceived);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 570);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.lbShowTitle);
            this.Controls.Add(this.spDown);
            this.Controls.Add(this.tabChart);
            this.Controls.Add(this.spLeft);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialPortTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.cmsAddThreshold.ResumeLayout(false);
            this.pnlDefaultValue.ResumeLayout(false);
            this.pnlDefaultValueSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmOperate;
        private System.Windows.Forms.ToolStripMenuItem tsmRefreshSerialPort;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripMenuItem tsmConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmDisConnect;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem tsmExportData;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmPortName;
        private System.Windows.Forms.ToolStripMenuItem tsmBaudRate;
        private System.Windows.Forms.ToolStripMenuItem tsmDataBits;
        private System.Windows.Forms.ToolStripMenuItem tsmStopBits;
        private System.Windows.Forms.ToolStripMenuItem tsmParity;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmReceiveData;
        private System.Windows.Forms.ToolStripMenuItem tsmSystemLogs;
        private System.Windows.Forms.ToolStripSeparator tss4;
        private System.Windows.Forms.ToolStripMenuItem tsmWhatsNew;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslRxCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataCount;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Splitter spLeft;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.Splitter spDown;
        private System.Windows.Forms.Label lbShowTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.FlowLayoutPanel pnlConfig;
        private System.ComponentModel.BackgroundWorker bgwRefreshSerialPort;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ContextMenuStrip cmsAddThreshold;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripSeparator tss5;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDefaultValue;
        private System.Windows.Forms.Label lbDefaultShow;
        private System.Windows.Forms.Panel pnlDefaultValueSetting;
        private System.Windows.Forms.Label lbBackColor;
        private System.Windows.Forms.Label lbFontColor;
    }
}

