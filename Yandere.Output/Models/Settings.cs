using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandere.Output.Models
{
    public class Settings
    {
        public bool IsNSFW { get {
                return bool.Parse(ConfigurationManager.AppSettings["IsNSFW"].ToString());
            } set
            {
                ConfigurationManager.AppSettings.Set("IsNSFW", value.ToString());
            }
        }

        public bool IsOverwrite { get; set; }
    }
}
