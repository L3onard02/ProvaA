using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProvaFaseA.Migrations
{
    /// <inheritdoc />
    public partial class prova3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.DropColumn(
                name: "IdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.AlterColumn<int>(
                name: "ProdottoIdentificativoProdotto",
                table: "Carrelli",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli",
                column: "ProdottoIdentificativoProdotto",
                principalTable: "Prodotti",
                principalColumn: "IdentificativoProdotto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.AlterColumn<int>(
                name: "ProdottoIdentificativoProdotto",
                table: "Carrelli",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdentificativoProdotto",
                table: "Carrelli",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli",
                column: "ProdottoIdentificativoProdotto",
                principalTable: "Prodotti",
                principalColumn: "IdentificativoProdotto");
        }
    }
}
