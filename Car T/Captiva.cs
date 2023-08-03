using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_T
{
    internal class Captiva : CarModel
    {
        public int Passengers { get; set; }
        private readonly int _maxspeed;
        public int MaxSpeed { get => _maxspeed; }
    
        public Captiva(int passengers, int maxspeed, string brand, int year, string color)
            : base(passengers, maxspeed)
        {
            Passengers = passengers;
            _maxspeed = maxspeed;
        }
    }

}
