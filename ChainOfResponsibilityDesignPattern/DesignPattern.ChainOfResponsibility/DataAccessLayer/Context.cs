using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q270QVE\\SQLEXPRESS; initial catalog = ChainOfResponsibility; integrated security=true; TrustServerCertificate=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
