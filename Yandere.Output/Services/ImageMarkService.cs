using CsvHelper;
using System.Globalization;
using System.IO;

namespace Yandere.Output.Services
{
    public class ImageMarkService
    {
        public ImageMarkService()
        {
            var text = new StreamReader("");
            var helper = new CsvReader(text, CultureInfo.CurrentCulture);
        }
    }
}
