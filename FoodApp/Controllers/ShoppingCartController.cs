using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodItemRepository _foodItemRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IFoodItemRepository foodRepository, ShoppingCart shoppingCart)
        {
            _foodItemRepository = foodRepository;
            _shoppingCart = shoppingCart;
        }

        #region Action Methods on Shopping Cart

        /// <summary>
        /// Renders the Cart view
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems(); 
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        /// <summary>
        /// Action to add selected item to the Cart
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _foodItemRepository.AllFoodItems.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Action to remove selected item from the Cart
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _foodItemRepository.AllFoodItems.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
                if (_shoppingCart.ShoppingCartItems.Count == 0)
                {
                    //Redirect to Home
                }
            }
            return RedirectToAction("Index");
        }

        #endregion
    }
}
