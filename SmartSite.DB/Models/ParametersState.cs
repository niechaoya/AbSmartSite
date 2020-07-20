using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ParametersState
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string Jdbh { get; set; }
        public string DevGuid { get; set; }
        public DateTime? DevOperateTime { get; set; }
        public int? DevStatus { get; set; }
        public int WarnType { get; set; }
        public string WarnId { get; set; }
        public decimal TempXlA { get; set; }
        public decimal TempXlB { get; set; }
        public decimal TempXlC { get; set; }
        public decimal? ElecLimit { get; set; }
        public decimal? TempHj { get; set; }
        public string SubId { get; set; }
    }
}
