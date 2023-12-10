using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Carrito
{
    public List<Vehiculos>  Vehiculos { get; set; } = new List<Vehiculos>();
}