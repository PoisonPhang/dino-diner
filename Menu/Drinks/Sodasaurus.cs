/*
 * Sodasaurus.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus Drink object
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Size property of the Sodasaurus instance
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                this.size = value;
                switch(value)
                {
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                }
            }
        }

        /// <summary>
        /// (SodasaurusFlavor) Flavor property of the Sodasaurus instance
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        public override string[] Special
        {
            get
            {
                string[] special = new string[1];

                if (!Ice)
                {
                    special[0] = "Hold ice";
                }

                return special;
            }
        }

        /// <summary>
        /// Constructs a new instance of Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.ingredients.AddRange(new List<string> { "Water", "Natural Flavors", "Cane Sugar" });
            this.Size = Size.Small;
            this.Ice = true;
        }

        public override string ToString()
        {
            return $"{size} {Flavor} Sodasaurus";
        }
    }
}
