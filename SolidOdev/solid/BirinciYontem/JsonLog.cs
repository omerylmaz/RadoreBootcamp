using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.BirinciYontem
{
    public class JsonLog : ILog
    {
        public void JsonYaz(string veri)
        {
            Console.WriteLine(veri + " json a kaydedildi");
        }

        public void WriteLog(string message)
        {
            JsonYaz(message);
        }
    }
}
