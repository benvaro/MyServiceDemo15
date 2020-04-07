using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathDemoHost
{
    class Program
    {
        static void Main(string[] args)
        { // EndPoint wcf = A-address B- binding C-contract (interface)
            ServiceHost host = new ServiceHost(typeof(MathDemo));
            host.AddServiceEndpoint(typeof(IMathDemo), new WSHttpBinding(),
                                    "http://127.0.0.1:9090/MathDemo");

            host.Open();

            Console.WriteLine("Type enter to stop");
            Console.ReadLine();
            host.Close();
        }
    }
}
