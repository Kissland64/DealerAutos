using System.ComponentModel.DataAnnotations;

public class Marca{
    
    [Key]

    public int MarcaId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    public DateTime FechaCreacion { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Modelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Tipo { get; set; } = string.Empty;

    public double Existencia { get; set; }

    public string? Imagen { get; set;}
}