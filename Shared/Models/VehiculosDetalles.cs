using System.ComponentModel.DataAnnotations;

public class VehiculosDetalles
{
    [Key]
    public int DetalleId { get; set; }
    public int VentaId { get; set; }
    public int VehiculoId { get; set; }
    public int ClienteId { get; set; } 
    public int CompraId { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public int CantidadAquirida { get; set; }
}