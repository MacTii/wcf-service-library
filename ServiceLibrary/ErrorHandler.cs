using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace ServiceLibrary
{
    [DataContract]
    public class ErrorHandler
    {
        public ErrorHandler(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
