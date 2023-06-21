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
    public partial class PlaylistForm : Form
    {
        public PlaylistForm()
        {
            InitializeComponent();
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            TitlePlaylistForm.BackColor = ColorTranslator.FromHtml("#30343F");
            
        }
    }
}
