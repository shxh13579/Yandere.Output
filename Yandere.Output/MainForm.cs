using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Models;
using Yandere.Output.Services;

namespace Yandere.Output
{
    public partial class MainForm : Form
    {
        private ImageQueryService _service;

        private System.Timers.Timer _tagSearchTimer = new System.Timers.Timer(2000);

        private List<YandereImage> _markList = new List<YandereImage>();

        private int _currentPage = 1;

        private bool _isNSFW = true;

        private ImageMarkService _imageMarkService;


        private int currentPage
        {
            get { return _currentPage; }
            set
            {
                PageNumber.Invoke(new Action(() =>
                {
                    PageNumber.Text = value.ToString();
                }));
                _currentPage = value;
            }
        }

        public MainForm()
        {
            _service = new ImageQueryService();
            _imageMarkService = new ImageMarkService();
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tagSearchTimer.Enabled = true;
            _tagSearchTimer.AutoReset = false;
            _tagSearchTimer.Elapsed += (e, v) =>
            {
                //ErrorMsg.Invoke(new Action(() =>
                //{
                //    ErrorMsg.Text += "1";
                //}));
            };
            Container.InitDataContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            await LoadImageData(1);
        }

        private async Task<bool> LoadImageData(int page)
        {
            Container.ClearContainer();
            var pageSize = 20;
            var data = await _service.GetList(page, SelectTags.Text, pageSize);
            if (Container.Data!=null && Container.Data.Count == pageSize && Container.Data.Select(x => x.id).ToArray() == data.Select(x => x.id).ToArray())
            {
                return false;
            }

            if (data == null)
            {
                MessageBox.Show("error!");
                return false;
            }
            if (!_isNSFW)
            {
                data = data.Where(x => x.rating == "s").ToList();
            }
            await Container.LoadData(data);
            Container.NextPageFunction = async (nextPage) =>
            {
                nextPage += 1;
                data = await _service.GetList(nextPage, "elf", pageSize);
                await Container.LoadData(data);
                return nextPage;
            };
            return true;
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectTags.Text = "";
        }

        private void SelectTags_TextChanged(object sender, EventArgs e)
        {
            _tagSearchTimer.Stop();
            _tagSearchTimer.Start();
        }

        private async void MarkBtn_Click(object sender, EventArgs e)
        {
            await Container.AddMark();
        }

        private void PageNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private async void SkipPageBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PageNumber.Text, out int page))
            {
                await LoadImageData(page);
            }
        }

        private async void NextPageBtn_Click(object sender, EventArgs e)
        {
            var success = await LoadImageData(currentPage + 1);
            if (success)
            {
                currentPage += 1;
            }
        }

        private async void PrePageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage -= 1;
                await LoadImageData(currentPage);
            }
        }

        private void IsNSFWCheck_CheckedChanged(object sender, EventArgs e)
        {
            _isNSFW = IsNSFWCheck.Checked;
        }

        private void MarkListBtn_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            Container.SelectAllImages(true);
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (IsPNGCheck.Checked)
            {
                Container.DownloadSelected(ImageType.PNG);
            }
            else
            {
                Container.DownloadSelected(ImageType.JPG);
            }
        }

        private void MarkDownloadBtn_Click(object sender, EventArgs e)
        {
            if (IsPNGCheck.Checked)
            {
                Container.DownloadMarked(ImageType.PNG);
            }
            else
            {
                Container.DownloadMarked(ImageType.JPG);
            }
        }

        private void DownloadShownBtn_Click(object sender, EventArgs e)
        {

            Container.RefreshImageStat();
        }

        private void DownloadAllResultBtn_Click(object sender, EventArgs e)
        {

            Container.RefreshImageStat();
        }
    }
}
