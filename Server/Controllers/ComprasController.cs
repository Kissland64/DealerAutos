using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ComprasController : ControllerBase
    {
        private readonly Context _context;

        public ComprasController(Context context)
        {
            _context = context;
        }

        public bool Existe(int CompraId)
        {
            return (_context.Compras?.Any(c => c.CompraId == CompraId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compras>>> Obtener()
        {
            if(_context.Compras == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Compras.ToListAsync();
            }
        }

        [HttpGet("{CompraId}")]
        public async Task<ActionResult<Compras>> ObtenerCompras(int CompraId)
        {
            if(_context.Compras == null)
            {
                return NotFound();
            }

            var Compras = await _context.Compras.Include(e => e.VehiculosDetalles).Where( e => e.CompraId == CompraId).FirstOrDefaultAsync();

            if(Compras == null)
            {
                return NotFound();
            }

            foreach(var item in Compras.VehiculosDetalles)
            {
                Console.WriteLine($"{item.DetalleId}, {item.CompraId}, {item.VehiculoId}, {item.Cantidad}");
            }

            return Compras;
        }
        
        [HttpPost]
        public async Task<ActionResult<Compras>> PostCompras(Compras compras)
        {
            if(!Existe(compras.CompraId))
            {
                Vehiculos? vehiculos = new Vehiculos();
                foreach(var vehiculoAgotado in compras.VehiculosDetalles)
                {
                    vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia += vehiculoAgotado.Cantidad;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                    }
                }
                await _context.Vehiculos.AddAsync(vehiculos);
            }
            else
            {
                var compraAnterior = _context.Compras.Include(e => e.VehiculosDetalles).AsNoTracking()
                .FirstOrDefault(c => c.CompraId == compras.CompraId);

                Vehiculos? vehiculos = new Vehiculos();

                if(compraAnterior != null && compraAnterior.VehiculosDetalles != null)
                {
                    foreach(var vehiculoAgotado in compraAnterior.VehiculosDetalles)
                    {
                        if(vehiculoAgotado != null)
                        {
                            vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                            if(vehiculos != null)
                            {
                                vehiculos.Existencia -=  vehiculoAgotado.Cantidad;
                                _context.Vehiculos.Update(vehiculos);
                                await _context.SaveChangesAsync();
                                _context.Entry(vehiculos).State = EntityState.Detached;
                            }   
                        }
                    }
                }

                _context.Database.ExecuteSqlRaw($"Delete from compraDetalle where CompraId = {compras.CompraId}");

                foreach(var vehiculoAgotado in compras.VehiculosDetalles)
                {
                    vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia += vehiculoAgotado.Cantidad;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                        _context.Entry(vehiculoAgotado).State = EntityState.Added;
                    }
                }
                _context.Compras.Update(compras);
            }

            await _context.SaveChangesAsync();
            _context.Entry(compras).State = EntityState.Detached;
            return Ok(compras);
        }

        [HttpDelete("{CompraId}")]
        public async Task<IActionResult> EliminarCompras(int CompraId)
        {
            var compras = await _context.Compras.Include(e => e.VehiculosDetalles).FirstOrDefaultAsync(c => c.CompraId == CompraId);

            if (compras == null)
            {
                return NotFound();
            }

            foreach (var detalle in compras.VehiculosDetalles)
            {
                var vehiculos = await _context.Vehiculos.FindAsync(detalle.VehiculoId);

                if (vehiculos != null)
                {
                    vehiculos.Existencia -= detalle.Cantidad;
                    _context.Vehiculos.Update(vehiculos);
                }
            }
            _context.Compras.Remove(compras);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}