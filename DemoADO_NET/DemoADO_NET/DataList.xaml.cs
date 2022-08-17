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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoADO_NET
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataList : Page
    {
        public DataList()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var data = (List<Product>)e.Parameter;
            this.ProductList.ItemsSource = data;
        }

        private void ProductList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var obj = (Product)this.ProductList.SelectedItem;
            Frame.Navigate(typeof(DetailView), obj);
        }
        

        private void MenuEdit_OnClick(object sender, RoutedEventArgs e)
        {
            var data = sender as MenuFlyoutItem;
            //Get data of row selected

            Frame.Navigate(typeof(EditVIew), data);
        }

        private void MenuDel_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
