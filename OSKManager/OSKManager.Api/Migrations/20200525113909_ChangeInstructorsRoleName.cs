using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class ChangeInstructorsRoleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4b20ed76-c027-4ac8-b965-cfa2fc35525b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae8dafb-1d32-4f9e-9396-f998db7c6c41"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("73f66388-e9f9-4333-b386-f54c047da345"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b133f5f4-296d-40d8-be07-1f6b2b248920"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "ed29c4dd-bb54-4b71-9f1e-61485757120c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "2e58027a-a2e5-491d-b207-7a3fa94e41d1", "INSTRUCTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "9b54d771-387f-45ee-94d7-bc0d30676fe9");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "2301D884-221A-4E7D-B509-0113DCC043E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39665189-e90d-457f-9855-33963c879543", "AQAAAAEAACcQAAAAEDHiguz0bGppyJwrZu1bby3A4KDzkDGsFcWBbiAweD1cGQIBRSYKPgPdqfys1WUOow==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("d68a51f5-9f62-4de4-be09-85cb77d1e592"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("7fba1061-11da-4088-a5f3-05c4752a5e5b"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("9f7a263a-0bd7-4e9b-950e-6cbc67e05e32"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("08dbea48-13e4-4bf6-89e7-475aeb96c8dc"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "2301D884-221A-4E7D-B509-0113DCC043E1" });

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("08dbea48-13e4-4bf6-89e7-475aeb96c8dc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7fba1061-11da-4088-a5f3-05c4752a5e5b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9f7a263a-0bd7-4e9b-950e-6cbc67e05e32"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d68a51f5-9f62-4de4-be09-85cb77d1e592"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "b18a2efa-3664-4b2a-9b8e-3bd48b086f03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e7e6ccc7-85a1-4980-b678-2beb6bbe706c", "Instructor" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "672778f3-928c-4c81-9503-71bfd1fc91c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d729c5d-2e6a-4893-972c-1a175b1e5807", "AQAAAAEAACcQAAAAEIitEFRxZFVnlvhWXS/7A4tfq8jm5NS3mBPM7vQDx7C/1xeUd9h3RH8lroo9EDCf4A==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("b133f5f4-296d-40d8-be07-1f6b2b248920"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("5ae8dafb-1d32-4f9e-9396-f998db7c6c41"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("73f66388-e9f9-4333-b386-f54c047da345"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("4b20ed76-c027-4ac8-b965-cfa2fc35525b"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }
    }
}
