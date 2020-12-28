using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SerialPortTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Text += "(V2.3.2)";
            CheckForIllegalCrossThreadCalls = false;
            string _Debug = Program.GetConfigValue("DebugMode");
            if (_Debug == string.Empty) _Debug = false.ToString();
            Debug = Convert.ToBoolean(_Debug);
            if (Program.GetConfigValue("Default_DefaultFontColor") == string.Empty)
                Program.UpdateAppConfig("Default_DefaultFontColor", Program.C2S(Color.Black));
            if (Program.GetConfigValue("Default_DefaultBackColor") == string.Empty)
                Program.UpdateAppConfig("Default_DefaultBackColor", Program.C2S(Color.White));
            Program.GetConfigValue("Default_ThresholdList");
        }

        bool Debug = true;

        private void frmMain_Load(object sender, EventArgs e)
        {
            fileguid = DateTime.Now.ToString("yyMMddHHmmss");
            try
            {
                if (Debug)
                {
                    if (!Directory.Exists("./Debug/")) Directory.CreateDirectory("./temp/");
                    fs_Logs = new FileStream("./Debug/Log_" + fileguid + ".txt", FileMode.Create);
                    sw_Logs = new StreamWriter(fs_Logs, Encoding.UTF8);
                    sw_Logs.AutoFlush = true;
                    fs_Debug = new FileStream("./Debug/Debug_" + fileguid + ".txt", FileMode.Create);
                    sw_Debug = new StreamWriter(fs_Logs, Encoding.UTF8);
                    sw_Debug.AutoFlush = true;
                    fs_Receive = new FileStream("./Debug/Rec_" + fileguid + ".txt", FileMode.Create);
                    sw_Receive = new StreamWriter(fs_Receive, Encoding.UTF8);
                    sw_Receive.AutoFlush = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            tsmRefreshSerialPort_Click(tsmRefreshSerialPort, new EventArgs());
            InitMenu(tsmBaudRate, Program.GetConfigValue("BaudRate"), InitBaudRate());
            InitMenu(tsmDataBits, Program.GetConfigValue("DataBits"), InitDataBits());
            InitMenu(tsmStopBits, Program.GetConfigValue("StopBits"), InitStopBits().ToArray());
            InitMenu(tsmParity, Program.GetConfigValue("Parity"), InitParity().ToArray());
            string DeviceList = Program.GetConfigValue("DeviceList");
            string[] DeviceInfo = DeviceList.Split(';');
            InitDevice(DeviceInfo.ToList());
            InitThresholdColor("Default");
            string[] ChartList = Program.GetConfigValue("ChartList").Split(';');
            foreach (string item in ChartList)
            {
                if (item == string.Empty) continue;
                AddNewTab(item, false);
            }
            Ready = false;
            WriteSysLog("Ready");
            Program.frma.Dispose();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwRefreshSerialPort.IsBusy)
            {
                MessageBox.Show("Please Waiting...", "Waite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                if (Debug)
                {
                    sw_Logs.Close();
                    sw_Receive.Close();
                    fs_Logs.Close();
                    fs_Receive.Close();
                }
                Environment.Exit(0);
            }
        }

        #region 全局变量

        List<ShowValue> ValueList = new List<ShowValue> { };

        string fileguid;

        FileStream fs_Logs;

        StreamWriter sw_Logs;

        FileStream fs_Receive;

        StreamWriter sw_Receive;

        FileStream fs_Debug;

        StreamWriter sw_Debug;

        bool Ready = false;

        Int64 RxCount = 0;

        #endregion

        #region 通用方法

        public void WriteDebug(Exception Ex)
        {
            string Log = Ex.Message.Replace("\r", "").Replace("\n", " ");
            if(Debug) sw_Debug.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "\t\t" + Log);
            MessageBox.Show(Log, "Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitMenu(ToolStripMenuItem tsm, string Defaults, string[] Items)
        {
            int index = 0;
            foreach (string item in Items)
            {
                if (item == Defaults)
                {
                    break;
                }
                index++;
            }
            if (index > Items.Length - 1) index = 0;
            InitMenu(tsm, index, Items);
        }

        private void InitMenu(ToolStripMenuItem tsm, int Defaults, string[] Items)
        {
            tsm.DropDownItems.Clear();
            foreach (string item in Items)
            {
                ToolStripItem temp = tsm.DropDownItems.Add(item);
                switch (tsm.Tag.ToString())
                {
                    case "PortName(&N)":
                        temp.Click += tsiPortName_Click;
                        break;
                    case "BaudRate(&B)":
                        temp.Click += tsiBaudRate_Click;
                        break;
                    case "DataBits(&D)":
                        temp.Click += tsiDataBits_Click;
                        break;
                    case "StopBits(&S)":
                        temp.Click += tsiStopBits_Click;
                        break;
                    case "Parity(&P)":
                        temp.Click += tsiParity_Click;
                        break;
                }
            }
            switch (tsm.Tag.ToString())
            {
                case "PortName(&N)":
                    tsiPortName_Click(tsm.DropDownItems[Defaults], new EventArgs());
                    break;
                case "BaudRate(&B)":
                    tsiBaudRate_Click(tsm.DropDownItems[Defaults], new EventArgs());
                    break;
                case "DataBits(&D)":
                    tsiDataBits_Click(tsm.DropDownItems[Defaults], new EventArgs());
                    break;
                case "StopBits(&S)":
                    tsiStopBits_Click(tsm.DropDownItems[Defaults], new EventArgs());
                    break;
                case "Parity(&P)":
                    tsiParity_Click(tsm.DropDownItems[Defaults], new EventArgs());
                    break;
            }
        }

        private void WriteSysLog(string Log)
        {
            Log = Log.Replace("\r", "").Replace("\n", " ");
            statusStrip.Invoke(new MethodInvoker(delegate { tsslStatus.Text = Log; }));
            if (Debug) sw_Logs.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "\t\t" + Log);
        }

        private void WriteSysLog(Exception Ex)
        {
            WriteSysLog(Ex.Message);
            DialogResult dialog = MessageBox.Show(Ex.Message + "\r\n\r\n是否继续运行？", "运行时错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dialog != DialogResult.OK)
            {
                serialPort.Dispose();
                Environment.Exit(0);
            }
        }

        private string[] InitBaudRate()
        {
            return new string[]
            {
                "1382400",
                "921600",
                "460800",
                "256000",
                "230400",
                "128000",
                "115200",
                "76800",
                "57600",
                "43000",
                "38400",
                "19200",
                "14400",
                "9600",
                "4800",
                "2400",
                "1200",
            };
        }

        private string[] InitDataBits()
        {
            return new string[]
            {
                "8",
                "7",
                "6",
                "5",
            };
        }

        private List<string> InitStopBits()
        {
            List<string> StopBits = new List<string> { };
            foreach (string item in Enum.GetNames(typeof(System.IO.Ports.StopBits))) StopBits.Add(item);
            StopBits.Remove("None");
            StopBits.Remove("OnePointFive");
            return StopBits;
        }

        private List<string> InitParity()
        {
            List<string> Parity = new List<string> { };
            foreach (string item in Enum.GetNames(typeof(System.IO.Ports.Parity))) Parity.Add(item);
            return Parity;
        }

        #endregion

        #region 刷新串口

        private void tsmRefreshSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                tsmPortName.DropDownItems.Clear();
                tsmPortName.DropDownItems.Add("Refreshing...");
                tsiPortName_Click(tsmPortName.DropDownItems[0], new EventArgs());
                if (serialPort.IsOpen) serialPort.Close();
                bgwRefreshSerialPort.RunWorkerAsync();
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void bgwRefreshSerialPort_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> PortNames = new List<string> { };
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            Array.Sort(portList, string.CompareOrdinal);
            foreach (string PortName in portList)
            {
                System.IO.Ports.SerialPort sp = new System.IO.Ports.SerialPort(PortName);
                try
                {
                    sp.Open();
                    sp.Close();
                    PortNames.Add(PortName);
                }
                catch { continue; }
                finally { sp.Dispose(); }
            }
            e.Result = PortNames;
        }

        private void bgwRefreshSerialPort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<string> PortNames = (List<string>)e.Result;
            tsmPortName.DropDownItems.Clear();
            if (PortNames.Count <= 0)
            {
                tsmPortName.DropDownItems.Add("Null");
                tsiPortName_Click(tsmPortName.DropDownItems[0], new EventArgs());
            }
            else
            {
                string PortName = Program.GetConfigValue("PortName");
                InitMenu(tsmPortName, PortName, PortNames.ToArray());
            }
        }

        #endregion

        #region 菜单栏操作

        private void tsiPortName_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem stm = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in tsmPortName.DropDownItems) item.Checked = false;
            stm.Checked = true;
            string PortName = stm.Text;
            Regex reg = new Regex(@"^COM\d+$");
            if (serialPort.IsOpen) serialPort.Close();
            serialPort.PortName = PortName;
            if (reg.IsMatch(PortName))
            {
                try
                {
                    serialPort.Open();
                    tsmPortName.Text = tsmPortName.Tag + ": " + stm.Text;
                    Program.UpdateAppConfig("PortName", PortName);
                    WriteSysLog("SerialPort: " + PortName + " is Open!");
                }
                catch (Exception Ex)
                {
                    WriteSysLog(Ex);
                }
            }
            else
            {
                tsmPortName.Text = stm.Text;
                WriteSysLog("Refreshing...");
            }
        }

        private void tsiBaudRate_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem stm = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in tsmBaudRate.DropDownItems) item.Checked = false;
            stm.Checked = true;
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
                serialPort.BaudRate = Convert.ToInt32(stm.Text);
                Regex reg = new Regex(@"^COM\d+$");
                if (reg.IsMatch(serialPort.PortName)) serialPort.Open();
                tsmBaudRate.Text = tsmDataBits.Tag + ": " + serialPort.BaudRate;
                Program.UpdateAppConfig("BaudRate", stm.Text);
                WriteSysLog("BaudRate: " + serialPort.BaudRate);
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void tsiDataBits_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem stm = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in tsmDataBits.DropDownItems) item.Checked = false;
            stm.Checked = true;
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
                serialPort.DataBits = Convert.ToInt32(stm.Text);
                Regex reg = new Regex(@"^COM\d+$");
                if (reg.IsMatch(serialPort.PortName)) serialPort.Open();
                tsmDataBits.Text = tsmDataBits.Tag + ": " + serialPort.DataBits;
                Program.UpdateAppConfig("DataBits", stm.Text);
                WriteSysLog("DataBits: " + serialPort.DataBits);
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void tsiStopBits_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem stm = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in tsmStopBits.DropDownItems) item.Checked = false;
            stm.Checked = true;
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
                var StopBits = Enum.Parse(typeof(System.IO.Ports.StopBits), stm.Text);
                serialPort.StopBits = (System.IO.Ports.StopBits)StopBits;
                Regex reg = new Regex(@"^COM\d+$");
                if (reg.IsMatch(serialPort.PortName)) serialPort.Open();
                tsmStopBits.Text = tsmStopBits.Tag + ": " + serialPort.StopBits;
                Program.UpdateAppConfig("StopBits", stm.Text);
                WriteSysLog("StopBits: " + serialPort.StopBits);
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void tsiParity_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem stm = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in tsmParity.DropDownItems) item.Checked = false;
            stm.Checked = true;
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
                var Parity = Enum.Parse(typeof(System.IO.Ports.Parity), stm.Text);
                serialPort.Parity = (System.IO.Ports.Parity)Parity;
                Regex reg = new Regex(@"^COM\d+$");
                if (reg.IsMatch(serialPort.PortName)) serialPort.Open();
                tsmParity.Text = tsmParity.Tag + ": " + serialPort.Parity;
                Program.UpdateAppConfig("Parity", stm.Text);
                WriteSysLog("Parity: " + serialPort.StopBits);
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void tsmConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try { serialPort.Open(); }
                catch (Exception Ex)
                {
                    WriteSysLog(Ex);
                    return;
                }
            }
            Ready = true;
            serialPort.Write("ConnectDriver\r\n");
            WriteSysLog("Send Connection Message!");
        }

        private void tsmDisConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try { serialPort.Open(); }
                catch (Exception Ex)
                {
                    WriteSysLog(Ex);
                    return;
                }
            }
            serialPort.Write("DisConnect\r\n");
            Ready = false;
            WriteSysLog("Send DisConnection Message!");
        }

        private void tsmExportData_Click(object sender, EventArgs e)
        {
            frmExport dialog = new frmExport();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WriteSysLog("Save File OK");
            }
            dialog.Dispose();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmReceiveData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请停止运行后查看\r\n\r\n./Debug/Rec_" + fileguid + ".txt\r\n历史缓存记录", "串口接收缓存", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmSystemLogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请停止运行后查看\r\n\r\n./Debug/Log_" + fileguid + ".txt\r\n历史系统日志", "系统日志缓存", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmWhatsNew_Click(object sender, EventArgs e)
        {
            frmNew dialog = new frmNew();
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            frmAbout ab = new frmAbout();
            ab.ShowDialog();
        }

        #endregion

        #region 阈值操作

        private void lbColor_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string thrName = "Default";
                if (Program.SelectedSV == null)
                {
                    DialogResult dia = MessageBox.Show("修改默认值将会影响已设定的变量阈值，是否继续修改？", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dia != DialogResult.OK) return;
                }
                else thrName = Program.SelectedSV.Name;
                lb.BackColor = dialog.Color;
                if (lb.Name == "lbFontColor")
                {
                    lbDefaultShow.ForeColor = dialog.Color;
                    Program.DefaultFontColor = dialog.Color;
                    Program.UpdateAppConfig(thrName + "_DefaultFontColor", Program.C2S(dialog.Color));
                }
                else if (lb.Name == "lbBackColor")
                {
                    lbDefaultShow.BackColor = dialog.Color;
                    Program.DefaultBackColor = dialog.Color;
                    Program.UpdateAppConfig(thrName + "_DefaultBackColor", Program.C2S(dialog.Color));
                }
                UpdateValue();
            }
        }

        private void InitThresholdColor(string thrName)
        {
            Program.DefaultFontColor = Program.S2C(Program.GetConfigValue(thrName + "_DefaultFontColor"));
            Program.DefaultBackColor = Program.S2C(Program.GetConfigValue(thrName + "_DefaultBackColor"));
            lbFontColor.BackColor = Program.DefaultFontColor;
            lbBackColor.BackColor = Program.DefaultBackColor;
            lbDefaultShow.ForeColor = Program.DefaultFontColor;
            lbDefaultShow.BackColor = Program.DefaultBackColor;
            Label templb = label1;
            Control c = pnlDefaultValue;
            pnlConfig.Controls.Clear();
            pnlConfig.Controls.Add(templb);
            pnlConfig.Controls.Add(c);
            string[] tempthresholds = Program.GetConfigValue(thrName + "_ThresholdList").Split(';');
            foreach (string item in tempthresholds)
            {
                if (item == string.Empty) continue;
                string ValueS = Program.GetConfigValue(item + "_Value");
                if (ValueS == string.Empty) ValueS = "0";
                int Value = Convert.ToInt16(ValueS);
                Color FontColor = Program.S2C(Program.GetConfigValue(item + "_FontColor"));
                Color BackColor = Program.S2C(Program.GetConfigValue(item + "_BackColor"));
                ThresholdValue tv = new ThresholdValue(item);
                tv.DefaultValue(Value, FontColor, BackColor);
                pnlConfig.Controls.Add(tv);
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            string thrName = "Default";
            if (Program.SelectedSV != null) thrName = Program.SelectedSV.Name;
            else { MessageBox.Show("Can't Add Default Config", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            ThresholdValue tv = new ThresholdValue(Guid.NewGuid().ToString());
            tv.DefaultValue(0, Color.Black, Color.White);
            Program.UpdateAppConfig(tv.Name + "_Value", "0");
            Program.UpdateAppConfig(tv.Name + "_FontColor", Program.C2S(Color.Black));
            Program.UpdateAppConfig(tv.Name + "_BackColor", Program.C2S(Color.White));
            pnlConfig.Controls.Add(tv);
            string ValueList = Program.GetConfigValue(thrName + "_ThresholdList");
            Program.UpdateAppConfig(thrName + "_ThresholdList", ValueList + tv.Name + ";");
            if (Program.SelectedSV != null) Program.SelectedSV.ReadValue();
        }

        public void UpdateValue()
        {
            if (Program.SelectedSV == null)
            {
                foreach (ShowValue sv in ValueList)
                {
                    sv.ResetThreshold();
                    sv.ChangedValue();
                }
            }
            else
            {
                Program.SelectedSV.ReadValue();
                Program.SelectedSV.ChangedValue();
            }
        }

        private void Sv_OnDefault(object sender, EventArgs e)
        {
            label1.Text = "Default";
            Program.SelectedSV = null;
            InitThresholdColor("Default");
        }

        private void Sv_OnSelectClear(object sender, EventArgs e)
        {
            foreach (ShowValue sv in flpMain.Controls) sv.SelectedChanged(false);
            ShowValue s = (ShowValue)sender;
            s.SelectedChanged(true);
            label1.Text = s.Name;
            Program.SelectedSV = s;
            InitThresholdColor(s.Name);
        }

        #endregion

        #region 串口数据处理

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string ReceiveBuff = serialPort.ReadLine().Replace("\r", "").Replace("\n", "");
            if(Debug) sw_Receive.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "\t\t" + ReceiveBuff);
            RxCount += ReceiveBuff.Length;
            statusStrip.Invoke(new MethodInvoker(delegate { tsslRxCount.Text = "RxCount: " + RxCount; }));
            if (!Ready) return;
            List<string> ReceiveCommand = ReceiveBuff.Split(';').ToList();
            if (ReceiveCommand[0].ToUpper() == "#SET".ToUpper()) SETData(ReceiveCommand);
            else if (ReceiveCommand[0].ToUpper() == "#DTU".ToUpper()) DTUData(ReceiveCommand);
            else WriteSysLog("Unresolved Data: " + ReceiveBuff);
        }

        private void serialPort_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            switch (e.EventType)
            {
                case System.IO.Ports.SerialError.Frame:
                    WriteSysLog("串口接收错误：(Frame)硬件检测到一个组帧错误。");
                    break;
                case System.IO.Ports.SerialError.Overrun:
                    WriteSysLog("串口接收错误：(Overrun)发生字符缓冲区溢出。下一个字符将丢失。");
                    break;
                case System.IO.Ports.SerialError.RXOver:
                    WriteSysLog("串口接收错误：(RXOver)发生输入缓冲区溢出。输入缓冲区空间不足，或在文件尾 (EOF) 字符之后接收到字符。 ");
                    break;
                case System.IO.Ports.SerialError.RXParity:
                    WriteSysLog("串口接收错误：(RXParity)硬件检测到奇偶校验错误。");
                    break;
                case System.IO.Ports.SerialError.TXFull:
                    WriteSysLog("串口接收错误：(TXFull)应用程序尝试传输一个字符，但是输出缓冲区已满。");
                    break;
            }
        }

        private void SETData(List<string> ReceiveData)
        {
            ReceiveData.RemoveAt(0);
            List<string> DeviceInfo = new List<string> { };
            try
            {
                string Device = "";
                foreach (string item in ReceiveData)
                {
                    if (item == string.Empty) continue;
                    Device += item + ";";
                    int LastLength = DeviceInfo.Count();
                    DeviceInfo.Add(item);
                    if (DeviceInfo.Count() <= LastLength) throw new Exception("Data parsing exception with duplicate name!");
                }
                Program.UpdateAppConfig("DeviceList", Device);
                InitDevice(DeviceInfo);
                WriteSysLog("Connection Succeful!");
                Program.frma.Dispose();
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void DTUData(List<string> ReceiveData)
        {
            ReceiveData.RemoveAt(0);
            try
            {
                if (ValueList.Count != ReceiveData.Count) { WriteSysLog(new Exception("长度不匹配，忽略接收数据。" + ValueList.Count + "!=" + ReceiveData.Count)); return; }
                bool Error = false;
                DataRow dr = Program.dt.NewRow();
                dr[0] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                for (int i = 0; i < ReceiveData.Count(); i++)
                {
                    if (Error) throw new Exception("数据无法解析：" + ReceiveData[i - 1]);
                    Regex reg = new Regex(@"^(\-)?\d+(\.\d*)?$");
                    if (ReceiveData[i] == string.Empty || !reg.IsMatch(ReceiveData[i]))
                    {
                        Error = true;
                        continue;
                    }
                    double value = Convert.ToDouble(ReceiveData[i]);
                    Invoke((EventHandler)(delegate
                    {
                        ValueList[i].UpdateValue(value);
                    }));
                    dr[i + 1] = value;
                }
                Program.dt.Rows.Add(dr);
                statusStrip.Invoke(new MethodInvoker(delegate { tsslDataCount.Text = "DataCount: " + Program.dt.Rows.Count; }));
            }
            catch (Exception Ex)
            {
                WriteSysLog(Ex);
            }
        }

        private void InitDevice(List<string> DeviceInfo)
        {
            Program.dt.Dispose();
            Program.dt = new DataTable();
            Program.dt.Columns.Add("UpdateTime");
            Ready = true;
            Invoke((EventHandler)(delegate
            {
                flpMain.Controls.Clear();
                ValueList.Clear();
                panel1.Controls.Clear();
                foreach (string item in DeviceInfo)
                {
                    if (item == string.Empty) continue;
                    if (Program.GetConfigValue(item + "_DefaultFontColor") == string.Empty)
                        Program.UpdateAppConfig(item + "_DefaultFontColor", Program.C2S(Color.Black));
                    if (Program.GetConfigValue(item + "_DefaultBackColor") == string.Empty)
                        Program.UpdateAppConfig(item + "_DefaultBackColor", Program.C2S(Color.White));
                    Program.GetConfigValue(item + "_ThresholdList");
                    ShowValue sv = new ShowValue(item);
                    sv.OnSelectClear += Sv_OnSelectClear;
                    sv.OnDefault += Sv_OnDefault;
                    flpMain.Controls.Add(sv);
                    ValueList.Add(sv);
                    Program.dt.Columns.Add(item);
                    CheckBox cbx = new CheckBox();
                    cbx.Name = item;
                    cbx.Text = item + "(" + Program.GetConfigValue("#Variable_" + item) + ")";
                    cbx.Tag = sv;
                    sv.Tag = cbx;
                    cbx.CheckedChanged += cbx_CheckedChanged;
                    cbx.Dock = DockStyle.Top;
                    cbx.AutoSize = false;
                    cbx.Width = 250;
                    string status = Program.GetConfigValue(cbx.Name + "_Display");
                    if (status == string.Empty) status = true.ToString();
                    cbx.Checked = Convert.ToBoolean(status);
                    cbx_CheckedChanged(cbx, new EventArgs());
                    panel1.Controls.Add(cbx);
                }
                foreach (TabPage item in tabChart.TabPages) ((ChartPage)item.Tag).Reset = true;
            }));
        }

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbx = (CheckBox)sender;
            ShowValue sv = (ShowValue)cbx.Tag;
            sv.Visible = cbx.Checked;
            Program.UpdateAppConfig(cbx.Name + "_Display", cbx.Checked.ToString());
        }

        #endregion

        #region 绘制图形

        private void tsmAddChart_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            AddNewTab(guid);
        }

        private void AddNewTab(string guid, bool Add = true)
        {
            ChartPage cp = new ChartPage(guid);
            cp.Name = guid;
            cp.Dock = DockStyle.Fill;
            TabPage tp = new TabPage("× DataChart");
            tp.Tag = cp;
            tp.Name = guid;
            tp.Controls.Add(cp);
            if (Add)
            {
                string ChartList = Program.GetConfigValue("ChartList");
                ChartList += guid + ";";
                Program.UpdateAppConfig("ChartList", ChartList);
            }
            tabChart.TabPages.Add(tp);
        }

        private void tabChart_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabChart.TabPages.Count; i++)
            {
                if (e.Location.X > i * 85 && e.Location.X < i * 85 + 20)
                {
                    DialogResult dialog = MessageBox.Show("You sure you want to delete it?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog != DialogResult.Yes) return;
                    string ChartList = Program.GetConfigValue("ChartList");
                    Program.UpdateAppConfig("ChartList", ChartList.Replace(tabChart.TabPages[i].Name + ";", string.Empty));
                    string[] LineList = Program.GetConfigValue(tabChart.TabPages[i].Name + "_LineList").Split(';');
                    Program.DeleteConfigValue(tabChart.TabPages[i].Name + "_LineList");
                    foreach (string item in LineList)
                    {
                        Program.DeleteConfigValue(item + "_LineName");
                        Program.DeleteConfigValue(item + "_LineColor");
                        Program.DeleteConfigValue(item + "_LineWidth");
                        Program.DeleteConfigValue(item + "_LineDisplay");
                    }
                    tabChart.TabPages[i].Dispose();
                }
            }
        }

        private void tabChart_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabChart.TabPages.Count; i++)
            {
                if (e.Location.X > i * 85 && e.Location.X < i * 85 + 20)
                {
                    tabChart.Cursor = Cursors.Hand;
                    break;
                }
                else tabChart.Cursor = Cursors.Arrow;
            }
        }

        #endregion

    }
}
