using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;
using Gym.Shared.DTOs;


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
        [HttpGet("totalPages")]
        public async Task<ActionResult> GetPages([FromQuery] PaginationDTO pagination)
        {
            var queryable = _context.planEntrenamiento.AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Observaciones.ToLower().Contains(pagination.Filter.ToLower()));
            }

            double count = await queryable.CountAsync();
            double totalPages = Math.Ceiling(count / pagination.RecordsNumber);
            return Ok(totalPages);
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
            try { 
            await _context.SaveChangesAsync();
            return Ok(planEntrenamiento);
                
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un plan de entrenamiento con el mismo nombre o Id.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }


        }

        [HttpPut]
        public async Task<ActionResult> Put(PlanEntrenamiento planEntrenamiento )
        {
            _context.Update(planEntrenamiento);
            try { 
            await _context.SaveChangesAsync();
            return Ok(planEntrenamiento);
                
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un registro con el mismo nombre o Id.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
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














