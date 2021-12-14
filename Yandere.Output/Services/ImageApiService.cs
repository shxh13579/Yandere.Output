using System.Collections.Generic;
using System.Threading.Tasks;
using Yandere.Output.Helper;
using Yandere.Output.Models;

namespace Yandere.Output.Services
{
    public class ImageApiService
    {
        public async Task<List<YandereImage>> GetList(int page, string tag, int limit = 40)
        {
            using (var http = new HttpHelper())
            {
                var imageList = await http.Get<List<YandereImage>>(ConfigurationHelper.Configuration.publicAPI.GetList, "page=" + page + "&tags=" + tag + "&limit=" + limit);
                return imageList;
            }
        }

        public async Task<List<YandereTag>> GetTagList(string name)
        {
            using (var http = new HttpHelper())
            {
                var tagList = await http.Get<List<YandereTag>>(ConfigurationHelper.Configuration.publicAPI.GetTags, "limit=10&page=1&order=count&name=" + name);
                return tagList;
            }
        }
    }
}
