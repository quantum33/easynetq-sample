using System;
using EasyNetQ;
using EasyNetQSample.Domain;

namespace EasyNetQSample.Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RECEIVER");

            using var bus = RabbitHutch.CreateBus("host=localhost");
            // bus.Advanced.QueueDeclare("TestQueue");

            bus.Subscribe<TextMessage>("test", message =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Got message: {message.Text}");
                Console.ResetColor();
            });
            Console.WriteLine("Listening....");
            Console.ReadLine();
        }
    }
}