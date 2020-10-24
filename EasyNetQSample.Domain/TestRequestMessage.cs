using EasyNetQ;

namespace EasyNetQSample.Domain
{
    [Queue("RpcSampleQueue", ExchangeName = "RpcSampleExchange")]
    public class TestRequestMessage
    {
        public string Message { get; set; }
    }
}