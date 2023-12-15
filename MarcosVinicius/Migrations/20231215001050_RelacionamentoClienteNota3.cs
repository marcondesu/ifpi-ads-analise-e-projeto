using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelacionamentoClienteNota3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Clientes_IdCliente",
                table: "NotasDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVenda_IdCliente",
                table: "NotasDeVenda");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "NotasDeVenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVenda_ClienteId",
                table: "NotasDeVenda",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Clientes_ClienteId",
                table: "NotasDeVenda",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Clientes_ClienteId",
                table: "NotasDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVenda_ClienteId",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "NotasDeVenda");

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVenda_IdCliente",
                table: "NotasDeVenda",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Clientes_IdCliente",
                table: "NotasDeVenda",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id");
        }
    }
}
