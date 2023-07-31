using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculos{

    [Key]

    public int VehiculoId { get; set; }

    public int MarcaId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    public string Anio { get; set; } =string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(7,7,ErrorMessage = "Es necesario 7 caracteres {1} y {2}")]
    public string Placa { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }

    public string Descripcion { get; set; } = string.Empty;

    public double Existencia { get; set; }

    public string? Imagen { get; set;}

    public int CantidadEnposesion { get; set; }

    public double Total { get; set; }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}