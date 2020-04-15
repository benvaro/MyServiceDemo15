using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    [ServiceContract(CallbackContract =typeof(ICallback))]
    public interface IBankService
    {
        [OperationContract] void PutMoney(double money);
        [OperationContract] double GetBalance();
        [OperationContract] void IsLogin(string name);
        [OperationContract(IsOneWay =true)] void Disconnect();
    }

    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void Notify(string message);
    }
}
