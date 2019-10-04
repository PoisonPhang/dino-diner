using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new Sodasaurus(),
                    new SteakosaurusBurger(),
                    new Fryceritops()
                };
            }
        }
        List<IMenuItem> AvailableEntrees { get; }
        List<IMenuItem> AvailableSides { get; }
        List<IMenuItem> AvailableDrinks { get; }
        List<IMenuItem> AvailableCombos { get; }
    }
}
