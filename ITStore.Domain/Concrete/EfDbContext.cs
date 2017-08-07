using ITStore.Domain.Entities;
using System.Data.Entity;

namespace ITStore.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
