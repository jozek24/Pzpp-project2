using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class LectureDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("11075837-1eb5-427c-b31c-fddd01f1d16d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("487c5254-766b-46f1-821c-dd1cb7487c98"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6962168b-4eee-4eec-92db-4c2d0a99c053"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8b2b6810-f597-4b50-ad0d-2fa130d83459"));

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "LectureDate");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LectureDate",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "LectureDate",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "LectureDate",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "b4b0fc3a-d50e-45d0-8853-9844ea5e9518");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "9d33a525-c03c-4826-8fda-5af4a071b2df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "784c7fd9-c7b9-49cf-a63a-1332f11750c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac97212b-679e-45a4-ae3a-836a42527af3", "AQAAAAEAACcQAAAAEEccRUYiLeKg0o9wI0AVV7TMzO/oFsgrDMyEiYaqOh+Ec36Qdpw6Zibiu1bAkEOGzQ==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("f2f3489e-41e4-4fb6-80cc-dd9796232cb3"), 1500m, 20, 30, "Motocykl", "A" },
                    { new Guid("c019751a-721c-47e2-a099-1737fa9c6344"), 1700m, 30, 30, "Samochód Osobowy", "B" },
                    { new Guid("60a5b892-828e-4e59-aa26-7acec013468f"), 2600m, 30, 20, "Samochód Ciężarowy", "C" },
                    { new Guid("8d4d32e3-0e57-49d9-9099-fac86d33945c"), 4800m, 60, 20, "Autobus", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("60a5b892-828e-4e59-aa26-7acec013468f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8d4d32e3-0e57-49d9-9099-fac86d33945c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c019751a-721c-47e2-a099-1737fa9c6344"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f2f3489e-41e4-4fb6-80cc-dd9796232cb3"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "LectureDate");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "LectureDate");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "LectureDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "LectureDate",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "131db459-af3e-4906-9633-8fa5a84b9f32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "29e063d5-a703-4979-b1bd-1021a6b8e576");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "385f8187-389f-47f3-91d0-91e6f47ff6ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4766358f-07fb-4f3c-b454-768e480f2f75", "AQAAAAEAACcQAAAAEPIKW9s+JKZDi+b+RImD8jAcdn8OOl/t5oIPq3PD12sztXOgg18/ozfB4QMVJ6krcw==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("487c5254-766b-46f1-821c-dd1cb7487c98"), 1500m, 20, 30, "Motocykl", "A" },
                    { new Guid("11075837-1eb5-427c-b31c-fddd01f1d16d"), 1700m, 30, 30, "Samochód Osobowy", "B" },
                    { new Guid("6962168b-4eee-4eec-92db-4c2d0a99c053"), 2600m, 30, 20, "Samochód Ciężarowy", "C" },
                    { new Guid("8b2b6810-f597-4b50-ad0d-2fa130d83459"), 4800m, 60, 20, "Autobus", "D" }
                });
        }
    }
}
