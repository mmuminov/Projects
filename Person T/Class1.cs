using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// age date-of-bearth, 

namespace Person_T
{
    internal class Class1
    {
        public Guid Id { get; set; }
        public string ShortName { get; private set; }
        public string FullName { get; private set; }
        public DateTime DateOfBearh { get; init; }
        public string Details { get; set; }
        public string Address { get; set; }
        public int Money { get; set; }

        public Class1(string shortname, string fullname, DateTime dateofbearth)
        {
            Id = Guid.NewGuid();
            ShortName = shortname;
            FullName = fullname;
            DateOfBearh = dateofbearth;
        }

        public void Display()
        {
            Console.WriteLine($"{ShortName}");
            Console.WriteLine($"{FullName}");
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{DateOfBearh}");
        }
    }
}
