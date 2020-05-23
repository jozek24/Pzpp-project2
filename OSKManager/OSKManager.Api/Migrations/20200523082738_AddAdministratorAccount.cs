using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class AddAdministratorAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "935f0f4e-f991-405d-bc31-b18be1c7c360");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b49aabdd-5423-4e05-b6c7-8ea96fbf16ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eef54878-a955-4abc-ba6b-52c1b56a2e96");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("60c9a5be-e412-4aa3-829d-0c180b4f1577"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9f63bae1-4880-4987-a312-adaecfe6eee1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d6b35adf-a618-494d-acf6-bfe4be7124c4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fd6bd236-9c23-47b6-8396-d1a03afaa649"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a69f8c0-4e6b-496a-90fb-72ba4ce0db03", "6d3c7aea-86ca-441b-9f29-89cf1a0f0934", "Student", "STUDENT" },
                    { "e5d6aa44-8ed6-4abd-a78b-31acc0ab9d90", "dc499b42-f07f-46d4-b94f-695f5c10744e", "Instructor", "Instructor" },
                    { "bed7ec8d-8687-4e21-a0e2-ab957c63f3ea", "1d2dd61a-c4ac-46a5-a62a-5621238a0da2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "PhotoPath" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", 0, null, "2e9b3f78-f984-4afc-a91b-9af462046a4b", "Administrator", "Admin@Admin.com", false, "Master", 0, "Admin", true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENBY0gg6lZJMVJlVUgJMl5b5Vh+0BF8EN/7AXkmx7TKF/Krw2pXkb9addYJJijWX8w==", null, false, "00000000-0000-0000-0000-000000000000", false, "Admin@Admin.com", null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7");

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
                    { "eef54878-a955-4abc-ba6b-52c1b56a2e96", "2eb7edfd-dfaa-4099-8558-65627b045250", "Student", "STUDENT" },
                    { "b49aabdd-5423-4e05-b6c7-8ea96fbf16ff", "ae6fcc4b-0b2a-46e8-a383-d094ca132545", "Instructor", "Instructor" },
                    { "935f0f4e-f991-405d-bc31-b18be1c7c360", "23e9cb2e-92c8-4f66-892d-3d8203c4936c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("fd6bd236-9c23-47b6-8396-d1a03afaa649"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("9f63bae1-4880-4987-a312-adaecfe6eee1"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("60c9a5be-e412-4aa3-829d-0c180b4f1577"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("d6b35adf-a618-494d-acf6-bfe4be7124c4"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }
    }
}
