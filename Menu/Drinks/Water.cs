/* Water.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water Drink object
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Size of this instance of Water
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// If this instance of Water contains Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Special instructions for Water
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Creates a new instance of Water
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
            Size = Size.Small;
        }

        /// <summary>
        /// Adds Lemon to this instance of Water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the size and name of water
        /// </summary>
        /// <returns>the size and name of water</returns>
        public override string ToString()
        {
            return $"{size} Water";
        }
    }
}
