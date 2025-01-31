﻿/* Menu.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu object containing properties for all available menu items
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// All menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots(),
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new PterodactylWings()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap())
                };
            }
        }

        /// <summary>
        /// All Entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
            }
        }

        /// <summary>
        /// All Sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots(),
                };
            }
        }

        /// <summary>
        /// All Drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// All Combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new PterodactylWings()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap())
                };
            }
        }

        public List<string> PossibleIngredients
        {
            get
            {
                List<string> ingredients = new List<string>();

                foreach(IMenuItem menuItem in AvailableMenuItems)
                {
                    foreach(string ingredient in menuItem.Ingredients)
                    {
                        if (!ingredients.Contains(ingredient))
                        {
                            ingredients.Add(ingredient);
                        }
                    }
                }

                return ingredients;
            }
        }

        /// <summary>
        /// Returns all available menu items as a string
        /// </summary>
        /// <returns>all available menu items as a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(IMenuItem menuItem in AvailableMenuItems)
            {
                sb.Append(menuItem.ToString() + "\n");
            }

            return sb.ToString();
        }
    }
}
