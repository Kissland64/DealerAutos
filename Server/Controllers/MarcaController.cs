using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly Context _context;

        public MarcasController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marca>>> GetMarcas()
        {
            var marcas = await _context.Marca.ToListAsync();

            if (marcas == null || marcas.Count == 0)
            {
                return NotFound();
            }

            return marcas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Marca>> GetMarcas(int id)
        {
            var marcas = await _context.Marca.FindAsync(id);

            if (marcas == null)
            {
                return NotFound();
            }

            return marcas;
        }

        [HttpPost]
        public async Task<ActionResult<Marca>> PostMarcas(Marca marca)
        {
            if (marca.MarcaId == 0)
            {
                _context.Marca.Add(marca);
            }
            else
            {
                _context.Marca.Update(marca);
            }

            await _context.SaveChangesAsync();
            return Ok(marca);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarcas(int id)
        {
            var marcas = await _context.Marca.FindAsync(id);
            if (marcas == null)
            {
                return NotFound();
            }

            _context.Marca.Remove(marcas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MarcasExists(int id)
        {
            return _context.Marca.Any(p => p.MarcaId == id);
        }
    }
}
