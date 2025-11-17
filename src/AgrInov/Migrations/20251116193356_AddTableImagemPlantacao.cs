using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddTableImagemPlantacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagemPlantacao",
                columns: table => new
                {
                    PlantacaoId = table.Column<int>(type: "int", nullable: false),
                    ImagemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemPlantacao", x => new { x.PlantacaoId, x.ImagemId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagemPlantacao");
        }
    }
}
