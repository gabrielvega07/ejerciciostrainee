using Ejercicio182.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejercicio182.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColegiosController : ControllerBase
    {
        private readonly DBContexto _context;

        public ColegiosController(DBContexto context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colegio>>> GetColegios()
        {
            return await _context.Colegios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Colegio>> GetColegio(int id)
        {
            var colegio = await _context.Colegios.FindAsync(id);

            if (colegio == null)
            {
                return NotFound();
            }

            return colegio;
        }

        [HttpPost]
        public async Task<ActionResult<Colegio>> PostColegio(Colegio colegio)
        {
            _context.Colegios.Add(colegio);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetColegio), new { id = colegio.Id }, colegio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutColegio(int id, Colegio colegio)
        {
            if (id != colegio.Id)
            {
                return BadRequest();
            }

            _context.Entry(colegio).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColegio(int id)
        {
            var colegio = await _context.Colegios.FindAsync(id);

            if (colegio == null)
            {
                return NotFound();
            }

            _context.Colegios.Remove(colegio);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
