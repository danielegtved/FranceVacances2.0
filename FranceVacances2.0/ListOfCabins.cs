using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class ListOfCabins
    {
        public List<Cabin> cabins = new List<Cabin>();

        private void CabinList()
        {
            cabins.Add(new Cabin("baguette 1", 1099, 4, "cabin", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 2", 99, 7, "cabin", DateTime.Now, true));
            cabins.Add(new Cabin("baguette 3", 2099, 6, "cabin", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 4", 3099, 5, "apartment", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 5", 4099, 3, "cabin", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 6", 5099, 2, "apartment", DateTime.Now, true));
            cabins.Add(new Cabin("baguette 7", 6099, 1, "cabin", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 8", 7099, 78, "cabin", DateTime.Now, false));
            cabins.Add(new Cabin("baguette 9", 8099, 103, "cabin", DateTime.Now, false));

        }
    }
}
