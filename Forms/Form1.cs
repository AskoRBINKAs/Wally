using System.Runtime.InteropServices;
namespace Wally
{
    public partial class Form1 : Form
    {
        private static string _weebpath = Application.ExecutablePath.ToString().Replace("Wally.exe", "wp.exe"); 
        private static string _jsonpath = Application.ExecutablePath.ToString().Replace("Wally.exe", "save.json"); 
        private static string _cfgpath = Application.ExecutablePath.ToString().Replace("Wally.exe", "conf.cfg");
        private static string _playlistpath = Application.ExecutablePath.ToString().Replace("Wally.exe", "playlist.json");
                
        private Form _activeForm;
        private Point mouseDownPoint = Point.Empty;

        public static Core core =  new Core(_weebpath,_jsonpath,_cfgpath);

        // for drag and move
        
	    [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;


        public Form1()
        {
            InitializeComponent();

        }

        // Method for checking required software for correct work
        public void CheckExistingModules()
        {
            string[] requiredModules = { "wp.exe", "wp-headless.exe", "weebp.dll", "weebp.lib", "mpv.exe" };
            foreach (string module in requiredModules)
            {
                if (!File.Exists(Application.ExecutablePath.ToString().Replace("Wally.exe","")+ module))
                {
                    MessageBox.Show("Caused error while starting program. Check existing next files in Wally directory:\nwp.exe\nwp-headless.exe\nweebp.dll\nweebp.lib\nmpv.exe\n"+Application.ExecutablePath);
                    Application.Exit();
                    break;
                }
            }
        }

        //setting labels with text on selected language
        private void Localize()
        {
            if (core.Language == "ru")
            {
                SettingsButton.Text = Resources.RU_locale.SettingsButtonText;
                GalleryButton.Text = Resources.RU_locale.GalleryButtonText;
                CreateButton.Text = Resources.RU_locale.CreatorButtonText;
            }
            else
            {
                SettingsButton.Text = Resources.EN_locale.SettingsButtonText;
                GalleryButton.Text = Resources.EN_locale.GalleryButtonText;
                CreateButton.Text = Resources.EN_locale.CreatorButtonText;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckExistingModules();
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            panel1.BackColor = ColorTranslator.FromHtml("#19369F");
            OpenChildForm(new Forms.Gallery(), sender);
            GalleryButton.BackColor = ColorTranslator.FromHtml("#30343F");
            Localize();           
            
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

        // hide program from alt+tab dialog
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
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
            OpenChildForm(new Forms.Settings(),sender);
            SettingsButton.BackColor = ColorTranslator.FromHtml("#30343F");
            GalleryButton.BackColor = Color.FromArgb(0, Color.Black);
            CreateButton.BackColor = Color.FromArgb(0, Color.Black);
            PlaylistButton.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void GalleryButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gallery(),sender);
            GalleryButton.BackColor = ColorTranslator.FromHtml("#30343F");
            SettingsButton.BackColor = Color.FromArgb(0, Color.Black);
            CreateButton.BackColor = Color.FromArgb(0, Color.Black);
            PlaylistButton.BackColor = Color.FromArgb(0, Color.Black);
        }

        //display other forms inside main form as page
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
            core.SaveWallpapers();
            Application.Exit();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            core.KillPreviousMPV();
        }



        private void CreateButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CreatorForm(), sender);
            GalleryButton.BackColor = Color.FromArgb(0, Color.Black);
            CreateButton.BackColor = ColorTranslator.FromHtml("#30343F");
            SettingsButton.BackColor = Color.FromArgb(0, Color.Black);
            PlaylistButton.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PlaylistForm(), sender);
            GalleryButton.BackColor = Color.FromArgb(0, Color.Black);
            CreateButton.BackColor = Color.FromArgb(0, Color.Black);
            SettingsButton.BackColor = Color.FromArgb(0, Color.Black);
            PlaylistButton.BackColor = ColorTranslator.FromHtml("#30343F");
        }
    }
}