using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectCheckData
    {
        public int Id { get; set; }
        public int? CheckPointId { get; set; }
        public int? CheckRouteId { get; set; }
        public int? CheckMemberId { get; set; }
        public int? CheckStatus { get; set; }
        public string CheckPhoto { get; set; }
        public string CheckDescribe { get; set; }
        public int? CheckIsCode { get; set; }
        public DateTime? CheckDate { get; set; }
        public int? CheckProjectId { get; set; }
    }
}
