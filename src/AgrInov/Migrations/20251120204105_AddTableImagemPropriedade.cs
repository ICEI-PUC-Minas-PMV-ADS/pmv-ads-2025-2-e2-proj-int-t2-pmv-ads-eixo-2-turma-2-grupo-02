using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class AddTableImagemPropriedade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagemPropriedade",
                columns: table => new
                {
                    PropriedadeId = table.Column<int>(type: "int", nullable: false),
                    ImagemId = table.Column<int>(type: "int", nullable: false),
                    PropriedadeAgriculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemPropriedade", x => new { x.PropriedadeId, x.ImagemId });
                    table.ForeignKey(
                        name: "FK_ImagemPropriedade_Imagens_ImagemId",
                        column: x => x.ImagemId,
                        principalTable: "Imagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagemPropriedade_PropriedadeAgricula_PropriedadeAgriculaId",
                        column: x => x.PropriedadeAgriculaId,
                        principalTable: "PropriedadeAgricula",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagemPropriedade_ImagemId",
                table: "ImagemPropriedade",
                column: "ImagemId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemPropriedade_PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                column: "PropriedadeAgriculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagemPropriedade");
        }
    }
}
