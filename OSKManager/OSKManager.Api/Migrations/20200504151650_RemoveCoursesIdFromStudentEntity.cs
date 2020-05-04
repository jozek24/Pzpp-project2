using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class RemoveCoursesIdFromStudentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_StudentId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId1",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22076ca5-eb33-407c-9151-7062852d21cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83929803-4087-49db-beb3-30f254b4f405");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45717a3-7b33-425c-9849-ab65ee72dc97");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("033f85db-984d-41ad-8c17-794fc12a6ccc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5d9e440e-f4a1-4537-8c7b-756628f24db4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("619c7f80-d882-492b-8e21-566e53ce7732"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("634af9b7-3b4a-4101-b7bf-cf7b5cd97a4a"));

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d28852ed-839f-4ad6-8f1e-3a38a5783c56", "c30f219f-79e2-4232-bfd3-c1d9d5a786bb", "Student", "STUDENT" },
                    { "57fa0819-d218-4c55-a1a5-845f6998da73", "de4de3a6-28ab-4b1c-9b72-37129d3e7cd0", "Instructor", "Instructor" },
                    { "4d1d8cba-4cc7-42d7-8aba-2a8c4e3eb043", "6bbda714-bb55-4d6d-b837-d0a4b27b0875", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("60c348fa-34cd-4bcb-8093-fe2f2ea55b40"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("29f32782-5ca0-4b8e-ae96-40b3476ff487"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("544b1ea0-89ea-4357-96c8-8a640b2b78d7"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("8523a02f-f805-4d3b-aba3-5051843edc32"), 4800m, 60, 20, null, "Autobus", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d1d8cba-4cc7-42d7-8aba-2a8c4e3eb043");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57fa0819-d218-4c55-a1a5-845f6998da73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d28852ed-839f-4ad6-8f1e-3a38a5783c56");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("29f32782-5ca0-4b8e-ae96-40b3476ff487"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("544b1ea0-89ea-4357-96c8-8a640b2b78d7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("60c348fa-34cd-4bcb-8093-fe2f2ea55b40"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8523a02f-f805-4d3b-aba3-5051843edc32"));

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Courses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22076ca5-eb33-407c-9151-7062852d21cd", "1fae2df5-8177-4676-b651-b4ba915459c1", "Student", "STUDENT" },
                    { "83929803-4087-49db-beb3-30f254b4f405", "7c37ab43-f5cb-455b-9d82-95fda113351c", "Instructor", "Instructor" },
                    { "a45717a3-7b33-425c-9849-ab65ee72dc97", "00f082cb-b624-4a7f-b523-828460ce87ee", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("634af9b7-3b4a-4101-b7bf-cf7b5cd97a4a"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("033f85db-984d-41ad-8c17-794fc12a6ccc"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("619c7f80-d882-492b-8e21-566e53ce7732"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("5d9e440e-f4a1-4537-8c7b-756628f24db4"), 4800m, 60, 20, null, "Autobus", "D" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId1",
                table: "Courses",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_StudentId1",
                table: "Courses",
                column: "StudentId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
