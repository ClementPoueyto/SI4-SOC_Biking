using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace WebRoutingService
{
    class ListStationsProxyApi
    {

        private List<Station> stations;
        
        public ListStationsProxyApi()
        {
            this.SetStations().Wait();
        }
        public async Task SetStations( )
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                WebProxyService.StationService.IStationService client = new WebProxyService.StationService.StationServiceClient();

                string stationsJson = JsonSerializer.Serialize(await client.GetDataAsync());

                List<Station> stations = JsonSerializer.Deserialize<List<Station>>(stationsJson);
                this.stations= stations;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
          
        }

        public List<Station> GetStations()
        {
            return this.stations;
        }
    }
}
