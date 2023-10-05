using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserMgmt
    {
        [Display(Name = "Login ID")]
        public string? LoginId { get; set; }
        [Display(Name = "User Name")]
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
