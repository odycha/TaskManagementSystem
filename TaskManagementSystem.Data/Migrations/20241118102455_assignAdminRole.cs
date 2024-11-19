using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class assignAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e15ce2eb-3781-4351-a205-dc133f889d57", "384df32d-2a7c-4147-baf1-152db746565b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8ec2c8-c653-4669-a7b4-e8f28730e619", "AQAAAAIAAYagAAAAEDXz+AVQhL8Kf9L8nKTyHFX34rwb5dhhu0vW6mFFwu9OloQ2b11Ms7zSgSAIt5yoIg==", "de7f49a1-d6b9-4195-9363-c830d5bf9ac1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e15ce2eb-3781-4351-a205-dc133f889d57", "384df32d-2a7c-4147-baf1-152db746565b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef7e3c1-1f7d-4aea-8970-badc3b12a939", "AQAAAAIAAYagAAAAEHpEChAI7oxFCH9p0GKZOpXigLtVmquaI73Bo3C0p9uyi91dicF3Y0dy4a+cVJmO4g==", "d503b8fc-4846-4f40-993d-7cc6e976fd28" });
        }
    }
}
