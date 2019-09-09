using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Dino Nuggets entree item
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Price of the Dino Nuggets
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Colories of the Dino Nuggets
        /// </summary>
        public uint Colories { get; set; }

        /// <summary>
        /// Ingredients of the Dino Nuggets
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 6; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new DinoNugget
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Colories = 6 * 59;
        }

        /// <summary>
        /// Adds a Dino Nugget to this instance
        /// </summary>
        public void AddNugget()
        {
            Ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Colories += 59;
        }
    }
}
