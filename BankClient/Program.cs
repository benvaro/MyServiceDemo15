using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BankClient.ServiceReference1;

namespace BankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BankServiceClient proxy = new BankServiceClient(new InstanceContext(new CallbackHandler())))
            {
                double money;
                Console.WriteLine("Enter name:");
                proxy.IsLogin(Console.ReadLine());
               //     return;
                do
                {
                    Console.WriteLine("Введіть суму грошей:");
                    money = Convert.ToDouble(Console.ReadLine());
                    proxy.PutMoney(money);
                    Console.WriteLine("Balance: {0}", proxy.GetBalance());
                } while (money > 0);
                proxy.Disconnect();
            }
        }
    }
}
