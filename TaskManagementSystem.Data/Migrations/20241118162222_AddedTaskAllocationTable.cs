using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedTaskAllocationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkingDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAllocations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAllocations_TaskTypes_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAllocations_WorkingDays_WorkingDayId",
                        column: x => x.WorkingDayId,
                        principalTable: "WorkingDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b25c3087-d3f1-45d9-b6bf-9d0c70dab31b", "AQAAAAIAAYagAAAAEMryg18x6DPQcJB1F6OZDwNjlLWD6xtBw73vIHmU/sPl4ID70Dgb3Fi9mVR1ObRoUA==", "4b4c3d44-5343-4d67-9d63-edccf720a7b2" });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAllocations_EmployeeId",
                table: "TaskAllocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAllocations_TaskTypeId",
                table: "TaskAllocations",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAllocations_WorkingDayId",
                table: "TaskAllocations",
                column: "WorkingDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e8ec2c8-c653-4669-a7b4-e8f28730e619", "AQAAAAIAAYagAAAAEDXz+AVQhL8Kf9L8nKTyHFX34rwb5dhhu0vW6mFFwu9OloQ2b11Ms7zSgSAIt5yoIg==", "de7f49a1-d6b9-4195-9363-c830d5bf9ac1" });
        }
    }
}
