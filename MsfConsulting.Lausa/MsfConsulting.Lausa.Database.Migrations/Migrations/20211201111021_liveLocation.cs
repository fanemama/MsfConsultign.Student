using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace MsfConsulting.Lausa.Database.Migrations.Migrations
{
    public partial class liveLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LiveLocationId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false),
                    Speed = table.Column<double>(type: "double", nullable: false),
                    Elevation = table.Column<double>(type: "double", nullable: false),
                    Heading = table.Column<double>(type: "double", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_LiveLocationId",
                table: "Students",
                column: "LiveLocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Locations_LiveLocationId",
                table: "Students",
                column: "LiveLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Locations_LiveLocationId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Students_LiveLocationId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LiveLocationId",
                table: "Students");
        }
    }
}
