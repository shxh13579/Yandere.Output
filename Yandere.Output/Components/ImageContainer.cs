using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Helper;
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

        private ImageSaveService _imageSaveService;

        private ImageMarkService _imageMarkService;

        private List<YandereImage> _data { get; set; } = new List<YandereImage>();

        public List<YandereImage> Data { get { return _data; } }

        public void RefreshImageStat()
        {
            foreach (Control control in MainContainer.Controls)
            {
                var image = control as ImageBrick;
                if (image != null)
                {
                    image.RefreshStat();
                }
            }
        }

        public List<YandereImage> SelectedImages
        {
            get
            {
                var result = new List<YandereImage>();
                foreach (Control control in MainContainer.Controls)
                {
                    var image = control as ImageBrick;
                    if (image != null)
                    {
                        if (image.Selected)
                        {
                            result.Add(image.ImageInfo);
                        }
                    }
                }
                return result;
            }
        }

        private void ImageContainer_Load(object sender, EventArgs e)
        {
        }

        public void InitDataContext()
        {
            _imageSaveService = new ImageSaveService();
            _imageMarkService = new ImageMarkService();
        }

        public void AddImageView(YandereImage info)
        {
            if (_view == null || _view.IsDisposed)
            {
                _view = new ImageViewForm(info);
                _view.FormClosed += (e, v) =>
                {
                    RefreshImageStat();
                };
            }
            else
            {
                _view.ChangeImage(info);
            }
            _view.Show();
            _view.BringToFront();
        }

        public Func<int, Task<int>> NextPageFunction = null;

        public void ClearContainer()
        {
            foreach (Control control in MainContainer.Controls)
            {
                control.Dispose();
            }
            MainContainer.Controls.Clear();
        }

        public async Task LoadData(List<YandereImage> data)
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
                var brick = new ImageBrick(info) { Width = 100, Height = 100 };
                brick.MarkEvent += async (id, check) =>
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

        public void DownloadSelected(ImageType type, bool overwrite = false)
        {
            var data = SelectedImages;
            foreach (YandereImage image in data)
            {
                if (!overwrite)
                {
                    if (image.IsJPGDownload && type == ImageType.JPG)
                    {
                        continue;
                    }
                    if (image.IsPNGDownload && type == ImageType.PNG)
                    {
                        continue;
                    }
                }
                FileSavingHelper.AddDownloadTask(image, type, (info) =>
                {
                    var brick = MainContainer.Controls[info.id.ToString()] as ImageBrick;
                    if (brick != null)
                    {
                        brick.RefreshStat();
                    }
                });
            }

        }

        public void DownloadMarked(ImageType type, bool overwrite = false)
        {
            var data = Data.Where(x => x.IsMark == true);
            foreach (YandereImage image in data)
            {
                if (!overwrite)
                {
                    if (image.IsJPGDownload && type == ImageType.JPG)
                    {
                        continue;
                    }
                    if (image.IsPNGDownload && type == ImageType.PNG)
                    {
                        continue;
                    }
                }
                FileSavingHelper.AddDownloadTask(image, type, (info) =>
                {
                    var brick = MainContainer.Controls[info.id.ToString()] as ImageBrick;
                    if (brick != null)
                    {
                        brick.RefreshStat();
                    }
                });
            }

        }

        public void InsertImage(YandereImage info)
        {
            MainContainer.Controls.Add(new ImageBrick(info) { Width = 150, Height = 150 });
        }

        public async Task AddMark()
        {
            var data = SelectedImages.Where(x => x.IsMark == false).Select(x => x.id);
            var success = await _imageMarkService.AddMarks(data);
            if (success)
            {
                Data.ForEach(x =>
                {
                    if (data.Contains(x.id))
                    {
                        x.IsMark = true;
                    }
                });
            }
            else
            {
                MessageBox.Show("Failed to mark image.");
            }
            RefreshImageStat();
        }

    }
}
