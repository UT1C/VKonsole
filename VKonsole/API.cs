using System.Net.Http;

namespace VKonsole
{
    class API
    {
        string _token;
        HttpClient client;

        public string token {
            set { _token = value; }
        }

        public API()
        {
            this.client = new HttpClient();
        }
    }
}
