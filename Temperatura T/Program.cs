
//temperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
//- unda Temperature write-only parameteri bo'lsin
//- har safar set qilganda temperature list ga saqlab borilsin
//- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin


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
}





