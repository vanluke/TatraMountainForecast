using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Model.Implementation;

namespace ConsoleApplication1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress();
                client.BaseAddress = new Uri("http://www.myweather2.com/developer/");
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                HttpResponseMessage response = await client.GetAsync(str);
                if (response.IsSuccessStatusCode)
                {
                    var retval = await response.Content..<Weathers>();
                }
            }
        }
    }
}
