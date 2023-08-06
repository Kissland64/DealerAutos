using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using DealerAutos.Shared;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly Context _contexto;

    public ClientesController(Context contexto)
    {
        _contexto = contexto;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Clientes>> ObtenerClientes()
    {

        var clientes = _contexto.Clientes.ToList();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public ActionResult<Clientes> ObtenerClientePorId(int id)
    {
        var cliente = _contexto.Clientes.Find(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    [HttpPost]
    public ActionResult<Clientes> AgregarCliente(Clientes cliente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _contexto.Clientes.Add(cliente);
        _contexto.SaveChanges();
        return CreatedAtAction(nameof(ObtenerClientePorId), new { id = cliente.ClienteId }, cliente);
    }

    [HttpPut("{id}")]
    public ActionResult ActualizarCliente(int id, Clientes cliente)
    {
        if (id != cliente.ClienteId)
        {
            return BadRequest();
        }

        var clienteExistente = _contexto.Clientes.Find(id);
        if (clienteExistente == null)
        {
            return NotFound();
        }
        _contexto.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult EliminarCliente(int id)
    {
        var cliente = _contexto.Clientes.Find(id);
        if (cliente == null)
        {
            return NotFound();
        }

        _contexto.Clientes.Remove(cliente);
        _contexto.SaveChanges();
        return NoContent();
    }

    [HttpGet("{clienteId}/Vehiculos")]
    public ActionResult<IEnumerable<Vehiculos>> ObtenerVehiculosPorCliente(int clienteId)
    {
        var cliente = _contexto.Clientes.Find(clienteId);
        if (cliente == null)
        {
            return NotFound();
        }

        var vehiculos = cliente.VehiculosDetalles.ToList();
        return Ok(vehiculos);
    }

    [HttpGet("{clienteId}/Vehiculos/{vehiculoId}")]
    public ActionResult<VehiculosDetalles> ObtenerVehiculoPorId(int clienteId, int vehiculoId)
    {
        var cliente = _contexto.Clientes.Find(clienteId);
        if (cliente == null)
        {
            return NotFound();
        }

        var vehiculo = cliente.VehiculosDetalles.FirstOrDefault(v => v.VehiculoId == vehiculoId);
        if (vehiculo == null)
        {
            return NotFound();
        }

        return Ok(vehiculo);
    }

    [HttpPost("{clienteId}/Vehiculos")]
    public ActionResult<VehiculosDetalles> AgregarVehiculo(int clienteId, VehiculosDetalles vehiculo)
    {
        var cliente = _contexto.Clientes.Find(clienteId);
        if (cliente == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        cliente.VehiculosDetalles.Add(vehiculo);
        _contexto.SaveChanges();
        return CreatedAtAction(nameof(ObtenerVehiculoPorId), new { clienteId, vehiculoId = vehiculo.VehiculoId }, vehiculo);
    }

    [HttpPut("{clienteId}/Vehiculos/{vehiculoId}")]
    public ActionResult ActualizarVehiculo(int clienteId, int vehiculoId)
    {
        var cliente = _contexto.Clientes.Find(clienteId);
        if (cliente == null)
        {
            return NotFound();
        }

        var vehiculoExistente = cliente.VehiculosDetalles.FirstOrDefault(v => v.VehiculoId == vehiculoId);
        if (vehiculoExistente == null)
        {
            return NotFound();
        }
        _contexto.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{clienteId}/Vehiculos/{vehiculoId}")]
    public ActionResult EliminarVehiculo(int clienteId, int vehiculoId)
    {
        var cliente = _contexto.Clientes.Find(clienteId);
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
        _contexto.SaveChanges();
        return NoContent();
    }
}