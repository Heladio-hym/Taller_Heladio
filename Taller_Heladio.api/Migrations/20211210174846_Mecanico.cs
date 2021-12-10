using Microsoft.EntityFrameworkCore.Migrations;

namespace Taller_Heladio.api.Migrations
{
    public partial class Mecanico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Proveedor_IdProveedor",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradaDetalle_Entrada_IdEntrada",
                table: "EntradaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradaDetalle_Refaccion_IdRefaccion",
                table: "EntradaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_Refaccion_Categoria_IdCategoria",
                table: "Refaccion");

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Refaccion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Proveedor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "IdRefaccion",
                table: "EntradaDetalle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEntrada",
                table: "EntradaDetalle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdProveedor",
                table: "Entrada",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Proveedor_IdProveedor",
                table: "Entrada",
                column: "IdProveedor",
                principalTable: "Proveedor",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradaDetalle_Entrada_IdEntrada",
                table: "EntradaDetalle",
                column: "IdEntrada",
                principalTable: "Entrada",
                principalColumn: "IdEntrada",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradaDetalle_Refaccion_IdRefaccion",
                table: "EntradaDetalle",
                column: "IdRefaccion",
                principalTable: "Refaccion",
                principalColumn: "IdRefaccion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refaccion_Categoria_IdCategoria",
                table: "Refaccion",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Proveedor_IdProveedor",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradaDetalle_Entrada_IdEntrada",
                table: "EntradaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradaDetalle_Refaccion_IdRefaccion",
                table: "EntradaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_Refaccion_Categoria_IdCategoria",
                table: "Refaccion");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Proveedor");

            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Refaccion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdRefaccion",
                table: "EntradaDetalle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdEntrada",
                table: "EntradaDetalle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdProveedor",
                table: "Entrada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Proveedor_IdProveedor",
                table: "Entrada",
                column: "IdProveedor",
                principalTable: "Proveedor",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradaDetalle_Entrada_IdEntrada",
                table: "EntradaDetalle",
                column: "IdEntrada",
                principalTable: "Entrada",
                principalColumn: "IdEntrada",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradaDetalle_Refaccion_IdRefaccion",
                table: "EntradaDetalle",
                column: "IdRefaccion",
                principalTable: "Refaccion",
                principalColumn: "IdRefaccion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Refaccion_Categoria_IdCategoria",
                table: "Refaccion",
                column: "IdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
