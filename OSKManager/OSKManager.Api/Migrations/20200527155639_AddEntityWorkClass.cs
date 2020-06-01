using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class AddEntityWorkClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "WorkClassId",
                table: "LectureDate",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkClassId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkClassId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkClasses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "4b2f0851-4ee4-4cd6-a0e9-91e28a4aff69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "bd442e70-b9a2-411c-9838-4861e11374c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "18b954d5-2a64-4510-8b1b-10e1a2f8df57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69a3d32d-e5ae-4b50-8061-1db12c696c80", "AQAAAAEAACcQAAAAECD0KqauWlg9lDQ1kHf7qqKP7xYzHmoTwu9ggVexGwI5ZXsTj+YWaxhyhzIjITlWAQ==" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BasicPrice", "CountOfDrivingHours", "CountOfLectureHours", "InstructorId", "LongCategoryName", "ShortCategory" },
                values: new object[,]
                {
                    { new Guid("ce9f8591-dc17-4b23-b6a1-0c39e8170175"), 1500m, 20, 30, null, "Motocykl", "A" },
                    { new Guid("e87aaa53-c407-4712-ac8d-a02718878821"), 1700m, 30, 30, null, "Samochód Osobowy", "B" },
                    { new Guid("91e4a1d6-daf5-4a47-bb7e-f07c0291e4bc"), 2600m, 30, 20, null, "Samochód Ciężarowy", "C" },
                    { new Guid("822c18da-a7e7-4b2b-8a2a-36fef457ef81"), 4800m, 60, 20, null, "Autobus", "D" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LectureDate_WorkClassId",
                table: "LectureDate",
                column: "WorkClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_WorkClassId",
                table: "Courses",
                column: "WorkClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkClassId",
                table: "AspNetUsers",
                column: "WorkClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkClasses_WorkClassId",
                table: "AspNetUsers",
                column: "WorkClassId",
                principalTable: "WorkClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_WorkClasses_WorkClassId",
                table: "Courses",
                column: "WorkClassId",
                principalTable: "WorkClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureDate_WorkClasses_WorkClassId",
                table: "LectureDate",
                column: "WorkClassId",
                principalTable: "WorkClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkClasses_WorkClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_WorkClasses_WorkClassId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureDate_WorkClasses_WorkClassId",
                table: "LectureDate");

            migrationBuilder.DropTable(
                name: "WorkClasses");

            migrationBuilder.DropIndex(
                name: "IX_LectureDate_WorkClassId",
                table: "LectureDate");

            migrationBuilder.DropIndex(
                name: "IX_Courses_WorkClassId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkClassId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("822c18da-a7e7-4b2b-8a2a-36fef457ef81"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("91e4a1d6-daf5-4a47-bb7e-f07c0291e4bc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ce9f8591-dc17-4b23-b6a1-0c39e8170175"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e87aaa53-c407-4712-ac8d-a02718878821"));

            migrationBuilder.DropColumn(
                name: "WorkClassId",
                table: "LectureDate");

            migrationBuilder.DropColumn(
                name: "WorkClassId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "WorkClassId",
                table: "AspNetUsers");

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
    }
}
