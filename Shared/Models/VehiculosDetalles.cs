using System.ComponentModel.DataAnnotations;

public class VehiculosDetalles
{
    [Key]
    public int DetalleId { get; set; }
    public int VentaId { get; set; }
    public int VehiculoId { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }
    public double Cantidad { get; set; }
    public double Existencia { get; set; }
    public double CantidadAgregada {get; set;}
}