using System;
using Sess2.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
//using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.IO;

namespace Sess3
{
    class Program
    {
        static void Main(string[] args)
        {
             GetData();
            Console.ReadLine();
        }

        private static async void GetData()
        {
            string url = "https://localhost:44315/api/customers";

            HttpClient client = new HttpClient();            

            client.BaseAddress = new Uri(url);

            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.RequestUri = new Uri(url);
            requestMessage.Method = HttpMethod.Get;
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            requestMessage.Headers.Add("Access-Control-Allow-Origin", "*");

            var result = await client.SendAsync(requestMessage);

            if(result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = await result.Content.ReadAsStringAsync();
                Console.WriteLine(data);

                JsonSerializer jsonSerializer = new JsonSerializer();
                var textReader = new StringReader(data);
                JsonTextReader reader = new JsonTextReader(textReader);

                var customers = jsonSerializer.Deserialize<IEnumerable<Customer>>(reader);

                foreach (var item in customers)
                {
                    Console.WriteLine(item.Name);
                }
            }

         
        }
    }
}
