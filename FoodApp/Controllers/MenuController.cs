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
    public class MenuController : Controller
    {      
        private readonly IFoodItemRepository _foodItemRepository;
        private readonly ICategoryRepository _categoryRepository;
        public MenuController(IFoodItemRepository foodRepository,ICategoryRepository categoryRepository)
        {
            _foodItemRepository = foodRepository;
            _categoryRepository = categoryRepository;
        }
        
        /// <summary>
        /// Action method to list the Menu items 
        /// </summary>
        /// <returns></returns>
        public ViewResult List()
        {
            MenuListViewModel menuListViewModel = new MenuListViewModel();
            menuListViewModel.AllItems = _foodItemRepository.AllFoodItems;
            menuListViewModel.AllCategories = _categoryRepository.AllCategories;          
            return View(menuListViewModel);
        }
    }
}
