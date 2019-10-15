/*
 * Drink.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract drink class for creating drink objects types
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem
    {
        protected List<string> ingredients = new List<string>();
        protected Size size = Size.Small;

        /// <summary>
        /// Price of the drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Calories in the drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients for the drinks
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>();
                foreach (string s in ingredients)
                {
                    i.Add(s);
                }
                return i;
            }
        }

        /// <summary>
        /// Size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// If the drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;

        public string Description => ToString();

        public abstract string[] Sepcial { get; }

        /// <summary>
        /// Removes ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
