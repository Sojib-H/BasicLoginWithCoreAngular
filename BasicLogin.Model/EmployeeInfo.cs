using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Model
{
    public partial class EmployeeInfo
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string EmpNameBangla { get; set; }
        public int DesignationID { get; set; }
        public int DepartmentID { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string FamilyParticulars { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }
        public int CompanyID { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
