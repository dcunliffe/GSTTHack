using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;
using GSTT.Hack.Function.DocumentNotification;
using GSTT.Hack.Models.Dto;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace GSTT.Hack.Tests
{
    [TestClass]
    public class DocumentNotificationProcessTests
    {
        private TraceWriterStub log;

        [TestInitialize]
        public void Initialise()
        {
            this.log = new TraceWriterStub(TraceLevel.Verbose);
        }

        [TestMethod]
        public void TestValidDocumentMessageReturnsOK()
        {
            // Arrange
            var validDocument = new DocumentDto()
            {
                Id = "valid",
                FileName = "validfilename"
            };
            var jsonContent = JsonConvert.SerializeObject(validDocument);

            // Act
            var response = Function.DocumentNotification.Process.Run(CreateRequest(jsonContent), this.log).Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        public void TestInvalidDocumentMessageReturnsError()
        {
            // Arrange
            // Act
            // Assert
        }

        private static HttpRequestMessage CreateRequest(string json)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            var httpConfig = new HttpConfiguration();
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            return request;
        }

        protected class TraceWriterStub : TraceWriter
        {
            protected TraceLevel _level;
            protected List<TraceEvent> _traces;

            public TraceWriterStub(TraceLevel level) : base(level)
            {
                _level = level;
                _traces = new List<TraceEvent>();
            }

            public override void Trace(TraceEvent traceEvent)
            {
                _traces.Add(traceEvent);
            }

            public List<TraceEvent> Traces => _traces;
        }
    }
}
