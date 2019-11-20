using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace launchDarklyFeatureToggle.Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            Task.Delay(3000);

            for (int i = 0; i < 100; i++)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/api/values");
                var client = new HttpClient();
                var result = await client.SendAsync(request);
                if (result.IsSuccessStatusCode)
                {
                    var message = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(message);  
                }
              
            }

            Console.ReadKey();
        }
    }
}
