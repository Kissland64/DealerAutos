﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealerAutos.Server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreRol")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            NombreRol = "Administrador"
                        },
                        new
                        {
                            RolId = 2,
                            NombreRol = "Cliente"
                        });
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Email = "admin@gmail.com",
                            FechaNacimiento = new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCompleto = "Kissland Baker",
                            NombreUsuario = "Admin",
                            Password = "Admin(6423)",
                            Rol = 1
                        },
                        new
                        {
                            UsuarioId = 2,
                            Email = "Keury@gmail.com",
                            FechaNacimiento = new DateTime(2002, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCompleto = "Keury Rodriguez",
                            NombreUsuario = "Cliente",
                            Password = "Keury(6423)",
                            Rol = 2
                        });
                });

            modelBuilder.Entity("Vehiculos", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Anio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Vendido")
                        .HasColumnType("INTEGER");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");

                    b.HasData(
                        new
                        {
                            VehiculoId = 1,
                            Anio = "2021",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7474),
                            Imagen = "https://www.motortrend.com/uploads/sites/5/2021/06/2021-Honda-CR-V-Touring.jpg",
                            Marca = "Honda",
                            Modelo = "CR-V",
                            Precio = 6745.0,
                            Tipo = "Jeepeta",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 2,
                            Anio = "2022",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7493),
                            Imagen = "https://www.yankodesign.com/images/design_news/2022/12/first-drive-new-honda-civic-type-r/2022_Honda_Civic-Type-R_Review_yankodesign_Hero.jpg",
                            Marca = "Honda",
                            Modelo = "Civic",
                            Precio = 5340.0,
                            Tipo = "Sedán",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 3,
                            Anio = "2023",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7495),
                            Imagen = "https://images.drive.com.au/driveau/image/upload/c_fill,f_auto,g_auto,h_675,q_auto:eco,w_1200/v1/cms/uploads/a7tgfapzsadx4m3zstqm",
                            Marca = "Isuzu",
                            Modelo = "D-MAX",
                            Precio = 8950.0,
                            Tipo = "Camioneta",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 4,
                            Anio = "2023",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7497),
                            Imagen = "https://www.motortrend.com/uploads/2022/05/2023-Audi-A3-003-front-three-quarter-view.jpg",
                            Marca = "Audi",
                            Modelo = "A3 S-Line",
                            Precio = 9500.0,
                            Tipo = "Compacto",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 5,
                            Anio = "2010",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7498),
                            Imagen = "https://www.gravityautossandysprings.com/galleria_images/2185/2185_main_l.jpg",
                            Marca = "Ford Mustang",
                            Modelo = "PREMIUM",
                            Precio = 6700.0,
                            Tipo = "Deportivo",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 6,
                            Anio = "2018",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7502),
                            Imagen = "https://img.supercarros.com/AdsPhotos/1024x768/0/11145289.jpg?wmo=08ba5e0a5f4c288ae8e9e6a1dd4b7e5962c1cab6b6265e400f229da56f718809cf87e80713186756a4df4a205b1655e81d4bb982212a95d7a746b9ebc17c6f91",
                            Marca = "Hyundai",
                            Modelo = "Sonata New Rise",
                            Precio = 5000.0,
                            Tipo = "Sedán",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 7,
                            Anio = "2023",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7504),
                            Imagen = "https://espaillatmotors.com/wp-content/uploads/2023/02/1-10-scaled.jpg",
                            Marca = "SWM",
                            Modelo = "G01F",
                            Precio = 7000.0,
                            Tipo = "Jeepeta",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 8,
                            Anio = "2020",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7505),
                            Imagen = "https://www.automotiveaddicts.com/wp-content/uploads/2020/11/2020-chevrolet-corvette.jpg",
                            Marca = "Chevrolet Corvette",
                            Modelo = "Stingray Z51",
                            Precio = 9000.0,
                            Tipo = "Deportivo",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 9,
                            Anio = "2018",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7507),
                            Imagen = "https://cdn.motor1.com/images/mgl/YMkY0/s1/lanzamiento-kia-picanto-2018.jpg",
                            Marca = "Kia",
                            Modelo = "Picanto",
                            Precio = 2000.0,
                            Tipo = "Compacto",
                            Vendido = false
                        },
                        new
                        {
                            VehiculoId = 10,
                            Anio = "2016",
                            Existencia = 5.0,
                            Fecha = new DateTime(2023, 12, 8, 22, 40, 53, 937, DateTimeKind.Local).AddTicks(7509),
                            Imagen = "https://images.dealersync.com/cloud/userdocumentprod/2539/Photos/739007/20211111220319765_IMG_0941%20%282%29.jpg?_=69a6fb4e56f60fad1b05f3454c24fd6876d54cad",
                            Marca = "Mini",
                            Modelo = "Cooper Countryman",
                            Precio = 3000.0,
                            Tipo = "Coupé/Deportivo",
                            Vendido = false
                        });
                });

            modelBuilder.Entity("VehiculosDetalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("VehiculoId");

                    b.HasIndex("VentaId");

                    b.ToTable("VehiculosDetalles");
                });

            modelBuilder.Entity("Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Compras", b =>
                {
                    b.HasOne("Usuario", null)
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehiculosDetalles", b =>
                {
                    b.HasOne("Vehiculos", null)
                        .WithMany("VehiculosDetalles")
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ventas", null)
                        .WithMany("VehiculosDetalles")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("Vehiculos", b =>
                {
                    b.Navigation("VehiculosDetalles");
                });

            modelBuilder.Entity("Ventas", b =>
                {
                    b.Navigation("VehiculosDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
