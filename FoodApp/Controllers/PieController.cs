using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodOrderingApp.Controllers
{
    public class PieController : Controller
    {
        //// GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        //ActionMethods
        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "Cheese Cakes";
            return View(pieListViewModel);
        }
    }
}
