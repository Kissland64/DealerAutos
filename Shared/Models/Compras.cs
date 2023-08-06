using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Compras{

    [Key]

    public int CompraId { get; set; }
    
    public DateTime FechaCompra { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string NombreComprador { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Marca { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Modelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }
}