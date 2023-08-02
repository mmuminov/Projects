
//temperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
//- unda Temperature write-only parameteri bo'lsin
//- har safar set qilganda temperature list ga saqlab borilsin
//- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin


//var emails = new TemperatureSensorService("Asilbek", Console.ReadLine());
//Console.WriteLine(emails.Fulname);


var temperatures = new TemperatureSensorService();
temperatures.Display(Convert.ToDouble(Console.ReadLine()));

public class TemperatureSensorService
{
    private double _temperature;
    public double Temperature 
    { 
        set
        {
            _temperature = value;
        }
    }
    
    public double Display(double temperature)
    {
        List<TemperatureSensorService> list = new List<TemperatureSensorService>();

        list.Add(new TemperatureSensorService());
        return temperature;
    }






    //private string _name;

    //public string Name
    //{
    //    set
    //    {
    //         _name = value;
    //    }
    //}

    ////public TemperatureSensorService(string name)
    ////{
    ////    Name = name;
    ////}

    //private readonly string _fullname;
    //public string Fulname { get => _fullname; }

    //public TemperatureSensorService(string fullname, string name)
    //{
    //    _fullname = fullname;
    //    _name = name;
    //}

}





