using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class LoggerAdapter : IOldLogger
    {
        private NewLogger _newLogger;

        public LoggerAdapter(NewLogger newLogger)
        {
            _newLogger = newLogger;
        }

        public void Log(string message)
        {
            _newLogger.WriteLog(message);
        }
    }

    public class Application
    {
        private IOldLogger _logger;

        public Application(IOldLogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("Uruchamianie aplikacji...");
        }
    }
}
