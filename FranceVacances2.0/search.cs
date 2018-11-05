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

        private void CompareLogic(string region, double price, int amountOfRooms, string type, DateTime checkIn, bool isOccipied, DateTime checkOut)
        {
            List<Object> validCabins = new List<object>();
            CompareAmountOfRooms(amountOfRooms, validCabins);
            CompareRegion(region);
            ComparePrice(price);
            CompareType(type);
            CompareIsOccipied(isOccipied);
        }

        private List<Object> CompareAmountOfRoomsValidRooms(int amountOfRooms, List<Object> validCabins)
        {
            CompareAmountOfRooms(amountOfRooms);
                validCabins.Add();


            return ValidRooms;
        }
        private List<Object> CompareAmountOfRooms(int amountOfRooms, List<Object> validCabins)
        {
            foreach (var individualCabin in cabin.listOfCabins.cabinsList) //Cabin klasse/ listofcabin klasse/ liste af cabins.
            {
                if (individualCabin.amountOfRooms == amountOfRooms)
                {
                    validCabins.Add(individualCabin);
                }
            }

            return validCabins;
        }
        private void CompareIsOccipied(object isoccipied)
        {
            throw new NotImplementedException();
        }

        private void CompareType(string type)
        {
            throw new NotImplementedException();
        }

        private void ComparePrice(double price)
        {
            throw new NotImplementedException();
        }

        private void CompareRegion(string region)
        {
            throw new NotImplementedException();
        }
    }
}
