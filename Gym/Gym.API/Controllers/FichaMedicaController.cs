using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/fichamedica")]
    public class FichaMedicaController: ControllerBase
    {
        private readonly DataContext? _context;

        public FichaMedicaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.FichaMedica.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var FichaMedica = await _context.FichaMedica.FirstOrDefaultAsync(x => x.Id_Ficha == id);
            if (FichaMedica == null)
            {
                return NotFound();
            }

            return Ok(FichaMedica);

        }
        [HttpPost]
        public async Task<IActionResult> post(FichaMedica fichaMedica)
        {
            _context.Add(fichaMedica);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(FichaMedica fichaMedica)
        {
            _context.Update(fichaMedica);
            await _context.SaveChangesAsync();
            return Ok(fichaMedica);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.FichaMedica
                .Where(c => c.Id_Ficha == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














