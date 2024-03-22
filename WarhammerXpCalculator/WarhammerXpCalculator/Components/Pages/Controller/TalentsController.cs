using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarhammerXpCalculator.Models;

namespace WarhammerXpCalculator.Components.Pages.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentsController : ControllerBase
    {
        private readonly WarhammerXpCalcDB _context;

        public TalentsController(WarhammerXpCalcDB context)
        {
            _context = context;
        }

        // GET: api/Talents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Talents>>> GetTalents()
        {
            return await _context.Talents.ToListAsync();
        }

        // GET: api/Talents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Talents>> GetTalents(int id)
        {
            var talents = await _context.Talents.FindAsync(id);

            if (talents == null)
            {
                return NotFound();
            }

            return talents;
        }

        // PUT: api/Talents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTalents(int id, Talents talents)
        {
            if (id != talents.Id)
            {
                return BadRequest();
            }

            _context.Entry(talents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalentsExists(id))
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

        // POST: api/Talents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Talents>> PostTalents(Talents talents)
        {
            _context.Talents.Add(talents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTalents", new { id = talents.Id }, talents);
        }

        // DELETE: api/Talents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTalents(int id)
        {
            var talents = await _context.Talents.FindAsync(id);
            if (talents == null)
            {
                return NotFound();
            }

            _context.Talents.Remove(talents);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TalentsExists(int id)
        {
            return _context.Talents.Any(e => e.Id == id);
        }
    }
}
