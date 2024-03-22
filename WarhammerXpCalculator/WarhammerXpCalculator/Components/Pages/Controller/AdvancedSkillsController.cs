using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarhammerXpCalculator.Models;
using WarhammerXpCalculator.Models.Skills;

namespace WarhammerXpCalculator.Components.Pages.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancedSkillsController : ControllerBase
    {
        private readonly WarhammerXpCalcDB _context;

        public AdvancedSkillsController(WarhammerXpCalcDB context)
        {
            _context = context;
        }

        // GET: api/AdvancedSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdvancedSkill>>> GetAdvancedSkills()
        {
            return await _context.AdvancedSkills.ToListAsync();
        }

        // GET: api/AdvancedSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdvancedSkill>> GetAdvancedSkill(int id)
        {
            var advancedSkill = await _context.AdvancedSkills.FindAsync(id);

            if (advancedSkill == null)
            {
                return NotFound();
            }

            return advancedSkill;
        }

        [HttpGet("/c{id}")]
        public async Task<ActionResult<IEnumerable<AdvancedSkill>>> GetAdvancedSkillByCharacterId(int id)
        {

            var aSkillSet = await _context.AdvancedSkills.Where(ads => ads.CharacterId == id).ToListAsync();

            if (aSkillSet == null || aSkillSet.Count == 0) { return NotFound(); }

            return aSkillSet;
        }

        // PUT: api/AdvancedSkills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvancedSkill(int id, AdvancedSkill advancedSkill)
        {
            if (id != advancedSkill.Id)
            {
                return BadRequest();
            }

            _context.Entry(advancedSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvancedSkillExists(id))
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

        // POST: api/AdvancedSkills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdvancedSkill>> PostAdvancedSkill(AdvancedSkill advancedSkill)
        {
            _context.AdvancedSkills.Add(advancedSkill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdvancedSkill", new { id = advancedSkill.Id }, advancedSkill);
        }

        // DELETE: api/AdvancedSkills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdvancedSkill(int id)
        {
            var advancedSkill = await _context.AdvancedSkills.FindAsync(id);
            if (advancedSkill == null)
            {
                return NotFound();
            }

            _context.AdvancedSkills.Remove(advancedSkill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdvancedSkillExists(int id)
        {
            return _context.AdvancedSkills.Any(e => e.Id == id);
        }
    }
}
