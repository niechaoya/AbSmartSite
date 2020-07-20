using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project3companyDept
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
        public string ProjectDept1Name { get; set; }
        public string ProjectDept2Name { get; set; }
    }
}
