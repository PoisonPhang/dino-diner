﻿/* MainWindow.xaml.cs
 * Author: Nathan Bean
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructs a new instance of MainWindow and creates a new order as well as setting the navigation
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            OrderList.NavigationService = OrderUI.NavigationService;
        }

        private void PassDataContentToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }

        private void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
