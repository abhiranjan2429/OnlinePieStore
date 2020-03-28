using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.ViewModels
{
    public class PaymentViewModel
    {
        public decimal TotalAmount { get; set; }
        public decimal DiscountedAmount { get; set; }
        [BindProperty]
        public decimal discountedPercent { get; set; }
        public PaymentOption PaymentType;
        public bool payview { get; set; }
    }
    public enum PaymentOption
    {
        Cash = 1,
        Card = 2
    }
}
