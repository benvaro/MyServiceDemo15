using BankClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient
{
    public class CallbackHandler : IBankServiceCallback
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
