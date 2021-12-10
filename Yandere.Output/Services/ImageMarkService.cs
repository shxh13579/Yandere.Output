using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandere.Output.Models;

namespace Yandere.Output.Services
{
    public class ImageMarkService : IDisposable
    {
        public ImageMarkService()
        {
        }

        public async Task<bool> AddMarks(IEnumerable<int> idList)
        {
            if (!idList.Any())
            {
                return true;
            }

            var existList = new List<int>();
            var exist = File.Exists("UserData.csv");
            if (exist)
            {
                var existFile = new StreamReader("UserData.csv", true);
                var existRead = new CsvReader(existFile, CultureInfo.InvariantCulture);
                try
                {
                    existList = existRead.GetRecords<MarkInfo>().Select(x => x.id).ToList();
                    existRead.Dispose();
                    existFile.Close();
                    existFile.Dispose();
                }
                catch (Exception e)
                {
                    existRead.Dispose();
                    existFile.Close();
                    existFile.Dispose();
                    throw e;
                }
            }
            var alert = MessageBox.Show("Unknown error occurred from your manifest,\r\n could you want to delete old file?", "Error", MessageBoxButtons.YesNo);
            if (alert == DialogResult.No)
            {
                return false;
            }

            var addList = new List<MarkInfo>();
            var text = new StreamWriter("UserData.csv", true);
            var helper = new CsvWriter(text, CultureInfo.InvariantCulture);
            try
            {
                if (!exist)
                {
                    helper.WriteHeader(typeof(MarkInfo));
                    helper.NextRecord();
                }
                foreach (var id in idList)
                {
                    if (!existList.Contains(id))
                    {
                        helper.WriteRecord(new MarkInfo() { id = id, Saved = false });
                        helper.NextRecord();
                    }
                }

                text.Close();
                text.Dispose();
                await helper.FlushAsync();
                await helper.DisposeAsync();
            }
            catch (Exception e)
            {
                text.Close();
                text.Dispose();
                await helper.FlushAsync();
                await helper.DisposeAsync();
                throw e;
            }
            return true;
        }

        public void Dispose()
        {

        }
    }
}
