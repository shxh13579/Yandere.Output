using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output.Services
{
    public class ImageQueryService
    {
        public async Task<List<YandereImage>> GetList(int page, string tag,int limit = 40)
        {
            using (var http = new HttpHelper())
            {
                var imageList = await http.Get<List<YandereImage>>(ConfigurationHelper.Configuration.publicAPI.GetList, "page=" + page + "&tags=" + tag + "&limit=" + limit);
                return imageList;
            }
        }
    }
}
