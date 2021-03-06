﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FranceVacances2._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Filter filter;
        public MainPage()
        {
            this.InitializeComponent();

            Filter filter = new Filter(this);
            search search = new search();
            filter = new Filter(this);
            ListOfCabins listOfCabins = new ListOfCabins();
            listOfCabins.CreateCabinList();


        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pageFilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (pageFilterListView.Visibility != Visibility.Collapsed)
            {
                pageFilterListView.Visibility = Visibility.Collapsed;
            }
            else
            {
                pageFilterListView.Visibility = Visibility.Visible;
            }
        }
    }
}
