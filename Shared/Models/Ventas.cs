using System.ComponentModel.DataAnnotations;

public class Ventas{
    
    [Key]

    public int VentaId { get; set; }
    
    [Required(ErrorMessage = "Este campo es necesario")]
    public string Vehiculos { get; set; } =string.Empty;

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
    public string DireccionVenta { get; set;} = string.Empty;
    
    [Required(ErrorMessage = "Este campo es necesario")]
    public string Ciudad { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }
}