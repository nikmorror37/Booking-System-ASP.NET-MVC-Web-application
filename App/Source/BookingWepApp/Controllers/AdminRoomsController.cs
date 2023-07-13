using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookingWepApp.Data;
using BookingWepApp.Models;

namespace BookingWepApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminRoomsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminRoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var applicationDbContext = _context.Rooms.Include(r => r.Hotel);

            if (id != null)
            {
                applicationDbContext = _context.Rooms.Where(r => r.Id == id).Include(r => r.Hotel);
            }

            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["HotelId"] = new SelectList(_context.Hotels.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,RoomType,RoomNumber,RoomPrice,RoomDescription,NumberOfBeds,Capacity,IsAvailable,RoomImageUrl,HotelId")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["HotelId"] = new SelectList(_context.Hotels.ToList(), "Id", "Name", room.HotelId);
            return View(room);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            ViewData["HotelId"] = new SelectList(_context.Hotels.ToList(), "Id", "Name", room.HotelId);
            return View(room);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomId,RoomType,RoomNumber,RoomPrice,RoomDescription,NumberOfBeds,Capacity,IsAvailable,RoomImageUrl,HotelId")] Room room)
        {
            if (ModelState.IsValid)
            {
                var item = _context.Rooms.Find(id);
                item.NumberOfBeds = room.NumberOfBeds;
                item.RoomPrice = room.RoomPrice;
                item.RoomDescription = room.RoomDescription;
                item.Capacity = room.Capacity;
                item.HotelId = room.HotelId;
                item.RoomType = room.RoomType;
                item.RoomImageUrl = room.RoomImageUrl;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["HotelId"] = new SelectList(_context.Hotels.ToList(), "Id", "Name", room.HotelId);
            return View(room);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .Include(r => r.Hotel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }
    }
}