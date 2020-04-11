using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class MockFoodItemRepository : IFoodItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<MenuItem> AllFoodItems => new List<MenuItem>
            {
                new MenuItem {ItemId = 1, Name="Italian espresso", Price=2.55M, ShortDescription="Double shot", LongDescription="A smoky, strong flavoured Espresso, Italian signature coffee", Category = _categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://c.wallhere.com/photos/bd/f4/cup_coffee_coffee_beans-618542.jpg!s"},
                new MenuItem {ItemId = 2, Name="Cappucino", Price=2.8M, ShortDescription="Espresso, steamed milk and foam", LongDescription="Espresso, perfect blend of steamed milk and foam", Category = _categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://c.wallhere.com/photos/97/de/coffee_coffee_beans_cup-120513.jpg!s"},
                new MenuItem {ItemId = 3, Name="Tea", Price=3.0M, ShortDescription="Infused herbal tea", LongDescription="A hot cup of refreshing infused herbal tea without milk", Category = _categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://d1yn1kh78jj1rr.cloudfront.net/image/thumbnail/rDtN98Qoishumwih/cup-of-tea_GJsCGrsu_thumb.jpg"},
                new MenuItem {ItemId = 4, Name="Hot Chocolate", Price=3.5M, ShortDescription="Rich chocolate with steamed milk and whipped cream", LongDescription="A smooth blend of dark hot chocolate, with coffee and milk", Category = _categoryRepository.AllCategories.ToList()[0], ImageThumbnailUrl="https://cmkt-image-prd.freetls.fastly.net/0.1.0/ps/3600499/300/200/m1/fpnw/wm0/h19drukpylojvzyxfgmzf3192wv4v9nwzqqzsdoguteepiwtinl4v85tt5t1kpu5-.jpg?1511095852&s=96d16ab1bb8f22e01440aa8b1b218046"}
            };       

        public MenuItem GetItemById(int itemId)
        {
            return AllFoodItems.FirstOrDefault(p => p.ItemId == itemId);
        }
    }
}
