using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_T
{
    abstract class CarModel
    {
        protected string _brand { get; init; }
        protected int _year { get; init; }
        protected string _color { get; set; }

        public CarModel(string brand, int year, string color)
        {
            _brand = brand;
            _year = year;
            _color = color;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Brand : {_brand}\nYear : Color : {_color}");
        }
    }

  
}

