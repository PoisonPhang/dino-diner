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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ prehistoricPBJ;
        private CretaceousCombo combo;

        public CustomizePrehistoricPBJ(PrehistoricPBJ prehistoricPBJ)
        {
            InitializeComponent();
            this.prehistoricPBJ = prehistoricPBJ;
        }

        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.prehistoricPBJ = combo.Entree as PrehistoricPBJ;
            this.combo = combo;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            prehistoricPBJ.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            prehistoricPBJ.HoldJelly();
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
