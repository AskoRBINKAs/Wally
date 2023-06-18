using System.Globalization;
using System.Threading;

namespace Wally
{
    public partial class Form1 : Form
    {
        public static Core core =  new Core();
       
        private Form _activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckExistingModules()
        {
            string[] requiredModules = { "wp.exe", "wp-headless.exe", "weebp.dll", "weebp.lib", "mpv.exe" };
            foreach (string module in requiredModules)
            {
                if (!File.Exists(module))
                {
                    MessageBox.Show("Caused error while starting program. Check existing next files in Wally directory:\nwp.exe\nwp-headless.exe\nweebp.dll\nweebp.lib\nmpv.exe\n");
                    Application.Exit();
                    break;
                }
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckExistingModules();
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            panel1.BackColor = ColorTranslator.FromHtml("#19369F");
            OpenChildForm(new Forms.Gallery(), sender);
            GalleryButton.BackColor = ColorTranslator.FromHtml("#30343F");
            //init labels
            if(core.Language == "ru")
            {
                SettingsButton.Text = Resources.RU_locale.SettingsButtonText;
                GalleryButton.Text = Resources.RU_locale.GalleryButtonText;
            }
            else
            {
                SettingsButton.Text = Resources.EN_locale.SettingsButtonText;
                GalleryButton.Text = Resources.EN_locale.GalleryButtonText;
            }
            //load last played wallpaper
            foreach(var wall in core.Walls)
            {
                if(wall.Name == core.LastWallpaperName)
                {
                    string link = wall.PathToVideo;
                    core.SetWallpaper(ref link);
                    core.LastWallpaperName = wall.Name;
                    break;
                }
            }
            notifyIcon1.Visible = true;
        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //settings button
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender);
            SettingsButton.BackColor = ColorTranslator.FromHtml("#30343F");
            GalleryButton.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void GalleryButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gallery(),sender);
            GalleryButton.BackColor = ColorTranslator.FromHtml("#30343F");
            SettingsButton.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void OpenChildForm(Form ChildForm,object sender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.ChildPanelDock.Controls.Add(ChildForm);
            this.ChildPanelDock.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X,Cursor.Position.Y);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            this.ShowInTaskbar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            core.SaveConfig();
            core.KillPreviousMPV();
            Application.Exit();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            core.KillPreviousMPV();
        }

        private void ChildPanelDock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}