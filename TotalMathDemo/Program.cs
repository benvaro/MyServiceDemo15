using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalMathDemo.ServiceReference1;
namespace TotalMathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TotalMathClient proxy = new TotalMathClient())
            {
                MathData data = proxy.Calculate(15,3);
                Console.WriteLine($"Add {data.resAdd}");
                Console.WriteLine($"Sub {data.resSub}");
                Console.WriteLine($"Mult {data.resMult}");
                Console.WriteLine($"Div {data.resDiv}");
            }
        }
    }
}
