using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class CoorperateCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string DistrictCode { get; set; }
        public decimal RegisterCapital { get; set; }
        public string SocialCreditCode { get; set; }
        public string LegalMan { get; set; }
        public string LegalManId { get; set; }
        public string LegalManPhone { get; set; }
        public string CompanyAddress { get; set; }
        public int CompanyCategory { get; set; }
        public string ConstructUnit { get; set; }
        public string ProjectChargeMan { get; set; }
        public string ProjectChargeManPhone { get; set; }
        public string ProjectChargeManId { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string CompanyDescribe { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
