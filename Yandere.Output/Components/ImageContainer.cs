using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Models;
using Yandere.Output.Services;

namespace Yandere.Output.Components
{
    public partial class ImageContainer : UserControl
    {
        public ImageContainer()
        {
            InitializeComponent();
        }

        private ImageViewForm _view = null;

        private int page = 1;

        private List<YandereImage> _data { get; set; }

        public List<YandereImage> Data { get { return _data; } }

        public List<YandereImage> SelectedImages
        {
            get
            {
                var result = new List<YandereImage>();
                foreach (ImageBrick image in MainContainer.Controls)
                {
                    if (image.Selected)
                    {
                        result.Add(image.ImageInfo);
                    }
                }
                return result;
            }
        }

        private void ImageContainer_Load(object sender, EventArgs e)
        {
        }

        public void AddImageView(YandereImage info)
        {
            if (_view == null || _view.IsDisposed)
            {
                _view = new ImageViewForm(info);
            }
            else
            {
                _view.ChangeImage(info);
            }
            _view.Show();
            _view.BringToFront();
        }

        public Func<int, Task<int>> NextPageFunction = null;

        public void LoadData(List<YandereImage> data)
        {
            if (MainContainer.Controls.Count > 0)
            {
                var btn = MainContainer.Controls[MainContainer.Controls.Count - 1];
                btn.Dispose();
                MainContainer.Controls.RemoveAt(MainContainer.Controls.Count - 1);
            }
            foreach (var info in data)
            {
                if (_data.Exists(x => x.id == info.id))
                {
                    continue;
                }
                _data.Add(info);
                var brick = new ImageBrick(info) { Width = 150, Height = 150 };
                brick.AddMarkEvent += async (id) =>
               {
                   using (ImageMarkService service = new ImageMarkService())
                   {
                       var suucess = await service.AddMarks(new[] { id });
                       return suucess;
                   }

               };
                MainContainer.Controls.Add(brick);
            }

            var moreBtn = new Button() { FlatStyle = FlatStyle.Flat, Text = "More", Width = MainContainer.Width - 30, Height = 30, Font = new Font("Microsoft YaHei UI", 12, FontStyle.Regular) };
            moreBtn.Click += async (e, v) =>
            {
                if (NextPageFunction != null)
                    page = await NextPageFunction(page);
            };
            MainContainer.Controls.Add(moreBtn);
        }

        public void SelectAllImages(bool isSelected)
        {
            foreach (ImageBrick image in MainContainer.Controls)
            {
                image.Selected = isSelected;
            }
        }


        public void InsertImage(YandereImage info)
        {
            MainContainer.Controls.Add(new ImageBrick(info) { Width = 150, Height = 150 });
        }


    }
}
