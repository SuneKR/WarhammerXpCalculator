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
    public class ExperienceLogsController : ControllerBase
    {
        private readonly WarhammerXpCalcDB _context;

        public ExperienceLogsController(WarhammerXpCalcDB context)
        {
            _context = context;
        }

        // GET: api/ExperienceLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExperienceLog>>> GetExperienceLogs()
        {
            return await _context.ExperienceLogs.ToListAsync();
        }

        // GET: api/ExperienceLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExperienceLog>> GetExperienceLog(int id)
        {
            var experienceLog = await _context.ExperienceLogs.FindAsync(id);

            if (experienceLog == null)
            {
                return NotFound();
            }

            return experienceLog;
        }

        // GET: api/ExperienceLogs/{id}
        //Returns all ExperienceLogs belonging to single character
        [HttpGet("c{id}")]
        public async Task<ActionResult<IEnumerable<ExperienceLog>>> GetExperienceLogsByCharacterId(int id)
        {

            var logSet = await _context.ExperienceLogs.Where(l => l.CharacterId == id).ToListAsync();

            if (logSet == null || logSet.Count == 0) { return NotFound(); }

            return logSet;
        }

        // PUT: api/ExperienceLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExperienceLog(int id, ExperienceLog experienceLog)
        {
            if (id != experienceLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(experienceLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienceLogExists(id))
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

        // POST: api/ExperienceLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExperienceLog>> PostExperienceLog(ExperienceLog experienceLog)
        {
            _context.ExperienceLogs.Add(experienceLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExperienceLog", new { id = experienceLog.Id }, experienceLog);
        }

        // DELETE: api/ExperienceLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperienceLog(int id)
        {
            var experienceLog = await _context.ExperienceLogs.FindAsync(id);
            if (experienceLog == null)
            {
                return NotFound();
            }

            _context.ExperienceLogs.Remove(experienceLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExperienceLogExists(int id)
        {
            return _context.ExperienceLogs.Any(e => e.Id == id);
        }
    }
}
