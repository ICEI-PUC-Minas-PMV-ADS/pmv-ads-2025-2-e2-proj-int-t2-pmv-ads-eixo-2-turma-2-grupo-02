using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateImagemPlantacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Imagens_ImagemId",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_ImagemId",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "ImagemId",
                table: "Imagens");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemPlantacao_ImagemId",
                table: "ImagemPlantacao",
                column: "ImagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemPlantacao_Imagens_ImagemId",
                table: "ImagemPlantacao",
                column: "ImagemId",
                principalTable: "Imagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemPlantacao_Imagens_ImagemId",
                table: "ImagemPlantacao");

            migrationBuilder.DropIndex(
                name: "IX_ImagemPlantacao_ImagemId",
                table: "ImagemPlantacao");

            migrationBuilder.AddColumn<int>(
                name: "ImagemId",
                table: "Imagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_ImagemId",
                table: "Imagens",
                column: "ImagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Imagens_ImagemId",
                table: "Imagens",
                column: "ImagemId",
                principalTable: "Imagens",
                principalColumn: "Id");
        }
    }
}
