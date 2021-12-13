using CsvHelper;
using Microsoft.EntityFrameworkCore;
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
        private ImageDBContext _db;

        public ImageMarkService()
        {
            _db  = new ImageDBContext();
        }



        public async Task<bool> AddMarks(IEnumerable<int> idList)
        {
            if (!idList.Any())
            {
                return true;
            }

            var existList = await _db .MarkInfo.Select(x => x.id).ToListAsync();
            var addList = idList.Where(x => !existList.Contains(x)).Select(x => new MarkInfo() { id = x });
            await _db .MarkInfo.AddRangeAsync(addList);
            return true;

        }

        public async Task<bool> RemoveMarks(IEnumerable<int> idList)
        {
            if (!idList.Any())
            {
                return true;
            }

            var existList = await _db .MarkInfo.Select(x => x.id).ToListAsync();
            var addList = idList.Where(x => existList.Contains(x)).Select(x => new MarkInfo() { id = x });
            _db .MarkInfo.RemoveRange(addList);
            return true;

        }

        public async void Dispose()
        {
            await _db.DisposeAsync();
        }
    }
}
