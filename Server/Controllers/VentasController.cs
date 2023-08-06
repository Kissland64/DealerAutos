using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ventas>>> GetVentas()
        {
            var ventas = await _context.Ventas.ToListAsync();

            return Ok(ventas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ventas>> GetVentas(int id)
        {
            var ventas = await _context.Ventas.FindAsync(id);

            if (ventas == null)
            {
                return NotFound();
            }

            return Ok(ventas);
        }

        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            if (ventas.VentaId == 0)
            {
                _context.Ventas.Add(ventas);
            }
            else
            {
                _context.Ventas.Update(ventas);
            }

            await _context.SaveChangesAsync();
            return Ok(ventas);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVentas(int id)
        {
            var ventas = await _context.Ventas.FindAsync(id);
            if (ventas == null)
            {
                return NotFound();
            }

            _context.Ventas.Remove(ventas);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
