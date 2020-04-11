using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FoodOrderingApp.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private static ShoppingCart instance = null;
        private static readonly object padlock = new object();
        private decimal _shoppingCartPrice = 0;

        ShoppingCart()
        {
            ShoppingCartItems = new List<ShoppingCartItem>();
        }

        #region Helper Methods
        /// <summary>
        /// Used by Startup class to get the instance of Cart
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns> 
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ShoppingCart() { ShoppingCartId = cartId };
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// Add to cart method
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
        public void AddToCart(MenuItem item, int quantity)
        {
            var shoppingCartItem =
                   ShoppingCartItems?.SingleOrDefault(
                        s => s.CartItem.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    CartItem = item,
                    Quantity = quantity
                };

                ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity = shoppingCartItem.Quantity + quantity;
            }
            UpdateTheCartprice();
        }

        /// <summary>
        /// Remove from cart method
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Quantity left in the cart for selected item, to be remmoved</returns>
        public int RemoveFromCart(MenuItem item)
        {
            var shoppingCartItem =
                    ShoppingCartItems.SingleOrDefault(
                        s => s.CartItem.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            var localItemQuantity = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localItemQuantity = shoppingCartItem.Quantity;
                }
                else
                {
                    ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            UpdateTheCartprice();
            return localItemQuantity;
        }

        /// <summary>
        /// To get all cart items
        /// </summary>
        /// <returns></returns>
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).ToList());
        }

        /// <summary>
        /// Clears the cart
        /// </summary>
        public void ClearCart()
        {
            var cartItems = ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);
            ShoppingCartItems.Clear();
        }

        /// <summary>
        /// Calculates the total price of the cart
        /// </summary>
        /// <returns>Total amount</returns>
        private void UpdateTheCartprice()
        {
            _shoppingCartPrice = ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.CartItem.Price * c.Quantity).Sum();           
        }
        public decimal GetShoppingCartTotal()
        {
            return _shoppingCartPrice;
        }
        #endregion

    }
}
