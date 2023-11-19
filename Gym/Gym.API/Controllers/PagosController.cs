﻿using Gym.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gym.Shared.Entidades;


namespace Gym.API.Controllers

{
    [ApiController]
    [Route("/api/pagos")]
    public class PagosController : ControllerBase
    {
        private readonly DataContext? _context;

        public PagosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Pagos.ToListAsync());
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            var Pagos = await _context.Pagos.FirstOrDefaultAsync(x => x.Id_Pagos == id);
            if (Pagos == null)
            {
                return NotFound();
            }

            return Ok(Pagos);

        }
        [HttpPost]
        public async Task<IActionResult> post(Pagos pagos)
        {
            _context.Add(pagos);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Pagos pagos)
        {
            _context.Update(pagos);
            await _context.SaveChangesAsync();
            return Ok(pagos);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Pagos
                .Where(c => c.Id_Pagos == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}














