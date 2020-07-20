using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class MemberTrain
    {
        public int Id { get; set; }
        public int? TrainMemberId { get; set; }
        public int? TrainType { get; set; }
        public int? TrainStatus { get; set; }
        public decimal? TrainScore { get; set; }
        public DateTime? TrainDate { get; set; }
    }
}
