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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets dinoNuggets;
        private CretaceousCombo combo;

        /// <summary>
        /// Constructs a new instance of CustomizeDinoNuggets with an existing DinoNuggets
        /// </summary>
        /// <param name="dinoNuggets">Existing DinoNuggets</param>
        public CustomizeDinoNuggets(DinoNuggets dinoNuggets)
        {
            InitializeComponent();
            this.dinoNuggets = dinoNuggets;
        }

        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.dinoNuggets = combo.Entree as DinoNuggets;
            this.combo = combo;
        }

        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dinoNuggets.AddNugget();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.GoBack();
            }
        }
    }
}
