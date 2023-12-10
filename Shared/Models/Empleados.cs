using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Empleados
{
    [Key]

    public int EmpleadoId { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
    public string Nombre { get; set;} =string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
    public string Apellido { get; set;} = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Por favor, ingrese un DNI válido de ocho dígitos.")]
    public string DNI { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El formato de la cédula no es válido. Debe ser XXX-XXXXXXX-X.")]
    public string Cedula { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es necesario")]
    [StringLength(100, ErrorMessage = "La dirección no puede tener más de 100 caracteres.")]
    public string Direccion { get; set; } = string.Empty;
}   