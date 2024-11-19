using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditedTaskTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TaskTypes");

            migrationBuilder.AddColumn<bool>(
                name: "Allocated",
                table: "TaskTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "TaskTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a820fceb-e3c8-4541-b350-1a552cd24a65", "AQAAAAIAAYagAAAAEEDbbeyjjY6XoJjKKjKgdwnLmgWmJ5BdhF3I7m5Qa/9Ocn7yA9bO+VcMTfmwg3LvUQ==", "cb73ce49-20b1-47c0-8388-5d0af19e5128" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allocated",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "TaskTypes");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndDate",
                table: "TaskTypes",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b25c3087-d3f1-45d9-b6bf-9d0c70dab31b", "AQAAAAIAAYagAAAAEMryg18x6DPQcJB1F6OZDwNjlLWD6xtBw73vIHmU/sPl4ID70Dgb3Fi9mVR1ObRoUA==", "4b4c3d44-5343-4d67-9d63-edccf720a7b2" });
        }
    }
}
