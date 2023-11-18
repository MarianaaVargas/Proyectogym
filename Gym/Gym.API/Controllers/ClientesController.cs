using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly DataContext? _context;

        public ClientesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Clientes.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Clientes = await _context.Clientes.FirstOrDefaultAsync(x => x.Id_Cliente == id);
            if (Clientes== null)
            {
                return NotFound();
            }

            return Ok(Clientes);

        }
        [HttpPost]
        public async Task<IActionResult> post(Clientes clientes)
        {
            _context.Add(clientes);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Clientes clientes)
        {
            _context.Update(clientes);
            await _context.SaveChangesAsync();
            return Ok(clientes);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Clientes
                .Where(c => c.Id_Cliente == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














