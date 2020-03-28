using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class Payment :IPayment
    {
        public decimal TotalAmount { get; set; }
        public decimal DiscountedAmount { get; set; }
        public PaymentOption PaymentType;
        public decimal GetDiscountedPrince(decimal discountPercent, decimal totalBill)
        {
            decimal payableAmount = totalBill - ((discountPercent / 100) *totalBill);
            return payableAmount;
        }
    }
   
    public enum PaymentOption
    {
        Cash=1,
        Card=2
    }
}
