using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberLogin
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime? LoginDate { get; set; }
        public string LoginMacId { get; set; }
        public string LoginMacType { get; set; }
        public string LoginLocation { get; set; }
    }
}
