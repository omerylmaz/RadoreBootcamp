using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.IkinciYontemFactory
{
    public class Logger
    {
        public ILogHandler _logHandler;

        public Logger(LogType type)
        {
            _logHandler = GetInstance(type);
        }

        public void LogKaydet(string message)
        {
            _logHandler.WriteLog(message);
        }

        private ILogHandler GetInstance(LogType logType)
        {
            switch (logType)
            {
                case LogType.Json:
                    return new JsonLogHandler();
                case LogType.Xml:
                    return new XmlLogHandler();
                case LogType.Db:
                    return new DbLogHandler();
                default:
                    throw new ArgumentException("There is no such log");
            }
        }
    }
}
