using GSTT.Hack.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gstt.Hack.Api.DocumentMetaData.Controllers
{
    public class DocumentController : ApiController
    {
        // GET api/values
        public IEnumerable<DocumentMetaDataDto> Get()
        {
            return new List<DocumentMetaDataDto>
            {
                new DocumentMetaDataDto
                {
                    Id = 111,
                    Category = "catgory 1",
                    Comment = "this is a comment for 1",
                    IsSecure = true,
                    Score = 11
                },
                new DocumentMetaDataDto
                {
                    Id = 222,
                    Category = "catgory 2",
                    Comment = "this is a comment for 2",
                    IsSecure = false,
                    Score = 2
                }
            };
        }

        // GET api/values/5
        public DocumentMetaDataDto Get(int id)
        {
            return new DocumentMetaDataDto
            {
                Id = id,
                Category = "catgory " + id,
                Comment = "this is a comment for " + id,
                IsSecure = true,
                Score = id * 2
            };
        }

        // POST api/values
        public void Post([FromBody]DocumentMetaDataDto documentMetaData)
        {

        }
    }
}
