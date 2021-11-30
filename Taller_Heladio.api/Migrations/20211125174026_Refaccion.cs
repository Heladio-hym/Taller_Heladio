using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Taller_Heladio.api.Migrations
{
    public partial class Refaccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    IdEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: true),
                    Estatus = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.IdEntrada);
                    table.ForeignKey(
                        name: "FK_Entrada_Proveedor_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Refaccion",
                columns: table => new
                {
                    IdRefaccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: true),
                    Existencia = table.Column<double>(type: "float", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refaccion", x => x.IdRefaccion);
                    table.ForeignKey(
                        name: "FK_Refaccion_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntradaDetalle",
                columns: table => new
                {
                    IdEntradaDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEntrada = table.Column<int>(type: "int", nullable: true),
                    IdRefaccion = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaDetalle", x => x.IdEntradaDetalle);
                    table.ForeignKey(
                        name: "FK_EntradaDetalle_Entrada_IdEntrada",
                        column: x => x.IdEntrada,
                        principalTable: "Entrada",
                        principalColumn: "IdEntrada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntradaDetalle_Refaccion_IdRefaccion",
                        column: x => x.IdRefaccion,
                        principalTable: "Refaccion",
                        principalColumn: "IdRefaccion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_IdProveedor",
                table: "Entrada",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaDetalle_IdEntrada",
                table: "EntradaDetalle",
                column: "IdEntrada");

            migrationBuilder.CreateIndex(
                name: "IX_EntradaDetalle_IdRefaccion",
                table: "EntradaDetalle",
                column: "IdRefaccion");

            migrationBuilder.CreateIndex(
                name: "IX_Refaccion_IdCategoria",
                table: "Refaccion",
                column: "IdCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradaDetalle");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Refaccion");
        }
    }
}
