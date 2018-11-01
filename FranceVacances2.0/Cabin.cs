using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class Cabin
    {
        public List<Cabin> _cabins = new List<Cabin>();

        public List<Cabin> Cabins
        {
            get { return _cabins; }
            set { _cabins = value; }
        }
    }
}
