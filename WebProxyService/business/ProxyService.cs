using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProxyService
{
    class ProxyService
    {
        string stationsKey = "stations";

        public ProxyService()
        {

        }

        public Station[] getAllStations()
        {

            ProxyCache<Station[]> proxyCache = new ProxyCache<Station[]>();
            Station[] stations = proxyCache.Get(stationsKey);
            if (stations==null||stations.Length==0){
                ListStationsApi client = new ListStationsApi();
                proxyCache.Set(stationsKey,client.GetStations());
                stations = proxyCache.Get(stationsKey);
            }
            return stations;
            
        }

        public Station getStation(string number, string name)
        {
            String key = name + "/" + number;
            ProxyCache<Station> proxyCache = new ProxyCache<Station>();
            Station s = proxyCache.Get(key);
            if (s == null)
            {
                StationApi client = new StationApi(number,name);
                proxyCache.Set(key, client.GetStation(), 60);
                s = proxyCache.Get(key);
            }

            return s;
        }

    }
}
