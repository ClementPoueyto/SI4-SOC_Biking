using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebProxyService
{
    [DataContract]
    public class Stand
    {
        [DataMember]

        public Availabilities availabilities { get; set; }
        [DataMember]

        public int capacity { get; set; }

        public Stand()
        {

        }

        public Stand(Availabilities availabilities, int capacity)
        {
            this.availabilities = availabilities;
            this.capacity = capacity;
        }

        public override string ToString()
        {
            return "availabilities : " + this.availabilities + "\n" +
                "capacity : " + this.capacity;
        }
    }
}
