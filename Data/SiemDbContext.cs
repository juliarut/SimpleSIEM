using Microsoft.EntityFrameworkCore;
using System;

public class SiemDbContext : DbContext
{
    public DbSet<LogEntry> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=siem.db");
}

public class LogEntry
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string Source { get; set; } 
    public string Message { get; set; } 
    public string Severity { get; set; }
    public string IPAddress { get; set; }
}
