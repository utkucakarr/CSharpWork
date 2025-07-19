using RecapProject1.Entities;
using System.Data.Entity;

namespace RecapProject1
{
    public class NortWindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
