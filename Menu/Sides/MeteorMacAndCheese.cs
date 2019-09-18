using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
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
            }
        }

        public MeteorMacAndCheese()
        {
            size = Size.Small;
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients.AddRange(new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" });
        }
    }
}
