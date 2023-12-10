using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vehiculos{

    [Key]

    public int VehiculoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    [EnumDataType(typeof(MarcasValidas), ErrorMessage = "Marca no válida.")]
    public string Marca { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Este campo es necesario")]
    [StringLength(50, ErrorMessage = "La longitud máxima del modelo es de 50 caracteres.")]
    public string Modelo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [StringLength(50, ErrorMessage = "La longitud máxima del tipo de vehículo es de 50 caracteres.")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(1900, 2100, ErrorMessage = "Por favor, ingrese un año válido.")]
    [RegularExpression(@"^\d{4}$", ErrorMessage = "Por favor, ingrese un año válido de cuatro dígitos.")]
    public string Anio { get; set; } =string.Empty;

    public bool Vendido { get; set; } = false;

    [Required(ErrorMessage = "Este campo es necesario")]
    [Range(1000, 20000, ErrorMessage = "* El campo Precio debe estar entre 1000 y 20000")]
    public double Precio { get; set; }

    public string? Imagen { get; set;}

    public double Existencia { get; set; }

    public enum MarcasValidas
    {
        Toyota, Honda, Ford, Isuzu, Audi,
        Ford_Mustang, Hyundai, SWM, Chevrolet_Corvette, Kia, 
        Mini, BMW, Lexus, Suzuki, Nissan,
        Mitsubishi, Citroen, Alfa_Rome, Bugatti, Lamborghini,
        Ferrari, Koenigsegg, Acura, Dodge, Jeep,
    }

    [ForeignKey("VehiculoId")]
    public ICollection<VehiculosDetalles> VehiculosDetalles { get; set; } = new List<VehiculosDetalles>();
}