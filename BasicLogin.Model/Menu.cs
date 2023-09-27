using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Model
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        public string ParentId { get; set; }
        public string MenuText { get; set; }
        public string Url { get; set; }
        public int MenuOrder { get; set; }
        public string Icon { get; set; }
        public int IsActive { get; set; }

        [NotMapped]
        public string RootMenu { get; set; }

        [NotMapped]
        public int UserID { get; set; }

    }
}
