using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", null, "Employee", "EMPLOYEE" },
                    { "335f4107-9914-4d65-9542-92db92194c0b", null, "TaskManager", "TASKMANAGER" },
                    { "e15ce2eb-3781-4351-a205-dc133f889d57", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "384df32d-2a7c-4147-baf1-152db746565b", 0, "e896928e-0e1d-4078-8fce-0d38290aadd9", new DateOnly(2024, 11, 15), "admin@localhost.com", true, "admin", "admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKIra37gpw4EVcfpUsuK6hjEDu1Fmr8lTTe4O2qvJWRajrgsjU8Qlin7nZdYnxPQTg==", null, false, "cfbf5c51-7a77-4cbb-baf2-08cab1d2ac47", false, "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29d8720e-11e4-466c-9b6f-ced906a1cf47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "335f4107-9914-4d65-9542-92db92194c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e15ce2eb-3781-4351-a205-dc133f889d57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b");
        }
    }
}
