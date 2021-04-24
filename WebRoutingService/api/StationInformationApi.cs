using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace WebRoutingService
{
    class StationInformationApi
    {

        private Station station;
        
        public StationInformationApi(string number, string name)
        {
            this.SetStation(number,name).Wait();
        }
        public async Task SetStation(string number, string name)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                WebProxyService.StationService.IStationService client = new WebProxyService.StationService.StationServiceClient();

                string stationsJson = JsonSerializer.Serialize(await client.GetStationAsync(number,name));

                Station station = JsonSerializer.Deserialize<Station>(stationsJson);
                this.station= station;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
          
        }

        public Station GetStation()
        {
            return this.station;
        }
    }
}
