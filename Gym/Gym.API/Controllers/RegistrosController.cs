using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/registros")]
    public class RegistrosController : ControllerBase
    {
        private readonly DataContext? _context;

        public RegistrosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.registros.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Registros = await _context.registros.FirstOrDefaultAsync(x => x.Id_Registro == id);
            if (Registros == null)
            {
                return NotFound();
            }

            return Ok(Registros);

        }
        [HttpPost]
        public async Task<IActionResult> post(Registros registros)
        {
            _context.Add(registros);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Registros registros)
        {
            _context.Update(registros);
            await _context.SaveChangesAsync();
            return Ok(registros);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.registros
                .Where(c => c.Id_Registro == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














