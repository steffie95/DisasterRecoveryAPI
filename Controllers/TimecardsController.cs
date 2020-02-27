using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisasterRecoveryAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace DisasterRecoveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TimecardsController : ControllerBase
    {
        private readonly TimecardContext _context;

        public TimecardsController(TimecardContext context)
        {
            _context = context;
        }

        // GET: api/Timecards
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Timecard>>> GetTimecards()
        {
            return await _context.Timecards.ToListAsync();
        }

        // GET: api/Timecards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timecard>> GetTimecard(int id)
        {
            var timecard = await _context.Timecards.FindAsync(id);

            if (timecard == null)
            {
                return NotFound();
            }

            return timecard;
        }

        // PUT: api/Timecards/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]

        public async Task<IActionResult> PutTimecard(int id, Timecard timecard)
        {
            if (id != timecard.Id)
            {
                return BadRequest();
            }

            _context.Entry(timecard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimecardExists(id))
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

        // POST: api/Timecards
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]

        public async Task<ActionResult<Timecard>> PostTimecard(Timecard timecard)
        {
            _context.Timecards.Add(timecard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTimecard", new { id = timecard.Id }, timecard);
        }

        // DELETE: api/Timecards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Timecard>> DeleteTimecard(int id)
        {
            var timecard = await _context.Timecards.FindAsync(id);
            if (timecard == null)
            {
                return NotFound();
            }

            _context.Timecards.Remove(timecard);
            await _context.SaveChangesAsync();

            return timecard;
        }

        private bool TimecardExists(int id)
        {
            return _context.Timecards.Any(e => e.Id == id);
        }
    }
}
