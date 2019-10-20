/*
 * TRexKingBurger.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu item for the T-Rex King Burger
    /// </summary>
    public class TRexKingBurger : Entree
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Ingredients of the T-Rex King Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Special instructions for TRexKingBurger
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }

        /// <summary>
        /// Removes the bun from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the lettuc from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the tomato from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the onoin from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the pickle from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the ketchup from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the mustard from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the mayo from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
