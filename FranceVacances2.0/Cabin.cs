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
        private string _location;
        private double _price;
        private int _size;
        private string _type;
        private DateTime _time;
        private bool _occupied;

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
