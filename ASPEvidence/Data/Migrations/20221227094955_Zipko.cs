using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPEvidence.Data.Migrations
{
    public partial class Zipko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Psč",
                table: "Users",
                newName: "Zip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Users",
                newName: "Psč");
        }
    }
}
