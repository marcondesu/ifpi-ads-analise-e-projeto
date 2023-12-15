using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelProdutoMarca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_IdNotaDeVenda",
                table: "Itens",
                column: "IdNotaDeVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_IdProduto",
                table: "Itens",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_NotasDeVenda_IdNotaDeVenda",
                table: "Itens",
                column: "IdNotaDeVenda",
                principalTable: "NotasDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_IdProduto",
                table: "Itens",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_NotasDeVenda_IdNotaDeVenda",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_IdProduto",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Marcas_MarcaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Itens_IdNotaDeVenda",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_IdProduto",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Produtos");

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
    }
}
