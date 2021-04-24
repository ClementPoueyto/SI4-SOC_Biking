using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BikeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string condition = "y";

            while (condition == "y")
            {
                WebRoutingService.IPathService pathService = new WebRoutingService.PathServiceClient();
                Console.WriteLine("Entrer adresse (1) ou coordonees GPS (2)");
                string mode = Console.ReadLine();
                if (mode == "1")
                {
                    Console.WriteLine("Entrer adresse du point de départ :");
                    string depart = Console.ReadLine();
                    Console.WriteLine("Entrer adresse du point d'arrivée :");
                    string fin = Console.ReadLine();

                    WebRoutingService.Itinerary[] itineraries = pathService.GetItinerary(depart, fin);

                    displayResult(itineraries);
                    Console.ReadLine();
                }
                else if (mode == "2")
                {
                    WebRoutingService.Position start = new WebRoutingService.Position();
                    WebRoutingService.Position arrival = new WebRoutingService.Position();

                    Console.WriteLine("Entrer coordonées du point de départ : \nLatitude :");
                    try
                    {
                        start.latitude = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Entrer coordonées du point de départ : \nLongitude :");
                        start.longitude = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Entrer coordonées du point d'arrivée : \nLatitude :");
                        arrival.latitude = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Entrer coordonées du point d'arrivée : \nLongitude :");
                        arrival.longitude = Convert.ToDouble(Console.ReadLine());

                        WebRoutingService.Itinerary[] itineraries = pathService.GetPath(start, arrival);
                        displayResult(itineraries);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wrong parameter");
                    }
                    Console.ReadLine();
                }


                Console.WriteLine("\nContinuer ? y/n");
                condition = Console.ReadLine();
            }

        }

        static void displayResult(WebRoutingService.Itinerary[] itineraries)
        {
            if (itineraries.Length != 3 || itineraries[0] == null)
            {
                Console.WriteLine("bad parameters");
                return;
            }
            foreach (WebRoutingService.Itinerary it in itineraries)
            {
                if (it != null&&it.features!=null)
                {
                    foreach (WebRoutingService.Feature ft in it.features)
                    {
                        if (ft != null)
                        {
                            foreach (WebRoutingService.Segment sg in ft.properties.segments)
                            {
                                Console.WriteLine("\ndistance : " + sg.distance.ToString() + " m");
                                Console.WriteLine("duration : " + sg.duration / 60 + " min");

                                foreach (WebRoutingService.Step st in sg.steps)
                                {
                                    Console.WriteLine(st.instruction.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
