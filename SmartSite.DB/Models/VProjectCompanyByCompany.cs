using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProjectCompanyByCompany
    {
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
        public int? ProjectCompanyType { get; set; }
        public string ProjectCompanyName { get; set; }
        public string ProjectDeptJob { get; set; }
    }
}
