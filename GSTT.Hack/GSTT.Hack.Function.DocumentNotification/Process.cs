using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;
using GSTT.Hack.Models.Dto;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace GSTT.Hack.Function.DocumentNotification
{
    public static class Process
    {
        private static IContainer container;

        [FunctionName("Process")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("Document notification has been received.");

            SetupServices();

            // Get request body
            var readerService = container.Resolve<IBodyReader<DocumentDto>>();
            var item = readerService.ReadBody(req.Content);

            var processor = container.Resolve<IDocumentProcessor>();
            var result = processor.Process(item);

            if (result.Success)
            {
                return req.CreateResponse(HttpStatusCode.OK);
            }

            log.Error($"Error occured whilst processing message. Id: {item.Id}, Filename: {item.FileName}. Error: {result.ErrorMessage}");
            return req.CreateErrorResponse(HttpStatusCode.InternalServerError, result.ErrorMessage);
        }

        private static void SetupServices()
        {
            if (container == default(IContainer))
            {
                var builder = new ContainerBuilder();

                builder.RegisterType<JsonBodyReader>().As<IBodyReader<DocumentDto>>().SingleInstance();
                builder.RegisterType<DocumentProcessor>().As<IDocumentProcessor>().SingleInstance();

                container = builder.Build();

            }
        }
    }
}
