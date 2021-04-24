using Itinero;
using Itinero.Osm.Vehicles;
using Itinero.IO.Osm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using System.Net.Http.Headers;

using Newtonsoft.Json;

namespace WebRoutingService
{
    class RoutingApi
    {
        public RoutingApi()
        {
           
        }

        static readonly HttpClient client = new HttpClient();


        public async Task<Itinerary> GetDirections(Position start, Position end, string mode)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string apiKey = "5b3ce3597851110001cf62482f1530fb598f48309a676fc6513cf5cc";
                string url = "https://api.openrouteservice.org/v2/directions/"+mode+"/geojson";
                /*
                    "api_key=" + apiKey+
                    "&start=" +
                    start.longitude +
                    "," +
                    start.latitude +
                    "&end=" +
                    start.longitude +
                    "," +
                    start.latitude;*/
                BodyContent postBody = new BodyContent();
                string json = "{ \"coordinates\":[["+start.longitude+","+start.latitude+"],["+end.longitude+","+end.latitude+"]]}";
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
                HttpResponseMessage response = await client.PostAsync(url, byteContent);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Itinerary it = JsonConvert.DeserializeObject<Itinerary>(responseBody);
                return it;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
           return new Itinerary();

        }
        class BodyContent
        {
            public double[,] coordinates { get; set; }

            public BodyContent() { }
        }
    }
    
}
