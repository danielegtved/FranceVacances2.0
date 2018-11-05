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

        public List<Object> CompareLogic(string region, double price, int amountOfRooms, string type, DateTime checkIn, bool isOccipied, DateTime checkOut)
        {
            List<Object> validCabins = new List<object>();
            CompareAmountOfRooms(amountOfRooms, validCabins);
            CompareRegion(region, validCabins);
            ComparePrice(price, validCabins);
            CompareType(type, validCabins);
            CompareIsOccipied(isOccipied, validCabins);
            return validCabins;
        }

        private List<Object> CompareAmountOfRooms(int amountOfRooms, List<Object> validCabins)
        {
            foreach (var individualCabin in cabin.listOfCabins.CreateeCabinsList) //Cabin klasse/ listofcabin klasse/ liste af cabins.
            {
                if (individualCabin.amountOfRooms == amountOfRooms)
                {
                    validCabins.Add(individualCabin);
                }
            }

            return validCabins;
        }
        private void CompareIsOccipied(object isoccipied, List<Object> validCabins)
        {
            throw new NotImplementedException();
        }

        private void CompareType(string type, List<Object> validCabins)
        {
            throw new NotImplementedException();
        }

        private void ComparePrice(double price, List<Object> validCabins)
        {
            throw new NotImplementedException();
        }

        private void CompareRegion(string region, List<Object> validCabins)
        {
            throw new NotImplementedException();
        }
    }
}
