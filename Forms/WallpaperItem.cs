using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wally;

namespace Wally.Forms
{
    public partial class WallpaperItem : UserControl
    {
        public string Title;
        public string PathToVideo;
        public string PathToLogo;
        public int index;
        public Wallpaper wallpaper;
        private Gallery _gallery;

        public WallpaperItem(Gallery gallery,Wallpaper wallpaper)
        {
            InitializeComponent();
            _gallery = gallery;
            this.wallpaper = wallpaper;
        }


        private void WallpaperItem_Load(object sender, EventArgs e)
        {
            SetWall.BackColor = Color.FromArgb(125,Color.Black);
            if (PathToLogo == "holder") 
            {
                pictureBox1.Image = Properties.Resources.no_preview;
            }
            else if(PathToLogo != null || PathToLogo != "")
            {
                pictureBox1.Image = Image.FromFile(PathToLogo);
            }
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            SetWall.Text = Title;

        }

        private void SetWall_Click_1(object sender, EventArgs e)
        {
            if (wallpaper.IsWeb)
            {
                Form1.core.SetWebWallpaper(ref PathToVideo);
            }
            else
            {
                Form1.core.SetWallpaper(ref PathToVideo);
            }
            Form1.core.LastWallpaperName = Title;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.core.Walls.Remove(wallpaper);
            _gallery.Reload(sender,e);
        }

  
    }
}
