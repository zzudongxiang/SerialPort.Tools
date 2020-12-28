using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialPortTools
{
    public partial class ChartPage : UserControl
    {
        public ChartPage(string Name)
        {
            InitializeComponent();
            this.Name = Name;
            Init();
        }

        public bool Reset = false;

        private void Init()
        {
            try
            {
                string[] LineList = Program.GetConfigValue(this.Name + "_LineList").Split(';');
                foreach (string item in LineList)
                {
                    if (item == string.Empty) continue;
                    string lineName = Program.GetConfigValue(item + "_LineName");
                    Color C = Program.S2C(Program.GetConfigValue(item + "_LineColor"));
                    string temp = Program.GetConfigValue(item + "_LineWidth");
                    if (temp == string.Empty) temp = "1";
                    int W = Convert.ToInt16(temp);
                    temp = Program.GetConfigValue(item + "_LineDisplay");
                    if (temp == string.Empty) temp = true.ToString();
                    bool B = Convert.ToBoolean(temp);
                    AddLine(item, lineName, C, W, B, Name);
                }
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void AddLine(string RdoName, string LineName, Color C, int W, bool B, string ListName) 
        {
            try
            {
                Series s = new Series();
                s.Color = C;
                s.BorderWidth = W;
                s.Enabled = B;
                s.ChartType = SeriesChartType.Line;
                ChartShow.Series.Add(s);
                ChartSetting cs = new ChartSetting(s, ChartShow, RdoName, ListName);
                cs.DefaultValue(LineName, C, W, B);
                cs.OnSelectClear += cs_OnSelectClear;
                pnlList.Controls.Add(cs);
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void cs_OnSelectClear(object sender, EventArgs e)
        {
            foreach (Control item in pnlList.Controls)
            {
                ChartSetting c = (ChartSetting)item;
                c.ShowDetail(false);
            }
            ChartSetting cs = (ChartSetting)sender;
            cs.ShowDetail(true);
        }

        public void addNewAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string guid = Guid.NewGuid().ToString();
                string LineList = Program.GetConfigValue(Name + "_LineList");
                Program.UpdateAppConfig(Name + "_LineList", LineList + guid + ";");
                Program.UpdateAppConfig(guid + "_LineName", "Null");
                Program.UpdateAppConfig(guid + "_LineColor", Program.C2S(Color.Red));
                Program.UpdateAppConfig(guid + "_LineWidth", 1.ToString());
                Program.UpdateAppConfig(guid + "_LineDisplay", true.ToString());
                AddLine(guid, "Null", Color.Red, 1, true, Name);
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Reset)
                {
                    foreach (ChartSetting item in pnlList.Controls) item.InitCbx();
                    Reset = false;
                }
                if (Program.dt != null && Program.dt.Rows.Count > 1)
                {
                    if (ChartShow.DataSource == null) ChartShow.DataSource = Program.dt;
                    try { ChartShow.DataBind(); } catch { }
                }
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void saveImageSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Title = "Save Image",
                Filter = "Image|*.png",
                FileName = "DataChart.png",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ChartShow.SaveImage(dialog.FileName, ChartImageFormat.Png);
                MessageBox.Show("Saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dialog.Dispose();
        }
    }
}
