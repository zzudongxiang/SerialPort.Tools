using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SerialPortTools
{
    public partial class frmExport : Form
    {
        public frmExport()
        {
            try
            {
                InitializeComponent();
                FileInfo fi = new FileInfo("./SaveData.csv");
                tbxFilePath.Text = fi.FullName;
                int index = 0;
                foreach (DataColumn dc in Program.dt.Columns)
                {
                    if (index++ > 0)
                    {
                        CheckBox cbx = new CheckBox();
                        cbx.Name = dc.ColumnName;
                        cbx.Text = dc.ColumnName + "(" + Program.GetConfigValue("#Variable_" + dc.ColumnName) + ")";
                        string status = Program.GetConfigValue(cbx.Name + "_Export");
                        if (status == string.Empty) status = true.ToString();
                        cbx.Checked = Convert.ToBoolean(status);
                        cbx.CheckedChanged += cbx_CheckedChanged;
                        cbx.AutoSize = false;
                        cbx.Width = 200;
                        flpColNames.Controls.Add(cbx);
                        dic.Add(dc.ColumnName, cbx);
                    }
                }
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private Dictionary<string, CheckBox> dic = new Dictionary<string, CheckBox> { };

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbx = (CheckBox)sender;
                Program.UpdateAppConfig(cbx.Name + "_Export", cbx.Checked.ToString());
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(tbxFilePath.Text, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                try
                {
                    string temp = "";
                    int index = 0;
                    foreach (DataColumn dc in Program.dt.Columns)
                    {
                        if (!dic.ContainsKey(dc.ColumnName) || dic[dc.ColumnName].Checked)
                        {
                            if (index++ > 0) temp += ",";
                            temp += dc.ColumnName;
                        }
                    }
                    sw.WriteLine(temp);
                    foreach (DataRow dr in Program.dt.Rows)
                    {
                        temp = "";
                        index = 0;
                        for (int i = 0; i < Program.dt.Columns.Count; i++)
                        {
                            if (!dic.ContainsKey(Program.dt.Columns[i].ColumnName) || dic[Program.dt.Columns[i].ColumnName].Checked)
                            {
                                if (index++ > 0) temp += ",";
                                temp += dr[i].ToString();
                            }
                        }
                        sw.WriteLine(temp);
                    }
                    MessageBox.Show("Export Done!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void tbxFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Title = "Save Receive Data",
                    Filter = "CsvFile|*.csv",
                    FileName = tbxFilePath.Text,
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbxFilePath.Text = dialog.FileName;
                }
                dialog.Dispose();
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }
    }
}
