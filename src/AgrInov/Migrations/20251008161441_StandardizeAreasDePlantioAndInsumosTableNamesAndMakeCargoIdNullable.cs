using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgrInov.Migrations
{
    /// <inheritdoc />
    public partial class StandardizeAreasDePlantioAndInsumosTableNamesAndMakeCargoIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cultura",
                table: "Cultura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AreaDePlantio",
                table: "AreaDePlantio");

            migrationBuilder.RenameTable(
                name: "Cultura",
                newName: "Culturas");

            migrationBuilder.RenameTable(
                name: "AreaDePlantio",
                newName: "AreasDePlantio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Culturas",
                table: "Culturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AreasDePlantio",
                table: "AreasDePlantio",
                column: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Culturas",
                table: "Culturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AreasDePlantio",
                table: "AreasDePlantio");

            migrationBuilder.RenameTable(
                name: "Culturas",
                newName: "Cultura");

            migrationBuilder.RenameTable(
                name: "AreasDePlantio",
                newName: "AreaDePlantio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cultura",
                table: "Cultura",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AreaDePlantio",
                table: "AreaDePlantio",
                column: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CargoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
