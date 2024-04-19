using DentistDataBaseApp.Data;
using DentistDataBaseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DentistDataBaseApp.Controllers
{
    public class csharp
    {
        [ApiController]
        [Route("api/[controller]")]
        public class DentistsController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public DentistsController(ApplicationDbContext context)
            {
                _context = context;
            }

            // POST: api/Dentists
            [HttpPost]
            public async Task<ActionResult<Dentist>> PostDentist(Dentist dentist)
            {
                _context.Dentist.Add(dentist);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetDentist", new { id = dentist.Id }, dentist);
            }

            // GET: api/Dentists
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Dentist>>> GetDentists()
            {
                return await _context.Dentist.ToListAsync();
            }

            // GET: api/Dentists/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Dentist>> GetDentist(int id)
            {
                var dentist = await _context.Dentist.FindAsync(id);

                if (dentist == null)
                {
                    return NotFound();
                }

                return dentist;
            }

            // PUT: api/Dentists/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutDentist(int id, Dentist dentist)
            {
                if (id != dentist.Id)
                {
                    return BadRequest();
                }

                _context.Entry(dentist).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DentistExists(id))
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

            // DELETE: api/Dentists/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteDentist(int id)
            {
                var dentist = await _context.Dentist.FindAsync(id);
                if (dentist == null)
                {
                    return NotFound();
                }

                _context.Dentist.Remove(dentist);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool DentistExists(int id)
            {
                return _context.Dentist.Any(e => e.Id == id);
            }
        }

    }
}
