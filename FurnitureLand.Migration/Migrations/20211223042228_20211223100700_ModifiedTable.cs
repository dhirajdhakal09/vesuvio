using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureLand.DatabaseMigration.Migrations
{
    public partial class _20211223100700_ModifiedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4506d5a0-e453-4eb5-bd5c-32c255b0c93b"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("9ba8803d-04f2-49b1-991b-0e3979c7e957"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b273c72f-b914-4007-91b6-380f78db14d4"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("edc89773-eeaa-4a8d-ac40-14e0c881f76a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("38b34311-4dde-4c38-8284-298b07061da7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4391f0b1-9910-412b-a96c-364f95444300"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("85e25352-cb28-421e-93c5-bb0008794cde"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c218af6e-ac48-483d-b2db-31c52f032dbe"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("150b4f83-dea2-4b0d-a729-90734c7f85cc"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("2f6fe8ae-b8a4-4090-acb8-51e8bb921ebe"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("926d2fcb-ea71-4995-ad61-d67a99c38225"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("3e7aa197-da09-44d8-8333-7076ca068f97"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("d1d4fa29-dede-424b-8a4b-c23d8b5965df"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e9b325d2-6c2b-4ad4-be87-1d153b8b3afa"));

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "InventoryAvailablilties",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "InventoryAvailablilties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a9639db2-6e3e-4fad-a773-b336b5d30627"), "Desks" },
                    { new Guid("0fd72905-a2f6-40c8-829e-f1d543531820"), "Chairs" },
                    { new Guid("8a10cccf-b134-4e31-b6cb-c1878e248d05"), "Tables" },
                    { new Guid("5a650efa-e9af-4dc8-b78f-7d033e76420e"), "File-Cabinets" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f599ba2d-edec-4385-a864-57ac52f83bee"), "Red" },
                    { new Guid("f07bb0be-d03d-44f8-b635-65c6f2d39ea7"), "Green" },
                    { new Guid("b3b4449b-10cb-49a0-a676-1e2f3bd62483"), "Blue" },
                    { new Guid("68796d50-5135-4fd2-9bae-efa9a6fcb1cf"), "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d7041f64-9b20-408f-9984-4a35ddac5cfa"), "Corporate" },
                    { new Guid("34b702cb-e924-465a-a1de-b0f8d6c64b2e"), "Home/Office" },
                    { new Guid("c57a824b-46da-4e5c-b819-cfaba54ed5bb"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e81f07c4-6419-425c-a2c0-8f2c80cb0904"), "Pine" },
                    { new Guid("83a35f78-e7e3-4dfe-8b4c-ed735b64b1e0"), "Milo" },
                    { new Guid("b59683ce-af6a-40f7-be8b-28e495a31b58"), "Fiber" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("0fd72905-a2f6-40c8-829e-f1d543531820"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("5a650efa-e9af-4dc8-b78f-7d033e76420e"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("8a10cccf-b134-4e31-b6cb-c1878e248d05"));

            migrationBuilder.DeleteData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("a9639db2-6e3e-4fad-a773-b336b5d30627"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("68796d50-5135-4fd2-9bae-efa9a6fcb1cf"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b3b4449b-10cb-49a0-a676-1e2f3bd62483"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f07bb0be-d03d-44f8-b635-65c6f2d39ea7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f599ba2d-edec-4385-a864-57ac52f83bee"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("34b702cb-e924-465a-a1de-b0f8d6c64b2e"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("c57a824b-46da-4e5c-b819-cfaba54ed5bb"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("d7041f64-9b20-408f-9984-4a35ddac5cfa"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("83a35f78-e7e3-4dfe-8b4c-ed735b64b1e0"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("b59683ce-af6a-40f7-be8b-28e495a31b58"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: new Guid("e81f07c4-6419-425c-a2c0-8f2c80cb0904"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "InventoryAvailablilties");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "InventoryAvailablilties");

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4506d5a0-e453-4eb5-bd5c-32c255b0c93b"), "Desks" },
                    { new Guid("edc89773-eeaa-4a8d-ac40-14e0c881f76a"), "Chairs" },
                    { new Guid("b273c72f-b914-4007-91b6-380f78db14d4"), "Tables" },
                    { new Guid("9ba8803d-04f2-49b1-991b-0e3979c7e957"), "File-Cabinets" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("38b34311-4dde-4c38-8284-298b07061da7"), "Red" },
                    { new Guid("c218af6e-ac48-483d-b2db-31c52f032dbe"), "Green" },
                    { new Guid("85e25352-cb28-421e-93c5-bb0008794cde"), "Blue" },
                    { new Guid("4391f0b1-9910-412b-a96c-364f95444300"), "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2f6fe8ae-b8a4-4090-acb8-51e8bb921ebe"), "Corporate" },
                    { new Guid("150b4f83-dea2-4b0d-a729-90734c7f85cc"), "Home/Office" },
                    { new Guid("926d2fcb-ea71-4995-ad61-d67a99c38225"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e7aa197-da09-44d8-8333-7076ca068f97"), "Pine" },
                    { new Guid("d1d4fa29-dede-424b-8a4b-c23d8b5965df"), "Milo" },
                    { new Guid("e9b325d2-6c2b-4ad4-be87-1d153b8b3afa"), "Fiber" }
                });
        }
    }
}
