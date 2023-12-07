using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CompraDetalles");

            migrationBuilder.DropTable(
                name: "LoginDTO");

            migrationBuilder.DropTable(
                name: "SesionDTO");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Ventas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Existencia",
                table: "Vehiculos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                columns: new[] { "Existencia", "Fecha" },
                values: new object[] { 5.0, new DateTime(2023, 12, 6, 17, 13, 31, 333, DateTimeKind.Local).AddTicks(8850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Vehiculos");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    CantidadAdquirida = table.Column<double>(type: "REAL", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    NombreComprador = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "LoginDTO",
                columns: table => new
                {
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDTO", x => x.Correo);
                });

            migrationBuilder.CreateTable(
                name: "SesionDTO",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesionDTO", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "CompraDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cantidad = table.Column<double>(type: "REAL", nullable: false),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_CompraDetalles_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Vehiculos",
                keyColumn: "VehiculoId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2023, 8, 7, 17, 32, 43, 775, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.CreateIndex(
                name: "IX_CompraDetalles_CompraId",
                table: "CompraDetalles",
                column: "CompraId");
        }
    }
}
