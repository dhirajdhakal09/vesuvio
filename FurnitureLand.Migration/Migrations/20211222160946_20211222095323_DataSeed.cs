using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureLand.DatabaseMigration.Migrations
{
    public partial class _20211222095323_DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("eb0d6332-94e1-497e-8574-c6d013396208"), "Desks" },
                    { new Guid("4ef87803-7b81-49fd-9c39-32b90b698573"), "Chairs" },
                    { new Guid("15747ed4-03c4-4fa7-bd10-f88e9f2216b9"), "Tables" },
                    { new Guid("c2fd6030-a09f-4294-bae3-b9d0980d00b7"), "File-Cabinets" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ae0538e-af73-45d7-95d0-02eb8409e918"), "Red" },
                    { new Guid("a24a5956-96c1-486b-acfb-f5f05a438328"), "Green" },
                    { new Guid("e9b3a640-7e80-4fe7-9edb-8bf0e95ad8bf"), "Blue" },
                    { new Guid("c71e4b47-4895-4f88-a557-8d7ad70a5dcb"), "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b31ed7ce-d993-4cb6-a57b-7efb1bd2b5e1"), "Corporate" },
                    { new Guid("ddfab8c4-1228-44fa-9532-d13d3eabe674"), "Home/Office" },
                    { new Guid("b5d61e15-edca-437e-86c9-1e3684dd98ae"), "School" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d45d9e94-ba33-4336-8d3c-c52716abafaa"), "Pine" },
                    { new Guid("d1f16582-fbd5-49c6-9fc6-918f2d156a1e"), "Milo" },
                    { new Guid("7f263d9f-a2de-404d-8dad-6a5c4a2f0704"), "Fiber" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("15747ed4-03c4-4fa7-bd10-f88e9f2216b9"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4ef87803-7b81-49fd-9c39-32b90b698573"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("c2fd6030-a09f-4294-bae3-b9d0980d00b7"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("eb0d6332-94e1-497e-8574-c6d013396208"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0ae0538e-af73-45d7-95d0-02eb8409e918"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a24a5956-96c1-486b-acfb-f5f05a438328"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c71e4b47-4895-4f88-a557-8d7ad70a5dcb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e9b3a640-7e80-4fe7-9edb-8bf0e95ad8bf"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("b31ed7ce-d993-4cb6-a57b-7efb1bd2b5e1"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("b5d61e15-edca-437e-86c9-1e3684dd98ae"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("ddfab8c4-1228-44fa-9532-d13d3eabe674"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("7f263d9f-a2de-404d-8dad-6a5c4a2f0704"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d1f16582-fbd5-49c6-9fc6-918f2d156a1e"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d45d9e94-ba33-4336-8d3c-c52716abafaa"));
        }
    }
}
