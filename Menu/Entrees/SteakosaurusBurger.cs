/*
 * SteakosaurusBurger.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu item for Steakosaurus Burger
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// The ingredients included in the Steakosarus Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new instance of the Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// Removes the bun from this instance of the Steakosaurus Burger
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the pickle from this instance of the Steakosaurus Burger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the ketchup from this instance of the Steakosaurus Burger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the mustard from this instance of the Steakosaurus Burger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
