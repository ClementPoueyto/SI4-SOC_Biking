using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace SelfHostedProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WebProxyService.StationService));
            host.Open();
            Console.WriteLine("bonjour, c'est le proxy");

            Console.ReadLine();
        }
    }
}
