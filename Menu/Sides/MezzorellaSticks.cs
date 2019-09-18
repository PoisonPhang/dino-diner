using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        public override Size Size
        {
            get => Size;
            set
            {
                this.Size = value;
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
            }
        }

        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients.AddRange(new List<string> { "Breading", "Cheese Product", "Vegetable Oil" });
        }
    }
}
