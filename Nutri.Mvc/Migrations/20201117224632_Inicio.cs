using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nutri.Mvc.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPreparacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FichaTecnica",
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
                    table.PrimaryKey("PK_FichaTecnica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichaTecnica_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichaTecnica_CategoriaId",
                table: "FichaTecnica",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichaTecnica");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
