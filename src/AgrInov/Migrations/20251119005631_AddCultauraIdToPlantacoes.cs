using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddCultauraIdToPlantacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CulturaId",
                table: "Plantacoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plantacoes_CulturaId",
                table: "Plantacoes",
                column: "CulturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plantacoes_Culturas_CulturaId",
                table: "Plantacoes",
                column: "CulturaId",
                principalTable: "Culturas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantacoes_Culturas_CulturaId",
                table: "Plantacoes");

            migrationBuilder.DropIndex(
                name: "IX_Plantacoes_CulturaId",
                table: "Plantacoes");

            migrationBuilder.DropColumn(
                name: "CulturaId",
                table: "Plantacoes");
        }
    }
}
