using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly Context _context;

        public ClientesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> ObtenerClientes()
        {
            return await _context.Clientes.Include(c => c.VehiculosDetalles).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> ObtenerClientePorId(int id)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public async Task<ActionResult<Clientes>> AgregarCliente(Clientes cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ObtenerClientePorId), new { id = cliente.ClienteId }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarCliente(int id, Clientes cliente)
        {
            if (id != cliente.ClienteId)
            {
                return BadRequest();
            }

            var clienteExistente = await _context.Clientes.FindAsync(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            _context.Entry(clienteExistente).CurrentValues.SetValues(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{clienteId}/Vehiculos")]
        public async Task<ActionResult<IEnumerable<VehiculosDetalles>>> ObtenerVehiculosPorCliente(int clienteId)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente.VehiculosDetalles.ToList();
        }

        [HttpGet("{clienteId}/Vehiculos/{vehiculoId}")]
        public async Task<ActionResult<VehiculosDetalles>> ObtenerVehiculoPorId(int clienteId, int vehiculoId)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            var vehiculo = cliente.VehiculosDetalles.FirstOrDefault(v => v.VehiculoId == vehiculoId);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        [HttpPost("{clienteId}/Vehiculos")]
        public async Task<ActionResult<VehiculosDetalles>> AgregarVehiculo(int clienteId, VehiculosDetalles vehiculo)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            cliente.VehiculosDetalles.Add(vehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(ObtenerVehiculoPorId), new { clienteId, vehiculoId = vehiculo.VehiculoId }, vehiculo);
        }

        [HttpPut("{clienteId}/Vehiculos/{vehiculoId}")]
        public async Task<ActionResult> ActualizarVehiculo(int clienteId, int vehiculoId, VehiculosDetalles vehiculo)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            var vehiculoExistente = cliente.VehiculosDetalles.FirstOrDefault(v => v.VehiculoId == vehiculoId);
            if (vehiculoExistente == null)
            {
                return NotFound();
            }

            _context.Entry(vehiculoExistente).CurrentValues.SetValues(vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{clienteId}/Vehiculos/{vehiculoId}")]
        public async Task<ActionResult> EliminarVehiculo(int clienteId, int vehiculoId)
        {
            var cliente = await _context.Clientes.Include(c => c.VehiculosDetalles).FirstOrDefaultAsync(c => c.ClienteId == clienteId);

            if (cliente == null)
            {
                return NotFound();
            }

            var vehiculo = cliente.VehiculosDetalles.FirstOrDefault(v => v.VehiculoId == vehiculoId);
            if (vehiculo == null)
            {
                return NotFound();
            }

            cliente.VehiculosDetalles.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}