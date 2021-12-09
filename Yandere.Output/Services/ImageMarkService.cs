using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Yandere.Output.Services
{
    public class ImageMarkService
    {
        public ImageMarkService()
        {
        }

        public async Task AddMarks(IEnumerable<string> idList)
        {
            if (!idList.Any())
            {
                return;
            }
            //TODO
            var existFile = new StreamReader("UserData.csv", true);
            var existRead = (await existFile.ReadLineAsync()) ?? "";
            existFile.Close();
            existFile.Dispose();
            var existList = existRead?.Split(",").ToList();
            var addList = new List<string>();
            foreach (var id in idList)
            {
                if (!existList.Contains(id))
                {
                    addList.Add(id);
                }
            }
            existList.AddRange(idList);

            var text = new StreamWriter("UserData.csv", true);
            var helper = new CsvWriter(text, CultureInfo.InvariantCulture);
            helper.WriteField(addList);
            await helper.FlushAsync();
            await helper.DisposeAsync();
        }
    }
}
