using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output.Components
{
    public partial class ImageBrick : UserControl
    {
        public ImageBrick()
        {
            InitializeComponent();
            InitFormat();
        }

        private List<ImageViewForm> _formList = null;

        private YandereImage _imageInfo { get; set; }

        public YandereImage ImageInfo { get { return _imageInfo; } }

        public Func<int, Task<bool>> AddMarkEvent = null;

        public ImageBrick(string url)
        {
            _imageInfo.preview_url = url;
            InitializeComponent();
            InitFormat();
        }
        public ImageBrick(YandereImage info)
        {
            _imageInfo = info;
            InitializeComponent();
            InitFormat();
        }

        public void InsertImage(string url)
        {
            ImageContent.ImageLocation = url;
        }

        private void InitFormat()
        {
            MouseClick += ImageBrick_MouseClick;
            ImageContent.MouseDoubleClick += ImageBrick_MouseDoubleClick;
            if (string.IsNullOrEmpty(_imageInfo.source))
            {
                FavBtn.Left += 53;
                DownloadBtn.Left += 53;
            }
        }

        private void ImageBrick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Parent.Parent is ImageContainer)
                {
                    (Parent.Parent as ImageContainer).AddImageView(_imageInfo);
                }
            }
        }

        private bool _selected { get; set; }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                if (!_selected)
                    BackColor = Color.Transparent;
                else
                    BackColor = Color.Gray;

            }
        }

        private void ImageBrick_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Selected = !Selected;
            }
        }

        private void ImageBrick_SizeChanged(object sender, EventArgs e)
        {
            if (Width > Height)
            {
                Height = Width;
            }
            else if (Height > Width)
            {
                Width = Height;
            }
        }

        private void ImageBrick_Load(object sender, EventArgs e)
        {
            InsertImage(_imageInfo.preview_url);
        }

        private void ImageContent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Selected = !Selected;
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            FileSavingHelper.AddDownloadJPGTask(_imageInfo);
        }

        private void PNGDownloadBtn_Click(object sender, EventArgs e)
        {
            FileSavingHelper.AddDownloadPNGTask(_imageInfo);
        }

        private async void FavBtn_Click(object sender, EventArgs e)
        {
            if (AddMarkEvent != null)
            {
                var success = await AddMarkEvent(_imageInfo.id);
                if (success)
                {
                    FavBtn.Invoke(new Action(() =>
                    {
                        FavBtn.Image = Resouces.Favorited;
                    }));
                }
            }
        }
    }

}
