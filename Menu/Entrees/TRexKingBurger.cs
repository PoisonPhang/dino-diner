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
        }

        /// <summary>
        /// Removes the lettuc from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Removes the tomato from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }

        /// <summary>
        /// Removes the onoin from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
        }

        /// <summary>
        /// Removes the pickle from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }

        /// <summary>
        /// Removes the mayo from this instance of the T-Rex King Burger
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
