using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPizzaria.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class asdasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "enderecoid",
                table: "TBFuncionario",
                newName: "Enderecoid");

            migrationBuilder.RenameIndex(
                name: "IX_TBFuncionario_enderecoid",
                table: "TBFuncionario",
                newName: "IX_TBFuncionario_Enderecoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enderecoid",
                table: "TBFuncionario",
                newName: "enderecoid");

            migrationBuilder.RenameIndex(
                name: "IX_TBFuncionario_Enderecoid",
                table: "TBFuncionario",
                newName: "IX_TBFuncionario_enderecoid");
        }
    }
}
