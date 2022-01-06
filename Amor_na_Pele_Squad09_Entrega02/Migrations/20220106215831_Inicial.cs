using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Amor_na_Pele_Squad09_Entrega02.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroContato",
                columns: table => new
                {
                    ID_Contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeContato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailContato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroContato", x => x.ID_Contato);
                });

            migrationBuilder.CreateTable(
                name: "CadastroEmpresa",
                columns: table => new
                {
                    ID_Empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeParaContatoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefoneEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricaoNegocio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroEmpresa", x => x.ID_Empresa);
                });

            migrationBuilder.CreateTable(
                name: "CadastroMulher",
                columns: table => new
                {
                    ID_Mulher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeMulher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numeroTelefoneMulher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailMulher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroMulher", x => x.ID_Mulher);
                });

            migrationBuilder.CreateTable(
                name: "CadastroNewsletter",
                columns: table => new
                {
                    ID_Newsletter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailNewsletter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeNewsletter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aceitaReceber = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroNewsletter", x => x.ID_Newsletter);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroContato");

            migrationBuilder.DropTable(
                name: "CadastroEmpresa");

            migrationBuilder.DropTable(
                name: "CadastroMulher");

            migrationBuilder.DropTable(
                name: "CadastroNewsletter");
        }
    }
}
