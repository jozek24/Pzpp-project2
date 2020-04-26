using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class SeedCategoryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("da3b2969-7bad-4f0c-88e1-782a2419b118"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("784ab0e3-3e58-45de-841b-36af4c358311"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("911afa54-ac4e-4d06-ac3e-1fbb84a1772d"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("2d5c1c65-d826-4159-ad5c-1283d37e908d"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d5c1c65-d826-4159-ad5c-1283d37e908d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("784ab0e3-3e58-45de-841b-36af4c358311"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("911afa54-ac4e-4d06-ac3e-1fbb84a1772d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da3b2969-7bad-4f0c-88e1-782a2419b118"));
        }
    }
}
