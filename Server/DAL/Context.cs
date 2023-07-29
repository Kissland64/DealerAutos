using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<Marca> Marca { get; set; }
}