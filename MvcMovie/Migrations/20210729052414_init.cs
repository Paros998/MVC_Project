using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    typBadania = table.Column<string>(type: "TEXT", nullable: true),
                    normaLow = table.Column<double>(type: "REAL", nullable: false),
                    normaHigh = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Raport",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NrRaportu = table.Column<int>(type: "INTEGER", nullable: false),
                    DataRaportu = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Odczyt1 = table.Column<double>(type: "REAL", nullable: false),
                    Odczyt2 = table.Column<double>(type: "REAL", nullable: false),
                    Odczyt3 = table.Column<double>(type: "REAL", nullable: false),
                    TypOdczytu = table.Column<string>(type: "TEXT", nullable: false),
                    Seria = table.Column<string>(type: "TEXT", nullable: false),
                    NazwaZakladu = table.Column<string>(type: "TEXT", nullable: false),
                    Produkt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raport", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    StudentSurname = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Semester = table.Column<int>(type: "INTEGER", nullable: false),
                    JoinTime = table.Column<string>(type: "TEXT", nullable: false),
                    University = table.Column<string>(type: "TEXT", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Produkt");

            migrationBuilder.DropTable(
                name: "Raport");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
