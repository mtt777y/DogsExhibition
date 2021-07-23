using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GogsExhibition;
using GogsExhibition.Classes;
using NLog;
using GogsExhibition.Controllers.Abstraction;

namespace GogsExhibition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeShowsController : OverloadedController
    {
        public TypeShowsController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }


        // GET: api/TypeShows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeShow>>> GetTypesShow()
        {
            return await _context.TypesShow.ToListAsync();
        }

        // GET: api/TypeShows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeShow>> GetTypeShow(int id)
        {
            var typeShow = await _context.TypesShow.FindAsync(id);

            if (typeShow == null)
            {
                return NotFound();
            }

            return typeShow;
        }

        // PUT: api/TypeShows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeShow(int id, TypeShow typeShow)
        {
            if (id != typeShow.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeShow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeShowExists(id))
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

        // POST: api/TypeShows
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeShow>> PostTypeShow(TypeShow typeShow)
        {
            _context.TypesShow.Add(typeShow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeShow", new { id = typeShow.Id }, typeShow);
        }

        // DELETE: api/TypeShows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeShow(int id)
        {
            var typeShow = await _context.TypesShow.FindAsync(id);
            if (typeShow == null)
            {
                return NotFound();
            }

            _context.TypesShow.Remove(typeShow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeShowExists(int id)
        {
            return _context.TypesShow.Any(e => e.Id == id);
        }
    }
}
