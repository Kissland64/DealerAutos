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

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(7,7,ErrorMessage = "Es necesario 7 caracteres {1} y {2}")]
    public string Placa { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }

    public double Existencia { get; set; }

    public string? Imagen { get; set;}

    public double Total { get; set; }
}