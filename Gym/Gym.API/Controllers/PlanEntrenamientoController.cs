using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/planentrenamiento")]
    public class PlanEntrenamientoController : ControllerBase
    {
        private readonly DataContext? _context;

        public PlanEntrenamientoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.planEntrenamiento.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var PlanEntrenamiento  = await _context.planEntrenamiento.FirstOrDefaultAsync(x => x.Id_Plan == id);
            if (PlanEntrenamiento == null)
            {
                return NotFound();
            }

            return Ok(PlanEntrenamiento);

        }
        [HttpPost]
        public async Task<IActionResult> post(PlanEntrenamiento planEntrenamiento)
        {
            _context.Add(planEntrenamiento);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(PlanEntrenamiento planEntrenamiento )
        {
            _context.Update(planEntrenamiento);
            await _context.SaveChangesAsync();
            return Ok(planEntrenamiento);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.planEntrenamiento
                .Where(c => c.Id_Plan == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














