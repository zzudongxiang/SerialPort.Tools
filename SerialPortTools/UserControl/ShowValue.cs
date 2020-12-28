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
    public partial class ShowValue : UserControl
    {
        public ShowValue(string Name)
        {
            InitializeComponent();
            this.Name = Name;
            ControlsText = Program.GetConfigValue("#Variable_" + Name);
            if (ControlsText == string.Empty) ControlsText = Name;
            lbTitle.Text = ControlsText;
            lbValue.Text = "00.00";
            lbValue.Tag = true;
            if (Program.GetConfigValue(Name + "_DefaultFontColor") != string.Empty && Program.GetConfigValue(Name + "_DefaultBackColor") != string.Empty) ReadValue();
            else ResetThreshold();
        }

        public string ControlsText = "";

        private double LastValue = 0;

        private Color DefaultFontColor = Color.Black;

        private new Color DefaultBackColor = Color.White;

        private Dictionary<string, Threshold> threshold = new Dictionary<string, Threshold> { };

        public delegate void SelectClear(object sender, EventArgs e);

        public event SelectClear OnSelectClear;

        public delegate void Default(object sender, EventArgs e);

        public event Default OnDefault;

        public void UpdateValue(double Value)
        {
            lbValue.Text = Value.ToString("00.00");
            LastValue = Value;
            ChangedValue();
        }

        public void ResetThreshold()
        {

            foreach (KeyValuePair<string, Threshold> item in threshold)
            {
                Program.DeleteConfigValue(item.Key + "_Value");
                Program.DeleteConfigValue(item.Key + "_FontColor");
                Program.DeleteConfigValue(item.Key + "_BackColor");
            }
            Program.DeleteConfigValue(Name + "_DefaultFontColor");
            Program.DeleteConfigValue(Name + "_DefaultBackColor");
            Program.DeleteConfigValue(Name + "_ThresholdList");
            DefaultFontColor = Program.S2C(Program.GetConfigValue("Default_DefaultFontColor"));
            DefaultBackColor = Program.S2C(Program.GetConfigValue("Default_DefaultBackColor"));
            Program.UpdateAppConfig(Name + "_DefaultFontColor", Program.C2S(DefaultFontColor));
            Program.UpdateAppConfig(Name + "_DefaultBackColor", Program.C2S(DefaultBackColor));
            string[] thresholds = Program.GetConfigValue("Default_ThresholdList").Split(';');
            threshold.Clear();
            foreach (string item in thresholds)
            {
                if (item == string.Empty) continue;
                string ValueS = Program.GetConfigValue(item + "_Value");
                if (ValueS == string.Empty) ValueS = "0";
                int Value = Convert.ToInt16(ValueS);
                Color FontColor = Program.S2C(Program.GetConfigValue(item + "_FontColor"));
                Color BackColor = Program.S2C(Program.GetConfigValue(item + "_BackColor"));
                threshold.Add(item, new Threshold(Value, FontColor, BackColor));
            }
        }

        public void ChangedValue()
        {
            lbValue.ForeColor = DefaultFontColor;
            lbValue.BackColor = DefaultBackColor;
            foreach (KeyValuePair<string, Threshold> item in threshold)
            {
                if (LastValue < item.Value.Value)
                {
                    lbValue.ForeColor = item.Value.FontColor;
                    lbValue.BackColor = item.Value.BackColor;
                }
                else break;
            }
        }

        public void ReadValue()
        {
            DefaultFontColor = Program.S2C(Program.GetConfigValue(Name + "_DefaultFontColor"));
            DefaultBackColor = Program.S2C(Program.GetConfigValue(Name + "_DefaultBackColor"));
            string[] thresholds = Program.GetConfigValue(Name + "_ThresholdList").Split(';');
            threshold.Clear();
            foreach (string item in thresholds)
            {
                if (item == string.Empty) continue;
                string ValueS = Program.GetConfigValue(item + "_Value");
                if (ValueS == string.Empty) ValueS = "0";
                int Value = Convert.ToInt16(ValueS);
                Color FontColor = Program.S2C(Program.GetConfigValue(item + "_FontColor"));
                Color BackColor = Program.S2C(Program.GetConfigValue(item + "_BackColor"));
                threshold.Add(item, new Threshold(Value, FontColor, BackColor));
            }
        }

        private void lbTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.UpdateAppConfig("#Variable_" + Name, lbTitle.Text);
                Program.ChangeText(this);
            }
            catch (Exception Ex)
            {
                Program.frm.WriteDebug(Ex);
            }
        }

        private void lbValue_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(lbValue.Tag))
            {
                BackColor = pnlTitle.BackColor;
                lbValue.Tag = !Convert.ToBoolean(lbValue.Tag);
                OnDefault(this, new EventArgs());
            }
            else OnSelectClear(this, new EventArgs());
        }

        public void SelectedChanged(bool Selected)
        {
            lbValue.Tag = !Selected;
            if (Selected) BackColor = Color.DodgerBlue;
            else BackColor = pnlTitle.BackColor;
        }
    }
}
