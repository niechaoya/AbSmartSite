using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class DeviceDataCarRecognize
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string DeviceSerialNo { get; set; }
        public string DeviceName { get; set; }
        public DateTime RecognizeTime { get; set; }
        public string RecognizePhoto { get; set; }
        public string PlateId { get; set; }
        public int Direction { get; set; }
        public string DoorName { get; set; }
        public int? IsOffline { get; set; }
    }
}
