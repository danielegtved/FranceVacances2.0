using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances2._0
{
    class search
    {
        private Cabin cabin;
        ListOfCabins listOfCabins = new ListOfCabins();

        private string _searchBar;
        private string _constantSearch = "search";

        private void Search()
        {

        }

        private void Compare()
        {
            List<Object> ValidCabins = new List<object>();
            //foreach (var  in listOfCabins.cabins)
            //{
                
            //}
            for (int i = 0; i < listOfCabins.cabins.Count; i++)
            {
                if (listOfCabins.cabins[i]._size == size) //attribut size som bliver ændret gennem knapper / dropdownbar
                {
                    ValidCabins.Add(listOfCabins.cabins[i]);
                }
            }

        }
    }
}
