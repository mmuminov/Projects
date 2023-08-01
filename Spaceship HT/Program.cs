
//-Spaceship modelidan foydalaning

//unda quyidagi propertylar bo'lsin
//- Name - nomi ( init-only )
//-Fuel - yoqilg'i miqdori ( read-only )
//- Speed - tezligi(read - write)
//- Trajectory - trayektoriyasi(write - only)

//- bitta object yarating, speed va trajectory ni har xil qiymatlarga o'zgartirib ekranga chiqaring


var allItems = new Spaceship("boing 747", 241_144, 180, 900);

Console.WriteLine(allItems);

public class Spaceship
{
    // read write property
    public int Speed { get; set; }

    // read only property
    // Readonly field
    private readonly double _fuel;

    // Read-only property
    public double Fuel => _fuel;

    // init only property
    public string Name { get; init; }

    public void DoSomething()
    {
        //Name = "";
    }
    
    // write only property
    private double _trajectory;
    public double Trajectory
    {
        set
        {
            _trajectory = value;
        }
    }

    public Spaceship(string name, double fuel, double traectory, double speed)
    {
        Name = name;
        _fuel = 12121;
        Trajectory = traectory;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nFuel - {Fuel}\nSpeed - 700{Speed}";
    }

}





