using BookStore.BLL.Interfaces;

namespace BookStore.BLL.Services
{
    public class LoggingConsoleService : ILoggingConsoleService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
        public void LogError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now}] ERROR: {ex}");
            Console.ResetColor();
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] WARNING: {message}");
        }
        public void LogInfo(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] INFO: {message}");
        }
        public void LogDebug(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] DEBUG: {message}");
        }
        public void LogTrace(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] TRACE: {message}");
        }
        public void LogCritical(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] CRITICAL: {message}");
        }
    }
}
