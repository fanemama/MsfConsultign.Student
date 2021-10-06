using Microsoft.EntityFrameworkCore.Migrations;

namespace MsfConsulting.Lausa.Database.Migrations.Migrations
{
    public partial class initSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unenrollments_Courses_CourseId",
                table: "Unenrollments");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Unenrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Code", "Label" },
                values: new object[,]
                {
                    { 1, "Physic", "Physic" },
                    { 2, "Mathematic", "Mathematic" },
                    { 3, "Biologic", "Biologic" },
                    { 4, "Geographic", "Geographic" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "Code", "Label" },
                values: new object[,]
                {
                    { 1, "A", "A" },
                    { 2, "B", "B" },
                    { 3, "C", "C" },
                    { 4, "D", "D" },
                    { 5, "F", "F" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Unenrollments_Courses_CourseId",
                table: "Unenrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unenrollments_Courses_CourseId",
                table: "Unenrollments");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Unenrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Unenrollments_Courses_CourseId",
                table: "Unenrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
