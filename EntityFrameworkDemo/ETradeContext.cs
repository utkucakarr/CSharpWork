using System.Data.Entity;

namespace EntityFrameworkDemo
{
    //Bu bir inherit(Kalıtım) işlemidir
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
