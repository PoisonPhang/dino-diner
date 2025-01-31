﻿/* Fryceritops.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Fryceritops side menu item
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Implemetation of the Size property of Fryceritops
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    default:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Special instructions for Fryceritops
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0]; 
            }
        }

        /// <summary>
        /// Constructs a new Fryceritops
        /// </summary>
        public Fryceritops()
        {
            size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;
            this.ingredients.AddRange(new List<string> { "Potato", "Salt", "Vegetable Oil" });
        }

        /// <summary>
        /// Returns the size and name of Fryceritops as a string
        /// </summary>
        /// <returns>the size and name of Fryceritops as a string</returns>
        public override string ToString()
        {
            return $"{size} Fryceritops";
        }
    }
}
