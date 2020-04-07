using MyGameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyGameHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WCF Host Works");
            using (ServiceHost host = new ServiceHost(typeof(MyGame)))
            {
                host.Open();
                ShowABC(host);
                Console.WriteLine("Service is ready");
                Console.ReadLine();
            }
        }

        private static void ShowABC(ServiceHost host)
        {
            Console.WriteLine("Host info...");
            foreach (var item in host.Description.Endpoints)
            {
                Console.WriteLine("Address {0}", item.Address);
                Console.WriteLine("Binding {0}", item.Binding.Name);
                Console.WriteLine("Contract {0}", item.Contract.Name);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
