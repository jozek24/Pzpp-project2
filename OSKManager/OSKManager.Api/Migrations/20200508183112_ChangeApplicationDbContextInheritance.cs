using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class ChangeApplicationDbContextInheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_Instructor_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_Student_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Instructor_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Student_AddressId",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "Instructor_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_AddressId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Instructor_AddressId",
                table: "AspNetUsers",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Student_AddressId",
                table: "AspNetUsers",
                type: "char(36)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Instructor_AddressId",
                table: "AspNetUsers",
                column: "Instructor_AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Student_AddressId",
                table: "AspNetUsers",
                column: "Student_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_Instructor_AddressId",
                table: "AspNetUsers",
                column: "Instructor_AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_Student_AddressId",
                table: "AspNetUsers",
                column: "Student_AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
