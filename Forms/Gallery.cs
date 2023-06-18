using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wally.Forms
{
    public partial class Gallery : Form
    {
        public OpenFileDialog OpenFileDialog = new OpenFileDialog();
        public Gallery()
        {
            InitializeComponent();
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            StopButton.BackColor = Color.Red;
            AddButton.BackColor = Color.Green;
            if (Form1.core.Language == "ru")
            {
                StopButton.Text = Resources.RU_locale.StopButtonText;
                AddButton.Text = Resources.RU_locale.AddButtonText;
            }
            else
            {

                StopButton.Text = Resources.EN_locale.StopButtonText;
                AddButton.Text = Resources.EN_locale.AddButtonText;
            }
            LoadWallpapers();
        }

        private void LoadWallpapers()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Wallpaper wallpaper in Form1.core.Walls)
            {
                if (wallpaper.IsCorrupted) continue;
                Forms.WallpaperItem item = new WallpaperItem();
                item.Title = wallpaper.Name;
                item.PathToLogo = wallpaper.PathToLogo;
                item.PathToVideo = wallpaper.PathToVideo;
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = "project.json";
            OpenFileDialog.DefaultExt = ".json";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = OpenFileDialog.FileName;
                Form1.core.AddWallpaper(ref filename);
                LoadWallpapers();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Form1.core.KillPreviousMPV();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
