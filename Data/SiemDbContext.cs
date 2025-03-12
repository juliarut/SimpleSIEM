using Microsoft.EntityFrameworkCore;

public class SiemDbContext : DbContext
{
    public DbSet<LogEntry> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=siem.db");
}
