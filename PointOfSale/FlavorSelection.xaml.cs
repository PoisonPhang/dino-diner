/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        private void OnFlavorSelect(Object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length-1] is Sodasaurus sodasaurus)
                {
                    sodasaurus.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), button.Tag.ToString());
                    NavigationService.GoBack();
                }
            }
        }
    }
}
