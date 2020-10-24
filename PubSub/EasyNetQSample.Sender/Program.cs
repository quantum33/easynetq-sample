using System;
using EasyNetQ;
using EasyNetQSample.Domain;

namespace EasyNetQSample.Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using var bus = RabbitHutch.CreateBus("host=localhost");
            // IExchange exchange = bus.Advanced.ExchangeDeclare("TestExchange", ExchangeType.Direct);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Publishing message #{i}");
                bus.Publish(new TextMessage { Text = $"{i}: Hello from EasyNetQ" });
            }
        }
    }
}
