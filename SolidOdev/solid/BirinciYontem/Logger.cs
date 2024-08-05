using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.BirinciYontem
{
    public class Logger
    {
        public ILog _log;

        public Logger(LogType type)
        {
            CreateInstance(type);
        }

        public void LogKaydet(string message)
        {
            _log.WriteLog(message);
        }

        private void CreateInstance(LogType type)
        {
            switch (type)
            {
                case LogType.Xml:
                    _log = new XmlLog();
                    break;
                case LogType.Db:
                    _log = new DbLog();
                    break;
                case LogType.Json:
                    _log = new JsonLog();
                    break;
            }
        }
    }
}
