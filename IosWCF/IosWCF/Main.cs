using System;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows.Forms;

namespace IosWCF
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //serviceHost = (ServiceHostBase)Activator.CreateInstance(typeof(WebServiceHost), new object[] { typeof(WCFService) });
            //serviceHost.Opened += delegate
            //{
            //    label1.Text = "已经打开";
            //};
            //serviceHost.Open();
            //Uri baseAddress = new Uri("http://127.0.0.1:9998/PersonRetriever");
            //using (ServiceHost host = new ServiceHost(typeof(PersonRetriever), baseAddress))
            //{
            //    WebHttpBinding binding = new WebHttpBinding();
            //    ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IPersonRetriever), binding, baseAddress);
            //    WebHttpBehavior httpBehavior = new WebHttpBehavior();
            //    endpoint.Behaviors.Add(httpBehavior);
            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("Hosted successfully.");
            //    };
            //    host.Open();
            //    Console.ReadLine();
            //}


            //string LocalIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(x => x.AddressFamily.ToString() == "InterNetwork").ToString();
            //Uri baseAddress = new Uri("http://" + LocalIp + ":9999/WCFService");
            //using (ServiceHost host = new ServiceHost(typeof(WCFService)))
            //{
            //    //var binding = new WebHttpBinding();
            //    //binding.ReceiveTimeout = TimeSpan.MaxValue;
            //    //host.AddServiceEndpoint(typeof(WCFService), binding, "http://" + LocalIp + ":9999/WCFService");
            //    //host.Opened += delegate
            //    //{
            //    //    label1.Text = "Server is running!";
            //    //};
            //    //host.Open();
            //    WebHttpBinding binding = new WebHttpBinding();
            //    ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(WCFService), binding, baseAddress);
            //    WebHttpBehavior httpBehavior = new WebHttpBehavior();
            //    endpoint.Behaviors.Add(httpBehavior);
            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("Hosted successfully.");
            //    };
            //    host.Open();
            //    Console.ReadLine();
            //}
        }
    }
}
