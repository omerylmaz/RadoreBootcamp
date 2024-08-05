#region Sizin Verdiğiniz Senaryo
//using SolidOdev.solid.kotu;

//XmlLog xmlLog = new XmlLog();
//DbLog dbLog = new DbLog();
//Logger logger = new Logger(dbLog, xmlLog, new JsonLog());
//logger.LogKaydet(LogType.Db, "303 nolu hata kodu oluştu");
#endregion


#region 1. Yöntem
// Bu yöntemde klasik daha basitçe yapmaya çalıştım. Dersteki öğrendiklerimiz üzerinden olabilecek en kısa yöntem olduğunu düşünerek yaptım

//using SolidOdev.solid.BirinciYontem;
//Logger loggerBirinciYontem = new Logger(LogType.Db);
//loggerBirinciYontem.LogKaydet("303 nolu hata kodu oluştu");
#endregion

#region 2. Yöntem
// Bu yönteme ihtiyaç duymamın sebebi eğer kompleks bir senaryo elimizde olursa, mesela DbLog için belki Db'ye bağlantı kurmamız gerekiyor ya da xml log
// için ayrı xml kütüphanelerinin konfigürasyonu gerekebilir. Bu sebepten dolayı uzun vadede aslında abstract factory'nin daha uygun bir çözüm olacağını
// düşündüğüm için bu yöntemi de eklemek istedim. Bu şekilde karışık konfigürasyon gerektiği durumlarda Factory sınıflar üzerinden gerekli konfigürasyon ayarlarımızı
// yapabiliriz ve uygulamanın farklı yerlerinde ihtiyaç duyulduğu zaman bu konfigürasyonları tekrarlamamıza gerek olmayacak. Aynı zamanda Single Responsibility prensibine
// bağlı kalarak her konfigürasyon için ayrı bir sınıf yaratıp konfigürasyonların sorumluluğunu o sınıflara bıraktım. Bu şekilde kompleks senaryolarda kodun
// inşası daha güvenli bir şekilde yapılıp Single Responsibility ve Open Closed prensiplerine bağlı kalmaya çalışabiliriz. Fakat bu yöntemde yine de metot içerisine
// bir farklı log mekanizması eklenmek istendiği zaman new {Logİsmi}Factory gibi bir ekleme yapacağımız için OCP'ye aykırı durum örnek verilen duruma göre az da olsa
// olabilir. Bundan dolayı aslında reflection uygulayarakta ocp'den maksimum verim alınabilir. Fakat derste öğrendiklerimizin dışında olduğu için eklemeyi uygun bulmadım.

using SolidOdev.solid.IkinciYontemFactory;

Logger logger = new Logger(LogType.Db);
logger.LogKaydet("303 nolu hata kodu oluştu");
#endregion

