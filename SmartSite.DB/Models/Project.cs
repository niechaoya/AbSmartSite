using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public int? ProjectCompanyId { get; set; }
        public int? ProjectMemberId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectLinkMan { get; set; }
        public string ProjectLinkTel { get; set; }
        public int? ProjectType { get; set; }
        public int? ProjectStatus { get; set; }
        public int? ProjectIsKeyPoint { get; set; }
        public int? ProjectArea { get; set; }
        public decimal? ProjectPrice { get; set; }
        public string ProjectLayerNumber { get; set; }
        public string ProjectFunction { get; set; }
        public string ProjectConstructionName { get; set; }
        public string ProjectBuildName { get; set; }
        public string ProjectDesignName { get; set; }
        public string ProjectSupervisorName { get; set; }
        public string ProjectSurveyName { get; set; }
        public string ProjectAppList { get; set; }
        public int? ProjectArea1Id { get; set; }
        public string ProjectArea1 { get; set; }
        public int? ProjectArea2Id { get; set; }
        public string ProjectArea2 { get; set; }
        public int? ProjectArea3Id { get; set; }
        public string ProjectArea3 { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectLongitude { get; set; }
        public string ProjectLatitude { get; set; }
        public string ProjectIntro { get; set; }
        public decimal? ProjectWidth { get; set; }
        public decimal? ProjectLength { get; set; }
        public string ProjectPhoto { get; set; }
        public string ProjectPlanarPhoto { get; set; }
        public string ProjectEffectPhoto { get; set; }
        public decimal? ProjectAqi { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public DateTime? ProjectCreateDate { get; set; }
        public string ProjectUrlBim { get; set; }
        public string ProjectUrl3d { get; set; }
        public string ProjectUrlCheck { get; set; }
    }
}
