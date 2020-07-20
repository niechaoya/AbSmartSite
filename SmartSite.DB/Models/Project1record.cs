using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project1record
    {
        public int Id { get; set; }
        public int? RecordProjectId { get; set; }
        public int? RecordMemberId { get; set; }
        public string RecordTitle { get; set; }
        public string RecordPhoto { get; set; }
        public string RecordDescribe { get; set; }
        public int? RecordDefaultIsShow { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
