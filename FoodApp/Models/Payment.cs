using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class Payment : IPayment
    {
        public decimal GetDiscountedPrice(string discountCode, decimal cartBillAmount)
        {
            var discountPercentage = DiscountCalculator.GetDiscountPercentage(discountCode);
            var payableAmount = cartBillAmount - ((discountPercentage / 100) * cartBillAmount);
            return payableAmount;
        }
    }

    public enum PaymentOption
    {
        Cash = 1,
        Card = 2
    }
}
