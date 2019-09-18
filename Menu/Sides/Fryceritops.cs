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
            this.Ingredients.Add("Potato");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegtable Oil");
        }
    }
}
