using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        [ServiceContract]
        interface IMathDemo
        {
            [OperationContract]
            int Add(int a, int b);
        }
        //[ServiceContract]
        //interface IScientificCalc : IMathDemo, IStat
        //{
        //    [OperationContract]
        //    double Pow(int a, int p);
        //    //...
        //    //...
        //    //...
        //}
       
        //[ServiceContract]
        //interface IStat
        //{
        //    [OperationContract]
        //    void GetStat();
        //}
        static void Main(string[] args)
        {
            ChannelFactory<IMathDemo> channelFactory = new ChannelFactory<IMathDemo>(new WSHttpBinding(),
                                                                                    new EndpointAddress("http://127.0.0.1:9090/MathDemo"));
            IMathDemo channel = channelFactory.CreateChannel();
            int res = channel.Add(20, 190);
            Console.WriteLine($"result: {res}");

            Console.ReadLine();
            channelFactory.Close();
        }
    }
}
