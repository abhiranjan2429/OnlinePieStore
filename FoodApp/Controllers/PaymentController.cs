using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodOrderingApp.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IPayment _payment;
        public PaymentController(ShoppingCart shoppingCart, IPayment payment)
        {
            _shoppingCart = shoppingCart;
            _payment = payment;
        }

        public IActionResult CheckOut()
        {
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                //Changes the state to Invalid
                ModelState.AddModelError("", "Your cart is empty, are you missing something in your cart?");
            }

            if (ModelState.IsValid)
            {                
                var paymentViewModel = new PaymentViewModel()
                {
                    Bill = _shoppingCart.GetShoppingCartTotal(),
                    FinalAmount = _shoppingCart.GetShoppingCartTotal()
                };

                return View(paymentViewModel);
            }

            return PartialView("_Empty");
        }

        [HttpPost]
        public IActionResult CheckOut(string discountCode)
        {
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, are you missing something in your cart?");
            }

            if (ModelState.IsValid)
            {
                var cartBillAmount = _shoppingCart.GetShoppingCartTotal();
                decimal discountedbill = _payment.GetDiscountedPrice(discountCode, cartBillAmount);
                var paymentViewModel = new PaymentViewModel()
                {
                    Bill = cartBillAmount,
                    FinalAmount = discountedbill
                };
                return View(paymentViewModel);

            }

            return PartialView("_Empty");
        }

        public IActionResult Success()
        {
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, are you missing something in your cart?");

            }
            if (ModelState.IsValid)
            {
                _shoppingCart.ClearCart();
                return View();
            }

            return PartialView("_Empty");
        }
    }
}
