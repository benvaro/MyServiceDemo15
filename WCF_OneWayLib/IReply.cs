using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_OneWayLib
{
    [ServiceContract]
    public interface IReply
    {
        [OperationContract(IsOneWay = true)]
        void FastReply();   // запит - не очікую відповідь

        [OperationContract]
        void SlowReply();  // запит - відповідь
    }

   
}
