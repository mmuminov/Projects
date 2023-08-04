

using System.Text;

namespace People;

internal class Person
{
    private string _name { get; set; }
    private int _age { get; set; }
    private string _city { get; set; }
    // DEFAULT CONSTRUCTOR
    public Person() { }
    // PARAMETERIZED CONSTRUCTOR
    public Person(string name, int age, string city)
    {
        _name = name;
        _age = age;
        _city = city;
    }
    // COPIED CONSTRUCTOR
    public Person(Person person)
    {
        this._name = person._name;
        this._age = person._age;
        this._city = person._city;
    }
    // STATIC CONSTRUCTOR
    static Person()
    {
        Console.WriteLine("Hello world: ");
    }

    public override string ToString()
    {
        return $"Name : {_name}\nAge : {_age}\nCity : {_city}";
    }

}

