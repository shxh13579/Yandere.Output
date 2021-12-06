using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Yandere.Output.Helper
{
    public class HttpHelper:IDisposable
    {
        public void Dispose()
        {
            _client.Dispose();
        }

        private HttpClient _client;

        public HttpHelper()
        {
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<T> Post<T>(string url,object body)
        {
            try
            {
                using(var content = new StringContent(JsonConvert.SerializeObject(body)))
                {
                    var resp = await _client.PostAsync(url, content).ConfigureAwait(false);
                    var resultData = await resp.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(resultData);
                }
            }
            catch(Exception e)
            {
                return default(T);
            }
        }
        public async Task<T> Get<T>(string url, string param)
        {
            try
            {
                var combinedUrl = url.Contains("?") ? (url + "&" + param) : (url + "?" + param);
                var resp = await _client.GetStringAsync(combinedUrl).ConfigureAwait(false);
                return JsonConvert.DeserializeObject<T>(resp);
            }
            catch (Exception e)
            {
                return default(T);
            }
        }

    }
}
