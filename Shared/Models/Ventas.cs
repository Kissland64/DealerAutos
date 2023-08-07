using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ventas{
    
    [Key]

    public int VentaId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Apellido { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Cedula { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Direccion { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Total { get; set; }

    [ForeignKey("VentaId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}