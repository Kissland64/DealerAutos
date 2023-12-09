using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculos{

    [Key]

    public int VehiculoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Marca { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Modelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Anio { get; set; } =string.Empty;

    public bool Vendido { get; set; } = false;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(1000, 20000, ErrorMessage = "* El campo Precio debe estar entre 1000 y 20000")]
    public double Precio { get; set; }

    public string? Imagen { get; set;}

    public double Existencia { get; set; }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}