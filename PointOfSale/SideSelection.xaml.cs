/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;

        public SideSelection()
        {
            InitializeComponent();
        }

        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Items.Add(side);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton radioButton)
            {
                side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), radioButton.Tag.ToString());
                side.Size = DinoDiner.Menu.Size.Large;
            }
        }
    }
}
