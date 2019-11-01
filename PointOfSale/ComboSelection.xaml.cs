/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        CretaceousCombo combo;
        /// <summary>
        /// Constructs a new instance of ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void OnBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeBrontowurst(combo));
            }
        }

        private void OnDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(combo));
            }
        }

        private void OnSteakosaurusCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosarusBurger(combo));
            }
        }

        private void OnTKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeTKingBurger(combo));
            }
        }

        private void OnPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
            }
        }

        private void OnPterdactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeVelociWrap(combo));
            }
        }
    }
}
