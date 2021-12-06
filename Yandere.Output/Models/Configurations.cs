using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandere.Output.Models
{

    public class Configurations
    {
        public API publicAPI { get; set; }

        private string _savePath { get; set; }

        public string SavePath
        {
            get { return _savePath; }
            set
            {
                _savePath = value;
                foreach(var name in Enum.GetNames(typeof(ImageType)))
                {
                    if (!Directory.Exists(_savePath+"\\"+name))
                    {
                        Directory.CreateDirectory(_savePath + "\\" + name);
                    }
                }
            }
        }
    }
    public class API
    {
        public string GetList { get; set; }

    }

}
