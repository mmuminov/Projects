using System.Net.Mail;
using System.Text.RegularExpressions;

Console.WriteLine("Email checcer!\n\n");
Console.WriteLine("Iltimos email ni kiriting: ");
var email = Console.ReadLine();

var emailAddresRejax = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
var emailAddrePatttern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
Console.WriteLine(Regex.IsMatch(email, emailAddrePatttern));
Console.WriteLine(emailAddresRejax.IsMatch(email));





//Console.WriteLine(Regex.IsMatch(emailAddress, emailAddressPattern));
//Console.WriteLine(emailAddressRegex.IsMatch(emailAddress));


//Console.Write("Enter you email address : ");
//var emailAddress = Console.ReadLine();
//var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
//var emailAddressPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";















