using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class SysFavorite
    {
        public int Id { get; set; }
        public int? FavMemberId { get; set; }
        public string FavObjectType { get; set; }
        public int? FavObjectId { get; set; }
        public int? FavStatus { get; set; }
        public DateTime? FavDate { get; set; }
        public DateTime? FavDateCancel { get; set; }
    }
}
