using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberPayMoney
    {
        public int Id { get; set; }
        public int? PayMoneyMemberId { get; set; }
        public string PayMoneyTitle { get; set; }
        public int? PayMoneyNumber { get; set; }
        public string PayMoneyPhoto { get; set; }
        public string PayMoneyFile { get; set; }
        public int? PayMoneyStatus { get; set; }
        public DateTime? PayMoneyDate { get; set; }
    }
}
