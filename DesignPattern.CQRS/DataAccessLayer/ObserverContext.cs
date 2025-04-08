using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DataAccessLayer
{
    public class ObserverContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q270QVE\\SQLEXPRESS; initial catalog = Observer; integrated security=true; TrustServerCertificate=true");
        }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }


    }
}
