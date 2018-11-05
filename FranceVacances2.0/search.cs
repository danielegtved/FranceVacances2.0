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

        public List<Object> CompareLogic(string region, double price, int amountOfRooms, string type, bool isOccipied, DateTime checkIn, DateTime checkOut)
        {
            List<Object> validCabins = new List<object>();
            foreach (var currentCabin in cabin.listOfCabins.cabinsList)
            {
                if (CompareIsOccipied(isOccipied, currentCabin) && CompareAmountOfRooms(amountOfRooms,currentCabin) && CompareRegion(region, currentCabin) && ComparePrice(price, currentCabin) && CompareType(type, currentCabin))
                {
                    validCabins.Add(currentCabin);
                }
            }
            return validCabins;
        }

        //private List<Object> CompareAmountOfRooms(int amountOfRooms, List<Object> validCabins)
        //{
        //    foreach (var individualCabin in cabin.listOfCabins.cabinsList) //Cabin klasse/ listofcabin klasse/ liste af cabins.
        //    {
        //        if (individualCabin.amountOfRooms == amountOfRooms)
        //        {
        //            validCabins.Add(individualCabin);
        //        }
        //    }

        //    return validCabins;
        //}

        private Boolean CompareAmountOfRooms(int AmountOfRooms, Cabin validCabin)
        {
            if (validCabin.amountOfRooms == AmountOfRooms)
            {
                return true;
            }

            return false;
        }
        private Boolean CompareIsOccipied(bool isoccipied, Cabin validCabin)
        {
            if (validCabin.isOccupied == isoccipied)
            {
                return false;
            }

            return true;
        }

        private Boolean CompareType(string type, Cabin validCabin)
        {
            if (validCabin.type == type)
            {
                return true;
            }

            return false;
        }

        private Boolean ComparePrice(double price, Cabin validCabin)
        {
            if (validCabin.price == price)
            {
                return true;
            }

            return false;
        }

        private Boolean CompareRegion(string region, Cabin validCabin)
        {
            if (validCabin.region == region)
            {
                return true;
            }

            return false;
        }
    }
}
