using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class ListOfCabins
    {
        public List<Cabin> cabinsList = new List<Cabin>();
        public void CreateCabinList()
        {
            cabinsList.Add(new Cabin("baguette 1", 1099, 4, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 2", 99, 7, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 3", 2099, 6, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 4", 3099, 5, "apartment", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 5", 4099, 3, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 6", 5099, 2, "apartment", true, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 7", 6099, 1, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 8", 7099, 78, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette 9", 8099, 103, "cabin", false, DateTime.Now, DateTime.Now));
            cabinsList.Add(new Cabin("baguette", 2.5, 3, "cabin", false, DateTime.Today, DateTime.Now));
        }
    }
}
