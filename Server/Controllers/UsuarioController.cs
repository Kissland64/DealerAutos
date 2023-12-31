using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DealerAutos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            return await _context.Usuarios.ToListAsync();
        }

        [HttpGet("GetRoles")]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoles()
        {

            var roles = await _context.Roles.ToListAsync();
            if (roles == null || roles.Count == 0)
            {
                return NotFound();
            }
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuarios(int id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var Usuarios = _context.Usuarios
                .Where(u => u.UsuarioId == id)
                .Include(c => c.Compras)
                .AsNoTracking()
                .SingleOrDefault();

            if (Usuarios == null)
            {
                return NotFound();
            }

            return Usuarios;
        }


        public bool UsuarioExiste(int id)
        {
            return (_context.Usuarios?.Any(u => u.UsuarioId == id)).GetValueOrDefault();
        }


        [HttpPost]
        public async Task<ActionResult<Usuario>> GetUsuarios(Usuario Usuarios)
        {
            if (!UsuarioExiste(Usuarios.UsuarioId))
                _context.Usuarios.Add(Usuarios);
            else
                _context.Usuarios.Update(Usuarios);
            await _context.SaveChangesAsync();
            return Ok(Usuarios);
        }

        [HttpGet("GetByUsername/{username}")]
        public async Task<ActionResult<Usuario>> GetUserByUsername(string username)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.NombreUsuario == username);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var Usuarios = await _context.Usuarios.FindAsync(id);
            if (Usuarios == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(Usuarios);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("AuthenticateUser")]
        public ActionResult<Usuario> AuthenticateUser([FromBody] Login loginModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid login data");
                }
                var user = _context.Usuarios.FirstOrDefault(u => u.Email == loginModel.Email);
                if (user == null)
                {

                    return NotFound("User not found.");
                }
                if (user.Password == loginModel.Password)
                {
                    return user;
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");

            }
        }

    }
}