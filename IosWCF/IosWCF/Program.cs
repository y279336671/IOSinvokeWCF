using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Windows.Forms;

namespace PointService
{
    class Program
    {
        //http://127.0.0.1:9998/PersonRetriever/Persons/Tom
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://127.0.0.1:9998/PersonRetriever");
            using (ServiceHost host = new ServiceHost(typeof(PersonRetriever), baseAddress))
            {
                WebHttpBinding binding = new WebHttpBinding();
                ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IPersonRetriever), binding, baseAddress);
                WebHttpBehavior httpBehavior = new WebHttpBehavior();
                endpoint.Behaviors.Add(httpBehavior);
                host.Opened += delegate
                {
                    Console.WriteLine("Hosted successfully.");
                };
                host.Open();
                Console.ReadLine();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IosWCF.Main());
        }
    }
}
