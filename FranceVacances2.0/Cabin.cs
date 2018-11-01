using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class Cabin
    {
        //public List<Cabin> _cabins = new List<Cabin>();
        public string _location { get; set; }
        public double _price { get; set; }
        public int _size { get; set; }
        public string _type { get; set; }
        public DateTime _time { get; set; }
        public bool _occupied { get; set; }

        public Cabin(string location, double price, int size, string type, DateTime time, bool occupied)
        {
            this._location = location;
            this._price = price;
            this._size = size;
            this._type = type;
            this._time = time;
            this._occupied = occupied;
        }

    }
}
