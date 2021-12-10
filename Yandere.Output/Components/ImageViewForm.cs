using System;
using System.Windows.Forms;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output.Components
{
    public partial class ImageViewForm : Form
    {
        private YandereImage _imageInfo = null;

        public ImageViewForm()
        {
            InitializeComponent();
        }

        public ImageViewForm(YandereImage info)
        {
            _imageInfo = info;
            InitializeComponent();
        }

        public void ChangeImage(YandereImage info)
        {
            _imageInfo = info;
            ImageViewForm_Load(null, null);
        }

        private void ImageViewForm_Load(object sender, EventArgs e)
        {
            if (_imageInfo != null)
            {
                ImageContent.ImageLocation = _imageInfo.sample_url;
                this.Text = _imageInfo.tags;
                SizeInfo.Text = "(" + _imageInfo.width + "x" + _imageInfo.height + ")";
            }
        }

        private void ImageViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ImageContent.Image.Dispose();
            this.ImageContent.Dispose();
            this.Dispose();
            GC.Collect();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveJpgBtn_Click(object sender, EventArgs e)
        {
            FileSavingHelper.AddDownloadJPGTask(_imageInfo);
        }

        private void savePngBtn_Click(object sender, EventArgs e)
        {
            FileSavingHelper.AddDownloadPNGTask(_imageInfo);

        }
    }
}
