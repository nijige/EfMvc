using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutri.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPreparacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FichaTecnicas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomePreparacao = table.Column<string>(nullable: true),
                    Ingredientes = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    ModoPreparo = table.Column<string>(nullable: true),
                    Rendimento = table.Column<int>(nullable: false),
                    CustoTotal = table.Column<int>(nullable: false),
                    CustoPorcao = table.Column<int>(nullable: false),
                    DataConclusão = table.Column<DateTimeOffset>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaTecnicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichaTecnicas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichaTecnicas_CategoriaId",
                table: "FichaTecnicas",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichaTecnicas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
