using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysFeedback
    {
        public int Id { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public int? FeedbackMemberId { get; set; }
        public string FeedbackManName { get; set; }
        public string FeedbackManTel { get; set; }
        public int? FeedbackObjectType { get; set; }
        public int? FeedbackObjectId { get; set; }
        public string FeedbackObjectName { get; set; }
        public int? FeedbackObjectFid { get; set; }
        public string FeedbackIntro { get; set; }
        public string FeedbackRepty { get; set; }
        public DateTime? FeedbackReptyDate { get; set; }
        public int? FeedbackStatus { get; set; }
    }
}
