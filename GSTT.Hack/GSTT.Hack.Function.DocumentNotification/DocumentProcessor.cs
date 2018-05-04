using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSTT.Hack.Models.Dto;

namespace GSTT.Hack.Function.DocumentNotification
{
    public class DocumentProcessor : IDocumentProcessor
    {
        public ProcessorResult Process(DocumentDto document)
        {
            if (document == null)
            {
                return new ProcessorResult(false, "No document provided.");
            }

            if (string.IsNullOrEmpty(document.Id))
            {
                return new ProcessorResult(false, "No document id provided.");
            }

            return new ProcessorResult(true);
        }
    }
}
