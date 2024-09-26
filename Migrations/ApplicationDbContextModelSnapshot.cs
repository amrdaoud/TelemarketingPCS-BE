﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelemarketingControlSystem.Models.Data;

#nullable disable

namespace TelemarketingControlSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.AccessLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessLogs");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.GroupTenantRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId");

                    b.ToTable("GroupTenantRoles");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.TenantDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("TenantId");

                    b.ToTable("TenantDevices");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.UserTenantRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId");

                    b.ToTable("UserTenantRoles");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpired")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenExpired")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.CallStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CallStatuses");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SyriatelId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.EmployeeCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CallStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CallType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("GSM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCalls");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.EmployeeWorkingHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("SegmentName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("WorkingHours")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SegmentName");

                    b.ToTable("EmployeeWorkingHours");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Notification.HubClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("connectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HubClients");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Notification.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("connectionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("Projects", t =>
                        {
                            t.HasCheckConstraint("Ck_Project_Dates", "[DateTo]>[DateFrom]");
                        });
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("AlternativeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bundle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CallStatusId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("GSM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Generation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegmentName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubSegment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CallStatusId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SegmentName");

                    b.ToTable("ProjectDetails");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDetailCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CallStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CallType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("ProjectDetailId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectDetailId");

                    b.ToTable("ProjectDetailCalls");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<double>("RangFrom")
                        .HasColumnType("float");

                    b.Property<double>("RangTo")
                        .HasColumnType("float");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectDictionaries");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Segment", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Name");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.TypeDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectTypeId")
                        .HasColumnType("int");

                    b.Property<double>("RangFrom")
                        .HasColumnType("float");

                    b.Property<double>("RangTo")
                        .HasColumnType("float");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("TypeDictionaries");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Device", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Auth.Device", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.GroupTenantRole", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Auth.Role", "Role")
                        .WithMany("GroupTenantRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Auth.Tenant", "Tenant")
                        .WithMany("GroupTenantRoles")
                        .HasForeignKey("TenantId");

                    b.Navigation("Role");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.RolePermission", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Auth.Permission", null)
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Auth.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.TenantDevice", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Auth.Device", "Device")
                        .WithMany("TenantDevices")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Auth.Tenant", "Tenant")
                        .WithMany("TenantDevices")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.UserTenantRole", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Auth.Role", "Role")
                        .WithMany("UserTenantRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Auth.Tenant", "Tenant")
                        .WithMany("UserTenantRoles")
                        .HasForeignKey("TenantId");

                    b.Navigation("Role");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.EmployeeCall", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Employee", "Employee")
                        .WithMany("EmployeeCalls")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.EmployeeWorkingHour", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Employee", "Employee")
                        .WithMany("EmployeeWorkingHours")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Project", "Project")
                        .WithMany("EmployeeWorkingHours")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Segment", "Segment")
                        .WithMany("EmployeeWorkingHours")
                        .HasForeignKey("SegmentName");

                    b.Navigation("Employee");

                    b.Navigation("Project");

                    b.Navigation("Segment");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Notification.Notification", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Project", "Project")
                        .WithMany("Notifications")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Project", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.ProjectType", "ProjectType")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectType");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDetail", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.CallStatus", "CallStatus")
                        .WithMany("ProjectDetails")
                        .HasForeignKey("CallStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Employee", "Employee")
                        .WithMany("ProjectDetails")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Project", "Project")
                        .WithMany("ProjectDetails")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelemarketingControlSystem.Models.Segment", "Segment")
                        .WithMany("ProjectDetails")
                        .HasForeignKey("SegmentName");

                    b.Navigation("CallStatus");

                    b.Navigation("Employee");

                    b.Navigation("Project");

                    b.Navigation("Segment");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDetailCall", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.ProjectDetail", "ProjectDetail")
                        .WithMany("ProjectDetailCalls")
                        .HasForeignKey("ProjectDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectDetail");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDictionary", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.Project", "Project")
                        .WithMany("ProjectDictionaries")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.TypeDictionary", b =>
                {
                    b.HasOne("TelemarketingControlSystem.Models.ProjectType", "ProjectType")
                        .WithMany("TypeDictionaries")
                        .HasForeignKey("ProjectTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectType");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Device", b =>
                {
                    b.Navigation("Childs");

                    b.Navigation("TenantDevices");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Role", b =>
                {
                    b.Navigation("GroupTenantRoles");

                    b.Navigation("RolePermissions");

                    b.Navigation("UserTenantRoles");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Auth.Tenant", b =>
                {
                    b.Navigation("GroupTenantRoles");

                    b.Navigation("TenantDevices");

                    b.Navigation("UserTenantRoles");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.CallStatus", b =>
                {
                    b.Navigation("ProjectDetails");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Employee", b =>
                {
                    b.Navigation("EmployeeCalls");

                    b.Navigation("EmployeeWorkingHours");

                    b.Navigation("ProjectDetails");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Project", b =>
                {
                    b.Navigation("EmployeeWorkingHours");

                    b.Navigation("Notifications");

                    b.Navigation("ProjectDetails");

                    b.Navigation("ProjectDictionaries");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectDetail", b =>
                {
                    b.Navigation("ProjectDetailCalls");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.ProjectType", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("TypeDictionaries");
                });

            modelBuilder.Entity("TelemarketingControlSystem.Models.Segment", b =>
                {
                    b.Navigation("EmployeeWorkingHours");

                    b.Navigation("ProjectDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
