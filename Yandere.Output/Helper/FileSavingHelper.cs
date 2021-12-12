using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Yandere.Output.Models;
using Yandere.Output.Services;

namespace Yandere.Output.Helper
{
    public static class FileSavingHelper
    {

        public static void AddDownloadJPGTask(YandereImage imageInfo, Action<YandereImage> act = null)
        {
            FileSavingHelper.AddDownloadTask(imageInfo, ImageType.JPG,act);
        }

        public static void AddDownloadPNGTask(YandereImage imageInfo, Action<YandereImage> act = null)
        {
            if (string.IsNullOrEmpty(imageInfo.source))
            {
                FileSavingHelper.AddDownloadJPGTask(imageInfo,act);
            }
            else
            {
                FileSavingHelper.AddDownloadTask(imageInfo, ImageType.PNG,act);
            }
        }

        public static void AddDownloadTask(YandereImage imageInfo, ImageType type,Action<YandereImage> act = null)
        {
            if (ThreadPool.ThreadCount < 30)
            {
                var url = "";
                string fileName = "";
                switch (type)
                {
                    case ImageType.PNG:
                        if (string.IsNullOrEmpty(imageInfo.source))
                        {
                            url = imageInfo.jpeg_url;
                            fileName = imageInfo.id.ToString() + ".jpg";
                        }
                        else
                        {
                            url = imageInfo.source;
                            fileName = imageInfo.id.ToString() + ".png";
                        }
                        break;
                    case ImageType.JPG:
                    default:
                        url = imageInfo.jpeg_url;
                        fileName = imageInfo.id.ToString() + ".jpg";
                        break;
                }
                ThreadPool.QueueUserWorkItem(new WaitCallback(async (v) =>
                {
                    using (HttpHelper http = new HttpHelper())
                    {
                        var path = ConfigurationHelper.Configuration.SavePath + "\\" + Enum.GetName(type) + "\\" + fileName;
                        if (!File.Exists(path))
                        {
                            var file = await http.GetBytes(url);
                            if (file.Length > 0)
                            {
                                await File.WriteAllBytesAsync(path, file);
                                using (ImageSaveService _saveService = new ImageSaveService())
                                {
                                    if (type == ImageType.JPG)
                                    {
                                        var addSuccess = await _saveService.AddDownloadData(new DownloadInfo { id = imageInfo.id, IsJPGDownload = true }, type);
                                        if (addSuccess)
                                        {
                                            imageInfo.IsJPGDownload = true;
                                        }
                                    }
                                    else
                                    {
                                        var addSuccess = await _saveService.AddDownloadData(new DownloadInfo { id = imageInfo.id, IsPNGDownload = true }, type);
                                        if (addSuccess)
                                        {
                                            imageInfo.IsPNGDownload = true;
                                        }
                                    }
                                    if (act != null)
                                    {
                                        act(imageInfo);
                                    }
                                }
                            }
                        }
                    }
                }));
            }
        }
    }
}
