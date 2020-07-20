using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class ProjectHardware
    {
        public int Id { get; set; }
        public int? RecordProjectId { get; set; }
        public string TowercraneBim { get; set; }
        public string ElevatorBim { get; set; }
        public string LmperialMaterialBim { get; set; }
        public string SmokeSensationBim { get; set; }
        public string GasMonitoringBim { get; set; }
        public string LnfraredBim { get; set; }
        public string LrismachineBim { get; set; }
        public string HookvisualizationBim { get; set; }
        public string StrongElectricityBim { get; set; }
        public string BianLinBim { get; set; }
        public string HighFormworkBim { get; set; }
        public string LntelligentPumpBim { get; set; }
        public string VehicleBim { get; set; }
        public string CarBim { get; set; }
        public string DustBim { get; set; }
        public string ZsBim { get; set; }
        public string EnergyBim { get; set; }
        public string WaterBim { get; set; }
        public string ElectricBim { get; set; }
        public string MemberBim { get; set; }
    }
}
