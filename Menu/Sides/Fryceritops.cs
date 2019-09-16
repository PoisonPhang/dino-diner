using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
            get => Size;
            set
            {
                if (value == Size.Large)
                {
                    this.Size = Size.Large;
                    this.Price = 1.95;
                    this.Calories = 480;
                }
                else if (value == Size.Medium)
                {
                    this.Size = Size.Medium;
                    this.Price = 1.45;
                    this.Calories = 365;
                } else
                {
                    this.Size = Size.Small;
                    this.Price = 0.99;
                    this.Calories = 222;
                }
            }
        }

        /// <summary>
        /// Constructs a new Fryceritops
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients.Add("Potato");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegtable Oil");
        }
    }
}
