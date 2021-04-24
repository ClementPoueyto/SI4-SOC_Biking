using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRoutingService
{
    public class Service
    {
        static List<Station> stations =null;
        Station startStation = new Station();
        Station arrivalStation = new Station();
        Position start;
        Position end;
        public Service(Position start, Position end)
        {
            this.start = start;
            this.end = end;
            if (stations == null)
            {
                stations = CallStationsApi();
            }
            this.startStation = getClosestStation(start,true);
            this.arrivalStation = getClosestStation(end,false);

        }

        public List<Station> CallStationsApi()
        {
            ListStationsProxyApi listStationsApi = new ListStationsProxyApi();
            stations = listStationsApi.GetStations();
            return stations;
        }

        public Station CallStationAvalaibilityApi(string number, string name)
        {
            StationInformationApi stationInfoApi = new StationInformationApi(number,name);
            return stationInfoApi.GetStation();
            
        }

        public bool isBikeAvailable(Station station,bool isStart)
        {

            Station s = CallStationAvalaibilityApi(station.number.ToString(), station.contractName);
            Availabilities av = new Availabilities();
            if (s.mainStands != null&&s.mainStands.availabilities!=null)
            {
                av = s.mainStands.availabilities;
            }
            if (s.totalStands != null&&s.totalStands.availabilities!=null)
            {
                 av = s.totalStands.availabilities;
            }
            
            if (isStart ==true&&( av.bikes>0 || av.bikmechanicalBikeses > 0 || av.electricalBikes > 0 || av.electricalInternalBatteryBikes > 0 || av.electricalRemovableBatteryBikes > 0))
            {
                return true;
            }
            if (isStart == false && av.stands > 0)
            {
                return true;
            }
            return false;
        }
        public Station getClosestStation(Position pos, bool isStart)
        {
            if (pos ==null || pos.latitude < -90 || pos.latitude > 90 || pos.longitude < -180 || pos.longitude > 180)
            {
                return null;
            }
         
            var sCoord = new GeoCoordinate(pos.latitude, pos.longitude);

            Station station = null;

            List<Station> orderedStations = stations;

            orderedStations=  orderedStations.OrderBy(s => sCoord.GetDistanceTo(new GeoCoordinate(s.position.latitude, s.position.longitude))).ToList();

            for(int i = 0; i < orderedStations.Count() && station == null; i++)
            {
                
                if (isBikeAvailable(orderedStations[i], isStart)) {
                    station = orderedStations[i];
                    return station;
                }
             }
            
            return station;
        }

        public Itinerary[] getItinerary()
        {
            RoutingApi routing = new RoutingApi();
            if (startStation==null|| arrivalStation==null || startStation.position == null || arrivalStation.position ==null)
            {
                return new Itinerary[3];
            }
            Itinerary[] itineraries = new Itinerary[3];
            itineraries[0]=routing.GetDirections(start,startStation.position, "foot-walking").Result;
            itineraries[1] = routing.GetDirections(startStation.position, arrivalStation.position, "cycling-road").Result;
            itineraries[2] = routing.GetDirections(arrivalStation.position, end, "foot-walking").Result;
            return itineraries;
        }




    }

}
