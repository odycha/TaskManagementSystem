using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class WorkingDaysTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkingDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateOnly>(type: "date", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDays", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef7e3c1-1f7d-4aea-8970-badc3b12a939", "AQAAAAIAAYagAAAAEHpEChAI7oxFCH9p0GKZOpXigLtVmquaI73Bo3C0p9uyi91dicF3Y0dy4a+cVJmO4g==", "d503b8fc-4846-4f40-993d-7cc6e976fd28" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingDays");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e896928e-0e1d-4078-8fce-0d38290aadd9", "AQAAAAIAAYagAAAAEKIra37gpw4EVcfpUsuK6hjEDu1Fmr8lTTe4O2qvJWRajrgsjU8Qlin7nZdYnxPQTg==", "cfbf5c51-7a77-4cbb-baf2-08cab1d2ac47" });
        }
    }
}
