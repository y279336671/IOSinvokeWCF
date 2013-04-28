using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace PointService
{
    class Program
    {
        //http://127.0.0.1:9998/PersonRetriever/Persons/Tom
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://127.0.0.1:9998/PointService");
            using (ServiceHost host = new ServiceHost(typeof(PointService), baseAddress))
            {
                WebHttpBinding binding = new WebHttpBinding();
                ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IPointService), binding, baseAddress);
                WebHttpBehavior httpBehavior = new WebHttpBehavior();
                endpoint.Behaviors.Add(httpBehavior);
                host.Opened += delegate
                {
                    Console.WriteLine("Hosted successfully.");
                };
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
