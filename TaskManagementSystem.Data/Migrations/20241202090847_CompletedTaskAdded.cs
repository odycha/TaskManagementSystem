using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompletedTaskAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "TaskTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827f01-662b-4641-abce-b1c496f28660",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff80122-4e2a-4971-8f3b-2288249508ff", "AQAAAAIAAYagAAAAEPLEawc/NRhXqK0Z26hRTMjPmEmsT8kmObbvcq4caJqkAllltvOFhwcpn2jWC3XZWg==", "1a1491f7-15ec-4d1b-84bb-c4476e639523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102075be-a710-4035-87e0-25f7295074e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d73798e8-8c54-48ab-aca5-b7ac0dcb1951", "AQAAAAIAAYagAAAAEOGEhGOKy+cbvFvdJjfFY/Ho1oV09jggF+xmFD1uLuAYI8Tf0PCuaXNKLrkRl5n1Hg==", "dff7cc3e-8fee-4f6f-b395-e28d2e047602" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16914ec6-4686-4c2c-ba58-5a9c3c15f404",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84d5b001-1e37-47e3-9fd0-85d817b26736", "AQAAAAIAAYagAAAAEH9lmLy/9T/WqPVlpAJqoAJo8/gsNyKSUeHYsMuaUadEZzdohUImlGK+s5a6jUvyPg==", "a665d0fc-12a3-48aa-8f9a-4fcc861ee380" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "336722d0-5991-49a5-ab55-d7414b598c63",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3171e59-3189-4561-b4f9-ce7d98737453", "AQAAAAIAAYagAAAAED1fUS2PB1xBe9H6XnY0utVD4gRNFipD9uq6j1Zz6QlbdvMcEGKq+6K0ZDoVHmfxKw==", "451d6de7-b375-4b77-b3c0-4ee9f25b088f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bded91-485a-44b5-bbc7-53e5be7c3d0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ab4df9-73ad-47a0-9cc3-55a6ee184171", "AQAAAAIAAYagAAAAEMPe2I30bF94MprlfGA/f1kk9n/BNn3pXtIr1opU2VFtJ3dSGjepIqnjVbey8YHYyw==", "4915ccd7-dbc9-4326-8565-b4fd6b33e883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "384df32d-2a7c-4147-baf1-152db746565b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98e5792b-3d6f-4fa0-94a1-3a81165173c1", "AQAAAAIAAYagAAAAELhGToqUZ1miCN8GjPEjK2x40sbS7fO/NKVzycl2FjUlDt7sbsAp7EwiFgn4aRiJTQ==", "69da5c2b-5c5f-4a40-a703-e7083b510e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5d1a8e-4f28-4ed5-8427-b72f0df86619",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4387fd-974f-4065-99e8-098de422615f", "AQAAAAIAAYagAAAAENd1pVm+uAZggJ4v/OhjSxikRDtUEigQB2TSS7xdF7ETnn0zakKkckPAHd4WfEIg5w==", "71775b8d-daa5-49f7-8367-e9f3c812ceae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d7b0c08-5565-420b-854e-10e8b3ea69d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7ed5c89-9d3e-4f01-8964-4c96d1a33611", "AQAAAAIAAYagAAAAEJAAc6bWvxYT5IyFC9U2d9vhzS83GxNydE+yflVozyastqhQ7/zI8IAsj8tU9yWrQg==", "d1d6c765-778b-442d-bd6a-7f4ccbabc0db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68ed7806-e19b-4610-8146-e999b0732379",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba2237d6-585e-4c3c-b70e-735439f70d56", "AQAAAAIAAYagAAAAEPsK9ACf8j1779UAVK+kUrsYPlXlK5a6cGM9U+K2mtQ2P6LwGgtQN3IhSJ18AvUZ1A==", "0638404b-f9af-43c1-882a-f139878b334a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "873d2b23-002a-477f-856e-5ed602b5405c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c7387b8-71e2-4e40-aad0-de2a7896c5bc", "AQAAAAIAAYagAAAAEF29DfCW1dF/PE3e8Sy9bfGLxXusK1BFg0l01Tyv+s3IUWmu6xWW9NCgW61tirfbrw==", "58e0ebfa-05d2-4bef-bc83-a529d8d435df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15c6625-2ded-49e4-b8b9-1f1738a696e3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c041e0-f8a6-4eae-ad0e-cdb4312d0da6", "AQAAAAIAAYagAAAAEHRdBQ28DXlGChkMO2vqzHuM8ndMDhzCTV5qsbg6Z7G71ba7bIuvj7s9Zup7k5K/0A==", "02d15c54-f2e2-4c94-b63c-f195a069716c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd65ce29-7600-446a-a89f-f3422bead07e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36492032-a40d-468e-8d12-bd1a5d54695d", "AQAAAAIAAYagAAAAEJFjjwL0NPmOt2g1p2bJvEgkX4+fPYYnOitlbpvc3mtQ/9wi/DQdTPC0diHtUg7AnA==", "ccefc07c-12ca-4fd2-b05b-fd916248c20c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "TaskTypes");

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
    }
}
