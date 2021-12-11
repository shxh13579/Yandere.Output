using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandere.Output.Models;

namespace Yandere.Output.Services
{
    public class ImageSaveService : IDisposable
    {
        private ImageDBContext _db;

        public ImageSaveService()
        {
            _db = new ImageDBContext();
        }

        public async Task<List<YandereImage>> GetList(List<YandereImage> data)
        {
            if (!data.Any())
            {
                return data;
            }
            var download = new DownloadInfo();
            var imageData = await _db.DownloadInfo.ToDictionaryAsync(x => x.id, y => y);
            data.ForEach(x =>
            {
                if (imageData.TryGetValue(x.id, out download))
                {
                    x.IsPNGDownload = download.IsPNGDownload;
                    x.IsJPGDownload = download.IsJPGDownload;
                }
                else
                {
                    x.IsPNGDownload = false;
                    x.IsJPGDownload = false;
                }
            });
            var mark = false;
            var markData = await _db.MarkInfo.ToDictionaryAsync(x => x.id, y => true);
            data.ForEach(x =>
            {
                if (markData.TryGetValue(x.id, out mark))
                {
                    x.IsMark = true;
                }
                else
                {
                    x.IsMark = false;
                }
            });

            return data;
        }

        public async Task<bool> AddDownloadData(IEnumerable<DownloadInfo> idList)
        {
            if (!idList.Any())
            {
                return true;
            }

            var existList = await _db.DownloadInfo.Select(x => x.id).ToListAsync();
            var addList = idList.Where(x => !existList.Contains(x.id));
            await _db.DownloadInfo.AddRangeAsync(addList);
            return true;

        }

        public async Task<bool> AddDownloadData(DownloadInfo info, ImageType type)
        {
            var exist = await _db.DownloadInfo.Where(x=>x.id ==info.id).FirstOrDefaultAsync();
            if (exist != default)
            {
                if ((!exist.IsJPGDownload && type == ImageType.JPG) || (!exist.IsPNGDownload && type == ImageType.PNG))
                {
                    switch (type)
                    {
                        case ImageType.PNG:
                            exist.IsPNGDownload = true;
                            break;
                        case ImageType.JPG:
                            exist.IsJPGDownload = true;
                            break;
                    }
                }
            }
            else
            {
                await _db.DownloadInfo.AddAsync(info);
            }

            await _db.SaveChangesAsync();
            return true;

        }


        public async void Dispose()
        {
            await _db.DisposeAsync();
        }

    }
}
