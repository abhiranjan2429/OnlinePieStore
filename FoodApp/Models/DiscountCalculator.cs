using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public static class DiscountCalculator
    {
       private static IDictionary<String, decimal> DiscountCodeAndValue = new Dictionary<string, decimal>()
            {
                {"New10",10 },  {"New20",20 },  {"New50",50 },
            };

        public static decimal GetDiscountPercentage(string discountCode)
        {
            decimal discount = 0;
            DiscountCodeAndValue.TryGetValue(discountCode, out discount);
            return discount;            
        }
    }
}
