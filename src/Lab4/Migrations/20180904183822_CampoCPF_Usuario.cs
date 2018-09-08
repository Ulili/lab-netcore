using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Migrations
{
    public partial class CampoCPF_Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuarios",
                maxLength: 13,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Usuarios");
        }
    }
}
