using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebRoutingService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class PathService : IPathService
    {
      
        public Itinerary[] GetItinerary(string start, string end)
        {
            if (start == null || end == null)
            {
                return null;
            }
            NominatimApi nominatim = new NominatimApi();
            var td = Task.Run(() => nominatim.GetLocation(start));
            td.Wait();
            Position startPath = td.Result;

            var td2 = Task.Run(() => nominatim.GetLocation(end));
            td.Wait();
            Position endPath = td2.Result;

            Service service = new Service(startPath, endPath);

            return service.getItinerary();
        }

        public void GetOptions()
        {
        }

        CompositeType IPathService.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        Itinerary[] IPathService.GetPath(Position start, Position end)
        {
            if (start == null || end == null)
            {
                throw new NotImplementedException();
            }
            Service service = new Service(start,end);

            return service.getItinerary();

        }
    }
}
