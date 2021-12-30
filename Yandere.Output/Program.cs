using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Yandere.Common.Helper;
using Yandere.Common.Models;

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
            try
            {

                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoadConfigurations();
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void LoadConfigurations()
        {
            var config = new FileStream("ApiConfigurations.json", FileMode.Open);
            var bytes = new byte[config.Length];
            config.Read(bytes, 0, (int)config.Length);
            var data = Encoding.Default.GetString(bytes);
            ConfigurationHelper.Configuration = JsonConvert.DeserializeObject<Configurations>(data);
            FileSavingHelper.SavePath = ConfigurationHelper.Configuration.SavePath;
            ConfigurationHelper.Settings = new Settings();
            ConfigurationHelper.Settings.IsNSFW = bool.Parse(ConfigurationManager.AppSettings["IsNSFW"].ToString() ?? "False");
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            MessageBox.Show(e.Exception.Message.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
