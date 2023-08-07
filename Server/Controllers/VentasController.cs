using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VentasController : ControllerBase
    {
        private readonly Context _context;

        public VentasController(Context context)
        {
            _context = context;
        }

        public bool Existe(int VentaId)
        {
            return (_context.Ventas?.Any(c => c.VentaId == VentaId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ventas>>> Obtener()
        {
            if(_context.Ventas == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Ventas.ToListAsync();
            }
        }

        [HttpGet("{VentasId}")]
        public async Task<ActionResult<Ventas>> ObtenerVentas(int VentaId)
        {
            
            if(_context.Ventas == null)
            {
                return NotFound();
            }
            var ventas = await _context.Ventas.Include(e => e.VehiculosDetalles).Where( e => e.VentaId == VentaId).FirstOrDefaultAsync();
            if(ventas == null)
            {
                return NotFound();
            }
            foreach(var item in ventas.VehiculosDetalles)
            {
                Console.WriteLine($"{item.DetalleId}, {item.VentaId}, {item.VehiculoId}, {item.Precio}");
            }

            return ventas;
        }
        
        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            if(!Existe(ventas.VentaId))
            {
                //Vehiculos? vehiculos = new Vehiculos();
                foreach(var vehiculoAgotado in ventas.VehiculosDetalles)
                {
                   var vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia -= 1;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                    }
                }
                await _context.Ventas.AddAsync(ventas);
            }
            else
            {
                var ventaAnterior = _context.Ventas.Include(e => e.VehiculosDetalles).AsNoTracking()
                .FirstOrDefault(c => c.VentaId == ventas.VentaId);

                Vehiculos? vehiculos = new Vehiculos();

                if(ventaAnterior != null && ventaAnterior.VehiculosDetalles != null)
                {
                    foreach(var vehiculoAgotado in ventaAnterior.VehiculosDetalles)
                    {
                        if(vehiculoAgotado != null)
                        {
                            vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                            if(vehiculos != null)
                            {
                                vehiculos.Existencia +=  vehiculoAgotado.Precio;
                                _context.Vehiculos.Update(vehiculos);
                                await _context.SaveChangesAsync();
                                _context.Entry(vehiculos).State = EntityState.Detached;
                            }   
                        }
                    }
                }

                _context.Database.ExecuteSqlRaw($"Delete from ventaDetalle where VentaId = {ventas.VentaId}");

                foreach(var vehiculoAgotado in ventas.VehiculosDetalles)
                {
                    vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia -= vehiculoAgotado.Precio;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                        _context.Entry(vehiculoAgotado).State = EntityState.Added;
                    }
                }
                _context.Ventas.Update(ventas);
            }

            await _context.SaveChangesAsync();
            _context.Entry(ventas).State = EntityState.Detached;
            return Ok(ventas);
        }

        [HttpDelete("{VentaId}")]
        public async Task<IActionResult> EliminarVentas(int VentaId)
        {
            var ventas = await _context.Ventas.Include(e => e.VehiculosDetalles).FirstOrDefaultAsync(c => c.VentaId == VentaId);

            if (ventas == null)
            {
                return NotFound();
            }

            foreach (var detalle in ventas.VehiculosDetalles)
            {
                var vehiculos = await _context.Vehiculos.FindAsync(detalle.VehiculoId);

                if (vehiculos != null)
                {
                    vehiculos.Existencia += detalle.Precio;
                    _context.Vehiculos.Update(vehiculos);
                }
            }
            _context.Ventas.Remove(ventas);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}