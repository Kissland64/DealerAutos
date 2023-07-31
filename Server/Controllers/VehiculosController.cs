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

        public bool Existe(int VehiculoId)
        {
            return (_context.Vehiculos?.Any(c => c.VehiculoId == VehiculoId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculos>>> Obtener()
        {
            if(_context.Vehiculos == null)
            {
                return NotFound();
            }
            else
            {
                
                return await _context.Vehiculos.ToListAsync();
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Vehiculos>> ObtenerVehiculos(int VehiculoId)
        {
            if(_context.Vehiculos == null)
            {
                return NotFound();
            }
            
            var vehiculo = await _context.Vehiculos.Include(c => c.VehiculosDetalles).Where(v => v.VehiculoId == VehiculoId).FirstOrDefaultAsync();

            if(vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> EliminarVehiculos(int VehiculoId)
        {
            var vehiculo = await _context.Vehiculos.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(v => v.VehiculoId == VehiculoId);

            if(vehiculo == null)
            {
                return NotFound();
            }

            foreach(var MarcaVehiculo in vehiculo.VehiculosDetalles)
            {
                var marca = await _context.Marca.FindAsync(MarcaVehiculo.MarcaId);

                if(marca != null)
                {
                    marca.Existencia -= MarcaVehiculo.CantidadAquirida;
                    _context.Marca.Update(marca);
                }
            }

            var marcaInicial = await _context.Marca.FindAsync(vehiculo.MarcaId);

            if(marcaInicial != null)
            {
                marcaInicial.Existencia -= vehiculo.CantidadEnposesion;
                _context.Marca.Update(marcaInicial);
            }

            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Vehiculos>> PostVehiculos(Vehiculos vehiculos)
        {
            if(!Existe(vehiculos.VehiculoId))
            {
                Marca? marca = new Marca();

                foreach(var MarcaVehiculo in vehiculos.VehiculosDetalles)
                {
                    marca = _context.Marca.Find(MarcaVehiculo.MarcaId);

                    if(marca != null)
                    {
                        marca.Existencia += MarcaVehiculo.CantidadAquirida;
                        _context.Marca.Update(marca);
                        await _context.SaveChangesAsync();
                        _context.Entry(marca).State = EntityState.Detached;
                    }
                }
                await _context.Vehiculos.AddAsync(vehiculos);
            }
            else
            {
                var vehiculoAnterior = _context.Vehiculos.Include(v => v.VehiculosDetalles).AsNoTracking()
                .FirstOrDefault(v => v.VehiculoId == vehiculos.VehiculoId);

                Marca? marca = new Marca();

                if(vehiculoAnterior != null && vehiculoAnterior.VehiculosDetalles != null)
                {
                    foreach(var MarcaVehiculo in vehiculoAnterior.VehiculosDetalles)
                    {
                        if(MarcaVehiculo != null)
                        {
                            marca = _context.Marca.Find(MarcaVehiculo.VehiculoId);

                            if(marca != null)
                            {
                                marca.Existencia -= MarcaVehiculo.CantidadAquirida;
                                _context.Marca.Update(marca);
                                await _context.SaveChangesAsync();
                                _context.Entry(marca).State = EntityState.Detached;
                            }
                        }
                    }
                }

                if(vehiculoAnterior != null)
                {
                    marca  = _context.Marca.Find(vehiculoAnterior.VehiculoId);

                    if(marca != null)
                    {
                        marca.Existencia += vehiculoAnterior.CantidadEnposesion;
                        _context.Marca.Update(marca);
                        await _context.SaveChangesAsync();
                        _context.Entry(marca).State = EntityState.Detached;
                    }
                }

                _context.Database.ExecuteSql($"Delete from VehiculosDetalles where VehiculoId = {vehiculos.VehiculoId}");

                foreach(var MarcaVehiculo in vehiculos.VehiculosDetalles)
                {
                    marca = _context.Marca.Find(MarcaVehiculo.MarcaId);

                    if(marca != null)
                    {
                        marca.Existencia += MarcaVehiculo.CantidadAquirida;
                        _context.Marca.Update(marca);
                        await _context.SaveChangesAsync();
                        _context.Entry(marca).State = EntityState.Detached;
                        _context.Entry(MarcaVehiculo).State = EntityState.Added;
                    }
                }

                marca = _context.Marca.Find(vehiculos.MarcaId);

                if(marca != null)
                {
                    marca.Existencia -= vehiculos.CantidadEnposesion;
                    _context.Marca.Update(marca);
                    await _context.SaveChangesAsync();
                    _context.Entry(marca).State = EntityState.Detached;
                }
                _context.Vehiculos.Update(vehiculos);
            }
            await _context.SaveChangesAsync();
            _context.Entry(vehiculos).State = EntityState.Detached;
            return Ok(vehiculos);
        }
    }
}