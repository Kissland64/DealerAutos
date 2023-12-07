using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Vehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Existencia",
                table: "Vehiculos",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 18, 49, 33, 82, DateTimeKind.Local).AddTicks(9069) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Existencia",
                table: "Vehiculos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5, new DateTime(2023, 12, 6, 18, 46, 51, 964, DateTimeKind.Local).AddTicks(2085) });
        }
    }
}
