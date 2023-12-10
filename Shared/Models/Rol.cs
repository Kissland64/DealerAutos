using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rol
{
    [Key]
    public int RolId { get; set; } 

    public string? NombreRol { get; set; } 
}