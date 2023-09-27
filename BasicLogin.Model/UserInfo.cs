using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Model
{
    public partial class UserInfo
    {
        [Key]
        public int UserID { get; set; }
        public int EmpID { get; set; }
        public int UserType { get; set; }
        public string Password { get; set; }
        public string RoleList { get; set; }
        public string Token { get; set; }
        public int CompanyID { get; set; }
        public bool IsActive { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
