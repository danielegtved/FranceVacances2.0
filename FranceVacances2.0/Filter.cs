using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace FranceVacances2._0
{
    class Filter
    {
        private string _location;
        private double _price;
        private int _amountOfRooms;
        private string _type;
        private DateTime _checkIn, _checkOut;
        private bool _avaliable;

        private MainPage _mainPage;


        public Filter(MainPage mainPage)
        {
            _mainPage = mainPage;
            createLayout(); 
        }

        public void createLayout()
        {
            #region componentsForListview
            ComboBox pageRoomSizeComboBox = new ComboBox();
            pageRoomSizeComboBox.Header = "Rooms";
            for (int i = 1; i < 4; i++) pageRoomSizeComboBox.Items.Add(i + " room(s)");

            ComboBox pricesComboBox = new ComboBox();
            pricesComboBox.Header = "Price";
            for (int i = 0; i < 4000; i = i + 1000) pricesComboBox.Items.Add(i + "-" + (i+1000) + " kr.");

            ComboBox typeComboBox = new ComboBox();
            typeComboBox.Header = "Type";
            typeComboBox.Items.Add("Cabin");
            typeComboBox.Items.Add("Apartment");

            ComboBox occupiedComboBox = new ComboBox();
            occupiedComboBox.Header = "Available";
            occupiedComboBox.Items.Add("Occupied");
            occupiedComboBox.Items.Add("Available");

            DatePicker checkInDatePicker = new DatePicker();
            checkInDatePicker.Header = "Check in";

            DatePicker checkOutDatePicker = new DatePicker();
            checkOutDatePicker.Header = "Check out";
            
            AutoSuggestBox regionAutoSuggestBox = new AutoSuggestBox();
            regionAutoSuggestBox.Items.Add("France");
            regionAutoSuggestBox.Items.Add("Denmark");
            #endregion

            _mainPage.pageFilterButton.Content = "Filter";

            _mainPage.pageFilterListView.Background = new SolidColorBrush(Colors.LightGray);

            _mainPage.pageFilterListView.Items.Add(pageRoomSizeComboBox);
            _mainPage.pageFilterListView.Items.Add(pricesComboBox);
            _mainPage.pageFilterListView.Items.Add(typeComboBox);
            _mainPage.pageFilterListView.Items.Add(occupiedComboBox);
            _mainPage.pageFilterListView.Items.Add(checkInDatePicker);
            _mainPage.pageFilterListView.Items.Add(checkOutDatePicker);
            _mainPage.pageFilterListView.Items.Add(regionAutoSuggestBox);
        }
    }
}
