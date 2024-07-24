using System.Net;

namespace _01_02_Decorator
{
    public class WebClientDecorator : WebClient
    {
        private readonly WebClient _client;
        public WebClientDecorator(WebClient webClient)
        {
            _client = webClient;
        }
        public string DownloadString(string address)
        {
            if(address == null)
                return string.Empty;

            if(address.StartsWith("https://price.okhovat.info"))
                return _client.DownloadString(address);
            return string.Empty;
        }
    }
}
