using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPEvidence.Data.Migrations
{
    public partial class Pojistenci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PojisteniOd",
                table: "Insurance",
                newName: "ValidTill");

            migrationBuilder.RenameColumn(
                name: "PojisteniDo",
                table: "Insurance",
                newName: "ValidSince");

            migrationBuilder.RenameColumn(
                name: "Objekt",
                table: "Insurance",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Nazev",
                table: "Insurance",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Castka",
                table: "Insurance",
                newName: "Amount");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Insurance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_UsersId",
                table: "Insurance",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Users_UsersId",
                table: "Insurance",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Users_UsersId",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_UsersId",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Insurance");

            migrationBuilder.RenameColumn(
                name: "ValidTill",
                table: "Insurance",
                newName: "PojisteniOd");

            migrationBuilder.RenameColumn(
                name: "ValidSince",
                table: "Insurance",
                newName: "PojisteniDo");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Insurance",
                newName: "Objekt");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Insurance",
                newName: "Nazev");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Insurance",
                newName: "Castka");
        }
    }
}
