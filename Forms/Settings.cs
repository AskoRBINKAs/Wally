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
            LogCheckBox.Checked = Form1.core.logging;
            LanguageBox.Items.Add("Русский");
            LanguageBox.Items.Add("English");
            FPSBox.Items.Add("15");
            FPSBox.Items.Add("24");
            FPSBox.Items.Add("30");
            FPSBox.Items.Add("60");
            LanguageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FPSBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VolumeTrackBar.Value = Form1.core.Volume;
            VolumePercentLabel.Text = Form1.core.Volume.ToString();
            DefaultSettedArgsLabel.Text += Form1.core.DefaultMPVArgs;
            ArgsFieldBox.Text = Form1.core.AdditionalMPVArgs;
            Localize();
            //setup FPS in box
            switch (Form1.core.Framerate)
            {
                case 15:
                    FPSBox.SelectedIndex = 0;
                    break;
                case 24:
                    FPSBox.SelectedIndex = 1;
                    break;
                case 30:
                    FPSBox.SelectedIndex = 2;
                    break;
                case 60:
                    FPSBox.SelectedIndex = 3;
                    break;
                default:
                    FPSBox.SelectedIndex = 0;
                    break;
            }
        }
        
        private void Localize()
        {
            if (Form1.core.Language == "ru")
            {
                LanguageBox.SelectedIndex = 0;
                StartupBox.Text = Resources.RU_locale.StartupCheckBoxText;
                LanguageLabel.Text = Resources.RU_locale.SelectLangugeText;
                LogLabel.Text = Resources.RU_locale.LogBoxText;
                LogCheckBox.Text = Resources.RU_locale.SettingsLogCheckBox;
                VolumeLabel.Text = Resources.RU_locale.SettingsVolumeText;
                MPVArgsLabel.Text = Resources.RU_locale.SettingsMPVAddArgsText;
            }
            else
            {
                LanguageBox.SelectedIndex = 1;
                StartupBox.Text = Resources.EN_locale.StartupCheckBoxText;
                LanguageLabel.Text = Resources.EN_locale.SelectLangugeText;
                LogLabel.Text = Resources.EN_locale.LogBoxText;
                LogCheckBox.Text = Resources.EN_locale.SettingsLogCheckBox;
                VolumeLabel.Text = Resources.EN_locale.SettingsVolumeText;
                MPVArgsLabel.Text = Resources.EN_locale.SettingsMPVAddArgsText;
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

        private void FPSBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FPSBox.SelectedIndex)
            {
                case 0:
                    Form1.core.Framerate = 15;
                    break;
                case 1:
                    Form1.core.Framerate = 24;
                    break;
                case 2:
                    Form1.core.Framerate = 30;
                    break;
                case 3:
                    Form1.core.Framerate = 60;
                    break;
                default:
                    break;
            }
            //MessageBox.Show(Form1.core.Framerate.ToString()+"\n"+FPSBox.SelectedIndex.ToString());
        }

        private void LogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(LogCheckBox.Checked == true)
            {
                Form1.core.logging = true;
            }
            else
            {
                Form1.core.logging = false;
            }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            Form1.core.Volume = VolumeTrackBar.Value;
            VolumePercentLabel.Text = VolumeTrackBar.Value.ToString();
          //  MessageBox.Show(Form1.core.Volume.ToString());
        }



        private void ArgsFieldBox_TextChanged(object sender, EventArgs e)
        {
            Form1.core.AdditionalMPVArgs = ArgsFieldBox.Text;
        }
    }
}
