using System;
using EasyNetQ;

namespace EasyNetQSample.Domain
{
    [Queue("MyQueue", ExchangeName = "MyExchange")]
    public class TextMessage
    {
        public TextMessage()
        {
            Environment.GetEnvironmentVariable("LOGNAME");
        }
        public string Text { get; set; }
    }
}