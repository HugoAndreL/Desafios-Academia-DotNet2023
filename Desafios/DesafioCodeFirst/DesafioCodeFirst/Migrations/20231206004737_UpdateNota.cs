using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Notas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
