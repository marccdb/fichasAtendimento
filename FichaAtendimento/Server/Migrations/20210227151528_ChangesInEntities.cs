using Microsoft.EntityFrameworkCore.Migrations;

namespace FichaAtendimento.Server.Migrations
{
    public partial class ChangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Escolaridade",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "IdadeMae",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "IdadePai",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Religiao",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "AbordagemProxSessao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "CID10_DSM",
                table: "Fichas");

            migrationBuilder.RenameColumn(
                name: "ProxTarefa",
                table: "Fichas",
                newName: "Observacoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observacoes",
                table: "Fichas",
                newName: "ProxTarefa");

            migrationBuilder.AddColumn<string>(
                name: "Escolaridade",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdadeMae",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdadePai",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religiao",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AbordagemProxSessao",
                table: "Fichas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CID10_DSM",
                table: "Fichas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
