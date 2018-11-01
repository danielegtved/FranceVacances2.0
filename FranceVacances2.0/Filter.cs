using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FranceVacances2._0
{
    class Filter
    {
        private string _location;
        private double _price;
        private int _roomSize;
        private string _type;
        private DateTime _departure, _arrival;
        private bool _avaliable;
        private MainPage _mainPage;


        public Filter(MainPage mainPage)
        {
            _mainPage = mainPage;
            createLayout(); 
        }
        //fuck

        public void createLayout()
        {
            _mainPage.pageRoomSizeComboBox.Header = "Rooms";
            for (int i = 1; i < 4; i++) _mainPage.pageRoomSizeComboBox.Items.Add(i + " room(s)");


        }
    }
}
