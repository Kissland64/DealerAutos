using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    DNI = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreRol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NombreUsuario = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Anio = table.Column<string>(type: "TEXT", nullable: false),
                    Vendido = table.Column<bool>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    Existencia = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadAgregada = table.Column<double>(type: "REAL", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehiculosDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Cantidad = table.Column<double>(type: "REAL", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false),
                    CantidadAgregada = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculosDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_VehiculosDetalles_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehiculosDetalles_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "NombreRol" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Empleado" },
                    { 3, "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "FechaNacimiento", "NombreCompleto", "NombreUsuario", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, "admin@gmail.com", new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kissland Baker", "Admin", "Admin(6423)", 1 },
                    { 2, "Keury@gmail.com", new DateTime(2002, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keury Rodriguez", "Cliente", "Keury(6423)", 2 }
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "VehiculoId", "Anio", "Existencia", "Fecha", "Imagen", "Marca", "Modelo", "Precio", "Tipo", "Vendido" },
                values: new object[,]
                {
                    { 1, "2021", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3086), "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg", "Honda", "CR-V", 6745.0, "Jeepeta", false },
                    { 2, "2022", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3104), "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg", "Honda", "Civic", 5340.0, "Sedán", false },
                    { 3, "2023", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3105), "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm", "Isuzu", "D-MAX", 8950.0, "Camioneta", false },
                    { 4, "2023", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3107), "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg", "Audi", "A3_S-Line", 9500.0, "Compacto", false },
                    { 5, "2010", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3108), "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg", "Ford_Mustang", "PREMIUM", 6700.0, "Deportivo", false },
                    { 6, "2018", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3111), "https://img.supercarros.com/AdsPhotos/1024x768/0/11145289.jpg?wmo=08ba5e0a5f4c288ae8e9e6a1dd4b7e5962c1cab6b6265e400f229da56f718809cf87e80713186756a4df4a205b1655e81d4bb982212a95d7a746b9ebc17c6f91", "Hyundai", "Sonata New Rise", 5000.0, "Sedán", false },
                    { 7, "2023", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3113), "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg", "SWM", "G01F", 7000.0, "Jeepeta", false },
                    { 8, "2020", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3114), "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg", "Chevrolet_Corvette", "Stingray Z51", 9000.0, "Deportivo", false },
                    { 9, "2018", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3115), "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg", "Kia", "Picanto", 2000.0, "Compacto", false },
                    { 10, "2016", 5.0, new DateTime(2023, 12, 10, 0, 20, 21, 966, DateTimeKind.Local).AddTicks(3118), "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad", "Mini", "Cooper_Countryman", 3000.0, "Coupé/Deportivo", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioId",
                table: "Compras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalles_VehiculoId",
                table: "VehiculosDetalles",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalles_VentaId",
                table: "VehiculosDetalles",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "VehiculosDetalles");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
