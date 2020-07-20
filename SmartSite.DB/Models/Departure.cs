using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Departure
    {
        public int Id { get; set; }
        public int? Uid { get; set; }
        public DateTime? LeavingTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? Voucher { get; set; }
        public string VoucherPhoto { get; set; }
        public int? Score { get; set; }
        public string Comments { get; set; }
    }
}
