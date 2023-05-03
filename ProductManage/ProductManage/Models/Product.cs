using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductManage.Models
{
        public class Product
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 2)]
            public string ProductName { get; set; }

            [Required]
            [Range(1, 100000)]
            public int ProductPrice { get; set; }

            public int? CategoryId { get; set; }
            [ForeignKey("CategoryId")]
            public Category Category { get; set; }
        }
}
