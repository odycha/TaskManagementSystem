﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagementSystem.Data;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241202090847_CompletedTaskAdded")]
    partial class CompletedTaskAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasData(
                        new
                        {
                            Id = "e15ce2eb-3781-4351-a205-dc133f889d57",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "335f4107-9914-4d65-9542-92db92194c0b",
                            Name = "TaskManager",
                            NormalizedName = "TASKMANAGER"
                        },
                        new
                        {
                            Id = "29d8720e-11e4-466c-9b6f-ced906a1cf47",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            UserId = "384df32d-2a7c-4147-baf1-152db746565b",
                            RoleId = "e15ce2eb-3781-4351-a205-dc133f889d57"
                        },
                        new
                        {
                            UserId = "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                            RoleId = "335f4107-9914-4d65-9542-92db92194c0b"
                        },
                        new
                        {
                            UserId = "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "68ed7806-e19b-4610-8146-e999b0732379",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "06827f01-662b-4641-abce-b1c496f28660",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "fd65ce29-7600-446a-a89f-f3422bead07e",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "873d2b23-002a-477f-856e-5ed602b5405c",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "336722d0-5991-49a5-ab55-d7414b598c63",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        },
                        new
                        {
                            UserId = "102075be-a710-4035-87e0-25f7295074e6",
                            RoleId = "29d8720e-11e4-466c-9b6f-ced906a1cf47"
                        });
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

            modelBuilder.Entity("TaskManagementSystem.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("SkillLevel")
                        .HasColumnType("int");

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

                    b.HasData(
                        new
                        {
                            Id = "384df32d-2a7c-4147-baf1-152db746565b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "98e5792b-3d6f-4fa0-94a1-3a81165173c1",
                            DateOfBirth = new DateOnly(2024, 11, 15),
                            DepartmentName = "IT Support",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELhGToqUZ1miCN8GjPEjK2x40sbS7fO/NKVzycl2FjUlDt7sbsAp7EwiFgn4aRiJTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "69da5c2b-5c5f-4a40-a703-e7083b510e71",
                            SkillLevel = 10,
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "84d5b001-1e37-47e3-9fd0-85d817b26736",
                            DateOfBirth = new DateOnly(2024, 11, 15),
                            DepartmentName = "IT Support",
                            Email = "taskManager@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "taskManager",
                            LastName = "taskManager",
                            LockoutEnabled = false,
                            NormalizedEmail = "TASKMANAGER@LOCALHOST.COM",
                            NormalizedUserName = "TASKMANAGER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEH9lmLy/9T/WqPVlpAJqoAJo8/gsNyKSUeHYsMuaUadEZzdohUImlGK+s5a6jUvyPg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a665d0fc-12a3-48aa-8f9a-4fcc861ee380",
                            SkillLevel = 10,
                            TwoFactorEnabled = false,
                            UserName = "taskManager@localhost.com"
                        },
                        new
                        {
                            Id = "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf4387fd-974f-4065-99e8-098de422615f",
                            DateOfBirth = new DateOnly(1998, 11, 20),
                            DepartmentName = "IT Support",
                            Email = "empl1@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl1",
                            LastName = "empl1",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL1@LOCALHOST.COM",
                            NormalizedUserName = "EMPL1@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENd1pVm+uAZggJ4v/OhjSxikRDtUEigQB2TSS7xdF7ETnn0zakKkckPAHd4WfEIg5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71775b8d-daa5-49f7-8367-e9f3c812ceae",
                            SkillLevel = 7,
                            TwoFactorEnabled = false,
                            UserName = "empl1@localhost.com"
                        },
                        new
                        {
                            Id = "68ed7806-e19b-4610-8146-e999b0732379",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba2237d6-585e-4c3c-b70e-735439f70d56",
                            DateOfBirth = new DateOnly(1990, 11, 15),
                            DepartmentName = "IT Support",
                            Email = "empl2@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl2",
                            LastName = "empl2",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL2@LOCALHOST.COM",
                            NormalizedUserName = "EMPL2@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPsK9ACf8j1779UAVK+kUrsYPlXlK5a6cGM9U+K2mtQ2P6LwGgtQN3IhSJ18AvUZ1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0638404b-f9af-43c1-882a-f139878b334a",
                            SkillLevel = 9,
                            TwoFactorEnabled = false,
                            UserName = "empl2@localhost.com"
                        },
                        new
                        {
                            Id = "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7ed5c89-9d3e-4f01-8964-4c96d1a33611",
                            DateOfBirth = new DateOnly(1995, 1, 15),
                            DepartmentName = "IT Support",
                            Email = "empl3@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl3",
                            LastName = "empl3",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL3@LOCALHOST.COM",
                            NormalizedUserName = "EMPL3@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJAAc6bWvxYT5IyFC9U2d9vhzS83GxNydE+yflVozyastqhQ7/zI8IAsj8tU9yWrQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d1d6c765-778b-442d-bd6a-7f4ccbabc0db",
                            SkillLevel = 6,
                            TwoFactorEnabled = false,
                            UserName = "empl3@localhost.com"
                        },
                        new
                        {
                            Id = "06827f01-662b-4641-abce-b1c496f28660",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ff80122-4e2a-4971-8f3b-2288249508ff",
                            DateOfBirth = new DateOnly(1999, 11, 15),
                            DepartmentName = "Development",
                            Email = "empl4@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl4",
                            LastName = "empl4",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL4@LOCALHOST.COM",
                            NormalizedUserName = "EMPL4@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPLEawc/NRhXqK0Z26hRTMjPmEmsT8kmObbvcq4caJqkAllltvOFhwcpn2jWC3XZWg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1a1491f7-15ec-4d1b-84bb-c4476e639523",
                            SkillLevel = 10,
                            TwoFactorEnabled = false,
                            UserName = "empl4@localhost.com"
                        },
                        new
                        {
                            Id = "fd65ce29-7600-446a-a89f-f3422bead07e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36492032-a40d-468e-8d12-bd1a5d54695d",
                            DateOfBirth = new DateOnly(2000, 11, 15),
                            DepartmentName = "Development",
                            Email = "empl5@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl5",
                            LastName = "empl5",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL5@LOCALHOST.COM",
                            NormalizedUserName = "EMPL5@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJFjjwL0NPmOt2g1p2bJvEgkX4+fPYYnOitlbpvc3mtQ/9wi/DQdTPC0diHtUg7AnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ccefc07c-12ca-4fd2-b05b-fd916248c20c",
                            SkillLevel = 6,
                            TwoFactorEnabled = false,
                            UserName = "empl5@localhost.com"
                        },
                        new
                        {
                            Id = "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88ab4df9-73ad-47a0-9cc3-55a6ee184171",
                            DateOfBirth = new DateOnly(1999, 3, 22),
                            DepartmentName = "Development",
                            Email = "empl6@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl6",
                            LastName = "empl6",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL6@LOCALHOST.COM",
                            NormalizedUserName = "EMPL6@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMPe2I30bF94MprlfGA/f1kk9n/BNn3pXtIr1opU2VFtJ3dSGjepIqnjVbey8YHYyw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4915ccd7-dbc9-4326-8565-b4fd6b33e883",
                            SkillLevel = 7,
                            TwoFactorEnabled = false,
                            UserName = "empl6@localhost.com"
                        },
                        new
                        {
                            Id = "873d2b23-002a-477f-856e-5ed602b5405c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9c7387b8-71e2-4e40-aad0-de2a7896c5bc",
                            DateOfBirth = new DateOnly(1980, 10, 20),
                            DepartmentName = "Development",
                            Email = "empl7@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl7",
                            LastName = "empl7",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL7@LOCALHOST.COM",
                            NormalizedUserName = "EMPL7@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEF29DfCW1dF/PE3e8Sy9bfGLxXusK1BFg0l01Tyv+s3IUWmu6xWW9NCgW61tirfbrw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "58e0ebfa-05d2-4bef-bc83-a529d8d435df",
                            SkillLevel = 7,
                            TwoFactorEnabled = false,
                            UserName = "empl7@localhost.com"
                        },
                        new
                        {
                            Id = "336722d0-5991-49a5-ab55-d7414b598c63",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d3171e59-3189-4561-b4f9-ce7d98737453",
                            DateOfBirth = new DateOnly(1997, 8, 8),
                            DepartmentName = "Marketing",
                            Email = "empl8@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl8",
                            LastName = "empl8",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL8@LOCALHOST.COM",
                            NormalizedUserName = "EMPL8@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED1fUS2PB1xBe9H6XnY0utVD4gRNFipD9uq6j1Zz6QlbdvMcEGKq+6K0ZDoVHmfxKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "451d6de7-b375-4b77-b3c0-4ee9f25b088f",
                            SkillLevel = 10,
                            TwoFactorEnabled = false,
                            UserName = "empl8@localhost.com"
                        },
                        new
                        {
                            Id = "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "25c041e0-f8a6-4eae-ad0e-cdb4312d0da6",
                            DateOfBirth = new DateOnly(1989, 11, 15),
                            DepartmentName = "Marketing",
                            Email = "empl9@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl9",
                            LastName = "empl9",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL9@LOCALHOST.COM",
                            NormalizedUserName = "EMPL9@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHRdBQ28DXlGChkMO2vqzHuM8ndMDhzCTV5qsbg6Z7G71ba7bIuvj7s9Zup7k5K/0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02d15c54-f2e2-4c94-b63c-f195a069716c",
                            SkillLevel = 7,
                            TwoFactorEnabled = false,
                            UserName = "empl9@localhost.com"
                        },
                        new
                        {
                            Id = "102075be-a710-4035-87e0-25f7295074e6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d73798e8-8c54-48ab-aca5-b7ac0dcb1951",
                            DateOfBirth = new DateOnly(1999, 7, 22),
                            DepartmentName = "Marketing",
                            Email = "empl10@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "empl10",
                            LastName = "empl10",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPL10@LOCALHOST.COM",
                            NormalizedUserName = "EMPL10@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOGEhGOKy+cbvFvdJjfFY/Ho1oV09jggF+xmFD1uLuAYI8Tf0PCuaXNKLrkRl5n1Hg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dff7cc3e-8fee-4f6f-b395-e28d2e047602",
                            SkillLevel = 6,
                            TwoFactorEnabled = false,
                            UserName = "empl10@localhost.com"
                        });
                });

            modelBuilder.Entity("TaskManagementSystem.Data.TaskAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TaskTypeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkingDayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskTypeId")
                        .IsUnique();

                    b.HasIndex("WorkingDayId");

                    b.ToTable("TaskAllocations");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Allocated")
                        .HasColumnType("bit");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("SkillLevel")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.WorkingDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Day")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("WorkingDays");
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
                    b.HasOne("TaskManagementSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.ApplicationUser", null)
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

                    b.HasOne("TaskManagementSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManagementSystem.Data.TaskAllocation", b =>
                {
                    b.HasOne("TaskManagementSystem.Data.ApplicationUser", "Employee")
                        .WithMany("TaskAllocations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.TaskType", "TaskType")
                        .WithOne("TaskAllocation")
                        .HasForeignKey("TaskManagementSystem.Data.TaskAllocation", "TaskTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManagementSystem.Data.WorkingDay", "WorkingDay")
                        .WithMany()
                        .HasForeignKey("WorkingDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("TaskType");

                    b.Navigation("WorkingDay");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.ApplicationUser", b =>
                {
                    b.Navigation("TaskAllocations");
                });

            modelBuilder.Entity("TaskManagementSystem.Data.TaskType", b =>
                {
                    b.Navigation("TaskAllocation");
                });
#pragma warning restore 612, 618
        }
    }
}
