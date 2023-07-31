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
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Anio = table.Column<string>(type: "TEXT", nullable: false),
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadEnposesion = table.Column<int>(type: "INTEGER", nullable: false),
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
                    DireccionVenta = table.Column<string>(type: "TEXT", nullable: false),
                    Ciudad = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "VehiculosDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    CantidadAquirida = table.Column<int>(type: "INTEGER", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "Existencia", "Fecha", "FechaCreacion", "Imagen", "Modelo", "Nombre", "Tipo" },
                values: new object[,]
                {
                    { 1, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1915), "https://static.vecteezy.com/system/resources/previews/020/335/963/original/honda-logo-honda-icon-free-free-vector.jpg", "CR-V", "Honda", "Jeepeta" },
                    { 2, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1915), "https://static.vecteezy.com/system/resources/previews/020/335/963/original/honda-logo-honda-icon-free-free-vector.jpg", "Civic", "Honda", "Sedán" },
                    { 3, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1886), "https://logowik.com/content/uploads/images/562_audi.jpg", "A3 S-Line", "Audi", "Compacto" },
                    { 4, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1895), "https://www.carlogos.org/logo/Isuzu-logo-1974-3000x3000.png", "D-MAX", "Isuzu", "Camioneta" },
                    { 5, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1943), "https://img.remediosdigitales.com/437262/2009_ford_mustang_badge/450_1000.jpg", "PREMIUM", "Ford Mustang", "Deportivo" },
                    { 6, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1926), "https://memolira.com/wp-content/uploads/2020/08/1600px-Hyundai_26379413755-e1596664023773.jpg", "Sonata New Rise", "Hyundai", "Sedán" },
                    { 7, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1954), "https://static.vecteezy.com/system/resources/previews/009/184/053/original/swm-letter-logo-design-with-polygon-shape-swm-polygon-and-cube-shape-logo-design-swm-hexagon-logo-template-white-and-black-colors-swm-monogram-business-and-real-estate-logo-vector.jpg", "G01F", "SWM", "Jeepeta" },
                    { 8, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6653), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), "https://w7.pngwing.com/pngs/838/136/png-transparent-2014-chevrolet-corvette-corvette-stingray-car-chevrolet-corvette-z06-car.png", "Stingray Z51", "Chevrolet Corvette", "Deportivo" },
                    { 9, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6655), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1921), "https://www.wfla.com/wp-content/uploads/sites/71/2021/03/Kia.jpg?w=1280", "Picanto", "Kia", "Compacto" },
                    { 10, 0.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1944), "https://img.remediosdigitales.com/f31872/logo-mini/450_1000.jpg", "Cooper Countryman", "Mini", "Coupé/Deportivo" }
                });

            migrationBuilder.InsertData(
                table: "Vehiculos",
                columns: new[] { "VehiculoId", "Anio", "CantidadEnposesion", "Descripcion", "Existencia", "Fecha", "Imagen", "MarcaId", "Nombre", "Placa", "Precio", "Total" },
                values: new object[,]
                {
                    { 1, "2021", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6536), "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg", 0, "Honda CR-V", "G520423", 6745.0, 0.0 },
                    { 2, "2022", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6558), "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg", 0, "Honda Civic", "J134998", 5340.0, 0.0 },
                    { 3, "2023", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6561), "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm", 0, "Isuzu D-MAX", "H722423", 8950.0, 0.0 },
                    { 4, "2023", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6563), "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg", 0, "Audi A3 S-Line", "A432539", 9500.0, 0.0 },
                    { 5, "2010", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6565), "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg", 0, "Ford Mustang PREMIUM", "E926184", 6700.0, 0.0 },
                    { 6, "2018", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6571), "https://img.supercarros.com/AdsPhotos/500x500/0/9819611.jpg", 0, "Hyundai Sonata New Rise", "T748510", 5000.0, 0.0 },
                    { 7, "2023", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6572), "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg", 0, "SWM G01F", "P426591", 7000.0, 0.0 },
                    { 8, "2020", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6574), "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg", 0, "Chevrolet Corvette Stingray Z51", "F102607", 9000.0, 0.0 },
                    { 9, "2018", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6577), "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg", 0, "Kia Picanto", "B892415", 2000.0, 0.0 },
                    { 10, "2016", 0, "", 2.0, new DateTime(2023, 7, 31, 15, 44, 37, 166, DateTimeKind.Local).AddTicks(6580), "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad", 0, "Mini Cooper Countryman", "A397148", 3000.0, 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalles_VehiculoId",
                table: "VehiculosDetalles",
                column: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "VehiculosDetalles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
