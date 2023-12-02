using ApplicationManager.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManager.Data
{
    public class AppDbContext : DbContext  // using microsoft entity framework core
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Appointment> Appointments { get; set; } // create a database table 
    }
}
