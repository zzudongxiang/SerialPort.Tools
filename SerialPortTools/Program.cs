using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SerialPortTools
{
    static class Program
    {

        public static frmMain frm;

        public static frmWaiting frma;

        public static Thread thread = new Thread(RunFrm);

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frma = new frmWaiting();
            thread.Start();
            frm = new frmMain();
            Application.Run(frm);
        }

        public static DataTable dt = new DataTable();

        public static void RunFrm()
        {
            Application.Run(frma);
        }

        #region ConfigFile

        private static string ConfigFilePath = "./" + Application.ProductName + ".exe";

        private static string CheckConfig(string ConfigFilePath)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(ConfigFilePath);
            if (!fi.Directory.Exists) System.IO.Directory.CreateDirectory(fi.DirectoryName);
            return ConfigFilePath;
        }

        public static void UpdateAppConfig(string Key, string Value)
        {
            string filePath = ConfigFilePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(CheckConfig(filePath));
            if (config.AppSettings.Settings[Key] == null) config.AppSettings.Settings.Add(Key, Value);
            else config.AppSettings.Settings[Key].Value = Value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetConfigValue(string Key)
        {
            string filePath = ConfigFilePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(CheckConfig(filePath));
            if (config.AppSettings.Settings[Key] == null) config.AppSettings.Settings.Add(Key, "");
            config.Save(ConfigurationSaveMode.Modified);
            return config.AppSettings.Settings[Key].Value;
        }

        public static void DeleteConfigValue(string Key)
        {
            string filePath = ConfigFilePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(CheckConfig(filePath));
            config.AppSettings.Settings.Remove(Key);
            config.Save(ConfigurationSaveMode.Modified);
        }

        #endregion

        #region Threshold

        public static ShowValue SelectedSV;

        public static Color DefaultFontColor = Color.Black;

        public static Color DefaultBackColor = Color.White;

        public static Dictionary<string, Threshold> threshold = new Dictionary<string, Threshold> { };

        public static string C2S(Color C)
        {
            return C.R + "," + C.G + "," + C.B;
        }

        public static Color S2C(string S)
        {
            try
            {
                string[] temp = S.Split(',');
                if (temp.Length != 3) return Color.Red;
                int R = Convert.ToInt16(temp[0]);
                int G = Convert.ToInt16(temp[1]);
                int B = Convert.ToInt16(temp[2]);
                return Color.FromArgb(R, G, B);
            }
            catch
            {
                return Color.Red;
            }
        }

        public static void ChangeColor()
        {
            frm.UpdateValue();
        }

        #endregion

        public static void ChangeText(ShowValue sender)
        {
            CheckBox cbx = (CheckBox)sender.Tag;
            if (cbx == null) return;
            cbx.Text = sender.Name + "(" + GetConfigValue("#Variable_" + sender.Name) + ")";
        }

    }
}
