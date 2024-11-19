using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApplicationUserDepSkill2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72fc1105-0345-44c4-bb2d-bbdef1b2ba7e", "AQAAAAIAAYagAAAAEGmc8+qNaO9MTbvUE02Oa+8ypI5gjH2oBX7M3nn9SWs5E4q5J/1YLP5Ry2QGyuBwTQ==", "eb7bd705-7df8-4692-ad99-2fc9f28f6cb2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bace888b-741a-4fc1-b4c5-85cc0b541461", "AQAAAAIAAYagAAAAEF0zPb1alS5iDieaH9PUpeghTlRJjMZ+9sXz0B1qkhBu8lNd72L61i0dhVJurcyoSQ==", "6da7aadb-67d2-4c64-9443-f11cfa9d16eb" });
        }
    }
}
