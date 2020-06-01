using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class SetRoleForAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a69f8c0-4e6b-496a-90fb-72ba4ce0db03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bed7ec8d-8687-4e21-a0e2-ab957c63f3ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5d6aa44-8ed6-4abd-a78b-31acc0ab9d90");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("18c8553d-ac53-4180-a4a9-7e92d9648df5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("45de4d52-ca5b-4f75-a363-6e49a99af8c0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("85bfe262-3834-42e5-b4c5-4c354007f7c5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bdb1dd10-3842-45cc-8f6a-a0ded11e06a0"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7D9B7113-A8F8-4035-99A7-A20DD400F6A3", "672778f3-928c-4c81-9503-71bfd1fc91c6", "Student", "STUDENT" },
                    { "78A7570F-3CE5-48BA-9461-80283ED1D94D", "e7e6ccc7-85a1-4980-b678-2beb6bbe706c", "Instructor", "Instructor" },
                    { "2301D884-221A-4E7D-B509-0113DCC043E1", "b18a2efa-3664-4b2a-9b8e-3bd48b086f03", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a69f8c0-4e6b-496a-90fb-72ba4ce0db03", "6d3c7aea-86ca-441b-9f29-89cf1a0f0934", "Student", "STUDENT" },
                    { "e5d6aa44-8ed6-4abd-a78b-31acc0ab9d90", "dc499b42-f07f-46d4-b94f-695f5c10744e", "Instructor", "Instructor" },
                    { "bed7ec8d-8687-4e21-a0e2-ab957c63f3ea", "1d2dd61a-c4ac-46a5-a62a-5621238a0da2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e9b3f78-f984-4afc-a91b-9af462046a4b", "AQAAAAEAACcQAAAAENBY0gg6lZJMVJlVUgJMl5b5Vh+0BF8EN/7AXkmx7TKF/Krw2pXkb9addYJJijWX8w==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("45de4d52-ca5b-4f75-a363-6e49a99af8c0"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("18c8553d-ac53-4180-a4a9-7e92d9648df5"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("bdb1dd10-3842-45cc-8f6a-a0ded11e06a0"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("85bfe262-3834-42e5-b4c5-4c354007f7c5"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }
    }
}
