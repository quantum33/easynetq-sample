using System;
using EasyNetQ;
using EasyNetQSample.Domain;

namespace EasyNetQSample.Requester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Requester starts.......");
            using var bus = RabbitHutch.CreateBus("host=localhost");
            bus.RequestAsync<TestRequestMessage, TestResponseMessage>(new TestRequestMessage {Message = "hello"})
                .ContinueWith(response =>
                {
                    Console.WriteLine($"Got response: {response.Result.Message}");
                });

            Console.ReadLine();
        }
    }
}