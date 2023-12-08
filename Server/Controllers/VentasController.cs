using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Client.Controllers
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

        private bool Existe(int VentaId)
        {
            return _context.Ventas.Any(v => v.VentaId == VentaId);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ventas>>> Obtener()
        {
            return await _context.Ventas.Include(v => v.VehiculosDetalles).ToListAsync();
        }

        [HttpGet("{VentaId}")]
        public async Task<ActionResult<Ventas>> ObtenerVenta(int VentaId)
        {
            var venta = await _context.Ventas.Include(v => v.VehiculosDetalles).FirstOrDefaultAsync(v => v.VentaId == VentaId);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarVehiculo(int id, [FromBody] Vehiculos vehiculo)
        {
            try
            {
                var vehiculoExistente = await _context.Vehiculos.FindAsync(id);

                if (vehiculoExistente == null)
                {
                    return NotFound();
                }

                vehiculoExistente.Precio = vehiculo.Precio;
                vehiculoExistente.Existencia = vehiculo.Existencia;

                _context.Vehiculos.Update(vehiculoExistente);
                await _context.SaveChangesAsync();

                return Ok(vehiculoExistente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }


        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            if (!Existe(ventas.VentaId))
            {
                await _context.Ventas.AddAsync(ventas);
                foreach (var detalle in ventas.VehiculosDetalles)
                {
                    var vehiculo = await _context.Vehiculos.FindAsync(detalle.VehiculoId);
                    if (vehiculo != null)
                    {
                        vehiculo.Existencia -= detalle.Cantidad;
                    }
                }
            }

            else
            {
                Ventas Anterior = await _context.Ventas
                    .Include(v => v.VehiculosDetalles)
                    .AsNoTracking()
                    .SingleOrDefaultAsync(v => v.VentaId == ventas.VentaId);

                if (Anterior != null)
                {
                    foreach (var detalle in Anterior.VehiculosDetalles)
                    {
                        var vehiculoAnterior = await _context.Vehiculos.FindAsync(detalle.VehiculoId);
                        if (vehiculoAnterior != null)
                        {
                            detalle.Cantidad++;
                            vehiculoAnterior.Existencia += detalle.Cantidad;
                        }
                        detalle.Cantidad--;
                    }

                    _context.RemoveRange(Anterior.VehiculosDetalles);
                    await _context.SaveChangesAsync();
                    await _context.AddRangeAsync(ventas.VehiculosDetalles);

                    _context.Update(ventas);
                }
            }

            foreach (var detalle in ventas.VehiculosDetalles)
            {
                var vehiculo = await _context.Vehiculos.FindAsync(detalle.VehiculoId);
                if (vehiculo != null)
                {
                    detalle.Cantidad++;
                    vehiculo.Existencia -= detalle.Cantidad;
                }
                detalle.Cantidad--;
            }

            await _context.SaveChangesAsync();
            return Ok(ventas);
        }


        [HttpDelete("{VentaId}")]
        public async Task<IActionResult> EliminarVenta(int VentaId)
        {
            var venta = await _context.Ventas.Include(v => v.VehiculosDetalles).FirstOrDefaultAsync(v => v.VentaId == VentaId);

            if (venta == null)
            {
                return NotFound();
            }

            foreach (var detalle in venta.VehiculosDetalles)
            {
                var vehiculo = await _context.Vehiculos.FindAsync(detalle.VehiculoId);
                if (vehiculo != null)
                {
                    detalle.Cantidad++;
                    vehiculo.Existencia += detalle.Cantidad;
                }
                detalle.Cantidad--;
            }

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}