using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Clientes
{
    [Key]

    public int ClienteId { get; set; }

    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set;} =string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Apellido { get; set;} = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Cedula { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Direccion { get; set; } = string.Empty;

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}