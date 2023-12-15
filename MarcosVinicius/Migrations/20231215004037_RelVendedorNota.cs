using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelVendedorNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdTransportadora",
                table: "NotasDeVenda");

            migrationBuilder.RenameColumn(
                name: "IdTransportadora",
                table: "NotasDeVenda",
                newName: "IdVendedor");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVenda_IdTransportadora",
                table: "NotasDeVenda",
                newName: "IX_NotasDeVenda_IdVendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdVendedor",
                table: "NotasDeVenda",
                column: "IdVendedor",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdVendedor",
                table: "NotasDeVenda");

            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "NotasDeVenda",
                newName: "IdTransportadora");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVenda_IdVendedor",
                table: "NotasDeVenda",
                newName: "IX_NotasDeVenda_IdTransportadora");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdTransportadora",
                table: "NotasDeVenda",
                column: "IdTransportadora",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }
    }
}
