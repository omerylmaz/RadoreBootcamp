GenelMudur genelMudur = new GenelMudur();
//stajyer.Maas = 45000;  //encapsulation ile dışarıdan modifiye kapalı olsun istedim
double genelMudurMaas = genelMudur.MaasAl();

Stajyer stajyer = new Stajyer();
double stajyerMaas = stajyer.MaasAl();

Mudur mudur = new Mudur();
double mudurMaas = mudur.MaasAl();

Programci programci = new Programci();
double programciMaas = programci.MaasAl();

Console.WriteLine($"Stajyer maaşı: {stajyerMaas}");
Console.WriteLine($"Genel Müdür maaşı: {genelMudurMaas}");
Console.WriteLine($"Programcı maaşı: {programciMaas}");
Console.WriteLine($"Müdür maaşı: {mudurMaas}");


public interface IYonetebilir
{
    void YoneticilikYap();
}

public abstract class Calisan
{
    public string Ad { get; set; }
    public double Maas { get; protected set; }
    public abstract double MaasAl();
}


public class GenelMudur : Calisan, IYonetebilir
{
    public override double MaasAl()
    {
        Maas = 80000;
        return Maas;
    }

    public void YoneticilikYap()
    {
        Console.WriteLine("Şirket güzel gidiyor. Hepinize zam yapacağım!!!");
    }
}

public class Mudur : Calisan, IYonetebilir
{
    public override double MaasAl()
    {
        Maas = 60000;
        return Maas;
    }
    public void YoneticilikYap()
    {
        Console.WriteLine("Performansınız çok güzel. Elinize sağlık");
    }
}

public class Programci : Calisan
{
    public override double MaasAl()
    {
        Maas = 40000;
        return Maas;
    }
}

public class Stajyer : Calisan
{
    public override double MaasAl()
    {
        Maas = 5000;
        return Maas;
    }
}