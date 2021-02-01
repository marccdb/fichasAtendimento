using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FichaAtendimento.Server.Migrations
{
    public partial class Alteraçãoemformatodedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Fichas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fichas");
        }
    }
}
