using GSTT.Hack.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Function.DocumentNotification
{
    interface IDocumentProcessor
    {
        ProcessorResult Process(DocumentDto document);
    }
}
