using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataElevator
    {
        public int Id { get; set; }
        public int? ElevatorDeviceId { get; set; }
        public decimal? ElevatorWindPole { get; set; }
        public decimal? ElevatorDipAngleX { get; set; }
        public decimal? ElevatorDipAngleY { get; set; }
        public decimal? ElevatorWeight { get; set; }
        public int? ElevatorNumber { get; set; }
        public decimal? ElevatorHeight { get; set; }
        public int? ElevatorFloor { get; set; }
        public decimal? ElevatorSpeed { get; set; }
        public bool? ElevatorIsWarn { get; set; }
        public DateTime? ElevatorDate { get; set; }
        public DateTime? ElevatorDateLog { get; set; }
    }
}
