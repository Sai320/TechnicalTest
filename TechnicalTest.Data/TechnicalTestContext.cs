using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.Entities;

namespace TechnicalTest.Data
{
    public class TechnicalTestContext : DbContext
    {
        public TechnicalTestContext() : base("TechnicalTestConnectionString")
        {
        }

        public DbSet<Register> registers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
