using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodApp.Models;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;

namespace FoodApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
        return View(homeViewModel);
        }
    }
}
