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

        public void createLayout()
        {

            ComboBox pageRoomSizeComboBox = new ComboBox();
            pageRoomSizeComboBox.Header = "Rooms";
            for (int i = 1; i < 4; i++) pageRoomSizeComboBox.Items.Add(i + " room(s)");

            ComboBox pricesComboBox = new ComboBox();
            pricesComboBox.Header = "Price";
            for (int i = 0; i < 4000; i = i + 1000) pricesComboBox.Items.Add(i + "-" + (i+1000) + " kr.");

            _mainPage.pageFilterButton.Content = "Filter";

            _mainPage.pageFilterListView.Items.Add(pageRoomSizeComboBox);
            _mainPage.pageFilterListView.Items.Add(pricesComboBox);
            _mainPage.pageFilterListView.Items.Add("Hej");
            //_mainPage.pageFilterListView.Visibility = Visibility.Collapsed;

            //_mainPage.Filters.Header = "Filters";
            //_mainPage.Filters.PlaceholderText = "HEJ";
            //_mainPage.Filters.Items.Add(pageRoomSizeComboBox);
            //_mainPage.Filters.Items.Add(pricesComboBox);


        }
    }
}
