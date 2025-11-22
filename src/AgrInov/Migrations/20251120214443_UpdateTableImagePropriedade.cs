using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableImagePropriedade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemPropriedade_PropriedadeAgricula_PropriedadeAgriculaId",
                table: "ImagemPropriedade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagemPropriedade",
                table: "ImagemPropriedade");

            migrationBuilder.DropIndex(
                name: "IX_ImagemPropriedade_PropriedadeAgriculaId",
                table: "ImagemPropriedade");

            migrationBuilder.DropColumn(
                name: "PropriedadeId",
                table: "ImagemPropriedade");

            migrationBuilder.AlterColumn<int>(
                name: "PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagemPropriedade",
                table: "ImagemPropriedade",
                columns: new[] { "PropriedadeAgriculaId", "ImagemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemPropriedade_PropriedadeAgricula_PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                column: "PropriedadeAgriculaId",
                principalTable: "PropriedadeAgricula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagemPropriedade_PropriedadeAgricula_PropriedadeAgriculaId",
                table: "ImagemPropriedade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagemPropriedade",
                table: "ImagemPropriedade");

            migrationBuilder.AlterColumn<int>(
                name: "PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PropriedadeId",
                table: "ImagemPropriedade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagemPropriedade",
                table: "ImagemPropriedade",
                columns: new[] { "PropriedadeId", "ImagemId" });

            migrationBuilder.CreateIndex(
                name: "IX_ImagemPropriedade_PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                column: "PropriedadeAgriculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemPropriedade_PropriedadeAgricula_PropriedadeAgriculaId",
                table: "ImagemPropriedade",
                column: "PropriedadeAgriculaId",
                principalTable: "PropriedadeAgricula",
                principalColumn: "Id");
        }
    }
}
