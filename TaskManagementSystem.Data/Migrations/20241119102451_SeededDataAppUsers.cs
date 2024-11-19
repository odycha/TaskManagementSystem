using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededDataAppUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45dbe73-b370-4213-b827-ce6b161bd683", "AQAAAAIAAYagAAAAEPeLmP2sh/jv0+7EuMIrg2SGJWTr548xtORb+s/paw1iT4uQoUVhKeAJJLjzIxFoMQ==", "f262fbb8-a4d6-4abc-b6cd-0d9348bb273e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DepartmentName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SkillLevel", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06827f01-662b-4641-abce-b1c496f28660", 0, "3bb60589-9b17-411d-af2c-0853a97951cf", new DateOnly(1999, 11, 15), "Development", "empl4@localhost.com", true, "empl4", "empl4", false, null, "EMPL4@LOCALHOST.COM", "EMPL4@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDO4qvA5slwFB5oNldtLO6wUnMrmtcb1t5mWRDkHrrzjIgxIKErnVJbayriRwQoUgg==", null, false, "f97306f2-5919-4362-88a5-6bae0e13bfa3", 10, false, "empl4@localhost.com" },
                    { "102075be-a710-4035-87e0-25f7295074e6", 0, "60ec1abf-9b6a-42f3-b120-29e63933866d", new DateOnly(1999, 7, 22), "Marketing", "empl10@localhost.com", true, "empl10", "empl10", false, null, "EMPL10@LOCALHOST.COM", "EMPL10@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA25l1LKneC1Oi9L/KgO2Jy5eAJN3B6m9Zm6fqHXB2sN7pElSjHgU1E2bndBpkB4gw==", null, false, "cff6d478-37a8-4cd3-96ec-6adbcf198413", 6, false, "empl10@localhost.com" },
                    { "16914ec6-4686-4c2c-ba58-5a9c3c15f404", 0, "6603aacf-d9c6-4230-b4da-8dae21d47ef0", new DateOnly(2024, 11, 15), "IT Support", "taskManager@localhost.com", true, "taskManager", "taskManager", false, null, "TASKMANAGER@LOCALHOST.COM", "TASKMANAGER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFXXAtikvPc/26pTn8DfB7tfVtXpFOCm4P0yqoXAduy9Q2RVzchdRL4gpp3NydqlVQ==", null, false, "65ec27bb-c5a1-469f-9444-cf3e2a82e77c", 10, false, "taskManager@localhost.com" },
                    { "336722d0-5991-49a5-ab55-d7414b598c63", 0, "8901ffbd-42af-4c31-a444-9df582ed0837", new DateOnly(1997, 8, 8), "Marketing", "empl8@localhost.com", true, "empl8", "empl8", false, null, "EMPL8@LOCALHOST.COM", "EMPL8@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFPFHJ4ZLpCaAnBbqw85UNjoo3ALYmtGQ+nHhuELzs16vMA6twjWKSaE9jaGJy4j1A==", null, false, "7c63357f-3af8-4ac7-8d39-9300ec5aaf61", 10, false, "empl8@localhost.com" },
                    { "37bded91-485a-44b5-bbc7-53e5be7c3d0b", 0, "fc646d3a-89d5-45eb-9ab2-c8ee6924813a", new DateOnly(1999, 3, 22), "Development", "empl6@localhost.com", true, "empl6", "empl6", false, null, "EMPL6@LOCALHOST.COM", "EMPL6@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBgA7iCEOwdfQPsa+v8lWcikrJbbqDqFuEG5Bwhvd2I2ndgiUMz8oJZ1H3augDrgZw==", null, false, "8db0ed89-1d40-4ddd-aa99-4b884d5412ec", 7, false, "empl6@localhost.com" },
                    { "4c5d1a8e-4f28-4ed5-8427-b72f0df86619", 0, "995ba181-e4d3-4558-8fb2-5d612f3f076c", new DateOnly(1998, 11, 20), "IT Support", "empl1@localhost.com", true, "empl1", "empl1", false, null, "EMPL1@LOCALHOST.COM", "EMPL1@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHAe6qnGOPRodQHKDjE6F1fZoR8g0RTuYrM8t/jJFPd0Qw6bp3YcQkl2LkdgQvVOvA==", null, false, "0d3476bb-99f9-4d0c-a44c-e740f4c1bd1e", 7, false, "empl1@localhost.com" },
                    { "4d7b0c08-5565-420b-854e-10e8b3ea69d6", 0, "5c18fcda-bc17-44a2-a6a8-1d4a43fb366a", new DateOnly(1995, 1, 15), "IT Support", "empl3@localhost.com", true, "empl3", "empl3", false, null, "EMPL3@LOCALHOST.COM", "EMPL3@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIPYlCu2H7oEbkTZM9cdONUSifrJYnI9hhihIPk5T5VuU50lWowaplQkdVBgyuMQZQ==", null, false, "1f7d7597-046e-470e-8985-ee9994a3d6ec", 6, false, "empl3@localhost.com" },
                    { "68ed7806-e19b-4610-8146-e999b0732379", 0, "cde24738-a408-4eb5-b11c-7bdcc9f68bbe", new DateOnly(1990, 11, 15), "IT Support", "empl2@localhost.com", true, "empl2", "empl2", false, null, "EMPL2@LOCALHOST.COM", "EMPL2@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDLRiswTTxUknwDTYqisXFU2ak29Va2aYM/nFcYchb4M4XA2E3Cpw9f0y8O/2m7hjQ==", null, false, "85dabcf8-eaa7-4ec4-ac5b-4ef62300a206", 9, false, "empl2@localhost.com" },
                    { "873d2b23-002a-477f-856e-5ed602b5405c", 0, "ea69883e-fe39-42cb-9d7c-0f9da6e3513b", new DateOnly(1980, 10, 20), "Development", "empl7@localhost.com", true, "empl7", "empl7", false, null, "EMPL7@LOCALHOST.COM", "EMPL7@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGz/38DZ8KqapMlxRhjU8iENPg6itI9um/8OocN4Uz8amNVhdqU7RKlVTWih7FCh1g==", null, false, "683ef482-bca9-4783-a397-24434ff0d5b1", 7, false, "empl7@localhost.com" },
                    { "d15c6625-2ded-49e4-b8b9-1f1738a696e3", 0, "2736273a-27a9-46cc-b03e-9d2e521c76f8", new DateOnly(1989, 11, 15), "Marketing", "empl9@localhost.com", true, "empl9", "empl9", false, null, "EMPL9@LOCALHOST.COM", "EMPL9@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHPDYk26lraQFj4Ak5J60tTlVikSXsmIzofIZNSV+tTKVNNhSFuBNsX9qCniIj0oKg==", null, false, "dc81fe15-72c8-4700-905a-34fd21d0f5ef", 7, false, "empl9@localhost.com" },
                    { "fd65ce29-7600-446a-a89f-f3422bead07e", 0, "6d0946f6-762a-44cf-bceb-57a7b431fe86", new DateOnly(2000, 11, 15), "Development", "empl5@localhost.com", true, "empl5", "empl5", false, null, "EMPL5@LOCALHOST.COM", "EMPL5@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBtIIFu+l5fVtD6SNZBgjuqumoW5X/AOghSTESuLnfdjHauxOi1sNIvml/ZxHd3O4Q==", null, false, "d1fb6e0c-eea5-4a85-bc5c-b873f378e688", 6, false, "empl5@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "06827f01-662b-4641-abce-b1c496f28660" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "102075be-a710-4035-87e0-25f7295074e6" },
                    { "335f4107-9914-4d65-9542-92db92194c0b", "16914ec6-4686-4c2c-ba58-5a9c3c15f404" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "336722d0-5991-49a5-ab55-d7414b598c63" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "37bded91-485a-44b5-bbc7-53e5be7c3d0b" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "4c5d1a8e-4f28-4ed5-8427-b72f0df86619" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "4d7b0c08-5565-420b-854e-10e8b3ea69d6" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "68ed7806-e19b-4610-8146-e999b0732379" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "873d2b23-002a-477f-856e-5ed602b5405c" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "d15c6625-2ded-49e4-b8b9-1f1738a696e3" },
                    { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "fd65ce29-7600-446a-a89f-f3422bead07e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "06827f01-662b-4641-abce-b1c496f28660" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "102075be-a710-4035-87e0-25f7295074e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "335f4107-9914-4d65-9542-92db92194c0b", "16914ec6-4686-4c2c-ba58-5a9c3c15f404" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "336722d0-5991-49a5-ab55-d7414b598c63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "37bded91-485a-44b5-bbc7-53e5be7c3d0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "4c5d1a8e-4f28-4ed5-8427-b72f0df86619" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "4d7b0c08-5565-420b-854e-10e8b3ea69d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "68ed7806-e19b-4610-8146-e999b0732379" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "873d2b23-002a-477f-856e-5ed602b5405c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "d15c6625-2ded-49e4-b8b9-1f1738a696e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29d8720e-11e4-466c-9b6f-ced906a1cf47", "fd65ce29-7600-446a-a89f-f3422bead07e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827f01-662b-4641-abce-b1c496f28660");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102075be-a710-4035-87e0-25f7295074e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16914ec6-4686-4c2c-ba58-5a9c3c15f404");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "336722d0-5991-49a5-ab55-d7414b598c63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bded91-485a-44b5-bbc7-53e5be7c3d0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5d1a8e-4f28-4ed5-8427-b72f0df86619");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d7b0c08-5565-420b-854e-10e8b3ea69d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68ed7806-e19b-4610-8146-e999b0732379");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "873d2b23-002a-477f-856e-5ed602b5405c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15c6625-2ded-49e4-b8b9-1f1738a696e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd65ce29-7600-446a-a89f-f3422bead07e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a989b1-6874-49c2-8fc7-93ebe5e7caef", "AQAAAAIAAYagAAAAEDg6g5Jx1hskbDMqkOtzAxVmiBTWUDz0TtRX2eW19OnGIOJsng+j3iFLD0QDNyr7lw==", "883acaf7-ba21-424c-bbf3-1d38415c1d79" });
        }
    }
}
