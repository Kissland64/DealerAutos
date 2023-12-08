using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Data1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RutaImagen",
                table: "Vehiculos");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 12, 8, 1, 14, 36, 523, DateTimeKind.Local).AddTicks(443));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RutaImagen",
                table: "Vehiculos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8078), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8097), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8099), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8100), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8102), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8105), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8107), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8108), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8110), "" });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                columns: new[] { "Fecha", "RutaImagen" },
                values: new object[] { new DateTime(2023, 12, 7, 20, 54, 47, 693, DateTimeKind.Local).AddTicks(8112), "" });
        }
    }
}
