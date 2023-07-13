using BookingWepApp.Data;
using BookingWepApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> Get()
        {
            return await _context.Hotels.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> Get(int id)
        {
            var item = await _context.Hotels.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Hotel>> Post(Hotel item)
        {
            _context.Hotels.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(Get),
                new { id = item.Id },
                item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Hotel item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var foundItem = await _context.Hotels.FindAsync(id);

            if (foundItem == null)
            {
                return NotFound();
            }

            foundItem.Name = item.Name;
            foundItem.Stars = item.Stars;
            foundItem.Address = item.Address;
            foundItem.City = item.City;
            foundItem.Country = item.Country;
            foundItem.Description = item.Description;
            foundItem.DistanceFromCenter = item.DistanceFromCenter;
            foundItem.ZipCode = item.ZipCode;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Hotels.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }
    }
}