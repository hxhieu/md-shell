using System;
using System.Threading.Tasks;

namespace MedsReadyMobile.Services.Loggers
{
    public class LocalDbLog : ILog
    {
        public Task Error(Exception ex)
        {
            throw new NotImplementedException();
        }

        public Task Error(string error)
        {
            throw new NotImplementedException();
        }

        public Task Info(string message)
        {
            throw new NotImplementedException();
        }

        public Task Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
