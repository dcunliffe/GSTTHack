using System;
using GSTT.Hack.Models.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Gstt.Hack.Api.DocumentMetaData.Controllers
{
    public class ManagementController : ApiController
    {

        // POST api/values
        public void Post([FromBody]RegisterDto RegisterSubscription)
        {

        }

        // GET api/values
        public IEnumerable<CategoryDto> GetCategories()
        {
            return new List<CategoryDto>();
        }

        public IEnumerable<SubscriptionDto> GetSubscriptionsPerUser(int userid)
        {
            return new List<SubscriptionDto>();
        }

        public IEnumerable<SubscriptionDto> GetSubscriptionsPerCategory(int categoryid)
        {
            return new List<SubscriptionDto>();
        }
    }
}
