﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTT.Hack.Management.FrontEnd.Models
{
    public class SubscriptionsModel
    {
        public List<CategoryModel> Categories{ get; set; }
        public string EmailAddress { get; set; }
    }
}