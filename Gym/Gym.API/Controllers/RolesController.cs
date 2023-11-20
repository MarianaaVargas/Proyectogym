using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/roles")]
    public class RolesController : ControllerBase
    {
        private readonly DataContext? _context;

        public RolesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Rol.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Rol = await _context.Rol.FirstOrDefaultAsync(x => x.Id_Rol == id);
            if (Rol == null)
            {
                return NotFound();
            }

            return Ok(Rol);

        }
        [HttpPost]
        public async Task<IActionResult> post(Roles rol)
        {
            _context.Add(rol);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Roles rol)
        {
            _context.Update(rol);
            await _context.SaveChangesAsync();
            return Ok(rol);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Rol
                .Where(c => c.Id_Rol == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














