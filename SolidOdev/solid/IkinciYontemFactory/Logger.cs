using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.IkinciYontemFactory
{
    public class Logger
    {
        public ILogFactory _logFactory;

        public Logger(LogType type)
        {
            _logFactory = GetInstance(type);
        }

        public void LogKaydet(string message)
        {
            _logFactory.WriteLog(message);
        }

        private ILogFactory GetInstance(LogType logType)
        {
            switch (logType)
            {
                case LogType.Json:
                    return new JsonLogFactory();
                case LogType.Xml:
                    return new XmlLogFactory();
                case LogType.Db:
                    return new DbLogFactory();
                default:
                    throw new ArgumentException("There is no such log");
            }
        }
    }
}
