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
        private ImageApiService _service;

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
            _service = new ImageApiService();
            _imageMarkService = new ImageMarkService();
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tagSearchTimer.Enabled = true;
            _tagSearchTimer.AutoReset = false;
            _tagSearchTimer.Elapsed += (e, v) =>
            {
                SelectTags.Invoke(new Action(() =>
                {
                    var text = SelectTags.Text;
                    //todo
                }));
                //ErrorMsg.Invoke(new Action(() =>
                //{
                //    ErrorMsg.Text += "1";
                //}));
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            await LoadImageData(1);
        }

        private async Task<bool> LoadImageData(int page)
        {
            var pageSize = 100;
            var data = await _service.GetList(page, SelectTags.Text, pageSize);
            if (Container.Data.Count == pageSize && Container.Data.Select(x => x.id).ToArray() == data.Select(x => x.id).ToArray())
            {
                return false;
            }

            if (data == null)
            {
                MessageBox.Show("error!");
                return false;
            }
            if (_isNSFW)
            {
                data = data.Where(x => x.rating == "e").ToList();
            }
            Container.LoadData(data);
            Container.NextPageFunction = async (nextPage) =>
            {
                nextPage += 1;
                data = await _service.GetList(nextPage, "elf", 100);
                Container.LoadData(data);
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
            var data = Container.SelectedImages;
            var success = await _imageMarkService.AddMarks(data.Select(x => x.id));
            if (success)
            {
                _markList.AddRange(data);
            }
            else
            {
                MessageBox.Show("Failed to mark image.");
            }
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
    }
}
