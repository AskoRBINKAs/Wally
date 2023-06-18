﻿using System;
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
        public Wallpaper wallpaper; 
        public WallpaperItem()
        {
            InitializeComponent();
        }


        private void WallpaperItem_Load(object sender, EventArgs e)
        {
            SetWall.BackColor = Color.FromArgb(125,Color.Black);
            if(PathToLogo!=null || PathToLogo!="") pictureBox1.Image = Image.FromFile(PathToLogo);

            SetWall.Text = Title;

        }

        private void SetWall_Click_1(object sender, EventArgs e)
        {
            Form1.core.SetWallpaper(ref PathToVideo);
            Form1.core.LastWallpaperName = Title;
        }
    }
}