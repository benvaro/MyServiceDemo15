using ClientDuplex.ServiceReference1;
using System;
namespace ClientDuplex
{
    public class CallbackCalculator : ICalculatorServiceCallback
    {
        public void Equals(double result)
        {
            Console.WriteLine("Result: " + result);
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            // new CallbackCalculator() - об'єкт типу контракта зворотнього виклику
            // InstanceContext - будуємо об'єкту середовище виконання (хостинг об'єкта типу контракта зворотнього виклику)
            CalculatorServiceClient client = new CalculatorServiceClient(
                                    new System.ServiceModel.InstanceContext(new CallbackCalculator()));
            client.AddTo(78);
            client.AddTo(100);

            client.DivideBy(4);  // ?
            client.MultiplyBy(0.5);
            client.SubtractFrom(10);
            Console.ReadLine();
        }
    }
}
