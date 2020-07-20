using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class VProject2company
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectCompanyId { get; set; }
        public string ProjectCompanyName { get; set; }
        public int? ProjectDeptId { get; set; }
        public string ProjectDeptName { get; set; }
        public string ProjectDeptJob { get; set; }
        public int? ProjectCompanyType { get; set; }
        public DateTime? ProjectCompanyDate { get; set; }
        public string CompanyNo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLinkMan { get; set; }
        public string CompanyLinkTel { get; set; }
    }
}
