using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DataAccessLayer
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q270QVE\\SQLEXPRESS; initial catalog = CQRS; integrated security=true; TrustServerCertificate=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
