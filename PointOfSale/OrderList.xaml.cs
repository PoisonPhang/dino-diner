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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public NavigationService NavigationService { get; set; }

        public OrderList()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(Object sender, EventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
        }

        private void RemoveItem(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order && sender is Button button && button.DataContext is IOrderItem item)
            {
                order.Remove(item);
            }
        }
    }
}
