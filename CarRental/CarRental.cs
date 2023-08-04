using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_HT
{
    internal class CarRental
    {
        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public double Balance { get; set; }
        public string BrandName { get; set; }
        public Guid Id { get; set; }

        List <CarRental> Cars = new List<CarRental> ();

        public void ADD()
        {
            Cars.Add(this);
        }

        public void Rent(string brandname)
        {
            for(int i = 0; i < Cars.Count; i++)
            {

            }
        }

    }
}
