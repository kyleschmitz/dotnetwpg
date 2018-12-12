using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=TestDB;Trusted_Connection=True;");
        }
    }
}