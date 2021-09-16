using System.Net;

namespace TestConsimple.Logic
{
    public static class JsonReader
    {
        public static string Connection(string url)
        {
            using var webClient = new WebClient();
            var json = webClient.DownloadString(url);
            return json;
        }
    }
}