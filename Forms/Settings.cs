using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;
using System.Threading;


namespace Wally.Forms
{
    public partial class Settings : Form
    {
        
        public Settings()
        {
            InitializeComponent();
            
        }

        public void Reload(object sender, EventArgs e)
        {
            InitializeComponent();
            Settings_Load(sender,e);
        }
        public void Settings_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            LoggingBox.Text = Form1.core.logs.ToString();
            label2.BackColor = Color.Transparent;
            VersionLabel.Text = Form1.core.Version;
            StartupBox.Checked = IsInStartup();
            LanguageBox.Items.Add("Русский");
            LanguageBox.Items.Add("English");
            LanguageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Localize();
        }
        
        private void Localize()
        {
            if (Form1.core.Language == "ru")
            {
                LanguageBox.SelectedIndex = 0;
                StartupBox.Text = Resources.RU_locale.StartupCheckBoxText;
                LanguageLabel.Text = Resources.RU_locale.SelectLangugeText;
                LogLabel.Text = Resources.RU_locale.LogBoxText;
            }
            else
            {
                LanguageBox.SelectedIndex = 1;
                StartupBox.Text = Resources.EN_locale.StartupCheckBoxText;
                LanguageLabel.Text = Resources.EN_locale.SelectLangugeText;
                LogLabel.Text = Resources.EN_locale.LogBoxText;
            }
        }

        private void SetStartup(bool enable)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk == null) return;
            if (enable)
                rk.SetValue("Wally", Application.ExecutablePath);
            else
                rk.DeleteValue("Wally", false);
        }

        private void StartupBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartupBox.CheckState == CheckState.Checked) SetStartup(true);
            else SetStartup(false);
        }
        
        private bool IsInStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (rk != null)
            {
                if(rk.GetValue("Wally") == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void LanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LanguageBox.SelectedIndex == 0)
            {
                Form1.core.Language = "ru";
            }
            else
            {
                Form1.core.Language = "en";
            }
        }

    }
}
