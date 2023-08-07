using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculos{

    [Key]

    public int VehiculoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Marca { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Modelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Anio { get; set; } =string.Empty;

    public bool Vendido { get; set; } = false;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }

    public string? Imagen { get; set;}
}