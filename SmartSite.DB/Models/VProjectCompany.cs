using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProjectCompany
    {
        public string CompanyName { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
    }
}
