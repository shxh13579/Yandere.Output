using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Models;

namespace Yandere.Output.Components
{
    public partial class ImageViewForm : Form
    {
        private YandereImage _imageInfo= null;

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
                ImageContent.ImageLocation = _imageInfo.jpeg_url;
                this.Text = _imageInfo.tags;
            }
        }

        private void ImageViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ImageContent.Image.Dispose();
            this.ImageContent.Dispose();
            this.Dispose();
            GC.Collect();
        }
    }
}
