using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPEvidence.Data.Migrations
{
    public partial class Vytvoreni_Pojisteni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Castka = table.Column<int>(type: "int", nullable: false),
                    Objekt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PojisteniOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PojisteniDo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");
        }
    }
}
