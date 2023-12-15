using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelTransportadoraNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTransportadora",
                table: "NotasDeVenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVenda_IdTransportadora",
                table: "NotasDeVenda",
                column: "IdTransportadora");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdTransportadora",
                table: "NotasDeVenda",
                column: "IdTransportadora",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Vendedores_IdTransportadora",
                table: "NotasDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVenda_IdTransportadora",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "IdTransportadora",
                table: "NotasDeVenda");
        }
    }
}
