using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BookingWepApp.Data;
using BookingWepApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace BookingWepApp.Controllers
{
    public class HomeController : Controller
    {       
        private readonly ApplicationDbContext _appContext;
        
        public HomeController(ApplicationDbContext appContext)
        {            
            _appContext = appContext;
        }

        public IActionResult Index(bool clear)
        {
            string currentUserId = GetCurrentUserId();

            var hotelsViewModel = new HotelsViewModel()
            {
                Hotels = _appContext.Hotels.Include(h => h.Rooms)
            };

            FillingViewBags();
            if (HttpContext.Session.GetString("SearchKeyword") == null || clear)
            {
                HttpContext.Session.SetString("SearchKeyword", string.Empty);
            }

            return View(hotelsViewModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Search(HotelsViewModel hotelsViewModel)
        {
            if (hotelsViewModel.SearchKeyword != null)
            {
                HttpContext.Session.SetString("SearchKeyword", hotelsViewModel.SearchKeyword);
            }

            var hotelListAfterSearch = GetHotelsBySearch(
                HttpContext.Session.GetString("SearchKeyword"));

            var newHotelViewModel = new HotelsViewModel
            {
                SearchKeyword = HttpContext.Session.GetString("SearchKeyword"),
                Hotels = hotelListAfterSearch
            };

            FillingViewBags();

            return Filter(newHotelViewModel);
        }

        [HttpPost]
        public IActionResult Filter(HotelsViewModel hotelsViewModel)
        {
            var hotelListAfterSearch = hotelsViewModel.Hotels ??
                GetHotelsBySearch(HttpContext.Session.GetString("SearchKeyword"));

            var distanceList = hotelsViewModel.DistanceList;

            var hotelListAfterFilter = hotelListAfterSearch
                           .Where(h => distanceList != null ? h.DistanceFromCenter < distanceList.Max() : true)
                           .ToList();

            string currentUserId = GetCurrentUserId();

            var newHotelViewModel = new HotelsViewModel
            {
                SearchKeyword = HttpContext.Session.GetString("SearchKeyword"),
                Hotels = hotelListAfterFilter
            };
            FillingViewBags();

            return View("Index", newHotelViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void FillingViewBags()
        {
            ViewBag.Stars = _appContext.Hotels
                .Select(h => h.Stars)
                .OrderByDescending(s => s)
                .Distinct()
                .ToList();
        }

        private IEnumerable<Hotel> GetHotelsBySearch(string hotelName)
        {
            if (!string.IsNullOrEmpty(hotelName))
            {
                var hotelsViewModel = new HotelsViewModel
                {
                    Hotels = _appContext.Hotels
                        .Include(h => h.Rooms)
                        .Where(h => h.Name.Contains(hotelName))
                        .ToList()
                };

                return hotelsViewModel.Hotels;
            }

            return _appContext.Hotels
                .Include(h => h.Rooms)
                .ToList();
        }

        private string GetCurrentUserId()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var identityClaimUser = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string currentUserId = identityClaimUser?.Value;
            return currentUserId;
        }
    }
}