using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VendorInvitationForm
    {
        public string? SupplierName { get; set; }
        public string? ContactPerson { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierMobile { get; set; }
        public string? ProjectName { get; set; }
        public string? InitialSubmitionDeadline { get; set; }
        public string? GPDOwner { get; set; }
        public string? Region { get; set; }
        public string? SupplierFormGuideline { get; set; }
        public string? EmailBody { get; set; }
        public string? BusinessUserName { get; set; }
        public string? BusinessUserEmail { get; set; }
        public string? CommodityName { get; set; }

        public string? BVM_Code { get; set; }
        public string? BVM_Name { get; set; }

    }
    
}
