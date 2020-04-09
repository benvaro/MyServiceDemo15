using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TotalMathLib;

namespace StudentHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Student host";
            using (ServiceHost host = new ServiceHost(typeof(StudentService)))
            {
                host.Open();
                Console.WriteLine("Service works...");
                Console.ReadLine();
            }
        }
    }
}
