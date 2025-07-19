using NorthWind.Entities.Concrete;
using System.Data.Entity;

namespace NorthWind.DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
