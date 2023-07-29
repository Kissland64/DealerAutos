using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculos{

    [Key]

    public int VehiculoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set; } = string.Empty;

    public DateTime FechaLlegada { get; set; }

    public DateTime FechaCreacion { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Color { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Placa { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}