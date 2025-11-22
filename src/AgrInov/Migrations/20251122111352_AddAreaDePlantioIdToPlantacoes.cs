using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddAreaDePlantioIdToPlantacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaDePlantioId",
                table: "Plantacoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plantacoes_AreaDePlantioId",
                table: "Plantacoes",
                column: "AreaDePlantioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plantacoes_AreasDePlantio_AreaDePlantioId",
                table: "Plantacoes",
                column: "AreaDePlantioId",
                principalTable: "AreasDePlantio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantacoes_AreasDePlantio_AreaDePlantioId",
                table: "Plantacoes");

            migrationBuilder.DropIndex(
                name: "IX_Plantacoes_AreaDePlantioId",
                table: "Plantacoes");

            migrationBuilder.DropColumn(
                name: "AreaDePlantioId",
                table: "Plantacoes");
        }
    }
}
