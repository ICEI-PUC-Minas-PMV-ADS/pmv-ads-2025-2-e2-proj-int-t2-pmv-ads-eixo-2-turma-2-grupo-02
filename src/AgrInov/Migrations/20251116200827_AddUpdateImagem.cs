using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateImagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
