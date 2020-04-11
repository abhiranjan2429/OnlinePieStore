using FoodOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class ShoppingCartItem
    {
        public int CartItemId { get; set; }
        public MenuItem CartItem { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; } //Link to associated Cart
    }
}
