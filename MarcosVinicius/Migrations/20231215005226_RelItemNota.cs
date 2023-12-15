using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelItemNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdNotaDeVenda",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_NotaDeVendaId",
                table: "Itens",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_NotasDeVenda_NotaDeVendaId",
                table: "Itens",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_NotasDeVenda_NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdNotaDeVenda",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Itens");
        }
    }
}
