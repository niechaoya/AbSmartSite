using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public int? DeptCompanyId { get; set; }
        public string DeptName { get; set; }
        public string DeptLinkMan { get; set; }
        public string DeptLinkTel { get; set; }
        public string DeptIntro { get; set; }
        public string DeptNumber { get; set; }
        public DateTime? DeptCreateDate { get; set; }
        public string Foreman { get; set; }
        public string Telephone { get; set; }
        public decimal? Amount { get; set; }
        public string ContractDocuments { get; set; }
        public string DepPhoto { get; set; }
        public string FilePath { get; set; }
        public int? Sex { get; set; }
        public int? ProjectId { get; set; }
    }
}
