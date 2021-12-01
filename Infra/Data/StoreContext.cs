using core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infra.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Products> Products { get; set; }
    }
}