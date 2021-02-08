using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FichaAtendimento.Server.Migrations
{
    public partial class Initialmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    idFicha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    NomePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumoAtendimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessaoPaga = table.Column<bool>(type: "bit", nullable: false),
                    CondutaClinica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProxTarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CID10_DSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAtendimento = table.Column<DateTime>(type: "date", nullable: false),
                    AbordagemProxSessao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciboEntregue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.idFicha);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    idPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Escolaridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religiao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdadePai = table.Column<int>(type: "int", nullable: false),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdadeMae = table.Column<int>(type: "int", nullable: false),
                    ReciboPara = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.idPaciente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
