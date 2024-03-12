﻿// <auto-generated />
using System;
using ConstructionSiteReportingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConstructionSiteReportingSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ConstructionSiteDbContext))]
    [Migration("20240312165947_ImageUrlColumnToProjectSiteNameAdded")]
    partial class ImageUrlColumnToProjectSiteNameAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction contractor identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Construction contractor name");

                    b.HasKey("Id");

                    b.ToTable("Contractors");

                    b.HasComment("Construction contractor");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Investment project identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectSiteNameId")
                        .HasColumnType("int")
                        .HasComment("Investment project/Construction site name identifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectSiteNameId")
                        .IsUnique();

                    b.ToTable("Projects");

                    b.HasComment("Investment project");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.ProjectSiteName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Investment project/Construction site name identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Investment project/Construction site image URL");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Investment project/Construction site name");

                    b.HasKey("Id");

                    b.ToTable("ProjectsSitesNames");

                    b.HasComment("Investment project/Construction site name");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction site identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2")
                        .HasComment("Construction site finish date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectSiteNameId")
                        .HasColumnType("int")
                        .HasComment("Investment project/Construction site name identifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectSiteNameId")
                        .IsUnique();

                    b.ToTable("Sites");

                    b.HasComment("Construction site");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.SiteStage", b =>
                {
                    b.Property<int>("SiteId")
                        .HasColumnType("int")
                        .HasComment("Construction site identifier");

                    b.Property<int>("StageId")
                        .HasColumnType("int")
                        .HasComment("Construction stage identifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("SiteId", "StageId");

                    b.HasIndex("StageId");

                    b.ToTable("SitesStages");

                    b.HasComment("Construction site and construction stage mapping table");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction stage identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Construction stage name");

                    b.HasKey("Id");

                    b.ToTable("Stages");

                    b.HasComment("Construction stage");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Task identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Task creation date");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Task creator identifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Task description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("Task's current status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Task title");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Tasks");

                    b.HasComment("User tasks");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Measurement unit identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Measurement unit type");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasComment("Measurement unit");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CarryOutDate")
                        .HasColumnType("datetime2")
                        .HasComment("Construction and assembly work carry out date and time");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work contractor identifier");

                    b.Property<decimal>("CostPerUnit")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Construction and assembly work cost per measurement unit");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Construction and assembly work creator identifier");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Construction and assembly work description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIncluded")
                        .HasColumnType("bit")
                        .HasComment("Boolean value that determines if the current construction and assembly work is included in the total quantity report");

                    b.Property<double>("Quantity")
                        .HasColumnType("float")
                        .HasComment("Construction and assembly work quantity");

                    b.Property<int>("StageId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work stage identifier");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(36,2)")
                        .HasComment("Construction and assembly work total cost");

                    b.Property<int>("UnitId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work measurement unit identifier");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work type identifier");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("StageId");

                    b.HasIndex("UnitId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("Works");

                    b.HasComment("Construction and assembly work");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkByProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work according to investment project identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work investment project identifier");

                    b.Property<double>("TotalQuantity")
                        .HasColumnType("float")
                        .HasComment("Construction and assembly work according to investment project total quantity");

                    b.Property<int>("UnitId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work according to investment project measurement unit identifier");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work type identifier according to investment project");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UnitId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("WorksByProjects");

                    b.HasComment("Construction and assembly work according to investment project");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Construction and assembly work type identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Construction and assembly work type name");

                    b.HasKey("Id");

                    b.ToTable("WorksTypes");

                    b.HasComment("Construction and assembly work type");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Project", b =>
                {
                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.ProjectSiteName", "ProjectSiteName")
                        .WithOne("Project")
                        .HasForeignKey("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Project", "ProjectSiteNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectSiteName");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Site", b =>
                {
                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.ProjectSiteName", "ProjectSiteName")
                        .WithOne("Site")
                        .HasForeignKey("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Site", "ProjectSiteNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectSiteName");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.SiteStage", b =>
                {
                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Site", "Site")
                        .WithMany("SitesStages")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Stage", "Stage")
                        .WithMany("SitesStages")
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Site");

                    b.Navigation("Stage");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Task", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Work", b =>
                {
                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Contractor", "Contractor")
                        .WithMany("Works")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Stage", "Stage")
                        .WithMany("Works")
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Unit", "Unit")
                        .WithMany("Works")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkType", "WorkType")
                        .WithMany("Works")
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Contractor");

                    b.Navigation("Creator");

                    b.Navigation("Stage");

                    b.Navigation("Unit");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkByProject", b =>
                {
                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Project", "Project")
                        .WithMany("WorksByProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Unit", "Unit")
                        .WithMany("WorksByProjects")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkType", "WorkType")
                        .WithMany("WorksByProjects")
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Unit");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Contractor", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Project", b =>
                {
                    b.Navigation("WorksByProjects");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.ProjectSiteName", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();

                    b.Navigation("Site")
                        .IsRequired();
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Site", b =>
                {
                    b.Navigation("SitesStages");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Stage", b =>
                {
                    b.Navigation("SitesStages");

                    b.Navigation("Works");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.Unit", b =>
                {
                    b.Navigation("Works");

                    b.Navigation("WorksByProjects");
                });

            modelBuilder.Entity("ConstructionSiteReportingSystem.Infrastructure.Data.Models.WorkType", b =>
                {
                    b.Navigation("Works");

                    b.Navigation("WorksByProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
