using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly Context _context;

        public VehiculosController(Context context)
        {
            _context = context;
        }

        //[HttpGet("Detalle\{DetalleId}")]
        //public async Task<ActionResult<VehiculosDetalles>> ObtenerVenta(int DetalleId)
        //{
        //    var venta = await _context.VehiculosDetalles.Include(v => v.VehiculosDetalles).FirstOrDefaultAsync(v => v.VentaId == DetalleId);

        //    if (venta == null)
        //    {
        //        return NotFound();
        //    }

        //    return venta;
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculos>>> GetVehiculosList()
        {
            var vehiculos = await _context.Vehiculos.ToListAsync();

            if (vehiculos == null || vehiculos.Count == 0)
            {
                return NotFound();
            }

            return vehiculos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculos>> GetVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        [HttpPost]
        public async Task<ActionResult<Vehiculos>> PostVehiculo(Vehiculos vehiculo)
        {
            if (vehiculo.VehiculoId == 0)
            {
                _context.Vehiculos.Add(vehiculo);
            }
            else
            {
                _context.Vehiculos.Update(vehiculo);
            }

            await _context.SaveChangesAsync();
            return Ok(vehiculo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
