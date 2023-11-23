using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;
using Gym.Shared.DTOs;


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
        [HttpGet("totalPages")]
        public async Task<ActionResult> GetPages([FromQuery] PaginationDTO pagination)
        {
            var queryable = _context.registros.AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Hora_Entrada.ToLower().Contains(pagination.Filter.ToLower()));
            }

            double count = await queryable.CountAsync();
            double totalPages = Math.Ceiling(count / pagination.RecordsNumber);
            return Ok(totalPages);
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
            try { 
            await _context.SaveChangesAsync();
            return Ok(registros);
                 
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

        [HttpPut]
        public async Task<ActionResult> Put(Registros registros)
        {
            _context.Update(registros);
            try { 
            await _context.SaveChangesAsync();
            return Ok(registros);
                
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














