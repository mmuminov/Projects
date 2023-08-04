using People;

var person = new Person("Mirzohid", 20, "Namangan");
Console.WriteLine(person);

var person1 = new Person("Firdavs", 14, "Navoi");
Console.WriteLine(person1);

var person2 = new Person(person1);
Console.WriteLine(person2);
