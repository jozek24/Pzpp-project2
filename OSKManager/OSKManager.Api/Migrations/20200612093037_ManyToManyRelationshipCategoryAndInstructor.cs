using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSKManager.Api.Migrations
{
    public partial class ManyToManyRelationshipCategoryAndInstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_InstructorId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_InstructorId",
                table: "Category");

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
                name: "InstructorId",
                table: "Category");

            migrationBuilder.CreateTable(
                name: "InstructorsCategories",
                columns: table => new
                {
                    InstructorId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorsCategories", x => new { x.InstructorId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_InstructorsCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorsCategories_AspNetUsers_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_InstructorsCategories_CategoryId",
                table: "InstructorsCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorsCategories");

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

            migrationBuilder.AddColumn<string>(
                name: "InstructorId",
                table: "Category",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

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
                name: "IX_Category_InstructorId",
                table: "Category",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_InstructorId",
                table: "Category",
                column: "InstructorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
