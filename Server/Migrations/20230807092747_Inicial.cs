using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealerAutos.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    CantidadAdquirida = table.Column<double>(type: "REAL", nullable: false),
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
                    NombreComprador = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Anio = table.Column<string>(type: "TEXT", nullable: false),
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    Total = table.Column<double>(type: "REAL", nullable: false)
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
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "CompraDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Cantidad = table.Column<double>(type: "REAL", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "VehiculosDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculosDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_VehiculosDetalles_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "VehiculoId", "Anio", "Existencia", "Imagen", "Marca", "Modelo", "Placa", "Precio", "Tipo", "Total" },
                values: new object[,]
                {
                    { 1, "2021", 5.0, "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg", "Honda", "CR-V", "G520423", 6745.0, "Jeepeta", 0.0 },
                    { 2, "2022", 5.0, "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg", "Honda", "Civic", "J134998", 5340.0, "Sedán", 0.0 },
                    { 3, "2023", 5.0, "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm", "Isuzu", "D-MAX", "H722423", 8950.0, "Camioneta", 0.0 },
                    { 4, "2023", 4.0, "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg", "Audi", "A3 S-Line", "A432539", 9500.0, "Compacto", 0.0 },
                    { 5, "2010", 3.0, "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg", "Ford Mustang", "PREMIUM", "E926184", 6700.0, "Deportivo", 0.0 },
                    { 6, "2018", 3.0, "https://img.supercarros.com/AdsPhotos/500x500/0/9819611.jpg", "Hyundai", "Sonata New Rise", "T748510", 5000.0, "Sedán", 0.0 },
                    { 7, "2023", 2.0, "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg", "SWM", "G01F", "P426591", 7000.0, "Jeepeta", 0.0 },
                    { 8, "2020", 2.0, "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg", "Chevrolet Corvette", "Stingray Z51", "F102607", 9000.0, "Deportivo", 0.0 },
                    { 9, "2018", 2.0, "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg", "Kia", "Picanto", "B892415", 2000.0, "Compacto", 0.0 },
                    { 10, "2016", 1.0, "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad", "Mini", "Cooper Countryman", "A397148", 3000.0, "Coupé/Deportivo", 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompraDetalles_CompraId",
                table: "CompraDetalles",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalles_VentaId",
                table: "VehiculosDetalles",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "VehiculosDetalles");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
