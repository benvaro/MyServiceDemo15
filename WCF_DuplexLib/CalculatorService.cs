using System.ServiceModel;

namespace WCF_DuplexLib
{
    public class CalculatorService : ICalculatorService
    {
        ICalculatorCallback callback = null;
        double result = 0;
        public CalculatorService()
        {
            //встановлюємо зв'язок для доступу до каналу зворотнього зв'язку
            callback = OperationContext.Current.GetCallbackChannel<ICalculatorCallback>();
        }
        public void AddTo(double num)
        {
            result += num;
            callback.Equals(result);
        }

        public void DivideBy(double num)
        {
            result /= num;
            callback.Equals(result);
        }

        public void MultiplyBy(double num)
        {
            result *= num;
            callback.Equals(result);
        }

        public void SubtractFrom(double num)
        {
            result -= num;
            callback.Equals(result);
        }
    }
}
