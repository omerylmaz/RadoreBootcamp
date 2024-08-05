using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.IkinciYontemFactory
{
    public interface ILogFactory
    {
        public void WriteLog(string message);
    }
    public class DbLogFactory : ILogFactory
    {
        public DbLog dbLog;
        public DbLogFactory()
        {
            dbLog = new DbLog();
        }
        public void WriteLog(string message)
        {
            dbLog.dbKayit(message);
        }
    }

    public class JsonLogFactory : ILogFactory
    {
        public JsonLog jsonLog;
        public JsonLogFactory()
        {
            jsonLog = new JsonLog();
        }
        public void WriteLog(string message)
        {
            jsonLog.JsonYaz(message);
        }
    }

    public class XmlLogFactory : ILogFactory
    {
        public XmlLog xmlLog;
        public XmlLogFactory()
        {
            xmlLog = new XmlLog();
        }
        public void WriteLog(string message)
        {
            xmlLog.xmlKayit(message);
        }
    }
}
