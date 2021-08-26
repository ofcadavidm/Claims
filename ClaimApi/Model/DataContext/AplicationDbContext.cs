using Microsoft.EntityFrameworkCore;

namespace ClaimApi.Model.DataContext
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Claim> Claims { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}
