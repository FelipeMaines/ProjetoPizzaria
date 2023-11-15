using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPizzaria.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBEndereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEndereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TBIngrediente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBIngrediente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TBSabor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSabor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TBValor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Tamanho = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ValorPizza = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorBorda = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBValor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TBCliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(20)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_TBCliente_TBEndereco",
                        column: x => x.EnderecoId,
                        principalTable: "TBEndereco",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(100)", nullable: false),
                    Matricula = table.Column<string>(type: "varchar(100)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Motorista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.id);
                    table.ForeignKey(
                        name: "FK_TBFuncionario_TBEndereco",
                        column: x => x.EnderecoId,
                        principalTable: "TBEndereco",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TBSabor_TBIngrediente",
                columns: table => new
                {
                    SaborIngredientesid = table.Column<int>(type: "int", nullable: false),
                    Saborid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSabor_TBIngrediente", x => new { x.SaborIngredientesid, x.Saborid });
                    table.ForeignKey(
                        name: "FK_TBSabor_TBIngrediente_TBIngrediente_SaborIngredientesid",
                        column: x => x.SaborIngredientesid,
                        principalTable: "TBIngrediente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBSabor_TBIngrediente_TBSabor_Saborid",
                        column: x => x.Saborid,
                        principalTable: "TBSabor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBCliente_EnderecoId",
                table: "TBCliente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBFuncionario_EnderecoId",
                table: "TBFuncionario",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBSabor_TBIngrediente_Saborid",
                table: "TBSabor_TBIngrediente",
                column: "Saborid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCliente");

            migrationBuilder.DropTable(
                name: "TBFuncionario");

            migrationBuilder.DropTable(
                name: "TBSabor_TBIngrediente");

            migrationBuilder.DropTable(
                name: "TBValor");

            migrationBuilder.DropTable(
                name: "TBEndereco");

            migrationBuilder.DropTable(
                name: "TBIngrediente");

            migrationBuilder.DropTable(
                name: "TBSabor");
        }
    }
}
