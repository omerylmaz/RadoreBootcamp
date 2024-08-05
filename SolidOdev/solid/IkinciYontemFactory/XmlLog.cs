using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOdev.solid.IkinciYontemFactory
{
    public class XmlLog : ILog
    {
        public void xmlKayit(string durum)
        {
            Console.WriteLine(durum + " xml e kaydedildi");
        }
    }
}
