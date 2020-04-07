using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    [ServiceContract]
    public interface IMathDemo
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
