using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatePlantacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_ImagemPlantacao_Plantacoes_PlantacaoId",
                table: "ImagemPlantacao",
                column: "PlantacaoId",
                principalTable: "Plantacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemPlantacao_Plantacoes_PlantacaoId",
                table: "ImagemPlantacao");
        }
    }
}
