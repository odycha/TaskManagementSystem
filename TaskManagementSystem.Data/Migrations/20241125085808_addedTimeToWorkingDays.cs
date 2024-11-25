using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedTimeToWorkingDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndTime",
                table: "WorkingDays",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartTime",
                table: "WorkingDays",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndTime",
                table: "TaskTypes",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "StartTime",
                table: "TaskTypes",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827f01-662b-4641-abce-b1c496f28660",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc7272f0-889a-4b65-85df-9c6a4d082cb3", "AQAAAAIAAYagAAAAEP4H6NS3FzuvEkyYFur37E1ipQlJ1JP5Itkm5egTOcB+sPRA1ZPsB48xTKhBGc4vtw==", "9a801f02-db98-49af-bc14-939951992920" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102075be-a710-4035-87e0-25f7295074e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06b2ac01-5ebd-4d4b-8f4c-3bdcbe497c57", "AQAAAAIAAYagAAAAELCf5oxNTtb3tYZQ1l+8QHxyZFp7QZz2o6Df0BBR64edg2ALujcAgZP6CDs5Dnanhg==", "fd30ae0e-b4e4-42b8-8109-a23e58f98214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d630c06-b2bb-4918-9ce1-1acd5eef62fc", "AQAAAAIAAYagAAAAEMCAu0Pnnl7Hgb7L8KfU1UJrwDRLb/Xuxlqgk5I+Zs1zJCsHQ9ye+Riy85tc4kOg8A==", "00a724c2-62f7-491e-869a-1f6eb39bdab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "336722d0-5991-49a5-ab55-d7414b598c63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c11e07a3-4c3d-4dbf-a913-3b651632a55e", "AQAAAAIAAYagAAAAELNjpkG0WV00ePQ7rg5zEOBR2GhGFQ1z+M1c05QJosb2gfDwpLuY176ioQbhs4yrIw==", "6df7782b-55e3-4375-9086-b9a0a1db4f19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4dbb57-03af-4f90-ad57-98188cc9ebed", "AQAAAAIAAYagAAAAEDCSDOZTGFxMPemuQcVr2BDNQZLRE9pahQn7y604UMUgBphVlohZVJSkBl+bEfoxyw==", "9df909d3-9e05-4cd0-894f-738924e89e06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0014825b-f37b-4520-81f8-7e399a234202", "AQAAAAIAAYagAAAAEDS+4ZfJAoFwQNeppI5ER1uBoMjDYZOgTf+uXo3RCNmQTXU7IBOwm7vMAkHQb3JNmw==", "d20d8f82-9798-471c-910f-848a6480ac67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41469ae1-ff96-4b1b-909a-0fc7aceff783", "AQAAAAIAAYagAAAAEAxLo0KkNVJflcN8rDhRN4KRxDUQe8zltpTywGBI+qv94I9dJlbtkcCoFjA9J/VEUA==", "c7b0e93c-2f94-47ea-86f3-c083cc411741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "636be5a8-158d-4aa1-baf3-19e93ab5d3f9", "AQAAAAIAAYagAAAAEI+bbyYFvsyTpGaiuvKFsrLewGnP+ktZpKWk4ERat9+8VVuvG/c4cojphXMss6CtnA==", "94aabb5b-ebaf-45c8-8841-bf9790e3ddeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68ed7806-e19b-4610-8146-e999b0732379",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3069a2b1-0942-462c-9e8b-1797bc74d693", "AQAAAAIAAYagAAAAEKNh8SM0kigWOcJGaJyHF0Zk6IOBXQ4je2K+Ec6FyM3ItC2XIl2SPZFBnlo20IzFew==", "2dbea8b4-67f3-4a16-b0f0-84e34ea55078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "873d2b23-002a-477f-856e-5ed602b5405c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae20492-9b9f-4b03-a0c1-e6631cbfe8da", "AQAAAAIAAYagAAAAEHYf/wFWq/AWR/aV98AyN1jS6TLJAxmFicd2LRhMP8tB8Hw9zUzUr6VaRnFZ/tONdw==", "b465aa7a-0d11-48ca-8184-085798e049e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bae1bef-f5ee-402d-ae5f-882b551897dc", "AQAAAAIAAYagAAAAEJRDgNxuAnNYkZdJZalx2+6wBej1FTYm7f+SuApZ/Woae/l4HFcFBVefZvl3OQ9jWQ==", "e719dc3f-ac0b-4489-94b5-2653540285a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd65ce29-7600-446a-a89f-f3422bead07e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc9e3c4c-595e-4abe-85ad-182c22f6aa90", "AQAAAAIAAYagAAAAEMbzVkKp2BC7HnN9Fq2ZUUSjKCXf8zxgUPpg4ESeuLzQwNnpwrFKefNzepJqEaY19Q==", "6226a368-e0c1-4005-9193-0296ff4ba280" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "WorkingDays");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "WorkingDays");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "TaskTypes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827f01-662b-4641-abce-b1c496f28660",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb60589-9b17-411d-af2c-0853a97951cf", "AQAAAAIAAYagAAAAEDO4qvA5slwFB5oNldtLO6wUnMrmtcb1t5mWRDkHrrzjIgxIKErnVJbayriRwQoUgg==", "f97306f2-5919-4362-88a5-6bae0e13bfa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102075be-a710-4035-87e0-25f7295074e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60ec1abf-9b6a-42f3-b120-29e63933866d", "AQAAAAIAAYagAAAAEA25l1LKneC1Oi9L/KgO2Jy5eAJN3B6m9Zm6fqHXB2sN7pElSjHgU1E2bndBpkB4gw==", "cff6d478-37a8-4cd3-96ec-6adbcf198413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6603aacf-d9c6-4230-b4da-8dae21d47ef0", "AQAAAAIAAYagAAAAEFXXAtikvPc/26pTn8DfB7tfVtXpFOCm4P0yqoXAduy9Q2RVzchdRL4gpp3NydqlVQ==", "65ec27bb-c5a1-469f-9444-cf3e2a82e77c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "336722d0-5991-49a5-ab55-d7414b598c63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8901ffbd-42af-4c31-a444-9df582ed0837", "AQAAAAIAAYagAAAAEFPFHJ4ZLpCaAnBbqw85UNjoo3ALYmtGQ+nHhuELzs16vMA6twjWKSaE9jaGJy4j1A==", "7c63357f-3af8-4ac7-8d39-9300ec5aaf61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc646d3a-89d5-45eb-9ab2-c8ee6924813a", "AQAAAAIAAYagAAAAEBgA7iCEOwdfQPsa+v8lWcikrJbbqDqFuEG5Bwhvd2I2ndgiUMz8oJZ1H3augDrgZw==", "8db0ed89-1d40-4ddd-aa99-4b884d5412ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45dbe73-b370-4213-b827-ce6b161bd683", "AQAAAAIAAYagAAAAEPeLmP2sh/jv0+7EuMIrg2SGJWTr548xtORb+s/paw1iT4uQoUVhKeAJJLjzIxFoMQ==", "f262fbb8-a4d6-4abc-b6cd-0d9348bb273e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995ba181-e4d3-4558-8fb2-5d612f3f076c", "AQAAAAIAAYagAAAAEHAe6qnGOPRodQHKDjE6F1fZoR8g0RTuYrM8t/jJFPd0Qw6bp3YcQkl2LkdgQvVOvA==", "0d3476bb-99f9-4d0c-a44c-e740f4c1bd1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c18fcda-bc17-44a2-a6a8-1d4a43fb366a", "AQAAAAIAAYagAAAAEIPYlCu2H7oEbkTZM9cdONUSifrJYnI9hhihIPk5T5VuU50lWowaplQkdVBgyuMQZQ==", "1f7d7597-046e-470e-8985-ee9994a3d6ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68ed7806-e19b-4610-8146-e999b0732379",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde24738-a408-4eb5-b11c-7bdcc9f68bbe", "AQAAAAIAAYagAAAAEDLRiswTTxUknwDTYqisXFU2ak29Va2aYM/nFcYchb4M4XA2E3Cpw9f0y8O/2m7hjQ==", "85dabcf8-eaa7-4ec4-ac5b-4ef62300a206" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "873d2b23-002a-477f-856e-5ed602b5405c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea69883e-fe39-42cb-9d7c-0f9da6e3513b", "AQAAAAIAAYagAAAAEGz/38DZ8KqapMlxRhjU8iENPg6itI9um/8OocN4Uz8amNVhdqU7RKlVTWih7FCh1g==", "683ef482-bca9-4783-a397-24434ff0d5b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2736273a-27a9-46cc-b03e-9d2e521c76f8", "AQAAAAIAAYagAAAAEHPDYk26lraQFj4Ak5J60tTlVikSXsmIzofIZNSV+tTKVNNhSFuBNsX9qCniIj0oKg==", "dc81fe15-72c8-4700-905a-34fd21d0f5ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd65ce29-7600-446a-a89f-f3422bead07e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d0946f6-762a-44cf-bceb-57a7b431fe86", "AQAAAAIAAYagAAAAEBtIIFu+l5fVtD6SNZBgjuqumoW5X/AOghSTESuLnfdjHauxOi1sNIvml/ZxHd3O4Q==", "d1fb6e0c-eea5-4a85-bc5c-b873f378e688" });
        }
    }
}
