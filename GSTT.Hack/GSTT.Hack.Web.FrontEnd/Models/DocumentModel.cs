using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSTT.Hack.Web.FrontEnd.Models
{
    public class DocumentModel
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public bool IsSecure { get; set; }

        public int Score { get; set; }

        public string Comment { get; set; }

        public string Uri { get; set; }

    }
}