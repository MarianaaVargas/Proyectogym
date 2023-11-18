using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext? _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.usuarios.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Usuarios = await _context.usuarios.FirstOrDefaultAsync(x => x.Id_Usuarios == id);
            if (Usuarios == null)
            {
                return NotFound();
            }

            return Ok(Usuarios);

        }
        [HttpPost]
        public async Task<IActionResult> post(Usuarios usuarios)
        {
            _context.Add(usuarios);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Usuarios usuarios)
        {
            _context.Update(usuarios);
            await _context.SaveChangesAsync();
            return Ok(usuarios);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.usuarios
                .Where(c => c.Id_Usuarios == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














