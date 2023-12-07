using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Vehiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalles_Vehiculos_VentaId",
                table: "VehiculosDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalles_Ventas_VehiculoId",
                table: "VehiculosDetalles");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 23, 36, 245, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalles_Vehiculos_VehiculoId",
                table: "VehiculosDetalles",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalles_Ventas_VentaId",
                table: "VehiculosDetalles",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalles_Vehiculos_VehiculoId",
                table: "VehiculosDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculosDetalles_Ventas_VentaId",
                table: "VehiculosDetalles");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 20, 19, 49, 1, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalles_Vehiculos_VentaId",
                table: "VehiculosDetalles",
                column: "VentaId",
                principalTable: "Vehiculos",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculosDetalles_Ventas_VehiculoId",
                table: "VehiculosDetalles",
                column: "VehiculoId",
                principalTable: "Ventas",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
