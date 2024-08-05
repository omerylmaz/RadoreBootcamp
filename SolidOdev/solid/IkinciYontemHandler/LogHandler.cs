using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.IkinciYontemFactory
{
    public interface ILogHandler
    {
        public void WriteLog(string message);
    }
    public class DbLogHandler : ILogHandler
    {
        public DbLog dbLog;
        public DbLogHandler()
        {
            dbLog = new DbLog();
        }
        public void WriteLog(string message)
        {
            dbLog.dbKayit(message);
        }
    }

    public class JsonLogHandler : ILogHandler
    {
        public JsonLog jsonLog;
        public JsonLogHandler()
        {
            jsonLog = new JsonLog();
        }
        public void WriteLog(string message)
        {
            jsonLog.JsonYaz(message);
        }
    }

    public class XmlLogHandler : ILogHandler
    {
        public XmlLog xmlLog;
        public XmlLogHandler()
        {
            xmlLog = new XmlLog();
        }
        public void WriteLog(string message)
        {
            xmlLog.xmlKayit(message);
        }
    }
}
