using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
namespace Worker
{
    public class Program
    {
        static HttpClient httpclient = new HttpClient();
        public static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }
        public static async Task MainAsync(string[] args)
        {
            while(true)
            {
                var bytes = await httpclient.GetByteArrayAsync("http://gen/8");
                var results = await httpclient.PostAsync("http://hashr/hashme",  new ByteArrayContent(bytes));
                results.EnsureSuccessStatusCode();
                var hashResults = await results.Content.ReadAsStringAsync();
                var dbResult = await httpclient.GetStringAsync($"http://store/store?dt={DateTime.Now.ToString()}");
                await Task.Delay(1000);
            }
        }
    }
}
