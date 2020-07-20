using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public int? CompanyProjectId { get; set; }
        public string CompanyNo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLinkMan { get; set; }
        public string CompanyLinkTel { get; set; }
        public int? CompanyArea1Id { get; set; }
        public string CompanyArea1 { get; set; }
        public int? CompanyArea2Id { get; set; }
        public string CompanyArea2 { get; set; }
        public int? CompanyArea3Id { get; set; }
        public string CompanyArea3 { get; set; }
        public string CompanyAddress { get; set; }
        public int? CompanyType { get; set; }
        public string CompanyIntro { get; set; }
        public string CompanyPhoto { get; set; }
        public string CompanyVision { get; set; }
        public string CompanyMission { get; set; }
        public string CompanyTarget { get; set; }
        public string CompanySpirit { get; set; }
        public string CompanyMind { get; set; }
        public DateTime? CompanyCreateDate { get; set; }
        public string ProjectChargeManId { get; set; }
        public string SocialCreditCode { get; set; }
        public string ConstructUnit { get; set; }
        public decimal? RegisterCapital { get; set; }
        public string LegalManId { get; set; }
        public string ProjectChargeMan { get; set; }
        public string ProjectChargeManPhone { get; set; }
    }
}
