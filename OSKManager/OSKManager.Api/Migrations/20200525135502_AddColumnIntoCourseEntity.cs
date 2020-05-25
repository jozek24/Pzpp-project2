using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class AddColumnIntoCourseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsStarted",
                table: "Courses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "5068a45e-14b3-4671-8db8-73dd6757c79d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "e51f0822-ae22-4872-b0b9-33897b959072");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "368b4837-ace8-46f8-9d57-71082421caf6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1be20b7-6bc1-4938-bfc4-e4f7423b7719", "AQAAAAEAACcQAAAAEH8gIRe+T1xVVO7yViLM4IQmEM1N1yPmI3HKUGbxEaNHrXpaGIIvC7YdYlrEGao59Q==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("a1ed8704-758f-460b-b9ed-3da4fd698a1d"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("57ef5e2f-287f-4926-9a74-53a293a528f3"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("a886b22a-7d82-4fbb-96f4-2b5acc0410c3"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("8c1f98a8-180b-4592-8326-65ffcf8ffeea"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("57ef5e2f-287f-4926-9a74-53a293a528f3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8c1f98a8-180b-4592-8326-65ffcf8ffeea"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a1ed8704-758f-460b-b9ed-3da4fd698a1d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a886b22a-7d82-4fbb-96f4-2b5acc0410c3"));

            migrationBuilder.DropColumn(
                name: "IsStarted",
                table: "Courses");

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
                column: "ConcurrencyStamp",
                value: "2e58027a-a2e5-491d-b207-7a3fa94e41d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "9b54d771-387f-45ee-94d7-bc0d30676fe9");

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
    }
}
