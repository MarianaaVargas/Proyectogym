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
            try { 
            await _context.SaveChangesAsync();
            return Ok(clientes);
             
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un cliente con el mismo nombre o Id.");
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
        public async Task<ActionResult> Put(Clientes clientes)
        {
            _context.Update(clientes);
            try { 
            await _context.SaveChangesAsync();
            return Ok(clientes);
               
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














