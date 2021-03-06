using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace WebRoutingService
{
    [DataContract]
    public class Itinerary
    {
        [DataMember]
        public Feature[] features { get; set; }

        [DataMember]
        public double[] bbox { get; set; }
        public Itinerary()
        {

        }

        public override string ToString()
        {
            string res = "";
            foreach (Feature step in features)
            {
                res = res + step + "\n";
            }
            return res;
        }
    }
}
