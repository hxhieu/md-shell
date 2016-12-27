using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MedsReadyMobile.Services.Loggers
{
    public interface ILog
    {
        Task Info(string message);
        Task Error(string error);
        Task Error(Exception ex);
        Task Warn(string message);
    }

    public class ConsoleLog : ILog
    {
        private Task WriteLine(string prefix, string message)
        {
            Debug.WriteLine($"{prefix}: {message}");
            return Task.FromResult(0);
        }
        public Task Error(string error) { return WriteLine("ERR", error); }

        public Task Info(string message) { return WriteLine("INFO", message); }

        public Task Warn(string message) { return WriteLine("WARN", message); }

        public Task Error(Exception ex) { return WriteLine("ERR", ex.Message); }
    }
}
