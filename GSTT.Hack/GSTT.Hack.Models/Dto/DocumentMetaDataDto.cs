using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Models.Dto
{
    public class DocumentMetaDataDto
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public bool IsSecure { get; set; }

        public int Score { get; set; }

        public string Comment { get; set; }
    }
}
