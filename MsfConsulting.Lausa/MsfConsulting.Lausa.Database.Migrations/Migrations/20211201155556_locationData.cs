using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MsfConsulting.Lausa.Database.Migrations.Migrations
{
    public partial class locationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Date", "Elevation", "Heading", "Latitude", "Longitude", "Speed", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 1, 16, 55, 56, 259, DateTimeKind.Local).AddTicks(50), 0.0, 0.0, 40.511070799999999, 5.0259003, 150.0, null },
                    { 2, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1273), 0.0, 0.0, 46.511070799999999, 6.6258002999999999, 150.0, null },
                    { 3, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1303), 0.0, 0.0, 41.511070799999999, 8.1257003000000001, 150.0, null },
                    { 4, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1307), 0.0, 0.0, 42.511070799999999, 15.2256003, 150.0, null },
                    { 5, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1309), 0.0, 0.0, 43.511070799999999, 10.3255003, 150.0, null },
                    { 6, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1312), 0.0, 0.0, 44.511070799999999, 7.4254002999999997, 150.0, null },
                    { 7, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1315), 0.0, 0.0, 45.511070799999999, 2.5253003000000001, 150.0, null },
                    { 8, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1318), 0.0, 0.0, 46.511070799999999, 3.6252002999999999, 150.0, null },
                    { 9, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1320), 0.0, 0.0, 47.511070799999999, 4.7251003000000003, 150.0, null },
                    { 10, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1323), 0.0, 0.0, 48.511070799999999, 5.8250003000000001, 150.0, null },
                    { 11, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1326), 0.0, 0.0, 49.511070799999999, 3.9248002999999998, 150.0, null },
                    { 12, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1330), 0.0, 0.0, 42.511070799999999, 6.0241002999999997, 150.0, null },
                    { 13, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1334), 0.0, 0.0, 46.511070799999999, 6.4257002999999999, 150.0, null },
                    { 14, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1337), 0.0, 0.0, 46.511070799999999, 6.5259003, 150.0, null },
                    { 15, new DateTime(2021, 12, 1, 16, 55, 56, 261, DateTimeKind.Local).AddTicks(1340), 0.0, 0.0, 46.511070799999999, 6.6560002999999996, 150.0, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "LiveLocationId", "Phone" },
                values: new object[,]
                {
                    { 1, "toto@titu.fr", "BMW", "LastName1", 1, null },
                    { 2, "toto@titu.fr", "RENAULT", "LastName2", 2, null },
                    { 3, "toto@titu.fr", "MERCEDES", "LastName3", 3, null },
                    { 4, "toto@titu.fr", "SUZUKI", "LastName4", 4, null },
                    { 5, "toto@titu.fr", "TOYOTA", "LastName5", 5, null },
                    { 6, "toto@titu.fr", "PEUGEOT", "LastName6", 6, null },
                    { 7, "toto@titu.fr", "PORSCHE", "LastName7", 7, null },
                    { 8, "toto@titu.fr", "MERCEDES", "LastName8", 8, null },
                    { 9, "toto@titu.fr", "OPEL", "LastName9", 9, null },
                    { 10, "toto@titu.fr", "TOYOTA", "LastName10", 10, null },
                    { 11, "toto@titu.fr", "CITROEN", "LastName11", 11, null },
                    { 12, "toto@titu.fr", "PEUGEOT", "LastName12", 12, null },
                    { 13, "toto@titu.fr", "BMW", "LastName13", 13, null },
                    { 14, "toto@titu.fr", "RENAULT", "LastName14", 14, null },
                    { 15, "toto@titu.fr", "MERCEDES", "LastName15", 15, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
