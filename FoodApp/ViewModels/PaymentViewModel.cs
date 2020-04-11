using FoodOrderingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.ViewModels
{
    public class PaymentViewModel
    {
        public decimal Bill { get; set; }
        public decimal FinalAmount { get; set; }

        [BindProperty]
        public string DiscountCode { get; set; }
        public PaymentOption PaymentMethod;
    }
}
