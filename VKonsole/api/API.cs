using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VKonsole
{
    public class API
    {
        private const string api_uri = "https://api.vk.com/";
        private HttpClient client;
        private string token;
        public string Token {
            private get { return token; }
            set { token = value; }
        }

        public API()
        {
            this.client = new HttpClient();
        }

        async public Task<Dictionary<string, dynamic>> Request(string method, Dictionary<string, dynamic> params)
        {
            return await client.PostAsync(
                $"{API.api_uri}{method}"
            );
        }
    }
}
