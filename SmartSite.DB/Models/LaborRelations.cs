using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class LaborRelations
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public int Uid { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? DateSigning { get; set; }
        public DateTime? LimitedDate { get; set; }
        public string ServiceContract { get; set; }
    }
}
