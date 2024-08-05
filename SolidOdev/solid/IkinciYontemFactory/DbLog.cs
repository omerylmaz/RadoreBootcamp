
namespace SolidOdev.solid.IkinciYontemFactory
{
    public class DbLog : ILog
    {
        public void dbKayit(string code)
        {
            Console.WriteLine(code + " db ye kaydedildi");
        }
    }
}
