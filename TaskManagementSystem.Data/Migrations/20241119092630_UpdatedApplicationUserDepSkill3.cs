using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApplicationUserDepSkill3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "DepartmentName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a989b1-6874-49c2-8fc7-93ebe5e7caef", "IT Support", "AQAAAAIAAYagAAAAEDg6g5Jx1hskbDMqkOtzAxVmiBTWUDz0TtRX2eW19OnGIOJsng+j3iFLD0QDNyr7lw==", "883acaf7-ba21-424c-bbf3-1d38415c1d79" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "DepartmentName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72fc1105-0345-44c4-bb2d-bbdef1b2ba7e", "IT", "AQAAAAIAAYagAAAAEGmc8+qNaO9MTbvUE02Oa+8ypI5gjH2oBX7M3nn9SWs5E4q5J/1YLP5Ry2QGyuBwTQ==", "eb7bd705-7df8-4692-ad99-2fc9f28f6cb2" });
        }
    }
}
