using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Components;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output
{


    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadConfigurations();
            Application.Run(new MainForm());
        }

        static void LoadConfigurations()
        {
            var config = new FileStream("ApiConfigurations.json",FileMode.Open);
            var bytes = new byte[config.Length];
            config.Read(bytes, 0, (int)config.Length);
            var data = Encoding.Default.GetString(bytes);
            ConfigurationHelper.Configuration = JsonConvert.DeserializeObject<Configurations>(data);
        }
    }
}
