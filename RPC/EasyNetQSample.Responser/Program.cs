using System;
using System.Threading.Tasks;
using EasyNetQ;
using EasyNetQSample.Domain;

namespace EasyNetQSample.Responser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Response machine starts....");
            
            using var bus = RabbitHutch.CreateBus("host=localhost");
            bus.RespondAsync<TestRequestMessage, TestResponseMessage>(request =>
                Task.Run(() => new Worker().Execute(request)));

            Console.ReadLine();
        }

        public class Worker
        {
            public TestResponseMessage Execute(TestRequestMessage request) => new TestResponseMessage
            {
                Message = $"reponse to '{request.Message}'"
            };
        }
    }
}