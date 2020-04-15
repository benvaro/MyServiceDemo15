using BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(BankService)))
            {
                host.Open();
                Console.WriteLine("Host works..");
                Console.ReadLine();
            }
        }
    }
}
