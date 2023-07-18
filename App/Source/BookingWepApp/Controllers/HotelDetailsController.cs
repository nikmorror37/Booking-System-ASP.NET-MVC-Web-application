using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BookingWepApp.Data;
using BookingWepApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BookingWepApp.Controllers
{
    [Authorize]
    public class HotelDetailsController : Controller
    {
        private readonly ApplicationDbContext _appContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public HotelDetailsController(ApplicationDbContext appContext,
            UserManager<ApplicationUser> userManager)
        {
            _appContext = appContext;
            _userManager = userManager;
        }

        //[BindProperty]
        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        [BindProperty]
        public ApplicationUser CurrentUser { get; set; }

        public async Task<IActionResult> HotelPage(int id)
        {
            var hotel = await _appContext.Hotels
                .Where(h => h.Id == id)
                .Include(r => r.Rooms)
                .FirstOrDefaultAsync();
            HotelDetailsData.CurrentHotel = hotel;

            return View(hotel);
        }

        public async Task<IActionResult> BookRoom(RoomType roomType, int id)
        {
            CurrentUser = await _userManager.GetUserAsync(User);
            if (CurrentUser != null)
                ViewBag.User = CurrentUser;

            var availableRoomToBeBooked = _appContext.Rooms
                .Where(_ => _.HotelId == id && _.RoomType == roomType)
                .Include(_ => _.Hotel)
                .FirstOrDefault();

            if (availableRoomToBeBooked != null)
            {
                HttpContext.Session.SetInt32("roomId", availableRoomToBeBooked.Id);
                HttpContext.Session.SetString("CheckInDate", HotelDetailsData.CheckInDate.ToString());
                HttpContext.Session.SetString("CheckOutDate", HotelDetailsData.CheckOutDate.ToString());

                return RedirectToAction("Checkout", "Checkout");
            }
            else
            {
                return NotFound();
            }
        }

        private List<DateTime> GetStayingDaysRangeList()
        {
            var daysRangeList = new List<DateTime>();

            for (DateTime date = HotelDetailsData.CheckInDate; date <= HotelDetailsData.CheckOutDate; date = date.AddDays(1))
            {
                daysRangeList.Add(date);
            }

            return daysRangeList;
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult SearchRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            if (checkInDate.Year <= 1 || checkOutDate.Year <= 1)
            {
                ViewBag.Error = "Укажите даты заезда и выезда";
                return View("HotelPage", HotelDetailsData.CurrentHotel);
            }
            if (checkOutDate <= checkInDate)
            {
                //выводим ошибку
                ViewBag.Error = "Дата выселения должна быть строго больше даты заселения";
                //возвращаем эту же страницу
                return View("HotelPage", HotelDetailsData.CurrentHotel);
            }
            //(StartA <= EndB) and (EndA >= StartB)
            string sql = "select q1.RoomType, q2.cnt, q1.cnt " +
                "from " +
                "(select r.RoomType, count(*) as cnt " +
                "from Hotels h " +
                "left join Rooms r on r.HotelId = h.Id " +
                $"where h.Id = {HotelDetailsData.CurrentHotel.Id} " +
                "and r.RoomType is not null " +
                "group by r.RoomType) as q1 " +
                "join " +
                "(select r.RoomType, count(*) as cnt " +
                "from Hotels h " +
                "left join Rooms r on r.HotelId = h.Id " +
                $"where h.Id = {HotelDetailsData.CurrentHotel.Id} " +
                "and r.RoomType is not null " +
                "and r.Id not in " +
                "(select b.RoomId " +
                "from Bookings b " +
                $"where ('{checkInDate.ToString("dd.MM.yyyy")}' <= b.CheckOut) and ('{checkOutDate.ToString("dd.MM.yyyy")}' >= b.CheckIn)) " +
            "group by r.RoomType) as q2 on q1.RoomType = q2.RoomType";

            var connection = new SqlConnection(_appContext.Database.GetDbConnection().ConnectionString);
            connection.Open();
            var adapter = new SqlDataAdapter(sql, connection);
            var dt = new DataTable();
            adapter.Fill(dt);

            var rooms = new List<RoomItem>();
            foreach (DataRow row in dt.Rows)
            {
                rooms.Add(new RoomItem()
                {
                    RoomType = (RoomType)row[0],
                    AvailableRooms = Convert.ToInt32(row[1]),
                    TotalRooms = Convert.ToInt32(row[2])
                });
            }

            ViewBag.RoomsAvailable = rooms;
            ViewBag.DataInfo = new List<DateTime>() { checkInDate, checkOutDate };

            HotelDetailsData.CheckInDate = checkInDate;
            HotelDetailsData.CheckOutDate = checkOutDate;

            return View("HotelPage", HotelDetailsData.CurrentHotel);
        }
    }

    public class RoomItem
    {
        public RoomType RoomType { get; set; }
        public int AvailableRooms { get; set; }
        public int TotalRooms { get; set; }
    }
}