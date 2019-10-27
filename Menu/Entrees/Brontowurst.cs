/* Brontowurst.cs
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

        /// <summary>
        /// Special instructions for Brontowurst
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");

                return special.ToArray();
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the peppers from the ingredients of this instance
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the onion from the ingredients of this instance
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of Brontowurst
        /// </summary>
        /// <returns>the name of Brontowurst</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
