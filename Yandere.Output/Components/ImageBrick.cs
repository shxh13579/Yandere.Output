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
    public partial class ImageBrick : UserControl
    {
        public ImageBrick()
        {
            InitializeComponent();
            InitFormat();
        }

        private List<ImageViewForm> _formList = null;

        private YandereImage _imageInfo { get; set; }

        

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
        }

        private void ImageBrick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                if(Parent.Parent is ImageContainer)
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
            }else if(Height > Width)
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
    }

}
