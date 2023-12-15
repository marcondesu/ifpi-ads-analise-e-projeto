using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcosVinicius.Migrations
{
    public partial class RelacionamentoClienteNota2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotasDeVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasDeVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasDeVenda_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVenda_IdCliente",
                table: "NotasDeVenda",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasDeVenda");
        }
    }
}
