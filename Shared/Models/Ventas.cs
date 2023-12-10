using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ventas{
    
    [Key]

    public int VentaId { get; set; }

    [ForeignKey("EmpleadoId")]
    public int EmpleadoId { get; set; }

    public int VehiculoId { get; set; }

    public double CantidadAgregada {get; set;}

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
    public string Apellido { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El formato de la cédula no es válido. Debe ser XXX-XXXXXXX-X.")]
    public string Cedula { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [StringLength(30, ErrorMessage = "La dirección no puede tener más de 30 caracteres.")]
    public string Direccion { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Total { get; set; }

    [ForeignKey("VentaId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}