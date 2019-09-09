﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst entree item
    /// </summary>
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Price of the Brontowurst
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Calories of the Brontowurst
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients of the Brontowurst
        /// </summary>
        public List<string> Ingredients
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
    }
}
