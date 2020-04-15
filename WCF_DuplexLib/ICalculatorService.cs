using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_DuplexLib
{
    [ServiceContract(CallbackContract = typeof(ICalculatorCallback))]
    public interface ICalculatorService
    {
        [OperationContract(IsOneWay = true)]
        void AddTo(double num);

        [OperationContract(IsOneWay = true)]
        void SubtractFrom(double num);
        [OperationContract(IsOneWay = true)]
        void MultiplyBy(double num);
        [OperationContract(IsOneWay = true)]
        void DivideBy(double num);
    }

    public interface ICalculatorCallback
    {
        [OperationContract(IsOneWay = true)]
        void Equals(double result);
    }
}
