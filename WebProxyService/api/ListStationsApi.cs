using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace WebProxyService
{
    class ListStationsApi
    {

        static readonly HttpClient client = new HttpClient();
        private Station[] stations;
        
        public ListStationsApi()
        {
            SetStations().Wait();
        }
        public async Task SetStations( )
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://api.jcdecaux.com/vls/v3/";
                string data = "stations";
                string apiKey = "1e8fa1e0e4cf13b66a513ec8f8c2efaf51a4f3f9";
              
                HttpResponseMessage response = await client.GetAsync(url + data + "?" + "&apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                this.stations = JsonSerializer.Deserialize<Station[]>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }          
        }

        public Station[] GetStations()
        {
            return this.stations;
        }
    }
}
