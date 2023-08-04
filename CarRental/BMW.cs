using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_HT
{
    sealed class BMW : CarRental
    {
        public string ModelName { get; set; }
        public DateTime RentPricePerHour { get; set; }

        public BMW(string modelname, DateTime rentperhour)
        {
            ModelName = modelname;
            RentPricePerHour = rentperhour;

        }
        public void Brandname(string brandname)
        {

        }
    }
}
