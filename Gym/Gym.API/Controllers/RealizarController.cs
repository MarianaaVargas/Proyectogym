using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/realizar")]
    public class RealizarController: ControllerBase
    {
        private readonly DataContext? _context;

        public RealizarController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.realizar.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Realizar = await _context.realizar.FirstOrDefaultAsync(x => x.Id == id);
            if (Realizar == null)
            {
                return NotFound();
            }

            return Ok(Realizar);

        }
        [HttpPost]
        public async Task<IActionResult> post(Realizar realizar)
        {
            _context.Add(realizar);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Realizar realizar)
        {
            _context.Update(realizar);
            await _context.SaveChangesAsync();
            return Ok(realizar);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.realizar
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














