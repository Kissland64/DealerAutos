using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Vehiculos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 51, 41, 26, DateTimeKind.Local).AddTicks(465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 6, 22, 50, 53, 485, DateTimeKind.Local).AddTicks(8874));
        }
    }
}
