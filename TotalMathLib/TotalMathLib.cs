using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TotalMathLib
{
    [DataContract]
    public class MathData
    {
        [DataMember]
        public int resAdd;
        [DataMember]
        public int resSub;
        [DataMember]
        public int resDiv;
        [DataMember]
        public int resMult;
    }
    
    public class TotalMath : ITotalMath
    {
        public MathData Calculate(int x, int y)
        {
            MathData data = new MathData();
            data.resAdd = x + y;
            data.resSub = x - y;
            data.resMult = x * y;
            data.resDiv = x / y;
            return data;
        }
    }
}
