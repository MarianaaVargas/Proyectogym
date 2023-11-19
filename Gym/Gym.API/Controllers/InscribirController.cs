using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/inscribir")]
    public class InscribirController : ControllerBase
    {
        private readonly DataContext? _context;

        public InscribirController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.inscribir.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Inscribir= await _context.inscribir.FirstOrDefaultAsync(x => x.Id == id);
            if (Inscribir == null)
            {
                return NotFound();
            }

            return Ok(Inscribir);

        }
        [HttpPost]
        public async Task<IActionResult> post(Inscribir inscribir)
        {
            _context.Add(inscribir);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Inscribir inscribir)
        {
            _context.Update(inscribir);
            await _context.SaveChangesAsync();
            return Ok(inscribir);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.inscribir 
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














