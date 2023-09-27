using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Model.Common
{
    public class ResponseParam
    {
        public string RspnCode { get; set; }
        public string RspnMessage { get; set; }
        public dynamic RspnData { get; set; }
    }
}
