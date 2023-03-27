using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.JobForCore.MCore
{
    public class ApiMessage<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } 
        public int code { get; set; }
        public bool Success { get; set; }
    }
}
