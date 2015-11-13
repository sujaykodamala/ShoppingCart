using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
   public  class CartEntity : DbContext
    {
       public DbSet<Customers> Customers { get; set; }
       public DbSet<Delivery> Deliveries { get; set; }
       public DbSet<Orders> Orders { get; set; }
       public DbSet<Payment> Payments { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Gender> Genders { get; set; }
       public DbSet<Products> Products { get; set; }

    }
}
