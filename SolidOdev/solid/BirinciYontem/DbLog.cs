
namespace SolidOdev.solid.BirinciYontem
{
    public class DbLog : ILog
    {
        public void dbKayit(string code)
        {
            Console.WriteLine(code + " db ye kaydedildi");
        }

        public void WriteLog(string message)
        {
            dbKayit(message);
        }
    }
}
