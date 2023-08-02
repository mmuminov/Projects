using EmailTemplates_T;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//EmailTemplateService service dan foydalaning

//unda quyidagi data member lar bo'lsin

//- Templates - email shablonlari kolleksiyasi, buning uchun EmailTemplates modeli ishlating ( subject, content = property)

//unda quyidagi methodlar bo'lsin

//- Add ( subject, content ) -email shablonini validate qilib, kolleksiyaga qo'shsin
//- GetRegistrationTemplate ( string username ) -shablonlar orasidan ro'yxatdan o'tganlik shablonini olib, message ga aylantirib jo'natsin
//- GetAccountBlockedTemplate ( string username ) -shablonlar orasidan akkount bloklanganlik shablonini olib, message ga aylantirib jo'natsin

//MessageConstants - static modelda quyidagi tokenlar konstanta holatida saqlansin

//- UserToken - {{UserToken}}
//-EmailTemplateService dan object yarating, 2 ta template qo'shing
//- ro'yxatdan o'tganlik va akkount bloklanganlik shablonlarini kerakli methodlar orqali olib, ekranga chiqaring


//Example

//Subject : Account Registration
//Content : Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi

//Subject : Account Blocked
//Content :  Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi

//N17-T2

//Shape abstract modelidan foydalaning

//unda quyidagi abstract methodlar bo’lsin

//- CalculateShape - double tipida yuzani hisoblasin

//Circle sealed modelidan foydalaning -Shape modelidan inheritance olgan bo’lsin

//unda quyidagi konstruktorlar bo’lsin

//- Circle ( radius )

//unda quyidagi methodlarni override qiling

//- CalculateShape


namespace EmailTemplates_T
{
    internal class Template
    {
        public string Subject { get; set; }
        public string Content { get; set; }

        public Template(string subject, string content)
        {
            Subject = subject;
            Content = content;
        }
    }

    public class EmailService
    {
        private List<Template> templates = new List<Template>();

        public void Add(string subject, string content)
        {
            if(!string.IsNullOrWhiteSpace(subject))
            {
                templates.Add(new Template ( subject,content ));
            }
        }

        public string GetRegistrationTemplate(string username)
        {
            foreach(Template template in templates)
            {
                template.Subject.Equals("Account Registration");
                template.Content.Replace(MessageConstants.UserToken, username);
            }
            return "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi\r\n";
        }

        public string GetAccountBlockedTemplate(string username)
        {
            foreach (Template template in templates)
            {
                template.Subject.Equals("Account Blocked");
                template.Content.Replace(MessageConstants.UserToken, username);
            }
            return "Hurmatli { { User} }, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi";
        }
    }
}





public static class MessageConstants
{
    public const string UserToken = "{{UserToken}}";
}