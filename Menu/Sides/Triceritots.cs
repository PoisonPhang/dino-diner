using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Menu item for the Triceritots side
    /// </summary>
    public class Triceritots : Side
    {
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch(value)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    default:
                        this.Price = 0.99;
                        this.Calories = 352;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructs a new Triceritots
        /// </summary>
        public Triceritots()
        {
            size = Size.Small;
            this.Price = 0.99;
            this.Calories = 352;
            this.ingredients.AddRange(new List<string> { "Potato", "Salt", "Vegetable Oil" });
        }
    }
}
