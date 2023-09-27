using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Model
{
    public class SessionDataModel
    {
        public string MsgCode { get; set; }
        public string Msg { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }

    }
}
