using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public DbSet<Order> Order { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }
    }

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();

            optionsBuilder.UseSqlServer("", b => b.MigrationsAssembly("DataLayer"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
