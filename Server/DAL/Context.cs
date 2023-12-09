using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Empleados> Empleados { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Compras> Compras { get; set; }
    public DbSet<VehiculosDetalles> VehiculosDetalles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vehiculos>().HasData(new List<Vehiculos>()
        {
            new Vehiculos
            {VehiculoId = 1, Imagen = "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg" ,
            Marca ="Honda", Modelo ="CR-V", Tipo ="Jeepeta", Anio ="2021", Precio = 6745, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 2, Imagen = "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg",
            Marca ="Honda", Modelo ="Civic", Tipo ="Sedán", Anio ="2022", Precio = 5340, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 3, Imagen = "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm",
            Marca ="Isuzu", Modelo ="D-MAX", Tipo ="Camioneta", Anio ="2023", Precio = 8950, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 4, Imagen = "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg",
            Marca ="Audi", Modelo ="A3 S-Line", Tipo ="Compacto", Anio = "2023", Precio = 9500, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 5, Imagen = "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg",
            Marca ="Ford Mustang", Modelo ="PREMIUM", Tipo ="Deportivo", Anio ="2010", Precio = 6700, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 6, Imagen = "https://img.supercarros.com/AdsPhotos/1024x768/0/11145289.jpg?wmo=08ba5e0a5f4c288ae8e9e6a1dd4b7e5962c1cab6b6265e400f229da56f718809cf87e80713186756a4df4a205b1655e81d4bb982212a95d7a746b9ebc17c6f91",
            Marca ="Hyundai", Modelo ="Sonata New Rise", Tipo ="Sedán", Anio ="2018", Precio = 5000, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 7, Imagen = "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg",
            Marca ="SWM", Modelo ="G01F", Tipo ="Jeepeta", Anio ="2023", Precio = 7000, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 8, Imagen = "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg",
            Marca ="Chevrolet Corvette", Modelo ="Stingray Z51", Tipo ="Deportivo", Anio ="2020", Precio = 9000, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 9, Imagen = "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg",
            Marca ="Kia", Modelo ="Picanto", Tipo ="Compacto", Anio ="2018", Precio = 2000, Existencia = 5,},
            new Vehiculos
            {VehiculoId = 10, Imagen = "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad",
            Marca ="Mini", Modelo ="Cooper Countryman", Tipo ="Coupé/Deportivo", Anio ="2016", Precio = 3000, Existencia = 5,},
        });

        modelBuilder.Entity<Usuario>().HasData(new List<Usuario>()
        {
            new Usuario(){
                UsuarioId = 1,
                NombreCompleto = "Kissland Baker",
                FechaNacimiento = new DateTime(2001, 4, 6),
                NombreUsuario = "Admin",
                Email = "admin@gmail.com",
                Password = "Admin(6423)",
                Rol = 1 },

            new Usuario(){
                UsuarioId = 2,
                NombreCompleto = "Keury Rodriguez",
                FechaNacimiento = new DateTime(2002, 5, 8),
                NombreUsuario = "Cliente",
                Email = "Keury@gmail.com",
                Password = "Keury(6423)",
                Rol = 2 },
        });

        modelBuilder.Entity<Rol>().HasData(new List<Rol>()
        {
            new Rol(){ RolId = 1, NombreRol = "Administrador" },
            new Rol(){ RolId = 2, NombreRol = "Cliente" },
        });
    }
}