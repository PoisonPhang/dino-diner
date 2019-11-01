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
        private CretaceousCombo combo;

        /// <summary>
        /// Constructs a new instance of SideSelection
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Constructs a new instance of SideSelection with an existing side
        /// </summary>
        /// <param name="side">Existing side to edit</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();

                if (combo != null)
                    combo.Side = side;
                else
                    order.Add(side);
            }
        }

        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();

                if (combo != null)
                    combo.Side = side;
                else
                    order.Add(side);
            }
        }

        private void OnSelectMMC(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();

                if (combo != null)
                    combo.Side = side;
                else
                    order.Add(side);
            }
        }

        private void OnSelectMozzerellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();

                if (combo != null)
                    combo.Side = side;
                else
                    order.Add(side);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton radioButton && side != null)
            {
                side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), radioButton.Tag.ToString());

                if (combo != null)
                    NavigationService.Navigate(new CustomizeCombo(combo));
                else
                    NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
