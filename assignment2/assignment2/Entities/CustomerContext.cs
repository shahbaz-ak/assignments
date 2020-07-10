using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace assignment2.Entities
{
    public class CustomerContext:DbContext
    {
        public DbSet<entitiyCustomer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-E85KP45;Initial Catalog=CustomerDB;Integrated Security=True");
        }
    }
}
