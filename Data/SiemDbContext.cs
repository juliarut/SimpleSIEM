using Microsoft.EntityFrameworkCore;
using SimpleSIEM.Models;

namespace SimpleSIEM.Data
{
    public class SiemDbContext : DbContext
    {
        public SiemDbContext(DbContextOptions<SiemDbContext> options) : base(options)
        {
        }

        public DbSet<LogEntry> Logs { get; set; }
    }
}
