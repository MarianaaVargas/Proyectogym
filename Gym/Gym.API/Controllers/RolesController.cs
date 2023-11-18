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
            return Ok(await _context.Roles.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Roles = await _context.Roles.FirstOrDefaultAsync(x => x.Id_Rol == id);
            if (Roles == null)
            {
                return NotFound();
            }

            return Ok(Roles);

        }
        [HttpPost]
        public async Task<IActionResult> post(Roles roles)
        {
            _context.Add(roles);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Roles roles)
        {
            _context.Update(roles);
            await _context.SaveChangesAsync();
            return Ok(roles);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Roles
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














