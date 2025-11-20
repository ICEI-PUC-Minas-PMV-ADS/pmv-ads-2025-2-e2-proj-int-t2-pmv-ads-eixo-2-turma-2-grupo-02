using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class InsumoCosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CulturaId",
                table: "Insumos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Custo",
                table: "Insumos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Utilizado",
                table: "Insumos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Insumos_CulturaId",
                table: "Insumos",
                column: "CulturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insumos_Culturas_CulturaId",
                table: "Insumos",
                column: "CulturaId",
                principalTable: "Culturas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insumos_Culturas_CulturaId",
                table: "Insumos");

            migrationBuilder.DropIndex(
                name: "IX_Insumos_CulturaId",
                table: "Insumos");

            migrationBuilder.DropColumn(
                name: "CulturaId",
                table: "Insumos");

            migrationBuilder.DropColumn(
                name: "Custo",
                table: "Insumos");

            migrationBuilder.DropColumn(
                name: "Utilizado",
                table: "Insumos");
        }
    }
}
