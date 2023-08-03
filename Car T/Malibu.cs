using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_T
{
    internal class Malibu : CarModel
    {
        public int Passengers1 { get; set; }
        private readonly int _maxspeed1;
        public int MaxSpeed1 { get => _maxspeed1; }

        public Malibu(int passengers1, int maxspeed1)
        {
            Passengers1 = passengers1;
            _maxspeed1 = maxspeed1;
        }
    }
}
