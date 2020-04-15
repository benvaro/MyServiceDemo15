using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BankLib
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single)]
    public class BankService : IBankService
    {
        double balance = 0;
        static int id = 0;
        List<User> client = new List<User>();
        public void IsLogin(string name)
        {
            string sessionId = OperationContext.Current.SessionId;
            User user = new User
            {
                Name = name,
                clientChannel = OperationContext.Current.GetCallbackChannel<ICallback>()
            };
            lock(user){
                client.Add(user);

                foreach (var item in client)
                {
                    item.clientChannel.Notify("Logged in: " + name);
                }
            }
        
        }
        public BankService()
        {
            ++id;
            Console.WriteLine("Account {0} created", id);
        }
        public double GetBalance()
        {
            return balance;
        }

        public void PutMoney(double money)
        {
            balance += money;
          //  client.Notify(string.Format("На вашому рахунку {0} грн", balance));

          //  client.Notify(OperationContext.Current.SessionId);
        }

        public void Disconnect()
        {

            string sessionId = OperationContext.Current.SessionId;
          //  OperationContext.Current.Channel.Close();
            int index = client.FindIndex(x => x == OperationContext.Current.GetCallbackChannel<ICallback>());
            client.RemoveAt(index);
            foreach (var item in client)
            {
                item.clientChannel.Notify("Logout in: " + sessionId);
            }
        }
    }

    public class User
    {
        public string Name;
        public ICallback clientChannel;
    }
}
