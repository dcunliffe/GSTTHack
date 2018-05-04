using GSTT.Hack.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Function.DocumentNotification
{
    public class JsonBodyReader : IBodyReader<DocumentDto>
    {
        public DocumentDto ReadBody(HttpContent content)
        {
            var jsonContent = content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<DocumentDto>(jsonContent);
            return entity;
        }
    }
}
