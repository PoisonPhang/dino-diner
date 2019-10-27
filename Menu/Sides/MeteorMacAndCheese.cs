/* MeteorMacAndCheese.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu item for the Meteor Mac and Cheese side
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Size property of the MeteorMacAndCheese
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
                        this.Calories = 520;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    default:
                        this.Price = 0.99;
                        this.Calories = 420;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Special instructions for MeteorMacAndCheese
        /// </summary>
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        /// <summary>
        /// Constructs a new MeteorMacAndCheese
        /// </summary>
        public MeteorMacAndCheese()
        {
            size = Size.Small;
            this.Price = 0.99;
            this.Calories = 420;
            this.ingredients.AddRange(new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" });
        }

        /// <summary>
        /// Returns the size and name of Meteor Mac and Cheese
        /// </summary>
        /// <returns>the size and name of Meteor Mac and Cheese</returns>
        public override string ToString()
        {
            return $"{size} Meteor Mac and Cheese";
        }
    }
}
