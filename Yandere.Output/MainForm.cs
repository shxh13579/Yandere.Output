using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Components;
using Yandere.Output.Services;

namespace Yandere.Output
{
    public partial class MainForm : Form
    {
        private ImageQueryService _service;

        private System.Timers.Timer _tagSearchTimer = new System.Timers.Timer(2000);

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
                ErrorMsg.Invoke(new Action(()=>{
                    ErrorMsg.Text += "1";
                }));
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = await _service.GetList(1, SelectTags.Text,100);
            if (data == null)
            {
                MessageBox.Show("error!");
                return;
            }
            Container.LoadData(data);
            Container.NextPageFunction = async (page)  =>
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
    }
}
