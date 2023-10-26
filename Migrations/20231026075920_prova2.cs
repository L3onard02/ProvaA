using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProvaFaseA.Migrations
{
    /// <inheritdoc />
    public partial class prova2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentificativoCliente",
                table: "Carrelli",
                newName: "IdentificativoCliente1");

            migrationBuilder.AddColumn<int>(
                name: "ProdottoIdentificativoProdotto",
                table: "Carrelli",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrelli_IdentificativoCliente1",
                table: "Carrelli",
                column: "IdentificativoCliente1");

            migrationBuilder.CreateIndex(
                name: "IX_Carrelli_ProdottoIdentificativoProdotto",
                table: "Carrelli",
                column: "ProdottoIdentificativoProdotto");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrelli_Clienti_IdentificativoCliente1",
                table: "Carrelli",
                column: "IdentificativoCliente1",
                principalTable: "Clienti",
                principalColumn: "IdentificativoCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli",
                column: "ProdottoIdentificativoProdotto",
                principalTable: "Prodotti",
                principalColumn: "IdentificativoProdotto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrelli_Clienti_IdentificativoCliente1",
                table: "Carrelli");

            migrationBuilder.DropForeignKey(
                name: "FK_Carrelli_Prodotti_ProdottoIdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.DropIndex(
                name: "IX_Carrelli_IdentificativoCliente1",
                table: "Carrelli");

            migrationBuilder.DropIndex(
                name: "IX_Carrelli_ProdottoIdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.DropColumn(
                name: "ProdottoIdentificativoProdotto",
                table: "Carrelli");

            migrationBuilder.RenameColumn(
                name: "IdentificativoCliente1",
                table: "Carrelli",
                newName: "IdentificativoCliente");
        }
    }
}
