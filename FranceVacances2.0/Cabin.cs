using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class Cabin
    {
        public ListOfCabins listOfCabins = new ListOfCabins();
        public string region { get; set; }
        public double price { get; set; }
        public int amountOfRooms { get; set; }
        public string type { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public bool isOccupied { get; set; }

        public Cabin(string region, double price, int amountOfRooms, string type, bool isOccupied, DateTime checkIn, DateTime checkOut)
        {
            this.region = region;
            this.price = price;
            this.amountOfRooms = amountOfRooms;
            this.type = type;
            this.isOccupied = isOccupied;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public Cabin()
        {
        }
    }
}
