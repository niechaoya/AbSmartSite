using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Profession
    {
        public int Id { get; set; }
        public string MaleSpecies { get; set; }
        public string NameMaleSpecies { get; set; }
        public int? SpecialWorker { get; set; }
    }
}
