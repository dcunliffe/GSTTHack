
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using GSTT.Hack.Models.Dto;
using System.Collections.Generic;

namespace Gstt.Hack.Function.Document
{
    public static class Function1
    {
        [FunctionName("Document")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            switch(req.Method.ToLower())
            {
                case "post":
                    return new CreatedResult("\\", $"Created");
                case "get":
                    if (string.IsNullOrEmpty(req.Query["id"]))
                    {
                        var docs = new List<DocumentDto>()
                        {
                            new DocumentDto( ) { Id = "1"},
                            new DocumentDto() { Id = "2"}
                        };
                        return new OkObjectResult(docs);
                    }
                    else
                    {
                        var doc = new DocumentDto()
                        {
                            Id = req.Query["id"]
                        };

                        return new OkObjectResult(doc);
                    }
            }


            return new BadRequestObjectResult("");
            /* log.Info("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

           string requestBody = new StreamReader(req.Body).ReadToEnd();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");*/
        }
    }
}
