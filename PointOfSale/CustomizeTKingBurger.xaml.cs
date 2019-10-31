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
    /// Interaction logic for CustomizeTKingBurger.xaml
    /// </summary>
    public partial class CustomizeTKingBurger : Page
    {
        private TRexKingBurger tRexKingBurger;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructs a new instance of CustomizeTKingBurger with an existing TRexKingBurger
        /// </summary>
        /// <param name="tRexKingBurger">Existing TRexKingBurger</param>
        public CustomizeTKingBurger(TRexKingBurger tRexKingBurger)
        {
            InitializeComponent();
            this.tRexKingBurger = tRexKingBurger;
        }

        public CustomizeTKingBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.tRexKingBurger = combo.Entree as TRexKingBurger;
            this.combo = combo;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            tRexKingBurger.HoldMayo();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
