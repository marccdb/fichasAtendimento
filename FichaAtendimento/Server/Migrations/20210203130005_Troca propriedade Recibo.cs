using Microsoft.EntityFrameworkCore.Migrations;

namespace FichaAtendimento.Server.Migrations
{
    public partial class TrocapropriedadeRecibo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DadosRecibo",
                table: "Pacientes",
                newName: "ReciboPara");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReciboPara",
                table: "Pacientes",
                newName: "DadosRecibo");
        }
    }
}
