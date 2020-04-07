using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyGameDemo.ServiceReference1;
namespace MyGameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyGameClient gc =new MyGameClient())
            {
                Console.WriteLine("Ask a question");
                string answer = gc.GetAnswer(Console.ReadLine());
                Console.WriteLine(answer);
            }
        }
    }
}
