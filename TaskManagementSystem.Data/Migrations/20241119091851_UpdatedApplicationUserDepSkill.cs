using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedApplicationUserDepSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "DepartmentName", "PasswordHash", "SecurityStamp", "SkillLevel" },
                values: new object[] { "bace888b-741a-4fc1-b4c5-85cc0b541461", "IT", "AQAAAAIAAYagAAAAEF0zPb1alS5iDieaH9PUpeghTlRJjMZ+9sXz0B1qkhBu8lNd72L61i0dhVJurcyoSQ==", "6da7aadb-67d2-4c64-9443-f11cfa9d16eb", 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f3aafd-75ee-4bda-b36a-1b08b9054bc2", "AQAAAAIAAYagAAAAEP6zkffk8AwG6X3+CvjOJUhh1Y45HN+UcEsRM0l8waLjnX/mojT/Vs4Lo1mvPrrodg==", "45a669c6-af6a-47b5-8a80-e3b347344bff" });
        }
    }
}
