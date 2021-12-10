using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using Yandere.Output.Models;

namespace Yandere.Output.Helper
{
    public static class FileSavingHelper
    {
        public static ConcurrentDictionary<string, string> fileList = new ConcurrentDictionary<string, string>();

        public static void AddDownloadJPGTask(YandereImage imageInfo)
        {
            FileSavingHelper.AddDownloadTask(imageInfo.jpeg_url, ImageType.JPG, imageInfo.id.ToString() + ".jpg");
        }

        public static void AddDownloadPNGTask(YandereImage imageInfo)
        {
            if (string.IsNullOrEmpty(imageInfo.source))
            {
                FileSavingHelper.AddDownloadJPGTask(imageInfo);
            }
            else
            {
                FileSavingHelper.AddDownloadTask(imageInfo.source, ImageType.PNG, imageInfo.id.ToString() + ".png");
            }
        }

        public static void AddDownloadTask(string url, ImageType type, string fileName)
        {
            if (ThreadPool.ThreadCount < 30)
            {
                if (!fileList.ContainsKey(fileName))
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(async (v) =>
                    {
                        using (HttpHelper http = new HttpHelper())
                        {
                            var path = ConfigurationHelper.Configuration.SavePath + "\\" + Enum.GetName(type) + "\\" + fileName;
                            var success = fileList.TryAdd(fileName, path);
                            if (success)
                            {
                                if (!File.Exists(path))
                                {
                                    var file = await http.GetBytes(url);
                                    if (file.Length > 0)
                                        await File.WriteAllBytesAsync(path, file);
                                }
                            }
                        }
                    }));
                }
            }
        }
    }
}
