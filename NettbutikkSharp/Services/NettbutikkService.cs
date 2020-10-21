using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NettbutikkSharp.Services
{
    public class NettbutikkService
    {
        protected string _ShopName { get; set; }

        protected string _apiKey { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="NettbutikkService" />.
        /// </summary>
        /// <param name="storeUrl">store url</param>
        /// <param name="apiKey">An API access token for the shop.</param>
        protected NettbutikkService(string storeUrl, string apiKey)
        {
            _apiKey = apiKey;
            _ShopName = storeUrl;
        }

        protected string PrepareProductRequest(string path, int flat)
        {
            return $"{_ShopName}/api/v1/{path}?flat={flat}&access_token={_apiKey}";
        }

        protected string PrepareOrderRequest(string path)
        {
            return $"{_ShopName}/api/v1/{path}?access_token={_apiKey}";
        }

        public static async Task<T> ExecuteGetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                T responseObj;
                using (var reader = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                {
                    var content = reader.ReadToEnd();
                    responseObj = JsonConvert.DeserializeObject<T>(content);
                }
                return responseObj;
            }
        }

        public static async Task<T> ExecutePostAsync<T>(string requestJson, bool isPatchRequest, string url)
        {
            var data = new StringContent(requestJson, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                var response = !isPatchRequest ? await client.PostAsync(url, data) : await client.PatchAsync(url, data);
                var result = response.Content.ReadAsStringAsync().Result;
                var responseObj = JsonConvert.DeserializeObject<T>(result);
                return responseObj;
            }
        }
    }
}
