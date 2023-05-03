using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static ProductManage.Models.Product;

namespace ProductManage.Models
{
    public class Category
    {
            [Key]
            public int CategoryId { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 2)]
            public string CategoryName { get; set; }       
    }
}