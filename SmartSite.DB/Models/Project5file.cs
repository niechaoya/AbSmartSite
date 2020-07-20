using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project5file
    {
        public int Id { get; set; }
        public int? FileProjectId { get; set; }
        public int? FileCompanyId { get; set; }
        public int? FileProjectCompanyId { get; set; }
        public int? FileProjectCompanyId1 { get; set; }
        public string FileProjectCompanyName1 { get; set; }
        public int? FileProjectCompanyId2 { get; set; }
        public string FileProjectCompanyName2 { get; set; }
        public string FileDir1 { get; set; }
        public string FileDir2 { get; set; }
        public string FileName { get; set; }
        public string FilePtoto { get; set; }
        public string FileUrl { get; set; }
        public decimal? FileSize { get; set; }
        public string FileFormat { get; set; }
        public string FileType { get; set; }
        public int? FileLevel { get; set; }
        public int? FileMemberId { get; set; }
        public int? FilePid { get; set; }
        public int? FilePid1 { get; set; }
        public string FileQrcodeImg { get; set; }
        public DateTime? FileDate { get; set; }
        public string FilePower { get; set; }
        public DateTime? Fieldate { get; set; }
    }
}
