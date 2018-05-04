using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTT.Hack.Function.DocumentNotification
{
    public class ProcessorResult
    {
        public ProcessorResult(bool Success, string ErrorMessage = "")
        {
            this.Success = Success;
            this.ErrorMessage = ErrorMessage;
        }

        public bool Success { get; }
        public string ErrorMessage { get; }
    }
}
