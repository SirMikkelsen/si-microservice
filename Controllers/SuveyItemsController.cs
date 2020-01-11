using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuveyApp.Model;

namespace SuveyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuveyItemsController : ControllerBase
    {
        private readonly SuveyContext _context;

        public SuveyItemsController(SuveyContext context)
        {
            _context = context;
        }

        // GET: api/SuveyItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuveyItem>>> GetSuveyItems()
        {
            return await _context.SuveyItems.ToListAsync();
        }

        // GET: api/SuveyItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuveyItem>> GetSuveyItem(int id)
        {
            var suveyItem = await _context.SuveyItems.FindAsync(id);

            if (suveyItem == null)
            {
                return NotFound();
            }

            return suveyItem;
        }

        // PUT: api/SuveyItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuveyItem(int id, SuveyItem suveyItem)
        {
            if (id != suveyItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(suveyItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuveyItemExists(id))
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

        // POST: api/SuveyItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SuveyItem>> PostSuveyItem(SuveyItem suveyItem)
        {
            _context.SuveyItems.Add(suveyItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSuveyItem), new { id = suveyItem.ID }, suveyItem);
        }

        // DELETE: api/SuveyItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuveyItem>> DeleteSuveyItem(int id)
        {
            var suveyItem = await _context.SuveyItems.FindAsync(id);
            if (suveyItem == null)
            {
                return NotFound();
            }

            _context.SuveyItems.Remove(suveyItem);
            await _context.SaveChangesAsync();

            return suveyItem;
        }

        private bool SuveyItemExists(int id)
        {
            return _context.SuveyItems.Any(e => e.ID == id);
        }
    }
}
