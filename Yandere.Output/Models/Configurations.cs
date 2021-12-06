using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandere.Output.Models
{

    public class Configurations
    {
        public API publicAPI { get; set; }
    }

    public class API
    {
        public string GetList { get; set; }

    }
}
