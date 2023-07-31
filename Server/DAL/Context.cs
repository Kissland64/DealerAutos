using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Marca> Marca { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vehiculos>().HasData(new List<Vehiculos>()
        {
            new Vehiculos
            {VehiculoId = 1, Imagen = "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg" ,
            Nombre ="Honda CR-V", Anio ="2021", Placa = "G520423", Precio = 6745, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 2, Imagen = "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg",
            Nombre ="Honda Civic", Anio ="2022", Placa = "J134998", Precio = 5340, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 3, Imagen = "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm",
            Nombre ="Isuzu D-MAX", Anio ="2023", Placa = "H722423", Precio = 8950, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 4, Imagen = "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg",
            Nombre ="Audi A3 S-Line", Anio = "2023", Placa = "A432539", Precio = 9500, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 5, Imagen = "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg",
            Nombre ="Ford Mustang PREMIUM", Anio ="2010", Placa = "E926184", Precio = 6700, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 6, Imagen = "https://img.supercarros.com/AdsPhotos/500x500/0/9819611.jpg",
            Nombre ="Hyundai Sonata New Rise", Anio ="2018", Placa = "T748510", Precio = 5000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 7, Imagen = "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg",
            Nombre ="SWM G01F", Anio ="2023", Placa = "P426591", Precio = 7000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 8, Imagen = "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg",
            Nombre ="Chevrolet Corvette Stingray Z51", Anio ="2020", Placa = "F102607", Precio = 9000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 9, Imagen = "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg",
            Nombre ="Kia Picanto", Anio ="2018", Placa = "B892415", Precio = 2000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 10, Imagen = "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad",
            Nombre ="Mini Cooper Countryman", Anio ="2016", Placa = "A397148", Precio = 3000, Existencia = 2,},
        });
        modelBuilder.Entity<Marca>().HasData(new List<Marca>()
        {
            new Marca
            {MarcaId = 1, Imagen = "https://static.vecteezy.com/system/resources/previews/020/335/963/original/honda-logo-honda-icon-free-free-vector.jpg",
            Nombre ="Honda", FechaCreacion = new DateTime(1948-09-24), Modelo = "CR-V", Tipo = "Jeepeta",},
            new Marca
            {MarcaId = 2, Imagen = "https://static.vecteezy.com/system/resources/previews/020/335/963/original/honda-logo-honda-icon-free-free-vector.jpg",
            Nombre ="Honda", FechaCreacion = new DateTime(1948-09-24), Modelo = "Civic", Tipo = "Sedán",},
            new Marca
            {MarcaId = 3, Imagen = "https://logowik.com/content/uploads/images/562_audi.jpg",
            Nombre ="Audi", FechaCreacion = new DateTime(1909-07-16), Modelo = "A3 S-Line", Tipo = "Compacto",},
            new Marca
            {MarcaId = 4, Imagen = "https://www.carlogos.org/logo/Isuzu-logo-1974-3000x3000.png",
            Nombre ="Isuzu", FechaCreacion = new DateTime(1916-11-10), Modelo = "D-MAX", Tipo = "Camioneta",},
            new Marca
            {MarcaId = 5, Imagen = "https://img.remediosdigitales.com/437262/2009_ford_mustang_badge/450_1000.jpg",
            Nombre ="Ford Mustang", FechaCreacion = new DateTime(1964-04-17), Modelo = "PREMIUM", Tipo = "Deportivo",},
            new Marca
            {MarcaId = 6, Imagen = "https://memolira.com/wp-content/uploads/2020/08/1600px-Hyundai_26379413755-e1596664023773.jpg",
            Nombre ="Hyundai", FechaCreacion = new DateTime(1967-12-29), Modelo = "Sonata New Rise", Tipo = "Sedán",},
            new Marca
            {MarcaId = 7, Imagen = "https://static.vecteezy.com/system/resources/previews/009/184/053/original/swm-letter-logo-design-with-polygon-shape-swm-polygon-and-cube-shape-logo-design-swm-hexagon-logo-template-white-and-black-colors-swm-monogram-business-and-real-estate-logo-vector.jpg",
            Nombre ="SWM", FechaCreacion = new DateTime(1971-06-11), Modelo = "G01F", Tipo = "Jeepeta",},
            new Marca
            {MarcaId = 8, Imagen = "https://w7.pngwing.com/pngs/838/136/png-transparent-2014-chevrolet-corvette-corvette-stingray-car-chevrolet-corvette-z06-car.png",
            Nombre ="Chevrolet Corvette", FechaCreacion = new DateTime(2013-01-13), Modelo = "Stingray Z51", Tipo = "Deportivo",},
            new Marca
            {MarcaId = 9, Imagen = "https://www.wfla.com/wp-content/uploads/sites/71/2021/03/Kia.jpg?w=1280",
            Nombre ="Kia", FechaCreacion = new DateTime(1944-12-11), Modelo = "Picanto", Tipo = "Compacto",},
            new Marca
            {MarcaId = 10, Imagen = "https://img.remediosdigitales.com/f31872/logo-mini/450_1000.jpg",
            Nombre ="Mini", FechaCreacion = new DateTime(1969-01-24), Modelo = "Cooper Countryman", Tipo = "Coupé/Deportivo",},
        });
    }
}