using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.IO;
namespace test
{
    public class EventGridFunction
    {
        private readonly ILogger<EventGridFunction> _logger;

        public EventGridFunction(ILogger<EventGridFunction> logger)
        {
            _logger = logger;
        }

        [Function("ProcessOrderStorage")]
        //[BlobOutput("orders/{rand-guid}.txt",Connection = "StorageConnectionString")]
        public string Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequestData req)
        {
            string requestBody = new StreamReader(req.Body).ReadToEndAsync().Result;

            _logger.LogInformation($"Order received: {requestBody}");

            return requestBody;
        }
    }
}