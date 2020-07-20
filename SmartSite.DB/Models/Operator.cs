using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Operator
    {
        public int Id { get; set; }
        public string OperatorName { get; set; }
        public string OperatorIdCard { get; set; }
        public string OperatorTel { get; set; }
        public int? OperatorType { get; set; }
        public string OperatorCredentialNo { get; set; }
        public string OperatorCredentialPhoto { get; set; }
        public int? OperatorDay { get; set; }
        public DateTime? OperatorReviewDate { get; set; }
        public DateTime? OperatorCreateDate { get; set; }
    }
}
