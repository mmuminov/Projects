//temperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
//- unda Temperature write-only parameteri bo'lsin
//- har safar set qilganda temperature list ga saqlab borilsin
//- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin

public class TemperatureSensorService
{
    private string _temperature;
    public string Temperature
    {
        set 
        { 
            _temperature = value; 
        }
    }

    public void Display(string value)
    {

    }

}





