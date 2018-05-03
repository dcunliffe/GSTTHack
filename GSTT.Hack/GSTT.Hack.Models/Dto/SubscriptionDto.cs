using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Models.Dto
{
    public class SubscriptionDto
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public string EmailAddress { get; set; }

        public int CategoryID { get; set; }

    }
}
