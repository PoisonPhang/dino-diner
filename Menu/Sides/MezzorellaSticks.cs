/*
 * MezzorellaSticks.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu item for the Mezzorella Sticks side
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Size property of the MezzorellaSticks
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
                        this.Calories = 720;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    default:
                        this.Price = 0.99;
                        this.Calories = 540;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Special instructions for MezzorellaSticks
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        /// <summary>
        /// Constructs a new MezzorellaSticks
        /// </summary>
        public MezzorellaSticks()
        {
            size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;
            this.ingredients.AddRange(new List<string> { "Breading", "Cheese Product", "Vegetable Oil" });
        }

        public override string ToString()
        {
            return $"{size} Mezzorella Sticks";
        }
    }
}
