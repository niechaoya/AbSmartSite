using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartSite.DB.Models
{
    public partial class subei_iot_2019_workspaceContext : DbContext
    {
        public subei_iot_2019_workspaceContext()
        {
        }

        public subei_iot_2019_workspaceContext(DbContextOptions<subei_iot_2019_workspaceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adict> Adict { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<ChannelDatas> ChannelDatas { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CoorperateCompany> CoorperateCompany { get; set; }
        public virtual DbSet<CoorperateCompanyType> CoorperateCompanyType { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Departure> Departure { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceAlarm> DeviceAlarm { get; set; }
        public virtual DbSet<DeviceAt> DeviceAt { get; set; }
        public virtual DbSet<DeviceData> DeviceData { get; set; }
        public virtual DbSet<DeviceDataCarRecognize> DeviceDataCarRecognize { get; set; }
        public virtual DbSet<DeviceDataCliver> DeviceDataCliver { get; set; }
        public virtual DbSet<DeviceDataDust> DeviceDataDust { get; set; }
        public virtual DbSet<DeviceDataEarthPump> DeviceDataEarthPump { get; set; }
        public virtual DbSet<DeviceDataElectric> DeviceDataElectric { get; set; }
        public virtual DbSet<DeviceDataElectricalFire> DeviceDataElectricalFire { get; set; }
        public virtual DbSet<DeviceDataElevator> DeviceDataElevator { get; set; }
        public virtual DbSet<DeviceDataHighFormwork> DeviceDataHighFormwork { get; set; }
        public virtual DbSet<DeviceDataInfraRed> DeviceDataInfraRed { get; set; }
        public virtual DbSet<DeviceDataIris> DeviceDataIris { get; set; }
        public virtual DbSet<DeviceDataProtect> DeviceDataProtect { get; set; }
        public virtual DbSet<DeviceDataSmoke> DeviceDataSmoke { get; set; }
        public virtual DbSet<DeviceDataStrongElectricity> DeviceDataStrongElectricity { get; set; }
        public virtual DbSet<DeviceDataTowerCrane> DeviceDataTowerCrane { get; set; }
        public virtual DbSet<DeviceDataUnloading> DeviceDataUnloading { get; set; }
        public virtual DbSet<DeviceDataWater> DeviceDataWater { get; set; }
        public virtual DbSet<DeviceDataWeather> DeviceDataWeather { get; set; }
        public virtual DbSet<DevicePush> DevicePush { get; set; }
        public virtual DbSet<DevicePushRecord> DevicePushRecord { get; set; }
        public virtual DbSet<DeviceRegister> DeviceRegister { get; set; }
        public virtual DbSet<DeviceSwitchMode> DeviceSwitchMode { get; set; }
        public virtual DbSet<DeviceSwitchRecording> DeviceSwitchRecording { get; set; }
        public virtual DbSet<DeviceThresholdSetting> DeviceThresholdSetting { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<DustEnvironmentEquipment> DustEnvironmentEquipment { get; set; }
        public virtual DbSet<DustEnvironmentalData> DustEnvironmentalData { get; set; }
        public virtual DbSet<Gplot> Gplot { get; set; }
        public virtual DbSet<LaborRelations> LaborRelations { get; set; }
        public virtual DbSet<LeaveTemplate> LeaveTemplate { get; set; }
        public virtual DbSet<LifterRealTime> LifterRealTime { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberLocation> MemberLocation { get; set; }
        public virtual DbSet<MemberLogin> MemberLogin { get; set; }
        public virtual DbSet<MemberPayMoney> MemberPayMoney { get; set; }
        public virtual DbSet<MemberProject> MemberProject { get; set; }
        public virtual DbSet<MemberTrain> MemberTrain { get; set; }
        public virtual DbSet<MemberWorkLog> MemberWorkLog { get; set; }
        public virtual DbSet<MemberWorkType> MemberWorkType { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<ParametersElectricBox> ParametersElectricBox { get; set; }
        public virtual DbSet<ParametersState> ParametersState { get; set; }
        public virtual DbSet<Payoff> Payoff { get; set; }
        public virtual DbSet<PersonalInformation> PersonalInformation { get; set; }
        public virtual DbSet<PersonnelCategory> PersonnelCategory { get; set; }
        public virtual DbSet<PersonnelType> PersonnelType { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Project1record> Project1record { get; set; }
        public virtual DbSet<Project2company> Project2company { get; set; }
        public virtual DbSet<Project3companyDept> Project3companyDept { get; set; }
        public virtual DbSet<Project4member> Project4member { get; set; }
        public virtual DbSet<Project5file> Project5file { get; set; }
        public virtual DbSet<Project6milepost> Project6milepost { get; set; }
        public virtual DbSet<Project7video> Project7video { get; set; }
        public virtual DbSet<ProjectAcceptance> ProjectAcceptance { get; set; }
        public virtual DbSet<ProjectCheckData> ProjectCheckData { get; set; }
        public virtual DbSet<ProjectCheckNote> ProjectCheckNote { get; set; }
        public virtual DbSet<ProjectCheckPoint> ProjectCheckPoint { get; set; }
        public virtual DbSet<ProjectCheckRoute> ProjectCheckRoute { get; set; }
        public virtual DbSet<ProjectHardware> ProjectHardware { get; set; }
        public virtual DbSet<ProjectShot> ProjectShot { get; set; }
        public virtual DbSet<ProjectShotLog> ProjectShotLog { get; set; }
        public virtual DbSet<ProjectShotSafe> ProjectShotSafe { get; set; }
        public virtual DbSet<ProjectShotSafeMember> ProjectShotSafeMember { get; set; }
        public virtual DbSet<ProjectShotSaftLog> ProjectShotSaftLog { get; set; }
        public virtual DbSet<SalaryInformation> SalaryInformation { get; set; }
        public virtual DbSet<SysApplication> SysApplication { get; set; }
        public virtual DbSet<SysAttach> SysAttach { get; set; }
        public virtual DbSet<SysBanner> SysBanner { get; set; }
        public virtual DbSet<SysBannerType> SysBannerType { get; set; }
        public virtual DbSet<SysButton> SysButton { get; set; }
        public virtual DbSet<SysDept> SysDept { get; set; }
        public virtual DbSet<SysDict> SysDict { get; set; }
        public virtual DbSet<SysFavorite> SysFavorite { get; set; }
        public virtual DbSet<SysFeedback> SysFeedback { get; set; }
        public virtual DbSet<SysLang> SysLang { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }
        public virtual DbSet<SysLogError> SysLogError { get; set; }
        public virtual DbSet<SysLogLogin> SysLogLogin { get; set; }
        public virtual DbSet<SysLoginType> SysLoginType { get; set; }
        public virtual DbSet<SysMenu> SysMenu { get; set; }
        public virtual DbSet<SysMessage> SysMessage { get; set; }
        public virtual DbSet<SysPhotos> SysPhotos { get; set; }
        public virtual DbSet<SysSend> SysSend { get; set; }
        public virtual DbSet<SysSendLog> SysSendLog { get; set; }
        public virtual DbSet<SysSet> SysSet { get; set; }
        public virtual DbSet<SysShare> SysShare { get; set; }
        public virtual DbSet<SysSms> SysSms { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<SysUserRole> SysUserRole { get; set; }
        public virtual DbSet<SysUserRoleMenu> SysUserRoleMenu { get; set; }
        public virtual DbSet<TimerStartSprayRegularly> TimerStartSprayRegularly { get; set; }
        public virtual DbSet<TowerRegistration> TowerRegistration { get; set; }
        public virtual DbSet<UnloadingDeviceRealTimeData> UnloadingDeviceRealTimeData { get; set; }
        public virtual DbSet<VDevice> VDevice { get; set; }
        public virtual DbSet<VDeviceAlarm> VDeviceAlarm { get; set; }
        public virtual DbSet<VDeviceByType> VDeviceByType { get; set; }
        public virtual DbSet<VDeviceData> VDeviceData { get; set; }
        public virtual DbSet<VDeviceDataDust> VDeviceDataDust { get; set; }
        public virtual DbSet<VDeviceDataDustB03avg> VDeviceDataDustB03avg { get; set; }
        public virtual DbSet<VDeviceDataDustByDay> VDeviceDataDustByDay { get; set; }
        public virtual DbSet<VDeviceTotal> VDeviceTotal { get; set; }
        public virtual DbSet<VMember> VMember { get; set; }
        public virtual DbSet<VMemberTotal> VMemberTotal { get; set; }
        public virtual DbSet<VMemberTotalByAge> VMemberTotalByAge { get; set; }
        public virtual DbSet<VProject> VProject { get; set; }
        public virtual DbSet<VProject2company> VProject2company { get; set; }
        public virtual DbSet<VProject7video> VProject7video { get; set; }
        public virtual DbSet<VProjectCheckDataByPoint> VProjectCheckDataByPoint { get; set; }
        public virtual DbSet<VProjectCheckDataByRoute> VProjectCheckDataByRoute { get; set; }
        public virtual DbSet<VProjectCheckNote> VProjectCheckNote { get; set; }
        public virtual DbSet<VProjectCheckPoint> VProjectCheckPoint { get; set; }
        public virtual DbSet<VProjectCheckRoute> VProjectCheckRoute { get; set; }
        public virtual DbSet<VProjectCompany> VProjectCompany { get; set; }
        public virtual DbSet<VProjectCompanyByCompany> VProjectCompanyByCompany { get; set; }
        public virtual DbSet<VProjectMember> VProjectMember { get; set; }
        public virtual DbSet<VProjectShotSafe> VProjectShotSafe { get; set; }
        public virtual DbSet<VProjectShotSafeMember> VProjectShotSafeMember { get; set; }
        public virtual DbSet<VProjectTotal> VProjectTotal { get; set; }
        public virtual DbSet<VShotSafe> VShotSafe { get; set; }
        public virtual DbSet<VUserRoleMenu> VUserRoleMenu { get; set; }
        public virtual DbSet<WeixinMenu> WeixinMenu { get; set; }
        public virtual DbSet<WeixinMsg> WeixinMsg { get; set; }
        public virtual DbSet<WeixinSend> WeixinSend { get; set; }
        public virtual DbSet<WeixinSendModel> WeixinSendModel { get; set; }
        public virtual DbSet<WeixinSetting> WeixinSetting { get; set; }
        public virtual DbSet<WeixinUser> WeixinUser { get; set; }
        public virtual DbSet<WeixinUserAttr> WeixinUserAttr { get; set; }
        public virtual DbSet<WorkCertificate> WorkCertificate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=subei_iot_2019_workspace;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adict>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AltCode)
                    .HasMaxLength(50)
                    .HasComment("报警代码");

                entity.Property(e => e.AltName)
                    .HasMaxLength(50)
                    .HasComment("报警名称");

                entity.Property(e => e.GrpCode)
                    .HasMaxLength(50)
                    .HasComment("项点代码");

                entity.Property(e => e.GrpName)
                    .HasMaxLength(50)
                    .HasComment("项点名称");

                entity.Property(e => e.SysCode)
                    .HasMaxLength(50)
                    .HasComment("系统代码");

                entity.Property(e => e.SysName)
                    .HasMaxLength(50)
                    .HasComment("系统名称(6a,检测棚,走形)");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.AreaPhoto).HasMaxLength(100);

                entity.Property(e => e.AreaRemark).HasMaxLength(500);
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasIndex(e => new { e.Uid, e.ClockInTime })
                    .HasName("AttendanceDay");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClockInTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Picture).IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasIndex(e => e.BankName)
                    .HasName("addBankName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChannelDatas>(entity =>
            {
                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(50)
                    .HasComment("详细地址");

                entity.Property(e => e.CompanyArea1).HasMaxLength(50);

                entity.Property(e => e.CompanyArea2).HasMaxLength(50);

                entity.Property(e => e.CompanyArea3).HasMaxLength(50);

                entity.Property(e => e.CompanyCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.CompanyIntro).HasComment("公司简介");

                entity.Property(e => e.CompanyLinkMan)
                    .HasMaxLength(50)
                    .HasComment("负责人");

                entity.Property(e => e.CompanyLinkTel)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.CompanyMind).HasComment("员工心愿");

                entity.Property(e => e.CompanyMission).HasComment("企业使命");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasComment("单位名称");

                entity.Property(e => e.CompanyNo)
                    .HasMaxLength(50)
                    .HasComment("资质编号");

                entity.Property(e => e.CompanyPhoto)
                    .HasMaxLength(100)
                    .HasComment("图片");

                entity.Property(e => e.CompanyProjectId).HasComment("项目id");

                entity.Property(e => e.CompanySpirit).HasComment("企业精神");

                entity.Property(e => e.CompanyTarget).HasComment("企业目标");

                entity.Property(e => e.CompanyType).HasComment("1 施工单位 2 劳务单位 3.企业");

                entity.Property(e => e.CompanyVision).HasComment("企业愿景");

                entity.Property(e => e.ConstructUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LegalManId)
                    .HasColumnName("LegalMan_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectChargeMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectChargeManId)
                    .HasColumnName("ProjectChargeMan_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectChargeManPhone)
                    .HasColumnName("ProjectChargeMan_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterCapital).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.SocialCreditCode)
                    .HasColumnName("Social_Credit_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoorperateCompany>(entity =>
            {
                entity.ToTable("Coorperate_Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyDescribe).HasMaxLength(500);

                entity.Property(e => e.CompanyLogo).HasColumnType("image");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConstructUnit)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LegalMan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LegalManId)
                    .IsRequired()
                    .HasColumnName("LegalMan_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LegalManPhone)
                    .IsRequired()
                    .HasColumnName("LegalMan_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectChargeMan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectChargeManId)
                    .HasColumnName("ProjectChargeMan_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectChargeManPhone)
                    .IsRequired()
                    .HasColumnName("ProjectChargeMan_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterCapital).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.SocialCreditCode)
                    .IsRequired()
                    .HasColumnName("Social_Credit_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoorperateCompanyType>(entity =>
            {
                entity.ToTable("Coorperate_Company_Type");

                entity.HasIndex(e => e.CompanyTypeName)
                    .HasName("AK_COMPANYTYPENAME_COORPERA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.HasIndex(e => e.CultureType)
                    .HasName("addCultureName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CultureType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.ContractDocuments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepPhoto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCompanyId).HasComment("公司id");

                entity.Property(e => e.DeptCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.DeptIntro).HasComment("部门简介");

                entity.Property(e => e.DeptLinkMan)
                    .HasMaxLength(50)
                    .HasComment("负责人");

                entity.Property(e => e.DeptLinkTel)
                    .HasMaxLength(50)
                    .HasComment("联系电话");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .HasComment("部门名称");

                entity.Property(e => e.DeptNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("部门人数");

                entity.Property(e => e.FilePath)
                    .HasColumnName("filePath")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Foreman)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.LeavingTime)
                    .HasColumnName("leavingTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.VoucherPhoto)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasIndex(e => e.DeviceNo)
                    .HasName("Unique_DeviceNo")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BlackBoxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceAddress)
                    .HasMaxLength(100)
                    .HasComment("设备详细地址");

                entity.Property(e => e.DeviceArea1).HasMaxLength(50);

                entity.Property(e => e.DeviceArea2).HasMaxLength(50);

                entity.Property(e => e.DeviceArea3).HasMaxLength(50);

                entity.Property(e => e.DeviceAtDate)
                    .HasColumnType("datetime")
                    .HasComment("最新命令时间");

                entity.Property(e => e.DeviceCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceDoorName).HasMaxLength(200);

                entity.Property(e => e.DeviceGroup)
                    .HasMaxLength(50)
                    .HasComment("组别");

                entity.Property(e => e.DeviceHeartDate)
                    .HasColumnType("datetime")
                    .HasComment("最新心跳时间");

                entity.Property(e => e.DeviceInstallDate)
                    .HasColumnType("datetime")
                    .HasComment("安装日期");

                entity.Property(e => e.DeviceLatitude)
                    .HasMaxLength(50)
                    .HasComment("纬度");

                entity.Property(e => e.DeviceLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceLongitude)
                    .HasMaxLength(50)
                    .HasComment("经度");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .HasComment("设备名称");

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("设备编号/ESN");

                entity.Property(e => e.DeviceProductionName)
                    .HasMaxLength(50)
                    .HasComment("生产厂家");

                entity.Property(e => e.DeviceProjectId).HasComment("项目");

                entity.Property(e => e.DeviceRecordNumber)
                    .HasMaxLength(50)
                    .HasComment("备案编号");

                entity.Property(e => e.DeviceSpecs)
                    .HasMaxLength(50)
                    .HasComment("规格型号");

                entity.Property(e => e.DeviceStatus).HasComment("设备状态(1.在线 2.离线)");

                entity.Property(e => e.DeviceSwitch).HasComment("开关 0为关 1为开");

                entity.Property(e => e.DeviceType1Id).HasComment("设备环境类型");

                entity.Property(e => e.DeviceTypeId).HasComment("设备类型");

                entity.Property(e => e.DeviceTypeName).HasMaxLength(200);

                entity.Property(e => e.InternetContenProvider)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturers)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TradeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAlarm>(entity =>
            {
                entity.ToTable("Device_Alarm");

                entity.HasIndex(e => new { e.DeviceNo, e.AlarmDate })
                    .HasName("Index_DeviceNo_AlarmDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlarmDate)
                    .HasColumnType("datetime")
                    .HasComment("报警时间");

                entity.Property(e => e.AlarmDeviceDataId).HasComment("设备数据id");

                entity.Property(e => e.AlarmDeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmDeviceType).HasComment("报警类型");

                entity.Property(e => e.AlarmExceedValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("超标值");

                entity.Property(e => e.AlarmIntro)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.AlarmValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("报警值");

                entity.Property(e => e.AlarmWarnName)
                    .HasMaxLength(50)
                    .HasComment("报警因子名称");

                entity.Property(e => e.AlarmWarningValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("警告值");

                entity.Property(e => e.DeviceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceAtDate)
                    .HasColumnType("datetime")
                    .HasComment("命令时间");

                entity.Property(e => e.DeviceAtIntro)
                    .HasMaxLength(200)
                    .HasComment("命令内容");

                entity.Property(e => e.DeviceAtStatus).HasComment("命令状态 1.成功 2.失败");

                entity.Property(e => e.DeviceAtType)
                    .HasMaxLength(50)
                    .HasComment("命令类型");

                entity.Property(e => e.DeviceId).HasComment("设备");
            });

            modelBuilder.Entity<DeviceData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceAddress).HasMaxLength(50);

                entity.Property(e => e.DeviceArea1).HasMaxLength(50);

                entity.Property(e => e.DeviceArea2).HasMaxLength(50);

                entity.Property(e => e.DeviceArea3).HasMaxLength(50);

                entity.Property(e => e.DeviceDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.DeviceDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.DeviceId).HasComment("设备id");

                entity.Property(e => e.DeviceLocation).HasMaxLength(50);

                entity.Property(e => e.DeviceLocationBaidu).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceDataCarRecognize>(entity =>
            {
                entity.ToTable("DeviceData_CarRecognize");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceName).HasMaxLength(100);

                entity.Property(e => e.DeviceSerialNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DoorName).HasMaxLength(100);

                entity.Property(e => e.LicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlateId)
                    .HasColumnName("PlateID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecognizePhoto).IsUnicode(false);

                entity.Property(e => e.RecognizeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeviceDataCliver>(entity =>
            {
                entity.ToTable("DeviceData_Cliver");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CliverDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.CliverDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.CliverDeviceId).HasComment("设备id");

                entity.Property(e => e.CliverDipAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾角");

                entity.Property(e => e.CliverHeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("高度");

                entity.Property(e => e.CliverHumidity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("湿度");

                entity.Property(e => e.CliverIsWarn).HasComment("是否报警");

                entity.Property(e => e.CliverMoment)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("力矩");

                entity.Property(e => e.CliverRange)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("幅度");

                entity.Property(e => e.CliverRotation)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("回装");

                entity.Property(e => e.CliverTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.CliverVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");

                entity.Property(e => e.CliverWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("重量");

                entity.Property(e => e.CliverWindSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("风速");
            });

            modelBuilder.Entity<DeviceDataDust>(entity =>
            {
                entity.ToTable("DeviceData_Dust");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceDataB03)
                    .HasColumnName("DeviceData_b03")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataCo)
                    .HasColumnName("DeviceData_co")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.DeviceDataH01)
                    .HasColumnName("DeviceData_h01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataHumidity)
                    .HasColumnName("DeviceData_humidity")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("湿度");

                entity.Property(e => e.DeviceDataNo2)
                    .HasColumnName("DeviceData_no2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("二氧化氮");

                entity.Property(e => e.DeviceDataO3)
                    .HasColumnName("DeviceData_o3")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("o3");

                entity.Property(e => e.DeviceDataPa)
                    .HasColumnName("DeviceData_pa")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("气压");

                entity.Property(e => e.DeviceDataPm10)
                    .HasColumnName("DeviceData_pm10")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("pm10");

                entity.Property(e => e.DeviceDataPm25)
                    .HasColumnName("DeviceData_pm25")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("pm25");

                entity.Property(e => e.DeviceDataPrimary)
                    .HasColumnName("DeviceData_Primary")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("首要污染物");

                entity.Property(e => e.DeviceDataSo2)
                    .HasColumnName("DeviceData_so2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.DeviceDataT01)
                    .HasColumnName("DeviceData_t01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataTemp)
                    .HasColumnName("DeviceData_temp")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.DeviceDataTsp)
                    .HasColumnName("DeviceData_tsp")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("tsp");

                entity.Property(e => e.DeviceDataW01)
                    .HasColumnName("DeviceData_w01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataW02)
                    .HasColumnName("DeviceData_w02")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataWd)
                    .HasColumnName("DeviceData_wd")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("风向");

                entity.Property(e => e.DeviceDataWp)
                    .HasColumnName("DeviceData_wp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataWs)
                    .HasColumnName("DeviceData_ws")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("风速");

                entity.Property(e => e.DeviceDataZs)
                    .HasColumnName("DeviceData_zs")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("噪声");

                entity.Property(e => e.DeviceDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.DeviceDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.DeviceIsWarn).HasComment("是否报警");
            });

            modelBuilder.Entity<DeviceDataEarthPump>(entity =>
            {
                entity.ToTable("DeviceData_EarthPump");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EarthPumpDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.EarthPumpDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.EarthPumpDeviceId).HasComment("地泵设备id");

                entity.Property(e => e.EarthPumpElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.EarthPumpIsWarn).HasComment("是否报警");

                entity.Property(e => e.EarthPumpTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.EarthPumpVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");

                entity.Property(e => e.EarthPumpWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("重量");
            });

            modelBuilder.Entity<DeviceDataElectric>(entity =>
            {
                entity.ToTable("DeviceData_Electric");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.ElectricDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.ElectricDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.ElectricDeviceId).HasComment("设备id");

                entity.Property(e => e.ElectricIsWarn).HasComment("是否报警");

                entity.Property(e => e.ElectricNumber)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("总量");

                entity.Property(e => e.ElectricNumberUse)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("使用量");

                entity.Property(e => e.ElectricPower)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("功率");

                entity.Property(e => e.ElectricVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");
            });

            modelBuilder.Entity<DeviceDataElectricalFire>(entity =>
            {
                entity.ToTable("DeviceData_ElectricalFire");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElectricalFireCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.ElectricalFireDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.ElectricalFireDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.ElectricalFireDeviceId).HasComment("设备id");

                entity.Property(e => e.ElectricalFireElectricEnergy)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电能");

                entity.Property(e => e.ElectricalFireHarmonic)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("谐波");

                entity.Property(e => e.ElectricalFirePower)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("功率");

                entity.Property(e => e.ElectricalFireTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.ElectricalFireVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");

                entity.Property(e => e.ElectricalIsWarn).HasComment("是否报警");
            });

            modelBuilder.Entity<DeviceDataElevator>(entity =>
            {
                entity.ToTable("DeviceData_Elevator");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElevatorDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.ElevatorDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.ElevatorDeviceId).HasComment("设备id");

                entity.Property(e => e.ElevatorDipAngleX)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾角x");

                entity.Property(e => e.ElevatorDipAngleY)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾角y");

                entity.Property(e => e.ElevatorFloor).HasComment("楼层");

                entity.Property(e => e.ElevatorHeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("高度");

                entity.Property(e => e.ElevatorIsWarn).HasComment("是否报警");

                entity.Property(e => e.ElevatorNumber).HasComment("人数");

                entity.Property(e => e.ElevatorSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("速度");

                entity.Property(e => e.ElevatorWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("重量");

                entity.Property(e => e.ElevatorWindPole)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("风况");
            });

            modelBuilder.Entity<DeviceDataHighFormwork>(entity =>
            {
                entity.ToTable("DeviceData_HighFormwork");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HighFormworkAxialForce)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("轴力");

                entity.Property(e => e.HighFormworkDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.HighFormworkDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.HighFormworkDeviceId).HasComment("高大支模设备id");

                entity.Property(e => e.HighFormworkIsWarn).HasComment("是否报警");

                entity.Property(e => e.HighFormworkSettle)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("沉降");

                entity.Property(e => e.HighFormworkShift)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("水平位移");

                entity.Property(e => e.HighFormworkTilt)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾斜");
            });

            modelBuilder.Entity<DeviceDataInfraRed>(entity =>
            {
                entity.ToTable("DeviceData_InfraRed");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InfraRedDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.InfraRedDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.InfraRedDeviceId).HasComment("红外对射设备id");

                entity.Property(e => e.InfraRedDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("警戒距离");

                entity.Property(e => e.InfraRedElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.InfraRedIsWarn).HasComment("是否报警");

                entity.Property(e => e.InfraRedLightNum).HasComment("光束数");

                entity.Property(e => e.InfraRedLightSource)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("光源");

                entity.Property(e => e.InfraRedLnductionSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("感应速度");

                entity.Property(e => e.InfraRedMode)
                    .HasMaxLength(50)
                    .HasComment("探测方式");

                entity.Property(e => e.InfraRedTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("环境温度");

                entity.Property(e => e.InfraRedVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");
            });

            modelBuilder.Entity<DeviceDataIris>(entity =>
            {
                entity.ToTable("DeviceData_Iris");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IrisDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.IrisDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.IrisDeviceId).HasComment("设备id");

                entity.Property(e => e.IrisDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("距离");

                entity.Property(e => e.IrisElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.IrisHumidity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("湿度");

                entity.Property(e => e.IrisIsWarn).HasComment("是否报警");

                entity.Property(e => e.IrisLight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("光强");

                entity.Property(e => e.IrisTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.IrisVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");

                entity.Property(e => e.IrisWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("重量");
            });

            modelBuilder.Entity<DeviceDataProtect>(entity =>
            {
                entity.ToTable("DeviceData_Protect");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProtectDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.ProtectDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.ProtectDeviceId).HasComment("临边防护设备id");

                entity.Property(e => e.ProtectElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.ProtectIsWarn).HasComment("是否报警");

                entity.Property(e => e.ProtectVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");
            });

            modelBuilder.Entity<DeviceDataSmoke>(entity =>
            {
                entity.ToTable("DeviceData_Smoke");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SmokeDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.SmokeDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.SmokeDeviceId).HasComment("设备id");

                entity.Property(e => e.SmokeElectricCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.SmokeHumidity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("湿度");

                entity.Property(e => e.SmokeIsWarn).HasComment("是否报警");

                entity.Property(e => e.SmokeOutVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("外部电压");

                entity.Property(e => e.SmokePowerSupply)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电源");

                entity.Property(e => e.SmokePowerValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电量百分比");

                entity.Property(e => e.SmokeTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.SmokeTimeStamp)
                    .HasMaxLength(50)
                    .HasComment("数据上报时间戳");

                entity.Property(e => e.SmokeVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");

                entity.Property(e => e.SmokeWarnConcentration)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("报警浓度");

                entity.Property(e => e.SmokeWarnType).HasComment("52 烟雾报警 54 自检报警 55 设备低电报警");
            });

            modelBuilder.Entity<DeviceDataStrongElectricity>(entity =>
            {
                entity.ToTable("DeviceData_StrongElectricity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StrongElectricityCurrent)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电流");

                entity.Property(e => e.StrongElectricityDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.StrongElectricityDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.StrongElectricityDeviceId).HasComment("强电检测设备id");

                entity.Property(e => e.StrongElectricityFrequency)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("交流频率");

                entity.Property(e => e.StrongElectricityIsWarn).HasComment("是否报警");

                entity.Property(e => e.StrongElectricityMode)
                    .HasMaxLength(50)
                    .HasComment("传输方式");

                entity.Property(e => e.StrongElectricityPower)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("功率");

                entity.Property(e => e.StrongElectricityVoltage)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电压");
            });

            modelBuilder.Entity<DeviceDataTowerCrane>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.HxzId, e.TowerCraneDate })
                    .HasName("PK__DeviceDa__0B5385C208948E58");

                entity.ToTable("DeviceData_TowerCrane");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HxzId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TowerCraneDate).HasColumnType("datetime");

                entity.Property(e => e.HxzFactory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TowerCraneBigArm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneCurrent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneDateLog).HasColumnType("datetime");

                entity.Property(e => e.TowerCraneDipAngleX).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneDipAngleY).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneMoment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCranePower).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneRange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneRotate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneTemp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneVoltage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TowerCraneWindPole).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WindSpeed).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<DeviceDataUnloading>(entity =>
            {
                entity.ToTable("DeviceData_Unloading");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UnloadingDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.UnloadingDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.UnloadingDeviceId).HasComment("设备id");

                entity.Property(e => e.UnloadingDipAngleX)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾角x");

                entity.Property(e => e.UnloadingDipAngleY)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("倾角y");

                entity.Property(e => e.UnloadingElectric)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("电量");

                entity.Property(e => e.UnloadingIsWarn).HasComment("是否报警");

                entity.Property(e => e.UnloadingPull)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("拉力");

                entity.Property(e => e.UnloadingTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");

                entity.Property(e => e.UnloadingWarningValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("预警值");

                entity.Property(e => e.UnloadingWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("重量");
            });

            modelBuilder.Entity<DeviceDataWater>(entity =>
            {
                entity.ToTable("DeviceData_Water");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WaterDate)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.WaterDateLog)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.WaterDeviceId).HasComment("设备id");

                entity.Property(e => e.WaterNumber)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("读数");

                entity.Property(e => e.WaterNumberUse)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("使用数");
            });

            modelBuilder.Entity<DeviceDataWeather>(entity =>
            {
                entity.ToTable("DeviceData_Weather");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WeatherCh2o)
                    .HasColumnName("Weather_CH2O")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("甲醛");

                entity.Property(e => e.WeatherCh4)
                    .HasColumnName("Weather_CH4")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("甲烷");

                entity.Property(e => e.WeatherCo)
                    .HasColumnName("Weather_CO")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("一氧化碳");

                entity.Property(e => e.WeatherCo2)
                    .HasColumnName("Weather_CO2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("二氧化碳");

                entity.Property(e => e.WeatherDate)
                    .HasColumnType("datetime")
                    .HasComment("上报时间");

                entity.Property(e => e.WeatherDateLog)
                    .HasColumnType("datetime")
                    .HasComment("采集时间");

                entity.Property(e => e.WeatherDeviceId).HasComment("设备id");

                entity.Property(e => e.WeatherH2s)
                    .HasColumnName("Weather_H2S")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("硫化氢");

                entity.Property(e => e.WeatherHumidity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("湿度");

                entity.Property(e => e.WeatherIsWarn).HasComment("是否报警");

                entity.Property(e => e.WeatherN2)
                    .HasColumnName("Weather_N2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("氮气");

                entity.Property(e => e.WeatherNh3)
                    .HasColumnName("Weather_NH3")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("氨");

                entity.Property(e => e.WeatherO2)
                    .HasColumnName("Weather_O2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("氧气");

                entity.Property(e => e.WeatherPressure)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("差压");

                entity.Property(e => e.WeatherSo2)
                    .HasColumnName("Weather_SO2")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("二氧化硫");

                entity.Property(e => e.WeatherTemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("温度");
            });

            modelBuilder.Entity<DevicePush>(entity =>
            {
                entity.ToTable("Device_Push");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasComment("设备id");

                entity.Property(e => e.DevicePushAlarmType).HasComment("报警类型");

                entity.Property(e => e.DevicePushDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.DevicePushMemberId)
                    .HasMaxLength(100)
                    .HasComment("推送人员");

                entity.Property(e => e.DevicePushStatus).HasComment("是否启用 1.启用 2,禁用");

                entity.Property(e => e.DevicePushType).HasComment("推送方式");
            });

            modelBuilder.Entity<DevicePushRecord>(entity =>
            {
                entity.ToTable("Device_PushRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasComment("设备id");

                entity.Property(e => e.PushRecordContent)
                    .HasMaxLength(50)
                    .HasComment("推送内容");

                entity.Property(e => e.PushRecordDate)
                    .HasColumnType("datetime")
                    .HasComment("推送时间");

                entity.Property(e => e.PushRecordMemberId).HasComment("推送人员");

                entity.Property(e => e.PushRecordStatus).HasComment("推送状态 1.推送成功 2.推送失败");
            });

            modelBuilder.Entity<DeviceRegister>(entity =>
            {
                entity.ToTable("Device_Register");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegisterAcceptanceDate)
                    .HasColumnType("datetime")
                    .HasComment("验收时间");

                entity.Property(e => e.RegisterApproachDate)
                    .HasColumnType("datetime")
                    .HasComment("进场时间");

                entity.Property(e => e.RegisterCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("登记时间");

                entity.Property(e => e.RegisterDeviceCode)
                    .HasMaxLength(50)
                    .HasComment("备案编号");

                entity.Property(e => e.RegisterDeviceId).HasComment("设备");

                entity.Property(e => e.RegisterDeviceName)
                    .HasMaxLength(50)
                    .HasComment("设备名称");

                entity.Property(e => e.RegisterDeviceNo)
                    .HasMaxLength(50)
                    .HasComment("设备编号");

                entity.Property(e => e.RegisterDeviceProduction)
                    .HasMaxLength(50)
                    .HasComment("生产厂家");

                entity.Property(e => e.RegisterDeviceSpec)
                    .HasMaxLength(50)
                    .HasComment("型号");

                entity.Property(e => e.RegisterMemberId).HasComment("登记人员");

                entity.Property(e => e.RegisterPhoto)
                    .HasMaxLength(250)
                    .HasComment("登记图片");

                entity.Property(e => e.RegisterProjectId).HasComment("项目");
            });

            modelBuilder.Entity<DeviceSwitchMode>(entity =>
            {
                entity.Property(e => e.TypeDescribe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceSwitchRecording>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceThresholdSetting>(entity =>
            {
                entity.ToTable("Device_ThresholdSetting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ThresholdDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.ThresholdDeviceType).HasComment("设备类型");

                entity.Property(e => e.ThresholdExceedValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("超标值");

                entity.Property(e => e.ThresholdName)
                    .HasMaxLength(50)
                    .HasComment("因子名称");

                entity.Property(e => e.ThresholdStatus).HasComment("状态 是否启用 1.启用 2,禁用");

                entity.Property(e => e.ThresholdWarningValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("警告值");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceType1)
                    .HasColumnName("DeviceType")
                    .HasComment("1.设备类型 2.设备环境类型");

                entity.Property(e => e.DeviceTypeAppUrl)
                    .HasMaxLength(50)
                    .HasComment("app 模块名称");

                entity.Property(e => e.DeviceTypeCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceTypeIntro)
                    .HasMaxLength(50)
                    .HasComment("类型简介");

                entity.Property(e => e.DeviceTypeName)
                    .HasMaxLength(50)
                    .HasComment("设备类型名称");
            });

            modelBuilder.Entity<DustEnvironmentEquipment>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Yxsk });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Yxsk)
                    .HasColumnName("YXSK")
                    .HasColumnType("datetime");

                entity.Property(e => e.HjBzjd)
                    .HasColumnName("HJ_BZJD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjBzsd)
                    .HasColumnName("HJ_BZSD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjBzwd)
                    .HasColumnName("HJ_BZWD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjBzwdX)
                    .HasColumnName("HJ_BZWD_X")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjDguid)
                    .HasColumnName("HJ_DGUID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HjDy)
                    .HasColumnName("HJ_DY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjFs)
                    .HasColumnName("HJ_FS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjFx)
                    .HasColumnName("HJ_FX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjPguid).HasColumnName("HJ_PGUID");

                entity.Property(e => e.HjPm10)
                    .HasColumnName("HJ_PM10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjPm25)
                    .HasColumnName("HJ_PM25")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjQy)
                    .HasColumnName("HJ_QY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjSd)
                    .HasColumnName("HJ_SD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjWd)
                    .HasColumnName("HJ_WD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HjZs)
                    .HasColumnName("HJ_ZS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jdbh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubId)
                    .HasColumnName("sub_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tsp)
                    .HasColumnName("tsp")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DustEnvironmentalData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DevGuid)
                    .HasColumnName("DEV_GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstallDate)
                    .HasColumnName("INSTALL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstallLocation)
                    .HasColumnName("INSTALL_LOCATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jdbh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MdModel)
                    .HasColumnName("MD_MODEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MdName)
                    .HasColumnName("MD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MdType)
                    .HasColumnName("MD_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeOption)
                    .HasColumnName("ME_OPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .HasColumnName("PROJECT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RunningState)
                    .HasColumnName("RUNNING_STATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubId)
                    .HasColumnName("_sub_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gplot>(entity =>
            {
                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.ValuesName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaborRelations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSigning).HasColumnType("datetime");

                entity.Property(e => e.LimitedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceContract)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<LeaveTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).IsUnicode(false);
            });

            modelBuilder.Entity<LifterRealTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HxzFactory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HxzId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityXalarm).HasColumnName("ObliguityXAlarm");

                entity.Property(e => e.ObliguityXerror).HasColumnName("ObliguityXError");

                entity.Property(e => e.ObliguityXpreAlarm).HasColumnName("ObliguityXPreAlarm");

                entity.Property(e => e.ObliguityY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityYalarm).HasColumnName("ObliguityYAlarm");

                entity.Property(e => e.ObliguityYpreAlarm).HasColumnName("ObliguityYPreAlarm");

                entity.Property(e => e.PeopleCnt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtime)
                    .HasColumnName("RTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Speed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WindLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WindSpeed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberAddress)
                    .HasMaxLength(100)
                    .HasComment("详细地址");

                entity.Property(e => e.MemberAge).HasComment("年龄");

                entity.Property(e => e.MemberArea1).HasMaxLength(50);

                entity.Property(e => e.MemberArea2).HasMaxLength(50);

                entity.Property(e => e.MemberArea3).HasMaxLength(50);

                entity.Property(e => e.MemberAuditDate)
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.MemberAuditStatus).HasComment("审核状态 1.审核中 2.审核通过 3.审核未通过");

                entity.Property(e => e.MemberCardBook)
                    .HasMaxLength(500)
                    .HasComment("资质证书");

                entity.Property(e => e.MemberCompanyId).HasComment("单位");

                entity.Property(e => e.MemberContract)
                    .HasMaxLength(200)
                    .HasComment("合同");

                entity.Property(e => e.MemberDateBirthday)
                    .HasColumnType("datetime")
                    .HasComment("生日");

                entity.Property(e => e.MemberDateReg)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.MemberDateUpdate)
                    .HasColumnType("datetime")
                    .HasComment("信息修改时间");

                entity.Property(e => e.MemberDeptId).HasComment("部门");

                entity.Property(e => e.MemberEmail)
                    .HasMaxLength(50)
                    .HasComment("邮箱");

                entity.Property(e => e.MemberIdCard)
                    .HasMaxLength(50)
                    .HasComment("身份证");

                entity.Property(e => e.MemberIdCardPhoto)
                    .HasMaxLength(500)
                    .HasComment("身份证照片");

                entity.Property(e => e.MemberIntro)
                    .HasMaxLength(100)
                    .HasComment("人员介绍");

                entity.Property(e => e.MemberLocation)
                    .HasMaxLength(100)
                    .HasComment("经纬度");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .HasComment("人员名称");

                entity.Property(e => e.MemberPhoto)
                    .HasMaxLength(100)
                    .HasComment("人员头像");

                entity.Property(e => e.MemberPhotoHead).HasMaxLength(500);

                entity.Property(e => e.MemberPid).HasComment("是否标识");

                entity.Property(e => e.MemberProjectId).HasComment("项目id");

                entity.Property(e => e.MemberPwd)
                    .HasMaxLength(50)
                    .HasComment("密码");

                entity.Property(e => e.MemberRoleId).HasComment("角色id");

                entity.Property(e => e.MemberSendId)
                    .HasMaxLength(50)
                    .HasComment("极光id");

                entity.Property(e => e.MemberSex).HasComment("0:女 1:男");

                entity.Property(e => e.MemberStatus)
                    .HasDefaultValueSql("((0))")
                    .HasComment("状态 1.启用 2.禁用");

                entity.Property(e => e.MemberTel)
                    .HasMaxLength(50)
                    .HasComment("联系电话");

                entity.Property(e => e.MemberType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("人员类型(1.管理人员 2.劳务人员 3.企业人员)");

                entity.Property(e => e.MemberWorkTypeId).HasComment("工种类型");
            });

            modelBuilder.Entity<MemberLocation>(entity =>
            {
                entity.ToTable("Member_Location");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.LocationDeviceId).HasComment("设备id");

                entity.Property(e => e.LocationLatitude)
                    .HasMaxLength(50)
                    .HasComment("纬度");

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(50)
                    .HasComment("经度");

                entity.Property(e => e.LocationStatus).HasComment("状态 1.在线 2.离线");
            });

            modelBuilder.Entity<MemberLogin>(entity =>
            {
                entity.ToTable("Member_Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginLocation).HasMaxLength(50);

                entity.Property(e => e.LoginMacId).HasMaxLength(50);

                entity.Property(e => e.LoginMacType).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberPayMoney>(entity =>
            {
                entity.ToTable("Member_PayMoney");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PayMoneyDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.PayMoneyFile)
                    .HasMaxLength(500)
                    .HasComment("文件");

                entity.Property(e => e.PayMoneyMemberId).HasComment("负责人员");

                entity.Property(e => e.PayMoneyNumber).HasComment("发放人数");

                entity.Property(e => e.PayMoneyPhoto)
                    .HasMaxLength(500)
                    .HasComment("图片");

                entity.Property(e => e.PayMoneyStatus).HasComment("发放状态 1.未发放 2.已发放");

                entity.Property(e => e.PayMoneyTitle)
                    .HasMaxLength(200)
                    .HasComment("标题");
            });

            modelBuilder.Entity<MemberProject>(entity =>
            {
                entity.ToTable("Member_Project");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberDate)
                    .HasColumnType("datetime")
                    .HasComment("参与时间");

                entity.Property(e => e.MemberId).HasComment("人员id");

                entity.Property(e => e.MemberProjectId).HasComment("项目id");

                entity.Property(e => e.MemberStatus).HasComment("是否开发该项目 1.是 2.否");
            });

            modelBuilder.Entity<MemberTrain>(entity =>
            {
                entity.ToTable("Member_Train");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TrainDate)
                    .HasColumnType("datetime")
                    .HasComment("培训时间");

                entity.Property(e => e.TrainMemberId).HasComment("培训人员");

                entity.Property(e => e.TrainScore)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("培训分数");

                entity.Property(e => e.TrainStatus).HasComment("培训状态 1.培训中 2.培训完成");

                entity.Property(e => e.TrainType).HasComment("培训类型");
            });

            modelBuilder.Entity<MemberWorkLog>(entity =>
            {
                entity.ToTable("Member_WorkLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WorkLogEndDate)
                    .HasColumnType("datetime")
                    .HasComment("工作结束时间");

                entity.Property(e => e.WorkLogHour)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("时长");

                entity.Property(e => e.WorkLogMembeId).HasComment("人员id");

                entity.Property(e => e.WorkLogProjectId).HasComment("项目id");

                entity.Property(e => e.WorkLogStartDate)
                    .HasColumnType("datetime")
                    .HasComment("工作开始时间");
            });

            modelBuilder.Entity<MemberWorkType>(entity =>
            {
                entity.ToTable("Member_WorkType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WorkTypeIntro)
                    .HasMaxLength(100)
                    .HasComment("工种简介");

                entity.Property(e => e.WorkTypeName)
                    .HasMaxLength(50)
                    .HasComment("工种类型名称");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewsAddManName).HasMaxLength(100);

                entity.Property(e => e.NewsDate).HasColumnType("datetime");

                entity.Property(e => e.NewsIntro).HasMaxLength(500);

                entity.Property(e => e.NewsKeyword).HasMaxLength(250);

                entity.Property(e => e.NewsPhoto).HasMaxLength(500);

                entity.Property(e => e.NewsPhotoList).HasMaxLength(1000);

                entity.Property(e => e.NewsPower).HasMaxLength(50);

                entity.Property(e => e.NewsTitle).HasMaxLength(500);

                entity.Property(e => e.NewsTypeName).HasMaxLength(100);

                entity.Property(e => e.NewsUrl).HasMaxLength(250);

                entity.Property(e => e.NewsUrlWx)
                    .HasColumnName("NewsUrl_wx")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewsTypeIntro).HasMaxLength(500);

                entity.Property(e => e.NewsTypeKeyword).HasMaxLength(250);

                entity.Property(e => e.NewsTypeName).HasMaxLength(250);

                entity.Property(e => e.NewsTypePath).HasMaxLength(50);

                entity.Property(e => e.NewsTypePhoto).HasMaxLength(50);

                entity.Property(e => e.NewsTypeViewIp).HasColumnName("NewsTypeViewIP");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperatorCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.OperatorCredentialNo)
                    .HasMaxLength(50)
                    .HasComment("证件号");

                entity.Property(e => e.OperatorCredentialPhoto)
                    .HasMaxLength(50)
                    .HasComment("证件图片");

                entity.Property(e => e.OperatorDay).HasComment("有效期");

                entity.Property(e => e.OperatorIdCard)
                    .HasMaxLength(50)
                    .HasComment("身份证号");

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .HasComment("操作人员姓名");

                entity.Property(e => e.OperatorReviewDate)
                    .HasColumnType("datetime")
                    .HasComment("复核时间");

                entity.Property(e => e.OperatorTel)
                    .HasMaxLength(50)
                    .HasComment("电话");

                entity.Property(e => e.OperatorType).HasComment("类型  1、塔吊司机 2、升降机司机");
            });

            modelBuilder.Entity<ParametersElectricBox>(entity =>
            {
                entity.Property(e => e.AroundTempLimit)
                    .HasColumnName("AROUND_TEMP_LIMIT")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("COMPANY_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DevGuid)
                    .HasColumnName("DEV_GUID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DevType)
                    .HasColumnName("DEV_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DevTypeName)
                    .IsRequired()
                    .HasColumnName("DEV_TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtuId).HasColumnName("DTU_ID");

                entity.Property(e => e.ElecLimit).HasColumnName("ELEC_LIMIT");

                entity.Property(e => e.InstallAddress)
                    .IsRequired()
                    .HasColumnName("INSTALL_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstallAddrtype)
                    .IsRequired()
                    .HasColumnName("INSTALL_ADDRTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jdbh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longtitude)
                    .HasColumnName("LONGTITUDE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("PROJECT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubId)
                    .HasColumnName("sub_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempLimit)
                    .HasColumnName("TEMP_LIMIT")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<ParametersState>(entity =>
            {
                entity.Property(e => e.DevGuid)
                    .IsRequired()
                    .HasColumnName("DEV_GUID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DevOperateTime)
                    .HasColumnName("DEV_OPERATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DevStatus).HasColumnName("DEV_STATUS");

                entity.Property(e => e.ElecLimit)
                    .HasColumnName("ELEC_LIMIT")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Jdbh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("PROJECT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubId)
                    .HasColumnName("sub_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TempHj)
                    .HasColumnName("TEMP_HJ")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TempXlA)
                    .HasColumnName("TEMP_XL_a")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TempXlB)
                    .HasColumnName("TEMP_XL_b")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TempXlC)
                    .HasColumnName("TEMP_XL_c")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WarnId)
                    .IsRequired()
                    .HasColumnName("WARN_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarnType).HasColumnName("WARN_TYPE");
            });

            modelBuilder.Entity<Payoff>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedTime).HasColumnType("datetime");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<PersonalInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApproachTime).HasColumnType("datetime");

                entity.Property(e => e.BedNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brithday).HasColumnType("datetime");

                entity.Property(e => e.CertificateAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DocumentPhoto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentVerso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GraduateSchool)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdcardNo)
                    .IsRequired()
                    .HasColumnName("IDCardNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingTime).HasColumnType("datetime");

                entity.Property(e => e.MedicalReport)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Portrait).IsUnicode(false);

                entity.Property(e => e.PositionLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RadioFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TertiaryDducation)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonnelCategory>(entity =>
            {
                entity.HasIndex(e => e.TypeName)
                    .HasName("addTypeName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonnelType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonnelType1)
                    .HasColumnName("PersonnelType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaleSpecies)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameMaleSpecies)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectAddress)
                    .HasMaxLength(50)
                    .HasComment("详细地址");

                entity.Property(e => e.ProjectAppList).HasComment("本项目购买的应用");

                entity.Property(e => e.ProjectAqi)
                    .HasColumnName("ProjectAQI")
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("空气指数");

                entity.Property(e => e.ProjectArea).HasComment("项目面积");

                entity.Property(e => e.ProjectArea1).HasMaxLength(50);

                entity.Property(e => e.ProjectArea2).HasMaxLength(50);

                entity.Property(e => e.ProjectArea3).HasMaxLength(50);

                entity.Property(e => e.ProjectBuildName)
                    .HasMaxLength(50)
                    .HasComment("建设单位");

                entity.Property(e => e.ProjectCompanyId).HasComment("所属公司");

                entity.Property(e => e.ProjectConstructionName)
                    .HasMaxLength(50)
                    .HasComment("施工");

                entity.Property(e => e.ProjectCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.ProjectDesignName)
                    .HasMaxLength(50)
                    .HasComment("设计单位");

                entity.Property(e => e.ProjectEffectPhoto)
                    .HasMaxLength(100)
                    .HasComment("效果图");

                entity.Property(e => e.ProjectEndDate)
                    .HasColumnType("datetime")
                    .HasComment("项目完工时间");

                entity.Property(e => e.ProjectFunction)
                    .HasMaxLength(100)
                    .HasComment("项目功能");

                entity.Property(e => e.ProjectIntro)
                    .HasMaxLength(100)
                    .HasComment("项目简介");

                entity.Property(e => e.ProjectIsKeyPoint).HasComment("是否重点项目 1.否 2.是");

                entity.Property(e => e.ProjectLatitude)
                    .HasMaxLength(50)
                    .HasComment("纬度");

                entity.Property(e => e.ProjectLayerNumber)
                    .HasMaxLength(50)
                    .HasComment("项目层数");

                entity.Property(e => e.ProjectLength)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("长度");

                entity.Property(e => e.ProjectLinkMan)
                    .HasMaxLength(50)
                    .HasComment("负责人");

                entity.Property(e => e.ProjectLinkTel)
                    .HasMaxLength(50)
                    .HasComment("联系电话");

                entity.Property(e => e.ProjectLongitude)
                    .HasMaxLength(50)
                    .HasComment("经度");

                entity.Property(e => e.ProjectMemberId).HasComment("创建人");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .HasComment("项目名称");

                entity.Property(e => e.ProjectNo)
                    .HasMaxLength(50)
                    .HasComment("项目编号");

                entity.Property(e => e.ProjectPhoto).HasComment("项目图片");

                entity.Property(e => e.ProjectPlanarPhoto)
                    .HasMaxLength(100)
                    .HasComment("平面图");

                entity.Property(e => e.ProjectPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("项目造价");

                entity.Property(e => e.ProjectStartDate)
                    .HasColumnType("datetime")
                    .HasComment("项目开工时间");

                entity.Property(e => e.ProjectStatus).HasComment("项目状态 1.在建 2.已竣工");

                entity.Property(e => e.ProjectSupervisorName)
                    .HasMaxLength(50)
                    .HasComment("监理单位");

                entity.Property(e => e.ProjectSurveyName)
                    .HasMaxLength(50)
                    .HasComment("勘察单位");

                entity.Property(e => e.ProjectType).HasComment("项目类型");

                entity.Property(e => e.ProjectUrl3d).HasMaxLength(500);

                entity.Property(e => e.ProjectUrlBim).HasMaxLength(500);

                entity.Property(e => e.ProjectUrlCheck).HasMaxLength(500);

                entity.Property(e => e.ProjectWidth)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("宽度");
            });

            modelBuilder.Entity<Project1record>(entity =>
            {
                entity.ToTable("Project_1Record");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("datetime")
                    .HasComment("记录时间");

                entity.Property(e => e.RecordDefaultIsShow).HasComment("是否默认显示 1.默认 2.不默认");

                entity.Property(e => e.RecordDescribe).HasComment("记录描述");

                entity.Property(e => e.RecordMemberId).HasComment("记录人员");

                entity.Property(e => e.RecordPhoto).HasComment("记录图片");

                entity.Property(e => e.RecordProjectId).HasComment("项目id");

                entity.Property(e => e.RecordTitle)
                    .HasMaxLength(200)
                    .HasComment("记录标题");
            });

            modelBuilder.Entity<Project2company>(entity =>
            {
                entity.ToTable("Project_2Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectCompanyDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.ProjectCompanyId).HasComment("施工单位id");

                entity.Property(e => e.ProjectCompanyType).HasComment("项目类型 1.施工单位 2.劳务单位,3关联单位(检查单位)");

                entity.Property(e => e.ProjectDeptId).HasComment("当id为0时 --ProjectDeptName为部门  或者为分包单位");

                entity.Property(e => e.ProjectDeptJob)
                    .HasMaxLength(500)
                    .HasComment("部门/岗位");

                entity.Property(e => e.ProjectDeptName)
                    .HasMaxLength(500)
                    .HasComment("部门/岗位");

                entity.Property(e => e.ProjectId).HasComment("项目id");
            });

            modelBuilder.Entity<Project3companyDept>(entity =>
            {
                entity.ToTable("Project_3Company_Dept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectDept1Name).HasMaxLength(500);

                entity.Property(e => e.ProjectDept2Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Project4member>(entity =>
            {
                entity.ToTable("Project_4Member");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("申请时间");

                entity.Property(e => e.MemberIsAccount).HasComment("1.已绑定 2.未绑定 3 我创建的");

                entity.Property(e => e.MemberIsShow).HasComment("是否默认显示 0.否 1.是");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberSysAuditDate)
                    .HasColumnType("datetime")
                    .HasComment("审核时间");

                entity.Property(e => e.MemberSysAuditStatus).HasComment("1未审核 2审核通过 3 审核未通过");

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasComment("1管理人员，2劳务人员");

                entity.Property(e => e.ProjectDept1Name).HasMaxLength(50);

                entity.Property(e => e.ProjectDept2Name)
                    .HasMaxLength(50)
                    .HasComment("部门、劳务单位");

                entity.Property(e => e.ProjectDept3Name)
                    .HasMaxLength(50)
                    .HasComment("岗位、班组");
            });

            modelBuilder.Entity<Project5file>(entity =>
            {
                entity.ToTable("Project_5File");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fieldate).HasColumnType("datetime");

                entity.Property(e => e.FileCompanyId).HasComment("项目单位id");

                entity.Property(e => e.FileDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.FileDir1)
                    .HasMaxLength(200)
                    .HasComment("文档目录一级");

                entity.Property(e => e.FileDir2).HasMaxLength(200);

                entity.Property(e => e.FileFormat)
                    .HasMaxLength(50)
                    .HasComment("资料格式");

                entity.Property(e => e.FileLevel).HasComment("文件等级 1.目录 2.文件");

                entity.Property(e => e.FileMemberId).HasComment("用户id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasComment("资料名称");

                entity.Property(e => e.FilePid).HasComment("一级目录id");

                entity.Property(e => e.FilePid1).HasComment("二级目录id");

                entity.Property(e => e.FilePower).HasMaxLength(500);

                entity.Property(e => e.FileProjectCompanyId).HasComment("单位部门id");

                entity.Property(e => e.FileProjectCompanyId1).HasComment("文档所属单位id");

                entity.Property(e => e.FileProjectCompanyId2).HasComment("文档所属部门id");

                entity.Property(e => e.FileProjectCompanyName1)
                    .HasMaxLength(200)
                    .HasComment("文档所属单位名称");

                entity.Property(e => e.FileProjectCompanyName2)
                    .HasMaxLength(200)
                    .HasComment("文档所属部门名称");

                entity.Property(e => e.FileProjectId).HasComment("项目id");

                entity.Property(e => e.FilePtoto)
                    .HasMaxLength(200)
                    .HasComment("资料图片");

                entity.Property(e => e.FileQrcodeImg)
                    .HasMaxLength(500)
                    .HasComment("二维码图片");

                entity.Property(e => e.FileSize)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("资料大小");

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(500)
                    .HasComment("路径");
            });

            modelBuilder.Entity<Project6milepost>(entity =>
            {
                entity.ToTable("Project_6Milepost");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MilepostDescribe).HasComment("描述");

                entity.Property(e => e.MilepostEndDate)
                    .HasColumnType("datetime")
                    .HasComment("竣工时间");

                entity.Property(e => e.MilepostName)
                    .HasMaxLength(200)
                    .HasComment("里程碑名称");

                entity.Property(e => e.MilepostProjectId).HasComment("项目id");

                entity.Property(e => e.MilepostStartDate)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.MilepostStatus).HasComment("1未完成，2已完成  3异常");
            });

            modelBuilder.Entity<Project7video>(entity =>
            {
                entity.ToTable("Project_7Video");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegionForUse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoCode)
                    .HasMaxLength(100)
                    .HasComment("编号");

                entity.Property(e => e.VideoInstallAddress)
                    .HasMaxLength(500)
                    .HasComment("安装地址");

                entity.Property(e => e.VideoInstallDate)
                    .HasColumnType("datetime")
                    .HasComment("安装时间");

                entity.Property(e => e.VideoName)
                    .HasMaxLength(50)
                    .HasComment("名称");

                entity.Property(e => e.VideoProjectId).HasComment("项目");

                entity.Property(e => e.VideoStatus).HasComment("状态 1.在线 2.离线");

                entity.Property(e => e.VideoType).HasMaxLength(50);

                entity.Property(e => e.VideoUrl)
                    .HasMaxLength(500)
                    .HasComment("链接地址");
            });

            modelBuilder.Entity<ProjectAcceptance>(entity =>
            {
                entity.ToTable("Project_Acceptance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptanceCompanyName).HasMaxLength(50);

                entity.Property(e => e.AcceptanceConfirmDate)
                    .HasColumnType("datetime")
                    .HasComment("验收确认时间");

                entity.Property(e => e.AcceptanceCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.AcceptanceDate)
                    .HasColumnType("datetime")
                    .HasComment("验收时间");

                entity.Property(e => e.AcceptanceDeptName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AcceptanceDesc)
                    .HasMaxLength(500)
                    .HasComment("验收描述");

                entity.Property(e => e.AcceptanceFrontDesc)
                    .HasMaxLength(500)
                    .HasComment("验收前描述");

                entity.Property(e => e.AcceptanceFrontPhoto)
                    .HasMaxLength(500)
                    .HasComment("验收前图片");

                entity.Property(e => e.AcceptanceFrontVideo)
                    .HasMaxLength(500)
                    .HasComment("验收前视频");

                entity.Property(e => e.AcceptanceMemberId).HasComment("添加人员");

                entity.Property(e => e.AcceptanceMemberName).HasMaxLength(50);

                entity.Property(e => e.AcceptancePhoto)
                    .HasMaxLength(500)
                    .HasComment("验收图片");

                entity.Property(e => e.AcceptancePlanDate)
                    .HasColumnType("datetime")
                    .HasComment("验收计划时间");

                entity.Property(e => e.AcceptanceProjectId).HasComment("项目id");

                entity.Property(e => e.AcceptanceStatus).HasComment("验收状态 1.待验收 2.已验收");

                entity.Property(e => e.AcceptanceTitle)
                    .HasMaxLength(200)
                    .HasComment("验收计划标题");

                entity.Property(e => e.AcceptanceVideo)
                    .HasMaxLength(500)
                    .HasComment("验收视频");
            });

            modelBuilder.Entity<ProjectCheckData>(entity =>
            {
                entity.ToTable("Project_CheckData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasComment("巡查时间");

                entity.Property(e => e.CheckDescribe).HasComment("描述");

                entity.Property(e => e.CheckIsCode).HasComment("是否扫码");

                entity.Property(e => e.CheckMemberId).HasComment("巡查人员id");

                entity.Property(e => e.CheckPhoto)
                    .HasMaxLength(200)
                    .HasComment("巡查图片");

                entity.Property(e => e.CheckPointId).HasComment("巡查点位");

                entity.Property(e => e.CheckStatus).HasComment("状态 1.巡查中 2,。巡查完成");
            });

            modelBuilder.Entity<ProjectCheckNote>(entity =>
            {
                entity.ToTable("Project_Check_Note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckApprovalMemberId).HasComment("审批人员");

                entity.Property(e => e.CheckCompanyId).HasComment("单位");

                entity.Property(e => e.CheckCompanyName).HasMaxLength(50);

                entity.Property(e => e.CheckCopyMemberId).HasComment("抄送人员");

                entity.Property(e => e.CheckCreateMemberId).HasComment("发起人员");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.CheckDeptName).HasMaxLength(50);

                entity.Property(e => e.CheckDesc)
                    .HasMaxLength(500)
                    .HasComment("描述");

                entity.Property(e => e.CheckFile)
                    .HasMaxLength(200)
                    .HasComment("文件");

                entity.Property(e => e.CheckMemberId).HasComment("检查人员");

                entity.Property(e => e.CheckParts)
                    .HasMaxLength(50)
                    .HasComment("检查部位");

                entity.Property(e => e.CheckPhoto)
                    .HasMaxLength(200)
                    .HasComment("图片");

                entity.Property(e => e.CheckProjectId).HasComment("项目");

                entity.Property(e => e.CheckScore).HasComment("检查分数");

                entity.Property(e => e.CheckStatus).HasComment("检查状态 1.待检查 2.已检查");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasComment("检查时间");

                entity.Property(e => e.CheckTitle)
                    .HasMaxLength(200)
                    .HasComment("标题");

                entity.Property(e => e.CheckType).HasComment("检查类型 1.通知 2.公式");
            });

            modelBuilder.Entity<ProjectCheckPoint>(entity =>
            {
                entity.ToTable("Project_Check_Point");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PointCode).HasMaxLength(50);

                entity.Property(e => e.PointDate)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.PointDistance).HasComment("距离");

                entity.Property(e => e.PointImg)
                    .HasMaxLength(200)
                    .HasComment("图片");

                entity.Property(e => e.PointLatitude)
                    .HasMaxLength(50)
                    .HasComment("纬度");

                entity.Property(e => e.PointLongitude)
                    .HasMaxLength(50)
                    .HasComment("经度");

                entity.Property(e => e.PointMatter)
                    .HasMaxLength(200)
                    .HasComment("点位事项");

                entity.Property(e => e.PointMemberId).HasComment("人员id");

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .HasComment("点位名称");

                entity.Property(e => e.PointProjectId).HasComment("项目id");

                entity.Property(e => e.PointTitle)
                    .HasMaxLength(200)
                    .HasComment("点位标题");
            });

            modelBuilder.Entity<ProjectCheckRoute>(entity =>
            {
                entity.ToTable("Project_Check_Route");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RouteDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.RouteDescribe).HasComment("路线描述");

                entity.Property(e => e.RouteMemberId).HasComment("人员id");

                entity.Property(e => e.RouteName)
                    .HasMaxLength(50)
                    .HasComment("路线名称");

                entity.Property(e => e.RoutePointCheckIdArr)
                    .HasMaxLength(500)
                    .HasComment("路线点位 多个");

                entity.Property(e => e.RouteProjectId).HasComment("项目id");
            });

            modelBuilder.Entity<ProjectHardware>(entity =>
            {
                entity.ToTable("Project_Hardware");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BianLinBim)
                    .HasColumnName("BianLinBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.CarBim)
                    .HasColumnName("CarBIM")
                    .HasMaxLength(500)
                    .HasComment("车辆");

                entity.Property(e => e.DustBim)
                    .HasColumnName("DustBIM")
                    .HasMaxLength(500)
                    .HasComment("扬尘");

                entity.Property(e => e.ElectricBim)
                    .HasColumnName("ElectricBIM")
                    .HasMaxLength(500)
                    .HasComment("电");

                entity.Property(e => e.ElevatorBim)
                    .HasColumnName("ElevatorBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.EnergyBim)
                    .HasColumnName("EnergyBIM")
                    .HasMaxLength(500)
                    .HasComment("能源");

                entity.Property(e => e.GasMonitoringBim)
                    .HasColumnName("GasMonitoringBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.HighFormworkBim)
                    .HasColumnName("HighFormworkBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.HookvisualizationBim)
                    .HasColumnName("HookvisualizationBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.LmperialMaterialBim)
                    .HasColumnName("LmperialMaterialBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.LnfraredBim)
                    .HasColumnName("LnfraredBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.LntelligentPumpBim)
                    .HasColumnName("LntelligentPumpBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.LrismachineBim)
                    .HasColumnName("LrismachineBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.MemberBim)
                    .HasColumnName("MemberBIM")
                    .HasMaxLength(500)
                    .HasComment("人员");

                entity.Property(e => e.SmokeSensationBim)
                    .HasColumnName("SmokeSensationBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.StrongElectricityBim)
                    .HasColumnName("StrongElectricityBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.TowercraneBim)
                    .HasColumnName("TowercraneBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.VehicleBim)
                    .HasColumnName("VehicleBIM")
                    .HasMaxLength(500);

                entity.Property(e => e.WaterBim)
                    .HasColumnName("WaterBIM")
                    .HasMaxLength(500)
                    .HasComment("水");

                entity.Property(e => e.ZsBim)
                    .HasColumnName("ZsBIM")
                    .HasMaxLength(500)
                    .HasComment("噪声");
            });

            modelBuilder.Entity<ProjectShot>(entity =>
            {
                entity.ToTable("Project_Shot");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShotDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.ShotDateAudit).HasColumnType("datetime");

                entity.Property(e => e.ShotDescribe).HasComment("描述");

                entity.Property(e => e.ShotMemberId).HasComment("人员id");

                entity.Property(e => e.ShotMemberIdAuditSelected)
                    .HasColumnName("ShotMemberId_Audit_Selected")
                    .HasComment("当前审核人");

                entity.Property(e => e.ShotMemberIdsAudit)
                    .HasColumnName("ShotMemberIds_Audit")
                    .HasMaxLength(500)
                    .HasComment("人员id");

                entity.Property(e => e.ShotMemberIdsCopy)
                    .HasColumnName("ShotMemberIds_Copy")
                    .HasMaxLength(500);

                entity.Property(e => e.ShotMemberName).HasMaxLength(50);

                entity.Property(e => e.ShotMemberTel).HasMaxLength(50);

                entity.Property(e => e.ShotPhoto).HasComment("图片");

                entity.Property(e => e.ShotProjectId).HasComment("项目id");

                entity.Property(e => e.ShotStatus)
                    .HasMaxLength(50)
                    .HasComment("1待审核 2已审核");

                entity.Property(e => e.ShotTitle)
                    .HasMaxLength(50)
                    .HasComment("标题");
            });

            modelBuilder.Entity<ProjectShotLog>(entity =>
            {
                entity.ToTable("Project_Shot_Log");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("")
                    .ValueGeneratedNever();

                entity.Property(e => e.LogAuditMemberId).HasComment("操作人ID");

                entity.Property(e => e.LogAuditMemberName)
                    .HasMaxLength(50)
                    .HasComment("巡检操作人名称");

                entity.Property(e => e.LogAuditStatusId)
                    .HasColumnName("LogAuditStatusID")
                    .HasComment("设备巡检状态");

                entity.Property(e => e.LogAuditStatusName)
                    .HasMaxLength(50)
                    .HasComment("设备巡检状态");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasComment("巡检日志时间");

                entity.Property(e => e.LogIntro).HasComment("描述");

                entity.Property(e => e.LogShotId).HasComment("设备ID");

                entity.Property(e => e.LogType).HasComment("1进度更新，2备忘");
            });

            modelBuilder.Entity<ProjectShotSafe>(entity =>
            {
                entity.ToTable("Project_Shot_Safe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShotAddress).HasMaxLength(50);

                entity.Property(e => e.ShotCheckIntro).HasMaxLength(500);

                entity.Property(e => e.ShotCheckPhoto).HasMaxLength(500);

                entity.Property(e => e.ShotCheckPosition)
                    .HasMaxLength(100)
                    .HasComment("检查部位");

                entity.Property(e => e.ShotCheckType).HasComment("检查类型 1,安全检查 2,质量检查");

                entity.Property(e => e.ShotDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.ShotDateAudit).HasColumnType("datetime");

                entity.Property(e => e.ShotDateCheck).HasColumnType("datetime");

                entity.Property(e => e.ShotDateSerice).HasColumnType("datetime");

                entity.Property(e => e.ShotIntro)
                    .HasMaxLength(500)
                    .HasComment("描述");

                entity.Property(e => e.ShotLocation).HasMaxLength(100);

                entity.Property(e => e.ShotLocationBaidu).HasMaxLength(100);

                entity.Property(e => e.ShotMemberId).HasComment("人员id");

                entity.Property(e => e.ShotMemberIdAuditSelected)
                    .HasColumnName("ShotMemberId_Audit_Selected")
                    .HasComment("当前审核人");

                entity.Property(e => e.ShotMemberIdCheck)
                    .HasColumnName("ShotMemberId_Check")
                    .HasComment("人员id");

                entity.Property(e => e.ShotMemberIdService)
                    .HasColumnName("ShotMemberId_Service")
                    .HasComment("人员id");

                entity.Property(e => e.ShotMemberIdsAudit)
                    .HasColumnName("ShotMemberIds_Audit")
                    .HasMaxLength(500)
                    .HasComment("人员id");

                entity.Property(e => e.ShotMemberIdsCopy)
                    .HasColumnName("ShotMemberIds_Copy")
                    .HasMaxLength(500);

                entity.Property(e => e.ShotMemberName).HasMaxLength(50);

                entity.Property(e => e.ShotMemberNameCheck)
                    .HasColumnName("ShotMemberName_Check")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberNameService)
                    .HasColumnName("ShotMemberName_Service")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberTel).HasMaxLength(50);

                entity.Property(e => e.ShotMemberTelCheck)
                    .HasColumnName("ShotMemberTel_Check")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberTelService)
                    .HasColumnName("ShotMemberTel_Service")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotPhoto)
                    .HasMaxLength(500)
                    .HasComment("图片");

                entity.Property(e => e.ShotProjectId).HasComment("项目id");

                entity.Property(e => e.ShotServiceIntro).HasMaxLength(500);

                entity.Property(e => e.ShotServicePhoto).HasMaxLength(500);

                entity.Property(e => e.ShotStatus).HasComment("1待检查 2待整顿 3待验收 4已验收");

                entity.Property(e => e.ShotStatusResult).HasComment("1合格 2待整改 3已整改");

                entity.Property(e => e.ShotTitle)
                    .HasMaxLength(200)
                    .HasComment("标题");
            });

            modelBuilder.Entity<ProjectShotSafeMember>(entity =>
            {
                entity.ToTable("Project_Shot_Safe_Member");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShotDate)
                    .HasColumnType("datetime")
                    .HasComment("时间");

                entity.Property(e => e.ShotId).HasComment("安全检查id");

                entity.Property(e => e.ShotMemberId).HasComment("人员id");
            });

            modelBuilder.Entity<ProjectShotSaftLog>(entity =>
            {
                entity.ToTable("Project_Shot_Saft_Log");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("");

                entity.Property(e => e.LogAuditMemberId).HasComment("操作人ID");

                entity.Property(e => e.LogAuditMemberName)
                    .HasMaxLength(50)
                    .HasComment("巡检操作人名称");

                entity.Property(e => e.LogAuditStatusId)
                    .HasColumnName("LogAuditStatusID")
                    .HasComment("设备巡检状态");

                entity.Property(e => e.LogAuditStatusName)
                    .HasMaxLength(50)
                    .HasComment("设备巡检状态");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasComment("巡检日志时间");

                entity.Property(e => e.LogIntro).HasComment("描述");

                entity.Property(e => e.LogShotId).HasComment("设备ID");

                entity.Property(e => e.LogType).HasComment("1进度更新，2备忘，3审核");
            });

            modelBuilder.Entity<SalaryInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).HasColumnName("BID");

                entity.Property(e => e.DailyWages).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OpeningBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<SysApplication>(entity =>
            {
                entity.ToTable("Sys_Application");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppIntro).HasMaxLength(500);

                entity.Property(e => e.AppMenuId).HasComment("权限视图id");

                entity.Property(e => e.AppName).HasMaxLength(50);

                entity.Property(e => e.AppNo).HasMaxLength(50);

                entity.Property(e => e.AppPhoto).HasMaxLength(500);

                entity.Property(e => e.AppPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<SysAttach>(entity =>
            {
                entity.ToTable("Sys_Attach");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachName).HasMaxLength(50);

                entity.Property(e => e.AttachPath).HasMaxLength(50);

                entity.Property(e => e.AttachType).HasMaxLength(50);
            });

            modelBuilder.Entity<SysBanner>(entity =>
            {
                entity.ToTable("Sys_Banner");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BannerDate).HasColumnType("datetime");

                entity.Property(e => e.BannerDateEnd).HasColumnType("datetime");

                entity.Property(e => e.BannerDateStart).HasColumnType("datetime");

                entity.Property(e => e.BannerPath).HasMaxLength(500);

                entity.Property(e => e.BannerPath1).HasMaxLength(500);

                entity.Property(e => e.BannerPath2).HasMaxLength(500);

                entity.Property(e => e.BannerRemark).HasMaxLength(200);

                entity.Property(e => e.BannerTitle).HasMaxLength(250);
            });

            modelBuilder.Entity<SysBannerType>(entity =>
            {
                entity.ToTable("Sys_BannerType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BannerTypeIntro).HasMaxLength(500);

                entity.Property(e => e.BannerTypeName).HasMaxLength(250);
            });

            modelBuilder.Entity<SysButton>(entity =>
            {
                entity.ToTable("Sys_Button");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增长id");

                entity.Property(e => e.ButtonClick)
                    .HasMaxLength(500)
                    .HasComment("按钮事件");

                entity.Property(e => e.ButtonIcon)
                    .HasMaxLength(100)
                    .HasComment("按钮图标");

                entity.Property(e => e.ButtonIf)
                    .HasMaxLength(100)
                    .HasComment("按钮存在条件");

                entity.Property(e => e.ButtonIsShow)
                    .HasDefaultValueSql("((0))")
                    .HasComment("按钮是否显示:0表示显示 1:表示");

                entity.Property(e => e.ButtonName)
                    .HasMaxLength(200)
                    .HasComment("按钮名称-中文");

                entity.Property(e => e.ButtonNo)
                    .HasMaxLength(200)
                    .HasComment("SysButtonNo");

                entity.Property(e => e.ButtonOrder).HasComment("排序 0表示最后");

                entity.Property(e => e.ButtonRemark)
                    .HasMaxLength(200)
                    .HasComment("按钮描述");

                entity.Property(e => e.ButtonType)
                    .HasMaxLength(100)
                    .HasComment("按钮分类：列表按钮");
            });

            modelBuilder.Entity<SysDept>(entity =>
            {
                entity.ToTable("Sys_Dept");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptIntro).HasMaxLength(50);

                entity.Property(e => e.DeptLinkMan).HasMaxLength(50);

                entity.Property(e => e.DeptLinkTel).HasMaxLength(50);

                entity.Property(e => e.DeptName).HasMaxLength(50);
            });

            modelBuilder.Entity<SysDict>(entity =>
            {
                entity.ToTable("Sys_Dict");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DictName).HasMaxLength(50);

                entity.Property(e => e.DictType).HasMaxLength(50);
            });

            modelBuilder.Entity<SysFavorite>(entity =>
            {
                entity.ToTable("Sys_Favorite");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FavDate).HasColumnType("datetime");

                entity.Property(e => e.FavDateCancel).HasColumnType("datetime");

                entity.Property(e => e.FavObjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysFeedback>(entity =>
            {
                entity.ToTable("Sys_Feedback");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.Property(e => e.FeedbackIntro).HasMaxLength(500);

                entity.Property(e => e.FeedbackManName).HasMaxLength(100);

                entity.Property(e => e.FeedbackManTel).HasMaxLength(50);

                entity.Property(e => e.FeedbackObjectName).HasMaxLength(500);

                entity.Property(e => e.FeedbackRepty).HasMaxLength(500);

                entity.Property(e => e.FeedbackReptyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysLang>(entity =>
            {
                entity.ToTable("Sys_Lang");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cn)
                    .HasColumnName("cn")
                    .HasMaxLength(500);

                entity.Property(e => e.Datashow).HasColumnName("datashow");

                entity.Property(e => e.Datasort).HasColumnName("datasort");

                entity.Property(e => e.Datatype)
                    .HasColumnName("datatype")
                    .HasMaxLength(50);

                entity.Property(e => e.Dataurl)
                    .HasColumnName("dataurl")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataurlparam)
                    .HasColumnName("dataurlparam")
                    .HasMaxLength(500);

                entity.Property(e => e.Datawidth).HasColumnName("datawidth");

                entity.Property(e => e.En)
                    .HasColumnName("en")
                    .HasMaxLength(500);

                entity.Property(e => e.Form)
                    .HasColumnName("form")
                    .HasMaxLength(50);

                entity.Property(e => e.No)
                    .HasColumnName("no")
                    .HasMaxLength(400);

                entity.Property(e => e.Sp)
                    .HasColumnName("sp")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.ToTable("Sys_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogActiveFnction)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LogActiveName).HasMaxLength(500);

                entity.Property(e => e.LogActiveType).HasMaxLength(500);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogFormCode).HasMaxLength(500);

                entity.Property(e => e.LogFormName).HasMaxLength(500);

                entity.Property(e => e.LogMemberName).HasMaxLength(500);

                entity.Property(e => e.LogStatusName).HasMaxLength(500);
            });

            modelBuilder.Entity<SysLogError>(entity =>
            {
                entity.ToTable("Sys_Log_Error");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrorAction).HasMaxLength(100);

                entity.Property(e => e.ErrorActionName).HasMaxLength(100);

                entity.Property(e => e.ErrorAddTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorFlag).HasMaxLength(100);

                entity.Property(e => e.ErrorUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<SysLogLogin>(entity =>
            {
                entity.ToTable("Sys_Log_Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginLocation).HasMaxLength(50);

                entity.Property(e => e.LoginMacId)
                    .HasColumnName("LoginMacID")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginMacType).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SysLoginType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_LoginType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginTypeDate).HasColumnType("datetime");

                entity.Property(e => e.LoginTypeNmae).HasMaxLength(100);
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.MenuId })
                    .HasName("PK_SystemUserType_Menu");

                entity.ToTable("Sys_Menu");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MenuAppFlag).HasComment("是否应用");

                entity.Property(e => e.MenuAppGroup)
                    .HasMaxLength(50)
                    .HasComment("应用组别");

                entity.Property(e => e.MenuAppIntro)
                    .HasMaxLength(500)
                    .HasComment("应用楼述");

                entity.Property(e => e.MenuAppName)
                    .HasMaxLength(50)
                    .HasComment("应用名称");

                entity.Property(e => e.MenuAppPhoto)
                    .HasMaxLength(50)
                    .HasComment("应用图片");

                entity.Property(e => e.MenuIcon).HasMaxLength(100);

                entity.Property(e => e.MenuName).HasMaxLength(100);

                entity.Property(e => e.MenuUrl).HasMaxLength(100);

                entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");

                entity.Property(e => e.Remark).HasMaxLength(1000);
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.ToTable("Sys_Message");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateMember).HasMaxLength(50);

                entity.Property(e => e.MessageContent).IsRequired();

                entity.Property(e => e.MessageMemberIdTo)
                    .HasColumnName("MessageMemberId_To")
                    .HasMaxLength(50);

                entity.Property(e => e.MessageTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysPhotos>(entity =>
            {
                entity.ToTable("Sys_Photos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PhotoIntro).HasMaxLength(500);

                entity.Property(e => e.PhotoPath).HasMaxLength(1000);

                entity.Property(e => e.PhotoTitle).HasMaxLength(50);

                entity.Property(e => e.PhotoType).HasMaxLength(50);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);
            });

            modelBuilder.Entity<SysSend>(entity =>
            {
                entity.ToTable("Sys_Send");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendDateSend).HasColumnType("datetime");

                entity.Property(e => e.SendDateUpdate).HasColumnType("datetime");

                entity.Property(e => e.SendIntro).HasMaxLength(250);

                entity.Property(e => e.SendKeyword).HasMaxLength(250);

                entity.Property(e => e.SendManName).HasMaxLength(100);

                entity.Property(e => e.SendObjectTypeName).HasMaxLength(100);

                entity.Property(e => e.SendTitle).HasMaxLength(250);
            });

            modelBuilder.Entity<SysSendLog>(entity =>
            {
                entity.ToTable("Sys_Send_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysSet>(entity =>
            {
                entity.ToTable("Sys_Set");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SystemSetName).HasMaxLength(100);

                entity.Property(e => e.SystemSetNo).HasMaxLength(50);

                entity.Property(e => e.SystemSetValue).HasMaxLength(50);
            });

            modelBuilder.Entity<SysShare>(entity =>
            {
                entity.ToTable("Sys_Share");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShareDate).HasColumnType("datetime");

                entity.Property(e => e.ShareObjectIntro).HasMaxLength(500);

                entity.Property(e => e.ShareType).HasMaxLength(50);

                entity.Property(e => e.ShareUrl).HasMaxLength(50);
            });

            modelBuilder.Entity<SysSms>(entity =>
            {
                entity.ToTable("Sys_Sms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SmsCheckDate).HasColumnType("datetime");

                entity.Property(e => e.SmsCheckIp).HasMaxLength(50);

                entity.Property(e => e.SmsCheckLocation).HasMaxLength(50);

                entity.Property(e => e.SmsCheckModel).HasMaxLength(50);

                entity.Property(e => e.SmsCode).HasMaxLength(50);

                entity.Property(e => e.SmsDate).HasColumnType("datetime");

                entity.Property(e => e.SmsMobile).HasMaxLength(50);

                entity.Property(e => e.SmsType).HasMaxLength(50);
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.ToTable("Sys_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserAccount).HasMaxLength(100);

                entity.Property(e => e.UserCompanyId).HasColumnName("UserCompanyID");

                entity.Property(e => e.UserDateCreate).HasColumnType("datetime");

                entity.Property(e => e.UserDateLogin).HasColumnType("datetime");

                entity.Property(e => e.UserDateLoginApi).HasColumnType("datetime");

                entity.Property(e => e.UserDateRequest).HasColumnType("datetime");

                entity.Property(e => e.UserDateRequestApi).HasColumnType("datetime");

                entity.Property(e => e.UserEmail).HasMaxLength(100);

                entity.Property(e => e.UserJobNumber)
                    .HasMaxLength(100)
                    .HasComment("工号");

                entity.Property(e => e.UserKey).HasMaxLength(100);

                entity.Property(e => e.UserLanguage).HasMaxLength(100);

                entity.Property(e => e.UserLocation).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserNickName).HasMaxLength(100);

                entity.Property(e => e.UserNo).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(100);

                entity.Property(e => e.UserPhotoHead).HasMaxLength(1000);

                entity.Property(e => e.UserPwd).HasMaxLength(100);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.UserRoleName).HasMaxLength(100);

                entity.Property(e => e.UserSendid).HasMaxLength(100);

                entity.Property(e => e.UserUrlWx).HasMaxLength(500);
            });

            modelBuilder.Entity<SysUserRole>(entity =>
            {
                entity.ToTable("Sys_UserRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserRoleAddDate).HasColumnType("datetime");

                entity.Property(e => e.UserRoleAgencyId).HasColumnName("UserRoleAgencyID");

                entity.Property(e => e.UserRoleAgencyName).HasMaxLength(100);

                entity.Property(e => e.UserRoleLoginTypeId).HasColumnName("UserRoleLoginTypeID");

                entity.Property(e => e.UserRoleLogo).HasMaxLength(500);

                entity.Property(e => e.UserRoleName).HasMaxLength(100);

                entity.Property(e => e.UserRoleRemark).HasMaxLength(200);
            });

            modelBuilder.Entity<SysUserRoleMenu>(entity =>
            {
                entity.ToTable("Sys_UserRoleMenu");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增长id");

                entity.Property(e => e.ButtonIds)
                    .HasColumnName("ButtonIDs")
                    .HasComment("菜单按钮表");

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasComment("菜单id");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("分组id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("添加时间");

                entity.Property(e => e.UpdateUser).HasComment("添加人");
            });

            modelBuilder.Entity<TimerStartSprayRegularly>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeviceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pm10)
                    .HasColumnName("PM10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pm25)
                    .HasColumnName("PM25")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tsp)
                    .HasColumnName("TSP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TowerRegistration>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("PK__TowerReg__C4971C1BFE506E5A");

                entity.Property(e => e.Ids).HasColumnName("IDs");

                entity.Property(e => e.HardwareVer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HxzFactory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HxzId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LeaseEndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeasePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaseStartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerPort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerTime).HasColumnType("datetime");

                entity.Property(e => e.SimCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareVer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnloadingDeviceRealTimeData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Appid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Appsecret)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BatteryPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HxzFactory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HxzId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obliguity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityXstatus).HasColumnName("ObliguityXStatus");

                entity.Property(e => e.ObliguityY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObliguityYstatus).HasColumnName("ObliguityYStatus");

                entity.Property(e => e.Rtime)
                    .HasColumnName("RTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeightPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeightStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Device");

                entity.Property(e => e.DeviceAddress).HasMaxLength(100);

                entity.Property(e => e.DeviceArea1).HasMaxLength(50);

                entity.Property(e => e.DeviceArea2).HasMaxLength(50);

                entity.Property(e => e.DeviceArea3).HasMaxLength(50);

                entity.Property(e => e.DeviceCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceLatitude).HasMaxLength(50);

                entity.Property(e => e.DeviceLongitude).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceTypeAppUrl).HasMaxLength(50);

                entity.Property(e => e.DeviceTypeName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectArea1).HasMaxLength(50);

                entity.Property(e => e.ProjectArea2).HasMaxLength(50);

                entity.Property(e => e.ProjectArea3).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.TradeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDeviceAlarm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceAlarm");

                entity.Property(e => e.AlarmDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmExceedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AlarmIntro).HasMaxLength(200);

                entity.Property(e => e.AlarmValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AlarmWarnName).HasMaxLength(50);

                entity.Property(e => e.AlarmWarningValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VDeviceByType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceByType");

                entity.Property(e => e.DeviceTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VDeviceData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceData");

                entity.Property(e => e.DeviceAddress).HasMaxLength(100);

                entity.Property(e => e.DeviceArea1).HasMaxLength(50);

                entity.Property(e => e.DeviceArea2).HasMaxLength(50);

                entity.Property(e => e.DeviceArea3).HasMaxLength(50);

                entity.Property(e => e.DeviceAtDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceDateLog).HasColumnType("datetime");

                entity.Property(e => e.DeviceHeartDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceInstallDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceLatitude).HasMaxLength(50);

                entity.Property(e => e.DeviceLocation).HasMaxLength(50);

                entity.Property(e => e.DeviceLocationBaidu).HasMaxLength(50);

                entity.Property(e => e.DeviceLongitude).HasMaxLength(50);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.DeviceNo).HasMaxLength(50);

                entity.Property(e => e.DeviceProductionName).HasMaxLength(50);

                entity.Property(e => e.DeviceRecordNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceSpecs).HasMaxLength(50);

                entity.Property(e => e.Expr2).HasMaxLength(50);

                entity.Property(e => e.Expr3).HasMaxLength(50);

                entity.Property(e => e.Expr4).HasMaxLength(50);

                entity.Property(e => e.Expr5).HasMaxLength(50);

                entity.Property(e => e.Expr6).HasMaxLength(50);

                entity.Property(e => e.Expr7).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VDeviceDataDust>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceDataDust");

                entity.Property(e => e.DeviceAddress).HasMaxLength(100);

                entity.Property(e => e.DeviceDataB03)
                    .HasColumnName("DeviceData_b03")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataCo)
                    .HasColumnName("DeviceData_co")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataH01)
                    .HasColumnName("DeviceData_h01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataHumidity)
                    .HasColumnName("DeviceData_humidity")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataNo2)
                    .HasColumnName("DeviceData_no2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataO3)
                    .HasColumnName("DeviceData_o3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataPa)
                    .HasColumnName("DeviceData_pa")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataPm10)
                    .HasColumnName("DeviceData_pm10")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataPm25)
                    .HasColumnName("DeviceData_pm25")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataPrimary)
                    .HasColumnName("DeviceData_Primary")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataSo2)
                    .HasColumnName("DeviceData_so2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataT01)
                    .HasColumnName("DeviceData_t01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataTemp)
                    .HasColumnName("DeviceData_temp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataTsp)
                    .HasColumnName("DeviceData_tsp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataW01)
                    .HasColumnName("DeviceData_w01")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataW02)
                    .HasColumnName("DeviceData_w02")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataWd)
                    .HasColumnName("DeviceData_wd")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataWp)
                    .HasColumnName("DeviceData_wp")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataWs)
                    .HasColumnName("DeviceData_ws")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDataZs)
                    .HasColumnName("DeviceData_zs")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeviceDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceDateLog).HasColumnType("datetime");

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VDeviceDataDustB03avg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceDataDust_B03Avg");

                entity.Property(e => e.DeviceDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Zs)
                    .HasColumnName("zs")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VDeviceDataDustByDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceDataDustByDay");

                entity.Property(e => e.DeviceDate)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Hh).HasColumnName("hh");

                entity.Property(e => e.Pm10)
                    .HasColumnName("pm10")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pm25)
                    .HasColumnName("pm25")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zs)
                    .HasColumnName("zs")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VDeviceTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_DeviceTotal");
            });

            modelBuilder.Entity<VMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Member");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberAddress).HasMaxLength(100);

                entity.Property(e => e.MemberArea1).HasMaxLength(50);

                entity.Property(e => e.MemberArea2).HasMaxLength(50);

                entity.Property(e => e.MemberArea3).HasMaxLength(50);

                entity.Property(e => e.MemberAuditDate).HasColumnType("datetime");

                entity.Property(e => e.MemberCardBook).HasMaxLength(500);

                entity.Property(e => e.MemberContract).HasMaxLength(200);

                entity.Property(e => e.MemberDateBirthday).HasColumnType("datetime");

                entity.Property(e => e.MemberDateReg).HasColumnType("datetime");

                entity.Property(e => e.MemberDateUpdate).HasColumnType("datetime");

                entity.Property(e => e.MemberEmail).HasMaxLength(50);

                entity.Property(e => e.MemberIdCard).HasMaxLength(50);

                entity.Property(e => e.MemberIdCardPhoto).HasMaxLength(500);

                entity.Property(e => e.MemberIntro).HasMaxLength(100);

                entity.Property(e => e.MemberLocation).HasMaxLength(100);

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberPhoto).HasMaxLength(100);

                entity.Property(e => e.MemberPhotoHead).HasMaxLength(500);

                entity.Property(e => e.MemberPwd).HasMaxLength(50);

                entity.Property(e => e.MemberSendId).HasMaxLength(50);

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.UserRoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<VMemberTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MemberTotal");
            });

            modelBuilder.Entity<VMemberTotalByAge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MemberTotalByAge");
            });

            modelBuilder.Entity<VProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectAddress).HasMaxLength(50);

                entity.Property(e => e.ProjectAqi)
                    .HasColumnName("ProjectAQI")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectArea1).HasMaxLength(50);

                entity.Property(e => e.ProjectArea2).HasMaxLength(50);

                entity.Property(e => e.ProjectArea3).HasMaxLength(50);

                entity.Property(e => e.ProjectBuildName).HasMaxLength(50);

                entity.Property(e => e.ProjectConstructionName).HasMaxLength(50);

                entity.Property(e => e.ProjectCreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectDesignName).HasMaxLength(50);

                entity.Property(e => e.ProjectEffectPhoto).HasMaxLength(100);

                entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectFunction).HasMaxLength(100);

                entity.Property(e => e.ProjectIntro).HasMaxLength(100);

                entity.Property(e => e.ProjectLatitude).HasMaxLength(50);

                entity.Property(e => e.ProjectLayerNumber).HasMaxLength(50);

                entity.Property(e => e.ProjectLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectLinkMan).HasMaxLength(50);

                entity.Property(e => e.ProjectLinkTel).HasMaxLength(50);

                entity.Property(e => e.ProjectLongitude).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.ProjectNo).HasMaxLength(50);

                entity.Property(e => e.ProjectPlanarPhoto).HasMaxLength(100);

                entity.Property(e => e.ProjectPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectStartDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectSupervisorName).HasMaxLength(50);

                entity.Property(e => e.ProjectSurveyName).HasMaxLength(50);

                entity.Property(e => e.ProjectUrl3d).HasMaxLength(500);

                entity.Property(e => e.ProjectUrlBim).HasMaxLength(500);

                entity.Property(e => e.ProjectUrlCheck).HasMaxLength(500);

                entity.Property(e => e.ProjectWidth).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VProject2company>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_2Company");

                entity.Property(e => e.CompanyLinkMan).HasMaxLength(50);

                entity.Property(e => e.CompanyLinkTel).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CompanyNo).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectCompanyDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCompanyName).HasMaxLength(50);

                entity.Property(e => e.ProjectDeptJob).HasMaxLength(500);

                entity.Property(e => e.ProjectDeptName).HasMaxLength(500);
            });

            modelBuilder.Entity<VProject7video>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_7Video");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectArea1).HasMaxLength(50);

                entity.Property(e => e.ProjectArea2).HasMaxLength(50);

                entity.Property(e => e.ProjectArea3).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.RegionForUse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoCode).HasMaxLength(100);

                entity.Property(e => e.VideoInstallAddress).HasMaxLength(500);

                entity.Property(e => e.VideoInstallDate).HasColumnType("datetime");

                entity.Property(e => e.VideoName).HasMaxLength(50);

                entity.Property(e => e.VideoType).HasMaxLength(50);

                entity.Property(e => e.VideoUrl).HasMaxLength(500);
            });

            modelBuilder.Entity<VProjectCheckDataByPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_CheckDataByPoint");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckPhoto).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.PointName).HasMaxLength(50);
            });

            modelBuilder.Entity<VProjectCheckDataByRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_CheckDataByRoute");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckPhoto).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.RouteName).HasMaxLength(50);
            });

            modelBuilder.Entity<VProjectCheckNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_Check_Note");

                entity.Property(e => e.CheckCompanyName).HasMaxLength(50);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDeptName).HasMaxLength(50);

                entity.Property(e => e.CheckDesc).HasMaxLength(500);

                entity.Property(e => e.CheckFile).HasMaxLength(200);

                entity.Property(e => e.CheckParts).HasMaxLength(50);

                entity.Property(e => e.CheckPhoto).HasMaxLength(200);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CheckTitle).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectName).HasMaxLength(50);
            });

            modelBuilder.Entity<VProjectCheckPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_Check_Point");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.PointDate).HasColumnType("datetime");

                entity.Property(e => e.PointLatitude).HasMaxLength(50);

                entity.Property(e => e.PointLongitude).HasMaxLength(50);

                entity.Property(e => e.PointMatter).HasMaxLength(200);

                entity.Property(e => e.PointName).HasMaxLength(50);
            });

            modelBuilder.Entity<VProjectCheckRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Project_Check_Route");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.RouteDate).HasColumnType("datetime");

                entity.Property(e => e.RouteName).HasMaxLength(50);

                entity.Property(e => e.RoutePointCheckIdArr).HasMaxLength(500);
            });

            modelBuilder.Entity<VProjectCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectCompany");

                entity.Property(e => e.CompanyName).HasMaxLength(50);
            });

            modelBuilder.Entity<VProjectCompanyByCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectCompany_ByCompany");

                entity.Property(e => e.ProjectCompanyName).HasMaxLength(50);

                entity.Property(e => e.ProjectDeptJob).HasMaxLength(500);
            });

            modelBuilder.Entity<VProjectMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectMember");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberCreateDate).HasColumnType("datetime");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberSysAuditDate).HasColumnType("datetime");

                entity.Property(e => e.MemberTel).HasMaxLength(50);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.ProjectAddress).HasMaxLength(50);

                entity.Property(e => e.ProjectArea1).HasMaxLength(50);

                entity.Property(e => e.ProjectArea2).HasMaxLength(50);

                entity.Property(e => e.ProjectArea3).HasMaxLength(50);

                entity.Property(e => e.ProjectDept1Name).HasMaxLength(50);

                entity.Property(e => e.ProjectDept2Name).HasMaxLength(50);

                entity.Property(e => e.ProjectDept3Name).HasMaxLength(50);

                entity.Property(e => e.ProjectEffectPhoto).HasMaxLength(100);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.UserRoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<VProjectShotSafe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectShotSafe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShotAddress).HasMaxLength(50);

                entity.Property(e => e.ShotCheckIntro).HasMaxLength(500);

                entity.Property(e => e.ShotCheckPhoto).HasMaxLength(500);

                entity.Property(e => e.ShotCheckPosition).HasMaxLength(100);

                entity.Property(e => e.ShotCompanyName).HasMaxLength(50);

                entity.Property(e => e.ShotDate).HasColumnType("datetime");

                entity.Property(e => e.ShotDateAudit).HasColumnType("datetime");

                entity.Property(e => e.ShotDateCheck).HasColumnType("datetime");

                entity.Property(e => e.ShotDateSerice).HasColumnType("datetime");

                entity.Property(e => e.ShotIntro).HasMaxLength(500);

                entity.Property(e => e.ShotLocation).HasMaxLength(100);

                entity.Property(e => e.ShotLocationBaidu).HasMaxLength(100);

                entity.Property(e => e.ShotMemberIdAuditSelected).HasColumnName("ShotMemberId_Audit_Selected");

                entity.Property(e => e.ShotMemberIdCheck).HasColumnName("ShotMemberId_Check");

                entity.Property(e => e.ShotMemberIdService).HasColumnName("ShotMemberId_Service");

                entity.Property(e => e.ShotMemberIdsAudit)
                    .HasColumnName("ShotMemberIds_Audit")
                    .HasMaxLength(500);

                entity.Property(e => e.ShotMemberIdsCopy)
                    .HasColumnName("ShotMemberIds_Copy")
                    .HasMaxLength(500);

                entity.Property(e => e.ShotMemberName).HasMaxLength(50);

                entity.Property(e => e.ShotMemberNameCheck)
                    .HasColumnName("ShotMemberName_Check")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberNameService)
                    .HasColumnName("ShotMemberName_Service")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberTel).HasMaxLength(50);

                entity.Property(e => e.ShotMemberTelCheck)
                    .HasColumnName("ShotMemberTel_Check")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotMemberTelService)
                    .HasColumnName("ShotMemberTel_Service")
                    .HasMaxLength(50);

                entity.Property(e => e.ShotPhoto).HasMaxLength(500);

                entity.Property(e => e.ShotServiceIntro).HasMaxLength(500);

                entity.Property(e => e.ShotServicePhoto).HasMaxLength(500);

                entity.Property(e => e.ShotTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<VProjectShotSafeMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectShotSafeMember");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogAuditMemberName).HasMaxLength(50);

                entity.Property(e => e.LogAuditStatusId).HasColumnName("LogAuditStatusID");

                entity.Property(e => e.LogAuditStatusName).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.ShotDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VProjectTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ProjectTotal");

                entity.Property(e => e.ProjectCount).HasColumnName("projectCount");

                entity.Property(e => e.ProjectCount1).HasColumnName("projectCount1");

                entity.Property(e => e.ProjectCount2).HasColumnName("projectCount2");
            });

            modelBuilder.Entity<VShotSafe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ShotSafe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogAuditMemberName).HasMaxLength(50);

                entity.Property(e => e.LogAuditStatusId).HasColumnName("LogAuditStatusID");

                entity.Property(e => e.LogAuditStatusName).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VUserRoleMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UserRoleMenu");

                entity.Property(e => e.ButtonIds).HasColumnName("ButtonIDs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MenuName).HasMaxLength(100);

                entity.Property(e => e.MenuUrl).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeixinMenu>(entity =>
            {
                entity.ToTable("Weixin_Menu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuKeyword).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuUrl).HasMaxLength(250);
            });

            modelBuilder.Entity<WeixinMsg>(entity =>
            {
                entity.ToTable("Weixin_Msg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormMsgKeyword).HasMaxLength(50);

                entity.Property(e => e.FormMsgType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgDesc).HasMaxLength(50);

                entity.Property(e => e.MsgTitle).HasMaxLength(50);

                entity.Property(e => e.ToMsgCateId).HasColumnName("ToMsgCateID");

                entity.Property(e => e.ToMsgCatePower)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToMsgContent).HasMaxLength(500);

                entity.Property(e => e.ToMsgLogId)
                    .HasColumnName("ToMsgLogID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToMsgSectionId).HasColumnName("ToMsgSectionID");

                entity.Property(e => e.ToMsgType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeixinSend>(entity =>
            {
                entity.ToTable("Weixin_Send");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendDesc).HasMaxLength(500);

                entity.Property(e => e.SendStatusDate).HasColumnType("datetime");

                entity.Property(e => e.SendTitle).HasMaxLength(250);

                entity.Property(e => e.SendUrl).HasMaxLength(250);
            });

            modelBuilder.Entity<WeixinSendModel>(entity =>
            {
                entity.ToTable("Weixin_SendModel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModelMemo).HasColumnType("ntext");

                entity.Property(e => e.ModelName).HasMaxLength(50);

                entity.Property(e => e.ModelPic1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelPic2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeixinSetting>(entity =>
            {
                entity.ToTable("Weixin_Setting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WxAccount)
                    .HasColumnName("Wx_Account")
                    .HasMaxLength(50);

                entity.Property(e => e.WxAddlink)
                    .HasColumnName("Wx_Addlink")
                    .HasMaxLength(250);

                entity.Property(e => e.WxAppId)
                    .HasColumnName("Wx_AppID")
                    .HasMaxLength(250);

                entity.Property(e => e.WxAppSecret)
                    .HasColumnName("Wx_AppSecret")
                    .HasMaxLength(250);

                entity.Property(e => e.WxEncodingAeskey)
                    .HasColumnName("Wx_EncodingAESKey")
                    .HasMaxLength(250);

                entity.Property(e => e.WxEncodingType).HasColumnName("Wx_EncodingType");

                entity.Property(e => e.WxId)
                    .HasColumnName("Wx_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WxId1)
                    .HasColumnName("Wx_ID1")
                    .HasMaxLength(50);

                entity.Property(e => e.WxId2)
                    .HasColumnName("Wx_ID2")
                    .HasMaxLength(50);

                entity.Property(e => e.WxMchid)
                    .HasColumnName("Wx_mchid")
                    .HasMaxLength(50);

                entity.Property(e => e.WxMchkey)
                    .HasColumnName("Wx_mchkey")
                    .HasMaxLength(50);

                entity.Property(e => e.WxName)
                    .HasColumnName("Wx_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.WxPwd)
                    .HasColumnName("Wx_Pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.WxToken)
                    .HasColumnName("Wx_Token")
                    .HasMaxLength(250);

                entity.Property(e => e.WxUrl)
                    .HasColumnName("Wx_Url")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<WeixinUser>(entity =>
            {
                entity.ToTable("Weixin_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HeadImgUrl).HasMaxLength(500);

                entity.Property(e => e.HeadImgUrlMin).HasMaxLength(500);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasMaxLength(100);

                entity.Property(e => e.Lng)
                    .HasColumnName("lng")
                    .HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.Openid).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(50);

                entity.Property(e => e.SubscribeTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinId).HasMaxLength(50);
            });

            modelBuilder.Entity<WeixinUserAttr>(entity =>
            {
                entity.ToTable("Weixin_UserAttr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttrName).HasMaxLength(100);

                entity.Property(e => e.AttrValue).HasMaxLength(100);

                entity.Property(e => e.WxUserId).HasColumnName("WX_UserId");
            });

            modelBuilder.Entity<WorkCertificate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
