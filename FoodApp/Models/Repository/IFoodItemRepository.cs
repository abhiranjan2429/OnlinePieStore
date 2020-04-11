using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public interface IFoodItemRepository
    {
        IEnumerable<MenuItem> AllFoodItems { get; }       
        MenuItem GetItemById(int itemId);      
    }
}
