using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataAccess.Http
{
    public class WebRequestExploration
    {
        public static void TestWebRequest()
        {
            WebRequest webRequest = WebRequest.Create("https://4tune.pl/");
            var response = webRequest.GetResponse();

            using (StreamReader responseReader = new StreamReader(response.GetResponseStream()))
            {
                var siteText = responseReader.ReadToEnd();
                Console.WriteLine(siteText);
            }
        }

        public static void TestWebClient()
        {
            using (WebClient webClient = new WebClient())
            {
                var siteTest = webClient.DownloadString("https://4tune.pl/");
                Console.WriteLine(siteTest);
            }
        }

        public static async Task<string> ReadWebPageAsync()
        {
            using (WebClient client = new WebClient())
            {
                return await client.DownloadStringTaskAsync("https://4tune.pl/");
            }
        }

        public static async Task<string> TestHttpClientAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync("https://4tune.pl/");
            }
        }
    }
}