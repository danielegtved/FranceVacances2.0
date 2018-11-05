using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class Cabin
    {
        private ListOfCabins listOfCabins = new ListOfCabins();

        //public List<Cabin> _cabins = new List<Cabin>();
        public string location { get; set; }
        public double price { get; set; }
        public int size { get; set; }
        public string type { get; set; }
        public DateTime time { get; set; }
        public bool occupied { get; set; }

        public Cabin(string location, double price, int size, string type, DateTime time, bool occupied)
        {
            this.location = location;
            this.price = price;
            this.size = size;
            this.type = type;
            this.time = time;
            this.occupied = occupied;
        }

    }
}
