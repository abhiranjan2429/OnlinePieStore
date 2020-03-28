using BethanysPieShop.Models;
using FoodOrderingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Components
{
    public class ShoppingCartSummary : ViewComponent 
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shaoppingCartTotalCountViewModel = new ShaoppingCartTotalCountViewModel
            {
                TotalCountOfProduct = _shoppingCart.GetTotalCountItems()
            };
            // int  x = _shoppingCart.GetTotalCountItems();
            return View(shaoppingCartTotalCountViewModel);
        }
        //int getTotalCountOfItem(List<ShoppingCartItem> shoppingCartItems)
        //{
        //    int count = 0;
        //    foreach(var product in shoppingCartItems )
        //    {
        //       // ShoppingCart.ShoppingCartItems1.
        //      //  count = count + product.;
        //    }

        //    return 0;
        //}
    }
}
