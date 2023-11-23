using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;
using System.Linq;
using Gym.Shared.DTOs;



namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/actividades")]
    public class ActividadesController : ControllerBase
    {
        private readonly DataContext? _context;

        public ActividadesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Actividades.ToListAsync());
        }
        [HttpGet("totalPages")]
        public async Task<ActionResult> GetPages([FromQuery] PaginationDTO pagination)
        {
            var queryable = _context.Actividades.AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Nombre.ToLower().Contains(pagination.Filter.ToLower()));
            }

            double count = await queryable.CountAsync();
            double totalPages = Math.Ceiling(count / pagination.RecordsNumber);
            return Ok(totalPages);
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Actividades = await _context.Actividades.FirstOrDefaultAsync(x => x.Id_Actividad == id);
            if (Actividades == null)
            {
                return NotFound();
            }

            return Ok(Actividades);

        }
        [HttpPost]
        public async Task<IActionResult> post(Actividades actividades)
        {
            _context.Add(actividades);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(actividades);
            }

            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una actividad con el mismo nombre o Id.");
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
        public async Task<ActionResult> Put(Actividades actividades)
        {
            _context.Update(actividades);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(actividades);
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

            var filaafectada = await _context.Actividades
                .Where(c => c.Id_Actividad == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














