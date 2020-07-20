using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectAcceptance
    {
        public int Id { get; set; }
        public int? AcceptanceProjectId { get; set; }
        public int? AcceptanceMemberId { get; set; }
        public string AcceptanceMemberName { get; set; }
        public int? AcceptanceCompanyId { get; set; }
        public string AcceptanceCompanyName { get; set; }
        public string AcceptanceDeptName { get; set; }
        public string AcceptanceTitle { get; set; }
        public string AcceptanceFrontDesc { get; set; }
        public DateTime? AcceptancePlanDate { get; set; }
        public string AcceptanceFrontPhoto { get; set; }
        public string AcceptanceFrontVideo { get; set; }
        public int? AcceptanceStatus { get; set; }
        public string AcceptanceDesc { get; set; }
        public string AcceptancePhoto { get; set; }
        public string AcceptanceVideo { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public DateTime? AcceptanceConfirmDate { get; set; }
        public DateTime? AcceptanceCreateDate { get; set; }
    }
}
