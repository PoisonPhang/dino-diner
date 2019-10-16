/*
 * Brontowurst.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst entree item
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Ingredients of the Brontowurst
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public override string[] Special
        {
            get
            {
                string[] special = new string[3];
                int index = 0;

                if (!bun)
                {
                    special[index] = "Hold bun";
                    index++;
                }
                if (!peppers)
                {
                    special[index] = "Hold peppers";
                    index++;
                }
                if (!onion)
                {
                    special[index] = "Hold onion";
                    index++;
                }

                return special;
            }
        }

        /// <summary>
        /// Constructs a new Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes the bun from the ingredients of this instance
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the peppers from the ingredients of this instance
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes the onion from the ingredients of this instance
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
