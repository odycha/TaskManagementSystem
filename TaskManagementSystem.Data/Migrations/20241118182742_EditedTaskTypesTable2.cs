using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditedTaskTypesTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskAllocations_TaskTypeId",
                table: "TaskAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f3aafd-75ee-4bda-b36a-1b08b9054bc2", "AQAAAAIAAYagAAAAEP6zkffk8AwG6X3+CvjOJUhh1Y45HN+UcEsRM0l8waLjnX/mojT/Vs4Lo1mvPrrodg==", "45a669c6-af6a-47b5-8a80-e3b347344bff" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAllocations_TaskTypeId",
                table: "TaskAllocations",
                column: "TaskTypeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaskAllocations_TaskTypeId",
                table: "TaskAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a820fceb-e3c8-4541-b350-1a552cd24a65", "AQAAAAIAAYagAAAAEEDbbeyjjY6XoJjKKjKgdwnLmgWmJ5BdhF3I7m5Qa/9Ocn7yA9bO+VcMTfmwg3LvUQ==", "cb73ce49-20b1-47c0-8388-5d0af19e5128" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAllocations_TaskTypeId",
                table: "TaskAllocations",
                column: "TaskTypeId");
        }
    }
}
