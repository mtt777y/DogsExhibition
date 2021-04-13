using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GogsExhibition;
using GogsExhibition.Classes;

namespace GogsExhibition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexesController : ControllerBase
    {
        private readonly DbSets _context;

        public SexesController(DbSets context)
        {
            _context = context;
        }

        // GET: api/Sexes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sex>>> GetSexs()
        {
            return await _context.Sexs.ToListAsync();
        }

        // GET: api/Sexes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sex>> GetSex(int id)
        {
            var sex = await _context.Sexs.FindAsync(id);

            if (sex == null)
            {
                return NotFound();
            }

            return sex;
        }

        // PUT: api/Sexes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSex(int id, Sex sex)
        {
            if (id != sex.Id)
            {
                return BadRequest();
            }

            _context.Entry(sex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SexExists(id))
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

        // POST: api/Sexes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sex>> PostSex(string strsex)
        {
            Sex sex = new Sex() { Name = strsex};
            _context.Sexs.Add(sex);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSex", new { id = sex.Id }, sex);
        }

        // DELETE: api/Sexes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSex(int id)
        {
            var sex = await _context.Sexs.FindAsync(id);
            if (sex == null)
            {
                return NotFound();
            }

            _context.Sexs.Remove(sex);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SexExists(int id)
        {
            return _context.Sexs.Any(e => e.Id == id);
        }
    }
}
