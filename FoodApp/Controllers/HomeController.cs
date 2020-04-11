using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;

namespace FoodOrderingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodItemRepository _foodRepository;
        public HomeController(IFoodItemRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public IActionResult Index()
        {
            
        return View();
        }
    }
}
