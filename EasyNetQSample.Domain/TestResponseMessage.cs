using EasyNetQ;

namespace EasyNetQSample.Domain
{
    [Queue("RpcSampleQueue", ExchangeName = "RpcSampleExchange")]
    public class TestResponseMessage
    {
        public string Message { get; set; }
    }
}