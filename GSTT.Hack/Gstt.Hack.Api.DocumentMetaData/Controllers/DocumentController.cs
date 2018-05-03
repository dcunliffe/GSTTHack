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
            return new List<DocumentMetaDataDto>();
        }

        // GET api/values/5
        public DocumentMetaDataDto Get(int id)
        {
            return new DocumentMetaDataDto();
        }

        // POST api/values
        public void Post([FromBody]DocumentMetaDataDto documentMetaData)
        {

        }
    }
}
