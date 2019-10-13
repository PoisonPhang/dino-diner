/* MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Progresses the display to ComboSelection
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Progresses the display to EntreeSelection
        /// </summary>
        /// <param name="sender">Element</param>
        /// <param name="e">Event args</param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
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
