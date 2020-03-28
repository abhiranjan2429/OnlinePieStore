using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop.Models
{
    public class ShoppingCart 
    {
        private readonly IPieRepository _mockPieRepository;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public static List<ShoppingCartItem> ShoppingCartItems1=new List<ShoppingCartItem>();// remove
        // the above being is used because to persist data in the service.


        public ShoppingCart(IPieRepository pieRepository)
        {
            //_mockPieRepository = new  MockPieRepository();
            //_mockPieRepository.ShoppingCartItems = new List<ShoppingCartItem>();
            _mockPieRepository = pieRepository;
           // _mockPieRepository.ShoppingCartItems = new List<ShoppingCartItem>();//remove
        }

        public static ShoppingCart GetCart(IServiceProvider services) // this will give the services which we use for dependency injection
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<IPieRepository>();
            context.ShoppingCartItems = ShoppingCartItems1;
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Pie pie, int amount)
        {
            var shoppingCartItem =
                    _mockPieRepository.ShoppingCartItems.SingleOrDefault(
                        s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Pie = pie,
                    Amount = 1
                };

              //  _mockPieRepository.ShoppingCartItems.Add(shoppingCartItem);
                ShoppingCartItems1.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
           // _appDbContext.SaveChanges(); not required as not saving anywhere
        }

        public int RemoveFromCart(Pie pie)
        {
            _mockPieRepository.ShoppingCartItems = ShoppingCartItems1;
           var shoppingCartItem =
                    _mockPieRepository.ShoppingCartItems.SingleOrDefault(
                        s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _mockPieRepository.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

           // _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _mockPieRepository.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                       .Select(s=>s).ToList());


                           // .Include(s => s.Pie)

                           //.ToList());
        }

        public void ClearCart()
        {
            var cartItems = _mockPieRepository
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);
            _mockPieRepository.ShoppingCartItems.Clear();
            ShoppingCartItems1.Clear();
        //  _mockPieRepository.ShoppingCartItems.RemoveRange(cartItems);

           // _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal() // insert
        {
            _mockPieRepository.ShoppingCartItems = ShoppingCartItems1;// remove
            var total = _mockPieRepository.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Pie.Price * c.Amount).Sum();
            return total;
        }

        public int GetTotalCountItems()
        {
            int count = 0;
            
            foreach(var items in ShoppingCartItems1)
            {
                if(items.ShoppingCartId==ShoppingCartId)
                count = count+items.Amount;
            }

            return count;
        }
        
    }
}
