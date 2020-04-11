using FoodOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.ViewModels
{
    public class MenuListViewModel
    {
        public IEnumerable<MenuItem> AllItems { get; set; }
        public IEnumerable<Category> AllCategories { get; set; }
        //public string CurrentCategory { get; set; }
    }
}
