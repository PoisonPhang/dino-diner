﻿/* EntreeSelection.xaml.cs
 * Author: Connor Davis
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;

        /// <summary>
        /// Constructs a new instance of EntreeSelection
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeBrontowurst(entree as Brontowurst));
            }
        }

        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeDinoNuggets(entree as DinoNuggets));
            }
        }

        private void OnSelectPPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(entree as PrehistoricPBJ));
            }
        }

        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectSteakosarusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeSteakosarusBurger(entree as SteakosaurusBurger));
            }
        }

        private void OnSelectTKB(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeTKingBurger(entree as TRexKingBurger));
            }
        }

        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeVelociWrap(entree as VelociWrap));
            }
        }
    }
}
