using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Klir.TechChallenge.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Summary = table.Column<string>(type: "varchar(100)", nullable: false),
                    TemperatureF = table.Column<int>(nullable: false),
                    TemperatureC = table.Column<int>(nullable: false),
                    DateForecast = table.Column<DateTime>(type: "datetime2(0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "DateForecast", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 1, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scorching", 32, 89 });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "DateForecast", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 2, new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild", 45, 112 });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "DateForecast", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 3, new DateTime(2018, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild", -4, 25 });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "DateForecast", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 4, new DateTime(2018, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balmy", 16, 60 });

            migrationBuilder.InsertData(
                table: "WeatherForecast",
                columns: new[] { "Id", "DateForecast", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 5, new DateTime(2018, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hot", 53, 127 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecast");
        }
    }
}
