using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRoutingService
{
    class Nominatim
    {
        public double place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public double osm_id { get; set; }

        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }

        public string type { get; set; }
        public double importance { get; set; }

        public Nominatim()
        {

        }
    }
}
