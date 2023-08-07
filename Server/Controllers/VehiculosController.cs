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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculos>>> GetVehiculos()
        {
            var vehiculos = await _context.Vehiculos.ToListAsync();

            if (vehiculos == null || vehiculos.Count == 0)
            {
                return NotFound();
            }

            return vehiculos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculos>> GetVehiculos(int id)
        {
            var vehiculos = await _context.Vehiculos.FindAsync(id);

            if (vehiculos == null)
            {
                return NotFound();
            }

            return vehiculos;
        }

        [HttpPost]
        public async Task<ActionResult<Vehiculos>> PostVehiculos(Vehiculos vehiculos)
        {
            if (vehiculos.VehiculoId == 0)
            {
                _context.Vehiculos.Add(vehiculos);
            }
            else
            {
                _context.Vehiculos.Update(vehiculos);
            }

            await _context.SaveChangesAsync();
            return Ok(vehiculos);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculos(int id)
        {
            var vehiculos = await _context.Vehiculos.FindAsync(id);
            if (vehiculos == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(vehiculos);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}