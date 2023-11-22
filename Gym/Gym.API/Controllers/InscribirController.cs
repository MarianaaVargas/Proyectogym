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
            var Inscribir= await _context.inscribir.FirstOrDefaultAsync(x => x.Id_Inscripcion == id);
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
            try { 
            await _context.SaveChangesAsync();
            return Ok(inscribir);
                
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una inscripcion con el mismo Id.");
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
        public async Task<ActionResult> Put(Inscribir inscribir)
        {
            _context.Update(inscribir);
            try { 
            await _context.SaveChangesAsync();
            return Ok(inscribir);
                
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un registro con el mismo Id.");
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

            var filaafectada = await _context.inscribir 
                .Where(c => c.Id_Inscripcion == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














