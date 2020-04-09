using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TotalMathLib;

namespace TotalMathHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Total Math Host";
            using (ServiceHost host = new ServiceHost(typeof(TotalMath)))
            {
                host.Open();
                Console.WriteLine("Service is ready");
                Console.ReadLine();
            }
        }
    }
}
