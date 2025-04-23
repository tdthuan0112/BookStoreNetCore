namespace BookStore.BLL.Interfaces
{
    public interface ILoggingConsoleService
    {
        void Log(string message);
        void LogError(Exception ex);
        void LogWarning(string message);
        void LogInfo(string message);
        void LogDebug(string message);
        void LogTrace(string message);
        void LogCritical(string message);
    }
}
