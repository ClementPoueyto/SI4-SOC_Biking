using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHosted
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(WebRoutingService.PathService));
            ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(WebRoutingService.IPathService),
                new WebHttpBinding(), "Web");
            endpoint.Behaviors.Add(new WebHttpBehavior());
            host.Open();
            Console.WriteLine("bonjour, c'est le serveur");

            Console.ReadLine();

          }
    }
}
