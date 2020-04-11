﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingApp.Models
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }        
        public decimal Price { get; set; }        
        public string ImageThumbnailUrl { get; set; }           
        //public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}