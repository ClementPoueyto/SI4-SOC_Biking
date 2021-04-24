using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebProxyService
{
    [DataContract]
    public class Availabilities
    {
        [DataMember]

        public int bikes { get; set; }
        [DataMember]

        public int stands { get; set; }
        [DataMember]

        public int bikmechanicalBikeses { get; set; }
        [DataMember]

        public int electricalBikes { get; set; }
        [DataMember]

        public int electricalInternalBatteryBikes { get; set; }
        [DataMember]

        public int electricalRemovableBatteryBikes { get; set; }

        public Availabilities()
        {

        }

        public Availabilities(int bikes, int stands, int bikmechanicalBikeses, int electricalBikes, int electricalInternalBatteryBikes, int electricalRemovableBatteryBikes)
        {
            this.bikes = bikes;
            this.stands = stands;
            this.bikmechanicalBikeses = bikmechanicalBikeses;
            this.electricalBikes = electricalBikes;
            this.electricalInternalBatteryBikes = electricalInternalBatteryBikes;
            this.electricalRemovableBatteryBikes = electricalRemovableBatteryBikes;
        }

        public override string ToString()
        {
            return "bikes : " + this.bikes + "\n" +
                "stands : " + this.stands + "\n" +
                "bikmechanicalBikeses : " + this.bikmechanicalBikeses + "\n" +
                "electricalBikes : " + this.electricalBikes + "\n" +
                "electricalInternalBatteryBikes : " + this.electricalInternalBatteryBikes + "\n" +
                "electricalRemovableBatteryBikes : " + this.electricalRemovableBatteryBikes + "\n";
        }
    }
}
