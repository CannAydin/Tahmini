using Microsoft.EntityFrameworkCore.Migrations;

namespace Tahmini.Data.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Tests_TestId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "Answers",
                newName: "testsId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_TestId",
                table: "Answers",
                newName: "IX_Answers_testsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Tests_testsId",
                table: "Answers",
                column: "testsId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Tests_testsId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "testsId",
                table: "Answers",
                newName: "TestId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_testsId",
                table: "Answers",
                newName: "IX_Answers_TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Tests_TestId",
                table: "Answers",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
