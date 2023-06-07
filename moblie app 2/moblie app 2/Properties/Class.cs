using Microsoft.EntityFrameworkCore;

namespace DuetRecordingApp.Models
{
    public class DuetRecordingContext : DbContext
    {
        public DuetRecordingContext(DbContextOptions<DuetRecordingContext> options) : base(options)
        {
        }

        public DbSet<Recording> Recordings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}