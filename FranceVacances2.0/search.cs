using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class search
    {
        private Cabin cabin = new Cabin();

        private string _searchBar;
        private string _constantSearch = "search";

        private void Search()
        {

        }

        private void CompareLogic(int price, int amountOfRooms, string type, DateTime checkIn, DateTime checkOut, string region)
        {
            List<Object> ValidCabins = new List<object>();
            CompareSize(amountOfRooms);
        }
        private int CompareSize(int amountOfRooms)
        {

            foreach (var individualCabin in cabin.listOfCabins.cabinsList) //Cabin klasse/ listofcabin klasse/ liste af cabins.
            {
                if (individualCabin.amountOfRooms == )
                {
                    
                }
            }
        }
    }
}
