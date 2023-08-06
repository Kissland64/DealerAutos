using System.ComponentModel.DataAnnotations;
using DealerAutos.Shared;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Compras> Compras { get; set; }
    public DbSet<LoginDTO> LoginDTO { get; set; }
    public DbSet<SesionDTO> SesionDTO { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vehiculos>().HasData(new List<Vehiculos>()
        {
            new Vehiculos
            {VehiculoId = 1, Imagen = "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg" ,
            Marca ="Honda", Modelo ="CR-V", Tipo ="Jeepeta", Anio ="2021", Placa = "G520423", Precio = 6745, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 2, Imagen = "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg",
            Marca ="Honda", Modelo ="Civic", Tipo ="Sedán", Anio ="2022", Placa = "J134998", Precio = 5340, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 3, Imagen = "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm",
            Marca ="Isuzu", Modelo ="D-MAX", Tipo ="Camioneta", Anio ="2023", Placa = "H722423", Precio = 8950, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 4, Imagen = "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg",
            Marca ="Audi", Modelo ="A3 S-Line", Tipo ="Compacto", Anio = "2023", Placa = "A432539", Precio = 9500, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 5, Imagen = "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg",
            Marca ="Ford Mustang", Modelo ="PREMIUM", Tipo ="Deportivo", Anio ="2010", Placa = "E926184", Precio = 6700, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 6, Imagen = "https://img.supercarros.com/AdsPhotos/500x500/0/9819611.jpg",
            Marca ="Hyundai", Modelo ="Sonata New Rise", Tipo ="Sedán", Anio ="2018", Placa = "T748510", Precio = 5000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 7, Imagen = "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg",
            Marca ="SWM", Modelo ="G01F", Tipo ="Jeepeta", Anio ="2023", Placa = "P426591", Precio = 7000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 8, Imagen = "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg",
            Marca ="Chevrolet Corvette", Modelo ="Stingray Z51", Tipo ="Deportivo", Anio ="2020", Placa = "F102607", Precio = 9000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 9, Imagen = "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg",
            Marca ="Kia", Modelo ="Picanto", Tipo ="Compacto", Anio ="2018", Placa = "B892415", Precio = 2000, Existencia = 2,},
            new Vehiculos
            {VehiculoId = 10, Imagen = "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad",
            Marca ="Mini", Modelo ="Cooper Countryman", Tipo ="Coupé/Deportivo", Anio ="2016", Placa = "A397148", Precio = 3000, Existencia = 2,},
        });
    }
}