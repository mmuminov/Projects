//Registratsiyadan keyin email jo'natadigan dastur tuzing

//- email jo'natish uchun EmailService dan foydalaning 
//- unda CredentialAddress va CredentialPassword init only propertylar bo'lsin
//- methodlardan SendEmail( to ) methodi bo'lsin
//- foydalanuvchidan email addresini so'rang
//- kiritilgan email addressga "Siz muvaffaqiyatli registratsiyadan o'tdingiz" nomli email borsin

//Example 

//subject - Siz muvaffaqiyatli registratsiyadan o'tdingiz
//body - "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz"


using System.Net.Mail;
using System.Net;


var senderEmail = "sultonbek.rakhimov.recovery@gmail.com";
var senderPassword = "szabguksrhwsbtie";
var email = new EmailService(senderEmail, senderPassword);
email.SendEmail("mirzohidmuminov04@gmail.com");
public class EmailService
{
    public string CredentialAddress { get; init; } = "";
    public string CredentialPassword { get; init; }

    public EmailService(string sender, string password)
    {
        CredentialAddress = sender; 
        CredentialPassword = password;
    }
    public void SendEmail(string receiverEmail)
    {
        var mail = new MailMessage(CredentialAddress , receiverEmail);
        mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
        mail.Body = "Hurmatli {Mirzohid}, siz sistemadan muvaffaqiyatli o'tdingiz";

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }

}


//namespace N16.InitOnlyProperty
//{
//    internal class User
//    {
//        public string Name { get; init; } = "";

//        public User(string value)
//        {
//            //Name = name;
//            //Name = firstName;
//        }

//        public void DoSomething()
//        {
//            //Name = "";
//        }
//    }
//}


