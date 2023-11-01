using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class DBContext : DbContext
    {
        public string DBPath => "database.db";

        public DbSet<Client> Clients { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<Tour> Tours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlite($"Data Source = {DBPath}");
        }
    }
}