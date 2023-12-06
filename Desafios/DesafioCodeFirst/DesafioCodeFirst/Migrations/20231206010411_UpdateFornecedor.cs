using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cnpj",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Funcao",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cnpj",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Funcao",
                table: "Fornecedores");
        }
    }
}
