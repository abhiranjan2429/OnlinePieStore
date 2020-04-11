using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Drinks", Description="All beverages"}
        };
    }
}
