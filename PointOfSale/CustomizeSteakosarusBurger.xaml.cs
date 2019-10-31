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
    /// Interaction logic for CustomizeSteakosarusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosarusBurger : Page
    {
        private SteakosaurusBurger steakosaurusBurger;

        public CustomizeSteakosarusBurger(SteakosaurusBurger steakosaurusBurger)
        {
            InitializeComponent();
            this.steakosaurusBurger = steakosaurusBurger;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            steakosaurusBurger.HoldBun();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            steakosaurusBurger.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            steakosaurusBurger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            steakosaurusBurger.HoldMustard();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
