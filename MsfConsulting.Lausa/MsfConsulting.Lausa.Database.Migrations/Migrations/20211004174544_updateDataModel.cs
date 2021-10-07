using Microsoft.EntityFrameworkCore.Migrations;

namespace MsfConsulting.Lausa.Database.Migrations.Migrations
{
    public partial class updateDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unenrollments_Students_StudentId",
                table: "Unenrollments");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Unenrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Unenrollments_Students_StudentId",
                table: "Unenrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unenrollments_Students_StudentId",
                table: "Unenrollments");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Unenrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Unenrollments_Students_StudentId",
                table: "Unenrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
