using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Vehi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cantidad",
                table: "VehiculosDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 18, 7, 49, 726, DateTimeKind.Local).AddTicks(8158));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "VehiculosDetalles");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8850));
        }
    }
}
