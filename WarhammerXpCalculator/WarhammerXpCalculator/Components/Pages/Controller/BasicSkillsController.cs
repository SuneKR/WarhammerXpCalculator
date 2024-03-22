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
    public class BasicSkillsController : ControllerBase
    {
        private readonly WarhammerXpCalcDB _context;

        public BasicSkillsController(WarhammerXpCalcDB context)
        {
            _context = context;
        }

        // GET: api/BasicSkills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicSkill>>> GetBasicSkill()
        {
            return await _context.BasicSkills.ToListAsync();
        }

        // GET: api/BasicSkills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasicSkill>> GetBasicSkill(int id)
        {
            var basicSkill = await _context.BasicSkills.FindAsync(id);

            if (basicSkill == null)
            {
                return NotFound();
            }

            return basicSkill;
        }

        // PUT: api/BasicSkills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasicSkill(int id, BasicSkill basicSkill)
        {
            if (id != basicSkill.Id)
            {
                return BadRequest();
            }

            _context.Entry(basicSkill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasicSkillExists(id))
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

        // POST: api/BasicSkills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BasicSkill>> PostBasicSkill(BasicSkill basicSkill)
        {
            _context.BasicSkills.Add(basicSkill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BasicSkillExists(basicSkill.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBasicSkill", new { id = basicSkill.Id }, basicSkill);
        }

        // DELETE: api/BasicSkills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasicSkill(int id)
        {
            var basicSkill = await _context.BasicSkills.FindAsync(id);
            if (basicSkill == null)
            {
                return NotFound();
            }

            _context.BasicSkills.Remove(basicSkill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BasicSkillExists(int id)
        {
            return _context.BasicSkills.Any(e => e.Id == id);
        }
    }
}
