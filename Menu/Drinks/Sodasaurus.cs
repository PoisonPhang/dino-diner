using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
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
                        this.Calories = 112;
                        break;
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                }
            }
        }
        public SodasaurusFlavor Flavor { get; set; }

        public Sodasaurus(SodasaurusFlavor flavor)
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ingredients.AddRange(new List<string> { "Water", "Natural Flavors", "Cane Sugar" });
            this.Size = Size.Small;
            this.Ice = true;
            this.Flavor = flavor;
        }
    }
}
