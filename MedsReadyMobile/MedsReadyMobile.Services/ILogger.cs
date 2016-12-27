using MedsReadyMobile.Services.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsReadyMobile.Services
{
    public interface ILogger
    {
        Task Info(string message);
        Task Warn(string message);
        Task Error(string error);
        Task Error(Exception ex);
        void AddLogMedium(ILog log);
    }

    public class Logger : ILogger
    {
        private ICollection<ILog> _logs = new List<ILog>();
        
        public void AddLogMedium(ILog log)
        {
            _logs.Add(log);
        }

        public async Task Error(Exception ex)
        {
            if (_logs == null || !_logs.Any()) return;

            foreach (var log in _logs)
            {
                await log.Error(ex);
            }
        }

        public async Task Error(string error)
        {
            if (_logs == null || !_logs.Any()) return;

            foreach (var log in _logs)
            {
                await log.Error(error);
            }
        }

        public async Task Info(string message)
        {
            if (_logs == null || !_logs.Any()) return;

            foreach (var log in _logs)
            {
                await log.Info(message);
            }
        }

        public async Task Warn(string message)
        {
            if (_logs == null || !_logs.Any()) return;

            foreach (var log in _logs)
            {
                await log.Warn(message);
            }
        }
    }
}
