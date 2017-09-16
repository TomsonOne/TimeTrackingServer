
 using TimeTrackingServer.Models;

// }
using Microsoft.EntityFrameworkCore;

namespace TimeTrackingServer.Models
{
    public class TimeTrackingDBContext : DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<CalculationConfig> Calculation { get; set; }

        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<ExpenseTypes> ExpenseTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=dewebspace.de,1525;User Id=srv_tt;Password=Timetrackin123!;Database=TimeTracking;Trusted_Connection=False;");
        }
    }
}