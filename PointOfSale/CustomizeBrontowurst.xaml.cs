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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst brontowurst;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructs a new instance of CustomizeBrontowurst using an existing Brontowurst
        /// </summary>
        /// <param name="brontowurst">Existing Brontowurst</param>
        public CustomizeBrontowurst(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }

        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            brontowurst = this.combo.Entree as Brontowurst;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldBun();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            } else
            {
                //NavigationService.GoBack();
            }
            
        }
    }
}
