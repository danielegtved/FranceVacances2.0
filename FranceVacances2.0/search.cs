﻿using System;
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
            foreach (var cabin in listOfCabins.cabinsList)
            {
                if (this.cabin. == cabin.size)
                {
                    
                }
            }
            for (int i = 0; i < listOfCabins.cabinsList.Count; i++)
            {
                if (listOfCabins.cabinsList[i].size == size) //attribut size som bliver ændret gennem knapper / dropdownbar
                {
                    ValidCabins.Add(listOfCabins.cabinsList[i]);
                }
            }

        }
    }
}
