using System;
using System.Collections.Generic;
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

        public MainForm()
        {
            _service = new ImageQueryService();
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tagSearchTimer.Enabled = true;
            _tagSearchTimer.AutoReset = false;
            _tagSearchTimer.Elapsed += (e, v) =>
            {
                ErrorMsg.Invoke(new Action(() =>
                {
                    ErrorMsg.Text += "1";
                }));
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = await _service.GetList(1, SelectTags.Text, 100);
            if (data == null)
            {
                MessageBox.Show("error!");
                return;
            }
            Container.LoadData(data);
            Container.NextPageFunction = async (page) =>
            {
                page += 1;
                data = await _service.GetList(page, "elf", 100);
                Container.LoadData(data);
                return page;
            };
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SelectTags_TextChanged(object sender, EventArgs e)
        {
            _tagSearchTimer.Stop();
            _tagSearchTimer.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            var data = MainContainer.SelectedImages;
            _markList.AddRange(data);
        }
    }
}
