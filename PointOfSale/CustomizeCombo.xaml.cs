/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo cretaceousCombo;
        /// <summary>
        /// Constructs a new instance of CustomizeCombo
        /// </summary>
        public CustomizeCombo(CretaceousCombo cretaceousCombo)
        {
            InitializeComponent();
            this.cretaceousCombo = cretaceousCombo;
        }

        /// <summary>
        /// Progresses the display to DrinkSelection
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Progresses the display to SideSelection
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
