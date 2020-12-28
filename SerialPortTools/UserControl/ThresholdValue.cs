using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortTools
{
    public partial class ThresholdValue : UserControl
    {
        public ThresholdValue(string Name)
        {
            InitializeComponent();
            this.Name = Name;
            if (!Program.threshold.ContainsKey(Name)) Program.threshold.Add(Name, new Threshold(0, Color.Black, Color.White));
        }

        private void lbColor_Click(object sender, EventArgs e)
        {
            try
            {
                Label lb = (Label)sender;
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lb.BackColor = dialog.Color;
                    if (lb.Name == "lbFontColor")
                    {
                        lbShow.ForeColor = dialog.Color;
                        Program.threshold[Name].FontColor = dialog.Color;
                        Program.UpdateAppConfig(Name + "_FontColor", Program.C2S(dialog.Color));
                    }
                    else if (lb.Name == "lbBackColor")
                    {
                        lbShow.BackColor = dialog.Color;
                        Program.threshold[Name].BackColor = dialog.Color;
                        Program.UpdateAppConfig(Name + "_BackColor", Program.C2S(dialog.Color));
                    }
                    Program.ChangeColor();
                }
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Program.threshold[Name].Value = (int)nudValue.Value;
                Program.UpdateAppConfig(Name + "_Value", nudValue.Value.ToString());
                Program.ChangeColor();
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ValueList = Program.GetConfigValue("ThresholdList");
                Program.UpdateAppConfig("ThresholdList", ValueList.Replace(Name + ";", string.Empty));
                Program.DeleteConfigValue(Name + "_FontColor");
                Program.DeleteConfigValue(Name + "_BackColor");
                Program.DeleteConfigValue(Name + "_Value");
                Program.threshold.Remove(Name);
                Program.ChangeColor();
                Dispose();
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        public void DefaultValue(int Value, Color FontColor, Color BackColor)
        {
            try
            {
                nudValue.Value = Value;
                lbFontColor.BackColor = FontColor;
                lbBackColor.BackColor = BackColor;
                lbShow.ForeColor = FontColor;
                lbShow.BackColor = BackColor;
                Program.threshold[Name].Value = Value;
                Program.threshold[Name].FontColor = FontColor;
                Program.threshold[Name].BackColor = BackColor;
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }
    }
}
