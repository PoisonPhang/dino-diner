/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private List<Button> drinks;
        private List<Button> options;
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
            drinks = new List<Button>() { BSodasaurus, BTryrannotea, BJurassicJava, BWater };
            options = new List<Button>() { BLemon, BFlavor, BDecaf, BSweet };
        }

        /// <summary>
        /// Toggles color values of drink buttons and enables options
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectSodasaurus(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BSodasaurus.ClearValue(Button.BackgroundProperty);

            foreach (Button button in options)
                button.IsEnabled = false;

            BFlavor.IsEnabled = true;

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }

        }

        /// <summary>
        /// Toggles color values of drink buttons and enables options
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectTryrannotea(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BTryrannotea.ClearValue(Button.BackgroundProperty);

            foreach (Button button in options)
                button.IsEnabled = false;

            BLemon.IsEnabled = true;
            BSweet.IsEnabled = true;

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Toggles color values of drink buttons and enables options
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectJurassicJava(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BJurassicJava.ClearValue(Button.BackgroundProperty);

            foreach (Button button in options)
                button.IsEnabled = false;

            BDecaf.IsEnabled = true;

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Toggles color values of drink buttons and enables options
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectWater(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BWater.ClearValue(Button.BackgroundProperty);

            foreach (Button button in options)
                button.IsEnabled = false;

            BLemon.IsEnabled = true;

            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton radioButton && drink != null)
            {
                drink.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), radioButton.Tag.ToString());
            }
        }

        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Water water)
            {
                water.AddLemon();
            }
            else if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.AddLemon();
            }
        }

        /// <summary>
        /// Progresses the display to FlavorSelection
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void OnMakeDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is JurassicJava jurassicJava)
            {
                jurassicJava.Decaf = true;
            }
        }

        private void OnMakeSweet(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tyrannotea)
            {
                tyrannotea.Sweet = true;
            }
        }

        private void OnSelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
