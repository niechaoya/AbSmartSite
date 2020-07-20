using System;
using System.Collections.Generic;

namespace SmartSite.DB.Models
{
    public partial class PersonalInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string IdcardNo { get; set; }
        public string BedNumber { get; set; }
        public int? PartyMember { get; set; }
        public string Phone { get; set; }
        public string GraduateSchool { get; set; }
        public string EmergencyContact { get; set; }
        public string Portrait { get; set; }
        public string MedicalReport { get; set; }
        public int? IsMonitor { get; set; }
        public string RadioFrequency { get; set; }
        public int TeamId { get; set; }
        public int PersonTypeId { get; set; }
        public int? WorkCertificateId { get; set; }
        public int? TypeOfWorkId { get; set; }
        public int? CategoryOfPersonnel { get; set; }
        public string TertiaryDducation { get; set; }
        public string PositionLabel { get; set; }
        public int? IsManagementPersonnel { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? Brithday { get; set; }
        public int? Synchronization { get; set; }
        public string DocumentPhoto { get; set; }
        public string Temperature { get; set; }
        public int? RecordStatus { get; set; }
        public string Address { get; set; }
        public DateTime? ApproachTime { get; set; }
        public int GuestCard { get; set; }
        public DateTime? LeavingTime { get; set; }
        public int? CulturalLevel { get; set; }
        public DateTime? CreateTime { get; set; }
        public string DocumentVerso { get; set; }
        public string ImageType { get; set; }
        public int? FaceIssue { get; set; }
        public int? ProjectId { get; set; }
        public string CertificateAddress { get; set; }
    }
}
