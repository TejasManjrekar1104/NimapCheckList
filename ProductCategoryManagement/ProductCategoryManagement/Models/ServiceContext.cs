

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductCategoryManagement.Models 
{
    public class ServiceContext : DbContext   
    {
        public DbSet<Category> Category { get; set; } 
        public DbSet<Product> Product { get; set; } 
    }
}