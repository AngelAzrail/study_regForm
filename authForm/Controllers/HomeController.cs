using System;
using authForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace authForm.Controllers
{

    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            ViewBag.VisitorNumber = new Random().Next(1, 100);
            ViewBag.DateAndTime = DateTime.Today.Date;
            return View();
        }

        [HttpGet]
        public ViewResult Registration()
        {
            ViewBag.Rooms = RoomRepository.GetRooms();
            return View();
        }

        [HttpPost]
        public ViewResult Registration(RegistrationForm model)
        {
            return View("Success", model);
        }
    }
}