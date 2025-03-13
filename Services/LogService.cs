using Models;
using Data;
using System.Linq;
using System.Collections.Generic;

namespace Services
{
    public class LogService
    {
        private readonly SiemDbContext _context;

        public LogService(SiemDbContext context)
        {
            _context = context;
        }

        public List<LogEntry> GetAllLogs()
        {
            return _context.Logs.ToList();
        }

        public void AddLog(LogEntry log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();
        }
    }
}
