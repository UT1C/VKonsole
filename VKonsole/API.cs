using System.Net.Http;

namespace VKonsole
{
    class API
    {
        HttpClient client;

        public API()
        {
            this.client = new HttpClient();
        }
    }
}
