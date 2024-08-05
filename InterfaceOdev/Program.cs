//interface için
//bmw           mercedes 			porche
//bmw havada uçuyor		mercedes havada uçuyor 		porche çok hızlı gidiyor
//bmw denizde yüzüyor		mercedes denizde yüzüyor	
//bmw çok hızlı gidiyor

// bu mesajları interface yada interface leri kullanarak ekrana nasıl yazdırırdınız.

//abstract class

// bmw 60.0 Litre       mercedes 70.0 litre		porche 80.0 litre

// toplamda ne kadar benzin harcıyorlar.




BMW bmw = new BMW(60.0);
bmw.Fast();
bmw.Fly();
bmw.Swim();

Mercedes mercedes = new Mercedes(70.0);
mercedes.Fly();
mercedes.Swim();

Porsche porsche = new Porsche(80.0);
porsche.Fast();

List<Car> cars = new List<Car>() { bmw, mercedes, porsche };

double totalFuel = 0;
foreach (Car car in cars)
{
    totalFuel += car.FuelConsumption;
}
Console.WriteLine();
Console.WriteLine($"Toplam yakıt tüketimi: {totalFuel} litre.");


abstract class Car
{
    public string Name { get; set; }
    public double FuelConsumption { get; set; }

    public Car(string name, double fuelConsumption)
    {
        Name = name;
        FuelConsumption = fuelConsumption;
    }
}

class BMW : Car, IFlyable, ISwimmable, IFast
{
    public BMW(double fuelConsumption) : base("BMW", fuelConsumption) { }

    public void Fast()
    {
        Console.WriteLine($"{Name} çok hızlı gidiyor.");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} havada uçuyor.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} denizde yüzüyor.");
    }
}

class Mercedes : Car, IFlyable, ISwimmable
{
    public Mercedes(double fuelConsumption) : base("Mercedes", fuelConsumption) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} havada uçuyor.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} denizde yüzüyor.");
    }
}

class Porsche : Car, IFast
{
    public Porsche(double fuelConsumption) : base("Porsche", fuelConsumption) { }

    public void Fast()
    {
        Console.WriteLine($"{Name} çok hızlı gidiyor.");
    }
}

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

interface IFast
{
    void Fast();
}