using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TotalMathLib
{
    [ServiceContract]
    public interface ITotalMath
    {
        [OperationContract]
        MathData Calculate(int x, int y);
    }
}
