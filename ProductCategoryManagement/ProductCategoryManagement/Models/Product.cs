﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductCategoryManagement.Models
{
    public class Product 
    {
        public int ProductId { get; set; } 

        public string ProductName { get; set; } 

        public int ProductPrice { get; set; }

        
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public  Category Category { get; set; }
        public bool IsActivate { get; internal set; }
    }
} 