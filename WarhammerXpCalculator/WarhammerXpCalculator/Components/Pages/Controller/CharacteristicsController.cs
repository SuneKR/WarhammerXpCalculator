using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarhammerXpCalculator.Models;
using System.Diagnostics;

namespace WarhammerXpCalculator.Components.Pages.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacteristicsController : ControllerBase
    {
        private readonly WarhammerXpCalcDB _context;

        public CharacteristicsController(WarhammerXpCalcDB context)
        {
            _context = context;
        }

        // GET: api/Characteristics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Characteristic>>> GetCharacteristic()
        {
            return await _context.Characteristics.ToListAsync();
        }

        // GET: api/Characteristics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Characteristic>> GetCharacteristic(string id)
        {
            var characteristic = await _context.Characteristics.FindAsync(id);

            if (characteristic == null)
            {
                return NotFound();
            }

            return characteristic;
        }

        // PUT: api/Characteristics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacteristic(int id, Characteristic characteristic)
        {
            if (id != characteristic.Id)
            {
                return BadRequest();
            }

            _context.Entry(characteristic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacteristicExists(id))
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

        // POST: api/Characteristics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Characteristic>> PostCharacteristic([FromBody] Characteristic characteristic)
        {
            _context.Characteristics.Add(characteristic);
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException)
            {
                if (CharacteristicExists(characteristic.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            //return CreatedAtAction("GetCharacteristic", new { id = characteristic.Id }, characteristic);
            return Ok(characteristic);
        }

        // DELETE: api/Characteristics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacteristic(int id)
        {
            var characteristic = await _context.Characteristics.FindAsync(id);
            if (characteristic == null)
            {
                return NotFound();
            }

            _context.Characteristics.Remove(characteristic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacteristicExists(int id)
        {
            return _context.Characteristics.Any(e => e.Id == id);
        }
    }
}
