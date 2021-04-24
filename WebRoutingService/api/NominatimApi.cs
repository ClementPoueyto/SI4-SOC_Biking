using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebRoutingService
{
    class NominatimApi
    {
        public NominatimApi()
        {

        }

        static readonly HttpClient client = new HttpClient();


        public async Task<Position> GetLocation(string adress)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://nominatim.openstreetmap.org/search?email=clement@gmail.com&format=json&q="+adress;

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Nominatim[] location = JsonSerializer.Deserialize<Nominatim[]>(responseBody);

                if (location.Length > 0)
                {
                    Position position = new Position(Convert.ToDouble(location[0].lat), Convert.ToDouble(location[0].lon));
                    return position;
                }

                return null;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return null;

        }
    }
}
