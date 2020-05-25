﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSKManager.Model;

namespace OSKManager.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200525113909_ChangeInstructorsRoleName")]
    partial class ChangeInstructorsRoleName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                            ConcurrencyStamp = "9b54d771-387f-45ee-94d7-bc0d30676fe9",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                            ConcurrencyStamp = "2e58027a-a2e5-491d-b207-7a3fa94e41d1",
                            Name = "Instructor",
                            NormalizedName = "INSTRUCTOR"
                        },
                        new
                        {
                            Id = "2301D884-221A-4E7D-B509-0113DCC043E1",
                            ConcurrencyStamp = "ed29c4dd-bb54-4b71-9f1e-61485757120c",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                            RoleId = "2301D884-221A-4E7D-B509-0113DCC043E1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OSKManager.Model.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NumberOfTheBuilding")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Street")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("OSKManager.Model.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("BasicPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("CountOfDrivingHours")
                        .HasColumnType("int");

                    b.Property<int>("CountOfLectureHours")
                        .HasColumnType("int");

                    b.Property<string>("InstructorId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LongCategoryName")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ShortCategory")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d68a51f5-9f62-4de4-be09-85cb77d1e592"),
                            BasicPrice = 1500m,
                            CountOfDrivingHours = 20,
                            CountOfLectureHours = 30,
                            LongCategoryName = "Motocykl",
                            ShortCategory = "A"
                        },
                        new
                        {
                            Id = new Guid("7fba1061-11da-4088-a5f3-05c4752a5e5b"),
                            BasicPrice = 1700m,
                            CountOfDrivingHours = 30,
                            CountOfLectureHours = 30,
                            LongCategoryName = "Samochód Osobowy",
                            ShortCategory = "B"
                        },
                        new
                        {
                            Id = new Guid("9f7a263a-0bd7-4e9b-950e-6cbc67e05e32"),
                            BasicPrice = 2600m,
                            CountOfDrivingHours = 30,
                            CountOfLectureHours = 20,
                            LongCategoryName = "Samochód Ciężarowy",
                            ShortCategory = "C"
                        },
                        new
                        {
                            Id = new Guid("08dbea48-13e4-4bf6-89e7-475aeb96c8dc"),
                            BasicPrice = 4800m,
                            CountOfDrivingHours = 60,
                            CountOfLectureHours = 20,
                            LongCategoryName = "Autobus",
                            ShortCategory = "D"
                        });
                });

            modelBuilder.Entity("OSKManager.Model.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ActualPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("FinishedDrivingHours")
                        .HasColumnType("int");

                    b.Property<int>("FinishedLectureHours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StudentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OSKManager.Model.DrivingDate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("DrivingDate");
                });

            modelBuilder.Entity("OSKManager.Model.LectureDate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("LectureDate");
                });

            modelBuilder.Entity("OSKManager.Model.PkkNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Pkk")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StudentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("PkkNumber");
                });

            modelBuilder.Entity("OSKManager.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("OSKManager.Model.Administrator", b =>
                {
                    b.HasBaseType("OSKManager.Model.User");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("Administrator");

                    b.HasData(
                        new
                        {
                            Id = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "39665189-e90d-457f-9855-33963c879543",
                            Email = "Admin@Admin.com",
                            EmailConfirmed = false,
                            FirstName = "Master",
                            Gender = 0,
                            LastName = "Admin",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDHiguz0bGppyJwrZu1bby3A4KDzkDGsFcWBbiAweD1cGQIBRSYKPgPdqfys1WUOow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Admin@Admin.com"
                        });
                });

            modelBuilder.Entity("OSKManager.Model.Instructor", b =>
                {
                    b.HasBaseType("OSKManager.Model.User");

                    b.Property<DateTime?>("LicenceExpireTime")
                        .HasColumnType("datetime(6)");

                    b.HasDiscriminator().HasValue("Instructor");
                });

            modelBuilder.Entity("OSKManager.Model.Student", b =>
                {
                    b.HasBaseType("OSKManager.Model.User");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InstructorId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("PersonalIdNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasIndex("InstructorId");

                    b.HasDiscriminator().HasValue("Student");
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
                    b.HasOne("OSKManager.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OSKManager.Model.User", null)
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

                    b.HasOne("OSKManager.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OSKManager.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSKManager.Model.Category", b =>
                {
                    b.HasOne("OSKManager.Model.Instructor", null)
                        .WithMany("CategoryPermissions")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("OSKManager.Model.Course", b =>
                {
                    b.HasOne("OSKManager.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSKManager.Model.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("OSKManager.Model.DrivingDate", b =>
                {
                    b.HasOne("OSKManager.Model.Course", null)
                        .WithMany("DateOfDriving")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSKManager.Model.LectureDate", b =>
                {
                    b.HasOne("OSKManager.Model.Course", null)
                        .WithMany("DateOfLecture")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSKManager.Model.PkkNumber", b =>
                {
                    b.HasOne("OSKManager.Model.Student", null)
                        .WithMany("PkkNumber")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("OSKManager.Model.User", b =>
                {
                    b.HasOne("OSKManager.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("OSKManager.Model.Student", b =>
                {
                    b.HasOne("OSKManager.Model.Instructor", null)
                        .WithMany("Students")
                        .HasForeignKey("InstructorId");
                });
#pragma warning restore 612, 618
        }
    }
}