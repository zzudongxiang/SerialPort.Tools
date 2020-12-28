using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialPortTools
{
    public partial class ChartSetting : UserControl
    {
        public ChartSetting(Series s, Chart c, string Name, string ListName)
        {
            InitializeComponent();
            this.s = s;
            this.Name = Name;
            this.ListName = ListName;
            this.c = c;
        }

        private string ListName = "";

        private Series s;

        private Chart c;

        public delegate void SelectClear(object sender, EventArgs e);

        public event SelectClear OnSelectClear;

        private void ChartSetting_Load(object sender, EventArgs e)
        {
            try
            {
                cbxShow.Tag = true;
                ShowDetail(false);
                Height = cbxShow.Height;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void cbxShow_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Location.X < 20)
                {
                    string temp = Program.GetConfigValue(ListName + "_LineList");
                    Program.UpdateAppConfig(ListName + "_LineList", temp.Replace(Name + ";", string.Empty));
                    Program.DeleteConfigValue(Name + "_LineDisplay");
                    Program.DeleteConfigValue(Name + "_LineName");
                    Program.DeleteConfigValue(Name + "_LineColor");
                    Program.DeleteConfigValue(Name + "_LineWidth");
                    c.Series.Remove(s);
                    Dispose();
                }
                else if (e.Location.X > cbxShow.Width - 20)
                {
                    cbxShow.Checked = !cbxShow.Checked;
                }
                else
                {
                    if (!Convert.ToBoolean(cbxShow.Tag))
                    {
                        Height = cbxShow.Height;
                        cbxShow.Tag = !Convert.ToBoolean(cbxShow.Tag);
                    }
                    else
                    {
                        OnSelectClear(this, new EventArgs());
                    }
                }
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void cbxShow_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                CheckBox cbx = (CheckBox)sender;
                if (e.Location.X < 16) cbx.Cursor = Cursors.Hand;
                else cbx.Cursor = Cursors.Arrow;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Program.UpdateAppConfig(Name + "_LineDisplay", cbxShow.Checked.ToString());
                s.Enabled = cbxShow.Checked;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxName.SelectedIndex > 0 && cbxName.SelectedItem.ToString() != "Null")
                {
                    s.YValueMembers = cbxName.SelectedItem.ToString();
                    s.XValueMember = "UpdateTime";
                }
                else
                {
                    s.YValueMembers = string.Empty;
                    s.XValueMember = string.Empty;
                }
                Program.UpdateAppConfig(Name + "_LineName", cbxName.SelectedItem.ToString());
                cbxShow.Text = "×  " + cbxName.SelectedItem.ToString();
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void lbSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lbSelect.BackColor = dialog.Color;
                    s.Color = dialog.Color;
                    Program.UpdateAppConfig(Name + "_LineColor", Program.C2S(dialog.Color));
                }
                dialog.Dispose();
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void trbSize_Scroll(object sender, EventArgs e)
        {
            try
            {
                lbSize.Text = trbSize.Value.ToString();
                s.BorderWidth = trbSize.Value;
                Program.UpdateAppConfig(Name + "_LineWidth", trbSize.Value.ToString());
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        public void InitCbx()
        {
            int index = 0;
            cbxName.Items.Clear();
            foreach (DataColumn item in Program.dt.Columns)
            {
                if (index++ > 0) cbxName.Items.Add(item.ColumnName);
                else cbxName.Items.Add("Null");
            }
            if (cbxName.SelectedItem == null || cbxName.SelectedItem.ToString() == string.Empty) cbxName.SelectedIndex = 0;
        }

        public void DefaultValue(string strName, Color C, int W, bool B) 
        {
            try
            {
                InitCbx();
                cbxName.SelectedItem = strName;
                if (cbxName.SelectedItem == null || cbxName.SelectedItem.ToString() == string.Empty) strName = "Null";
                cbxShow.Text = "×  " + strName;
                lbSelect.BackColor = C;
                trbSize.Value = W;
                lbSize.Text = W.ToString();
                cbxShow.Checked = B;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        public void ShowDetail(bool Show)
        {
            if (Show)
            {
                Height = cbxShow.Height + pnlName.Height + pnlSize.Height + 3;
                cbxShow.Tag = false;
            }
            else
            {
                Height = cbxShow.Height;
                cbxShow.Tag = true;
            }
        }

    }
}
