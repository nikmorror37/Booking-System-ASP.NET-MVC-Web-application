using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingWepApp.Data;
using BookingWepApp.Models;

namespace BookingWepApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminHotelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminHotelsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Hotels.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelId,Name,Website,Address,ZipCode,City,Country,Description,Stars,DistanceFromCenter,ImageUrl,RatedByGuests")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                var webRootPath = _webHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var fileName = Guid.NewGuid().ToString();
                var folder = Path.Combine(webRootPath, @"pictures/hotels/");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(folder, fileName + extension), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }
                hotel.ImageUrl = @"~/pictures/hotels/" + fileName + extension;

                _context.Add(hotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HotelId,Name,Website,Address,ZipCode,City,Country,Description,Stars,DistanceFromCenter,ImageUrl,RatedByGuests")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = _context.Hotels.Find(id);

                    var webRootPath = _webHostEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0)
                    {
                        var fileName = Guid.NewGuid().ToString();
                        var folder = Path.Combine(webRootPath, @"pictures/hotels/");
                        var extension = Path.GetExtension(files[0].FileName);

                        using (var fileStream = new FileStream(Path.Combine(folder, fileName + extension), FileMode.Create))
                        {
                            await files[0].CopyToAsync(fileStream);
                        }

                        item.ImageUrl = @"~/pictures/hotels/" + fileName + extension;
                    }
                    else
                    {
                        item.ImageUrl = _context.Hotels.Where(h => h.Id == hotel.Id)
                            .Select(h => h.ImageUrl)
                            .FirstOrDefault();
                    }

                    item.Stars = hotel.Stars;
                    item.Address = hotel.Address;
                    item.City = hotel.City;
                    item.Country = hotel.Country;
                    item.Website = hotel.Website;
                    item.DistanceFromCenter = hotel.DistanceFromCenter;
                    item.Description = hotel.Description;
                    item.ZipCode = hotel.ZipCode;
                    item.Name = hotel.Name;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(hotel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.Id == id);
        }
    }
}