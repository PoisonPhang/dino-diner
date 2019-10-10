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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private List<Button> drinks;
        private List<Button> options;
        public DrinkSelection()
        {
            InitializeComponent();
            drinks = new List<Button>() { BSodasaurus, BTryrannotea, BJurassicJava, BWater };
            options = new List<Button>() { BLemon, BFlavor, BDecaf, BSweet };
        }

        private void SelectSodasaurus(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BSodasaurus.Background = Brushes.Green;

            foreach (Button button in options)
                button.IsEnabled = false;

            BFlavor.IsEnabled = true;
        }

        private void SelectTryrannotea(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BTryrannotea.Background = Brushes.Green;

            foreach (Button button in options)
                button.IsEnabled = false;

            BLemon.IsEnabled = true;
            BSweet.IsEnabled = true;
        }

        private void SelectJurassicJava(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BJurassicJava.Background = Brushes.Green;

            foreach (Button button in options)
                button.IsEnabled = false;

            BDecaf.IsEnabled = true;
        }

        private void SelectWater(object sender, RoutedEventArgs e)
        {
            foreach (Button button in drinks)
                button.Background = Brushes.Gray;

            BWater.Background = Brushes.Green;

            foreach (Button button in options)
                button.IsEnabled = false;

            BLemon.IsEnabled = true;
        }
    }
}
