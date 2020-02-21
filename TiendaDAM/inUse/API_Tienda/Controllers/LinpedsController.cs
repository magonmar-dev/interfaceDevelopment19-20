using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Tienda.Models;

namespace API_Tienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinpedsController : ControllerBase
    {
        private readonly TodoContext _context;

        public LinpedsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Linpeds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Linped>>> GetLinped()
        {
            return await _context.Linped.ToListAsync();
        }

        // GET: api/Linpeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Linped>> GetLinped(string id)
        {
            var linped = await _context.Linped.FindAsync(id);

            if (linped == null)
            {
                return NotFound();
            }

            return linped;
        }

        // PUT: api/Linpeds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinped(string id, Linped linped)
        {
            if (id != linped.pedidoID)
            {
                return BadRequest();
            }

            _context.Entry(linped).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinpedExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Linpeds
        [HttpPost]
        public async Task<ActionResult<Linped>> PostLinped(Linped linped)
        {
            _context.Linped.Add(linped);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LinpedExists(linped.pedidoID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLinped", new { id = linped.pedidoID }, linped);
        }

        // DELETE: api/Linpeds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Linped>> DeleteLinped(string id)
        {
            var linped = await _context.Linped.FindAsync(id);
            if (linped == null)
            {
                return NotFound();
            }

            _context.Linped.Remove(linped);
            await _context.SaveChangesAsync();

            return linped;
        }

        private bool LinpedExists(string id)
        {
            return _context.Linped.Any(e => e.pedidoID == id);
        }
    }
}
