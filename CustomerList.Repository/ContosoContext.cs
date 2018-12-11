using CustomerList.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public class ContosoContext : DbContext
    {

     


        public ContosoContext(DbContextOptions options) : base(options)
        {
            
        }

        /// Gets the customers DbSet.
        public DbSet<Customer> Customers { get; set; }

        /// Gets the orders DbSet.
        public DbSet<Order> Orders { get; set; }

        /// Gets the products DbSet.
        public DbSet<Product> Products { get; set; }

        /// Gets the line items DbSet.
        public DbSet<LineItem> LineItems { get; set; }
    }
}
