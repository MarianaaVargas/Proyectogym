using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


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

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Actividades = await _context.Actividades.FirstOrDefaultAsync(x =>x.Id_Actividad == id);
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
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Actividades actividades)
        {
            _context.Update(actividades);
            await _context.SaveChangesAsync();
            return Ok(actividades);
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




    

    


    
        

    

