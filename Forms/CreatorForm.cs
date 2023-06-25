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
    public partial class CreatorForm : Form
    {
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        private string _title="";
        private string _videoPath="";
        private string _previewPath = "";
        public CreatorForm()
        {
            InitializeComponent();
        }

        private void Localize()
        {
            if (Form1.core.Language == "ru")
            {
                NameLabel.Text = Resources.RU_locale.CreatorNameLabel;
                VideoLabel.Text = Resources.RU_locale.CreatorVideoLabel;
                PreviewLabel.Text = Resources.RU_locale.CreatorPreviewLabel;
                TitleCreatorForm.Text = Resources.RU_locale.CreatorTitleLabel;
                AddVideoButton.Text = Resources.RU_locale.CreatorAddFileButtonText;
                AddPreviewPath.Text = Resources.RU_locale.CreatorAddFileButtonText;
                CreateButton.Text = Resources.RU_locale.CreatorCreateButtonText;
            }
            else
            {
                NameLabel.Text = Resources.EN_locale.CreatorNameLabel;
                VideoLabel.Text = Resources.EN_locale.CreatorVideoLabel;
                PreviewLabel.Text = Resources.EN_locale.CreatorPreviewLabel;
                TitleCreatorForm.Text = Resources.EN_locale.CreatorTitleLabel;
                AddVideoButton.Text = Resources.EN_locale.CreatorAddFileButtonText;
                AddPreviewPath.Text = Resources.EN_locale.CreatorAddFileButtonText;
                CreateButton.Text = Resources.EN_locale.CreatorCreateButtonText;
            }
        }

        private void CreatorForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#30343F");
            panel1.BackColor = ColorTranslator.FromHtml("#30343F");
            NameLabel.BackColor = ColorTranslator.FromHtml("#30343F");
            VideoLabel.BackColor = ColorTranslator.FromHtml("#30343F");
            PreviewLabel.BackColor = ColorTranslator.FromHtml("#30343F");
            TitleCreatorForm.BackColor = ColorTranslator.FromHtml("#30343F");
            IsWebBox.BackColor = ColorTranslator.FromHtml("#30343F");
            Localize();
        }

        private void AddVideoButton_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _videoPath = _openFileDialog.FileName;
                VideoPathBox.Text = _videoPath;
            }
            
        }

        private void AddPreviewPath_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _previewPath = _openFileDialog.FileName;
                PreviewPathBox.Text = _previewPath;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(_title=="" && _videoPath == "")
            {
                return;
            }
            if (_previewPath=="")
            {
                _previewPath = "holder";
            }
            _title = NameBox.Text;
            Form1.core.AddWallpaper(new Wallpaper(_title,_videoPath,_previewPath,IsWebBox.Checked));
        }
    }
}
