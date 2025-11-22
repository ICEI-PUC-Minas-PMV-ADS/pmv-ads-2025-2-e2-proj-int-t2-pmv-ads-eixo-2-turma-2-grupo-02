using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldRecomendacaoOnTableCultura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recomendacao",
                table: "Culturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recomendacao",
                table: "Culturas");
        }
    }
}
