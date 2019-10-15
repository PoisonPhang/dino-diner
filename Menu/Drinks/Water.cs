/*
 * Water.cs
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
            set => size = value;
        }

        /// <summary>
        /// If this instance of Water contains Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        public override string[] Sepcial
        {
            get
            {
                string[] special = new string[2];
                int index = 0;

                if (!Ice)
                {
                    special[index] = "Hold ice";
                    index++;
                }
                if (Lemon)
                {
                    special[index] = "Add lemon";
                    index++;
                }

                return special;
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
        }

        public override string ToString()
        {
            return $"{size} Water";
        }
    }
}
