using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using FoodOrderingApp.Models;
using FoodOrderingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingApp.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IPayment _payment;
        private bool pay { get; set; } = false;
        public PaymentController(ShoppingCart shoppingCart, IPayment payment)
        {
            _shoppingCart = shoppingCart;
            _payment = payment;
        }
        public IActionResult CheckOut()
        {
            if (_shoppingCart.GetTotalCountItems() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some items Coffee first");

            }


            if (ModelState.IsValid)
            {
                var totalbill = _shoppingCart.GetShoppingCartTotal();
                var paymentViewModel = new PaymentViewModel()
                {
                    TotalAmount = totalbill,
                    DiscountedAmount=totalbill
                };

                return View(paymentViewModel);
            }
            return PartialView("_Empty");
        }
        [HttpPost]
        public IActionResult CheckOut(decimal discountPercent)
        {
            if (_shoppingCart.GetTotalCountItems() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some items Coffee first");

            }
            if (ModelState.IsValid)
            {
                var totalbill = _shoppingCart.GetShoppingCartTotal();
                decimal discountedbill = _payment.GetDiscountedPrince(discountPercent, _shoppingCart.GetShoppingCartTotal());
                var paymentViewModel = new PaymentViewModel()
                {
                    DiscountedAmount = discountedbill,
                    discountedPercent = discountPercent,
                    payview = true,
                    TotalAmount = totalbill,
                    
                };
                return View(paymentViewModel);

            }

            return PartialView("_Empty");
        }
        public IActionResult Successful()
        {
            if (_shoppingCart.GetTotalCountItems() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some items Coffee first");

            }
            if (ModelState.IsValid)
            {

                _shoppingCart.ClearCart();
                return View();
            }

            return PartialView("_Empty");
        }

        public IActionResult CardSuccessful()
        {
            if (_shoppingCart.GetTotalCountItems() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some items Coffee first");

            }
            if (ModelState.IsValid)
            {

                return View(new PaymentViewModel {DiscountedAmount=1 });
            }

            return PartialView("_Empty");
        }
 

    }
}