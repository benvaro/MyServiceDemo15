using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Client_OneWay.ServiceReference1;


namespace WCF_Client_OneWay
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ReplyClient client = new ReplyClient())
            {
                Console.WriteLine("Enter number:");
                int a = Convert.ToInt32(Console.ReadLine());
             //   client.SlowReply();
              client.FastReply();
                Console.WriteLine("U put: " + a);
            }
        }
    }
}
