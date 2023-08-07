using Microsoft.AspNetCore.Http;
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

        public bool Existe(int VentaId)
        {
            return (_context.Ventas?.Any(v => v.VentaId == VentaId)).GetValueOrDefault();
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

        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            if (!Existe(ventas.VentaId))
            {
                await _context.Ventas.AddAsync(ventas);
            }
            else
            {
                Ventas Anterior = await _context.Ventas.Include(v => v.VehiculosDetalles).AsNoTracking().SingleOrDefaultAsync(v => v.VentaId == ventas.VentaId);
                if(Anterior != null)
                {
                    _context.RemoveRange(Anterior.VehiculosDetalles);
                    await _context.SaveChangesAsync();
                    await _context.AddRangeAsync(ventas.VehiculosDetalles);
                    _context.Update(ventas);
                }
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

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}