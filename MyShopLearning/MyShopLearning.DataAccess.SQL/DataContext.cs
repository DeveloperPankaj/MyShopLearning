using MyShopLearning.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLearning.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Product> product { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Customer> customers { get; set; }

    }
}
