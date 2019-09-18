using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        public override Size Size
        {
            get => Size;
            set
            {
                this.Size = value;
                if (value == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 520;
                } else if (value == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 490;
                } else
                {
                    this.Price = 0.99;
                    this.Calories = 420;
                }
            }
        }

        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients.AddRange(new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" });
        }
    }
}
