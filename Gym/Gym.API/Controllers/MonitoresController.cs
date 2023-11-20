using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;
using Gym.Shared.Entities;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/monitores")]
    public class MonitoresController : ControllerBase
    {
        private readonly DataContext? _context;

        public MonitoresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Monitores.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Monitores = await _context.Monitores.FirstOrDefaultAsync(x => x.Id_Monitor == id);
            if (Monitores == null)
            {
                return NotFound();
            }

            return Ok(Monitores);

        }
        [HttpPost]
        public async Task<IActionResult> post(Monitores monitores)
        {
            _context.Add(monitores);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Monitores monitores)
        {
            _context.Update(monitores);
            await _context.SaveChangesAsync();
            return Ok(monitores);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Monitores
                .Where(c => c.Id_Monitor == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














