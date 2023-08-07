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
            if(_context.Ventas == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Ventas.ToListAsync();
            }
        }

        [HttpGet("{VentaId}")]
        public async Task<ActionResult<Ventas>> ObtenerVenta(int VentaId)
        {
            if(_context.Ventas == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas.Include(v => v.VehiculosDetalles).Where(v => v.VentaId == VentaId).FirstOrDefaultAsync();

            if(venta == null)
            {
                return NotFound();
            }

            foreach(var item in venta.VehiculosDetalles)
            {
                Console.WriteLine($"{item.DetalleId}, {item.VentaId}, {item.VehiculoId}, {item.Precio}");
            }

            return venta;
        }

        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            if(!Existe(ventas.VentaId))
            {
                Vehiculos? vehiculos = new Vehiculos();

                foreach(var vehiculoAgotado in ventas.VehiculosDetalles)
                {
                    vehiculos = _context.Vehiculos.Find(vehiculoAgotado.VehiculoId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia -= vehiculoAgotado.Precio;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                    }
                }
                await _context.Ventas.AddAsync(ventas);
            }
            else
            {
                var ventaAnterior = _context.Ventas.Include(v => v.VehiculosDetalles).AsNoTracking()
                .FirstOrDefault(v => v.VentaId == ventas.VentaId);

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
                                vehiculos.Existencia += vehiculoAgotado.Precio;
                                _context.Vehiculos.Update(vehiculos);
                                await _context.SaveChangesAsync();
                                _context.Entry(vehiculos).State = EntityState.Detached;
                            }
                        }
                    }
                }

                if(ventaAnterior != null)
                {
                    vehiculos  = _context.Vehiculos.Find(ventaAnterior.VentaId);

                    if(vehiculos != null)
                    {
                        vehiculos.Existencia -= ventaAnterior.Total;
                        _context.Vehiculos.Update(vehiculos);
                        await _context.SaveChangesAsync();
                        _context.Entry(vehiculos).State = EntityState.Detached;
                    }
                }

                _context.Database.ExecuteSql($"Delete from VentasDetalle where VentaId = {ventas.VentaId}");

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

                vehiculos = _context.Vehiculos.Find(ventas.VentaId);

                if(vehiculos != null)
                {
                    vehiculos.Existencia += ventas.Total;
                    _context.Vehiculos.Update(vehiculos);
                    await _context.SaveChangesAsync();
                    _context.Entry(vehiculos).State = EntityState.Detached;
                }
                _context.Ventas.Update(ventas);
            }

            await _context.SaveChangesAsync();
            _context.Entry(ventas).State = EntityState.Detached;
            return Ok(ventas);
        }

        [HttpDelete("{VentaId}")]
        public async Task<IActionResult> EliminarVenta(int VentaId)
        {
            var venta = await _context.Ventas.Include(v => v.VehiculosDetalles).FirstOrDefaultAsync(v => v.VentaId == VentaId);

            if(venta == null)
            {
                return NotFound();
            }

            foreach(var vehiculoAgotado in venta.VehiculosDetalles)
            {
                var vehiculos = await _context.Vehiculos.FindAsync(vehiculoAgotado.VehiculoId);

                if(vehiculos != null)
                {
                    vehiculos.Existencia += vehiculoAgotado.Precio;
                    _context.Vehiculos.Update(vehiculos);
                }
            }

            var vehiculoInicial = await _context.Vehiculos.FindAsync(venta.VentaId);

            if(vehiculoInicial != null)
            {
                vehiculoInicial.Existencia += venta.Total;
                _context.Vehiculos.Update(vehiculoInicial);
            }

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}