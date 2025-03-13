namespace SimpleSIEM.Models
{
    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Source { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public string IPAddress { get; set; }
    }
}
