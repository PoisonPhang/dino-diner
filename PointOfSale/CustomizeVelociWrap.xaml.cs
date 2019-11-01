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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap velociWrap;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructs a new instance of CustomizeVelociWrap with an existing VelociWrap
        /// </summary>
        /// <param name="velociWrap">Existing VelociWrap</param>
        public CustomizeVelociWrap(VelociWrap velociWrap)
        {
            InitializeComponent();
            this.velociWrap = velociWrap;
        }

        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.velociWrap = combo.Entree as VelociWrap;
            this.combo = combo;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            velociWrap.HoldDressing();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            velociWrap.HoldLettuce();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            velociWrap.HoldCheese();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.GoBack();
        }
    }
}
